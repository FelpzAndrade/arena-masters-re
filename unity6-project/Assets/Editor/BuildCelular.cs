using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Builds de celular. Menu "Arena Masters/Celular/...":
//   Configurar Android e iOS       nome, com.filipe.arena, paisagem, IL2CPP, ARM64, nivel de qualidade "Celular" (perfil leve do URP)
//   Build and Run Android (desenv.) gera Builds/Android/ArenaMasters.apk e instala no aparelho ligado no USB (contador de FPS na tela)
//   Build Android (desenv.)        so gera o .apk
//   Gerar projeto iOS (Xcode)      Builds/iOS (abrir no Mac com o Xcode; ver CLAUDE.md)
// So a cena da luta entra no build (a lista de cenas do projeto tem as 49 cenas do jogo original e fica como esta).
public static class BuildCelular
{
	public const string Pacote = "com.filipe.arena";
	public const string Cena = "Assets/Scenes/Prototype1x1.unity";
	const string PerfilCelular = "Assets/Settings/URP_Celular.asset";
	const string NomeNivel = "Celular";

	[MenuItem("Arena Masters/Celular/Configurar Android e iOS")]
	public static void Configurar()
	{
		PlayerSettings.companyName = "Felipe";
		PlayerSettings.productName = "Arena Masters RE";
		foreach (NamedBuildTarget alvo in new[] { NamedBuildTarget.Android, NamedBuildTarget.iOS })
		{
			PlayerSettings.SetApplicationIdentifier(alvo, Pacote);
			PlayerSettings.SetScriptingBackend(alvo, ScriptingImplementation.IL2CPP);
			PlayerSettings.SetManagedStrippingLevel(alvo, ManagedStrippingLevel.Low);   // nivel baixo: o codigo decompilado usa reflexao
		}
		// paisagem (gira entre as duas paisagens, nunca em pe)
		PlayerSettings.defaultInterfaceOrientation = UIOrientation.AutoRotation;
		PlayerSettings.allowedAutorotateToPortrait = false;
		PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;
		PlayerSettings.allowedAutorotateToLandscapeLeft = true;
		PlayerSettings.allowedAutorotateToLandscapeRight = true;
		// Android: so ARM64 (exigido pela Play Store e o que os tablets atuais usam), Vulkan com GLES3 de reserva
		PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
		PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel26;
		PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
		PlayerSettings.SetGraphicsAPIs(BuildTarget.Android, new[] { GraphicsDeviceType.Vulkan, GraphicsDeviceType.OpenGLES3 });
		// iOS: area segura ja tratada no jogo (AreaSegura); sem esconder a barra de casa por padrao
		PlayerSettings.iOS.targetOSVersionString = "15.0";
		PlayerSettings.iOS.requiresFullScreen = true;
		PlayerSettings.statusBarHidden = true;
		NivelCelular();
		AssetDatabase.SaveAssets();
		Debug.Log($"[Celular] configurado: {Pacote}, paisagem, IL2CPP, ARM64, qualidade '{NomeNivel}' ({PerfilCelular})");
	}

	// perfil leve do URP: copia do perfil da arena com escala de render menor, sombra mais curta e simples
	// (sem sombra suave nem sombra das luzes extras), HDR de 32 bits, sem MSAA (a camera ja usa FXAA)
	static UniversalRenderPipelineAsset PerfilLeve()
	{
		UniversalRenderPipelineAsset baseUrp = (UniversalRenderPipelineAsset)GraphicsSettings.defaultRenderPipeline;
		if (AssetDatabase.LoadAssetAtPath<UniversalRenderPipelineAsset>(PerfilCelular) == null)
		{
			AssetDatabase.CopyAsset(AssetDatabase.GetAssetPath(baseUrp), PerfilCelular);
		}
		UniversalRenderPipelineAsset p = AssetDatabase.LoadAssetAtPath<UniversalRenderPipelineAsset>(PerfilCelular);
		p.renderScale = 0.8f;
		p.upscalingFilter = UpscalingFilterSelection.Linear;
		p.msaaSampleCount = 1;
		p.supportsHDR = true;                                   // o bloom das skills precisa de HDR
		p.hdrColorBufferPrecision = HDRColorBufferPrecision._32Bits;
		p.shadowDistance = 18f;
		p.shadowCascadeCount = 1;
		p.mainLightShadowmapResolution = 1024;
		p.maxAdditionalLightsCount = 3;                         // as 3 luzes que piscam (LuzesBraseiros)
		p.supportsCameraOpaqueTexture = false;
		p.colorGradingLutSize = 16;
		SerializedObject so = new SerializedObject(p);
		so.FindProperty("m_SoftShadowsSupported").boolValue = false;
		so.FindProperty("m_AdditionalLightShadowsSupported").boolValue = false;
		so.ApplyModifiedPropertiesWithoutUndo();
		EditorUtility.SetDirty(p);
		return p;
	}

