using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000479")]
public class XModuleMyControlForPet : XModuleMyControl
{
	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0x80")]
	public XModuleEntity myPlayerMe;

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0xB773D0", Offset = "0xB773D0", VA = "0xB773D0")]
	public XModuleMyControlForPet()
	{
	}

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0xB773D4", Offset = "0xB773D4", VA = "0xB773D4", Slot = "61")]
	public override void SetLookAtPos(Vector3 vecTarget)
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0xB77574", Offset = "0xB77574", VA = "0xB77574", Slot = "59")]
	protected override float GetMoveSpeed(float dt)
	{
		return default(float);
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0xB7763C", Offset = "0xB7763C", VA = "0xB7763C", Slot = "64")]
	protected override void UpdateControl(float deltaTime)
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0xB77F40", Offset = "0xB77F40", VA = "0xB77F40", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0xB7823C", Offset = "0xB7823C", VA = "0xB7823C", Slot = "13")]
	public override void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x60025EC")]
	[Address(RVA = "0xB78240", Offset = "0xB78240", VA = "0xB78240", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0xB78290", Offset = "0xB78290", VA = "0xB78290", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0xB782E0", Offset = "0xB782E0", VA = "0xB782E0")]
	private bool CheckPlayerDie()
	{
		return default(bool);
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0xB78324", Offset = "0xB78324", VA = "0xB78324", Slot = "60")]
	public override Vector3 GetBehindPosition(GameObject target, GameObject me, float distance = 1f)
	{
		return default(Vector3);
	}
}
