using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000456")]
public class XModuleCollision : XModuleBase
{
	[Token(Token = "0x4001560")]
	[FieldOffset(Offset = "0x10")]
	private bool ignoreSensorOnce;

	[Token(Token = "0x4001561")]
	[FieldOffset(Offset = "0x14")]
	private XHelper.UIDChecker m_skillColliderUIDChecker;

	[Token(Token = "0x4001562")]
	[FieldOffset(Offset = "0x18")]
	private Collider m_childCollider;

	[Token(Token = "0x60023E5")]
	[Address(RVA = "0xB5103C", Offset = "0xB5103C", VA = "0xB5103C")]
	public XModuleCollision()
	{
	}

	[Token(Token = "0x60023E6")]
	[Address(RVA = "0xB39158", Offset = "0xB39158", VA = "0xB39158")]
	public void IgnoreSensorOnce()
	{
	}

	[Token(Token = "0x60023E7")]
	[Address(RVA = "0xB510E0", Offset = "0xB510E0", VA = "0xB510E0")]
	private bool IsSensorIgnoredOnce(GameObject colGo)
	{
		return default(bool);
	}

	[Token(Token = "0x60023E8")]
	[Address(RVA = "0xB511E0", Offset = "0xB511E0", VA = "0xB511E0", Slot = "9")]
	public override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60023E9")]
	[Address(RVA = "0xB51C30", Offset = "0xB51C30", VA = "0xB51C30", Slot = "10")]
	public override void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x60023EA")]
	[Address(RVA = "0xB51C34", Offset = "0xB51C34", VA = "0xB51C34", Slot = "11")]
	public override void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x60023EB")]
	[Address(RVA = "0xB520F0", Offset = "0xB520F0", VA = "0xB520F0", Slot = "12")]
	public override void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x60023EC")]
	[Address(RVA = "0xB5121C", Offset = "0xB5121C", VA = "0xB5121C")]
	public void OnCollisionAndTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x60023ED")]
	[Address(RVA = "0xB51C70", Offset = "0xB51C70", VA = "0xB51C70")]
	public void OnCollisionAndTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x60023EE")]
	[Address(RVA = "0xB520F4", Offset = "0xB520F4", VA = "0xB520F4")]
	private void OnHit(Collider col)
	{
	}

	[Token(Token = "0x60023EF")]
	[Address(RVA = "0xB52D9C", Offset = "0xB52D9C", VA = "0xB52D9C")]
	private void OnHitLevelMapObject(Collider col)
	{
	}

	[Token(Token = "0x60023F0")]
	[Address(RVA = "0xB52C30", Offset = "0xB52C30", VA = "0xB52C30")]
	private void OnEnterDropObject(Collider col)
	{
	}

	[Token(Token = "0x60023F1")]
	[Address(RVA = "0xB53890", Offset = "0xB53890", VA = "0xB53890")]
	private void OnExitDropObject(Collider col)
	{
	}

	[Token(Token = "0x60023F2")]
	[Address(RVA = "0xB52AF0", Offset = "0xB52AF0", VA = "0xB52AF0")]
	private void OnEnterHeadStone(Collider col)
	{
	}

	[Token(Token = "0x60023F3")]
	[Address(RVA = "0xB53DBC", Offset = "0xB53DBC", VA = "0xB53DBC")]
	private void OnExitHeadStone(Collider col)
	{
	}

	[Token(Token = "0x60023F4")]
	[Address(RVA = "0xB548AC", Offset = "0xB548AC", VA = "0xB548AC")]
	private void OnDieDropObjectEventToModule()
	{
	}

	[Token(Token = "0x60023F5")]
	[Address(RVA = "0xB54990", Offset = "0xB54990", VA = "0xB54990", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x60023F6")]
	[Address(RVA = "0xB549BC", Offset = "0xB549BC", VA = "0xB549BC", Slot = "18")]
	public override void OnAfterActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60023F7")]
	[Address(RVA = "0xB54C48", Offset = "0xB54C48", VA = "0xB54C48", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60023F8")]
	[Address(RVA = "0xB526E0", Offset = "0xB526E0", VA = "0xB526E0")]
	private void OnEnterGimmick(Collider col)
	{
	}

	[Token(Token = "0x60023F9")]
	[Address(RVA = "0xB53B80", Offset = "0xB53B80", VA = "0xB53B80")]
	private void OnExitGimmick(Collider col)
	{
	}

	[Token(Token = "0x60023FA")]
	[Address(RVA = "0xB52280", Offset = "0xB52280", VA = "0xB52280")]
	private void OnTouchSensor(Collider col)
	{
	}

	[Token(Token = "0x60023FB")]
	[Address(RVA = "0xB539CC", Offset = "0xB539CC", VA = "0xB539CC")]
	private void OnExitSensor(Collider col)
	{
	}

	[Token(Token = "0x60023FC")]
	[Address(RVA = "0xB52DCC", Offset = "0xB52DCC", VA = "0xB52DCC")]
	private void OnEnterPointObject(Collider col)
	{
	}

	[Token(Token = "0x60023FD")]
	[Address(RVA = "0xB53334", Offset = "0xB53334", VA = "0xB53334")]
	private void OnExitPointObject(Collider col)
	{
	}
}