	// o nivel "Simple" (padrao de Android e iPhone) vira "Celular" com o perfil leve
	static void NivelCelular()
	{
		UniversalRenderPipelineAsset leve = PerfilLeve();
		SerializedObject so = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/QualitySettings.asset")[0]);
		SerializedProperty niveis = so.FindProperty("m_QualitySettings");
		int indice = -1;
		for (int i = 0; i < niveis.arraySize; i++)
		{
			string nome = niveis.GetArrayElementAtIndex(i).FindPropertyRelative("name").stringValue;
			if (nome == NomeNivel || (indice < 0 && nome == "Simple"))
			{
				indice = i;
			}
		}
		SerializedProperty nivel = niveis.GetArrayElementAtIndex(indice);
		nivel.FindPropertyRelative("name").stringValue = NomeNivel;
		nivel.FindPropertyRelative("customRenderPipeline").objectReferenceValue = leve;
		nivel.FindPropertyRelative("vSyncCount").intValue = 0;        // o jogo pede 60 FPS (ContadorFPS)
		nivel.FindPropertyRelative("antiAliasing").intValue = 0;
		SerializedProperty padroes = so.FindProperty("m_PerPlatformDefaultQuality");
		for (int i = 0; i < padroes.arraySize; i++)
		{
			SerializedProperty e = padroes.GetArrayElementAtIndex(i);
			string plataforma = e.FindPropertyRelative("first").stringValue;
			if (plataforma == "Android" || plataforma == "iPhone")
			{
				e.FindPropertyRelative("second").intValue = indice;
			}
		}
		so.ApplyModifiedPropertiesWithoutUndo();
	}

	[MenuItem("Arena Masters/Celular/Build and Run Android (desenvolvimento)")]
	public static void BuildAndRunAndroid() => Android(true);

	[MenuItem("Arena Masters/Celular/Build Android (desenvolvimento)")]
	public static void BuildAndroid() => Android(false);

	public static string Android(bool instalar)
	{
		if (!BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.Android, BuildTarget.Android))
		{
			return Falha("o modulo Android nao esta instalado (Unity Hub > Installs > 6000.5.2f1 > Add modules > Android Build Support, com SDK/NDK e OpenJDK)");
		}
		Configurar();
		EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
		EditorUserBuildSettings.buildAppBundle = false;      // .apk para instalar direto (o .aab e so para a loja)
		Directory.CreateDirectory("Builds/Android");
		BuildPlayerOptions o = new BuildPlayerOptions
		{
			scenes = new[] { Cena },
			locationPathName = "Builds/Android/ArenaMasters.apk",
			target = BuildTarget.Android,
			options = BuildOptions.Development | (instalar ? BuildOptions.AutoRunPlayer : BuildOptions.None),
		};
		return Resultado(BuildPipeline.BuildPlayer(o));
	}

	[MenuItem("Arena Masters/Celular/Gerar projeto iOS (Xcode)")]
	public static string IOS()
	{
		if (!BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.iOS, BuildTarget.iOS))
		{
			return Falha("o modulo iOS nao esta instalado (Unity Hub > Add modules > iOS Build Support). O projeto Xcode pode ser gerado no Windows, mas compilar e instalar so no Mac");
		}
		Configurar();
		Directory.CreateDirectory("Builds/iOS");
		BuildPlayerOptions o = new BuildPlayerOptions { scenes = new[] { Cena }, locationPathName = "Builds/iOS", target = BuildTarget.iOS, options = BuildOptions.Development };
		return Resultado(BuildPipeline.BuildPlayer(o));
	}

	static string Resultado(UnityEditor.Build.Reporting.BuildReport r)
	{
		string s = $"[Celular] build {r.summary.result}: {r.summary.outputPath} ({r.summary.totalSize / (1024f * 1024f):0.0} MB, {r.summary.totalTime.TotalSeconds:0} s, {r.summary.totalErrors} erros)";
		Debug.Log(s);
		return s;
	}

	static string Falha(string motivo)
	{
		Debug.LogWarning("[Celular] " + motivo);
		return motivo;
	}
}
