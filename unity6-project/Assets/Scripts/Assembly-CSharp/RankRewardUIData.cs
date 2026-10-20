using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001030")]
public class RankRewardUIData
{
	[Token(Token = "0x40056F9")]
	[FieldOffset(Offset = "0x8")]
	public GameObject goRewardRoot;

	[Token(Token = "0x40056FA")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprCurrencyIcon;

	[Token(Token = "0x40056FB")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblRewardAmount;

	[Token(Token = "0x60078B7")]
	[Address(RVA = "0x20EB09C", Offset = "0x20EB09C", VA = "0x20EB09C")]
	public RankRewardUIData()
	{
	}

	[Token(Token = "0x60078B8")]
	[Address(RVA = "0x20EB0A4", Offset = "0x20EB0A4", VA = "0x20EB0A4")]
	public void Build(CSContent content)
	{
	}

	[Token(Token = "0x60078B9")]
	[Address(RVA = "0x20EB2D8", Offset = "0x20EB2D8", VA = "0x20EB2D8")]
	public void SetActive(bool isActive)
	{
	}
}
