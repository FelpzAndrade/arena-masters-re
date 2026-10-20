using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FAD")]
public class XWidget_MissionStageItem : MonoBehaviour
{
	[Token(Token = "0x4005308")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprFarmingType;

	[Token(Token = "0x4005309")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblFramingType;

	[Token(Token = "0x400530A")]
	[FieldOffset(Offset = "0x14")]
	public XUISound sound;

	[Token(Token = "0x400530B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblStageName;

	[Token(Token = "0x400530C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goStarRoot;

	[Token(Token = "0x400530D")]
	[FieldOffset(Offset = "0x20")]
	public XWiget_GridBuilder gridStar;

	[Token(Token = "0x400530E")]
	[FieldOffset(Offset = "0x24")]
	public UISprite sprActive;

	[Token(Token = "0x400530F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goLock;

	[Token(Token = "0x4005310")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblMissionType;

	[Token(Token = "0x4005311")]
	[FieldOffset(Offset = "0x30")]
	public CSStageInfo m_stageInfo;

	[Token(Token = "0x4005312")]
	[FieldOffset(Offset = "0x34")]
	public int BestScore;

	[Token(Token = "0x4005313")]
	[FieldOffset(Offset = "0x38")]
	public bool Enterable;

	[Token(Token = "0x4005314")]
	[FieldOffset(Offset = "0x39")]
	public bool IsRemainPlayCnt;

	[Token(Token = "0x4005315")]
	[FieldOffset(Offset = "0x3C")]
	public int TotalStar;

	[Token(Token = "0x4005316")]
	[FieldOffset(Offset = "0x40")]
	public bool IsBonusStage;

	[Token(Token = "0x4005317")]
	[FieldOffset(Offset = "0x41")]
	public bool IsActive;

	[Token(Token = "0x4005318")]
	[FieldOffset(Offset = "0x42")]
	public bool IsClear;

	[Token(Token = "0x4005319")]
	[FieldOffset(Offset = "0x44")]
	public GameObject goBonusRoot;

	[Token(Token = "0x400531A")]
	[FieldOffset(Offset = "0x48")]
	public Transform transformSprStar;

	[Token(Token = "0x400531B")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_RewardItem soulStoneReward;

	[Token(Token = "0x400531C")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblStarCnt;

	[Token(Token = "0x400531D")]
	[FieldOffset(Offset = "0x54")]
	public UILabel lblEnterCnt;

	[Token(Token = "0x400531E")]
	[FieldOffset(Offset = "0x58")]
	public TweenScale starTweenScale;

	[Token(Token = "0x400531F")]
	[FieldOffset(Offset = "0x5C")]
	public UIProgressBar prbBonus;

	[Token(Token = "0x4005320")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblStageNum;

	[Token(Token = "0x4005321")]
	[FieldOffset(Offset = "0x64")]
	private int MAX_STAR;

	[Token(Token = "0x17000ED2")]
	public int StageIndex
	{
		[Token(Token = "0x60074B0")]
		[Address(RVA = "0x14677D4", Offset = "0x14677D4", VA = "0x14677D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60074AF")]
	[Address(RVA = "0x14677C4", Offset = "0x14677C4", VA = "0x14677C4")]
	public XWidget_MissionStageItem()
	{
	}

	[Token(Token = "0x60074B1")]
	[Address(RVA = "0x14677F8", Offset = "0x14677F8", VA = "0x14677F8", Slot = "4")]
	public virtual void Show(CSStageInfo stageInfo, int bestScore, bool isPrevClear)
	{
	}

	[Token(Token = "0x60074B2")]
	[Address(RVA = "0x1467900", Offset = "0x1467900", VA = "0x1467900")]
	public void Show(CSStageInfo stageInfo, int bestScore, int totalStar, int playedCnt, bool enterable)
	{
	}

	[Token(Token = "0x60074B3")]
	[Address(RVA = "0x14679AC", Offset = "0x14679AC", VA = "0x14679AC")]
	private void BuildBonus(int totalStar, int playedCnt, bool enterable)
	{
	}

	[Token(Token = "0x60074B4")]
	[Address(RVA = "0x1467858", Offset = "0x1467858", VA = "0x1467858")]
	private void BuildCommon(CSStageInfo stageInfo, int bestScore, bool enterable)
	{
	}

	[Token(Token = "0x60074B5")]
	[Address(RVA = "0x14681D4", Offset = "0x14681D4", VA = "0x14681D4")]
	private void ActiveRightInfo()
	{
	}

	[Token(Token = "0x60074B6")]
	[Address(RVA = "0x1468220", Offset = "0x1468220", VA = "0x1468220")]
	private void BuildFarmingType()
	{
	}

	[Token(Token = "0x60074B7")]
	[Address(RVA = "0x146898C", Offset = "0x146898C", VA = "0x146898C")]
	private void BuildMissionType()
	{
	}

	[Token(Token = "0x60074B8")]
	[Address(RVA = "0x1467FF0", Offset = "0x1467FF0", VA = "0x1467FF0")]
	private void BuildStageNumber()
	{
	}

	[Token(Token = "0x60074B9")]
	[Address(RVA = "0x146803C", Offset = "0x146803C", VA = "0x146803C")]
	private void BuildActive()
	{
	}

	[Token(Token = "0x60074BA")]
	[Address(RVA = "0x1468C70", Offset = "0x1468C70", VA = "0x1468C70")]
	private void BuildStar()
	{
	}

	[Token(Token = "0x60074BB")]
	[Address(RVA = "0x1467E48", Offset = "0x1467E48", VA = "0x1467E48")]
	public void BuildEnterCnt(CSStageInfo stageInfo, int playableCnt)
	{
	}

	[Token(Token = "0x60074BC")]
	[Address(RVA = "0x1468CEC", Offset = "0x1468CEC", VA = "0x1468CEC")]
	public void SetSound(bool enterable)
	{
	}

	[Token(Token = "0x60074BD")]
	[Address(RVA = "0x1468DD0", Offset = "0x1468DD0", VA = "0x1468DD0")]
	public void OnClick_Enter()
	{
	}
}
