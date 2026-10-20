using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200051C")]
public class XGameModeHideAndSeek : XGameModePVP
{
	[Token(Token = "0x200051D")]
	private sealed class _003CShowSetTaggerMessageCoroutine_003Ec__Iterator4C : IDisposable
	{
		[Token(Token = "0x40019DF")]
		[FieldOffset(Offset = "0x8")]
		internal int nTargetPhotonID;

		[Token(Token = "0x40019E0")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40019E1")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40019E2")]
		[FieldOffset(Offset = "0x14")]
		internal int _003C_0024_003EnTargetPhotonID;

		[Token(Token = "0x40019E3")]
		[FieldOffset(Offset = "0x18")]
		internal XGameModeHideAndSeek _003C_003Ef__this;

		[Token(Token = "0x170006D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002BF0")]
			[Address(RVA = "0x140A758", Offset = "0x140A758", VA = "0x140A758", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BF1")]
			[Address(RVA = "0x140A760", Offset = "0x140A760", VA = "0x140A760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x1408584", Offset = "0x1408584", VA = "0x1408584")]
		public _003CShowSetTaggerMessageCoroutine_003Ec__Iterator4C()
		{
		}

		[Token(Token = "0x6002BF0")]
		[Address(RVA = "0x140A758", Offset = "0x140A758", VA = "0x140A758", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BF1")]
		[Address(RVA = "0x140A760", Offset = "0x140A760", VA = "0x140A760", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x140A768", Offset = "0x140A768", VA = "0x140A768", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x140A868", Offset = "0x140A868", VA = "0x140A868", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x140A874", Offset = "0x140A874", VA = "0x140A874", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200051E")]
	private sealed class _003CRespawn_003Ec__Iterator4D : IDisposable
	{
		[Token(Token = "0x40019E4")]
		[FieldOffset(Offset = "0x8")]
		internal XModuleEntity me;

		[Token(Token = "0x40019E5")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40019E6")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40019E7")]
		[FieldOffset(Offset = "0x14")]
		internal XModuleEntity _003C_0024_003Eme;

		[Token(Token = "0x40019E8")]
		[FieldOffset(Offset = "0x18")]
		internal XGameModeHideAndSeek _003C_003Ef__this;

		[Token(Token = "0x170006D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002BF6")]
			[Address(RVA = "0x140A4B4", Offset = "0x140A4B4", VA = "0x140A4B4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BF7")]
			[Address(RVA = "0x140A4BC", Offset = "0x140A4BC", VA = "0x140A4BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x1408FEC", Offset = "0x1408FEC", VA = "0x1408FEC")]
		public _003CRespawn_003Ec__Iterator4D()
		{
		}

		[Token(Token = "0x6002BF6")]
		[Address(RVA = "0x140A4B4", Offset = "0x140A4B4", VA = "0x140A4B4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x140A4BC", Offset = "0x140A4BC", VA = "0x140A4BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x140A4C4", Offset = "0x140A4C4", VA = "0x140A4C4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x140A6B8", Offset = "0x140A6B8", VA = "0x140A6B8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x140A6C4", Offset = "0x140A6C4", VA = "0x140A6C4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200051F")]
	private sealed class _003CChangeTeamSpectatorMode_003Ec__Iterator4E : IDisposable
	{
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x8")]
		internal XHideAndSeekState_Play _003CstatePlay_003E__0;

		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeHideAndSeek _003C_003Ef__this;

		[Token(Token = "0x170006DA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002BFC")]
			[Address(RVA = "0x140A1C4", Offset = "0x140A1C4", VA = "0x140A1C4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006DB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BFD")]
			[Address(RVA = "0x140A1CC", Offset = "0x140A1CC", VA = "0x140A1CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x1409248", Offset = "0x1409248", VA = "0x1409248")]
		public _003CChangeTeamSpectatorMode_003Ec__Iterator4E()
		{
		}

		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x140A1C4", Offset = "0x140A1C4", VA = "0x140A1C4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x140A1CC", Offset = "0x140A1CC", VA = "0x140A1CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x140A1D4", Offset = "0x140A1D4", VA = "0x140A1D4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x140A414", Offset = "0x140A414", VA = "0x140A414", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x140A420", Offset = "0x140A420", VA = "0x140A420", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40019D9")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x7C")]
	protected bool m_beTagger;

	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x80")]
	private string selectTaggerSoundKey;

	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0x84")]
	private bool m_isFirstMessage;

	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x85")]
	private bool m_isRejoinPlayer;

	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine _respawn;

	[Token(Token = "0x170006D5")]
	public bool IsRejoin
	{
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x1407500", Offset = "0x1407500", VA = "0x1407500")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x1407460", Offset = "0x1407460", VA = "0x1407460")]
	public XGameModeHideAndSeek(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002BD3")]
	[Address(RVA = "0x1407508", Offset = "0x1407508", VA = "0x1407508", Slot = "11")]
	public override void OnGameInit()
	{
	}

	[Token(Token = "0x6002BD4")]
	[Address(RVA = "0x14076AC", Offset = "0x14076AC", VA = "0x14076AC", Slot = "27")]
	protected override void OnRejoinPlayer(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6002BD5")]
	[Address(RVA = "0x1407838", Offset = "0x1407838", VA = "0x1407838", Slot = "28")]
	protected override void OnWelcomeAgain()
	{
	}

	[Token(Token = "0x6002BD6")]
	[Address(RVA = "0x1407AA8", Offset = "0x1407AA8", VA = "0x1407AA8")]
	public void SetTagger(int nTargetPhotonID, int itemID)
	{
	}

	[Token(Token = "0x6002BD7")]
	[Address(RVA = "0x14084C0", Offset = "0x14084C0", VA = "0x14084C0")]
	public void ActiveTaggerTimerByMasterClient()
	{
	}

	[Token(Token = "0x6002BD8")]
	[Address(RVA = "0x1408410", Offset = "0x1408410", VA = "0x1408410")]
	[DebuggerHidden]
	private IEnumerator ShowSetTaggerMessageCoroutine(int nTargetPhotonID)
	{
		return null;
	}

	[Token(Token = "0x6002BD9")]
	[Address(RVA = "0x1408164", Offset = "0x1408164", VA = "0x1408164")]
	private void ShowSetTaggerMessage(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x6002BDA")]
	[Address(RVA = "0x140858C", Offset = "0x140858C", VA = "0x140858C", Slot = "14")]
	public override void InitOnGetReady()
	{
	}

	[Token(Token = "0x6002BDB")]
	[Address(RVA = "0x14085A0", Offset = "0x14085A0", VA = "0x14085A0", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x1408738", Offset = "0x1408738", VA = "0x1408738", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002BDD")]
	[Address(RVA = "0x14089A4", Offset = "0x14089A4", VA = "0x14089A4", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x1408DE0", Offset = "0x1408DE0", VA = "0x1408DE0", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x1408EB8", Offset = "0x1408EB8", VA = "0x1408EB8", Slot = "48")]
	protected override void SendKillAndDieEvent(string strAttackerName)
	{
	}

	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x14079F8", Offset = "0x14079F8", VA = "0x14079F8")]
	[DebuggerHidden]
	private IEnumerator Respawn(XModuleEntity me)
	{
		return null;
	}

	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x1408FF4", Offset = "0x1408FF4", VA = "0x1408FF4")]
	private int GetRespawnTime()
	{
		return default(int);
	}

	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x1409130", Offset = "0x1409130", VA = "0x1409130")]
	private void RespawnState()
	{
	}

	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x1408B68", Offset = "0x1408B68", VA = "0x1408B68")]
	private void RouletteGhost()
	{
	}

	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x1408D3C", Offset = "0x1408D3C", VA = "0x1408D3C")]
	[DebuggerHidden]
	private IEnumerator ChangeTeamSpectatorMode()
	{
		return null;
	}

	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x1407DE4", Offset = "0x1407DE4", VA = "0x1407DE4")]
	private void SetMyPlayerState(CSPlayerState state, bool onReconnect, int itemID)
	{
	}

	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x1409250", Offset = "0x1409250", VA = "0x1409250")]
	public void AddTaggerBuffToMyPlayer(bool onReconnect)
	{
	}

	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x1409498", Offset = "0x1409498", VA = "0x1409498")]
	public void LostTaggerBuffToMyPlayer()
	{
	}

	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x1409684", Offset = "0x1409684", VA = "0x1409684")]
	public void TaggerChooseToMasterClient(int ignoreChoosePhotonID = -1, int itemID = 0, bool isDieEvent = false)
	{
	}

	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x140976C", Offset = "0x140976C", VA = "0x140976C", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAid)
	{
	}

	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x1409B08", Offset = "0x1409B08", VA = "0x1409B08")]
	private void CheckEscapePlayerKill()
	{
	}

	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x1409DE0", Offset = "0x1409DE0", VA = "0x1409DE0", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x1409EC0", Offset = "0x1409EC0", VA = "0x1409EC0", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x1409F10", Offset = "0x1409F10", VA = "0x1409F10", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x1409F48", Offset = "0x1409F48", VA = "0x1409F48", Slot = "29")]
	public override void OnGameExit()
	{
	}
}
