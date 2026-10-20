using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000670")]
public class XProtoInfoManager_LobbyButton : Dictionary<XLobbyButtonType, List<XLobbyButtonInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4001EDC")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, List<XLobbyButtonInfo>> m_ButtonsByCountry;

	[Token(Token = "0x4001EDD")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XLobbyButtonInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<XLobbyButtonInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6003673")]
	[Address(RVA = "0x1C86100", Offset = "0x1C86100", VA = "0x1C86100")]
	public XProtoInfoManager_LobbyButton()
	{
	}

	[Token(Token = "0x6003674")]
	[Address(RVA = "0x1C8E4C8", Offset = "0x1C8E4C8", VA = "0x1C8E4C8", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6003675")]
	[Address(RVA = "0x1C8E4D8", Offset = "0x1C8E4D8", VA = "0x1C8E4D8", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6003676")]
	[Address(RVA = "0x1C8E4DC", Offset = "0x1C8E4DC", VA = "0x1C8E4DC", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x6003677")]
	[Address(RVA = "0x1C8E9B4", Offset = "0x1C8E9B4", VA = "0x1C8E9B4", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6003678")]
	[Address(RVA = "0x1C8F138", Offset = "0x1C8F138", VA = "0x1C8F138")]
	public List<XLobbyButtonInfo> GetLobbyButtons(string strCountryCode)
	{
		return null;
	}

	[Token(Token = "0x6003679")]
	[Address(RVA = "0x1C8F33C", Offset = "0x1C8F33C", VA = "0x1C8F33C")]
	public List<XLobbyButtonInfo> GetLobbyBanners(DateTime nowTime, string strCountry)
	{
		return null;
	}

	[Token(Token = "0x600367A")]
	[Address(RVA = "0x1C8F7FC", Offset = "0x1C8F7FC", VA = "0x1C8F7FC")]
	private static bool _003CGetLobbyBanners_003Em__184(XLobbyButtonInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x600367B")]
	[Address(RVA = "0x1C8F80C", Offset = "0x1C8F80C", VA = "0x1C8F80C")]
	private static int _003CGetLobbyBanners_003Em__185(XLobbyButtonInfo x, XLobbyButtonInfo y)
	{
		return default(int);
	}
}
