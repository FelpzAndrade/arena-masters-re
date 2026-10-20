using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000508")]
public class XCapturePointARule
{
	[Token(Token = "0x2000509")]
	private sealed class _003COnReqInteractionCapturePoint_003Ec__AnonStorey11A
	{
		[Token(Token = "0x40019A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int nReqPhotonID;

		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x1AA61D8", Offset = "0x1AA61D8", VA = "0x1AA61D8")]
		public _003COnReqInteractionCapturePoint_003Ec__AnonStorey11A()
		{
		}

		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x1AA7154", Offset = "0x1AA7154", VA = "0x1AA7154")]
		internal bool _003C_003Em__110(int element)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400199B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private XCapturePointATimer m_ATeamTimer;

	[Token(Token = "0x400199C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private XCapturePointATimer m_BTeamTimer;

	[Token(Token = "0x400199D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private XCapturePointATimer m_RestTimer;

	[Token(Token = "0x400199E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int m_ATeamScore;

	[Token(Token = "0x400199F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_BTeamScore;

	[Token(Token = "0x40019A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private GameModeInfo m_GameModeInfo;

	[Token(Token = "0x40019A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XCapturePointAState_Play m_PlayState;

	[Token(Token = "0x40019A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XGameModeData_CapturePointA m_GameModeData;

	[Token(Token = "0x40019A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<int> m_InteractingPlayers;

	[Token(Token = "0x40019A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int m_LastGameModeDataChecksum;

	[Token(Token = "0x40019A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fDataSyncElapsedTime;

	[Token(Token = "0x40019A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isBeforeTenSecond;

	[Token(Token = "0x40019A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XCapturePointInteractionDistanceChecker m_InteractionDistanceChecker;

	[Token(Token = "0x40019A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int m_lastSend;

	[Token(Token = "0x6002B5B")]
	[Address(RVA = "0x1AA4890", Offset = "0x1AA4890", VA = "0x1AA4890")]
	public XCapturePointARule()
	{
	}

	[Token(Token = "0x6002B5C")]
	[Address(RVA = "0x1AA49C4", Offset = "0x1AA49C4", VA = "0x1AA49C4")]
	public void SetGoalTime(float flagDestroyTime, float restTime)
	{
	}

	[Token(Token = "0x6002B5D")]
	[Address(RVA = "0x1AA4A1C", Offset = "0x1AA4A1C", VA = "0x1AA4A1C")]
	public void Enter(GameModeInfo gameModeInfo, XCapturePointAState_Play playState, XGameModeData_CapturePointA gameModeData)
	{
	}

	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x1AA4B78", Offset = "0x1AA4B78", VA = "0x1AA4B78")]
	public void OnMasterClientSwitched(GameModeInfo gameModeInfo, XCapturePointAState_Play playState, XGameModeData_CapturePointA gameModeData)
	{
	}

	[Token(Token = "0x6002B5F")]
	[Address(RVA = "0x1AA4C00", Offset = "0x1AA4C00", VA = "0x1AA4C00")]
	public void Update(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B60")]
	[Address(RVA = "0x1AA4C68", Offset = "0x1AA4C68", VA = "0x1AA4C68")]
	private void UpdateTeamTimer(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B61")]
	[Address(RVA = "0x1AA4D7C", Offset = "0x1AA4D7C", VA = "0x1AA4D7C")]
	private void UpdateFlag(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B62")]
	[Address(RVA = "0x1AA59A0", Offset = "0x1AA59A0", VA = "0x1AA59A0", Slot = "4")]
	protected virtual void UpdateCheckInteractionDistance(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x1AA5030", Offset = "0x1AA5030", VA = "0x1AA5030")]
	private void UpdateInteraction(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x1AA5484", Offset = "0x1AA5484", VA = "0x1AA5484")]
	private void UpdateSyncGameModeData(float fDeltaTime)
	{
	}

	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x1AA5808", Offset = "0x1AA5808", VA = "0x1AA5808")]
	private void GetMsgAndSendWhiteMsg(string msgKey, int round, float duration = 5f)
	{
	}

	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x1AA5578", Offset = "0x1AA5578", VA = "0x1AA5578")]
	private void ChangeCapturePointTeam(XTeamEnum nTeam)
	{
	}

	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x1AA5EB4", Offset = "0x1AA5EB4", VA = "0x1AA5EB4")]
	private bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x1AA601C", Offset = "0x1AA601C", VA = "0x1AA601C")]
	public void OnReqInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x1AA61E0", Offset = "0x1AA61E0", VA = "0x1AA61E0")]
	public void OnReqCancelInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x1AA62C0", Offset = "0x1AA62C0", VA = "0x1AA62C0", Slot = "5")]
	public virtual void SendInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x1AA649C", Offset = "0x1AA649C", VA = "0x1AA649C", Slot = "6")]
	public virtual void SendCancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x1AA6678", Offset = "0x1AA6678", VA = "0x1AA6678", Slot = "7")]
	public virtual void SendSyncGameModeData([Optional] PhotonPlayer photonPlayer)
	{
	}
}
