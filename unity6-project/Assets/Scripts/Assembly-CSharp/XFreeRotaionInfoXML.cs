using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200064A")]
public sealed class XFreeRotaionInfoXML
{
	[Token(Token = "0x4001E40")]
	[FieldOffset(Offset = "0x8")]
	public List<FreeRotaionInfo> dataList;

	[Token(Token = "0x60035EE")]
	[Address(RVA = "0x19B53A8", Offset = "0x19B53A8", VA = "0x19B53A8")]
	public XFreeRotaionInfoXML()
	{
	}

	[Token(Token = "0x60035EF")]
	[Address(RVA = "0x19B5454", Offset = "0x19B5454", VA = "0x19B5454")]
	public void Add(FreeRotaionInfo i)
	{
	}
}
