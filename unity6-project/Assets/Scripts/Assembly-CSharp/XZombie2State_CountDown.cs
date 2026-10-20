using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005E6")]
public class XZombie2State_CountDown : XPVPGameModeState_CountDown
{
	[Token(Token = "0x20005E7")]
	private sealed class _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator69 : IDisposable
	{
		[Token(Token = "0x4001C7C")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001C7D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001C7E")]
		[FieldOffset(Offset = "0x10")]
		internal XZombie2State_CountDown _003C_003Ef__this;

		[Token(Token = "0x17000788")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600325C")]
			[Address(RVA = "0x23D6E30", Offset = "0x23D6E30", VA = "0x23D6E30", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000789")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600325D")]
			[Address(RVA = "0x23D6E38", Offset = "0x23D6E38", VA = "0x23D6E38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600325B")]
		[Address(RVA = "0x23D691C", Offset = "0x23D691C", VA = "0x23D691C")]
		public _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator69()
		{
		}

		[Token(Token = "0x600325C")]
		[Address(RVA = "0x23D6E30", Offset = "0x23D6E30", VA = "0x23D6E30", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600325D")]
		[Address(RVA = "0x23D6E38", Offset = "0x23D6E38", VA = "0x23D6E38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600325E")]
		[Address(RVA = "0x23D6E40", Offset = "0x23D6E40", VA = "0x23D6E40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600325F")]
		[Address(RVA = "0x23D6FF4", Offset = "0x23D6FF4", VA = "0x23D6FF4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003260")]
		[Address(RVA = "0x23D7000", Offset = "0x23D7000", VA = "0x23D7000", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20005E8")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator6A : IDisposable
	{
		[Token(Token = "0x4001C7F")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001C80")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001C81")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001C82")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001C86")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x1700078A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003262")]
			[Address(RVA = "0x23D6BF8", Offset = "0x23D6BF8", VA = "0x23D6BF8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700078B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003263")]
			[Address(RVA = "0x23D6C00", Offset = "0x23D6C00", VA = "0x23D6C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003261")]
		[Address(RVA = "0x23D6BF0", Offset = "0x23D6BF0", VA = "0x23D6BF0")]
		public _003CRepositionMyPlayer_003Ec__Iterator6A()
		{
		}

		[Token(Token = "0x6003262")]
		[Address(RVA = "0x23D6BF8", Offset = "0x23D6BF8", VA = "0x23D6BF8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003263")]
		[Address(RVA = "0x23D6C00", Offset = "0x23D6C00", VA = "0x23D6C00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003264")]
		[Address(RVA = "0x23D6C08", Offset = "0x23D6C08", VA = "0x23D6C08", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003265")]
		[Address(RVA = "0x23D6D90", Offset = "0x23D6D90", VA = "0x23D6D90", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003266")]
		[Address(RVA = "0x23D6D9C", Offset = "0x23D6D9C", VA = "0x23D6D9C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x6003254")]
	[Address(RVA = "0x23D63F4", Offset = "0x23D63F4", VA = "0x23D63F4")]
	public XZombie2State_CountDown()
	{
	}

	[Token(Token = "0x6003255")]
	[Address(RVA = "0x23D63FC", Offset = "0x23D63FC", VA = "0x23D63FC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003256")]
	[Address(RVA = "0x23D6620", Offset = "0x23D6620", VA = "0x23D6620")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeam, bool onReconnect)
	{
	}

	[Token(Token = "0x6003257")]
	[Address(RVA = "0x23D657C", Offset = "0x23D657C", VA = "0x23D657C")]
	[DebuggerHidden]
	private IEnumerator RespawnMyPlayerOnRoundStart()
	{
		return null;
	}

	[Token(Token = "0x6003258")]
	[Address(RVA = "0x23D6924", Offset = "0x23D6924", VA = "0x23D6924")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6003259")]
	[Address(RVA = "0x23D6A60", Offset = "0x23D6A60", VA = "0x23D6A60")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600325A")]
	[Address(RVA = "0x23D6B2C", Offset = "0x23D6B2C", VA = "0x23D6B2C")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}
}
