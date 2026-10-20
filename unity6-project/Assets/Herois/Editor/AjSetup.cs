using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

// Configura o Aj (heroi de teste do Mixamo, Assets/Herois/Aj) seguindo o Docs/combate_spec.md.
// Menu: Arena Masters/Herois/Configurar Aj.
//   1. todos os FBX como Humanoid; o Aj_Idle cria o Avatar (tem o boneco) e os outros usam esse Avatar
//   2. Idle, Run e Walk em loop; golpes sem loop
//   3. em cada golpe, acha o quadro do impacto (pico de velocidade da mao direita, a da arma) e poe o evento OnImpacto
//   4. Animator Controller Aj.controller: Idle/Run/Walk por velocidade, um estado por golpe, TomarDano e Morrer
// Escreve Docs/aj_impactos.txt com o quadro do impacto de cada golpe.
public static class AjSetup
{
	private const string Dir = "Assets/Herois/Aj";
	private static readonly string[] Loops = { "Idle", "Run", "Walk" };
	private static readonly string[] Attacks = { "AtaqueBasico", "Redemoinho", "Investida", "GolpeChao" };

	[MenuItem("Arena Masters/Herois/Configurar Aj")]
	public static void Run()
	{
		string idlePath = Dir + "/Aj_Idle.fbx";
		ModelImporter idle = (ModelImporter)AssetImporter.GetAtPath(idlePath);
		idle.animationType = ModelImporterAnimationType.Human;
		idle.avatarSetup = ModelImporterAvatarSetup.CreateFromThisModel;
		SetClip(idle, "Idle", true, null);
		idle.SaveAndReimport();
		Avatar avatar = null;
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(idlePath))
		{
			if (o is Avatar a)
			{
				avatar = a;
			}
		}
		if (avatar == null || !avatar.isHuman)
		{
			Debug.LogError("[Aj] o Aj_Idle nao gerou um Avatar humanoide valido");
			return;
		}

		foreach (string action in new[] { "Run", "Walk", "AtaqueBasico", "Redemoinho", "Investida", "GolpeChao", "TomarDano", "Morrer" })
		{
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath($"{Dir}/Aj_{action}.fbx");
			imp.animationType = ModelImporterAnimationType.Human;
			imp.avatarSetup = ModelImporterAvatarSetup.CopyFromOther;
			imp.sourceAvatar = avatar;
			SetClip(imp, action, System.Array.IndexOf(Loops, action) >= 0, null);
			imp.SaveAndReimport();
		}

