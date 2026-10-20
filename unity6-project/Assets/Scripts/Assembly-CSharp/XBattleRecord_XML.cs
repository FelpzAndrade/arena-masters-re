using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000647")]
public sealed class XBattleRecord_XML
{
	[Token(Token = "0x4001E3B")]
	[FieldOffset(Offset = "0x8")]
	public List<XBattleRecord_XMLData> dataList;

	[Token(Token = "0x60035E2")]
	[Address(RVA = "0x1EFF320", Offset = "0x1EFF320", VA = "0x1EFF320")]
	public XBattleRecord_XML()
	{
	}

	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x1EFF3CC", Offset = "0x1EFF3CC", VA = "0x1EFF3CC")]
	public void Add(XBattleRecord_XMLData i)
	{
	}
}
