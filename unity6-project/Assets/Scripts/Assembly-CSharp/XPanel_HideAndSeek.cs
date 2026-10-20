using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000D14")]
public class XPanel_HideAndSeek : XPanel_GameBase
{
	[Token(Token = "0x40042CE")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_RankedIcons rankedIcons;

	[Token(Token = "0x6005FB4")]
	[Address(RVA = "0xFF5C14", Offset = "0xFF5C14", VA = "0xFF5C14")]
	public XPanel_HideAndSeek()
	{
	}

	[Token(Token = "0x6005FB5")]
	[Address(RVA = "0xFF5C1C", Offset = "0xFF5C1C", VA = "0xFF5C1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6005FB6")]
	[Address(RVA = "0xFF5C60", Offset = "0xFF5C60", VA = "0xFF5C60")]
	public void UpdateRankedIcon()
	{
	}

	[Token(Token = "0x6005FB7")]
	[Address(RVA = "0xFF5D38", Offset = "0xFF5D38", VA = "0xFF5D38")]
	public void BuildRank(List<XPlayer> players, IRecordUISetter setter)
	{
	}
}
