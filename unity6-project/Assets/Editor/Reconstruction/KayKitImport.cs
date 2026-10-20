using UnityEditor;

// Importa os personagens KayKit (CC0) com animacao Legacy: o prototipo toca os clipes por nome, sem AnimatorController.
public class KayKitImport : AssetPostprocessor
{
	private void OnPreprocessModel()
	{
		if (!assetPath.Contains("Prototype/KayKit/Characters"))
		{
			return;
		}
		ModelImporter importer = (ModelImporter)assetImporter;
		importer.animationType = ModelImporterAnimationType.Legacy;
		importer.importAnimation = true;
		importer.materialImportMode = ModelImporterMaterialImportMode.ImportStandard;
	}

	public static void EnsureLegacy(string path)
	{
		ModelImporter importer = (ModelImporter)AssetImporter.GetAtPath(path);
		if (importer != null && importer.animationType != ModelImporterAnimationType.Legacy)
		{
			AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
		}
	}
}
