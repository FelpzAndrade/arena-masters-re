using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200100E")]
public sealed class XHelpXML
{
	[Token(Token = "0x4005600")]
	[FieldOffset(Offset = "0x8")]
	public List<XHelpInfo> dataList;

	[Token(Token = "0x60077C8")]
	[Address(RVA = "0x1D1F8E0", Offset = "0x1D1F8E0", VA = "0x1D1F8E0")]
	public XHelpXML()
	{
	}

	[Token(Token = "0x60077C9")]
	[Address(RVA = "0x1D1F98C", Offset = "0x1D1F98C", VA = "0x1D1F98C")]
	public void Add(XHelpInfo i)
	{
	}
}
