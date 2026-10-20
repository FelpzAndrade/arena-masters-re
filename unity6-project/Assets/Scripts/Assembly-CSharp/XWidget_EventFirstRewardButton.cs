using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EAF")]
public class XWidget_EventFirstRewardButton : MonoBehaviour
{
	[Token(Token = "0x2000EB0")]
	private sealed class _003CBuildWinProgress_003Ec__AnonStorey20B
	{
		[Token(Token = "0x4004D31")]
		[FieldOffset(Offset = "0x8")]
		internal int prbMaxCount;

		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x1427A30", Offset = "0x1427A30", VA = "0x1427A30")]
		public _003CBuildWinProgress_003Ec__AnonStorey20B()
		{
		}

		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x1428200", Offset = "0x1428200", VA = "0x1428200")]
		internal int _003C_003Em__408(int curVal)
		{
			return default(int);
		}

		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x1428208", Offset = "0x1428208", VA = "0x1428208")]
		internal void _003C_003Em__40B(UILabel label, int curValue)
		{
		}
	}

	[Token(Token = "0x4004D21")]
	[FieldOffset(Offset = "0xC")]
	public XUIAcquisitionDirection acqusitionDirection;

	[Token(Token = "0x4004D22")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_RewardItem rewardItem;

	[Token(Token = "0x4004D23")]
	[FieldOffset(Offset = "0x14")]
	public GameObject rewardFrame;

	[Token(Token = "0x4004D24")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TopInputBlockObject;

	[Token(Token = "0x4004D25")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_Button button;

	[Token(Token = "0x4004D26")]
	[FieldOffset(Offset = "0x20")]
	public UITable rewardCountTable;

	[Token(Token = "0x4004D27")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblStepCount;

	[Token(Token = "0x4004D28")]
	[FieldOffset(Offset = "0x28")]
	public EventGameModeInfo eventModeInfo;

	[Token(Token = "0x4004D29")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goComplete;

	[Token(Token = "0x4004D2A")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_ProgressBar prb;

	[Token(Token = "0x4004D2B")]
	[FieldOffset(Offset = "0x34")]
	private Action onRefresh;

	[Token(Token = "0x4004D2C")]
	[FieldOffset(Offset = "0x38")]
	private Action onShowRewardPopup;

	[Token(Token = "0x4004D2D")]
	[FieldOffset(Offset = "0x3C")]
	private EventFirstRewardLogic firstRewardLogic;

	[Token(Token = "0x4004D2E")]
	[FieldOffset(Offset = "0x0")]
	private static Func<int, int> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x4004D2F")]
	[FieldOffset(Offset = "0x4")]
	private static Func<int, bool> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x4004D30")]
	[FieldOffset(Offset = "0x8")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x6006D75")]
	[Address(RVA = "0x1427020", Offset = "0x1427020", VA = "0x1427020")]
	public XWidget_EventFirstRewardButton()
	{
	}

	[Token(Token = "0x6006D76")]
	[Address(RVA = "0x1427028", Offset = "0x1427028", VA = "0x1427028")]
	public void Build(EventGameModeInfo eventModeInfo, Action onRefresh, Action onShowRewardPopup)
	{
	}

	[Token(Token = "0x6006D77")]
	[Address(RVA = "0x1427A1C", Offset = "0x1427A1C", VA = "0x1427A1C")]
	public void OnShowRewardPopup()
	{
	}

	[Token(Token = "0x6006D78")]
	[Address(RVA = "0x142769C", Offset = "0x142769C", VA = "0x142769C")]
	private void BuildWinProgress(EventFirstRewardLogic logic)
	{
	}

	[Token(Token = "0x6006D79")]
	[Address(RVA = "0x14274E4", Offset = "0x14274E4", VA = "0x14274E4")]
	private void BuildRewardStepProgress(int curCount, int maxCount)
	{
	}

	[Token(Token = "0x6006D7A")]
	[Address(RVA = "0x1427A38", Offset = "0x1427A38", VA = "0x1427A38")]
	public void OnClickGetReward()
	{
	}

	[Token(Token = "0x6006D7B")]
	[Address(RVA = "0x1427CB0", Offset = "0x1427CB0", VA = "0x1427CB0")]
	private void EndDirection()
	{
	}

	[Token(Token = "0x6006D7C")]
	[Address(RVA = "0x1427DB4", Offset = "0x1427DB4", VA = "0x1427DB4")]
	private static int _003CBuildWinProgress_003Em__409(int curVal)
	{
		return default(int);
	}

	[Token(Token = "0x6006D7D")]
	[Address(RVA = "0x1427DBC", Offset = "0x1427DBC", VA = "0x1427DBC")]
	private static bool _003CBuildWinProgress_003Em__40A(int curValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D7E")]
	[Address(RVA = "0x1427DC4", Offset = "0x1427DC4", VA = "0x1427DC4")]
	private static void _003CBuildWinProgress_003Em__40C(UIProgressBar progressbar, int curValue)
	{
	}

	[Token(Token = "0x6006D7F")]
	[Address(RVA = "0x1427DC8", Offset = "0x1427DC8", VA = "0x1427DC8")]
	private void _003COnClickGetReward_003Em__40D(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
	{
	}
}
