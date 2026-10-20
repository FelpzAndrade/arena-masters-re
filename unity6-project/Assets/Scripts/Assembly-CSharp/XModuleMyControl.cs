using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000478")]
public class XModuleMyControl : XModuleBase
{
	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0x10")]
	protected bool m_bIdle;

	[Token(Token = "0x4001683")]
	[FieldOffset(Offset = "0x11")]
	protected bool m_pushing;

	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0x14")]
	protected float m_curMoveSpeed;

	[Token(Token = "0x4001685")]
	[FieldOffset(Offset = "0x18")]
	protected float noneBattleMoveDelay;

	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0x1C")]
	protected float noneBattleMoveDelayAccum;

	[Token(Token = "0x4001687")]
	[FieldOffset(Offset = "0x20")]
	protected Vector3 m_PreMovement;

	[Token(Token = "0x4001688")]
	[FieldOffset(Offset = "0x2C")]
	protected Vector3 m_CurrentMovement;

	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0x38")]
	protected Vector3 m_PreDir;

	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x44")]
	protected Vector3 m_CurrentDir;

	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x50")]
	protected long m_LastSyncTurnTime;

	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 m_moveFromStick;

	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0x64")]
	protected bool m_hasMoveTo;

	[Token(Token = "0x400168E")]
	[FieldOffset(Offset = "0x68")]
	protected Vector3 m_moveTo;

	[Token(Token = "0x400168F")]
	[FieldOffset(Offset = "0x74")]
	protected float? m_absoluteSpeed;

	[Token(Token = "0x4001690")]
	[FieldOffset(Offset = "0x7C")]
	protected XMySkillControl m_SkillControl;

