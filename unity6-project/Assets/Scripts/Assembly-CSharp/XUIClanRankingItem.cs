using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200101E")]
public class XUIClanRankingItem : MonoBehaviour
{
	[Token(Token = "0x4005658")]
	[FieldOffset(Offset = "0xC")]
	public UISprite sprBg;

	[Token(Token = "0x4005659")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprMark;

	[Token(Token = "0x400565A")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x400565B")]
	[FieldOffset(Offset = "0x18")]
	public UISprite sprMine;

	[Token(Token = "0x400565C")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprRank;

	[Token(Token = "0x400565D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblName;

	[Token(Token = "0x400565E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblRank;

	[Token(Token = "0x400565F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblScore;

	[Token(Token = "0x4005660")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblWin;

	[Token(Token = "0x4005661")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goDetail;

	[Token(Token = "0x4005662")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isMine;

	[Token(Token = "0x4005663")]
	[FieldOffset(Offset = "0x38")]
	private string m_clanId;

	[Token(Token = "0x4005664")]
	[FieldOffset(Offset = "0x3C")]
	private Action<string, RankListViewType> m_onDetail;

	[Token(Token = "0x4005665")]
	[FieldOffset(Offset = "0x40")]
	private RankListViewType m_ViewType;

	[Token(Token = "0x600782E")]
	[Address(RVA = "0x1A38A0C", Offset = "0x1A38A0C", VA = "0x1A38A0C")]
	public XUIClanRankingItem()
	{
	}

	[Token(Token = "0x600782F")]
	[Address(RVA = "0x1A38A14", Offset = "0x1A38A14", VA = "0x1A38A14")]
	public void Build(XUIClanRankingList.ClanRankData rankerData, int rankersCount, RankListViewType viewType, Action<string, RankListViewType> onDetail)
	{
	}

	[Token(Token = "0x6007830")]
	[Address(RVA = "0x1A39234", Offset = "0x1A39234", VA = "0x1A39234")]
	private void BuildClanMark(int markId, int markColorId)
	{
	}

	[Token(Token = "0x6007831")]
	[Address(RVA = "0x1A39068", Offset = "0x1A39068", VA = "0x1A39068")]
	private void BuildRankSprite(int userRank)
	{
	}

	[Token(Token = "0x6007832")]
	[Address(RVA = "0x1A39514", Offset = "0x1A39514", VA = "0x1A39514")]
	public void OnButtonClick_ShowClanDetail()
	{
	}
}
