using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FD7")]
public class XWidget_RankingRewardPopup : MonoBehaviour
{
	[Token(Token = "0x400545A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH_RANKING_REWARD_POPUP;

	[Token(Token = "0x400545B")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_RankingInfo rankingInfo;

	[Token(Token = "0x400545C")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridContentIcon;

	[Token(Token = "0x400545D")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridLabel;

	[Token(Token = "0x400545E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRankingModeText;

	[Token(Token = "0x600760D")]
	[Address(RVA = "0x13326C4", Offset = "0x13326C4", VA = "0x13326C4")]
	public XWidget_RankingRewardPopup()
	{
	}

	[Token(Token = "0x600760F")]
	[Address(RVA = "0x133275C", Offset = "0x133275C", VA = "0x133275C")]
	public static XWidget_RankingRewardPopup CreateRankRewardRecievePopup(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6007610")]
	[Address(RVA = "0x13328FC", Offset = "0x13328FC", VA = "0x13328FC")]
	public void Build(Netdata_Ranker rankerData, int rankerCount, int rankRewardID, RankType rankType)
	{
	}

	[Token(Token = "0x6007611")]
	[Address(RVA = "0x1332C0C", Offset = "0x1332C0C", VA = "0x1332C0C")]
	private void BuildReward(CSRankRewardItem rankRewardItem)
	{
	}

	[Token(Token = "0x6007612")]
	[Address(RVA = "0x1333094", Offset = "0x1333094", VA = "0x1333094")]
	public void Build(ClanRankMetaData clanRankMetaData, int clanRank, int clanRewardID, ClanRankType clanRankType)
	{
	}

	[Token(Token = "0x6007613")]
	[Address(RVA = "0x1332BD8", Offset = "0x1332BD8", VA = "0x1332BD8")]
	public void Show()
	{
	}

	[Token(Token = "0x6007614")]
	[Address(RVA = "0x13332B8", Offset = "0x13332B8", VA = "0x13332B8")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007615")]
	[Address(RVA = "0x13332EC", Offset = "0x13332EC", VA = "0x13332EC")]
	public void OnClickClose()
	{
	}
}
