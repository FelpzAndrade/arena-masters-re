using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

// Configura o Aj (heroi de teste do Mixamo, Assets/Herois/Aj) seguindo o Docs/combate_spec.md.
// Menu: Arena Masters/Herois/Configurar Aj.
//   1. todos os FBX como Humanoid; o Aj_Idle cria o Avatar (tem o boneco) e os outros usam esse Avatar;
//      as texturas embutidas no Aj_Idle vao para Assets/Herois/Aj/Texturas
//   2. Idle, Run e Walk em loop; golpes sem loop
//   3. impacto = pico de velocidade da mao direita em relacao ao quadril; cada golpe ganha o evento OnImpacto ali
//      - Aj_AtaqueBasico e um combo de 4 golpes: vira 4 clipes (Ataque1 a Ataque4), cortados no vale de velocidade
//        entre um pico e outro, um OnImpacto em cada
//      - Aj_Redemoinho vem "From Run": comeca no quadro 15 (agachado juntando forca), para o corte de entrada sair logo
//        e o giro vir em seguida (skill de mobilidade responde na hora); OnImpacto no corte e no giro
//   4. Animator Controller Aj.controller: locomocao por velocidade, um estado por golpe, TomarDano e Morrer
// Escreve Docs/aj_impactos.txt com o quadro do impacto de cada golpe.
public static class AjSetup
{
	private const string Dir = "Assets/Herois/Aj";
	private const int RedemoinhoInicio = 15;   // quadro (30 fps) onde o clipe do Redemoinho comeca
	private static readonly string[] Loops = { "Idle", "Run", "Walk" };
	public static readonly string[] Combo = { "Ataque1", "Ataque2", "Ataque3", "Ataque4" };
	private static readonly string[] Skills = { "Redemoinho", "Investida", "GolpeChao" };

	[MenuItem("Arena Masters/Herois/Configurar Aj")]
	public static void Run()
	{
		string idlePath = Dir + "/Aj_Idle.fbx";
		ModelImporter idle = (ModelImporter)AssetImporter.GetAtPath(idlePath);
		if (!AssetDatabase.IsValidFolder(Dir + "/Texturas"))
		{
			AssetDatabase.CreateFolder(Dir, "Texturas");
			idle.ExtractTextures(Dir + "/Texturas");
			AssetDatabase.Refresh();
		}
		idle.animationType = ModelImporterAnimationType.Human;
		idle.avatarSetup = ModelImporterAvatarSetup.CreateFromThisModel;
		idle.importCameras = false;   // o FBX do Mixamo traz uma camera ("bottom") que tapava a camera do jogo
		idle.importLights = false;
		idle.materialImportMode = ModelImporterMaterialImportMode.ImportViaMaterialDescription;
		idle.materialSearch = ModelImporterMaterialSearch.Everywhere;
		SetClips(idle, new[] { Def("Aj_Idle", 0, -1, true) });
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

		// primeiro importa tudo como Humanoid com o Avatar do Idle (clipes inteiros), depois mede e corta
		foreach (string action in new[] { "Run", "Walk", "AtaqueBasico", "Redemoinho", "Investida", "GolpeChao", "TomarDano", "Morrer" })
		{
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath($"{Dir}/Aj_{action}.fbx");
			imp.animationType = ModelImporterAnimationType.Human;
			imp.avatarSetup = ModelImporterAvatarSetup.CopyFromOther;
			imp.sourceAvatar = avatar;
			imp.materialImportMode = ModelImporterMaterialImportMode.None;
			SetClips(imp, new[] { Def("Aj_" + action, 0, -1, System.Array.IndexOf(Loops, action) >= 0) });
			imp.SaveAndReimport();
		}

		GameObject probe = (GameObject)Object.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>(idlePath));
		List<string> report = new List<string>();

