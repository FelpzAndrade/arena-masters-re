using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2001054")]
public class XUIManager
{
	[Token(Token = "0x2001055")]
	private sealed class _003CCheckCurrencyAndPopup_003Ec__AnonStorey258
	{
		[Token(Token = "0x400580A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Currency currencyType;

		[Token(Token = "0x400580B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Action onPopupShowAction;

		[Token(Token = "0x400580C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XUIManager _003C_003Ef__this;

		[Token(Token = "0x60079F9")]
		[Address(RVA = "0x10B5768", Offset = "0x10B5768", VA = "0x10B5768")]
		public _003CCheckCurrencyAndPopup_003Ec__AnonStorey258()
		{
		}

		[Token(Token = "0x60079FA")]
		[Address(RVA = "0x10B6524", Offset = "0x10B6524", VA = "0x10B6524")]
		internal void _003C_003Em__51B()
		{
		}
	}

	[Token(Token = "0x4005800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public XUIMgr_Common common;

	[Token(Token = "0x4005801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XUIMgr_Game game;

	[Token(Token = "0x4005802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XUIMgr_Lobby lobby;

	[Token(Token = "0x4005803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XUIMgr_Title title;

	[Token(Token = "0x4005804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4005805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4005806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4005807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4005808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4005809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache9;

	[Token(Token = "0x60079CC")]
	[Address(RVA = "0x10B1400", Offset = "0x10B1400", VA = "0x10B1400")]
	public XUIManager()
	{
	}

	[Token(Token = "0x60079CD")]
	[Address(RVA = "0x10B1F00", Offset = "0x10B1F00", VA = "0x10B1F00")]
	public void ClearGame()
	{
	}

	[Token(Token = "0x60079CE")]
	[Address(RVA = "0x10B2044", Offset = "0x10B2044", VA = "0x10B2044")]
	public void ClearLobby()
	{
	}

	[Token(Token = "0x60079CF")]
	[Address(RVA = "0x10B2114", Offset = "0x10B2114", VA = "0x10B2114")]
	public void ClearTitle()
	{
	}

	[Token(Token = "0x60079D0")]
	[Address(RVA = "0x10B21E4", Offset = "0x10B21E4", VA = "0x10B21E4")]
	public void ClearCommon()
	{
	}

	[Token(Token = "0x60079D1")]
	[Address(RVA = "0x10A440C", Offset = "0x10A440C", VA = "0x10A440C")]
	public void NotifyToUI(string eventName, object arg)
	{
	}

	[Token(Token = "0x60079D2")]
	[Address(RVA = "0x10B22B4", Offset = "0x10B22B4", VA = "0x10B22B4")]
	public void NotifyToUI(string eventName)
	{
	}

	[Token(Token = "0x60079D3")]
	[Address(RVA = "0x10B239C", Offset = "0x10B239C", VA = "0x10B239C")]
	public void ShowNotEnoughStaminaPopUp()
	{
	}

	[Token(Token = "0x60079D4")]
	[Address(RVA = "0x10B2614", Offset = "0x10B2614", VA = "0x10B2614")]
	public void ShowNotEnoughEnergyPopUp()
	{
	}

	[Token(Token = "0x60079D5")]
	[Address(RVA = "0x10B288C", Offset = "0x10B288C", VA = "0x10B288C")]
	public bool CheckCrystal(int curCrystal, int reqCrystal, [Optional] Action onFailAction)
	{
		return default(bool);
	}

	[Token(Token = "0x60079D6")]
	[Address(RVA = "0x10B2A84", Offset = "0x10B2A84", VA = "0x10B2A84")]
	public bool CheckArenaCoin(int curArenaCoin, int reqArenaCoin, [Optional] Action action)
	{
		return default(bool);
	}

	[Token(Token = "0x60079D7")]
	[Address(RVA = "0x10B28B8", Offset = "0x10B28B8", VA = "0x10B28B8")]
	public void ShowNotEnoughCrystalPopUp([Optional] Action action)
	{
	}

	[Token(Token = "0x60079D8")]
	[Address(RVA = "0x10B2C4C", Offset = "0x10B2C4C", VA = "0x10B2C4C")]
	public Action GetActionOnNotEnoughCrystal()
	{
		return null;
	}

	[Token(Token = "0x60079D9")]
	[Address(RVA = "0x10B2FD0", Offset = "0x10B2FD0", VA = "0x10B2FD0")]
	public void ShowNotEnoughFPPopUp([Optional] Action action)
	{
	}

	[Token(Token = "0x60079DA")]
	[Address(RVA = "0x10B3154", Offset = "0x10B3154", VA = "0x10B3154")]
	public void ShowNotEnoughMedalOfHonorPopUp([Optional] Action action)
	{
	}

	[Token(Token = "0x60079DB")]
	[Address(RVA = "0x10B3318", Offset = "0x10B3318", VA = "0x10B3318")]
	public void ShowNotEnoughMedalOfWarriorPopUp([Optional] Action action)
	{
	}

	[Token(Token = "0x60079DC")]
	[Address(RVA = "0x10B34DC", Offset = "0x10B34DC", VA = "0x10B34DC")]
	public void ShowNotEnoughFriendPointPopup([Optional] Action action)
	{
	}

	[Token(Token = "0x60079DD")]
	[Address(RVA = "0x10B2AC8", Offset = "0x10B2AC8", VA = "0x10B2AC8")]
	public void ShowNotEnoughArenaCoinPopup([Optional] Action action)
	{
	}

	[Token(Token = "0x60079DE")]
	[Address(RVA = "0x10B36A0", Offset = "0x10B36A0", VA = "0x10B36A0")]
	public bool CheckGold(int curGold, int reqGold, [Optional] Action onFailAction)
	{
		return default(bool);
	}

	[Token(Token = "0x60079DF")]
	[Address(RVA = "0x10B3A2C", Offset = "0x10B3A2C", VA = "0x10B3A2C")]
	public bool CheckSoulStoneCount(XModuleActor character)
	{
		return default(bool);
	}

	[Token(Token = "0x60079E0")]
	[Address(RVA = "0x10B3EB4", Offset = "0x10B3EB4", VA = "0x10B3EB4")]
	public bool CheckSoulDustCount(XModuleActor character)
	{
		return default(bool);
	}

	[Token(Token = "0x60079E1")]
	[Address(RVA = "0x10B37AC", Offset = "0x10B37AC", VA = "0x10B37AC")]
	public void ShowNotEnoughGoldPopUp([Optional] Action action)
	{
	}

	[Token(Token = "0x60079E2")]
	[Address(RVA = "0x10B433C", Offset = "0x10B433C", VA = "0x10B433C")]
	public void ShowNotEnoughTeamLevelPopUp()
	{
	}

	[Token(Token = "0x60079E3")]
	[Address(RVA = "0x10B4514", Offset = "0x10B4514", VA = "0x10B4514")]
	public void ShowNotEnoughTeamLevelPopUp(int lev)
	{
	}

	[Token(Token = "0x60079E4")]
	[Address(RVA = "0x10B46D0", Offset = "0x10B46D0", VA = "0x10B46D0")]
	public void ShowNotEnoughCharacterLevelPopUp()
	{
	}

	[Token(Token = "0x60079E5")]
	[Address(RVA = "0x10B48A8", Offset = "0x10B48A8", VA = "0x10B48A8")]
	public void ShowNotEnoughCharacterLevelPopUp(int lev)
	{
	}

	[Token(Token = "0x60079E6")]
	[Address(RVA = "0x10B3CF8", Offset = "0x10B3CF8", VA = "0x10B3CF8")]
	public void ShowNotEnoughSoulStonePopUp(int needMore)
	{
	}

	[Token(Token = "0x60079E7")]
	[Address(RVA = "0x10B4180", Offset = "0x10B4180", VA = "0x10B4180")]
	public void ShowNotEnoughSoulDustPopUp(int needMore)
	{
	}

	[Token(Token = "0x60079E8")]
	[Address(RVA = "0x10B4A80", Offset = "0x10B4A80", VA = "0x10B4A80")]
	public void ShowItemIsNotReadyPopUp()
	{
	}

	[Token(Token = "0x60079E9")]
	[Address(RVA = "0x10B4C58", Offset = "0x10B4C58", VA = "0x10B4C58")]
	public void ShowDungeonIsNotReadyPopUp()
	{
	}

	[Token(Token = "0x60079EA")]
	[Address(RVA = "0x10B4E30", Offset = "0x10B4E30", VA = "0x10B4E30")]
	public void ShowSellSoulStoneIsNotMaxLevelCharacterPopup()
	{
	}

	[Token(Token = "0x60079EB")]
	[Address(RVA = "0x10B5008", Offset = "0x10B5008", VA = "0x10B5008")]
	public bool CheckInventory(int curCount, int reqCount)
	{
		return default(bool);
	}

	[Token(Token = "0x60079EC")]
	[Address(RVA = "0x10B5294", Offset = "0x10B5294", VA = "0x10B5294")]
	public int GetUpgradePrice(XModuleActor character)
	{
		return default(int);
	}

	[Token(Token = "0x60079ED")]
	[Address(RVA = "0x10B5440", Offset = "0x10B5440", VA = "0x10B5440")]
	public int GetUpgradePricePet(XModuleActor character)
	{
		return default(int);
	}

	[Token(Token = "0x60079EE")]
	[Address(RVA = "0x10B3B4C", Offset = "0x10B3B4C", VA = "0x10B3B4C")]
	public int GetReqSoulStone(XModuleActor character)
	{
		return default(int);
	}

	[Token(Token = "0x60079EF")]
	[Address(RVA = "0x10B3FD4", Offset = "0x10B3FD4", VA = "0x10B3FD4")]
	public int GetReqSoulDust(XModuleActor pet)
	{
		return default(int);
	}

	[Token(Token = "0x60079F0")]
	[Address(RVA = "0x10B55EC", Offset = "0x10B55EC", VA = "0x10B55EC")]
	public bool CheckCurrency(UserDataBase userData, Currency currencyType, int reqCount, [Optional] Action onFailAction)
	{
		return default(bool);
	}

	[Token(Token = "0x60079F1")]
	[Address(RVA = "0x10B564C", Offset = "0x10B564C", VA = "0x10B564C")]
	public bool CheckCurrencyAndPopup(UserDataBase userData, Currency currencyType, int reqCount, Action onPopupShowAction)
	{
		return default(bool);
	}

	[Token(Token = "0x60079F2")]
	[Address(RVA = "0x10B5770", Offset = "0x10B5770", VA = "0x10B5770")]
	public void ShowCurrencyNotEnoughPopup(Currency currencyType, Action onPopupShowAction)
	{
	}

	[Token(Token = "0x60079F3")]
	[Address(RVA = "0x10B5834", Offset = "0x10B5834", VA = "0x10B5834")]
	private static void _003CShowNotEnoughStaminaPopUp_003Em__515()
	{
	}

	[Token(Token = "0x60079F4")]
	[Address(RVA = "0x10B5BE4", Offset = "0x10B5BE4", VA = "0x10B5BE4")]
	private static void _003CShowNotEnoughEnergyPopUp_003Em__516()
	{
	}

	[Token(Token = "0x60079F5")]
	[Address(RVA = "0x10B5CEC", Offset = "0x10B5CEC", VA = "0x10B5CEC")]
	private static void _003CGetActionOnNotEnoughCrystal_003Em__517()
	{
	}

	[Token(Token = "0x60079F6")]
	[Address(RVA = "0x10B5DC0", Offset = "0x10B5DC0", VA = "0x10B5DC0")]
	private static void _003CGetActionOnNotEnoughCrystal_003Em__518()
	{
	}

	[Token(Token = "0x60079F7")]
	[Address(RVA = "0x10B605C", Offset = "0x10B605C", VA = "0x10B605C")]
	private static void _003CShowNotEnoughGoldPopUp_003Em__519()
	{
	}

	[Token(Token = "0x60079F8")]
	[Address(RVA = "0x10B6164", Offset = "0x10B6164", VA = "0x10B6164")]
	private static void _003CCheckInventory_003Em__51A()
	{
	}
}
