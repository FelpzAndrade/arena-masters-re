using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D36")]
public class XWidget_EmoticonMenuItem : MonoBehaviour
{
	[Token(Token = "0x400439D")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprEmoticon;

	[Token(Token = "0x400439E")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x400439F")]
	[FieldOffset(Offset = "0x14")]
	private int m_emoticonSetID;

	[Token(Token = "0x40043A0")]
	[FieldOffset(Offset = "0x18")]
	private int m_emoticonSubID;

	[Token(Token = "0x40043A1")]
	[FieldOffset(Offset = "0x1C")]
	private Action m_onClickAction;

	[Token(Token = "0x60060EA")]
	[Address(RVA = "0x15F4580", Offset = "0x15F4580", VA = "0x15F4580")]
	public XWidget_EmoticonMenuItem()
	{
	}

	[Token(Token = "0x60060EB")]
	[Address(RVA = "0x15F41B0", Offset = "0x15F41B0", VA = "0x15F41B0")]
	public void Build(Sprite image, Action onClickAction)
	{
	}

	[Token(Token = "0x60060EC")]
	[Address(RVA = "0x15F4588", Offset = "0x15F4588", VA = "0x15F4588")]
	public void OnClick_Emoticon()
	{
	}
}
