using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000409")]
public class XHitCollider : MonoBehaviour
{
	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0xC")]
	public GameObject[] m_Colliders;

	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x10")]
	public bool GroupHit;

	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x1D22114", Offset = "0x1D22114", VA = "0x1D22114")]
	public XHitCollider()
	{
	}

	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x1D2211C", Offset = "0x1D2211C", VA = "0x1D2211C")]
	public void SetActive(bool b)
	{
	}

	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x1D22238", Offset = "0x1D22238", VA = "0x1D22238")]
	public void Init(CSCharacterInfo characterInfo, CSSkillInfo skillInfo, XModuleSkill moduleSkill, XSkill skill)
	{
	}

	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x1D22480", Offset = "0x1D22480", VA = "0x1D22480")]
	public void SetupAttackerInfo(CSSkillInfo skillInfo, XModuleSkill moduleSkill)
	{
	}

	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x1D225C8", Offset = "0x1D225C8", VA = "0x1D225C8")]
	public void SetColUID()
	{
	}
}
