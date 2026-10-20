using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000651")]
public sealed class XClanMarkXML
{
	[Token(Token = "0x4001E4D")]
	[FieldOffset(Offset = "0x8")]
	public List<XClanMarkProtoInfo> dataList;

	[Token(Token = "0x6003606")]
	[Address(RVA = "0x1AC6230", Offset = "0x1AC6230", VA = "0x1AC6230")]
	public XClanMarkXML()
	{
	}

	[Token(Token = "0x6003607")]
	[Address(RVA = "0x1AC62DC", Offset = "0x1AC62DC", VA = "0x1AC62DC")]
	public void Add(XClanMarkProtoInfo i)
	{
	}
}
