using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B4E")]
	public enum SkillPassiveTiming
	{
		[Token(Token = "0x4003880")]
		None = 0,
		[Token(Token = "0x4003881")]
		Kill = 1,
		[Token(Token = "0x4003882")]
		Revive = 2,
		[Token(Token = "0x4003883")]
		DeathsDoor = 3,
		[Token(Token = "0x4003884")]
		Controlled = 4,
		[Token(Token = "0x4003885")]
		Tag = 5,
		[Token(Token = "0x4003886")]
		Dodge = 6,
		[Token(Token = "0x4003887")]
		Death = 7,
		[Token(Token = "0x4003888")]
		Hit = 8,
		[Token(Token = "0x4003889")]
		Damage = 9,
		[Token(Token = "0x400388A")]
		EnterDeathsDoor = 10,
		[Token(Token = "0x400388B")]
		HitMe = 11,
		[Token(Token = "0x400388C")]
		DamageMe = 12,
		[Token(Token = "0x400388D")]
		PhysicalDamage = 13,
		[Token(Token = "0x400388E")]
		MagicalDamage = 14,
		[Token(Token = "0x400388F")]
		PhysicalDamageMe = 15,
		[Token(Token = "0x4003890")]
		MagicalDamageMe = 16,
		[Token(Token = "0x4003891")]
		CriticalHit = 17,
		[Token(Token = "0x4003892")]
		CriticalHitMe = 18
	}
}
