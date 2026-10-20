using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000445")]
public class XModuleAction : XModuleBase
{
	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x10")]
	private XActionState m_actionState;

	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x14")]
	private XMoveState m_moveState;

	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x18")]
	private XMotionControlBase m_currentMotionControl;

	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x1C")]
	private float m_respawnRemainTime;

	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x20")]
	private float m_respawnTime;

	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x24")]
	private bool IsMotionSync__BackingField;

	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x25")]
	private bool IsMovingSkillSync__BackingField;

	[Token(Token = "0x17000592")]
	public XActionState ActionState
	{
		[Token(Token = "0x600221F")]
		[Address(RVA = "0xB32FB4", Offset = "0xB32FB4", VA = "0xB32FB4")]
		get
		{
			return default(XActionState);
		}
		[Token(Token = "0x6002220")]
		[Address(RVA = "0xB32FBC", Offset = "0xB32FBC", VA = "0xB32FBC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000593")]
	public XMoveState MoveState
	{
		[Token(Token = "0x6002221")]
		[Address(RVA = "0xB32FCC", Offset = "0xB32FCC", VA = "0xB32FCC")]
		get
		{
			return default(XMoveState);
		}
		[Token(Token = "0x6002222")]
		[Address(RVA = "0xB32FD4", Offset = "0xB32FD4", VA = "0xB32FD4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000594")]
	public MotionControlType MotionControlType
	{
		[Token(Token = "0x6002223")]
		[Address(RVA = "0xB32FE4", Offset = "0xB32FE4", VA = "0xB32FE4")]
		get
		{
			return default(MotionControlType);
		}
	}

	[Token(Token = "0x17000595")]
	public float RespawnRemainTime
	{
		[Token(Token = "0x600222F")]
		[Address(RVA = "0xB33D0C", Offset = "0xB33D0C", VA = "0xB33D0C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000596")]
	public float RespawnTimePercent
	{
		[Token(Token = "0x6002230")]
		[Address(RVA = "0xB33D14", Offset = "0xB33D14", VA = "0xB33D14")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000597")]
	public bool IsMotionSync
	{
		[Token(Token = "0x6002231")]
		[Address(RVA = "0xB33DD4", Offset = "0xB33DD4", VA = "0xB33DD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002232")]
		[Address(RVA = "0xB33DDC", Offset = "0xB33DDC", VA = "0xB33DDC")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000598")]
	public bool IsMovingSkillSync
	{
		[Token(Token = "0x6002233")]
		[Address(RVA = "0xB33DE4", Offset = "0xB33DE4", VA = "0xB33DE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002234")]
		[Address(RVA = "0xB33DEC", Offset = "0xB33DEC", VA = "0xB33DEC")]
		internal set
		{
		}
	}

	[Token(Token = "0x600221E")]
	[Address(RVA = "0xB32F7C", Offset = "0xB32F7C", VA = "0xB32F7C")]
	public XModuleAction()
	{
	}

	[Token(Token = "0x6002224")]
	[Address(RVA = "0xB33048", Offset = "0xB33048", VA = "0xB33048")]
	public bool IsDead()
	{
		return default(bool);
	}

	[Token(Token = "0x6002225")]
	[Address(RVA = "0xB3305C", Offset = "0xB3305C", VA = "0xB3305C", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x6002226")]
	[Address(RVA = "0xB33070", Offset = "0xB33070", VA = "0xB33070", Slot = "46")]
	public override void OnPlayAnimation()
	{
	}

	[Token(Token = "0x6002227")]
	[Address(RVA = "0xB33084", Offset = "0xB33084", VA = "0xB33084")]
	public void SetActionState(XActionState state)
	{
	}

	[Token(Token = "0x6002228")]
	[Address(RVA = "0xB3308C", Offset = "0xB3308C", VA = "0xB3308C", Slot = "47")]
	public override void OnStopAnimation()
	{
	}

	[Token(Token = "0x6002229")]
	[Address(RVA = "0xB330A0", Offset = "0xB330A0", VA = "0xB330A0", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x600222A")]
	[Address(RVA = "0xB331E8", Offset = "0xB331E8", VA = "0xB331E8")]
	public XMotionControlBase StartMotionControl(MotionControlType type, MotionControlDirection directionType, float fTime, Vector3 pos, Vector3 dir, float distance = 0f, float distance2 = 0f)
	{
		return null;
	}

	[Token(Token = "0x600222B")]
	[Address(RVA = "0xB33900", Offset = "0xB33900", VA = "0xB33900")]
	public void ReleaseMotionControl()
	{
	}

	[Token(Token = "0x600222C")]
	[Address(RVA = "0xB33AAC", Offset = "0xB33AAC", VA = "0xB33AAC")]
	public float CalcDuration(MotionControlType type, float originalDuration, float mcDistance)
	{
		return default(float);
	}

	[Token(Token = "0x600222D")]
	[Address(RVA = "0xB33038", Offset = "0xB33038", VA = "0xB33038")]
	public bool HasMotionFactor()
	{
		return default(bool);
	}

	[Token(Token = "0x600222E")]
	[Address(RVA = "0xB330D8", Offset = "0xB330D8", VA = "0xB330D8")]
	private void UpdateMotionControl(float dt)
	{
	}

	[Token(Token = "0x6002235")]
	[Address(RVA = "0xB330BC", Offset = "0xB330BC", VA = "0xB330BC")]
	private void UpdateActionState(float dt)
	{
	}

	[Token(Token = "0x6002236")]
	[Address(RVA = "0xB33DF4", Offset = "0xB33DF4", VA = "0xB33DF4")]
	public void LootAtTarget(Transform target)
	{
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0xB33F54", Offset = "0xB33F54", VA = "0xB33F54")]
	public void Run(Vector3 directionOnWorldSpace)
	{
	}

	[Token(Token = "0x6002238")]
	[Address(RVA = "0xB340E0", Offset = "0xB340E0", VA = "0xB340E0")]
	public void Idle()
	{
	}

	[Token(Token = "0x6002239")]
	[Address(RVA = "0xB34258", Offset = "0xB34258", VA = "0xB34258", Slot = "22")]
	public override void OnSkillMotionEnd()
	{
	}

	[Token(Token = "0x600223A")]
	[Address(RVA = "0xB342E0", Offset = "0xB342E0", VA = "0xB342E0", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x600223B")]
	[Address(RVA = "0xB3433C", Offset = "0xB3433C", VA = "0xB3433C", Slot = "23")]
	public override void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x600223C")]
	[Address(RVA = "0xB34350", Offset = "0xB34350", VA = "0xB34350", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x600223D")]
	[Address(RVA = "0xB34500", Offset = "0xB34500", VA = "0xB34500", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x600223E")]
	[Address(RVA = "0xB3450C", Offset = "0xB3450C", VA = "0xB3450C", Slot = "45")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x600223F")]
	[Address(RVA = "0xB34518", Offset = "0xB34518", VA = "0xB34518")]
	public bool IsSuspendPhotonSynchronize()
	{
		return default(bool);
	}
}
