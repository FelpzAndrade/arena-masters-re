using System.IO;
using System.Text;
using CS;
using UnityEditor;
using UnityEngine;

// Verificacao da fatia 2: monta XGlobal.proto como o jogo (fabrica + carga local) e toca BGM_Title pelo XSoundManager.
public static class Slice2Check
{
	[MenuItem("Arena Masters/Verificar fatia 2 (som)")]
	public static void Run()
	{
		CSLog.Init(new CSLogger());
		XGlobal.Option = new XOption();
		XGlobal.Option.Language = "en-US";
		XGlobal.proto = new XProtoInfoManagers();
		XGlobal.proto.Init(new XProtoInfoFactory(), ProtoInfoFrom.Client);
		bool loaded = XGlobal.proto.LoadFromLocalFile(string.Empty);
		bool cooked = XGlobal.proto.sound.Cooking(XGlobal.proto);

		GameObject host = new GameObject("XSoundManager");
		XSoundManager sound = host.AddComponent<XSoundManager>();
		XGlobal.sound = sound;
		sound.Init();
		sound.PlayBGM_Title();
		AudioSource bgm = sound.BGMSource;

		StringBuilder sb = new StringBuilder();
		sb.Append($"loaded={loaded}|cooked={cooked}|sound_keys={XGlobal.proto.sound.Count}");
		sb.Append($"|clip={(bgm.clip != null ? bgm.clip.name : "null")}|volume={bgm.volume.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture)}|loop={bgm.loop}");
		sb.Append($"|group={(bgm.outputAudioMixerGroup != null ? bgm.outputAudioMixerGroup.name : "null")}");
		sb.Append($"|mixer={(bgm.outputAudioMixerGroup != null ? bgm.outputAudioMixerGroup.audioMixer.name : "null")}");
		sound.StopBGM();
		sound.ResumeBGM();
		sound.ClearBGM();
		sb.Append($"|cleared={(bgm.clip == null)}");
		sb.AppendLine($"|decibel_0={sound.CalcVolumToDecibel(0f)}|decibel_1={sound.CalcVolumToDecibel(1f)}");

		Object.DestroyImmediate(GameObject.Find("AudioSource"));
		Object.DestroyImmediate(GameObject.Find("SystemAudioSource"));
		Object.DestroyImmediate(host);
		File.WriteAllText("C:/Users/felip/arena-masters-re/decomp/slice2_result.txt", sb.ToString());
		Debug.Log("Fatia 2:\n" + sb);
	}
}
