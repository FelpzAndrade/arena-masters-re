using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6F")]
public class XWidget_BroadcastMsg : MonoBehaviour
{
	[Token(Token = "0x4003F09")]
	[FieldOffset(Offset = "0xC")]
	public UISprite sprIcon;

	[Token(Token = "0x4003F0A")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblMessge;

	[Token(Token = "0x60059B5")]
	[Address(RVA = "0x15C20B0", Offset = "0x15C20B0", VA = "0x15C20B0")]
	public XWidget_BroadcastMsg()
	{
	}

	[Token(Token = "0x60059B6")]
	[Address(RVA = "0x15C20B8", Offset = "0x15C20B8", VA = "0x15C20B8")]
	public void BuildNoneUI()
	{
	}

	[Token(Token = "0x60059B7")]
	[Address(RVA = "0x15C2308", Offset = "0x15C2308", VA = "0x15C2308")]
	public void BuildNoticeUI(ChatMessage chatMsg)
	{
	}

	[Token(Token = "0x60059B8")]
	[Address(RVA = "0x15C2534", Offset = "0x15C2534", VA = "0x15C2534")]
	public void BuildShowoffUI(ChatMessage chatMsg)
	{
	}

	[Token(Token = "0x60059B9")]
	[Address(RVA = "0x15C264C", Offset = "0x15C264C", VA = "0x15C264C")]
	public void BuildChatUI(ChatMessage chatMsg)
	{
	}

	[Token(Token = "0x60059BA")]
	[Address(RVA = "0x15C21F0", Offset = "0x15C21F0", VA = "0x15C21F0")]
	private void BuildIcon(Color color, string spriteName)
	{
	}

	[Token(Token = "0x60059BB")]
	[Address(RVA = "0x15C2420", Offset = "0x15C2420", VA = "0x15C2420")]
	private void BuildText(Color color, string text)
	{
	}
}
