using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EFB")]
public class XWidget_OtherUserRankInfo : MonoBehaviour
{
	[Token(Token = "0x4004F63")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_RankTierInfo rankTierInfo;

	[Token(Token = "0x4004F64")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblBestScore;

	[Token(Token = "0x4004F65")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblBestTier;

	[Token(Token = "0x4004F66")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblBestWinninStreak;

	[Token(Token = "0x6006FE2")]
	[Address(RVA = "0x1311084", Offset = "0x1311084", VA = "0x1311084")]
	public XWidget_OtherUserRankInfo()
	{
	}

	[Token(Token = "0x6006FE3")]
	[Address(RVA = "0x1310F10", Offset = "0x1310F10", VA = "0x1310F10")]
	public void Build(RankType rankType, int placementTestCount, int lastPlaySeason, int seasonScore, int bestScore, int bestWinningStreak, CSProtoInfoManager_TrophyReward protoTrophy)
	{
	}
}
