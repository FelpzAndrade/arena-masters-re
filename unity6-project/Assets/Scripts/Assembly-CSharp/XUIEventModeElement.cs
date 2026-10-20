using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E1")]
public class XUIEventModeElement : XUIModeElementBase
{
	[Token(Token = "0x40020CA")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_EventModeTime time;

	[Token(Token = "0x40020CB")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblOrder;

	[Token(Token = "0x40020CC")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_EventMilestoneReward milestoneReward;

	[Token(Token = "0x40020CD")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_EventRecordStatus status;

	[Token(Token = "0x40020CE")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject goEnterCost;

	[Token(Token = "0x40020CF")]
	[FieldOffset(Offset = "0x40")]
	public UITable tableCost;

	[Token(Token = "0x40020D0")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblCostCount;

	[Token(Token = "0x40020D1")]
	[FieldOffset(Offset = "0x48")]
	public UI2DSprite sprCostType;

	[Token(Token = "0x40020D2")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_Libbon libbon;

	[Token(Token = "0x40020D3")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblModeName;

	[Token(Token = "0x40020D4")]
	[FieldOffset(Offset = "0x54")]
	public XWidget_Mark modeMark;

	[Token(Token = "0x40020D5")]
	[FieldOffset(Offset = "0x58")]
	public GameObject goGetReward;

	[Token(Token = "0x40020D6")]
	[FieldOffset(Offset = "0x5C")]
	private GameModeInstanceInfo m_modeInstanceInfo;

	[Token(Token = "0x40020D7")]
	[FieldOffset(Offset = "0x60")]
	private EventGameModeInfo m_eventInfo;

	[Token(Token = "0x40020D8")]
	[FieldOffset(Offset = "0x64")]
	private EventGameRewardGroup m_rewardInfo;

	[Token(Token = "0x40020D9")]
	[FieldOffset(Offset = "0x68")]
	private int m_unlockNeedLv;

	[Token(Token = "0x40020DA")]
	[FieldOffset(Offset = "0x6C")]
	private int hideLevel;

	[Token(Token = "0x40020DB")]
	[FieldOffset(Offset = "0x70")]
	private DateTime startGroupDateTime;

	[Token(Token = "0x40020DC")]
	[FieldOffset(Offset = "0x80")]
	private DateTime endGroupDateTime;

	[Token(Token = "0x40020DD")]
	[FieldOffset(Offset = "0x90")]
	private Action onAllModeRefresh;

	[Token(Token = "0x17000819")]
	public EventGameModeInfo EventInfo
	{
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x1A41DC8", Offset = "0x1A41DC8", VA = "0x1A41DC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081A")]
	public EventGameRewardGroup RewardInfo
	{
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x1A41DD0", Offset = "0x1A41DD0", VA = "0x1A41DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003992")]
	[Address(RVA = "0x1A41DB8", Offset = "0x1A41DB8", VA = "0x1A41DB8")]
	public XUIEventModeElement()
	{
	}

	[Token(Token = "0x6003995")]
	[Address(RVA = "0x1A41DD8", Offset = "0x1A41DD8", VA = "0x1A41DD8")]
	public void Init(bool isExistRecievableFirstReward, XMyInfo myInfo, GameModeInstanceInfo instanceInfo, EventGameModeInfo eventInfo, EventGameRewardGroup rewardInfo, int unlockNeedLv, Action onRefresh, DateTime startGroupDateTime, DateTime endGroupDateTime, bool isCurrent)
	{
	}

	[Token(Token = "0x6003996")]
	[Address(RVA = "0x1A42270", Offset = "0x1A42270", VA = "0x1A42270")]
	public void BuildEventStatus(bool isExistRecievableFirstReward, XMyInfo myInfo, EventGameModeInfo eventModeInfo, EventGameRewardGroup rewardInfo)
	{
	}

	[Token(Token = "0x6003997")]
	[Address(RVA = "0x1A426C4", Offset = "0x1A426C4", VA = "0x1A426C4")]
	private void BuildEnterCost(bool isShow, bool isFreeEnter, Currency enterCostType, int enterCostCount)
	{
	}

	[Token(Token = "0x6003998")]
	[Address(RVA = "0x1A424AC", Offset = "0x1A424AC", VA = "0x1A424AC")]
	private void BuildEventTime(bool bActiveRemainTime, DateTime startGroupDateTime, DateTime endGroupDateTime, DateTime startDateTime, DateTime endDateTime, bool isFirst)
	{
	}

	[Token(Token = "0x6003999")]
	[Address(RVA = "0x1A42698", Offset = "0x1A42698", VA = "0x1A42698")]
	private void SetActiveGetReward(bool bActive)
	{
	}

	[Token(Token = "0x600399A")]
	[Address(RVA = "0x1A42AF8", Offset = "0x1A42AF8", VA = "0x1A42AF8")]
	public void RefreshTime()
	{
	}

	[Token(Token = "0x600399B")]
	[Address(RVA = "0x1A42E14", Offset = "0x1A42E14", VA = "0x1A42E14")]
	public void BuildLock(int level)
	{
	}

	[Token(Token = "0x600399C")]
	[Address(RVA = "0x1A42E50", Offset = "0x1A42E50", VA = "0x1A42E50")]
	public bool IsOpend()
	{
		return default(bool);
	}

	[Token(Token = "0x600399D")]
	[Address(RVA = "0x1A42900", Offset = "0x1A42900", VA = "0x1A42900")]
	public bool IsGroupOpend()
	{
		return default(bool);
	}

	[Token(Token = "0x600399E")]
	[Address(RVA = "0x1A42148", Offset = "0x1A42148", VA = "0x1A42148")]
	public void Refresh(bool isExistRecievableFirstReward, XMyInfo myInfo)
	{
	}

	[Token(Token = "0x600399F")]
	[Address(RVA = "0x1A42F58", Offset = "0x1A42F58", VA = "0x1A42F58")]
	public void OnClick_Help()
	{
	}
}
