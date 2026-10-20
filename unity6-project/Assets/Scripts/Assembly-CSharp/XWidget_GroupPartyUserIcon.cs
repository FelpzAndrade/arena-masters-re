using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DA0")]
public class XWidget_GroupPartyUserIcon : MonoBehaviour
{
	[Token(Token = "0x40046C9")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x40046CA")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x40046CB")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x40046CC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goSprReady;

	[Token(Token = "0x40046CD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goSprMaster;

	[Token(Token = "0x6006445")]
	[Address(RVA = "0x143F308", Offset = "0x143F308", VA = "0x143F308")]
	public XWidget_GroupPartyUserIcon()
	{
	}

	[Token(Token = "0x6006446")]
	[Address(RVA = "0x143E158", Offset = "0x143E158", VA = "0x143E158")]
	public void Build(NetMatchPlayerInfo player, string masterName)
	{
	}
}
