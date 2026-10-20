using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200047A")]
public class XModuleMyControForPlayer : XModuleMyControl
{
	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0x80")]
	protected bool m_movingSpeedControl;

	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0x84")]
	protected XMyNewbieBuffChecker m_NewbieBuffChecker;

	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0x88")]
	protected XMyTeamModePlayStartBuffChecker m_TeamModePlayStartBuffChecker;

	[Token(Token = "0x60025F0")]
	[Address(RVA = "0xB731CC", Offset = "0xB731CC", VA = "0xB731CC")]
	public XModuleMyControForPlayer()
	{
	}

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0xB73404", Offset = "0xB73404", VA = "0xB73404", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x60025F2")]
	[Address(RVA = "0xB73408", Offset = "0xB73408", VA = "0xB73408")]
	protected void ApplyModeBuff()
	{
	}

	[Token(Token = "0x60025F3")]
	[Address(RVA = "0xB736AC", Offset = "0xB736AC", VA = "0xB736AC")]
	public bool InBattle()
	{
		return default(bool);
	}

	[Token(Token = "0x60025F4")]
	[Address(RVA = "0xB736E4", Offset = "0xB736E4", VA = "0xB736E4", Slot = "59")]
	protected override float GetMoveSpeed(float dt)
	{
		return default(float);
	}

	[Token(Token = "0x60025F5")]
	[Address(RVA = "0xB738A0", Offset = "0xB738A0", VA = "0xB738A0", Slot = "61")]
	public override void SetLookAtPos(Vector3 vecTarget)
	{
	}

	[Token(Token = "0x60025F6")]
	[Address(RVA = "0xB73958", Offset = "0xB73958", VA = "0xB73958", Slot = "62")]
	public override void SetLookAtPosLerp(Vector3 vecTarget)
	{
	}

	[Token(Token = "0x60025F7")]
	[Address(RVA = "0xB73B58", Offset = "0xB73B58", VA = "0xB73B58", Slot = "63")]
	public override void SetLookAtControlDir()
	{
	}

	[Token(Token = "0x60025F8")]
	[Address(RVA = "0xB73C4C", Offset = "0xB73C4C", VA = "0xB73C4C")]
	protected bool CheckHP()
	{
		return default(bool);
	}

	[Token(Token = "0x60025F9")]
	[Address(RVA = "0xB73C90", Offset = "0xB73C90", VA = "0xB73C90", Slot = "64")]
	protected override void UpdateControl(float deltaTime)
	{
	}

	[Token(Token = "0x60025FA")]
	[Address(RVA = "0xB748A0", Offset = "0xB748A0", VA = "0xB748A0", Slot = "13")]
	public override void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x60025FB")]
	[Address(RVA = "0xB74BE8", Offset = "0xB74BE8", VA = "0xB74BE8", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x60025FC")]
	[Address(RVA = "0xB753E0", Offset = "0xB753E0", VA = "0xB753E0", Slot = "43")]
	public override void OnGameModePlayStateEnter()
	{
	}

	[Token(Token = "0x60025FD")]
	[Address(RVA = "0xB758A4", Offset = "0xB758A4", VA = "0xB758A4", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60025FE")]
	[Address(RVA = "0xB75954", Offset = "0xB75954", VA = "0xB75954", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc actor)
	{
	}
}
