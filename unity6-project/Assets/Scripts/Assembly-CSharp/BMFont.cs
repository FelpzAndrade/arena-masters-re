using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200020B")]
public class BMFont
{
	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[HideInInspector]
	private int mSize;

	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[HideInInspector]
	private int mBase;

	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	[SerializeField]
	private int mHeight;

	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, BMGlyph> mDict;

	[Token(Token = "0x17000287")]
	public bool isValid
	{
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x20C0A48", Offset = "0x20C0A48", VA = "0x20C0A48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000288")]
	public int charSize
	{
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x20C0AF0", Offset = "0x20C0AF0", VA = "0x20C0AF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x20C0AF8", Offset = "0x20C0AF8", VA = "0x20C0AF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000289")]
	public int baseOffset
	{
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x20C0B00", Offset = "0x20C0B00", VA = "0x20C0B00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x20C0B08", Offset = "0x20C0B08", VA = "0x20C0B08")]
		set
		{
		}
	}

	[Token(Token = "0x1700028A")]
	public int texWidth
	{
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x20C0B10", Offset = "0x20C0B10", VA = "0x20C0B10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x20C0B18", Offset = "0x20C0B18", VA = "0x20C0B18")]
		set
		{
		}
	}

	[Token(Token = "0x1700028B")]
	public int texHeight
	{
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x20C0B20", Offset = "0x20C0B20", VA = "0x20C0B20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x20C0B28", Offset = "0x20C0B28", VA = "0x20C0B28")]
		set
		{
		}
	}

	[Token(Token = "0x1700028C")]
	public int glyphCount
	{
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x20C0B30", Offset = "0x20C0B30", VA = "0x20C0B30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700028D")]
	public string spriteName
	{
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x20C0BE0", Offset = "0x20C0BE0", VA = "0x20C0BE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x20C0BE8", Offset = "0x20C0BE8", VA = "0x20C0BE8")]
		set
		{
		}
	}

	[Token(Token = "0x1700028E")]
	public List<BMGlyph> glyphs
	{
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x20C0BF0", Offset = "0x20C0BF0", VA = "0x20C0BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x20C0960", Offset = "0x20C0960", VA = "0x20C0960")]
	public BMFont()
	{
	}

	[Token(Token = "0x6001108")]
	[Address(RVA = "0x20C0BF8", Offset = "0x20C0BF8", VA = "0x20C0BF8")]
	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x6001109")]
	[Address(RVA = "0x20C0E44", Offset = "0x20C0E44", VA = "0x20C0E44")]
	public BMGlyph GetGlyph(int index)
	{
		return null;
	}

	[Token(Token = "0x600110A")]
	[Address(RVA = "0x20C0E4C", Offset = "0x20C0E4C", VA = "0x20C0E4C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600110B")]
	[Address(RVA = "0x20C0F10", Offset = "0x20C0F10", VA = "0x20C0F10")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
