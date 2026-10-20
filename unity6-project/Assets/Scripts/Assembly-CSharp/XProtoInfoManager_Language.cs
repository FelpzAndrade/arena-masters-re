using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000667")]
public class XProtoInfoManager_Language : Dictionary<string, XLanguageInfo>, IGetLocaleInfo, CSProtoInfoManagerBase
{
	[Token(Token = "0x2000668")]
	private sealed class _003CGetLanguageInfoByChannelLanguageName_003Ec__AnonStorey12A
	{
		[Token(Token = "0x4001EAA")]
		[FieldOffset(Offset = "0x8")]
		internal string strChannelLang;

		[Token(Token = "0x6003668")]
		[Address(RVA = "0x1C8D96C", Offset = "0x1C8D96C", VA = "0x1C8D96C")]
		public _003CGetLanguageInfoByChannelLanguageName_003Ec__AnonStorey12A()
		{
		}

		[Token(Token = "0x6003669")]
		[Address(RVA = "0x1C8E3D8", Offset = "0x1C8E3D8", VA = "0x1C8E3D8")]
		internal bool _003C_003Em__181(XLanguageInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001EA8")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XLanguageInfo, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4001EA9")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XLanguageInfo, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6003657")]
	[Address(RVA = "0x1C8642C", Offset = "0x1C8642C", VA = "0x1C8642C")]
	public XProtoInfoManager_Language()
	{
	}

	[Token(Token = "0x6003658")]
	[Address(RVA = "0x1C8CF88", Offset = "0x1C8CF88", VA = "0x1C8CF88", Slot = "42")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6003659")]
	[Address(RVA = "0x1C8CF98", Offset = "0x1C8CF98", VA = "0x1C8CF98", Slot = "44")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x600365A")]
	[Address(RVA = "0x1C8CF9C", Offset = "0x1C8CF9C", VA = "0x1C8CF9C", Slot = "43")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x600365B")]
	[Address(RVA = "0x1C8D218", Offset = "0x1C8D218", VA = "0x1C8D218", Slot = "45")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x600365C")]
	[Address(RVA = "0x1C8D768", Offset = "0x1C8D768", VA = "0x1C8D768")]
	public XLanguageInfo GetLanguageInfo(string strLanguage)
	{
		return null;
	}

	[Token(Token = "0x600365D")]
	[Address(RVA = "0x1C8D864", Offset = "0x1C8D864", VA = "0x1C8D864")]
	public XLanguageInfo GetLanguageInfoByChannelLanguageName(string strChannelLang)
	{
		return null;
	}

	[Token(Token = "0x600365E")]
	[Address(RVA = "0x1C8DB3C", Offset = "0x1C8DB3C", VA = "0x1C8DB3C")]
	public XLanguageInfo GetDefaultLanguageInfo()
	{
		return null;
	}

	[Token(Token = "0x600365F")]
	[Address(RVA = "0x1C8D974", Offset = "0x1C8D974", VA = "0x1C8D974")]
	private XLanguageInfo FindLanguageInfo(Func<XLanguageInfo, bool> searchAction)
	{
		return null;
	}

	[Token(Token = "0x6003660")]
	[Address(RVA = "0x1C8DC3C", Offset = "0x1C8DC3C", VA = "0x1C8DC3C")]
	private List<XLanguageInfo> FindAllLanguageInfo(Func<XLanguageInfo, bool> searchAction)
	{
		return null;
	}

	[Token(Token = "0x6003661")]
	[Address(RVA = "0x1C8DE84", Offset = "0x1C8DE84", VA = "0x1C8DE84", Slot = "40")]
	public bool IsExistLanguageLocaleInfo(string strlanguage)
	{
		return default(bool);
	}

	[Token(Token = "0x6003662")]
	[Address(RVA = "0x1C8DE9C", Offset = "0x1C8DE9C", VA = "0x1C8DE9C", Slot = "41")]
	public string GetDefaultLanguage()
	{
		return null;
	}

	[Token(Token = "0x6003663")]
	[Address(RVA = "0x1C8DF68", Offset = "0x1C8DF68", VA = "0x1C8DF68")]
	public List<XLanguageInfo> GetOptionActiveList()
	{
		return null;
	}

	[Token(Token = "0x6003664")]
	[Address(RVA = "0x1C8E090", Offset = "0x1C8E090", VA = "0x1C8E090")]
	public List<XLanguageInfo> GetChatActiveList()
	{
		return null;
	}

	[Token(Token = "0x6003665")]
	[Address(RVA = "0x1C8E1B8", Offset = "0x1C8E1B8", VA = "0x1C8E1B8")]
	public XLanguageInfo GetLanguageInfoBySystemLanguage(string strSystemLanguage)
	{
		return null;
	}

	[Token(Token = "0x6003666")]
	[Address(RVA = "0x1C8E398", Offset = "0x1C8E398", VA = "0x1C8E398")]
	private static bool _003CGetOptionActiveList_003Em__182(XLanguageInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6003667")]
	[Address(RVA = "0x1C8E3B8", Offset = "0x1C8E3B8", VA = "0x1C8E3B8")]
	private static bool _003CGetChatActiveList_003Em__183(XLanguageInfo info)
	{
		return default(bool);
	}
}
