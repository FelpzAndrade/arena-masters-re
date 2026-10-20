using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E87")]
public class XWidget_ButtonOpenClanWar : MonoBehaviour, IClanWarListener
{
	[Token(Token = "0x4004C19")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Button btn;

	[Token(Token = "0x4004C1A")]
	[FieldOffset(Offset = "0x10")]
	public GameObject rankingRemainTimeObject;

	[Token(Token = "0x4004C1B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblDayOfWeek;

	[Token(Token = "0x4004C1C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRankingRemainTime;

	[Token(Token = "0x4004C1D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblVersus;

	[Token(Token = "0x4004C1E")]
	[FieldOffset(Offset = "0x20")]
	private bool isModeOpened;

	[Token(Token = "0x6006C45")]
	[Address(RVA = "0x15C5878", Offset = "0x15C5878", VA = "0x15C5878")]
	public XWidget_ButtonOpenClanWar()
	{
	}

	[Token(Token = "0x6006C46")]
	[Address(RVA = "0x15C5880", Offset = "0x15C5880", VA = "0x15C5880")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006C47")]
	[Address(RVA = "0x15C59F8", Offset = "0x15C59F8", VA = "0x15C59F8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006C48")]
	[Address(RVA = "0x15C5ADC", Offset = "0x15C5ADC", VA = "0x15C5ADC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006C49")]
	[Address(RVA = "0x15C5C68", Offset = "0x15C5C68", VA = "0x15C5C68")]
	public void SetLadderChatClanWarButton(bool active)
	{
	}

	[Token(Token = "0x6006C4A")]
	[Address(RVA = "0x15C5AE0", Offset = "0x15C5AE0", VA = "0x15C5AE0")]
	public void CheckOpenFeature()
	{
	}

	[Token(Token = "0x6006C4B")]
	[Address(RVA = "0x15C5FB4", Offset = "0x15C5FB4", VA = "0x15C5FB4")]
	private void OpenClanWar()
	{
	}

	[Token(Token = "0x6006C4C")]
	[Address(RVA = "0x15C65F0", Offset = "0x15C65F0", VA = "0x15C65F0")]
	private void PrepareClanWar()
	{
	}

	[Token(Token = "0x6006C4D")]
	[Address(RVA = "0x15C61A4", Offset = "0x15C61A4", VA = "0x15C61A4")]
	private void SetDayOfWeek()
	{
	}

	[Token(Token = "0x6006C4E")]
	[Address(RVA = "0x15C62BC", Offset = "0x15C62BC", VA = "0x15C62BC")]
	private bool GetModeOpened()
	{
		return default(bool);
	}

	[Token(Token = "0x6006C4F")]
	[Address(RVA = "0x15C5D80", Offset = "0x15C5D80", VA = "0x15C5D80")]
	private bool GetIsLadderMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6006C50")]
	[Address(RVA = "0x15C6398", Offset = "0x15C6398", VA = "0x15C6398")]
	private void BuildRemainTime(bool isModeOpenTime)
	{
	}

	[Token(Token = "0x6006C51")]
	[Address(RVA = "0x15C6824", Offset = "0x15C6824", VA = "0x15C6824")]
	private void DescriptRemainTime(bool open, StringBuilder stringBuilder, DayOfWeek dayOfWeek)
	{
	}

	[Token(Token = "0x6006C52")]
	[Address(RVA = "0x15C6B34", Offset = "0x15C6B34", VA = "0x15C6B34")]
	private void SetTextRankingRemainTime(StringBuilder stringBuilder)
	{
	}

	[Token(Token = "0x6006C53")]
	[Address(RVA = "0x15C6C5C", Offset = "0x15C6C5C", VA = "0x15C6C5C")]
	private string GetRankTypeString()
	{
		return null;
	}

	[Token(Token = "0x6006C54")]
	[Address(RVA = "0x15C6D00", Offset = "0x15C6D00", VA = "0x15C6D00")]
	public void OnClick_ClanWar()
	{
	}

	[Token(Token = "0x6006C55")]
	[Address(RVA = "0x15C5E5C", Offset = "0x15C5E5C", VA = "0x15C5E5C")]
	private void RefreshInParty(bool enable)
	{
	}

	[Token(Token = "0x6006C56")]
	[Address(RVA = "0x15C6EB8", Offset = "0x15C6EB8", VA = "0x15C6EB8", Slot = "4")]
	public void OnCreateParty(DTPartyInfo party)
	{
	}

	[Token(Token = "0x6006C57")]
	[Address(RVA = "0x15C6EC0", Offset = "0x15C6EC0", VA = "0x15C6EC0", Slot = "5")]
	public void OnJoinParty1(DTPartyInfo party)
	{
	}

	[Token(Token = "0x6006C58")]
	[Address(RVA = "0x15C6EC8", Offset = "0x15C6EC8", VA = "0x15C6EC8", Slot = "6")]
	public void OnLeaveParty(DTPartyInfo party)
	{
	}

	[Token(Token = "0x6006C59")]
	[Address(RVA = "0x15C6ED0", Offset = "0x15C6ED0", VA = "0x15C6ED0", Slot = "7")]
	public void OnPartyBreak(long partyKey)
	{
	}

	[Token(Token = "0x6006C5A")]
	[Address(RVA = "0x15C6ED8", Offset = "0x15C6ED8", VA = "0x15C6ED8", Slot = "8")]
	public void OnClanMatchStart(DTPartyInfo party)
	{
	}

	[Token(Token = "0x6006C5B")]
	[Address(RVA = "0x15C6EE0", Offset = "0x15C6EE0", VA = "0x15C6EE0", Slot = "9")]
	public void OnClanMatchCancel()
	{
	}

	[Token(Token = "0x6006C5C")]
	[Address(RVA = "0x15C6EE8", Offset = "0x15C6EE8", VA = "0x15C6EE8", Slot = "10")]
	public void OnRefreshInParty()
	{
	}

	[Token(Token = "0x6006C5D")]
	[Address(RVA = "0x15C6EF0", Offset = "0x15C6EF0", VA = "0x15C6EF0", Slot = "11")]
	public void OnRefreshMyClanParty(DTPartyInfo party)
	{
	}
}
