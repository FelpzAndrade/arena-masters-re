using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E3A")]
public class XWidget_RankRewardList : MonoBehaviour
{
	[Token(Token = "0x4004AFF")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4004B00")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridRankReward;

	[Token(Token = "0x4004B01")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridClanRankReward;

	[Token(Token = "0x4004B02")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH_RANKING_REWARD;

	[Token(Token = "0x60069E4")]
	[Address(RVA = "0x1333410", Offset = "0x1333410", VA = "0x1333410")]
	public XWidget_RankRewardList()
	{
	}

	[Token(Token = "0x60069E6")]
	[Address(RVA = "0x13334A8", Offset = "0x13334A8", VA = "0x13334A8")]
	public static XWidget_RankRewardList CreateRankRewardList(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60069E7")]
	[Address(RVA = "0x1333648", Offset = "0x1333648", VA = "0x1333648")]
	private void HideGrid()
	{
	}

	[Token(Token = "0x60069E8")]
	[Address(RVA = "0x13336F4", Offset = "0x13336F4", VA = "0x13336F4")]
	public void ShowClan(ClanRankType clanRankType, int myRank, int totalRanker)
	{
	}

	[Token(Token = "0x60069E9")]
	[Address(RVA = "0x1333BC0", Offset = "0x1333BC0", VA = "0x1333BC0")]
	public void ShowLadder(RankType rankType, int myRank, int totalRanker)
	{
	}

	[Token(Token = "0x60069EA")]
	[Address(RVA = "0x1333A24", Offset = "0x1333A24", VA = "0x1333A24")]
	private void Build(XWiget_GridBuilder builder, CSRankRewardItem[] modeRewardList, int myRank, int totalRanker, int myTierID)
	{
	}

	[Token(Token = "0x60069EB")]
	[Address(RVA = "0x1333EF0", Offset = "0x1333EF0", VA = "0x1333EF0")]
	public void Hide()
	{
	}

	[Token(Token = "0x60069EC")]
	[Address(RVA = "0x1333F24", Offset = "0x1333F24", VA = "0x1333F24")]
	public void OnClickClose()
	{
	}
}
