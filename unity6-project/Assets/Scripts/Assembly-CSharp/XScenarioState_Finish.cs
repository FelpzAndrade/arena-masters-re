using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20005C9")]
public class XScenarioState_Finish : XPVEGameModeState_Finish
{
	[Token(Token = "0x20005CA")]
	private sealed class _003CRequestCompleteScenarioGame_003Ec__AnonStorey121
	{
		[Token(Token = "0x4001C1E")]
		[FieldOffset(Offset = "0x8")]
		internal int score;

		[Token(Token = "0x4001C1F")]
		[FieldOffset(Offset = "0xC")]
		internal XScenarioState_Finish _003C_003Ef__this;

		[Token(Token = "0x6003198")]
		[Address(RVA = "0x1CAD9F4", Offset = "0x1CAD9F4", VA = "0x1CAD9F4")]
		public _003CRequestCompleteScenarioGame_003Ec__AnonStorey121()
		{
		}

		[Token(Token = "0x6003199")]
		[Address(RVA = "0x1CAE4A8", Offset = "0x1CAE4A8", VA = "0x1CAE4A8")]
		internal void _003C_003Em__13E(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x20005CB")]
	private sealed class _003CRequestFailureScenarioGame_003Ec__AnonStorey122
	{
		[Token(Token = "0x4001C20")]
		[FieldOffset(Offset = "0x8")]
		internal int score;

		[Token(Token = "0x4001C21")]
		[FieldOffset(Offset = "0xC")]
		internal XScenarioState_Finish _003C_003Ef__this;

		[Token(Token = "0x600319A")]
		[Address(RVA = "0x1CAE358", Offset = "0x1CAE358", VA = "0x1CAE358")]
		public _003CRequestFailureScenarioGame_003Ec__AnonStorey122()
		{
		}

		[Token(Token = "0x600319B")]
		[Address(RVA = "0x1CAEA28", Offset = "0x1CAEA28", VA = "0x1CAEA28")]
		internal void _003C_003Em__13F(ApiReturnCode errno, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x600319C")]
		[Address(RVA = "0x1CAF1E0", Offset = "0x1CAF1E0", VA = "0x1CAF1E0")]
		internal void _003C_003Em__140()
		{
		}
	}

	[Token(Token = "0x4001C1A")]
	[FieldOffset(Offset = "0x20")]
	private new XPlayerManager m_playerManager;

	[Token(Token = "0x4001C1B")]
	[FieldOffset(Offset = "0x24")]
	private Netdata_CompleteMission m_response;

	[Token(Token = "0x4001C1C")]
	[FieldOffset(Offset = "0x28")]
	private int m_score;

	[Token(Token = "0x4001C1D")]
	[FieldOffset(Offset = "0x2C")]
	private int m_celarBeforeTotalStar;

	[Token(Token = "0x600318B")]
	[Address(RVA = "0x1CAC0D0", Offset = "0x1CAC0D0", VA = "0x1CAC0D0")]
	public XScenarioState_Finish()
	{
	}

	[Token(Token = "0x600318C")]
	[Address(RVA = "0x1CAC0D8", Offset = "0x1CAC0D8", VA = "0x1CAC0D8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600318D")]
	[Address(RVA = "0x1CAC604", Offset = "0x1CAC604", VA = "0x1CAC604")]
	private int CalcStar(MissionPlayPattern pattern, int hpPercent, XPlayerManager records)
	{
		return default(int);
	}

	[Token(Token = "0x600318E")]
	[Address(RVA = "0x1CAD7F8", Offset = "0x1CAD7F8", VA = "0x1CAD7F8")]
	private void StartMissionResultProcess()
	{
	}

	[Token(Token = "0x600318F")]
	[Address(RVA = "0x1CAD1F8", Offset = "0x1CAD1F8", VA = "0x1CAD1F8")]
	private void RequestCompleteScenarioGame(int score)
	{
	}

	[Token(Token = "0x6003190")]
	[Address(RVA = "0x1CAD9FC", Offset = "0x1CAD9FC", VA = "0x1CAD9FC")]
	private new void CreatePlayerCharacterObject()
	{
	}

	[Token(Token = "0x6003191")]
	[Address(RVA = "0x1CADB64", Offset = "0x1CADB64", VA = "0x1CADB64")]
	private void ProcessResultExpression()
	{
	}

	[Token(Token = "0x6003192")]
	[Address(RVA = "0x1CADF18", Offset = "0x1CADF18", VA = "0x1CADF18")]
	private void EndResultExpression()
	{
	}

	[Token(Token = "0x6003193")]
	[Address(RVA = "0x1CAE124", Offset = "0x1CAE124", VA = "0x1CAE124")]
	private void ShowFinalRecord()
	{
	}

	[Token(Token = "0x6003194")]
	[Address(RVA = "0x1CAE264", Offset = "0x1CAE264", VA = "0x1CAE264")]
	private void ShowResultWindow()
	{
	}

	[Token(Token = "0x6003195")]
	[Address(RVA = "0x1CACC54", Offset = "0x1CACC54", VA = "0x1CACC54")]
	private void RequestFailureScenarioGame(int score)
	{
	}

	[Token(Token = "0x6003196")]
	[Address(RVA = "0x1CAE360", Offset = "0x1CAE360", VA = "0x1CAE360")]
	private void RequestFailureExit()
	{
	}

	[Token(Token = "0x6003197")]
	[Address(RVA = "0x1CAD7DC", Offset = "0x1CAD7DC", VA = "0x1CAD7DC")]
	public int CalcStar(int hpPercent, int ref1, int ref2)
	{
		return default(int);
	}
}