		// eventos OnImpacto: amostra cada golpe no boneco do Idle e acha o pico de velocidade da mao direita
		GameObject probe = (GameObject)Object.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>(idlePath));
		Animator anim = probe.GetComponent<Animator>() ?? probe.AddComponent<Animator>();
		anim.avatar = avatar;
		Transform hand = anim.GetBoneTransform(HumanBodyBones.RightHand);
		List<string> report = new List<string>();
		foreach (string action in Attacks)
		{
			string path = $"{Dir}/Aj_{action}.fbx";
			AnimationClip clip = Clip(path);
			(float t, int frame, int frames, float speed) = ImpactOf(probe, clip, hand);
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath(path);
			SetClip(imp, action, false, t / clip.length);
			imp.SaveAndReimport();
			report.Add($"Aj_{action}: impacto no quadro {frame} de {frames} ({t:0.00} s de {clip.length:0.00} s), mao a {speed:0.0} m/s");
		}
		Object.DestroyImmediate(probe);

		BuildController();
		Directory.CreateDirectory("Docs");
		File.WriteAllLines("Docs/aj_impactos.txt", report);
		AssetDatabase.SaveAssets();
		Debug.Log("[Aj] configurado:\n" + string.Join("\n", report));
	}

	private static void SetClip(ModelImporter imp, string action, bool loop, float? impact)
	{
		ModelImporterClipAnimation[] clips = imp.clipAnimations;
		if (clips == null || clips.Length == 0)
		{
			clips = imp.defaultClipAnimations;
		}
		if (clips.Length == 0)
		{
			return;
		}
		ModelImporterClipAnimation c = clips[0];
		c.name = "Aj_" + action;
		c.loopTime = loop;
		c.loopPose = loop;
		c.lockRootRotation = true;            // o jogo gira o heroi; a animacao nao
		c.lockRootHeightY = true;
		c.lockRootPositionXZ = true;          // deslocamento vem do codigo da skill (Investida/Redemoinho), nao da animacao
		c.keepOriginalOrientation = true;
		c.keepOriginalPositionY = true;
		c.keepOriginalPositionXZ = true;
		if (impact.HasValue)
		{
			c.events = new[] { new AnimationEvent { functionName = "OnImpacto", time = impact.Value } };
		}
		imp.clipAnimations = new[] { c };
	}

	private static AnimationClip Clip(string path)
	{
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(path))
		{
			if (o is AnimationClip c && !c.name.StartsWith("__preview__"))
			{
				return c;
			}
		}
		return null;
	}

	// velocidade da mao em relacao ao quadril (o corpo andar nao conta), quadro a quadro; pega o pico
	private static (float t, int frame, int frames, float speed) ImpactOf(GameObject probe, AnimationClip clip, Transform hand)
	{
		Animator anim = probe.GetComponent<Animator>();
		Transform hips = anim.GetBoneTransform(HumanBodyBones.Hips);
		int frames = Mathf.Max(2, Mathf.RoundToInt(clip.length * clip.frameRate));
		float dt = clip.length / frames;
		Vector3? prev = null;
		float best = 0f;
		int bestFrame = 0;
		AnimationMode.StartAnimationMode();
		for (int f = 0; f <= frames; f++)
		{
			AnimationMode.BeginSampling();
			AnimationMode.SampleAnimationClip(probe, clip, f * dt);
			AnimationMode.EndSampling();
			Vector3 p = hips.InverseTransformPoint(hand.position);
			if (prev.HasValue && f > frames * 0.1f)   // ignora o comeco (saida da pose de guarda)
			{
				float v = (p - prev.Value).magnitude / dt * hips.lossyScale.x;
				if (v > best)
				{
					best = v;
					bestFrame = f;
				}
			}
			prev = p;
		}
		AnimationMode.StopAnimationMode();
		return (bestFrame * dt, bestFrame, frames, best);
	}

	private static void BuildController()
	{
		string path = Dir + "/Aj.controller";
		AssetDatabase.DeleteAsset(path);
		AnimatorController ctrl = AnimatorController.CreateAnimatorControllerAtPath(path);
		ctrl.AddParameter("Velocidade", AnimatorControllerParameterType.Float);
		foreach (string a in Attacks)
		{
			ctrl.AddParameter(a, AnimatorControllerParameterType.Trigger);
		}
		ctrl.AddParameter("TomarDano", AnimatorControllerParameterType.Trigger);
		ctrl.AddParameter("Morrer", AnimatorControllerParameterType.Trigger);
		AnimatorStateMachine sm = ctrl.layers[0].stateMachine;

		// locomocao: blend por velocidade (m/s): parado, andando, correndo
		AnimatorState loco = ctrl.CreateBlendTreeInController("Locomocao", out BlendTree tree, 0);
		tree.blendParameter = "Velocidade";
		tree.useAutomaticThresholds = false;
		tree.AddChild(Clip(Dir + "/Aj_Idle.fbx"), 0f);
		tree.AddChild(Clip(Dir + "/Aj_Walk.fbx"), 1.6f);
		tree.AddChild(Clip(Dir + "/Aj_Run.fbx"), 5f);
		sm.defaultState = loco;

		foreach (string a in Attacks)
		{
			AddAction(sm, loco, a, Clip($"{Dir}/Aj_{a}.fbx"), true);
		}
		AddAction(sm, loco, "TomarDano", Clip(Dir + "/Aj_TomarDano.fbx"), true);
		AddAction(sm, loco, "Morrer", Clip(Dir + "/Aj_Morrer.fbx"), false);
	}

	// estado disparado de qualquer lugar pelo gatilho de mesmo nome; volta para a locomocao no fim
	private static void AddAction(AnimatorStateMachine sm, AnimatorState loco, string name, AnimationClip clip, bool back)
	{
		AnimatorState s = sm.AddState(name);
		s.motion = clip;
		AnimatorStateTransition t = sm.AddAnyStateTransition(s);
		t.AddCondition(AnimatorConditionMode.If, 0f, name);
		t.duration = 0.05f;
		t.canTransitionToSelf = true;
		if (back)
		{
			AnimatorStateTransition r = s.AddTransition(loco);
			r.hasExitTime = true;
			r.exitTime = 0.92f;
			r.duration = 0.12f;
		}
	}
}
