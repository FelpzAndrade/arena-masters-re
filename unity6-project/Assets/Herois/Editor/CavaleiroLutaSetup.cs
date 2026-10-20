using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

// Cavaleiro na luta (terceiro heroi, ao lado de Axie e Spark). Menu: Arena Masters/Herois/Montar Cavaleiro para a luta.
// O Fighter toca clipes Legacy do KayKit (Animation). Os golpes do Cavaleiro sao do Mixamo (Humanoid, Assets/Herois/Aj):
// aqui eles sao "assados" no esqueleto do KayKit: o clipe Humanoid toca no Cavaleiro.fbx (Avatar) quadro a quadro e
// cada osso e gravado num clipe Legacy novo (Prototype/Resources/Anim/Cavaleiro_*.anim, que o Fighter carrega sozinho).
// O resto (tomar golpe, cair, levantar, comemorar, andar de lado) usa os clipes do proprio Knight do KayKit.
// Prefab da luta: Assets/Herois/Cavaleiro/CavaleiroLuta.prefab (Knight Legacy + pintura do Cavaleiro + componentes das skills).
public static class CavaleiroLutaSetup
{
	public const string Prefab = CavaleiroSetup.Dir + "/CavaleiroLuta.prefab";
	const string Knight = "Assets/Prototype/KayKit/Characters/Knight.fbx";
	const string Saida = "Assets/Prototype/Resources/Anim";

	// clipe do Aj -> nome do clipe assado
	static readonly (string fbx, string clip, string nome)[] Clipes =
	{
		("Aj_Idle", "Aj_Idle", "Cavaleiro_Parado"),
		("Aj_Run", "Aj_Run", "Cavaleiro_Correr"),
		("Aj_AtaqueBasico", "Aj_Ataque1", "Cavaleiro_Ataque1"),
		("Aj_AtaqueBasico", "Aj_Ataque2", "Cavaleiro_Ataque2"),
		("Aj_AtaqueBasico", "Aj_Ataque3", "Cavaleiro_Ataque3"),
		("Aj_AtaqueBasico", "Aj_Ataque4", "Cavaleiro_Ataque4"),
		("Aj_Redemoinho", "Aj_Redemoinho", "Cavaleiro_Redemoinho"),
		("Aj_GolpeChao", "Aj_GolpeChao", "Cavaleiro_GolpeChao"),
	};

	[MenuItem("Arena Masters/Herois/Montar Cavaleiro para a luta")]
	public static void Run()
	{
		Debug.Log("[Cavaleiro] " + Montar());
	}

	public static string Montar()
	{
		KayKitImport.EnsureLegacy(Knight);
		string relatorio = Assar();
		MontarPrefab();
		AssetDatabase.SaveAssets();
		return relatorio;
	}

	// ---------- clipes ----------

