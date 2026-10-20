using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BA7")]
public class XSkill : IDisposable, CSPoolEntry
{
	[Token(Token = "0x2000BA8")]
	public enum XSkillExpiredResult
	{
		[Token(Token = "0x4003B45")]
		NA = 0,
		[Token(Token = "0x4003B46")]
		Timeout = 1,
		[Token(Token = "0x4003B47")]
		ProjectileRangeOut = 2
	}

	[Token(Token = "0x4003B36")]
	[FieldOffset(Offset = "0x8")]
	private XModuleEntity m_me;

	[Token(Token = "0x4003B37")]
	[FieldOffset(Offset = "0xC")]
	private XModuleActor m_actor;

	[Token(Token = "0x4003B38")]
	[FieldOffset(Offset = "0x10")]
	private CSSkillInfo m_SkillInfo;

	[Token(Token = "0x4003B39")]
	[FieldOffset(Offset = "0x14")]
	private CSSkillInfo m_parentSkillInfo;

	[Token(Token = "0x4003B3A")]
	[FieldOffset(Offset = "0x18")]
	private float m_elapsedTime;

	[Token(Token = "0x4003B3B")]
	[FieldOffset(Offset = "0x1C")]
	public XModuleEntity target;

	[Token(Token = "0x4003B3C")]
	[FieldOffset(Offset = "0x20")]
	public XSkillCollider collider;

	[Token(Token = "0x4003B3D")]
	[FieldOffset(Offset = "0x24")]
	public XSkillProjectile projectile;

	[Token(Token = "0x4003B3E")]
	[FieldOffset(Offset = "0x28")]
	public XSkillOwnerAttribute ownerAttibute;

	[Token(Token = "0x4003B3F")]
	[FieldOffset(Offset = "0x2C")]
	private List<XSkillModule> modules;

	[Token(Token = "0x4003B40")]
	[FieldOffset(Offset = "0x30")]
	private uint m_SkillUID;

	[Token(Token = "0x4003B41")]
	[FieldOffset(Offset = "0x34")]
	private XSkillExpiredResult m_ExpiredResult;

	[Token(Token = "0x4003B42")]
	[FieldOffset(Offset = "0x0")]
	private static Action<XSkillModule> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x4003B43")]
	[FieldOffset(Offset = "0x4")]
	private static Action<XSkillModule> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x17000C73")]
	public XSkillExpiredResult ExpiredResult
	{
		[Token(Token = "0x600544B")]
		[Address(RVA = "0x181D024", Offset = "0x181D024", VA = "0x181D024")]
		get
		{
			return default(XSkillExpiredResult);
		}
	}

	[Token(Token = "0x17000C74")]
	public CSSkillInfo SkillInfo
	{
		[Token(Token = "0x600544C")]
		[Address(RVA = "0x181D02C", Offset = "0x181D02C", VA = "0x181D02C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600544D")]
		[Address(RVA = "0x181D034", Offset = "0x181D034", VA = "0x181D034")]
		set
		{
		}
	}

