using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000AA9")]
public sealed class CSCharacterSoundInfoXML
{
	[Token(Token = "0x400321E")]
	[FieldOffset(Offset = "0x8")]
	public List<CSCharacterSoundInfo> dataList;

	[Token(Token = "0x6004E92")]
	[Address(RVA = "0x21F1484", Offset = "0x21F1484", VA = "0x21F1484")]
	public CSCharacterSoundInfoXML()
	{
	}

	[Token(Token = "0x6004E93")]
	[Address(RVA = "0x21F1530", Offset = "0x21F1530", VA = "0x21F1530")]
	public void Add(CSCharacterSoundInfo i)
	{
	}
}
