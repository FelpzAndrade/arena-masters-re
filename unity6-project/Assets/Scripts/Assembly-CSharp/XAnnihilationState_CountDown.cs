using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200054B")]
public class XAnnihilationState_CountDown : XPVPGameModeState_CountDown
{
	[Token(Token = "0x200054C")]
	private sealed class _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator51 : IDisposable
	{
		[Token(Token = "0x4001A6F")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001A70")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001A71")]
		[FieldOffset(Offset = "0x10")]
		internal XAnnihilationState_CountDown _003C_003Ef__this;

		[Token(Token = "0x17000704")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D24")]
			[Address(RVA = "0x1EE5D24", Offset = "0x1EE5D24", VA = "0x1EE5D24", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000705")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D25")]
			[Address(RVA = "0x1EE5D2C", Offset = "0x1EE5D2C", VA = "0x1EE5D2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x1EE5810", Offset = "0x1EE5810", VA = "0x1EE5810")]
		public _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator51()
		{
		}

		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x1EE5D24", Offset = "0x1EE5D24", VA = "0x1EE5D24", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x1EE5D2C", Offset = "0x1EE5D2C", VA = "0x1EE5D2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x1EE5D34", Offset = "0x1EE5D34", VA = "0x1EE5D34", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x1EE5EE8", Offset = "0x1EE5EE8", VA = "0x1EE5EE8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D28")]
		[Address(RVA = "0x1EE5EF4", Offset = "0x1EE5EF4", VA = "0x1EE5EF4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200054D")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator52 : IDisposable
	{
		[Token(Token = "0x4001A72")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001A74")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001A75")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001A76")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x17000706")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D2A")]
			[Address(RVA = "0x1EE5AEC", Offset = "0x1EE5AEC", VA = "0x1EE5AEC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000707")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x1EE5AF4", Offset = "0x1EE5AF4", VA = "0x1EE5AF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x1EE5AE4", Offset = "0x1EE5AE4", VA = "0x1EE5AE4")]
		public _003CRepositionMyPlayer_003Ec__Iterator52()
		{
		}

		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x1EE5AEC", Offset = "0x1EE5AEC", VA = "0x1EE5AEC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0x1EE5AF4", Offset = "0x1EE5AF4", VA = "0x1EE5AF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0x1EE5AFC", Offset = "0x1EE5AFC", VA = "0x1EE5AFC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x1EE5C84", Offset = "0x1EE5C84", VA = "0x1EE5C84", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x1EE5C90", Offset = "0x1EE5C90", VA = "0x1EE5C90", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x6002D1C")]
	[Address(RVA = "0x1EE52E0", Offset = "0x1EE52E0", VA = "0x1EE52E0")]
	public XAnnihilationState_CountDown()
	{
	}

	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0x1EE52E8", Offset = "0x1EE52E8", VA = "0x1EE52E8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0x1EE5514", Offset = "0x1EE5514", VA = "0x1EE5514")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeam, bool onReconnect)
	{
	}

	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x1EE5470", Offset = "0x1EE5470", VA = "0x1EE5470")]
	[DebuggerHidden]
	private IEnumerator RespawnMyPlayerOnRoundStart()
	{
		return null;
	}

	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x1EE5818", Offset = "0x1EE5818", VA = "0x1EE5818")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002D21")]
	[Address(RVA = "0x1EE5954", Offset = "0x1EE5954", VA = "0x1EE5954")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x1EE5A20", Offset = "0x1EE5A20", VA = "0x1EE5A20")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}
}
