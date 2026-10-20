using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000E38")]
public class XPanel_WaitingMatch : XCommonBackUI
{
	[Token(Token = "0x2000E39")]
	private sealed class _003CRefreshTime_003Ec__IteratorA8 : IDisposable
	{
		[Token(Token = "0x4004AFC")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4004AFD")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4004AFE")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_WaitingMatch _003C_003Ef__this;

		[Token(Token = "0x17000DA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60069DF")]
			[Address(RVA = "0xADA664", Offset = "0xADA664", VA = "0xADA664", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000DA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60069E0")]
			[Address(RVA = "0xADA66C", Offset = "0xADA66C", VA = "0xADA66C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60069DE")]
		[Address(RVA = "0xADA3F4", Offset = "0xADA3F4", VA = "0xADA3F4")]
		public _003CRefreshTime_003Ec__IteratorA8()
		{
		}

		[Token(Token = "0x60069DF")]
		[Address(RVA = "0xADA664", Offset = "0xADA664", VA = "0xADA664", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60069E0")]
		[Address(RVA = "0xADA66C", Offset = "0xADA66C", VA = "0xADA66C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60069E1")]
		[Address(RVA = "0xADA674", Offset = "0xADA674", VA = "0xADA674", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60069E2")]
		[Address(RVA = "0xADA830", Offset = "0xADA830", VA = "0xADA830", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60069E3")]
		[Address(RVA = "0xADA83C", Offset = "0xADA83C", VA = "0xADA83C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004AF8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblElapsed;

	[Token(Token = "0x4004AF9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTitle;

	[Token(Token = "0x4004AFA")]
	[FieldOffset(Offset = "0x20")]
	private Stopwatch m_stopWatch;

	[Token(Token = "0x4004AFB")]
	[FieldOffset(Offset = "0x24")]
	private Action m_onCancel;

	[Token(Token = "0x60069D4")]
	[Address(RVA = "0xADA0A0", Offset = "0xADA0A0", VA = "0xADA0A0")]
	public XPanel_WaitingMatch()
	{
	}

	[Token(Token = "0x60069D5")]
	[Address(RVA = "0xADA13C", Offset = "0xADA13C", VA = "0xADA13C")]
	public void Show(string title, int avgWaitTime, Action onCancel)
	{
	}

	[Token(Token = "0x60069D6")]
	[Address(RVA = "0xADA2C8", Offset = "0xADA2C8", VA = "0xADA2C8")]
	private string ToMinSecString(int sec)
	{
		return null;
	}

	[Token(Token = "0x60069D7")]
	[Address(RVA = "0xADA224", Offset = "0xADA224", VA = "0xADA224")]
	[DebuggerHidden]
	private IEnumerator RefreshTime()
	{
		return null;
	}

	[Token(Token = "0x60069D8")]
	[Address(RVA = "0xADA1E0", Offset = "0xADA1E0", VA = "0xADA1E0")]
	private void Reset()
	{
	}

	[Token(Token = "0x60069D9")]
	[Address(RVA = "0xADA3FC", Offset = "0xADA3FC", VA = "0xADA3FC", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60069DA")]
	[Address(RVA = "0xADA43C", Offset = "0xADA43C", VA = "0xADA43C")]
	public void PrivateHide()
	{
	}

	[Token(Token = "0x60069DB")]
	[Address(RVA = "0xADA45C", Offset = "0xADA45C", VA = "0xADA45C")]
	public void TimeOutCancel()
	{
	}

	[Token(Token = "0x60069DC")]
	[Address(RVA = "0xADA400", Offset = "0xADA400", VA = "0xADA400")]
	public void OnClickCancle()
	{
	}

	[Token(Token = "0x60069DD")]
	[Address(RVA = "0xADA620", Offset = "0xADA620", VA = "0xADA620")]
	public int GetMatchWaitTime()
	{
		return default(int);
	}
}
