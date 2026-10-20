using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000AC2")]
public sealed class CSEmoticonInfoXML
{
	[Token(Token = "0x400326D")]
	[FieldOffset(Offset = "0x8")]
	public List<CSEmoticonSetInfo> dataList;

	[Token(Token = "0x6004F01")]
	[Address(RVA = "0x21F17EC", Offset = "0x21F17EC", VA = "0x21F17EC")]
	public CSEmoticonInfoXML()
	{
	}

	[Token(Token = "0x6004F02")]
	[Address(RVA = "0x21F1898", Offset = "0x21F1898", VA = "0x21F1898")]
	public void Add(CSEmoticonSetInfo i)
	{
	}
}
