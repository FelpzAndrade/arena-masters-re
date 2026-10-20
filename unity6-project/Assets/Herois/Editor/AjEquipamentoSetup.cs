using System.IO;
using UnityEditor;
using UnityEngine;

// Pecas do Aj tiradas do KayKit Character Pack: Adventurers (CC0, Kay Lousberg), que ja esta no projeto:
// o Knight.fbx traz espada, escudos e elmo como pecas rigidas presas nos ossos. Este menu copia so as pecas usadas
// para Assets/Herois/Aj/Equipamento (malha + prefab, pivo no ponto de pega) e usa o mesmo material dos herois
// (URP Lit com a textura-paleta do kit). Menu: Arena Masters/Herois/Extrair equipamento do Aj.
public static class AjEquipamentoSetup
{
	private const string Dir = "Assets/Herois/Aj/Equipamento";
	private const string Fonte = "Assets/Prototype/KayKit/Characters/Knight.fbx";
	private static readonly string[] Pecas = { "1H_Sword", "Badge_Shield", "Knight_Helmet" };
	private static readonly string[] Nomes = { "Espada", "Escudo", "Elmo" };

	[MenuItem("Arena Masters/Herois/Extrair equipamento do Aj")]
	public static void Extrair()
	{
		Directory.CreateDirectory(Dir);
		string texPath = Dir + "/knight_texture.png";
		if (!File.Exists(texPath))
		{
			AssetDatabase.CopyAsset("Assets/Prototype/KayKit/Characters/knight_texture.png", texPath);
		}
		Texture2D tex = AssetDatabase.LoadAssetAtPath<Texture2D>(texPath);
		string matPath = Dir + "/M_EquipamentoKayKit.mat";
		Material mat = AssetDatabase.LoadAssetAtPath<Material>(matPath);
		if (mat == null)
		{
			mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
			AssetDatabase.CreateAsset(mat, matPath);
		}
		mat.SetTexture("_BaseMap", tex);
		mat.mainTexture = tex;
		mat.SetFloat("_Smoothness", 0.25f);
		mat.SetFloat("_Metallic", 0f);
		EditorUtility.SetDirty(mat);

		GameObject knight = AssetDatabase.LoadAssetAtPath<GameObject>(Fonte);
		for (int i = 0; i < Pecas.Length; i++)
		{
			Transform src = null;
			foreach (Transform t in knight.GetComponentsInChildren<Transform>(true))
			{
				if (t.name == Pecas[i])
				{
					src = t;
				}
			}
			Mesh mesh = Object.Instantiate(src.GetComponent<MeshFilter>().sharedMesh);
			mesh.name = "M_" + Nomes[i];
			string meshPath = $"{Dir}/M_{Nomes[i]}.asset";
			Mesh existing = AssetDatabase.LoadAssetAtPath<Mesh>(meshPath);
			if (existing != null)
			{
				EditorUtility.CopySerialized(mesh, existing);
				mesh = existing;
			}
			else
			{
				AssetDatabase.CreateAsset(mesh, meshPath);
			}
			GameObject go = new GameObject(Nomes[i]);
			GameObject vis = new GameObject("Malha");
			vis.transform.SetParent(go.transform, false);
			vis.transform.localPosition = src.localPosition;   // mesmo deslocamento do slot do kit (pivo = mao/cabeca)
			vis.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer r = vis.AddComponent<MeshRenderer>();
			r.sharedMaterial = mat;
			PrefabUtility.SaveAsPrefabAsset(go, $"{Dir}/{Nomes[i]}.prefab");
			Object.DestroyImmediate(go);
		}
		AssetDatabase.SaveAssets();
		Debug.Log("[Aj] equipamento extraido: Espada, Escudo, Elmo em " + Dir);
	}
}
