using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000677")]
public sealed class ShowBoxInfoXML
{
	[Token(Token = "0x4001F0F")]
	[FieldOffset(Offset = "0x8")]
	public List<ShowBoxInfo> dataList;

	[Token(Token = "0x6003687")]
	[Address(RVA = "0x20F8D58", Offset = "0x20F8D58", VA = "0x20F8D58")]
	public ShowBoxInfoXML()
	{
	}

	[Token(Token = "0x6003688")]
	[Address(RVA = "0x20F8E04", Offset = "0x20F8E04", VA = "0x20F8E04")]
	public void Add(ShowBoxInfo i)
	{
	}
}
