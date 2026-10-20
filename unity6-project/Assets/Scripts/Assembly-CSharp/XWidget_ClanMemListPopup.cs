using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000EA3")]
public class XWidget_ClanMemListPopup : XUIBaseWidget
{
	[Token(Token = "0x4004CE4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblClanNameTitle;

	[Token(Token = "0x4004CE5")]
	[FieldOffset(Offset = "0x20")]
	public XListView_ClanMemberList memList;

	[Token(Token = "0x6006D37")]
	[Address(RVA = "0x15E4B0C", Offset = "0x15E4B0C", VA = "0x15E4B0C")]
	public XWidget_ClanMemListPopup()
	{
	}

	[Token(Token = "0x6006D38")]
	[Address(RVA = "0x15DA584", Offset = "0x15DA584", VA = "0x15DA584")]
	public void BuildList(string clanName, List<CompletedClanMember> dataList)
	{
	}

	[Token(Token = "0x6006D39")]
	[Address(RVA = "0x15E4B14", Offset = "0x15E4B14", VA = "0x15E4B14")]
	public void BuildList(string clanName, List<CompletedClanMember> dataList, RankListViewType viewType)
	{
	}

	[Token(Token = "0x6006D3A")]
	[Address(RVA = "0x15DA538", Offset = "0x15DA538", VA = "0x15DA538")]
	public void Show()
	{
	}
}
