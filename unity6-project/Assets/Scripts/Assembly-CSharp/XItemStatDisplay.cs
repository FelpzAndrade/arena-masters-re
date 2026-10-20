using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2001063")]
public class XItemStatDisplay
{
	[Token(Token = "0x4005881")]
	[FieldOffset(Offset = "0x8")]
	private List<XCharStatusDisplay> m_randomOptionStatDisplayList;

	[Token(Token = "0x4005882")]
	[FieldOffset(Offset = "0xC")]
	private XCharStatusDisplay m_statDisply;

	[Token(Token = "0x4005883")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_majorStats;

	[Token(Token = "0x4005884")]
	[FieldOffset(Offset = "0x14")]
	private List<string> m_displayStats;

	[Token(Token = "0x4005885")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_randomStats;

	[Token(Token = "0x6007BD6")]
	[Address(RVA = "0x1D3641C", Offset = "0x1D3641C", VA = "0x1D3641C")]
	public XItemStatDisplay(XItem item)
	{
	}

	[Token(Token = "0x6007BD7")]
	[Address(RVA = "0x1D36424", Offset = "0x1D36424", VA = "0x1D36424")]
	public XItemStatDisplay(XItem item, XItem itemOther)
	{
	}

	[Token(Token = "0x6007BD8")]
	[Address(RVA = "0x1D369A0", Offset = "0x1D369A0", VA = "0x1D369A0")]
	public List<XCharStatusDisplay.StatInfo> DetailItemStats()
	{
		return null;
	}

	[Token(Token = "0x6007BD9")]
	[Address(RVA = "0x1D36CB0", Offset = "0x1D36CB0", VA = "0x1D36CB0")]
	public List<XCharStatusDisplay.StatInfo> GetExcetMajorStats()
	{
		return null;
	}

	[Token(Token = "0x6007BDA")]
	[Address(RVA = "0x1D36F44", Offset = "0x1D36F44", VA = "0x1D36F44")]
	public List<XCharStatusDisplay.StatInfo> GetRandomOptionStats()
	{
		return null;
	}

	[Token(Token = "0x6007BDB")]
	[Address(RVA = "0x1D370F0", Offset = "0x1D370F0", VA = "0x1D370F0")]
	public List<XCharStatusDisplay.StatInfo> GetMajorStats()
	{
		return null;
	}
}
