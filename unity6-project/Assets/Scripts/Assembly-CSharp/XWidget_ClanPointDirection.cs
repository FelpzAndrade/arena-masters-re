using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D91")]
public class XWidget_ClanPointDirection : MonoBehaviour
{
	[Token(Token = "0x4004671")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprMark;

	[Token(Token = "0x4004672")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblName;

	[Token(Token = "0x4004673")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblScore;

	[Token(Token = "0x4004674")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblScoreText;

	[Token(Token = "0x4004675")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblClanWarPoint;

	[Token(Token = "0x4004676")]
	[FieldOffset(Offset = "0x20")]
	public GameObject clanWarPointRoot;

	[Token(Token = "0x4004677")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<MatchPlayerInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x60063AF")]
	[Address(RVA = "0x15E4C4C", Offset = "0x15E4C4C", VA = "0x15E4C4C")]
	public XWidget_ClanPointDirection()
	{
	}

	[Token(Token = "0x60063B0")]
	[Address(RVA = "0x15E4C54", Offset = "0x15E4C54", VA = "0x15E4C54")]
	public void Show(int beforeClanScore, XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x60063B1")]
	[Address(RVA = "0x15E584C", Offset = "0x15E584C", VA = "0x15E584C")]
	private int GetBeforeClanScore()
	{
		return default(int);
	}

	[Token(Token = "0x60063B2")]
	[Address(RVA = "0x15E5448", Offset = "0x15E5448", VA = "0x15E5448")]
	private int GetAcquireClanPoint(XPlayerManager playerManager)
	{
		return default(int);
	}

	[Token(Token = "0x60063B3")]
	[Address(RVA = "0x15E5110", Offset = "0x15E5110", VA = "0x15E5110")]
	private void BuildClanMark(int markId, int markColorId)
	{
	}

	[Token(Token = "0x60063B4")]
	[Address(RVA = "0x15E5AD4", Offset = "0x15E5AD4", VA = "0x15E5AD4")]
	public void Hide()
	{
	}

	[Token(Token = "0x60063B5")]
	[Address(RVA = "0x15E5B08", Offset = "0x15E5B08", VA = "0x15E5B08")]
	private static bool _003CShow_003Em__31B(MatchPlayerInfo item)
	{
		return default(bool);
	}
}
