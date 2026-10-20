using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FC2")]
public class XWidget_PVPReadyView : XUIBaseWidget
{
	[Token(Token = "0x40053C1")]
	[FieldOffset(Offset = "0x1C")]
	private readonly string Path_RewardBoxDetailPopup;

	[Token(Token = "0x40053C2")]
	[FieldOffset(Offset = "0x20")]
	private readonly string Path_QuickMatchOptionPopup;

	[Token(Token = "0x40053C3")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_RewardDetailPopup _rewardBoxDetailPopup;

	[Token(Token = "0x40053C4")]
	[FieldOffset(Offset = "0x28")]
	private XWidget_QuickMatchOptionPopup _quickMatchOptionPopup;

	[Token(Token = "0x40053C5")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_ModeInfo modeInfo;

	[Token(Token = "0x40053C6")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_ModeSelector modeSelector;

	[Token(Token = "0x40053C7")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_ItemDetailToolTip itemToolTip;

	[Token(Token = "0x40053C8")]
	[FieldOffset(Offset = "0x38")]
	public Transform toolTipTransform;

	[Token(Token = "0x40053C9")]
	[FieldOffset(Offset = "0x3C")]
	public XPanel_CombatMissionReward combatMissionReward;

	[Token(Token = "0x40053CA")]
	[FieldOffset(Offset = "0x40")]
	private bool IsFriendly;

	[Token(Token = "0x40053CB")]
	[FieldOffset(Offset = "0x44")]
	private Action<GameModeInstanceInfo, string, bool> modeSelectDelegate;

	[Token(Token = "0x40053CC")]
	[FieldOffset(Offset = "0x48")]
	public GameObject QuickMatchOptionButton;

	[Token(Token = "0x17000EDC")]
	public XWidget_RewardDetailPopup rewardBoxDetailPopup
	{
		[Token(Token = "0x6007559")]
		[Address(RVA = "0x13295E0", Offset = "0x13295E0", VA = "0x13295E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EDD")]
	public XWidget_QuickMatchOptionPopup quickMatchOptionPopup
	{
		[Token(Token = "0x600755A")]
		[Address(RVA = "0x13296FC", Offset = "0x13296FC", VA = "0x13296FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007558")]
	[Address(RVA = "0x1329540", Offset = "0x1329540", VA = "0x1329540")]
	public XWidget_PVPReadyView()
	{
	}

	[Token(Token = "0x600755B")]
	[Address(RVA = "0x1329818", Offset = "0x1329818", VA = "0x1329818")]
	public void ShowRewardBoxDetailPopup()
	{
	}

	[Token(Token = "0x600755C")]
	[Address(RVA = "0x13298A0", Offset = "0x13298A0", VA = "0x13298A0")]
	public void ShowQuickMatchOptionPopup()
	{
	}

	[Token(Token = "0x600755D")]
	[Address(RVA = "0x132991C", Offset = "0x132991C", VA = "0x132991C")]
	public void RegisterModeSelectDelegate(Action<GameModeInstanceInfo, string, bool> modeSelectDelegate)
	{
	}

	[Token(Token = "0x600755E")]
	[Address(RVA = "0x1329924", Offset = "0x1329924", VA = "0x1329924")]
	public void BuildFriendlyOneModeView(GameModeInstanceInfo gameModeInstanceInfo, bool isShowCombatMissionPanel = false)
	{
	}

	[Token(Token = "0x600755F")]
	[Address(RVA = "0x1329BE4", Offset = "0x1329BE4", VA = "0x1329BE4")]
	public void BuildNormalOneMode(GameModeInstanceInfo modeInfo)
	{
	}

	[Token(Token = "0x6007560")]
	[Address(RVA = "0x1329C28", Offset = "0x1329C28", VA = "0x1329C28")]
	public void BuildAlMode()
	{
	}

	[Token(Token = "0x6007561")]
	[Address(RVA = "0x132996C", Offset = "0x132996C", VA = "0x132996C")]
	private void BuildCommon(bool isShowCombatMissionPanel = true)
	{
	}

	[Token(Token = "0x6007562")]
	[Address(RVA = "0x132A4F4", Offset = "0x132A4F4", VA = "0x132A4F4")]
	public GameModeInstanceInfo GetSelectedGameMode(bool isOrigin = false)
	{
		return null;
	}

	[Token(Token = "0x6007563")]
	[Address(RVA = "0x1329C6C", Offset = "0x1329C6C", VA = "0x1329C6C")]
	private void BuildCombatMissionPanel()
	{
	}

	[Token(Token = "0x6007564")]
	[Address(RVA = "0x132AA48", Offset = "0x132AA48", VA = "0x132AA48")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x6007565")]
	[Address(RVA = "0x132AA4C", Offset = "0x132AA4C", VA = "0x132AA4C")]
	public void ClearListMap()
	{
	}

	[Token(Token = "0x6007566")]
	[Address(RVA = "0x132AB24", Offset = "0x132AB24", VA = "0x132AB24")]
	public void Show()
	{
	}

	[Token(Token = "0x6007567")]
	[Address(RVA = "0x132AB70", Offset = "0x132AB70", VA = "0x132AB70", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6007568")]
	[Address(RVA = "0x132AB90", Offset = "0x132AB90", VA = "0x132AB90")]
	private void ChangeMode(GameModeInstanceInfo gamemodeInstance, string strUnlock, bool unlock)
	{
	}

	[Token(Token = "0x6007569")]
	[Address(RVA = "0x132AC4C", Offset = "0x132AC4C", VA = "0x132AC4C")]
	private void ChangeModeDesc(GameModeInstanceInfo gamemodeInstance)
	{
	}

	[Token(Token = "0x600756A")]
	[Address(RVA = "0x132ADF4", Offset = "0x132ADF4", VA = "0x132ADF4")]
	public void OnClick_QuickMatchOption()
	{
	}

	[Token(Token = "0x600756B")]
	[Address(RVA = "0x132ADF8", Offset = "0x132ADF8", VA = "0x132ADF8")]
	public void GetMissionReward(Action ProcessingStartGame)
	{
	}

	[Token(Token = "0x600756C")]
	[Address(RVA = "0x132AED8", Offset = "0x132AED8", VA = "0x132AED8")]
	public void OnClick_Help()
	{
	}
}