	[Token(Token = "0x17000626")]
	public float CurMoveSpeed
	{
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0xB75F34", Offset = "0xB75F34", VA = "0xB75F34")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0xB75F3C", Offset = "0xB75F3C", VA = "0xB75F3C")]
		set
		{
		}
	}

	[Token(Token = "0x60025C2")]
	[Address(RVA = "0xB732CC", Offset = "0xB732CC", VA = "0xB732CC")]
	public XModuleMyControl()
	{
	}

	[Token(Token = "0x60025C3")]
	[Address(RVA = "0xB75EBC", Offset = "0xB75EBC", VA = "0xB75EBC", Slot = "4")]
	public override string GetTypeStr()
	{
		return null;
	}

	[Token(Token = "0x60025C6")]
	[Address(RVA = "0xB75F44", Offset = "0xB75F44", VA = "0xB75F44", Slot = "59")]
	protected virtual float GetMoveSpeed(float dt)
	{
		return default(float);
	}

	[Token(Token = "0x60025C7")]
	[Address(RVA = "0xB75F74", Offset = "0xB75F74", VA = "0xB75F74", Slot = "60")]
	public virtual Vector3 GetBehindPosition(GameObject target, GameObject me, float distance = 2f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60025C8")]
	[Address(RVA = "0xB75FBC", Offset = "0xB75FBC", VA = "0xB75FBC", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60025C9")]
	[Address(RVA = "0xB75FD0", Offset = "0xB75FD0", VA = "0xB75FD0", Slot = "18")]
	public override void OnAfterActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60025CA")]
	[Address(RVA = "0xB76008", Offset = "0xB76008", VA = "0xB76008", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x60025CB")]
	[Address(RVA = "0xB75910", Offset = "0xB75910", VA = "0xB75910")]
	protected void UpdateGravity(float deltaTime)
	{
	}

	[Token(Token = "0x60025CC")]
	[Address(RVA = "0xB761B8", Offset = "0xB761B8", VA = "0xB761B8", Slot = "61")]
	public virtual void SetLookAtPos(Vector3 vecTarget)
	{
	}

	[Token(Token = "0x60025CD")]
	[Address(RVA = "0xB761BC", Offset = "0xB761BC", VA = "0xB761BC", Slot = "62")]
	public virtual void SetLookAtPosLerp(Vector3 vecTarget)
	{
	}

	[Token(Token = "0x60025CE")]
	[Address(RVA = "0xB761C0", Offset = "0xB761C0", VA = "0xB761C0", Slot = "63")]
	public virtual void SetLookAtControlDir()
	{
	}

	[Token(Token = "0x60025CF")]
	[Address(RVA = "0xB744A0", Offset = "0xB744A0", VA = "0xB744A0")]
	protected bool CheckAction()
	{
		return default(bool);
	}

	[Token(Token = "0x60025D0")]
	[Address(RVA = "0xB74520", Offset = "0xB74520", VA = "0xB74520")]
	public bool CheckMoveControl()
	{
		return default(bool);
	}

	[Token(Token = "0x60025D1")]
	[Address(RVA = "0xB745E0", Offset = "0xB745E0", VA = "0xB745E0")]
	protected void UpdateExtrapolateSync()
	{
	}

	[Token(Token = "0x60025D2")]
	[Address(RVA = "0xB76394", Offset = "0xB76394", VA = "0xB76394", Slot = "64")]
	protected virtual void UpdateControl(float deltaTime)
	{
	}

	[Token(Token = "0x60025D3")]
	[Address(RVA = "0xB76230", Offset = "0xB76230", VA = "0xB76230")]
	protected bool IsUpdateSyncTurn()
	{
		return default(bool);
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0xB761EC", Offset = "0xB761EC", VA = "0xB761EC")]
	protected void SyncMoveStart(Vector3 dir, float curMoveSpeed)
	{
	}

	[Token(Token = "0x60025D5")]
	[Address(RVA = "0xB76350", Offset = "0xB76350", VA = "0xB76350")]
	protected void SyncMoveTurn(Vector3 dir, float curMoveSpeed)
	{
	}

	[Token(Token = "0x60025D6")]
	[Address(RVA = "0xB7458C", Offset = "0xB7458C", VA = "0xB7458C")]
	protected void SyncStop()
	{
	}

	[Token(Token = "0x60025D7")]
	[Address(RVA = "0xB3260C", Offset = "0xB3260C", VA = "0xB3260C")]
	public void ResetMoveControl()
	{
	}

	[Token(Token = "0x60025D8")]
	[Address(RVA = "0xB764E4", Offset = "0xB764E4", VA = "0xB764E4")]
	public void Warp(Vector3 vPos)
	{
	}

	[Token(Token = "0x60025D9")]
	[Address(RVA = "0xB54E80", Offset = "0xB54E80", VA = "0xB54E80")]
	public void Warp(Vector3 vPos, Vector3 vDir)
	{
	}

	[Token(Token = "0x60025DA")]
	[Address(RVA = "0xB765E0", Offset = "0xB765E0", VA = "0xB765E0")]
	public void OnTiltStick(Vector3 dir)
	{
	}

	[Token(Token = "0x60025DB")]
	[Address(RVA = "0xB31E68", Offset = "0xB31E68", VA = "0xB31E68")]
	public void MoveTo(Vector3 moveTo)
	{
	}

	[Token(Token = "0x60025DC")]
	[Address(RVA = "0xB325E8", Offset = "0xB325E8", VA = "0xB325E8")]
	public void MoveToWithAbsoluteSpeed(Vector3 moveTo, float? speed)
	{
	}

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0xB765EC", Offset = "0xB765EC", VA = "0xB765EC", Slot = "14")]
	public override void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60025DE")]
	[Address(RVA = "0xB394F4", Offset = "0xB394F4", VA = "0xB394F4")]
	public bool UseSkill(int SkillId)
	{
		return default(bool);
	}

	[Token(Token = "0x60025DF")]
	[Address(RVA = "0xB76A80", Offset = "0xB76A80", VA = "0xB76A80")]
	public bool UseSkillWithOutReserve(int SkillId)
	{
		return default(bool);
	}

	[Token(Token = "0x60025E0")]
	[Address(RVA = "0xB768BC", Offset = "0xB768BC", VA = "0xB768BC")]
	protected bool UseCharacterSkill(int nSkillID, bool reserve)
	{
		return default(bool);
	}

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0xB7704C", Offset = "0xB7704C", VA = "0xB7704C")]
	protected bool UseRelicSkill(int nSkillID, bool reserve)
	{
		return default(bool);
	}

	[Token(Token = "0x60025E2")]
	[Address(RVA = "0xB77164", Offset = "0xB77164", VA = "0xB77164")]
	public bool IsProcessingComboSkill(int comboSkillLine)
	{
		return default(bool);
	}

	[Token(Token = "0x60025E3")]
	[Address(RVA = "0xB7722C", Offset = "0xB7722C", VA = "0xB7722C")]
	public LastComboSkillData GetLastComboSkillData(int comboSkillLine)
	{
		return null;
	}

	[Token(Token = "0x60025E4")]
	[Address(RVA = "0xB77310", Offset = "0xB77310", VA = "0xB77310")]
	public void OnPressCharacterSkillKey(XKeyEnum key, bool byAuto)
	{
	}

	[Token(Token = "0x60025E5")]
	[Address(RVA = "0xB77390", Offset = "0xB77390", VA = "0xB77390")]
	public void OnPressRelicSkillKey(XKeyEnum key, bool byAuto)
	{
	}
}