		// combo: 4 picos -> 4 clipes cortados nos vales entre eles
		{
			string path = Dir + "/Aj_AtaqueBasico.fbx";
			AnimationClip clip = FirstClip(path);
			float[] v = HandSpeed(probe, clip);
			List<int> peaks = Peaks(v, 4);
			List<ModelImporterClipAnimation> defs = new List<ModelImporterClipAnimation>();
			int start = 0;
			for (int i = 0; i < peaks.Count; i++)
			{
				int end = i + 1 < peaks.Count ? Valley(v, peaks[i], peaks[i + 1]) : v.Length - 1;
				ModelImporterClipAnimation d = Def("Aj_" + Combo[i], start, end, false);
				d.events = new[] { Impact((peaks[i] - start) / (float)(end - start)) };
				defs.Add(d);
				report.Add($"Aj_{Combo[i]}: quadros {start} a {end} do Aj_AtaqueBasico, impacto no quadro {peaks[i]} ({(peaks[i] - start) / 30f:0.00} s do inicio do clipe)");
				start = end;
			}
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath(path);
			SetClips(imp, defs.ToArray());
			imp.SaveAndReimport();
		}

		foreach (string action in Skills)
		{
			string path = $"{Dir}/Aj_{action}.fbx";
			AnimationClip clip = FirstClip(path);
			float[] v = HandSpeed(probe, clip);
			int first = action == "Redemoinho" ? RedemoinhoInicio : 0;
			int last = v.Length - 1;
			List<int> peaks = action == "Redemoinho" ? Peaks(v, 2, first) : new List<int> { Peaks(v, 1, (int)(v.Length * 0.1f))[0] };
			ModelImporterClipAnimation d = Def("Aj_" + action, first, last, false);
			List<AnimationEvent> events = new List<AnimationEvent>();
			foreach (int p in peaks)
			{
				events.Add(Impact((p - first) / (float)(last - first)));
				report.Add($"Aj_{action}: impacto no quadro {p} ({(p - first) / 30f:0.00} s do inicio do clipe de {(last - first) / 30f:0.00} s)");
			}
			d.events = events.ToArray();
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath(path);
			SetClips(imp, new[] { d });
			imp.SaveAndReimport();
		}
		Object.DestroyImmediate(probe);

