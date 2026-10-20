using System.IO;
using UnityEditor;
using UnityEngine;

// Animacoes feitas no Blender (tools/blender) para os personagens KayKit.
// O Blender exporta o esqueleto como raiz (root/hips/...), mas no modelo do Unity os ossos ficam embaixo de "Rig"
// (Rig/root/hips/...). Este conversor copia cada clipe de Prototype/KayKit/Animations/<Heroi>@<Clipe>.fbx
// para Prototype/Resources/Anim/<Clipe>.anim (Legacy) com o prefixo "Rig/"; o Fighter carrega de la
// toda animacao de skill que o modelo nao tiver.
public static class BlenderAnimImport
{
	private const string Source = "Assets/Prototype/KayKit/Animations";
	private const string Target = "Assets/Prototype/Resources/Anim";

	[MenuItem("Arena Masters/Animacoes/Converter do Blender")]
	public static void ConvertAll()
	{
		Directory.CreateDirectory(Target);
		int count = 0;
		foreach (string file in Directory.GetFiles(Source, "*@*.fbx"))
		{
			string path = file.Replace('\\', '/');
			ModelImporter imp = (ModelImporter)AssetImporter.GetAtPath(path);
			if (imp.animationType != ModelImporterAnimationType.Legacy || imp.materialImportMode != ModelImporterMaterialImportMode.None)
			{
				imp.animationType = ModelImporterAnimationType.Legacy;
				imp.importAnimation = true;
				imp.materialImportMode = ModelImporterMaterialImportMode.None;
				imp.SaveAndReimport();
			}
			foreach (Object o in AssetDatabase.LoadAllAssetsAtPath(path))
			{
				if (o is AnimationClip clip && !clip.name.StartsWith("__preview"))
				{
					Convert(clip);
					count++;
				}
			}
		}
		AssetDatabase.SaveAssets();
		Debug.Log($"[Anim] {count} animacoes do Blender convertidas para {Target}");
	}

	private static void Convert(AnimationClip src)
	{
		AnimationClip dst = new AnimationClip { name = src.name, legacy = true, frameRate = src.frameRate, wrapMode = WrapMode.Once };
		foreach (EditorCurveBinding b in AnimationUtility.GetCurveBindings(src))
		{
			if (string.IsNullOrEmpty(b.path))
			{
				continue;                  // objeto do esqueleto no Blender: no Unity o "Rig" fica parado
			}
			EditorCurveBinding nb = b;
			nb.path = "Rig/" + b.path;
			AnimationUtility.SetEditorCurve(dst, nb, AnimationUtility.GetEditorCurve(src, b));
		}
		string path = $"{Target}/{src.name}.anim";
		AnimationClip existing = AssetDatabase.LoadAssetAtPath<AnimationClip>(path);
		if (existing == null)
		{
			AssetDatabase.CreateAsset(dst, path);
		}
		else
		{
			EditorUtility.CopySerialized(dst, existing);   // mantem o GUID
		}
	}
}
