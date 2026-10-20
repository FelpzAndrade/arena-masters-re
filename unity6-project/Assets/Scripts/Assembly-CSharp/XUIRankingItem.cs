using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001032")]
public class XUIRankingItem : MonoBehaviour
{
	[Token(Token = "0x4005705")]
	[FieldOffset(Offset = "0xC")]
	public UISprite sprBg;

	[Token(Token = "0x4005706")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprChar;

	[Token(Token = "0x4005707")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x4005708")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4005709")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite sprMine;

	[Token(Token = "0x400570A")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprRank;

	[Token(Token = "0x400570B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblRank;

	[Token(Token = "0x400570C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblLv;

	[Token(Token = "0x400570D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblNick;

	[Token(Token = "0x400570E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblScore;

	[Token(Token = "0x400570F")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblWin;

	[Token(Token = "0x4005710")]
	[FieldOffset(Offset = "0x38")]
	public GameObject goDetail;

	[Token(Token = "0x4005711")]
	[FieldOffset(Offset = "0x3C")]
	private string m_userNickName;

	[Token(Token = "0x4005712")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isMine;

	[Token(Token = "0x60078BE")]
	[Address(RVA = "0x1913E68", Offset = "0x1913E68", VA = "0x1913E68")]
	public XUIRankingItem()
	{
	}

	[Token(Token = "0x60078BF")]
	[Address(RVA = "0x1913E70", Offset = "0x1913E70", VA = "0x1913E70")]
	public void Build(XUIRankingList.RankerData rankerData)
	{
	}

	[Token(Token = "0x60078C0")]
	[Address(RVA = "0x19146F8", Offset = "0x19146F8", VA = "0x19146F8")]
	private void BuildRankSprite(int userRank)
	{
	}

	[Token(Token = "0x60078C1")]
	[Address(RVA = "0x19148C4", Offset = "0x19148C4", VA = "0x19148C4")]
	public void OnButtonClick_ShowRankerDetail()
	{
	}
}
