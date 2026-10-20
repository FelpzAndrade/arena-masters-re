using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Heroi Cavaleiro: corpo do KayKit Knight (com as pecas originais dele) tocando as animacoes do Mixamo do Aj
// por retarget Humanoid. Menu: Arena Masters/Herois/Configurar Cavaleiro.
//   - Cavaleiro.fbx (copia do Knight do kit) como Humanoid, com o mapa de ossos do KayKit feito a mao
//     (nomes "upperarm.l" etc. que o mapeamento automatico nao reconhece; sem pescoco nem dedos no rig do kit)
//   - usa o Animator Controller do Aj (os clipes Humanoid servem em qualquer Avatar)
public static class CavaleiroSetup
{
	public const string Dir = "Assets/Herois/Cavaleiro";
	public const string Fbx = Dir + "/Cavaleiro.fbx";

	private static readonly (string human, string bone)[] Mapa =
	{
		("Hips", "hips"), ("Spine", "spine"), ("Chest", "chest"), ("Head", "head"),
		("LeftUpperArm", "upperarm.l"), ("LeftLowerArm", "lowerarm.l"), ("LeftHand", "wrist.l"),
		("RightUpperArm", "upperarm.r"), ("RightLowerArm", "lowerarm.r"), ("RightHand", "wrist.r"),
		("LeftUpperLeg", "upperleg.l"), ("LeftLowerLeg", "lowerleg.l"), ("LeftFoot", "foot.l"), ("LeftToes", "toes.l"),
		("RightUpperLeg", "upperleg.r"), ("RightLowerLeg", "lowerleg.r"), ("RightFoot", "foot.r"), ("RightToes", "toes.r"),
	};

	// pecas do kit que o Cavaleiro usa; o resto (espadas e escudos extras) fica escondido
	public static readonly string[] Escondidas = { "1H_Sword_Offhand", "Rectangle_Shield", "Round_Shield", "Spike_Shield", "2H_Sword" };

	// mesmo shader dos herois da luta (URP Lit) com a paleta azul-roxo; + 2a camada de contorno (rim) leve,
	// shader ArenaMasters/VFX/Fantasma (so a borda brilha, soma luz): destaca o heroi do chao quente
	public static Material[] Materiais()
	{
		Material lit = Lit("M_Cavaleiro", "T_CavaleiroPaleta");
		string rimPath = Dir + "/M_CavaleiroContorno.mat";
		Material rim = AssetDatabase.LoadAssetAtPath<Material>(rimPath);
		if (rim == null)
		{
			rim = new Material(Shader.Find("ArenaMasters/VFX/Fantasma"));
			AssetDatabase.CreateAsset(rim, rimPath);
		}
		rim.SetColor("_Color", new Color(0.45f, 0.7f, 1.4f));
		rim.SetFloat("_Base", 0f);
		rim.SetFloat("_RimPower", 4f);
		rim.SetFloat("_Alpha", 0.22f);
		EditorUtility.SetDirty(rim);
		return new[] { lit, rim };
	}

	public static Material MaterialBoneco() => Lit("M_BonecoTreino", "T_BonecoPaleta");

	private static Material Lit(string nome, string textura)
	{
		string path = $"{Dir}/{nome}.mat";
		Material m = AssetDatabase.LoadAssetAtPath<Material>(path);
		if (m == null)
		{
			m = new Material(Shader.Find("Universal Render Pipeline/Lit"));
			AssetDatabase.CreateAsset(m, path);
		}
		Texture2D tex = AssetDatabase.LoadAssetAtPath<Texture2D>($"{Dir}/{textura}.png");
		m.SetTexture("_BaseMap", tex);
		m.mainTexture = tex;
		m.SetFloat("_Smoothness", 0.3f);
		m.SetFloat("_Metallic", 0f);
		EditorUtility.SetDirty(m);
		return m;
	}

	// pinta o Cavaleiro: todas as pecas com o Lit da paleta + contorno; elmo com blocos proprios (azul-roxo com detalhe
	// dourado); espada com a 3a camada de brilho (fio + runa), faiscas e o componente EspadaBrilho
	public static void Vestir(GameObject heroi)
	{
		EsconderExtras(heroi);
		Material[] mats = Materiais();
		foreach (Renderer r in heroi.GetComponentsInChildren<Renderer>(true))
		{
			if (r is SkinnedMeshRenderer || r is MeshRenderer)
			{
				r.sharedMaterials = mats;   // 1 submalha + 2 materiais = a malha desenha 2 vezes (Lit e contorno)
			}
			if (r.name == "Knight_Helmet")
			{
				r.GetComponent<MeshFilter>().sharedMesh = MalhaElmo(r.GetComponent<MeshFilter>().sharedMesh);
			}
			if (r.name == "1H_Sword")
			{
				r.sharedMaterials = new[] { mats[0], mats[1], AssetDatabase.LoadAssetAtPath<Material>(VfxCavaleiroBuilder.MaterialBrilho) };
				EspadaBrilho eb = heroi.GetComponent<EspadaBrilho>() ?? heroi.AddComponent<EspadaBrilho>();
				eb.lamina = r;
				eb.indiceMaterial = 2;
				if (r.transform.Find("VFX_FaiscasLamina") == null)
				{
					GameObject f = (GameObject)PrefabUtility.InstantiatePrefab(Resources.Load<GameObject>("VFX_FaiscasLamina"), r.transform);
					f.transform.localPosition = Vector3.zero;
					f.transform.localRotation = Quaternion.identity;
				}
				Transform aviso = r.transform.Find("VFX_LaminaPronta");
				if (aviso == null)
				{
					aviso = ((GameObject)PrefabUtility.InstantiatePrefab(Resources.Load<GameObject>("VFX_LaminaPronta"), r.transform)).transform;
					aviso.localPosition = Vector3.zero;
					aviso.localRotation = Quaternion.identity;
				}
				aviso.gameObject.SetActive(false);
				eb.avisoPronta = aviso.gameObject;
			}
		}
	}

