using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FDC")]
public class XWidget_RemainPeriod : MonoBehaviour
{
	[Token(Token = "0x400549A")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblText;

	[Token(Token = "0x400549B")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblRemainTime;

	[Token(Token = "0x400549C")]
	[FieldOffset(Offset = "0x18")]
	private DateTime ExpireAtUtc;

	[Token(Token = "0x6007654")]
	[Address(RVA = "0x1342304", Offset = "0x1342304", VA = "0x1342304")]
	public XWidget_RemainPeriod()
	{
	}

	[Token(Token = "0x6007655")]
	[Address(RVA = "0x134230C", Offset = "0x134230C", VA = "0x134230C")]
	public void Build(DateTime expireAtUtc, DateTime utcNow)
	{
	}

	[Token(Token = "0x6007656")]
	[Address(RVA = "0x134241C", Offset = "0x134241C", VA = "0x134241C")]
	public void UpdateRemain(DateTime utcNow)
	{
	}

	[Token(Token = "0x6007657")]
	[Address(RVA = "0x134257C", Offset = "0x134257C", VA = "0x134257C")]
	public bool IsExpire(DateTime utcNow)
	{
		return default(bool);
	}
}
