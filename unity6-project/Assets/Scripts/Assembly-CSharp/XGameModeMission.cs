using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XLevel;

[Token(Token = "0x2000593")]
public class XGameModeMission : XGameModePVE
{
	[Token(Token = "0x4001B52")]
	[FieldOffset(Offset = "0x84")]
	private XGameMode m_subMode;

	[Token(Token = "0x4001B53")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17000758")]
	public XGameMode SubMode
	{
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x13F8FF8", Offset = "0x13F8FF8", VA = "0x13F8FF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000759")]
	public override float StartTime
	{
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x140E518", Offset = "0x140E518", VA = "0x140E518", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700075A")]
	public override int MaxPlayerCount
	{
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x140E570", Offset = "0x140E570", VA = "0x140E570", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700075B")]
	public override XGameModeData GameModeData
	{
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x140E5C8", Offset = "0x140E5C8", VA = "0x140E5C8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700075C")]
	public override XGameModeLocalData GameModeLocalData
	{
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x140E620", Offset = "0x140E620", VA = "0x140E620", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x140E678", Offset = "0x140E678", VA = "0x140E678", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700075D")]
	public override float GameFullTime
	{
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x140F764", Offset = "0x140F764", VA = "0x140F764", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700075E")]
	public override bool IsCleared
	{
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x140FC4C", Offset = "0x140FC4C", VA = "0x140FC4C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x1407408", Offset = "0x1407408", VA = "0x1407408")]
	public XGameModeMission(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x140E6D8", Offset = "0x140E6D8", VA = "0x140E6D8", Slot = "10")]
	public override void SetStateMachine(XGameModeStateMachine stateMachine)
	{
	}

	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x140E338", Offset = "0x140E338", VA = "0x140E338")]
	private XGameMode GetMode()
	{
		return null;
	}

	[Token(Token = "0x6002FAF")]
	[Address(RVA = "0x140E760", Offset = "0x140E760", VA = "0x140E760", Slot = "13")]
	public override void InitPlayerTeam()
	{
	}

	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x140E7B8", Offset = "0x140E7B8", VA = "0x140E7B8", Slot = "14")]
	public override void InitOnGetReady()
	{
	}

	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x140E810", Offset = "0x140E810", VA = "0x140E810", Slot = "48")]
	public override XModuleLevelObject ObjectLoader(LevelObjectData obj)
	{
		return null;
	}

	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x140F068", Offset = "0x140F068", VA = "0x140F068", Slot = "49")]
	protected override void OnObjDie(XModuleLevelObject obj)
	{
	}

	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x140F3D4", Offset = "0x140F3D4", VA = "0x140F3D4", Slot = "12")]
	public override List<Vector3> GetCurrentWayPoints()
	{
		return null;
	}

	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x140F42C", Offset = "0x140F42C", VA = "0x140F42C", Slot = "31")]
	public override bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x140F434", Offset = "0x140F434", VA = "0x140F434", Slot = "22")]
	public override void ResetTime()
	{
	}

	[Token(Token = "0x6002FB6")]
	[Address(RVA = "0x140F494", Offset = "0x140F494", VA = "0x140F494", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FB7")]
	[Address(RVA = "0x140F4EC", Offset = "0x140F4EC", VA = "0x140F4EC", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x140F544", Offset = "0x140F544", VA = "0x140F544", Slot = "43")]
	public override void SetGoalKillCount()
	{
	}

	[Token(Token = "0x6002FBA")]
	[Address(RVA = "0x140F8EC", Offset = "0x140F8EC", VA = "0x140F8EC", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x140F944", Offset = "0x140F944", VA = "0x140F944", Slot = "30")]
	public override void RespawnMyPlayer()
	{
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x140F99C", Offset = "0x140F99C", VA = "0x140F99C", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x140F9FC", Offset = "0x140F9FC", VA = "0x140F9FC", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x140FA54", Offset = "0x140FA54", VA = "0x140FA54", Slot = "45")]
	public override void OnReqCancelInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x140FABC", Offset = "0x140FABC", VA = "0x140FABC", Slot = "44")]
	public override void OnReqInteractionCapturePoint(int nPointObjectIndex, int nReqPhotonID)
	{
	}

	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x140FB24", Offset = "0x140FB24", VA = "0x140FB24", Slot = "46")]
	public override void OnInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x140FB8C", Offset = "0x140FB8C", VA = "0x140FB8C", Slot = "47")]
	public override void OnCancelInteractionCapturePoint(int nPointObjectIndex, int nPhotonID)
	{
	}

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x140FBF4", Offset = "0x140FBF4", VA = "0x140FBF4", Slot = "24")]
	public override void SetClear()
	{
	}

	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x140FCA4", Offset = "0x140FCA4", VA = "0x140FCA4", Slot = "23")]
	public override void SetStartTime(float fStartTime)
	{
	}

	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x140FD0C", Offset = "0x140FD0C", VA = "0x140FD0C", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x140FD74", Offset = "0x140FD74", VA = "0x140FD74", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x140FDDC", Offset = "0x140FDDC", VA = "0x140FDDC", Slot = "16")]
	public override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x140FDE0", Offset = "0x140FDE0", VA = "0x140FDE0", Slot = "15")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x140FDE4", Offset = "0x140FDE4", VA = "0x140FDE4", Slot = "21")]
	public override void OnHit(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x140FE4C", Offset = "0x140FE4C", VA = "0x140FE4C")]
	private static void _003COnObjDie_003Em__12D()
	{
	}
}
