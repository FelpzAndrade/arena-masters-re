using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001027")]
public class XUILobbyRankerItem : MonoBehaviour
{
	[Token(Token = "0x40056BD")]
	[FieldOffset(Offset = "0xC")]
	public Transform transformClanMark;

	[Token(Token = "0x40056BE")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ClanMark clanMark;

	[Token(Token = "0x40056BF")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprFrame;

	[Token(Token = "0x40056C0")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x40056C1")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprRank;

	[Token(Token = "0x40056C2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblNickName;

	[Token(Token = "0x40056C3")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_TextScrolling nickNameRolling;

	[Token(Token = "0x40056C4")]
	[FieldOffset(Offset = "0x28")]
	private float elaspedTime;

	[Token(Token = "0x40056C5")]
	[FieldOffset(Offset = "0x2C")]
	private float nextStateTime;

	[Token(Token = "0x40056C6")]
	[FieldOffset(Offset = "0x30")]
	private bool IsNeedRolling;

	[Token(Token = "0x6007887")]
	[Address(RVA = "0x109B67C", Offset = "0x109B67C", VA = "0x109B67C")]
	public XUILobbyRankerItem()
	{
	}

	[Token(Token = "0x6007888")]
	[Address(RVA = "0x109B68C", Offset = "0x109B68C", VA = "0x109B68C")]
	private void Update()
	{
	}

	[Token(Token = "0x6007889")]
	[Address(RVA = "0x109B72C", Offset = "0x109B72C", VA = "0x109B72C")]
	public void BuildClan(int markID, int colorID, int rank, int score, string name)
	{
	}

	[Token(Token = "0x600788A")]
	[Address(RVA = "0x109BC38", Offset = "0x109BC38", VA = "0x109BC38")]
	public void BuildNormal(int profileID, int titleID, int rank, int score, string name)
	{
	}

	[Token(Token = "0x600788B")]
	[Address(RVA = "0x109B95C", Offset = "0x109B95C", VA = "0x109B95C")]
	private void BuildCommon(int rank, int score, string name)
	{
	}
}
