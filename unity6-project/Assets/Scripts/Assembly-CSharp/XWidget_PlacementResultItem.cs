using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D3C")]
public class XWidget_PlacementResultItem : MonoBehaviour
{
	[Token(Token = "0x40043D1")]
	[FieldOffset(Offset = "0xC")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x40043D2")]
	[FieldOffset(Offset = "0x10")]
	public UISprite sprHighlight;

	[Token(Token = "0x40043D3")]
	[FieldOffset(Offset = "0x14")]
	public UISprite sprResult;

	[Token(Token = "0x600611A")]
	[Address(RVA = "0x13199C8", Offset = "0x13199C8", VA = "0x13199C8")]
	public XWidget_PlacementResultItem()
	{
	}

	[Token(Token = "0x600611B")]
	[Address(RVA = "0x13199D0", Offset = "0x13199D0", VA = "0x13199D0")]
	public void Buid(bool current, CSWinlose winlose)
	{
	}

	[Token(Token = "0x600611C")]
	[Address(RVA = "0x1319C74", Offset = "0x1319C74", VA = "0x1319C74")]
	public void ResetPlayTween()
	{
	}

	[Token(Token = "0x600611D")]
	[Address(RVA = "0x1319CB8", Offset = "0x1319CB8", VA = "0x1319CB8")]
	public void EndPlayTween()
	{
	}

	[Token(Token = "0x600611E")]
	[Address(RVA = "0x1319B94", Offset = "0x1319B94", VA = "0x1319B94")]
	private string GetHighlightSpriteName(CSWinlose winlose)
	{
		return null;
	}
}
