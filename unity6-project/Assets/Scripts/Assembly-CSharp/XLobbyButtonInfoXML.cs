using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200066F")]
public sealed class XLobbyButtonInfoXML
{
	[Token(Token = "0x4001EDB")]
	[FieldOffset(Offset = "0x8")]
	public List<XLobbyButtonInfo> dataList;

	[Token(Token = "0x6003671")]
	[Address(RVA = "0x1E186BC", Offset = "0x1E186BC", VA = "0x1E186BC")]
	public XLobbyButtonInfoXML()
	{
	}

	[Token(Token = "0x6003672")]
	[Address(RVA = "0x1E18768", Offset = "0x1E18768", VA = "0x1E18768")]
	public void Add(XLobbyButtonInfo i)
	{
	}
}
