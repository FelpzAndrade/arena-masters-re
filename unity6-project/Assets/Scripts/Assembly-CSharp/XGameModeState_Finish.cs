using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XAssetBundle;

[Token(Token = "0x20005AA")]
public class XGameModeState_Finish : XGameModeState
{
	[Token(Token = "0x20005AB")]
	private sealed class _003CLoadPlayerCharacterObject_003Ec__Iterator4A : IDisposable
	{
		[Token(Token = "0x4001B87")]
		[FieldOffset(Offset = "0x8")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeState_Finish _003C_003Ef__this;

		[Token(Token = "0x17000767")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003087")]
			[Address(RVA = "0x1417FD0", Offset = "0x1417FD0", VA = "0x1417FD0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000768")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003088")]
			[Address(RVA = "0x1417FD8", Offset = "0x1417FD8", VA = "0x1417FD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003086")]
		[Address(RVA = "0x1416780", Offset = "0x1416780", VA = "0x1416780")]
		public _003CLoadPlayerCharacterObject_003Ec__Iterator4A()
		{
		}

		[Token(Token = "0x6003087")]
		[Address(RVA = "0x1417FD0", Offset = "0x1417FD0", VA = "0x1417FD0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003088")]
		[Address(RVA = "0x1417FD8", Offset = "0x1417FD8", VA = "0x1417FD8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003089")]
		[Address(RVA = "0x1417FE0", Offset = "0x1417FE0", VA = "0x1417FE0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600308A")]
		[Address(RVA = "0x1418310", Offset = "0x1418310", VA = "0x1418310", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600308B")]
		[Address(RVA = "0x141831C", Offset = "0x141831C", VA = "0x141831C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20005AC")]
	private sealed class _003CRequestCompleteGame_003Ec__AnonStorey11C
	{
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x8")]
		internal XPlayer myPlayer;

		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0xC")]
		internal XPlayerManager playerManager;

		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0x10")]
		internal XGameModeType gameModeType;

		[Token(Token = "0x4001B8E")]
		[FieldOffset(Offset = "0x14")]
		internal CSWinlose gameWinlose;

		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x18")]
		internal MatchType matchType;

		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x1C")]
		internal XGameModeState_Finish _003C_003Ef__this;

		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache6;

		[Token(Token = "0x600308C")]
		[Address(RVA = "0x14161FC", Offset = "0x14161FC", VA = "0x14161FC")]
		public _003CRequestCompleteGame_003Ec__AnonStorey11C()
		{
		}

		[Token(Token = "0x600308D")]
		[Address(RVA = "0x14183B0", Offset = "0x14183B0", VA = "0x14183B0")]
		internal void _003C_003Em__116(ApiReturnCode errno, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x600308E")]
		[Address(RVA = "0x1418D1C", Offset = "0x1418D1C", VA = "0x1418D1C")]
		private static void _003C_003Em__117()
		{
		}
	}

	[Token(Token = "0x4001B84")]
	[FieldOffset(Offset = "0x14")]
	protected XPlayerManager m_playerManager;

	[Token(Token = "0x4001B85")]
	[FieldOffset(Offset = "0x18")]
	protected ApiReturnCode m_errno;

	[Token(Token = "0x4001B86")]
	[FieldOffset(Offset = "0x1C")]
	protected Netdata_CompleteGame m_gameResponse;

	[Token(Token = "0x17000766")]
	protected virtual float finishDelay
	{
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x1414AE8", Offset = "0x1414AE8", VA = "0x1414AE8", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003070")]
	[Address(RVA = "0x1414AD8", Offset = "0x1414AD8", VA = "0x1414AD8")]
	public XGameModeState_Finish()
	{
	}

	[Token(Token = "0x6003071")]
	[Address(RVA = "0x1414AE0", Offset = "0x1414AE0", VA = "0x1414AE0", Slot = "15")]
	public override XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x6003073")]
	[Address(RVA = "0x1414AF0", Offset = "0x1414AF0", VA = "0x1414AF0", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003074")]
	[Address(RVA = "0x1414DB0", Offset = "0x1414DB0", VA = "0x1414DB0", Slot = "20")]
	protected virtual void CompleteGame()
	{
	}

	[Token(Token = "0x6003075")]
	[Address(RVA = "0x1415F44", Offset = "0x1415F44", VA = "0x1415F44")]
	private List<string> GetModUserLog()
	{
		return null;
	}

	[Token(Token = "0x6003076")]
	[Address(RVA = "0x1414ECC", Offset = "0x1414ECC", VA = "0x1414ECC")]
	protected void RequestCompleteGame(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x6003077")]
	[Address(RVA = "0x1416204", Offset = "0x1416204", VA = "0x1416204")]
	private void TrackTapjoy(MatchType matchType, XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6003078")]
	[Address(RVA = "0x1416590", Offset = "0x1416590", VA = "0x1416590")]
	private void ProcessNewbieConsecutiveLose(XGameModeType gameModeType, CSWinlose gameWinlose, bool isMultiplay)
	{
	}

	[Token(Token = "0x6003079")]
	[Address(RVA = "0x1416690", Offset = "0x1416690", VA = "0x1416690")]
	protected void CreatePlayerCharacterObject()
	{
	}

	[Token(Token = "0x600307A")]
	[Address(RVA = "0x14166DC", Offset = "0x14166DC", VA = "0x14166DC")]
	[DebuggerHidden]
	private IEnumerator LoadPlayerCharacterObject()
	{
		return null;
	}

	[Token(Token = "0x600307B")]
	[Address(RVA = "0x1416788", Offset = "0x1416788", VA = "0x1416788")]
	private void ProcessResultExpression()
	{
	}

	[Token(Token = "0x600307C")]
	[Address(RVA = "0x1416B2C", Offset = "0x1416B2C", VA = "0x1416B2C")]
	private void EndResultExpression()
	{
	}

	[Token(Token = "0x600307D")]
	[Address(RVA = "0x1416E1C", Offset = "0x1416E1C", VA = "0x1416E1C")]
	private void ShowFinalRecord()
	{
	}

	[Token(Token = "0x600307E")]
	[Address(RVA = "0x1416F5C", Offset = "0x1416F5C", VA = "0x1416F5C")]
	public void SetBeforeResultElo(int elo)
	{
	}

	[Token(Token = "0x600307F")]
	[Address(RVA = "0x1417038", Offset = "0x1417038", VA = "0x1417038")]
	private void ShowResultWindow()
	{
	}

	[Token(Token = "0x6003080")]
	[Address(RVA = "0x1417128", Offset = "0x1417128", VA = "0x1417128")]
	private void EndGameResultCharactersDirection()
	{
	}

	[Token(Token = "0x6003081")]
	[Address(RVA = "0x14171FC", Offset = "0x14171FC", VA = "0x14171FC")]
	protected void ProcessRoomSelectorHistory(XGameModeType nGameModeType, CSWinlose winlose, int nRank)
	{
	}

	[Token(Token = "0x6003082")]
	[Address(RVA = "0x141737C", Offset = "0x141737C", VA = "0x141737C")]
	protected void SendTapjoyReport()
	{
	}

	[Token(Token = "0x6003083")]
	[Address(RVA = "0x141755C", Offset = "0x141755C", VA = "0x141755C")]
	public void GameResultDirection(bool isVictory = true)
	{
	}

	[Token(Token = "0x6003084")]
	[Address(RVA = "0x1417D64", Offset = "0x1417D64", VA = "0x1417D64")]
	private void HideNotMe(XModuleEntity entity, XModuleEntity myEntity)
	{
	}

	[Token(Token = "0x6003085")]
	[Address(RVA = "0x1417E94", Offset = "0x1417E94", VA = "0x1417E94", Slot = "13")]
	public override bool OnMessage(IGameModeStateMessage msg)
	{
		return default(bool);
	}
}
