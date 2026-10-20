using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB4")]
public class XWidget_EventModeTime : MonoBehaviour
{
	[Token(Token = "0x4004D44")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goRootCloseRemainTime;

	[Token(Token = "0x4004D45")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goRootOpenRemainTime;

	[Token(Token = "0x4004D46")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_CoolTime closeRemainCoolTime;

	[Token(Token = "0x4004D47")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_CoolTime openRemainCoolTime;

	[Token(Token = "0x4004D48")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblGroupOpenTime;

	[Token(Token = "0x4004D49")]
	[FieldOffset(Offset = "0x20")]
	private DateTime eventStartTime;

	[Token(Token = "0x4004D4A")]
	[FieldOffset(Offset = "0x30")]
	private DateTime eventEndTime;

	[Token(Token = "0x4004D4B")]
	[FieldOffset(Offset = "0x40")]
	private DateTime evnetGroupStartTime;

	[Token(Token = "0x4004D4C")]
	[FieldOffset(Offset = "0x50")]
	private DateTime eventGroupEndTime;

	[Token(Token = "0x4004D4D")]
	[FieldOffset(Offset = "0x60")]
	public Action onCoolEnd;

	[Token(Token = "0x6006D97")]
	[Address(RVA = "0x14291B8", Offset = "0x14291B8", VA = "0x14291B8")]
	public XWidget_EventModeTime()
	{
	}

	[Token(Token = "0x6006D98")]
	[Address(RVA = "0x14291C0", Offset = "0x14291C0", VA = "0x14291C0")]
	public void BuildGroupOpenTime(DateTime evnetGroupStartTime, DateTime eventGroupEndTime)
	{
	}

	[Token(Token = "0x6006D99")]
	[Address(RVA = "0x14293CC", Offset = "0x14293CC", VA = "0x14293CC")]
	private DateTime GetNowLocalTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6006D9A")]
	[Address(RVA = "0x14294A0", Offset = "0x14294A0", VA = "0x14294A0")]
	private bool IsOpend(DateTime eventStartTime, DateTime eventEndTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D9B")]
	[Address(RVA = "0x1429610", Offset = "0x1429610", VA = "0x1429610")]
	private void OnCoolEnd()
	{
	}

	[Token(Token = "0x6006D9C")]
	[Address(RVA = "0x1429624", Offset = "0x1429624", VA = "0x1429624")]
	public void BuildRemainTime(DateTime eventStartTime, DateTime eventEndTime, Action OnCoolEnd)
	{
	}

	[Token(Token = "0x6006D9D")]
	[Address(RVA = "0x14298F8", Offset = "0x14298F8", VA = "0x14298F8")]
	private void BuildOpenRemainTime(DateTime nowTime, DateTime eventStartTime)
	{
	}

	[Token(Token = "0x6006D9E")]
	[Address(RVA = "0x1429734", Offset = "0x1429734", VA = "0x1429734")]
	private void BuildCloseRemainTime(DateTime nowTime, DateTime eventEndTime)
	{
	}

	[Token(Token = "0x6006D9F")]
	[Address(RVA = "0x1429ABC", Offset = "0x1429ABC", VA = "0x1429ABC")]
	private void SetActiveRootObject(bool isOpend)
	{
	}

	[Token(Token = "0x6006DA0")]
	[Address(RVA = "0x1429B0C", Offset = "0x1429B0C", VA = "0x1429B0C")]
	public void SetActiveRemainTimeObject(bool bActive)
	{
	}
}
