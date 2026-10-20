using UnityEditor;
using UnityEngine;

// Formas da mira no chao (Assets/UI/Resources/Mira, tools/gen_ui_textures.py): o jogo pinta cada forma na cor da skill
// lendo os pixels, entao elas precisam ser legiveis (Read/Write) e presas na borda (sem repetir).
public class ImportMira : AssetPostprocessor
{
	private void OnPreprocessTexture()
	{
		if (!assetPath.Replace('\\', '/').Contains("/Resources/Mira/"))
		{
			return;
		}
		TextureImporter imp = (TextureImporter)assetImporter;
		imp.isReadable = true;
		imp.wrapMode = TextureWrapMode.Clamp;
		imp.alphaIsTransparency = true;
		imp.textureCompression = TextureImporterCompression.Uncompressed;   // GetPixels32 precisa de formato sem compressao
	}
}
