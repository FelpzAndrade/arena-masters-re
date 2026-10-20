using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FA8")]
public class XWidget_Mark : MonoBehaviour
{
	[Token(Token = "0x40052E4")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprBG;

	[Token(Token = "0x40052E5")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x6007497")]
	[Address(RVA = "0x145DE08", Offset = "0x145DE08", VA = "0x145DE08")]
	public XWidget_Mark()
	{
	}

	[Token(Token = "0x6007498")]
	[Address(RVA = "0x142D6A8", Offset = "0x142D6A8", VA = "0x142D6A8")]
	public void Build(string bgPath, Color bgColor, string iconPath, Color iconColor)
	{
	}

	[Token(Token = "0x6007499")]
	[Address(RVA = "0x145DE10", Offset = "0x145DE10", VA = "0x145DE10")]
	public void BuildBG(string bgPath, Color bgColor)
	{
	}

	[Token(Token = "0x600749A")]
	[Address(RVA = "0x145DE48", Offset = "0x145DE48", VA = "0x145DE48")]
	public void BuildIcon(string iconPath, Color iconColor)
	{
	}

	[Token(Token = "0x600749B")]
	[Address(RVA = "0x145DE80", Offset = "0x145DE80", VA = "0x145DE80")]
	private void BuildSprite(UI2DSprite sprite, string iconPath, Color iconColor)
	{
	}
}
