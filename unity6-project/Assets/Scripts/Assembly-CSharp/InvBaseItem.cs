using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200019E")]
public class InvBaseItem
{
	[Token(Token = "0x200019F")]
	public enum Slot
	{
		[Token(Token = "0x40005F4")]
		None = 0,
		[Token(Token = "0x40005F5")]
		Weapon = 1,
		[Token(Token = "0x40005F6")]
		Shield = 2,
		[Token(Token = "0x40005F7")]
		Body = 3,
		[Token(Token = "0x40005F8")]
		Shoulders = 4,
		[Token(Token = "0x40005F9")]
		Bracers = 5,
		[Token(Token = "0x40005FA")]
		Boots = 6,
		[Token(Token = "0x40005FB")]
		Trinket = 7,
		[Token(Token = "0x40005FC")]
		_LastDoNotUse = 8
	}

	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x8")]
	public int id16;

	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x10")]
	public string description;

	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x14")]
	public Slot slot;

	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x18")]
	public int minItemLevel;

	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x1C")]
	public int maxItemLevel;

	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x20")]
	public List<InvStat> stats;

	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject attachment;

	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x28")]
	public Color color;

	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x38")]
	public UIAtlas iconAtlas;

	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x3C")]
	public string iconName;

	[Token(Token = "0x6000E82")]
	[Address(RVA = "0xD8F630", Offset = "0xD8F630", VA = "0xD8F630")]
	public InvBaseItem()
	{
	}
}
