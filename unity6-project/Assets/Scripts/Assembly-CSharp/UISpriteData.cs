using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200028D")]
public class UISpriteData
{
	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0xC")]
	public int x;

	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x10")]
	public int y;

	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x14")]
	public int width;

	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x18")]
	public int height;

	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0x1C")]
	public int borderLeft;

	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x20")]
	public int borderRight;

	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0x24")]
	public int borderTop;

	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0x28")]
	public int borderBottom;

	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0x2C")]
	public int paddingLeft;

	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x30")]
	public int paddingRight;

	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x34")]
	public int paddingTop;

	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0x38")]
	public int paddingBottom;

	[Token(Token = "0x170003BF")]
	public bool hasBorder
	{
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x179EE7C", Offset = "0x179EE7C", VA = "0x179EE7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003C0")]
	public bool hasPadding
	{
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x179FF80", Offset = "0x179FF80", VA = "0x179FF80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001677")]
	[Address(RVA = "0x179FEF4", Offset = "0x179FEF4", VA = "0x179FEF4")]
	public UISpriteData()
	{
	}

	[Token(Token = "0x600167A")]
	[Address(RVA = "0x179FFA0", Offset = "0x179FFA0", VA = "0x179FFA0")]
	public void SetRect(int x, int y, int width, int height)
	{
	}

	[Token(Token = "0x600167B")]
	[Address(RVA = "0x179FFB8", Offset = "0x179FFB8", VA = "0x179FFB8")]
	public void SetPadding(int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x600167C")]
	[Address(RVA = "0x179FFD0", Offset = "0x179FFD0", VA = "0x179FFD0")]
	public void SetBorder(int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x600167D")]
	[Address(RVA = "0x179FFE8", Offset = "0x179FFE8", VA = "0x179FFE8")]
	public void CopyFrom(UISpriteData sd)
	{
	}

	[Token(Token = "0x600167E")]
	[Address(RVA = "0x17A006C", Offset = "0x17A006C", VA = "0x17A006C")]
	public void CopyBorderFrom(UISpriteData sd)
	{
	}
}
