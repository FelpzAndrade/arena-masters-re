using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000D72")]
public sealed class XKillStreakInfoXML
{
	[Token(Token = "0x400455E")]
	[FieldOffset(Offset = "0x8")]
	public List<XKillStreakInfo> dataList;

	[Token(Token = "0x60062B6")]
	[Address(RVA = "0x1D38464", Offset = "0x1D38464", VA = "0x1D38464")]
	public XKillStreakInfoXML()
	{
	}

	[Token(Token = "0x60062B7")]
	[Address(RVA = "0x1D38510", Offset = "0x1D38510", VA = "0x1D38510")]
	public void Add(XKillStreakInfo i)
	{
	}
}
