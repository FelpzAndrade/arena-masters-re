using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200020C")]
public class BMGlyph
{
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x8")]
	public int index;

	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0xC")]
	public int x;

	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x10")]
	public int y;

	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x14")]
	public int width;

	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x18")]
	public int height;

	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x1C")]
	public int offsetX;

	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x20")]
	public int offsetY;

	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x24")]
	public int advance;

	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x28")]
	public int channel;

	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x2C")]
	public List<int> kerning;

	[Token(Token = "0x600110C")]
	[Address(RVA = "0x20C0E3C", Offset = "0x20C0E3C", VA = "0x20C0E3C")]
	public BMGlyph()
	{
	}

	[Token(Token = "0x600110D")]
	[Address(RVA = "0x20C10CC", Offset = "0x20C10CC", VA = "0x20C10CC")]
	public int GetKerning(int previousChar)
	{
		return default(int);
	}

	[Token(Token = "0x600110E")]
	[Address(RVA = "0x20C11F8", Offset = "0x20C11F8", VA = "0x20C11F8")]
	public void SetKerning(int previousChar, int amount)
	{
	}

	[Token(Token = "0x600110F")]
	[Address(RVA = "0x20C1038", Offset = "0x20C1038", VA = "0x20C1038")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
