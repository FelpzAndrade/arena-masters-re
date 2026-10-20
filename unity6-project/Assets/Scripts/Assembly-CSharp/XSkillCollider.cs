using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BA9")]
public class XSkillCollider : XSkillModule
{
	[Token(Token = "0x4003B48")]
	[FieldOffset(Offset = "0x18")]
	private List<XHitCollider> m_ColliderRoots;

	[Token(Token = "0x4003B49")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_bActive;

	[Token(Token = "0x4003B4A")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_autoTargetPosition;

	[Token(Token = "0x4003B4B")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion m_autoTargetRotation;

	[Token(Token = "0x4003B4C")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_positionSet;

	[Token(Token = "0x6005467")]
	[Address(RVA = "0x181E1A4", Offset = "0x181E1A4", VA = "0x181E1A4")]
	public XSkillCollider(XSkill skill, XModuleEntity me, CSSkillInfo skillInfo, CSSkillInfo parentSkillInfo)
	{
	}

	[Token(Token = "0x6005468")]
	[Address(RVA = "0x181E2B0", Offset = "0x181E2B0", VA = "0x181E2B0")]
	private void Activate(bool isActive, XHitCollider collider)
	{
	}

	[Token(Token = "0x6005469")]
	[Address(RVA = "0x181E3F0", Offset = "0x181E3F0", VA = "0x181E3F0")]
	private void Deactivate()
	{
	}

	[Token(Token = "0x600546A")]
	[Address(RVA = "0x181E530", Offset = "0x181E530", VA = "0x181E530", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600546B")]
	[Address(RVA = "0x181E7BC", Offset = "0x181E7BC", VA = "0x181E7BC", Slot = "4")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600546C")]
	[Address(RVA = "0x181F464", Offset = "0x181F464", VA = "0x181F464", Slot = "5")]
	public override void OnUpdate(float timeDelta)
	{
	}

	[Token(Token = "0x600546D")]
	[Address(RVA = "0x181EF58", Offset = "0x181EF58", VA = "0x181EF58")]
	private void UpdateActivates()
	{
	}

	[Token(Token = "0x600546E")]
	[Address(RVA = "0x181F468", Offset = "0x181F468", VA = "0x181F468", Slot = "7")]
	public override void OnSkillStart(Vector3 pos, Quaternion dir)
	{
	}
}
