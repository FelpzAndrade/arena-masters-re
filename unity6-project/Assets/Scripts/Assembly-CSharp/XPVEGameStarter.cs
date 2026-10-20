using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004E7")]
public class XPVEGameStarter : XGameStarter
{
	[Token(Token = "0x20004E8")]
	private sealed class _003CStartSkyTower_003Ec__AnonStorey116
	{
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x8")]
		internal CSStageInfo currentDungeonInfo;

		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0xC")]
		internal Action onStartFail;

		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x1C974E8", Offset = "0x1C974E8", VA = "0x1C974E8")]
		public _003CStartSkyTower_003Ec__AnonStorey116()
		{
		}

		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x1C981E4", Offset = "0x1C981E4", VA = "0x1C981E4")]
		internal void _003C_003Em__108(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x20004E9")]
	private sealed class _003CRequestEnterSpecialDungeon_003Ec__AnonStorey117
	{
		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x8")]
		internal CSStageInfo currentDungeonInfo;

		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0xC")]
		internal Action onStartFail;

		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x1C97F6C", Offset = "0x1C97F6C", VA = "0x1C97F6C")]
		public _003CRequestEnterSpecialDungeon_003Ec__AnonStorey117()
		{
		}

		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x1C980B0", Offset = "0x1C980B0", VA = "0x1C980B0")]
		internal void _003C_003Em__109(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x20004EA")]
	private sealed class _003CRequestEnterMission_003Ec__AnonStorey118
	{
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x8")]
		internal CSStageInfo currentDungeonInfo;

		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0xC")]
		internal Action onStartFail;

		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x1C97F74", Offset = "0x1C97F74", VA = "0x1C97F74")]
		public _003CRequestEnterMission_003Ec__AnonStorey118()
		{
		}

		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x1C97F7C", Offset = "0x1C97F7C", VA = "0x1C97F7C")]
		internal void _003C_003Em__10A(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x40018D5")]
	[FieldOffset(Offset = "0xC")]
	private XGameModeType m_gameModeType;

	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x1C96BDC", Offset = "0x1C96BDC", VA = "0x1C96BDC")]
	public XPVEGameStarter(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x1C96CD0", Offset = "0x1C96CD0", VA = "0x1C96CD0", Slot = "4")]
	public override XGameModeType GetGameModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x1C96CD8", Offset = "0x1C96CD8", VA = "0x1C96CD8")]
	public static bool Special_SkyTowerGameStart(CSStageInfo dungeonInfo, Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x1C97474", Offset = "0x1C97474", VA = "0x1C97474")]
	public static bool MissionGameStart(CSStageInfo dungeonInfo, Action onStartFail, bool isItemBooster, bool isGoldBooster, bool isPromstoneBooster)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A87")]
	[Address(RVA = "0x1C96D2C", Offset = "0x1C96D2C", VA = "0x1C96D2C")]
	private static bool CheckPveGameStart(CSStageInfo stageInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x1C96FEC", Offset = "0x1C96FEC", VA = "0x1C96FEC")]
	private static bool StartSkyTower(Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A89")]
	[Address(RVA = "0x1C96FE8", Offset = "0x1C96FE8", VA = "0x1C96FE8")]
	private static bool StartSpecial(Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A8A")]
	[Address(RVA = "0x1C974C8", Offset = "0x1C974C8", VA = "0x1C974C8")]
	private static bool StartMission(Action onStartFail, bool isItemBooster, bool isGoldBooster, bool isPromstoneBooster)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0x1C974F0", Offset = "0x1C974F0", VA = "0x1C974F0")]
	private static bool RequestEnterSpecialDungeon(Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x1C97978", Offset = "0x1C97978", VA = "0x1C97978")]
	private static bool RequestEnterMission(Action onStartFail, bool isItemBooster, bool isGoldBooster, bool isPromstoneBooster)
	{
		return default(bool);
	}
}
