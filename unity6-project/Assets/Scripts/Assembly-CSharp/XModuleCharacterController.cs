using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000455")]
public class XModuleCharacterController : XModuleBase
{
	[Token(Token = "0x400155E")]
	[FieldOffset(Offset = "0x10")]
	private CharacterController m_characterController;

	[Token(Token = "0x400155F")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 reserved;

	[Token(Token = "0x17000605")]
	public CharacterController CharcaterController
	{
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0xB50504", Offset = "0xB50504", VA = "0xB50504")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60023D6")]
	[Address(RVA = "0xB504BC", Offset = "0xB504BC", VA = "0xB504BC")]
	public XModuleCharacterController()
	{
	}

	[Token(Token = "0x60023D8")]
	[Address(RVA = "0xB5050C", Offset = "0xB5050C", VA = "0xB5050C", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60023D9")]
	[Address(RVA = "0xB505A8", Offset = "0xB505A8", VA = "0xB505A8")]
	public void EnableController(bool isEnable)
	{
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0xB50684", Offset = "0xB50684", VA = "0xB50684")]
	public void SyncStop()
	{
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0xB50968", Offset = "0xB50968", VA = "0xB50968")]
	public CollisionFlags Move(Vector3 motion, float deltaTime)
	{
		return default(CollisionFlags);
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0xB43CD4", Offset = "0xB43CD4", VA = "0xB43CD4")]
	public void ReserveMove(Vector3 motion)
	{
	}

	[Token(Token = "0x60023DD")]
	[Address(RVA = "0xB50A7C", Offset = "0xB50A7C", VA = "0xB50A7C", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60023DE")]
	[Address(RVA = "0xB50A00", Offset = "0xB50A00", VA = "0xB50A00")]
	private CollisionFlags CharControllerMove(Vector3 vPos)
	{
		return default(CollisionFlags);
	}

	[Token(Token = "0x60023DF")]
	[Address(RVA = "0xB50B18", Offset = "0xB50B18", VA = "0xB50B18")]
	public CollisionFlags Warp(Vector3 motion)
	{
		return default(CollisionFlags);
	}

	[Token(Token = "0x60023E0")]
	[Address(RVA = "0xB50B30", Offset = "0xB50B30", VA = "0xB50B30")]
	public void MoveTransfom(Vector3 motion, float deltaTime)
	{
	}

	[Token(Token = "0x60023E1")]
	[Address(RVA = "0xB50BE4", Offset = "0xB50BE4", VA = "0xB50BE4")]
	public CollisionFlags MoveGravity(float fTo)
	{
		return default(CollisionFlags);
	}

	[Token(Token = "0x60023E2")]
	[Address(RVA = "0xB50CB0", Offset = "0xB50CB0", VA = "0xB50CB0")]
	public void SetSynchronizeSync(Vector3 speed)
	{
	}

	[Token(Token = "0x60023E3")]
	[Address(RVA = "0xB506E4", Offset = "0xB506E4", VA = "0xB506E4")]
	private void SetSynchronizedValues(Vector3 speed, float turnSpeed)
	{
	}

	[Token(Token = "0x60023E4")]
	[Address(RVA = "0xB50CF0", Offset = "0xB50CF0", VA = "0xB50CF0", Slot = "14")]
	public override void OnDrawGizmos()
	{
	}
}
