using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FBB")]
public class XWidget_OtherUserInfoPopup : XUIBaseWidget
{
	[Token(Token = "0x4005374")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject sprGoodManner;

	[Token(Token = "0x4005375")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprBadManner;

	[Token(Token = "0x4005376")]
	[FieldOffset(Offset = "0x24")]
	public UISprite sprMannerBackground;

	[Token(Token = "0x4005377")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblMannerScore;

	[Token(Token = "0x4005378")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblName;

	[Token(Token = "0x4005379")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblClanName;

	[Token(Token = "0x400537A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblLv;

	[Token(Token = "0x400537B")]
	[FieldOffset(Offset = "0x38")]
	public UI2DSprite sprFrame;

	[Token(Token = "0x400537C")]
	[FieldOffset(Offset = "0x3C")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x400537D")]
	[FieldOffset(Offset = "0x40")]
	public XWiget_GridBuilder rankInfoBuilder;

	[Token(Token = "0x400537E")]
	[FieldOffset(Offset = "0x44")]
	public XWidget_MostPlayedCharInfo mostPlayedInfo;

	[Token(Token = "0x6007518")]
	[Address(RVA = "0x131029C", Offset = "0x131029C", VA = "0x131029C")]
	public XWidget_OtherUserInfoPopup()
	{
	}

	[Token(Token = "0x6007519")]
	[Address(RVA = "0x13102A4", Offset = "0x13102A4", VA = "0x13102A4")]
	public void Show(NetData_OtherUserMetaData otherUserMetaData)
	{
	}

	[Token(Token = "0x600751A")]
	[Address(RVA = "0x1310300", Offset = "0x1310300", VA = "0x1310300")]
	private void Build(NetData_OtherUserMetaData otherUserMetaData)
	{
	}

	[Token(Token = "0x600751B")]
	[Address(RVA = "0x131051C", Offset = "0x131051C", VA = "0x131051C")]
	private void BuildMannerScore(NetData_OtherUserMetaData otherUserMetaData)
	{
	}

	[Token(Token = "0x600751C")]
	[Address(RVA = "0x1310740", Offset = "0x1310740", VA = "0x1310740")]
	private void BuildClanName(string clanName)
	{
	}

	[Token(Token = "0x600751D")]
	[Address(RVA = "0x13108B0", Offset = "0x13108B0", VA = "0x13108B0")]
	private void BuildRankInfo(NetData_OtherUserMetaData otherUserMetaData)
	{
	}

	[Token(Token = "0x600751E")]
	[Address(RVA = "0x1310BC4", Offset = "0x1310BC4", VA = "0x1310BC4")]
	private void BuildRankInfo(XWidget_OtherUserRankInfo widget, RankType type, NetData_OtherUserMetaData otherUserMetaData)
	{
	}

	[Token(Token = "0x600751F")]
	[Address(RVA = "0x1310AB8", Offset = "0x1310AB8", VA = "0x1310AB8")]
	public void BuildProfileIcon(int id)
	{
	}

	[Token(Token = "0x6007520")]
	[Address(RVA = "0x13109AC", Offset = "0x13109AC", VA = "0x13109AC")]
	private void BuildFrame(int id)
	{
	}
}
