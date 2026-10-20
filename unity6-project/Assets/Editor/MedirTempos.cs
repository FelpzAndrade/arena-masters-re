using System;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

// Mede no Console (prefixo "[Tempo]"):
//   recompilacao  do inicio da compilacao ate o editor voltar pronto (compilar + recarregar os scripts)
//   entrar no Play  do clique no Play ate o 1o quadro do jogo
// Os horarios ficam no SessionState, que sobrevive ao recarregamento dos scripts.
[InitializeOnLoad]
static class MedirTempos
{
	const string InicioCompilacao = "MedirTempos.compilacao";
	const string InicioPlay = "MedirTempos.play";

	static MedirTempos()
	{
		CompilationPipeline.compilationStarted += _ =>
		{
			if (SessionState.GetString(InicioCompilacao, "") == "")
			{
				SessionState.SetString(InicioCompilacao, DateTime.Now.Ticks.ToString());
			}
		};
		AssemblyReloadEvents.afterAssemblyReload += () =>   // na hora (o delayCall espera o editor ganhar foco)
		{
			string t = SessionState.GetString(InicioCompilacao, "");
			if (t != "")
			{
				SessionState.EraseString(InicioCompilacao);
				Debug.Log($"[Tempo] recompilacao: {Segundos(t):0.00} s");
			}
		};
		EditorApplication.playModeStateChanged += estado =>
		{
			if (estado == PlayModeStateChange.ExitingEditMode)
			{
				SessionState.SetString(InicioPlay, DateTime.Now.Ticks.ToString());
			}
			else if (estado == PlayModeStateChange.EnteredPlayMode)
			{
				string t = SessionState.GetString(InicioPlay, "");
				if (t != "")
				{
					SessionState.EraseString(InicioPlay);
					Debug.Log($"[Tempo] entrar no Play: {Segundos(t):0.00} s");
				}
			}
		};
	}

	public static double Segundos(string ticks) => (DateTime.Now.Ticks - long.Parse(ticks)) / 1e7;
}
