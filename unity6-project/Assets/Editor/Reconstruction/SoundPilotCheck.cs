using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CS;
using UnityEditor;

// Verificacao do piloto: carrega sound_xml pela logica reconstruida e grava um resumo para comparar com o esperado.
public static class SoundPilotCheck
{
	[MenuItem("Arena Masters/Verificar piloto de som")]
	public static void Run()
	{
		CSLog.Init(new CSLogger());
		StringBuilder sb = new StringBuilder();
		foreach (string lang in new[] { "ko-KR", "en-US" })
		{
			XGlobal.Option = new XOption();
			XGlobal.Option.Language = lang;
			XProtoInfoManager_Sound mgr = new XProtoInfoManager_Sound();
			bool loaded = mgr.LoadFromLocalFile(new XFileLoader_UnityResource(XProtoInfoManager_Sound.ClientFilePath));
			bool cooked = mgr.Cooking(null);
			int entries = mgr.Values.Sum(l => l.Count);
			int loops = mgr.Values.Sum(l => l.Count(i => i.LoopFlag));
			List<XSoundInfo> all = mgr["BGM_All"];
			sb.AppendLine($"{lang}|loaded={loaded}|cooked={cooked}|keys={mgr.Count}|entries={entries}|loops={loops}"
				+ $"|common={mgr.CommmonSoundUIKey.Count}|lobby={mgr.LobbySoundUIKey.Count}|ingame={mgr.InGameSoundUIKey.Count}"
				+ $"|bgm_all={all.Count}|bgm_all_last_ratioSum={all[all.Count - 1].ratioSum}");
		}
		File.WriteAllText("C:/Users/felip/arena-masters-re/decomp/sound_pilot_result.txt", sb.ToString());
		UnityEngine.Debug.Log("Piloto de som:\n" + sb);
	}
}
