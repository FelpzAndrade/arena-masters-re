using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FC1")]
public class XWidget_PVPEventReadyView : XUIBaseWidget
{
	[Token(Token = "0x40053B6")]
	[FieldOffset(Offset = "0x1C")]
	public int _parentPanelDepth;

	[Token(Token = "0x40053B7")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_Mark modeMark;

	[Token(Token = "0x40053B8")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_ModeInfo modeInfoWidget;

	[Token(Token = "0x40053B9")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_EventMilestoneReward milestoneReward;

	[Token(Token = "0x40053BA")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_EventRecordStatus status;

	[Token(Token = "0x40053BB")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_EventFirstRewardButton firstRewardBtn;

	[Token(Token = "0x40053BC")]
	[FieldOffset(Offset = "0x34")]
	private readonly string Path_eventRewardPopup;

	[Token(Token = "0x40053BD")]
	[FieldOffset(Offset = "0x38")]
	private XWidget_EventRewardPopup _eventRewardPopup;

	[Token(Token = "0x40053BE")]
	[FieldOffset(Offset = "0x3C")]
	private EventGameRewardGroup rewardInfo;

	[Token(Token = "0x40053BF")]
	[FieldOffset(Offset = "0x40")]
	private EventGameModeInfo eventModeInfo;

	[Token(Token = "0x40053C0")]
	[FieldOffset(Offset = "0x44")]
	private int helpID;

	[Token(Token = "0x17000EDA")]
	public int ParentPanelDepth
	{
		[Token(Token = "0x6007551")]
		[Address(RVA = "0x13288F0", Offset = "0x13288F0", VA = "0x13288F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000EDB")]
	public XWidget_EventRewardPopup EventRewardPopup
	{
		[Token(Token = "0x6007552")]
		[Address(RVA = "0x13289F8", Offset = "0x13289F8", VA = "0x13289F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007550")]
	[Address(RVA = "0x132885C", Offset = "0x132885C", VA = "0x132885C")]
	public XWidget_PVPEventReadyView()
	{
	}

	[Token(Token = "0x6007553")]
	[Address(RVA = "0x1328B14", Offset = "0x1328B14", VA = "0x1328B14")]
	public void Build(GameModeInstanceInfo modeInstanceInfo, EventGameModeInfo eventModeInfo, EventGameRewardGroup rewardInfo, Action onRefresh)
	{
	}

	[Token(Token = "0x6007554")]
	[Address(RVA = "0x1328ED4", Offset = "0x1328ED4", VA = "0x1328ED4")]
	public void Show()
	{
	}

	[Token(Token = "0x6007555")]
	[Address(RVA = "0x1328F20", Offset = "0x1328F20", VA = "0x1328F20")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6007556")]
	[Address(RVA = "0x1329008", Offset = "0x1329008", VA = "0x1329008")]
	public void OnClick_MilestoneRewardPopup()
	{
	}

	[Token(Token = "0x6007557")]
	[Address(RVA = "0x1329148", Offset = "0x1329148", VA = "0x1329148")]
	public void OnClick_FirstRewardPopup()
	{
	}
}
