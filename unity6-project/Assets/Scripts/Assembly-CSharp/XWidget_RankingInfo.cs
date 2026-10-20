using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001041")]
public class XWidget_RankingInfo : MonoBehaviour
{
	[Token(Token = "0x4005788")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_RankTierInfo rankTierInfo;

	[Token(Token = "0x4005789")]
	[FieldOffset(Offset = "0x10")]
	public GameObject goPTRoot;

	[Token(Token = "0x400578A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblPTCount;

	[Token(Token = "0x400578B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goClanRoot;

	[Token(Token = "0x400578C")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprClanMark;

	[Token(Token = "0x400578D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblTitle;

	[Token(Token = "0x400578E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblClanName;

	[Token(Token = "0x400578F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblMyRank;

	[Token(Token = "0x4005790")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblMyScore;

	[Token(Token = "0x4005791")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblMyWinRate;

	[Token(Token = "0x4005792")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblMyWinningStreak;

	[Token(Token = "0x4005793")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblMyPerfectVictory;

	[Token(Token = "0x4005794")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblMyWin;

	[Token(Token = "0x4005795")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblMyLose;

	[Token(Token = "0x4005796")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblMyDraw;

	[Token(Token = "0x4005797")]
	[FieldOffset(Offset = "0x48")]
	public UILabel lblMyRankText;

	[Token(Token = "0x4005798")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblMyScoreText;

	[Token(Token = "0x4005799")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblMyWinningStreakText;

	[Token(Token = "0x400579A")]
	[FieldOffset(Offset = "0x54")]
	public UILabel lblMyPerfectVictoryText;

	[Token(Token = "0x400579B")]
	[FieldOffset(Offset = "0x58")]
	public UILabel lblMyRecordText;

	[Token(Token = "0x400579C")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel lblMyWinText;

	[Token(Token = "0x400579D")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblMatchTypeScoreText;

	[Token(Token = "0x6007953")]
	[Address(RVA = "0x133063C", Offset = "0x133063C", VA = "0x133063C")]
	public XWidget_RankingInfo()
	{
	}

	[Token(Token = "0x6007954")]
	[Address(RVA = "0x1330644", Offset = "0x1330644", VA = "0x1330644")]
	public void BuildThisWeek(bool isPt, int ptCount, Netdata_Ranker rankerData, int rankerCount = 0)
	{
	}

	[Token(Token = "0x6007955")]
	[Address(RVA = "0x13314C8", Offset = "0x13314C8", VA = "0x13314C8")]
	public void BuildThisWeek(int clanRank, ClanRankMetaData clanRankMetaData)
	{
	}

	[Token(Token = "0x6007956")]
	[Address(RVA = "0x1331FB8", Offset = "0x1331FB8", VA = "0x1331FB8")]
	private void BuildClanMark(int markId, int markColorId)
	{
	}

	[Token(Token = "0x6007957")]
	[Address(RVA = "0x1332298", Offset = "0x1332298", VA = "0x1332298")]
	public void BuildTotalData(bool isPt, int ptCount, Netdata_Ranker rankerData)
	{
	}

	[Token(Token = "0x6007958")]
	[Address(RVA = "0x1331078", Offset = "0x1331078", VA = "0x1331078")]
	public void SetAcvieScore(bool isPt)
	{
	}

	[Token(Token = "0x6007959")]
	[Address(RVA = "0x133121C", Offset = "0x133121C", VA = "0x133121C")]
	public void BuildScore(int score)
	{
	}

	[Token(Token = "0x600795A")]
	[Address(RVA = "0x13311E0", Offset = "0x13311E0", VA = "0x13311E0")]
	public void BuildRank(int rank)
	{
	}

	[Token(Token = "0x600795B")]
	[Address(RVA = "0x1331258", Offset = "0x1331258", VA = "0x1331258")]
	private void BuildRecord(GameRecord gameRecord)
	{
	}

	[Token(Token = "0x600795C")]
	[Address(RVA = "0x1330DE4", Offset = "0x1330DE4", VA = "0x1330DE4")]
	private void BuildText(bool isThisWeek)
	{
	}

	[Token(Token = "0x600795D")]
	[Address(RVA = "0x1330B40", Offset = "0x1330B40", VA = "0x1330B40")]
	public void Init(string initValue)
	{
	}

	[Token(Token = "0x600795E")]
	[Address(RVA = "0x1331A30", Offset = "0x1331A30", VA = "0x1331A30")]
	public void InitClan(string initValue)
	{
	}
}
