using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001031")]
public class XUIRankRewardItem : MonoBehaviour
{
	[Token(Token = "0x40056FC")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprFirstReward;

	[Token(Token = "0x40056FD")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblFirstRewardCnt;

	[Token(Token = "0x40056FE")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprSecondReward;

	[Token(Token = "0x40056FF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblSecondRewardCnt;

	[Token(Token = "0x4005700")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblRank;

	[Token(Token = "0x4005701")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprRank;

	[Token(Token = "0x4005702")]
	[FieldOffset(Offset = "0x24")]
	public GameObject sprSelectEffect;

	[Token(Token = "0x4005703")]
	[FieldOffset(Offset = "0x28")]
	private RankRewardUIData firstReward;

	[Token(Token = "0x4005704")]
	[FieldOffset(Offset = "0x2C")]
	private RankRewardUIData secondReward;

	[Token(Token = "0x60078BA")]
	[Address(RVA = "0x1915228", Offset = "0x1915228", VA = "0x1915228")]
	public XUIRankRewardItem()
	{
	}

	[Token(Token = "0x60078BB")]
	[Address(RVA = "0x1915230", Offset = "0x1915230", VA = "0x1915230")]
	private void Awake()
	{
	}

	[Token(Token = "0x60078BC")]
	[Address(RVA = "0x1915350", Offset = "0x1915350", VA = "0x1915350", Slot = "4")]
	public virtual void Build(CSRankRewardItem rankRewardItem, int myRank, int totalRanker, bool isMine)
	{
	}

	[Token(Token = "0x60078BD")]
	[Address(RVA = "0x191563C", Offset = "0x191563C", VA = "0x191563C")]
	private void BuildReward(CSRankRewardItem rankRewardItem)
	{
	}
}
