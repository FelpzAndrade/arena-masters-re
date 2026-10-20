using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20001A4")]
public class InvStat
{
	[Token(Token = "0x20001A5")]
	public enum Identifier
	{
		[Token(Token = "0x400061A")]
		Strength = 0,
		[Token(Token = "0x400061B")]
		Constitution = 1,
		[Token(Token = "0x400061C")]
		Agility = 2,
		[Token(Token = "0x400061D")]
		Intelligence = 3,
		[Token(Token = "0x400061E")]
		Damage = 4,
		[Token(Token = "0x400061F")]
		Crit = 5,
		[Token(Token = "0x4000620")]
		Armor = 6,
		[Token(Token = "0x4000621")]
		Health = 7,
		[Token(Token = "0x4000622")]
		Mana = 8,
		[Token(Token = "0x4000623")]
		Other = 9
	}

	[Token(Token = "0x20001A6")]
	public enum Modifier
	{
		[Token(Token = "0x4000625")]
		Added = 0,
		[Token(Token = "0x4000626")]
		Percent = 1
	}

	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x8")]
	public Identifier id;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0xC")]
	public Modifier modifier;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0xD92504", Offset = "0xD92504", VA = "0xD92504")]
	public InvStat()
	{
	}

	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0xD9256C", Offset = "0xD9256C", VA = "0xD9256C")]
	public static string GetName(Identifier i)
	{
		return null;
	}

	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0xD92640", Offset = "0xD92640", VA = "0xD92640")]
	public static string GetDescription(Identifier i)
	{
		return null;
	}

	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0xD927BC", Offset = "0xD927BC", VA = "0xD927BC")]
	public static int CompareArmor(InvStat a, InvStat b)
	{
		return default(int);
	}

	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0xD92868", Offset = "0xD92868", VA = "0xD92868")]
	public static int CompareWeapon(InvStat a, InvStat b)
	{
		return default(int);
	}
}