	// ponta da lamina e rastro na espada do proprio modelo, na cor do brilho
	public static Equipamento Armar(GameObject heroi)
	{
		Equipamento eq = heroi.GetComponent<Equipamento>() ?? heroi.AddComponent<Equipamento>();
		eq.armaDoModelo = "1H_Sword";
		eq.pontaDoModelo = new Vector3(0f, 1.38f, 0f);
		eq.corRastro = VfxCavaleiroBuilder.Cor * 0.45f;   // mesma cor da emissao, um pouco mais fraca (o rastro e largo)
		eq.larguraRastro = 0.24f;
		return eq;
	}

	// copia da malha do elmo com os blocos trocados (o elmo divide os blocos de aco com o corpo; assim so ele muda):
	// aco principal (3,0) -> bloco livre (0,3), pintado de azul-roxo; aco das faixas (7,0) -> dourado (4,1)
	private static Mesh MalhaElmo(Mesh original)
	{
		string path = Dir + "/Elmo_Cavaleiro.asset";
		Mesh m = AssetDatabase.LoadAssetAtPath<Mesh>(path);
		if (m != null)
		{
			return m;
		}
		m = Object.Instantiate(original);
		Vector2[] uv = m.uv;
		for (int i = 0; i < uv.Length; i++)
		{
			int cx = Mathf.FloorToInt(uv[i].x * 8f), cy = Mathf.FloorToInt((1f - uv[i].y) * 4f);
			(int x, int y) novo = (cx, cy) == (3, 0) ? (0, 3) : (cx, cy) == (7, 0) ? (4, 1) : (cx, cy);
			uv[i] += new Vector2((novo.x - cx) / 8f, -(novo.y - cy) / 4f);
		}
		m.uv = uv;
		AssetDatabase.CreateAsset(m, path);
		return m;
	}

	public static void EsconderExtras(GameObject heroi)
	{
		foreach (Transform t in heroi.GetComponentsInChildren<Transform>(true))
		{
			if (System.Array.IndexOf(Escondidas, t.name) >= 0)
			{
				t.gameObject.SetActive(false);
			}
		}
	}

	// folha de poses (de cima, de lado e de frente) para conferir o retarget
	public static string Previa(string nome, List<(string fbx, string clip, float t)> poses)
	{
		return EquipamentoPrevia.Folha(AssetDatabase.LoadAssetAtPath<GameObject>(Fbx), poses, nome, Vestir);
	}

	[MenuItem("Arena Masters/Herois/Configurar Cavaleiro")]
	public static void Run()
	{
		ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath(Fbx);
		imp.animationType = ModelImporterAnimationType.Human;
		imp.avatarSetup = ModelImporterAvatarSetup.CreateFromThisModel;
		imp.importAnimation = false;     // o kit traz as animacoes dele embutidas: aqui so o corpo
		imp.importCameras = false;
		imp.importLights = false;
		imp.materialImportMode = ModelImporterMaterialImportMode.None;

		// esqueleto na pose de descanso do arquivo (T-pose do kit)
		GameObject model = AssetDatabase.LoadAssetAtPath<GameObject>(Fbx);
		List<SkeletonBone> skel = new List<SkeletonBone>();
		foreach (Transform t in model.GetComponentsInChildren<Transform>(true))
		{
			skel.Add(new SkeletonBone { name = t.name, position = t.localPosition, rotation = t.localRotation, scale = t.localScale });
		}
		List<HumanBone> human = new List<HumanBone>();
		foreach ((string h, string b) in Mapa)
		{
			HumanBone hb = new HumanBone { humanName = h, boneName = b };
			hb.limit.useDefaultValues = true;
			human.Add(hb);
		}
		HumanDescription d = imp.humanDescription;
		d.human = human.ToArray();
		d.skeleton = skel.ToArray();
		d.upperArmTwist = 0.5f;
		d.lowerArmTwist = 0.5f;
		d.upperLegTwist = 0.5f;
		d.lowerLegTwist = 0.5f;
		d.armStretch = 0.05f;
		d.legStretch = 0.05f;
		d.feetSpacing = 0f;
		d.hasTranslationDoF = false;
		imp.humanDescription = d;
		imp.SaveAndReimport();

		Avatar avatar = null;
		foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(Fbx))
		{
			if (o is Avatar a)
			{
				avatar = a;
			}
		}
		Debug.Log("[Cavaleiro] avatar " + (avatar != null && avatar.isValid && avatar.isHuman ? "humanoide valido" : "INVALIDO"));
	}
}
