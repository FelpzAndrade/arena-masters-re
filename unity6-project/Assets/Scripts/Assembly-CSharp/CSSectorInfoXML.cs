using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000B43")]
public sealed class CSSectorInfoXML
{
	[Token(Token = "0x400380C")]
	[FieldOffset(Offset = "0x8")]
	public List<CSSectorInfo> dataList;

	[Token(Token = "0x6005250")]
	[Address(RVA = "0x1E5FB54", Offset = "0x1E5FB54", VA = "0x1E5FB54")]
	public CSSectorInfoXML()
	{
	}

	[Token(Token = "0x6005251")]
	[Address(RVA = "0x1E5FBF8", Offset = "0x1E5FBF8", VA = "0x1E5FBF8")]
	public void Add(CSSectorInfo i)
	{
	}
}
