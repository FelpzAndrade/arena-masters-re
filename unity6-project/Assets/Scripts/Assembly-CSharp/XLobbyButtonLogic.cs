using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200061F")]
public static class XLobbyButtonLogic
{
	[Token(Token = "0x4001D78")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<XLobbyButtonInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60034C0")]
	[Address(RVA = "0x1E18808", Offset = "0x1E18808", VA = "0x1E18808")]
	public static List<XLobbyButtonInfo> GetItemShowableList(XProtoInfoManager_LobbyButton lobbyButtonProtoInfoManager, XLobbyButtonType buttonType, DateTime currentTime, QuestLogic logic, UserDataBase data, List<int> ownCharIds, string loginCountry, XProtoInfoManager_Country protoCountry, string currentLangString)
	{
		return null;
	}

	[Token(Token = "0x60034C1")]
	[Address(RVA = "0x1E18C70", Offset = "0x1E18C70", VA = "0x1E18C70")]
	private static bool CheckShowable_Platform(XLobbyButtonPlatformType lobbyButtonPlatformType)
	{
		return default(bool);
	}

	[Token(Token = "0x60034C2")]
	[Address(RVA = "0x1E18CD0", Offset = "0x1E18CD0", VA = "0x1E18CD0")]
	private static bool IsIncludeCurrentTime(XLobbyButtonInfo lobbyButtonInfo, DateTime currentTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60034C3")]
	[Address(RVA = "0x1E18FB0", Offset = "0x1E18FB0", VA = "0x1E18FB0")]
	private static bool CheckIsShowed_Lang(XLobbyButtonInfo lobbyButtonInfo, string currentLangString)
	{
		return default(bool);
	}

	[Token(Token = "0x60034C4")]
	[Address(RVA = "0x1E18C00", Offset = "0x1E18C00", VA = "0x1E18C00")]
	public static bool IsShowed(XLobbyButtonInfo lobbyButtonInfo, DateTime currentTime, string currentLangString)
	{
		return default(bool);
	}

	[Token(Token = "0x60034C5")]
	[Address(RVA = "0x1E190E4", Offset = "0x1E190E4", VA = "0x1E190E4")]
	public static bool CheckNaverButton(XProtoInfoManager_LobbyButton lobbyButtonProtoInfoManager, string loginCountry)
	{
		return default(bool);
	}

	[Token(Token = "0x60034C6")]
	[Address(RVA = "0x1E19364", Offset = "0x1E19364", VA = "0x1E19364")]
	private static int _003CGetItemShowableList_003Em__178(XLobbyButtonInfo x, XLobbyButtonInfo y)
	{
		return default(int);
	}
}
