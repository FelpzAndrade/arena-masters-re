using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20001A2")]
public class InvGameItem
{
	[Token(Token = "0x20001A3")]
	public enum Quality
	{
		[Token(Token = "0x4000609")]
		Broken = 0,
		[Token(Token = "0x400060A")]
		Cursed = 1,
		[Token(Token = "0x400060B")]
		Damaged = 2,
		[Token(Token = "0x400060C")]
		Worn = 3,
		[Token(Token = "0x400060D")]
		Sturdy = 4,
		[Token(Token = "0x400060E")]
		Polished = 5,
		[Token(Token = "0x400060F")]
		Improved = 6,
		[Token(Token = "0x4000610")]
		Crafted = 7,
		[Token(Token = "0x4000611")]
		Superior = 8,
		[Token(Token = "0x4000612")]
		Enchanted = 9,
		[Token(Token = "0x4000613")]
		Epic = 10,
		[Token(Token = "0x4000614")]
		Legendary = 11,
		[Token(Token = "0x4000615")]
		_LastDoNotUse = 12
	}

	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private int mBaseItemID;

	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0xC")]
	public Quality quality;

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x10")]
	public int itemLevel;

	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x14")]
	private InvBaseItem mBaseItem;

	[Token(Token = "0x17000242")]
	public int baseItemID
	{
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0xD91C58", Offset = "0xD91C58", VA = "0xD91C58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000243")]
	public InvBaseItem baseItem
	{
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0xD918C0", Offset = "0xD918C0", VA = "0xD918C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000244")]
	public string name
	{
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0xD91974", Offset = "0xD91974", VA = "0xD91974")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000245")]
	public float statMultiplier
	{
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0xD91E98", Offset = "0xD91E98", VA = "0xD91E98")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000246")]
	public Color color
	{
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0xD91FB8", Offset = "0xD91FB8", VA = "0xD91FB8")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0xD91E28", Offset = "0xD91E28", VA = "0xD91E28")]
	public InvGameItem(int id)
	{
	}

	[Token(Token = "0x6000E97")]
	[Address(RVA = "0xD91E5C", Offset = "0xD91E5C", VA = "0xD91E5C")]
	public InvGameItem(int id, InvBaseItem bi)
	{
	}

	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0xD9216C", Offset = "0xD9216C", VA = "0xD9216C")]
	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
