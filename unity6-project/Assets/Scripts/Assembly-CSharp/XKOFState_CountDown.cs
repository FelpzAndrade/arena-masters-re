using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200057B")]
public class XKOFState_CountDown : XPVPGameModeState_CountDown
{
	[Token(Token = "0x200057C")]
	private sealed class _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator5F : IDisposable
	{
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001B0E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001B0F")]
		[FieldOffset(Offset = "0x10")]
		internal XKOFState_CountDown _003C_003Ef__this;

		[Token(Token = "0x17000733")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002EB0")]
			[Address(RVA = "0x1D3BA08", Offset = "0x1D3BA08", VA = "0x1D3BA08", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000734")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002EB1")]
			[Address(RVA = "0x1D3BA10", Offset = "0x1D3BA10", VA = "0x1D3BA10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x1D3B4F4", Offset = "0x1D3B4F4", VA = "0x1D3B4F4")]
		public _003CRespawnMyPlayerOnRoundStart_003Ec__Iterator5F()
		{
		}

		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0x1D3BA08", Offset = "0x1D3BA08", VA = "0x1D3BA08", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x1D3BA10", Offset = "0x1D3BA10", VA = "0x1D3BA10", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x1D3BA18", Offset = "0x1D3BA18", VA = "0x1D3BA18", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002EB3")]
		[Address(RVA = "0x1D3BBCC", Offset = "0x1D3BBCC", VA = "0x1D3BBCC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002EB4")]
		[Address(RVA = "0x1D3BBD8", Offset = "0x1D3BBD8", VA = "0x1D3BBD8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200057D")]
	private sealed class _003CRepositionMyPlayer_003Ec__Iterator60 : IDisposable
	{
		[Token(Token = "0x4001B10")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x4001B11")]
		[FieldOffset(Offset = "0xC")]
		internal XTeamEnum myTeam;

		[Token(Token = "0x4001B12")]
		[FieldOffset(Offset = "0x10")]
		internal int myIndex;

		[Token(Token = "0x4001B13")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001B14")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001B15")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EdelayTime;

		[Token(Token = "0x4001B16")]
		[FieldOffset(Offset = "0x20")]
		internal XTeamEnum _003C_0024_003EmyTeam;

		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x24")]
		internal int _003C_0024_003EmyIndex;

		[Token(Token = "0x17000735")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002EB6")]
			[Address(RVA = "0x1D3B7D0", Offset = "0x1D3B7D0", VA = "0x1D3B7D0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000736")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002EB7")]
			[Address(RVA = "0x1D3B7D8", Offset = "0x1D3B7D8", VA = "0x1D3B7D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x1D3B7C8", Offset = "0x1D3B7C8", VA = "0x1D3B7C8")]
		public _003CRepositionMyPlayer_003Ec__Iterator60()
		{
		}

		[Token(Token = "0x6002EB6")]
		[Address(RVA = "0x1D3B7D0", Offset = "0x1D3B7D0", VA = "0x1D3B7D0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EB7")]
		[Address(RVA = "0x1D3B7D8", Offset = "0x1D3B7D8", VA = "0x1D3B7D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0x1D3B7E0", Offset = "0x1D3B7E0", VA = "0x1D3B7E0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002EB9")]
		[Address(RVA = "0x1D3B968", Offset = "0x1D3B968", VA = "0x1D3B968", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x1D3B974", Offset = "0x1D3B974", VA = "0x1D3B974", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x1D3ADB8", Offset = "0x1D3ADB8", VA = "0x1D3ADB8")]
	public XKOFState_CountDown()
	{
	}

	[Token(Token = "0x6002EA8")]
	[Address(RVA = "0x1D3ADC0", Offset = "0x1D3ADC0", VA = "0x1D3ADC0", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002EA9")]
	[Address(RVA = "0x1D3B054", Offset = "0x1D3B054", VA = "0x1D3B054", Slot = "19")]
	protected override void InitCoundDown()
	{
	}

	[Token(Token = "0x6002EAA")]
	[Address(RVA = "0x1D3B1F8", Offset = "0x1D3B1F8", VA = "0x1D3B1F8")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeam, bool onReconnect)
	{
	}

	[Token(Token = "0x6002EAB")]
	[Address(RVA = "0x1D3AFB0", Offset = "0x1D3AFB0", VA = "0x1D3AFB0")]
	[DebuggerHidden]
	private IEnumerator RespawnMyPlayerOnRoundStart()
	{
		return null;
	}

	[Token(Token = "0x6002EAC")]
	[Address(RVA = "0x1D3B4FC", Offset = "0x1D3B4FC", VA = "0x1D3B4FC")]
	private void RepositionMyPlayerOnRoundStart()
	{
	}

	[Token(Token = "0x6002EAD")]
	[Address(RVA = "0x1D3B638", Offset = "0x1D3B638", VA = "0x1D3B638")]
	private int GetMyPlayerSpawnIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6002EAE")]
	[Address(RVA = "0x1D3B704", Offset = "0x1D3B704", VA = "0x1D3B704")]
	[DebuggerHidden]
	private IEnumerator RepositionMyPlayer(float delayTime, XTeamEnum myTeam, int myIndex)
	{
		return null;
	}
}
