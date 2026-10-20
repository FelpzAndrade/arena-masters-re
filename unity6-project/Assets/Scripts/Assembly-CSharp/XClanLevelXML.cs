using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200064D")]
public sealed class XClanLevelXML
{
	[Token(Token = "0x4001E44")]
	[FieldOffset(Offset = "0x8")]
	public List<XClanLevelInfo> dataList;

	[Token(Token = "0x60035F9")]
	[Address(RVA = "0x1AC5D84", Offset = "0x1AC5D84", VA = "0x1AC5D84")]
	public XClanLevelXML()
	{
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0x1AC5E30", Offset = "0x1AC5E30", VA = "0x1AC5E30")]
	public void Add(XClanLevelInfo i)
	{
	}
}
