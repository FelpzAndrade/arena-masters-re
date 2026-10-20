using CS;
using Il2CppDummyDll;

[Token(Token = "0x200085D")]
public class XRoomJoinLevelCalculator
{
	[Token(Token = "0x400241D")]
	private const int TOLER_LEVEL_1_15 = 8;

	[Token(Token = "0x400241E")]
	private const int TOLER_LEVEL_16_25 = 10;

	[Token(Token = "0x400241F")]
	private const int TOLER_LEVEL_26_40 = 12;

	[Token(Token = "0x4002420")]
	private const int TOLER_LEVEL_41_50 = 10;

	[Token(Token = "0x4002421")]
	private const float SLIDE_TDM_WIN = 0.1f;

	[Token(Token = "0x4002422")]
	private const float SLIDE_TDM_DRAW = 0f;

	[Token(Token = "0x4002423")]
	private const float SLIDE_TDM_LOSE = -0.1f;

	[Token(Token = "0x4002424")]
	private const float SLIDE_DM_RANK_1 = 0.1f;

	[Token(Token = "0x4002425")]
	private const float SLIDE_DM_RANK_2 = 0.05f;

	[Token(Token = "0x4002426")]
	private const float SLIDE_DM_RANK_3 = 0f;

	[Token(Token = "0x4002427")]
	private const float SLIDE_DM_RANK_4 = 0f;

	[Token(Token = "0x4002428")]
	private const float SLIDE_DM_RANK_5 = -0.05f;

	[Token(Token = "0x4002429")]
	private const float SLIDE_DM_RANK_6 = -0.1f;

	[Token(Token = "0x400242A")]
	private const float SLIDE_MIN = -0.3f;

	[Token(Token = "0x400242B")]
	private const float SLIDE_MAX = 0.3f;

	[Token(Token = "0x400242C")]
	private const int MIN_LEVEL = 1;

	[Token(Token = "0x400242D")]
	private const int MAX_LEVEL = 60;

	[Token(Token = "0x400242E")]
	[FieldOffset(Offset = "0x8")]
	private bool FREE_LEVEL_MATCHING;

	[Token(Token = "0x400242F")]
	[FieldOffset(Offset = "0xC")]
	private int m_MinLevel;

	[Token(Token = "0x4002430")]
	[FieldOffset(Offset = "0x10")]
	private int m_MaxLevel;

	[Token(Token = "0x4002431")]
	[FieldOffset(Offset = "0x14")]
	private XGameModeType m_GameModeType;

	[Token(Token = "0x4002432")]
	[FieldOffset(Offset = "0x18")]
	private int m_TolerLevel;

	[Token(Token = "0x4002433")]
	[FieldOffset(Offset = "0x1C")]
	private float m_fTDMSlide;

	[Token(Token = "0x4002434")]
	[FieldOffset(Offset = "0x20")]
	private float m_fDMSlide;

	[Token(Token = "0x17000969")]
	public int TolerLevel
	{
		[Token(Token = "0x6004561")]
		[Address(RVA = "0x1CA7240", Offset = "0x1CA7240", VA = "0x1CA7240")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700096A")]
	public float TDMSlide
	{
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x1CA7248", Offset = "0x1CA7248", VA = "0x1CA7248")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700096B")]
	public float DMSlide
	{
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x1CA7250", Offset = "0x1CA7250", VA = "0x1CA7250")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6004557")]
	[Address(RVA = "0x1CA6E78", Offset = "0x1CA6E78", VA = "0x1CA6E78")]
	public XRoomJoinLevelCalculator()
	{
	}

	[Token(Token = "0x6004558")]
	[Address(RVA = "0x1CA6E94", Offset = "0x1CA6E94", VA = "0x1CA6E94")]
	public void SetFreeMatching(bool b)
	{
	}

	[Token(Token = "0x6004559")]
	[Address(RVA = "0x1CA6E9C", Offset = "0x1CA6E9C", VA = "0x1CA6E9C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600455A")]
	[Address(RVA = "0x1CA6EB4", Offset = "0x1CA6EB4", VA = "0x1CA6EB4")]
	public void Calc(XGameModeType gameModeType, int nCharLevel)
	{
	}

	[Token(Token = "0x600455B")]
	[Address(RVA = "0x1CA6FAC", Offset = "0x1CA6FAC", VA = "0x1CA6FAC")]
	private void CalcTolerLevel(int nCharLevel)
	{
	}

	[Token(Token = "0x600455C")]
	[Address(RVA = "0x1CA6FF8", Offset = "0x1CA6FF8", VA = "0x1CA6FF8")]
	public void BuildGameResult(XGameModeType nGameModeType, CSWinlose winlose, int nRank)
	{
	}

	[Token(Token = "0x600455D")]
	[Address(RVA = "0x1CA717C", Offset = "0x1CA717C", VA = "0x1CA717C")]
	private void BuildTDMResult(CSWinlose winlose)
	{
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0x1CA70C4", Offset = "0x1CA70C4", VA = "0x1CA70C4")]
	private void BuildDMResult(int nRank)
	{
	}

	[Token(Token = "0x600455F")]
	[Address(RVA = "0x1CA71F8", Offset = "0x1CA71F8", VA = "0x1CA71F8")]
	public int GetJoinableMinLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6004560")]
	[Address(RVA = "0x1CA721C", Offset = "0x1CA721C", VA = "0x1CA721C")]
	public int GetJoinableMaxLevel()
	{
		return default(int);
	}
}
