using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200055A")]
public class XClassicState_CountDown : XPVPGameModeState_CountDown
{
	[Token(Token = "0x200055B")]
	private sealed class _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator57 : IDisposable
	{
		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x10")]
		internal XClassicState_CountDown _003C_003Ef__this;

		[Token(Token = "0x17000715")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002DB0")]
			[Address(RVA = "0x1986D2C", Offset = "0x1986D2C", VA = "0x1986D2C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000716")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DB1")]
			[Address(RVA = "0x1986D34", Offset = "0x1986D34", VA = "0x1986D34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x1986818", Offset = "0x1986818", VA = "0x1986818")]
		public _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator57()
		{
		}

		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x1986D2C", Offset = "0x1986D2C", VA = "0x1986D2C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x1986D34", Offset = "0x1986D34", VA = "0x1986D34", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x1986D3C", Offset = "0x1986D3C", VA = "0x1986D3C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x1986EF0", Offset = "0x1986EF0", VA = "0x1986EF0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0x1986EFC", Offset = "0x1986EFC", VA = "0x1986EFC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200055C")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator58 : IDisposable
	{
		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x17000717")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002DB6")]
			[Address(RVA = "0x1986AF4", Offset = "0x1986AF4", VA = "0x1986AF4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000718")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DB7")]
			[Address(RVA = "0x1986AFC", Offset = "0x1986AFC", VA = "0x1986AFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x1986AEC", Offset = "0x1986AEC", VA = "0x1986AEC")]
		public _003CRepositionMyPlayer_003Ec__Iterator58()
		{
		}

		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x1986AF4", Offset = "0x1986AF4", VA = "0x1986AF4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x1986AFC", Offset = "0x1986AFC", VA = "0x1986AFC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x1986B04", Offset = "0x1986B04", VA = "0x1986B04", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x1986C8C", Offset = "0x1986C8C", VA = "0x1986C8C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x1986C98", Offset = "0x1986C98", VA = "0x1986C98", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x19862E8", Offset = "0x19862E8", VA = "0x19862E8")]
	public XClassicState_CountDown()
	{
	}

	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x19862F0", Offset = "0x19862F0", VA = "0x19862F0", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x198651C", Offset = "0x198651C", VA = "0x198651C")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeam, bool onReconnect)
	{
	}

	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x1986478", Offset = "0x1986478", VA = "0x1986478")]
	[DebuggerHidden]
	private IEnumerator RespawnMyPlayerOnRoundStart()
	{
		return null;
	}

	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x1986820", Offset = "0x1986820", VA = "0x1986820")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x198695C", Offset = "0x198695C", VA = "0x198695C")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x1986A28", Offset = "0x1986A28", VA = "0x1986A28")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}
}