	[Token(Token = "0x17000C75")]
	public float ElapsedTime
	{
		[Token(Token = "0x600544E")]
		[Address(RVA = "0x181D03C", Offset = "0x181D03C", VA = "0x181D03C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000C76")]
	public float ExpiredTime
	{
		[Token(Token = "0x600544F")]
		[Address(RVA = "0x181D044", Offset = "0x181D044", VA = "0x181D044")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000C77")]
	public float UseAnimationTime
	{
		[Token(Token = "0x6005450")]
		[Address(RVA = "0x181D080", Offset = "0x181D080", VA = "0x181D080")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000C78")]
	public uint UID
	{
		[Token(Token = "0x6005464")]
		[Address(RVA = "0x181E0EC", Offset = "0x181E0EC", VA = "0x181E0EC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600544A")]
	[Address(RVA = "0x181CF78", Offset = "0x181CF78", VA = "0x181CF78")]
	public XSkill()
	{
	}

	[Token(Token = "0x6005451")]
	[Address(RVA = "0x181D150", Offset = "0x181D150", VA = "0x181D150", Slot = "5")]
	public void OnCleanupInObjectPool()
	{
	}

	[Token(Token = "0x6005452")]
	[Address(RVA = "0x181D154", Offset = "0x181D154", VA = "0x181D154")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005453")]
	[Address(RVA = "0x181D210", Offset = "0x181D210", VA = "0x181D210")]
	public XModuleEntity GetTarget()
	{
		return null;
	}

	[Token(Token = "0x6005454")]
	[Address(RVA = "0x181D218", Offset = "0x181D218", VA = "0x181D218", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6005455")]
	[Address(RVA = "0x181D2D8", Offset = "0x181D2D8", VA = "0x181D2D8")]
	public bool IsCancelable(CSCharacterSkillInfo.SkillType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6005456")]
	[Address(RVA = "0x181D384", Offset = "0x181D384", VA = "0x181D384")]
	public bool IsDodgeCancelable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005457")]
	[Address(RVA = "0x181D3D8", Offset = "0x181D3D8", VA = "0x181D3D8")]
	public bool IsExpired()
	{
		return default(bool);
	}

	[Token(Token = "0x6005458")]
	[Address(RVA = "0x181D5D8", Offset = "0x181D5D8", VA = "0x181D5D8")]
	public bool IsMovable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005459")]
	[Address(RVA = "0x181D634", Offset = "0x181D634", VA = "0x181D634")]
	public bool IsDirectionFixed()
	{
		return default(bool);
	}

	[Token(Token = "0x600545A")]
	[Address(RVA = "0x181D658", Offset = "0x181D658", VA = "0x181D658")]
	public bool IsProjectile()
	{
		return default(bool);
	}

	[Token(Token = "0x600545B")]
	[Address(RVA = "0x181D668", Offset = "0x181D668", VA = "0x181D668")]
	public static XSkill New()
	{
		return null;
	}

	[Token(Token = "0x600545C")]
	private T AddModule<T>() where T : XSkillModule
	{
		return null;
	}

	[Token(Token = "0x600545D")]
	[Address(RVA = "0x181D720", Offset = "0x181D720", VA = "0x181D720")]
	private void NotifyToModules(Action<XSkillModule> func)
	{
	}

	[Token(Token = "0x600545E")]
	[Address(RVA = "0x181D838", Offset = "0x181D838", VA = "0x181D838")]
	public void Init(XModuleEntity me, CSSkillInfo skillInfo, XModuleEntity target)
	{
	}

	[Token(Token = "0x600545F")]
	[Address(RVA = "0x181DA8C", Offset = "0x181DA8C", VA = "0x181DA8C")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6005460")]
	[Address(RVA = "0x181DBB4", Offset = "0x181DBB4", VA = "0x181DBB4")]
	public void OnSkillFinished()
	{
	}

	[Token(Token = "0x6005461")]
	[Address(RVA = "0x181DCDC", Offset = "0x181DCDC", VA = "0x181DCDC")]
	public void OnCollision(GameObject goAttacker)
	{
	}

	[Token(Token = "0x6005462")]
	[Address(RVA = "0x181DE04", Offset = "0x181DE04", VA = "0x181DE04")]
	public void UseSkill(Vector3 pos, Quaternion dir)
	{
	}

	[Token(Token = "0x6005463")]
	[Address(RVA = "0x181DFA4", Offset = "0x181DFA4", VA = "0x181DFA4")]
	public void Update(float delta)
	{
	}

	[Token(Token = "0x6005465")]
	[Address(RVA = "0x181E0F4", Offset = "0x181E0F4", VA = "0x181E0F4")]
	private static void _003CInit_003Em__216(XSkillModule m)
	{
	}

	[Token(Token = "0x6005466")]
	[Address(RVA = "0x181E14C", Offset = "0x181E14C", VA = "0x181E14C")]
	private static void _003CDestroy_003Em__217(XSkillModule m)
	{
	}
}
