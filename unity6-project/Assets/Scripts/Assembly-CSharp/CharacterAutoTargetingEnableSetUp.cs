using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000629")]
public class CharacterAutoTargetingEnableSetUp
{
	[Token(Token = "0x4001DBC")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<int, bool> AutoTargetingSetUp;

	[Token(Token = "0x6003503")]
	[Address(RVA = "0x20C4160", Offset = "0x20C4160", VA = "0x20C4160")]
	public CharacterAutoTargetingEnableSetUp()
	{
	}

	[Token(Token = "0x6003504")]
	[Address(RVA = "0x20C420C", Offset = "0x20C420C", VA = "0x20C420C")]
	public bool GetAutoTargetSetting(int skillId, bool defaultValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6003505")]
	[Address(RVA = "0x20C42F0", Offset = "0x20C42F0", VA = "0x20C42F0")]
	public void SetAutoTargettingEnable(int skillId, bool b)
	{
	}
}
