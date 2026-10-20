using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000689")]
public sealed class TutorialInfoXML
{
	[Token(Token = "0x4002000")]
	[FieldOffset(Offset = "0x8")]
	public List<TutorialInfo> dataList;

	[Token(Token = "0x6003718")]
	[Address(RVA = "0x1D5BE94", Offset = "0x1D5BE94", VA = "0x1D5BE94")]
	public TutorialInfoXML()
	{
	}

	[Token(Token = "0x6003719")]
	[Address(RVA = "0x1D5BF40", Offset = "0x1D5BF40", VA = "0x1D5BF40")]
	public void Add(TutorialInfo i)
	{
	}
}
