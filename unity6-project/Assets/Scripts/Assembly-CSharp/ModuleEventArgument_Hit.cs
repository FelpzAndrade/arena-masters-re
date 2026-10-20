using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200045F")]
public class ModuleEventArgument_Hit : IDisposable, CSPoolEntry
{
	[Token(Token = "0x40015A6")]
	[FieldOffset(Offset = "0x8")]
	public XModuleEntity attackerME;

	[Token(Token = "0x40015A7")]
	[FieldOffset(Offset = "0xC")]
	public XModuleEntity victimME;

	[Token(Token = "0x40015A8")]
	[FieldOffset(Offset = "0x10")]
	public XModuleEntity attackSkillME;

	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x14")]
	public List<XSkillProjectile.Entry> projectileSkills;

	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x18")]
	public CSSkillInfo attackerSkillInfo;

	[Token(Token = "0x40015AB")]
	[FieldOffset(Offset = "0x1C")]
	public int nDamage;

	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x20")]
	public int nPureDamage;

	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x24")]
	public int nHeal;

	[Token(Token = "0x40015AE")]
	[FieldOffset(Offset = "0x28")]
	public bool isCritical;

	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x2C")]
	public uint nSkillUID;

	[Token(Token = "0x6002480")]
	[Address(RVA = "0x135C360", Offset = "0x135C360", VA = "0x135C360")]
	public ModuleEventArgument_Hit()
	{
	}

	[Token(Token = "0x6002481")]
	[Address(RVA = "0x135C368", Offset = "0x135C368", VA = "0x135C368", Slot = "5")]
	public void OnCleanupInObjectPool()
	{
	}

	[Token(Token = "0x6002482")]
	[Address(RVA = "0x135C38C", Offset = "0x135C38C", VA = "0x135C38C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002483")]
	[Address(RVA = "0x135C3B0", Offset = "0x135C3B0", VA = "0x135C3B0", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
