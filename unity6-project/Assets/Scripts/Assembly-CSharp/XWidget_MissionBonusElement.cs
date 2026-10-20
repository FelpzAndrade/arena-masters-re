using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FA9")]
public class XWidget_MissionBonusElement : MonoBehaviour
{
	[Token(Token = "0x40052E6")]
	[FieldOffset(Offset = "0xC")]
	public Transform transformSprStar;

	[Token(Token = "0x40052E7")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_RewardItem soulStoneReward;

	[Token(Token = "0x40052E8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblStarCnt;

	[Token(Token = "0x40052E9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblWarnnig;

	[Token(Token = "0x40052EA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblEnterText;

	[Token(Token = "0x40052EB")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblEnterCnt;

	[Token(Token = "0x40052EC")]
	[FieldOffset(Offset = "0x24")]
	public TweenScale starTweenScale;

	[Token(Token = "0x40052ED")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_Button btn;

	[Token(Token = "0x40052EE")]
	[FieldOffset(Offset = "0x2C")]
	public UIProgressBar prbBonus;

	[Token(Token = "0x40052EF")]
	[FieldOffset(Offset = "0x30")]
	private CSStageInfo m_stageInfo;

	[Token(Token = "0x40052F0")]
	[FieldOffset(Offset = "0x34")]
	private bool m_enterable;

	[Token(Token = "0x40052F1")]
	[FieldOffset(Offset = "0x38")]
	private int m_totalStar;

	[Token(Token = "0x600749C")]
	[Address(RVA = "0x1465854", Offset = "0x1465854", VA = "0x1465854")]
	public XWidget_MissionBonusElement()
	{
	}

	[Token(Token = "0x600749D")]
	[Address(RVA = "0x146585C", Offset = "0x146585C", VA = "0x146585C")]
	public void Show(CSStageInfo stageInfo, int totalStar, int playedCnt, bool enterable)
	{
	}

	[Token(Token = "0x600749E")]
	[Address(RVA = "0x1466260", Offset = "0x1466260", VA = "0x1466260")]
	public void OnClick_GoToMissionDetail()
	{
	}

	[Token(Token = "0x600749F")]
	[Address(RVA = "0x1465CDC", Offset = "0x1465CDC", VA = "0x1465CDC")]
	private void BuildBonus(int totalStar)
	{
	}

	[Token(Token = "0x60074A0")]
	[Address(RVA = "0x1465E3C", Offset = "0x1465E3C", VA = "0x1465E3C")]
	private void BuildText(bool enable, int chapter, int playableCnt)
	{
	}
}
