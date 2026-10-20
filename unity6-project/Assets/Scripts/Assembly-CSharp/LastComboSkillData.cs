using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CE")]
public class LastComboSkillData
{
	[Token(Token = "0x4002086")]
	[FieldOffset(Offset = "0x8")]
	public CSSkillInfo lastUsedSkillInfo;

	[Token(Token = "0x4002087")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goOwner;

	[Token(Token = "0x4002088")]
	[FieldOffset(Offset = "0x10")]
	public int m_nLastUsedComboSkillID;

	[Token(Token = "0x4002089")]
	[FieldOffset(Offset = "0x14")]
	public float m_fLastUsedComboSkillTime;

	[Token(Token = "0x6003907")]
	[Address(RVA = "0xDD5554", Offset = "0xDD5554", VA = "0xDD5554")]
	public LastComboSkillData()
	{
	}
}