		BuildController();
		Directory.CreateDirectory("Docs");
		File.WriteAllLines("Docs/aj_impactos.txt", report);
		AssetDatabase.SaveAssets();
		Debug.Log("[Aj] configurado:\n" + string.Join("\n", report));
	}

	private static AnimationEvent Impact(float normalized)
	{
		return new AnimationEvent { functionName = "OnImpacto", time = Mathf.Clamp01(normalized) };
	}

	// lastFrame < 0 = ate o fim do clipe
	private static ModelImporterClipAnimation Def(string name, int firstFrame, int lastFrame, bool loop)
	{
		return new ModelImporterClipAnimation
		{
			name = name,
			firstFrame = firstFrame,
			lastFrame = lastFrame,
			loopTime = loop,
			loopPose = loop,
			lockRootRotation = true,          // o jogo gira o heroi; a animacao nao
			lockRootHeightY = true,
			// deslocamento vem do codigo da skill, nao da animacao: XZ fora da pose (false) + applyRootMotion desligado
			// = o corpo fica em cima do objeto (true assaria o andar na pose e o corpo escaparia do efeito)
			lockRootPositionXZ = false,
			keepOriginalOrientation = true,
			keepOriginalPositionY = true,
			keepOriginalPositionXZ = false,   // raiz no centro de massa: com o clipe cortado, a origem do quadro 0 deixava o corpo 1 m a frente
		};
	}

	private static void SetClips(ModelImporter imp, ModelImporterClipAnimation[] defs)
	{
		ModelImporterClipAnimation[] src = imp.defaultClipAnimations;
		if (src.Length == 0)
		{
			return;
		}
		foreach (ModelImporterClipAnimation d in defs)
		{
			d.takeName = src[0].takeName;
			if (d.lastFrame < 0)
			{
				d.firstFrame = src[0].firstFrame;
				d.lastFrame = src[0].lastFrame;
			}
		}
		imp.clipAnimations = defs;
	}

	private static AnimationClip FirstClip(string path)
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

	public static AnimationClip Clip(string fbx, string name)
	{
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(fbx))
		{
			if (o is AnimationClip c && c.name == name)
			{
				return c;
			}
		}
		return null;
	}

	// velocidade da mao direita em relacao ao quadril (o corpo andar nao conta), um valor por quadro (30 fps)
	private static float[] HandSpeed(GameObject probe, AnimationClip clip)
	{
		Animator anim = probe.GetComponent<Animator>();
		Transform hips = anim.GetBoneTransform(HumanBodyBones.Hips);
		Transform hand = anim.GetBoneTransform(HumanBodyBones.RightHand);
		int frames = Mathf.Max(2, Mathf.RoundToInt(clip.length * 30f));
		float dt = clip.length / frames;
		float[] v = new float[frames + 1];
		Vector3 prev = Vector3.zero;
		AnimationMode.StartAnimationMode();
		for (int f = 0; f <= frames; f++)
		{
			AnimationMode.BeginSampling();
			AnimationMode.SampleAnimationClip(probe, clip, f * dt);
			AnimationMode.EndSampling();
			Vector3 p = hips.InverseTransformPoint(hand.position);
			if (f > 0)
			{
				v[f] = (p - prev).magnitude / dt * hips.lossyScale.x;
			}
			prev = p;
		}
		AnimationMode.StopAnimationMode();
		return v;
	}

	// os 'count' maiores picos locais (acima de 60% do maximo), em ordem de tempo, a partir de 'from'
	private static List<int> Peaks(float[] v, int count, int from = 0)
	{
		float max = 0f;
		for (int f = from; f < v.Length; f++)
		{
			max = Mathf.Max(max, v[f]);
		}
		List<int> peaks = new List<int>();
		for (int f = Mathf.Max(2, from); f < v.Length - 2; f++)
		{
			if (v[f] > 0.6f * max && v[f] >= v[f - 1] && v[f] >= v[f + 1] && v[f] >= v[f - 2] && v[f] >= v[f + 2])
			{
				peaks.Add(f);
			}
		}
		peaks.Sort((a, b) => v[b].CompareTo(v[a]));
		if (peaks.Count > count)
		{
			peaks.RemoveRange(count, peaks.Count - count);
		}
		peaks.Sort();
		return peaks;
	}

	private static int Valley(float[] v, int a, int b)
	{
		int best = a + 1;
		for (int f = a + 1; f < b; f++)
		{
			if (v[f] < v[best])
			{
				best = f;
			}
		}
		return best;
	}

	private static void BuildController()
	{
		string path = Dir + "/Aj.controller";
		AssetDatabase.DeleteAsset(path);
		AnimatorController ctrl = AnimatorController.CreateAnimatorControllerAtPath(path);
		ctrl.AddParameter("Velocidade", AnimatorControllerParameterType.Float);
		AnimatorStateMachine sm = ctrl.layers[0].stateMachine;

		// locomocao: blend por velocidade (m/s): parado, andando, correndo
		AnimatorState loco = ctrl.CreateBlendTreeInController("Locomocao", out BlendTree tree, 0);
		tree.blendParameter = "Velocidade";
		tree.useAutomaticThresholds = false;
		tree.AddChild(Clip(Dir + "/Aj_Idle.fbx", "Aj_Idle"), 0f);
		tree.AddChild(Clip(Dir + "/Aj_Walk.fbx", "Aj_Walk"), 1.6f);
		tree.AddChild(Clip(Dir + "/Aj_Run.fbx", "Aj_Run"), 5f);
		sm.defaultState = loco;

		foreach (string a in Combo)
		{
			AddAction(ctrl, sm, loco, a, Clip(Dir + "/Aj_AtaqueBasico.fbx", "Aj_" + a), true);
		}
		foreach (string a in Skills)
		{
			AddAction(ctrl, sm, loco, a, Clip($"{Dir}/Aj_{a}.fbx", "Aj_" + a), true);
		}
		AddAction(ctrl, sm, loco, "TomarDano", Clip(Dir + "/Aj_TomarDano.fbx", "Aj_TomarDano"), true);
		AddAction(ctrl, sm, loco, "Morrer", Clip(Dir + "/Aj_Morrer.fbx", "Aj_Morrer"), false);
	}

	// estado disparado de qualquer lugar pelo gatilho de mesmo nome; volta para a locomocao no fim
	private static void AddAction(AnimatorController ctrl, AnimatorStateMachine sm, AnimatorState loco, string name, AnimationClip clip, bool back)
	{
		ctrl.AddParameter(name, AnimatorControllerParameterType.Trigger);
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
