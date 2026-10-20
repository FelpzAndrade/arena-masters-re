using System;
using System.Collections.Generic;
using System.Text;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

// Reconstruido a partir do pseudo-C (Ghidra) de libil2cpp.so.
[Token(Token = "0x2000BB3")]
public class XProtoInfoManager_Sound : Dictionary<string, List<XSoundInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4003B8C")]
	[FieldOffset(Offset = "0x0")]
	public static string ClientFilePath = "XML/sound_xml";

	[Token(Token = "0x4003B8D")]
	[FieldOffset(Offset = "0x34")]
	public List<string> CommmonSoundUIKey;

	[Token(Token = "0x4003B8E")]
	[FieldOffset(Offset = "0x38")]
	public List<string> LobbySoundUIKey;

	[Token(Token = "0x4003B8F")]
	[FieldOffset(Offset = "0x3C")]
	public List<string> InGameSoundUIKey;

	[Token(Token = "0x4003B90")]
	[FieldOffset(Offset = "0x40")]
	private bool isInitCook;

	[Token(Token = "0x60054A7")]
	[Address(RVA = "0x1C86718", Offset = "0x1C86718", VA = "0x1C86718")]
	public XProtoInfoManager_Sound()
	{
		CommmonSoundUIKey = new List<string>();
		LobbySoundUIKey = new List<string>();
		InGameSoundUIKey = new List<string>();
	}

	[Token(Token = "0x60054A9")]
	[Address(RVA = "0x1C90AB8", Offset = "0x1C90AB8", VA = "0x1C90AB8", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return from == ProtoInfoFrom.Client;
	}

	[Token(Token = "0x60054AA")]
	[Address(RVA = "0x1C90AC8", Offset = "0x1C90AC8", VA = "0x1C90AC8", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60054AB")]
	[Address(RVA = "0x1C90ACC", Offset = "0x1C90ACC", VA = "0x1C90ACC", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		if (!isInitCook)
		{
			foreach (KeyValuePair<string, List<XSoundInfo>> pair in this)
			{
				// soma acumulada de ratio por nome, usada no sorteio entre variacoes do mesmo som
				float sum = 0f;
				foreach (XSoundInfo info in pair.Value)
				{
					sum += info.ratio;
					info.ratioSum = sum;
					if (!info.Cooking())
					{
						return false;
					}
				}
			}
			isInitCook = true;
		}
		return true;
	}

	[Token(Token = "0x60054AC")]
	[Address(RVA = "0x1C90D48", Offset = "0x1C90D48", VA = "0x1C90D48")]
	public void LoadFromServer(JToken source)
	{
		throw new NotImplementedException();
	}

	[Token(Token = "0x60054AD")]
	[Address(RVA = "0x1C90DDC", Offset = "0x1C90DDC", VA = "0x1C90DDC", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		if (isInitCook && Count >= 1)
		{
			if (loader != null)
			{
				CSLog.Info("Already loaded : " + loader.Filename);
			}
			return true;
		}
		isInitCook = false;
		Clear();
		XSoundInfoXML xml = CSXMLSerialization.Deserialize<XSoundInfoXML>(loader, Encoding.UTF8);
		if (xml == null)
		{
			if (loader != null)
			{
				CSLog.Error("Load failed : " + loader.Filename);
			}
			return false;
		}
		Clear();
		if (xml.dataList != null)
		{
			foreach (XSoundInfo info in xml.dataList)
			{
				if (!ShouldAdd(info.language))
				{
					continue;
				}
				if (!TryGetValue(info.strName, out List<XSoundInfo> list))
				{
					list = new List<XSoundInfo>();
					Add(info.strName, list);
				}
				List<string> uiKeys = null;
				switch (info.trackType)
				{
					case MixerTrack.UI_COMMON:
						uiKeys = CommmonSoundUIKey;
						break;
					case MixerTrack.UI_OUTGAME:
						uiKeys = LobbySoundUIKey;
						break;
					case MixerTrack.UI_INGAME:
					case MixerTrack.VOX_SYSTEM_COMMON:
						uiKeys = InGameSoundUIKey;
						break;
				}
				uiKeys?.Add(info.strName);
				list.Add(info);
			}
		}
		if (loader != null)
		{
			CSLog.Info("Load complete : " + loader.Filename);
		}
		return true;
	}

	// Trecho inline no original: filtro vazio aceita; lista separada por virgula aceita se algum item passar.
	private bool ShouldAdd(string language)
	{
		if (string.IsNullOrEmpty(language))
		{
			return true;
		}
		if (language.Contains(","))
		{
			foreach (string code in language.Split(','))
			{
				if (CheckAddSound(code))
				{
					return true;
				}
			}
			return false;
		}
		return CheckAddSound(language);
	}

	[Token(Token = "0x60054AE")]
	[Address(RVA = "0x1C915D4", Offset = "0x1C915D4", VA = "0x1C915D4")]
	private bool CheckAddSound(string language)
	{
		// "kr" = so neste idioma; "!kr" = todos exceto este idioma
		if (!string.IsNullOrEmpty(language) && !language.Contains("!"))
		{
			if (XGlobal.Option == null)
			{
				return false;
			}
			return XGlobal.Option.Language == language;
		}
		if (string.IsNullOrEmpty(language) || language.Length <= 1)
		{
			return false;
		}
		string excluded = language.Substring(1, language.Length - 1);
		if (XGlobal.Option == null)
		{
			return false;
		}
		return XGlobal.Option.Language != excluded;
	}

	[Token(Token = "0x60054AF")]
	[Address(RVA = "0x1C918D4", Offset = "0x1C918D4", VA = "0x1C918D4")]
	public void ChangeLangaugeAndClear()
	{
		isInitCook = false;
		Clear();
	}
}
