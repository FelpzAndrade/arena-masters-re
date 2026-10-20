using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000486")]
public class XModuleRangeCollision : MonoBehaviour
{
	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0xC")]
	private CSSkillInfo m_SkillInfo;

	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0x10")]
	private CSSkillEffectInfo m_effectInfo;

	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0x14")]
	private XModuleEntity me;

	[Token(Token = "0x60026B9")]
	[Address(RVA = "0xB8CF64", Offset = "0xB8CF64", VA = "0xB8CF64")]
	public XModuleRangeCollision()
	{
	}

	[Token(Token = "0x60026BA")]
	[Address(RVA = "0xB8CF6C", Offset = "0xB8CF6C", VA = "0xB8CF6C")]
	public void Init(CSSkillInfo skillInfo, CSSkillEffectInfo effectInfo, XModuleEntity me)
	{
	}

	[Token(Token = "0x60026BB")]
	[Address(RVA = "0xB8D088", Offset = "0xB8D088", VA = "0xB8D088")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0xB8D08C", Offset = "0xB8D08C", VA = "0xB8D08C")]
	public void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0xB8D090", Offset = "0xB8D090", VA = "0xB8D090")]
	private void OnCollisionAndTrigger(Collider col)
	{
	}
}
