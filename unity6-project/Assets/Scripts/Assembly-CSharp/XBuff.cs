using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200039E")]
public class XBuff : IDisposable, CSPoolEntry
{
	[Token(Token = "0x40012D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private CSBuffInfo m_buffInfo;

	[Token(Token = "0x40012D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float m_fDurationTime;

	[Token(Token = "0x40012D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float m_fElapsedTime;

	[Token(Token = "0x40012D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XDotInfo m_dotInfo;

	[Token(Token = "0x40012D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_bReleased;

	[Token(Token = "0x40012D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CSSkillInfo m_ParentSkill;

	[Token(Token = "0x40012D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CharStatus m_buffStatus;

	[Token(Token = "0x40012D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int m_stackCount;

	[Token(Token = "0x40012DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int m_userATID;

	[Token(Token = "0x40012DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 moveDir;

	[Token(Token = "0x40012DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float moveSpeed;

	[Token(Token = "0x40012DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_buffEffects;

	[Token(Token = "0x40012DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<GameObject> m_buffEffectsRefreshOnUpdate;

	[Token(Token = "0x170004FA")]
	public int StackCount
	{
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x1A98868", Offset = "0x1A98868", VA = "0x1A98868")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004FB")]
	public float ElapsedTime
	{
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x1A98870", Offset = "0x1A98870", VA = "0x1A98870")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170004FC")]
	public float Duration
	{
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x1A98878", Offset = "0x1A98878", VA = "0x1A98878")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x1A98880", Offset = "0x1A98880", VA = "0x1A98880")]
		set
		{
		}
	}

	[Token(Token = "0x170004FD")]
	public CSSkillInfo ParentSkill
	{
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x1A98888", Offset = "0x1A98888", VA = "0x1A98888")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FE")]
	public CharStatus BuffStatus
	{
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x1A98890", Offset = "0x1A98890", VA = "0x1A98890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FF")]
	public int UserATID
	{
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x1A98898", Offset = "0x1A98898", VA = "0x1A98898")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000500")]
	public List<GameObject> BuffEffects
	{
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x1A99714", Offset = "0x1A99714", VA = "0x1A99714")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000501")]
	public List<GameObject> BuffEffectsRefreshOnUpdate
	{
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x1A9971C", Offset = "0x1A9971C", VA = "0x1A9971C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x1A986A4", Offset = "0x1A986A4", VA = "0x1A986A4")]
	public XBuff()
	{
	}

	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x1A98798", Offset = "0x1A98798", VA = "0x1A98798")]
	public static XBuff New()
	{
		return null;
	}

	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x1A988A0", Offset = "0x1A988A0", VA = "0x1A988A0")]
	public bool IsMaxStack()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x1A988D8", Offset = "0x1A988D8", VA = "0x1A988D8")]
	public void Copy(XBuff other)
	{
	}

	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x1A98A08", Offset = "0x1A98A08", VA = "0x1A98A08", Slot = "5")]
	public void OnCleanupInObjectPool()
	{
	}

	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x1A98A0C", Offset = "0x1A98A0C", VA = "0x1A98A0C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x1A98B70", Offset = "0x1A98B70", VA = "0x1A98B70", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x1A98C30", Offset = "0x1A98C30", VA = "0x1A98C30")]
	public void Init(CSBuffInfo buffInfo, float fDurationTime, CSSkillInfo parentSkill, int nMaxHP, XModuleActor user, [Optional] short stackCount, [Optional] Vector3 colPos, [Optional] Vector3 colDir, [Optional] Vector3 myPos)
	{
	}

	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x1A98F98", Offset = "0x1A98F98", VA = "0x1A98F98")]
	public void Reapply(CSBuffInfo buffInfo, float fDurationTime, CSSkillInfo parentSkill, int nMaxHP, XModuleActor user, [Optional] Vector3 colPos, [Optional] Vector3 colDir, [Optional] Vector3 myPos)
	{
	}

	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x1A99020", Offset = "0x1A99020", VA = "0x1A99020")]
	public void Reapply(CSBuffInfo buffInfo, float fDurationTime, CSSkillInfo parentSkill, int nMaxHP, XModuleActor user, int stackCount, [Optional] Vector3 colPos, [Optional] Vector3 colDir, [Optional] Vector3 myPos)
	{
	}

	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x1A98CA0", Offset = "0x1A98CA0", VA = "0x1A98CA0")]
	private void Apply(CSBuffInfo buffInfo, float fDurationTime, CSSkillInfo parentSkill, int nMaxHP, XModuleActor user, [Optional] Vector3 colPos, [Optional] Vector3 colDir, [Optional] Vector3 myPos)
	{
	}

	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x1A99098", Offset = "0x1A99098", VA = "0x1A99098")]
	private void SetBuffUniformMotionInfo(CSBuffInfo buffInfo, XModuleActor user, Vector3 colPos, Vector3 colDir, Vector3 myPos)
	{
	}

	[Token(Token = "0x6001DD5")]
	[Address(RVA = "0x1A994A0", Offset = "0x1A994A0", VA = "0x1A994A0")]
	public CSBuffInfo GetBuffInfo()
	{
		return null;
	}

	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x1A994A8", Offset = "0x1A994A8", VA = "0x1A994A8")]
	public void PeriodUpdate(float deltaTime, XModuleEntity obj)
	{
	}

	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x1A9959C", Offset = "0x1A9959C", VA = "0x1A9959C")]
	public void OnUpdate(float deltaTime, XModuleEntity obj)
	{
	}

	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x1A995A0", Offset = "0x1A995A0", VA = "0x1A995A0")]
	private void UpdateCharacterMove(float deltaTime, XModuleEntity obj)
	{
	}

	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x1A994BC", Offset = "0x1A994BC", VA = "0x1A994BC")]
	private void UpdateDotAndHot(float deltaTime, XModuleEntity obj)
	{
	}

	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x1A9969C", Offset = "0x1A9969C", VA = "0x1A9969C")]
	public bool IsReleased()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x1A996A4", Offset = "0x1A996A4", VA = "0x1A996A4")]
	public bool IsModeBuff()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x1A996C4", Offset = "0x1A996C4", VA = "0x1A996C4")]
	public bool IsTimeOver()
	{
		return default(bool);
	}

	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x1A99238", Offset = "0x1A99238", VA = "0x1A99238")]
	private void InitDoTAndHoTInfo(CSBuffInfo buffInfo, int nMaxHP, int userATID)
	{
	}

	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x1A99724", Offset = "0x1A99724", VA = "0x1A99724")]
	public void SetDeleteMe()
	{
	}
}
