using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA9")]
public class XWidget_Tooltip : MonoBehaviour
{
	[Token(Token = "0x4004083")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_NGUITween tween;

	[Token(Token = "0x4004084")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblText;

	[Token(Token = "0x4004085")]
	[FieldOffset(Offset = "0x14")]
	public UISprite sprBg;

	[Token(Token = "0x6005B69")]
	[Address(RVA = "0x1B27B18", Offset = "0x1B27B18", VA = "0x1B27B18")]
	public XWidget_Tooltip()
	{
	}

	[Token(Token = "0x6005B6A")]
	[Address(RVA = "0x1B27B20", Offset = "0x1B27B20", VA = "0x1B27B20")]
	public void Show(Transform parent, string text)
	{
	}

	[Token(Token = "0x6005B6B")]
	[Address(RVA = "0x1B27BD0", Offset = "0x1B27BD0", VA = "0x1B27BD0")]
	public void Show(string text)
	{
	}
}
