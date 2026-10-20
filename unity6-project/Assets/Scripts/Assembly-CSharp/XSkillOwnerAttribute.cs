using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BAB")]
public class XSkillOwnerAttribute : XSkillModule
{
	[Token(Token = "0x4003B51")]
	[FieldOffset(Offset = "0x18")]
	private bool m_bActive;

	[Token(Token = "0x4003B52")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PushColliderPrefabPath;

	[Token(Token = "0x4003B53")]
	[FieldOffset(Offset = "0x1C")]
	private XPushCollider m_pushCollider;

	[Token(Token = "0x6005477")]
	[Address(RVA = "0x181F760", Offset = "0x181F760", VA = "0x181F760")]
	public XSkillOwnerAttribute(XSkill skill, XModuleEntity me, CSSkillInfo skillInfo, CSSkillInfo parentSkillInfo)
	{
	}

	[Token(Token = "0x6005479")]
	[Address(RVA = "0x181F828", Offset = "0x181F828", VA = "0x181F828", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600547A")]
	[Address(RVA = "0x181F848", Offset = "0x181F848", VA = "0x181F848")]
	private void Disable()
	{
	}

	[Token(Token = "0x600547B")]
	[Address(RVA = "0x181FA18", Offset = "0x181FA18", VA = "0x181FA18", Slot = "4")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600547C")]
	[Address(RVA = "0x181FDE0", Offset = "0x181FDE0", VA = "0x181FDE0")]
	private void Push(CharacterController target)
	{
	}

	[Token(Token = "0x600547D")]
	[Address(RVA = "0x181FF14", Offset = "0x181FF14", VA = "0x181FF14", Slot = "5")]
	public override void OnUpdate(float timeDelta)
	{
	}

	[Token(Token = "0x600547E")]
	[Address(RVA = "0x181FDDC", Offset = "0x181FDDC", VA = "0x181FDDC")]
	private void UpdateActivates()
	{
	}

	[Token(Token = "0x600547F")]
	[Address(RVA = "0x181FFAC", Offset = "0x181FFAC", VA = "0x181FFAC", Slot = "7")]
	public override void OnSkillStart(Vector3 pos, Quaternion dir)
	{
	}

	[Token(Token = "0x6005480")]
	[Address(RVA = "0x181FFB0", Offset = "0x181FFB0", VA = "0x181FFB0", Slot = "8")]
	public override void OnSkillFinished()
	{
	}

	[Token(Token = "0x6005481")]
	[Address(RVA = "0x181FF18", Offset = "0x181FF18", VA = "0x181FF18")]
	private void UpdateGhost()
	{
	}
}
