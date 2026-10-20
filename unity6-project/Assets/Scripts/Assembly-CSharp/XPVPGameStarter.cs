using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004ED")]
public class XPVPGameStarter : XGameStarter
{
	[Token(Token = "0x20004EE")]
	private enum XPVPErrorCode
	{
		[Token(Token = "0x40018E5")]
		Success = 0,
		[Token(Token = "0x40018E6")]
		BanCharInParty = 1,
		[Token(Token = "0x40018E7")]
		OneMemberInParty = 2
	}

	[Token(Token = "0x20004EF")]
	private sealed class _003CRequestEnterDungeon_003Ec__AnonStorey10B
	{
		[Token(Token = "0x40018E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameModeInstanceInfo currentGameModeInstanceInfo;

		[Token(Token = "0x40018E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal EventGameModeInfo currentEventGameModeInfo;

		[Token(Token = "0x40018EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Action onStartFail;

		[Token(Token = "0x40018EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XPVPGameStarter _003C_003Ef__this;

		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x1C9E4A4", Offset = "0x1C9E4A4", VA = "0x1C9E4A4")]
		public _003CRequestEnterDungeon_003Ec__AnonStorey10B()
		{
		}

		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x1C9EAB0", Offset = "0x1C9EAB0", VA = "0x1C9EAB0")]
		internal void _003C_003Em__F1(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x20004F0")]
	private sealed class _003CRequestEnterFriendly_003Ec__AnonStorey10C
	{
		[Token(Token = "0x40018EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameModeInstanceInfo currentGameModeInstanceInfo;

		[Token(Token = "0x40018ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal FriendlySessionData friendlySessionData;

		[Token(Token = "0x40018EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string friendlyPhotonRoomName;

		[Token(Token = "0x40018EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal string friendlyMasterName;

		[Token(Token = "0x40018F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Action onStartFail;

		[Token(Token = "0x40018F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal XPVPGameStarter _003C_003Ef__this;

		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x1C9E5A8", Offset = "0x1C9E5A8", VA = "0x1C9E5A8")]
		public _003CRequestEnterFriendly_003Ec__AnonStorey10C()
		{
		}

		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x1C9ECAC", Offset = "0x1C9ECAC", VA = "0x1C9ECAC")]
		internal void _003C_003Em__F2(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x20004F1")]
	private sealed class _003CRequestEnterDungeon_003Ec__AnonStorey10D
	{
		[Token(Token = "0x40018F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action onStartSuccess;

		[Token(Token = "0x40018F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Action onStartFail;

		[Token(Token = "0x40018F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPVPGameStarter _003C_003Ef__this;

		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x1C9E5B0", Offset = "0x1C9E5B0", VA = "0x1C9E5B0")]
		public _003CRequestEnterDungeon_003Ec__AnonStorey10D()
		{
		}

		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x1C9EC3C", Offset = "0x1C9EC3C", VA = "0x1C9EC3C")]
		internal void _003C_003Em__F3(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x20004F2")]
	private sealed class _003CErrorHandleFunc_003Ec__AnonStorey10E
	{
		[Token(Token = "0x40018F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string title;

		[Token(Token = "0x40018F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string defaultMessage;

		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x1C9E5B8", Offset = "0x1C9E5B8", VA = "0x1C9E5B8")]
		public _003CErrorHandleFunc_003Ec__AnonStorey10E()
		{
		}

		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x1C9E90C", Offset = "0x1C9E90C", VA = "0x1C9E90C")]
		internal void _003C_003Em__F4()
		{
		}
	}

	[Token(Token = "0x40018DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected GameModeInstanceInfo m_gameModeInstanceInfo;

	[Token(Token = "0x40018E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected EventGameModeInfo m_eventgameModeInfo;

	[Token(Token = "0x40018E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected bool m_preGameContinue;

	[Token(Token = "0x40018E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	protected bool m_friendlyMatch;

	[Token(Token = "0x40018E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	protected bool m_bQuickMatch;

	[Token(Token = "0x6002A9E")]
	[Address(RVA = "0x1C986F4", Offset = "0x1C986F4", VA = "0x1C986F4")]
	public XPVPGameStarter()
	{
	}

	[Token(Token = "0x6002A9F")]
	[Address(RVA = "0x1C9AA40", Offset = "0x1C9AA40", VA = "0x1C9AA40")]
	public XPVPGameStarter(MatchType matchType, XGameModeType gameMode, int sectorID, bool preGameContinue, bool friendlyMatch)
	{
	}

	[Token(Token = "0x6002AA0")]
	[Address(RVA = "0x1C9ADF4", Offset = "0x1C9ADF4", VA = "0x1C9ADF4")]
	public XPVPGameStarter(GameModeInstanceInfo gameModeInstanceInfo, int sectorID, bool isAIMode)
	{
	}

	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x1C98718", Offset = "0x1C98718", VA = "0x1C98718")]
	public void SetGameStarterInfo(GameModeInstanceInfo gameModeInstanceInfo)
	{
	}

	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x1C9ABA8", Offset = "0x1C9ABA8", VA = "0x1C9ABA8")]
	public bool SetGameStarterInfo(GameModeInstanceInfo gameModeInstanceInfo, int sectorID, bool isAIMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AA3")]
	[Address(RVA = "0x1C9AE40", Offset = "0x1C9AE40", VA = "0x1C9AE40")]
	public static GameModeInstanceInfo GetGameModeInstanceInfo(XGameModeType gamemode, bool IsLadder, bool IsAIMode)
	{
		return null;
	}

	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x1C9AF64", Offset = "0x1C9AF64", VA = "0x1C9AF64", Slot = "4")]
	public override XGameModeType GetGameModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x1C9AF88", Offset = "0x1C9AF88", VA = "0x1C9AF88")]
	public int GetGameModeInstanceID()
	{
		return default(int);
	}

	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x1C9AFAC", Offset = "0x1C9AFAC", VA = "0x1C9AFAC")]
	public int GetRandomSectorID(bool isCheckLevel)
	{
		return default(int);
	}

	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x1C9B238", Offset = "0x1C9B238", VA = "0x1C9B238")]
	public int GetRecommendSectorID()
	{
		return default(int);
	}

	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x1C9B3F4", Offset = "0x1C9B3F4", VA = "0x1C9B3F4")]
	private void SetQuickMatch(bool bQuickMatch)
	{
	}

	[Token(Token = "0x6002AA9")]
	[Address(RVA = "0x1C9B3EC", Offset = "0x1C9B3EC", VA = "0x1C9B3EC")]
	private bool IsQuickMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6002AAA")]
	[Address(RVA = "0x1C9B3FC", Offset = "0x1C9B3FC", VA = "0x1C9B3FC")]
	private bool IsNewbieQuickMatchOption()
	{
		return default(bool);
	}

	[Token(Token = "0x6002AAB")]
	[Address(RVA = "0x1C9B514", Offset = "0x1C9B514", VA = "0x1C9B514")]
	public void CheckQuickMatch()
	{
	}

	[Token(Token = "0x6002AAC")]
	[Address(RVA = "0x1C9B6E0", Offset = "0x1C9B6E0", VA = "0x1C9B6E0")]
	public bool IsModeOpenTimeInfo(bool isFriendlyMatch, bool isRandomMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AAD")]
	[Address(RVA = "0x1C9BAC4", Offset = "0x1C9BAC4", VA = "0x1C9BAC4")]
	public void GameRecordClearCache()
	{
	}

	[Token(Token = "0x6002AAE")]
	[Address(RVA = "0x1C9BBB0", Offset = "0x1C9BBB0", VA = "0x1C9BBB0")]
	public bool PVPGameStart(Action onStartFail, bool previous_game_continue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AAF")]
	[Address(RVA = "0x1C9C03C", Offset = "0x1C9C03C", VA = "0x1C9C03C")]
	private bool FuncPvpGameStart(Action onStartFail, bool preGameContinue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB0")]
	[Address(RVA = "0x1C9C234", Offset = "0x1C9C234", VA = "0x1C9C234")]
	public bool FriendlyGameStart(Action onStartFail, FriendlySessionData friendlySessionData, bool previous_game_continue = false, string friendlyMasterName = "")
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB1")]
	[Address(RVA = "0x1C9C2E4", Offset = "0x1C9C2E4", VA = "0x1C9C2E4")]
	private bool FuncFriendlyGameStart(Action onStartFail, FriendlySessionData friendlySessionData, bool preGameContinue, string friendlyMasterName)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB2")]
	[Address(RVA = "0x1C9D290", Offset = "0x1C9D290", VA = "0x1C9D290")]
	public bool PartyGameStart(int sectorId, XGameModeType gameMode, MatchType matchType, Action onStartSuccess, [Optional] Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x1C9D734", Offset = "0x1C9D734", VA = "0x1C9D734")]
	public bool ClanWarGameStart(int sectorId, XGameModeType gameMode, MatchType matchType, Action onStartSuccess, [Optional] Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x1C9BC2C", Offset = "0x1C9BC2C", VA = "0x1C9BC2C")]
	protected bool CheckPvpGameStart(GameModeInstanceInfo gameModeInstanceInfo, bool previous_game_continue, bool friendly_match)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB5")]
	[Address(RVA = "0x1C9D7C4", Offset = "0x1C9D7C4", VA = "0x1C9D7C4")]
	protected bool CheckNormalBattleMaxRewardCount()
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x1C9DBC0", Offset = "0x1C9DBC0", VA = "0x1C9DBC0")]
	public bool CheckBanCharInParty(XCharParty party)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x1C9DCB0", Offset = "0x1C9DCB0", VA = "0x1C9DCB0")]
	private void PVPErrorHandle(XPVPErrorCode error)
	{
	}

	[Token(Token = "0x6002AB8")]
	[Address(RVA = "0x1C9DF70", Offset = "0x1C9DF70", VA = "0x1C9DF70", Slot = "6")]
	protected virtual bool RequestEnterDungeon(CharPartyId charPartyId, MatchType matchType, XGameModeType nGameModeType, int nSectorID, Action onStartFail, bool preGameContinue)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AB9")]
	[Address(RVA = "0x1C9E4AC", Offset = "0x1C9E4AC", VA = "0x1C9E4AC", Slot = "7")]
	protected virtual void DoEnterDungeon(JObject jsonData, int eloPt, GameModeInstanceInfo currentGameModeInstanceInfo, bool m_preGameContinue, Action onStartFail)
	{
	}

	[Token(Token = "0x6002ABA")]
	[Address(RVA = "0x1C9CD30", Offset = "0x1C9CD30", VA = "0x1C9CD30")]
	private bool RequestEnterFriendly(CharPartyId charPartyId, MatchType matchType, XGameModeType nGameModeType, int nSectorID, FriendlySessionData friendlySessionData, string friendlyPhotonRoomName, string friendlyMasterName, Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ABB")]
	[Address(RVA = "0x1C9D320", Offset = "0x1C9D320", VA = "0x1C9D320")]
	protected bool RequestEnterDungeon(int nSectorID, XGameModeType nGameModeType, MatchType matchType, Action onStartSuccess, Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x1C99184", Offset = "0x1C99184", VA = "0x1C99184")]
	protected void ErrorHandleFunc(ApiReturnCode errorCode, JObject json)
	{
	}

	[Token(Token = "0x6002ABD")]
	[Address(RVA = "0x1C9E5C0", Offset = "0x1C9E5C0", VA = "0x1C9E5C0")]
	private void ClanLeaveFunc()
	{
	}
}
