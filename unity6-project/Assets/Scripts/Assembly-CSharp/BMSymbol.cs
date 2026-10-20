using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200020D")]
public class BMSymbol
{
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x8")]
	public string sequence;

	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0xC")]
	public string spriteName;

	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x10")]
	private UISpriteData mSprite;

	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x14")]
	private bool mIsValid;

	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x18")]
	private int mLength;

	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x1C")]
	private int mOffsetX;

	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x20")]
	private int mOffsetY;

	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x24")]
	private int mWidth;

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x28")]
	private int mHeight;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x2C")]
	private int mAdvance;

	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x30")]
	private Rect mUV;

	[Token(Token = "0x1700028F")]
	public int length
	{
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x20C13C8", Offset = "0x20C13C8", VA = "0x20C13C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000290")]
	public int offsetX
	{
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x20C1408", Offset = "0x20C1408", VA = "0x20C1408")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000291")]
	public int offsetY
	{
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x20C1410", Offset = "0x20C1410", VA = "0x20C1410")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000292")]
	public int width
	{
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x20C1418", Offset = "0x20C1418", VA = "0x20C1418")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000293")]
	public int height
	{
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x20C1420", Offset = "0x20C1420", VA = "0x20C1420")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000294")]
	public int advance
	{
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x20C1428", Offset = "0x20C1428", VA = "0x20C1428")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000295")]
	public Rect uvRect
	{
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x20C1430", Offset = "0x20C1430", VA = "0x20C1430")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x6001110")]
	[Address(RVA = "0x20C13C0", Offset = "0x20C13C0", VA = "0x20C13C0")]
	public BMSymbol()
	{
	}

	[Token(Token = "0x6001118")]
	[Address(RVA = "0x20C1440", Offset = "0x20C1440", VA = "0x20C1440")]
	public void MarkAsChanged()
	{
	}

	[Token(Token = "0x6001119")]
	[Address(RVA = "0x20C144C", Offset = "0x20C144C", VA = "0x20C144C")]
	public bool Validate(UIAtlas atlas)
	{
		return default(bool);
	}
}
