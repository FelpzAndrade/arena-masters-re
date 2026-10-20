using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000628")]
public class XAccountGameData
{
	[Token(Token = "0x4001DBA")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<int, CharacterAutoTargetingEnableSetUp> AutoTargetingEnableSettiing;

	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0xC")]
	public List<string> LastMatchedPlayers;

	[Token(Token = "0x60034FF")]
	[Address(RVA = "0x17B5664", Offset = "0x17B5664", VA = "0x17B5664")]
	public XAccountGameData()
	{
	}

	[Token(Token = "0x6003500")]
	[Address(RVA = "0x17B5744", Offset = "0x17B5744", VA = "0x17B5744")]
	public bool GetAutotargetingSetUp(int charID, int skillID, bool defaultValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6003501")]
	[Address(RVA = "0x17B5780", Offset = "0x17B5780", VA = "0x17B5780")]
	public CharacterAutoTargetingEnableSetUp GetCharacterAutoTargetingEnableSetUp(int charid)
	{
		return null;
	}

	[Token(Token = "0x6003502")]
	[Address(RVA = "0x17B58A4", Offset = "0x17B58A4", VA = "0x17B58A4", Slot = "4")]
	public virtual void EnqueLastMatchedPlayers(List<string> nickNames)
	{
	}
}