	static string Assar()
	{
		System.IO.Directory.CreateDirectory(Saida);
		GameObject cav = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(CavaleiroSetup.Fbx));
		// root motion LIGADO: o deslocamento do clipe vai para a raiz (que nao e gravada) e o quadril fica no lugar.
		// Desligado, o Unity soma o deslocamento no quadril e o heroi andaria sozinho dentro do clipe.
		cav.GetComponent<Animator>().applyRootMotion = true;
		Transform rig = cav.transform.Find("Rig");
		string relatorio = "";
		AnimationMode.StartAnimationMode();
		try
		{
			foreach ((string fbx, string nomeClip, string nome) in Clipes)
			{
				AnimationClip origem = Clipe($"Assets/Herois/Aj/{fbx}.fbx", nomeClip);
				if (origem == null)
				{
					relatorio += $"{nomeClip} nao achado; ";
					continue;
				}
				AnimationClip novo = new AnimationClip { name = nome, legacy = true, frameRate = origem.frameRate };
				GameObjectRecorder rec = new GameObjectRecorder(cav);
				rec.BindComponentsOfType<Transform>(rig.gameObject, true);   // so os ossos (o lugar do heroi e do Fighter)
				int quadros = Mathf.RoundToInt(origem.length * origem.frameRate);
				float dt = 1f / origem.frameRate;
				List<(float t, Vector3 pe1, Vector3 pe2)> pes = new List<(float, Vector3, Vector3)>();
				Transform peE = Osso(cav.transform, "foot.l"), peD = Osso(cav.transform, "foot.r"), quadril = Osso(cav.transform, "hips");
				List<(Vector3 p, Quaternion r)> quadris = new List<(Vector3, Quaternion)>();
				Quaternion giro0 = Quaternion.identity;
				for (int q = 0; q <= quadros; q++)
				{
					float t = Mathf.Min(q * dt, origem.length);
					AnimationMode.BeginSampling();
					AnimationMode.SampleAnimationClip(cav, origem, t);
					AnimationMode.EndSampling();
					rec.TakeSnapshot(q == 0 ? 0f : dt);
					// o giro do clipe (ex.: a volta do Redemoinho) tambem foi para a raiz: devolve so o giro ao quadril
					if (q == 0)
					{
						giro0 = cav.transform.rotation;
					}
					Quaternion giro = cav.transform.rotation * Quaternion.Inverse(giro0);
					quadris.Add((giro * quadril.localPosition, giro * quadril.localRotation));   // Rig e root (pais) ficam na pose de descanso (identidade)
					pes.Add((t, cav.transform.InverseTransformPoint(peE.position), cav.transform.InverseTransformPoint(peD.position)));
				}
				rec.SaveToClip(novo, origem.frameRate);
				rec.ResetRecording();
				Quadril(novo, "Rig/root/hips", quadris, dt);
				string caminho = $"{Saida}/{nome}.anim";
				AnimationClip velho = AssetDatabase.LoadAssetAtPath<AnimationClip>(caminho);
				if (velho != null)
				{
					EditorUtility.CopySerialized(novo, velho);
					velho.legacy = true;
					EditorUtility.SetDirty(velho);
				}
				else
				{
					AssetDatabase.CreateAsset(novo, caminho);
				}
				relatorio += $"{nome} ({quadros} quadros)";
				if (nome == "Cavaleiro_Correr")
				{
					relatorio += $" velocidade do pe de apoio {VelocidadePe(pes):0.00} m/s";
				}
				relatorio += "; ";
			}
		}
		finally
		{
			AnimationMode.StopAnimationMode();
			Object.DestroyImmediate(cav);
		}
		return relatorio;
	}

	// reescreve as curvas de posicao e rotacao do quadril (uma chave por quadro, interpolacao linear)
	static void Quadril(AnimationClip clip, string caminho, List<(Vector3 p, Quaternion r)> quadros, float dt)
	{
		for (int i = 1; i < quadros.Count; i++)
		{
			if (Quaternion.Dot(quadros[i].r, quadros[i - 1].r) < 0f)
			{
				Quaternion r = quadros[i].r;
				quadros[i] = (quadros[i].p, new Quaternion(-r.x, -r.y, -r.z, -r.w));   // mesmo hemisferio: sem giro falso entre quadros
			}
		}
		string[] nomes = { "m_LocalPosition.x", "m_LocalPosition.y", "m_LocalPosition.z", "m_LocalRotation.x", "m_LocalRotation.y", "m_LocalRotation.z", "m_LocalRotation.w" };
		for (int k = 0; k < nomes.Length; k++)
		{
			AnimationCurve curva = new AnimationCurve();
			for (int i = 0; i < quadros.Count; i++)
			{
				curva.AddKey(new Keyframe(i * dt, k < 3 ? quadros[i].p[k] : quadros[i].r[k - 3]));
			}
			for (int i = 0; i < curva.length; i++)
			{
				AnimationUtility.SetKeyLeftTangentMode(curva, i, AnimationUtility.TangentMode.Linear);
				AnimationUtility.SetKeyRightTangentMode(curva, i, AnimationUtility.TangentMode.Linear);
			}
			clip.SetCurve(caminho, typeof(Transform), nomes[k], curva);
		}
	}

	// pe de apoio: o mais baixo em cada quadro; a velocidade dele para tras e a velocidade da corrida "no lugar"
	static float VelocidadePe(List<(float t, Vector3 pe1, Vector3 pe2)> pes)
	{
		float soma = 0f, chao = float.MaxValue;
		int n = 0;
		foreach ((float t, Vector3 pe1, Vector3 pe2) p in pes)
		{
			chao = Mathf.Min(chao, p.pe1.y, p.pe2.y);   // altura do osso do pe apoiado (o osso fica acima da sola)
		}
		for (int i = 1; i < pes.Count; i++)
		{
			bool esquerdo = pes[i].pe1.y < pes[i].pe2.y;
			Vector3 a = esquerdo ? pes[i - 1].pe1 : pes[i - 1].pe2, b = esquerdo ? pes[i].pe1 : pes[i].pe2;
			float baixo = Mathf.Min(pes[i].pe1.y, pes[i].pe2.y);
			if (baixo < chao + 0.04f && pes[i].t > pes[i - 1].t)
			{
				soma += Mathf.Abs(b.z - a.z) / (pes[i].t - pes[i - 1].t);
				n++;
			}
		}
		return n > 0 ? soma / n : 0f;
	}

	static AnimationClip Clipe(string fbx, string nome)
	{
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(fbx))
		{
			if (o is AnimationClip c && c.name == nome)
			{
				return c;
			}
		}
		return null;
	}

	static Transform Osso(Transform raiz, string nome)
	{
		foreach (Transform t in raiz.GetComponentsInChildren<Transform>(true))
		{
			if (t.name == nome)
			{
				return t;
			}
		}
		return null;
	}

	// ---------- prefab ----------

	static void MontarPrefab()
	{
		GameObject go = (GameObject)PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(Knight));
		go.name = "CavaleiroLuta";
		CavaleiroSetup.Vestir(go);   // paleta azul-roxo, elmo, contorno, brilho da espada, faiscas, EspadaBrilho
		SkillEsferaGiratoria esfera = go.AddComponent<SkillEsferaGiratoria>();
		esfera.alturaCentro = 1.15f;
		esfera.escala = 1.2f;            // mesma esfera da cena de teste (heroi de ~2,4 m com o elmo)
		esfera.moverHeroi = false;       // o Fighter avanca (SkillDef.dashDistance/dashTime)
		SkillUltimateExplosao ult = go.AddComponent<SkillUltimateExplosao>();
		ult.escala = 1.2f;
		ult.moverHeroi = false;          // o Fighter avanca ate o inimigo (SkillDef.dashStop)
		ult.impactoPeloRelogio = false;  // a luta chama Impacto() quando o golpe sai
		foreach (Transform t in go.GetComponentsInChildren<Transform>(true))
		{
			if (t.name == "1H_Sword")
			{
				esfera.pontaDaLamina = t;
				ult.mao = t;             // brilho de carga da ultimate na espada
			}
		}
		PrefabUtility.SaveAsPrefabAsset(go, Prefab);
		Object.DestroyImmediate(go);
	}
}
