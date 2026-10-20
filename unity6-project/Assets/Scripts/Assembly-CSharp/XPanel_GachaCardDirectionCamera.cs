using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CC2")]
public class XPanel_GachaCardDirectionCamera : MonoBehaviour
{
	[Token(Token = "0x40040E0")]
	[FieldOffset(Offset = "0xC")]
	public Camera CharacterCamera;

	[Token(Token = "0x40040E1")]
	[FieldOffset(Offset = "0x10")]
	private RenderTexture m_renderTexture;

	[Token(Token = "0x6005BF9")]
	[Address(RVA = "0xFCDE08", Offset = "0xFCDE08", VA = "0xFCDE08")]
	public XPanel_GachaCardDirectionCamera()
	{
	}

	[Token(Token = "0x6005BFA")]
	[Address(RVA = "0xFCDE10", Offset = "0xFCDE10", VA = "0xFCDE10")]
	public void Init()
	{
	}

	[Token(Token = "0x6005BFB")]
	[Address(RVA = "0xFCDE6C", Offset = "0xFCDE6C", VA = "0xFCDE6C")]
	public void LinkRenderTexture(UITexture drawtexture)
	{
	}

	[Token(Token = "0x6005BFC")]
	[Address(RVA = "0xFCDEE0", Offset = "0xFCDEE0", VA = "0xFCDEE0")]
	public void Hide()
	{
	}
}
