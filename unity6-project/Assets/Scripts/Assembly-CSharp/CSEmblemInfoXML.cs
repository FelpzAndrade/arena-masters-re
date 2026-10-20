using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000ABE")]
public sealed class CSEmblemInfoXML
{
	[Token(Token = "0x4003254")]
	[FieldOffset(Offset = "0x8")]
	public List<CSEmblemSetInfo> dataList;

	[Token(Token = "0x6004EF3")]
	[Address(RVA = "0x21F15D0", Offset = "0x21F15D0", VA = "0x21F15D0")]
	public CSEmblemInfoXML()
	{
	}

	[Token(Token = "0x6004EF4")]
	[Address(RVA = "0x21F167C", Offset = "0x21F167C", VA = "0x21F167C")]
	public void Add(CSEmblemSetInfo i)
	{
	}
}
