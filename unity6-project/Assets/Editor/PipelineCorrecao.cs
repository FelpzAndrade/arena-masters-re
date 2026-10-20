using UnityEditor;

// Correcao do pacote com.unity.pipeline 0.9.0-exp.1 no Unity 6000.5: ele tenta publicar o endereco do servidor
// durante o carregamento do codigo ([OnCodeLoaded]), onde o Unity 6000.5 bloqueia AssetDatabase.IsAssetImportWorkerProcess,
// e o "unity status" do Unity CLI nunca enxerga o editor. Aqui o inicio e repetido logo depois, fora do carregamento.
// Pode apagar quando uma versao nova do pacote corrigir isso.
[InitializeOnLoad]
static class PipelineCorrecao
{
	static PipelineCorrecao()
	{
		// fim do recarregamento (roda na hora; o delayCall espera o editor ganhar foco)
		AssemblyReloadEvents.afterAssemblyReload += Iniciar;
		EditorApplication.delayCall += Iniciar;   // 1a abertura do editor (sem recarregamento)
	}

	static void Iniciar()
	{
		System.Type t = System.Type.GetType("Unity.Pipeline.PipelineDescriptorPublisher, Unity.Pipeline");
		if (t == null)
		{
			return;
		}
		const System.Reflection.BindingFlags F = System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static;
		if (t.GetField("s_File", F)?.GetValue(null) != null)
		{
			return;   // ja publicou (versao do pacote sem o problema)
		}
		t.GetMethod("Start", F)?.Invoke(null, null);
	}
}
