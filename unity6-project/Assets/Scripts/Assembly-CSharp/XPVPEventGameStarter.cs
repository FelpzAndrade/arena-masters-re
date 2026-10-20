using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004EB")]
public class XPVPEventGameStarter : XPVPGameStarter
{
	[Token(Token = "0x20004EC")]
	private sealed class _003CRequestEnterDungeon_003Ec__AnonStorey119
	{
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x8")]
		internal GameModeInstanceInfo currentGameModeInstanceInfo;

		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0xC")]
		internal Action onStartFail;

		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x10")]
		internal XPVPEventGameStarter _003C_003Ef__this;

		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x1C98F34", Offset = "0x1C98F34", VA = "0x1C98F34")]
		public _003CRequestEnterDungeon_003Ec__AnonStorey119()
		{
		}

		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x1C98F3C", Offset = "0x1C98F3C", VA = "0x1C98F3C")]
		internal void _003C_003Em__10B(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
		{
		}
	}

	[Token(Token = "0x6002A93")]
	[Address(RVA = "0x1C98318", Offset = "0x1C98318", VA = "0x1C98318")]
	public XPVPEventGameStarter(int eventModeID)
	{
	}

	[Token(Token = "0x6002A94")]
	[Address(RVA = "0x1C988EC", Offset = "0x1C988EC", VA = "0x1C988EC")]
	public XPVPEventGameStarter(EventGameModeInfo eventgameModeInfo, GameModeInstanceInfo gameModeInstanceInfo)
	{
	}

	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x1C98778", Offset = "0x1C98778", VA = "0x1C98778")]
	private void SetEventModeStarterInfo(EventGameModeInfo eventgameModeInfo)
	{
	}

	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x1C98934", Offset = "0x1C98934", VA = "0x1C98934")]
	public int GetEventEnterCostCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002A97")]
	[Address(RVA = "0x1C98958", Offset = "0x1C98958", VA = "0x1C98958")]
	public Currency GetEventEnterCostType()
	{
		return default(Currency);
	}

	[Token(Token = "0x6002A98")]
	[Address(RVA = "0x1C9897C", Offset = "0x1C9897C", VA = "0x1C9897C")]
	public int GetEventModeGroupID()
	{
		return default(int);
	}

	[Token(Token = "0x6002A99")]
	[Address(RVA = "0x1C989A0", Offset = "0x1C989A0", VA = "0x1C989A0")]
	public int GetEventModeRewardGroupID()
	{
		return default(int);
	}

	[Token(Token = "0x6002A9A")]
	[Address(RVA = "0x1C989C4", Offset = "0x1C989C4", VA = "0x1C989C4")]
	public bool IsEventModeOpenTime(DateTime nowTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x1C98A0C", Offset = "0x1C98A0C", VA = "0x1C98A0C", Slot = "6")]
	protected override bool RequestEnterDungeon(CharPartyId charPartyId, MatchType matchType, XGameModeType nGameModeType, int nSectorID, Action onStartFail, bool preGameContinue)
	{
		return default(bool);
	}
}
