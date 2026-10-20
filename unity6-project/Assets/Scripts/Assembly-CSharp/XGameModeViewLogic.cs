using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200061B")]
public static class XGameModeViewLogic
{
	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int QUICKMATCH_INSTANCE_ID;

	[Token(Token = "0x4001D3B")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int NEWBIEMATCH_INSTANCE_ID;

	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int TEAMDEATHMATCH_GAMEMODE_INSTANCE_ID;

	[Token(Token = "0x4001D3D")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<GameModeInstanceInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x600349A")]
	[Address(RVA = "0x141EDF8", Offset = "0x141EDF8", VA = "0x141EDF8")]
	public static bool TryGetNormalModes(out List<GameModeInstanceInfo> modeInstanceList, out Dictionary<int, string> modeNameLocaleKeyDic, bool isIgnoreCheck = false)
	{
		modeInstanceList = default;
		modeNameLocaleKeyDic = default;
		return default(bool);
	}

	[Token(Token = "0x600349B")]
	[Address(RVA = "0x141F368", Offset = "0x141F368", VA = "0x141F368")]
	public static string GetModeLocaleKey(int modeInstanceID)
	{
		return null;
	}

	[Token(Token = "0x600349C")]
	[Address(RVA = "0x141FACC", Offset = "0x141FACC", VA = "0x141FACC")]
	public static bool IsQuickMatch(int modeInstanceID)
	{
		return default(bool);
	}

	[Token(Token = "0x600349D")]
	[Address(RVA = "0x141FB8C", Offset = "0x141FB8C", VA = "0x141FB8C")]
	public static bool IsNewbieMatch(int modeInstanceID)
	{
		return default(bool);
	}

	[Token(Token = "0x600349E")]
	[Address(RVA = "0x141F938", Offset = "0x141F938", VA = "0x141F938")]
	public static GameModeInstanceInfo GetQuickMatchModeInstanceInfo()
	{
		return null;
	}

	[Token(Token = "0x600349F")]
	[Address(RVA = "0x141F6B0", Offset = "0x141F6B0", VA = "0x141F6B0")]
	public static GameModeInstanceInfo GetNewbieMatchModeInstanceInfo()
	{
		return null;
	}

	[Token(Token = "0x60034A0")]
	[Address(RVA = "0x141FC4C", Offset = "0x141FC4C", VA = "0x141FC4C")]
	public static int GetNormalPVPUnlockLv(MatchType matchType, XGameModeType gameModeType, CSProtoInfoManager_GameConst gameConst)
	{
		return default(int);
	}

	[Token(Token = "0x60034A1")]
	[Address(RVA = "0x141FEC8", Offset = "0x141FEC8", VA = "0x141FEC8")]
	private static int _003CTryGetNormalModes_003Em__174(GameModeInstanceInfo x, GameModeInstanceInfo y)
	{
		return default(int);
	}
}
