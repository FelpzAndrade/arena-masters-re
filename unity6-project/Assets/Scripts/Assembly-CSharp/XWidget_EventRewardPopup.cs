using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB6")]
public class XWidget_EventRewardPopup : XUIBaseWidget
{
	[Token(Token = "0x2000EB7")]
	private class RewardUIInfo
	{
		[Token(Token = "0x4004D68")]
		[FieldOffset(Offset = "0x8")]
		public int conditionCount;

		[Token(Token = "0x4004D69")]
		[FieldOffset(Offset = "0xC")]
		public ConditionType targetCondition;

		[Token(Token = "0x4004D6A")]
		[FieldOffset(Offset = "0x10")]
		public List<CSContent> contents;

		[Token(Token = "0x6006DAA")]
		[Address(RVA = "0x142B364", Offset = "0x142B364", VA = "0x142B364")]
		public RewardUIInfo()
		{
		}
	}

	[Token(Token = "0x4004D5D")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel rootPanel;

	[Token(Token = "0x4004D5E")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004D5F")]
	[FieldOffset(Offset = "0x24")]
	public Transform pool;

	[Token(Token = "0x4004D60")]
	[FieldOffset(Offset = "0x28")]
	public int posY_space;

	[Token(Token = "0x4004D61")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblTitle;

	[Token(Token = "0x4004D62")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblBottomText;

	[Token(Token = "0x4004D63")]
	[FieldOffset(Offset = "0x34")]
	private float m_addPosY;

	[Token(Token = "0x4004D64")]
	[FieldOffset(Offset = "0x38")]
	public XUIEventModeRewardItem OriginObject;

	[Token(Token = "0x4004D65")]
	[FieldOffset(Offset = "0x3C")]
	private List<RewardUIInfo> m_info;

	[Token(Token = "0x4004D66")]
	[FieldOffset(Offset = "0x40")]
	private List<XUIEventModeRewardItem> used;

	[Token(Token = "0x4004D67")]
	[FieldOffset(Offset = "0x44")]
	private List<XUIEventModeRewardItem> unused;

	[Token(Token = "0x6006DA3")]
	[Address(RVA = "0x142A568", Offset = "0x142A568", VA = "0x142A568")]
	public XWidget_EventRewardPopup()
	{
	}

	[Token(Token = "0x6006DA4")]
	[Address(RVA = "0x142A668", Offset = "0x142A668", VA = "0x142A668")]
	public void Show(int panelDepth, RewardType rewardType, EventGameRewardGroup rewardGroupInfo, string titleText, string bottomText)
	{
	}

	[Token(Token = "0x6006DA5")]
	[Address(RVA = "0x142AED0", Offset = "0x142AED0", VA = "0x142AED0")]
	private void Build()
	{
	}

	[Token(Token = "0x6006DA6")]
	[Address(RVA = "0x142AA18", Offset = "0x142AA18", VA = "0x142AA18")]
	public void Clear()
	{
	}

	[Token(Token = "0x6006DA7")]
	[Address(RVA = "0x142B0E0", Offset = "0x142B0E0", VA = "0x142B0E0")]
	private XUIEventModeRewardItem GetClone()
	{
		return null;
	}

	[Token(Token = "0x6006DA8")]
	[Address(RVA = "0x142AFF8", Offset = "0x142AFF8", VA = "0x142AFF8")]
	private void BuildAndSetPos(RewardUIInfo info, bool isLast)
	{
	}

	[Token(Token = "0x6006DA9")]
	[Address(RVA = "0x142AC58", Offset = "0x142AC58", VA = "0x142AC58")]
	private List<RewardUIInfo> GetRewardUIInfo(EventGameRewardGroup rewardGroupInfo, RewardType targetRewardType, ConditionType targetCondition)
	{
		return null;
	}
}
