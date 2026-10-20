using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000609")]
public abstract class XGameFlow
{
	[Token(Token = "0x200060A")]
	private sealed class _003COnEnd_003Ec__Iterator72 : IDisposable
	{
		[Token(Token = "0x4001CEB")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001CEC")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x170007A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60033FD")]
			[Address(RVA = "0x13DFB68", Offset = "0x13DFB68", VA = "0x13DFB68", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033FE")]
			[Address(RVA = "0x13DFB70", Offset = "0x13DFB70", VA = "0x13DFB70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x13DFB48", Offset = "0x13DFB48", VA = "0x13DFB48")]
		public _003COnEnd_003Ec__Iterator72()
		{
		}

		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x13DFB68", Offset = "0x13DFB68", VA = "0x13DFB68", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x13DFB70", Offset = "0x13DFB70", VA = "0x13DFB70", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x13DFB78", Offset = "0x13DFB78", VA = "0x13DFB78", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003400")]
		[Address(RVA = "0x13DFB88", Offset = "0x13DFB88", VA = "0x13DFB88", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003401")]
		[Address(RVA = "0x13DFB94", Offset = "0x13DFB94", VA = "0x13DFB94", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x60033F3")]
	[Address(RVA = "0x13DFAB0", Offset = "0x13DFAB0", VA = "0x13DFAB0")]
	protected XGameFlow()
	{
	}

	[Token(Token = "0x60033F4")]
	public abstract GameFlowTypes GetFlowType();

	[Token(Token = "0x60033F5")]
	[Address(RVA = "0x13DFAB8", Offset = "0x13DFAB8", VA = "0x13DFAB8", Slot = "5")]
	public virtual void OnStart()
	{
	}

	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x13DFABC", Offset = "0x13DFABC", VA = "0x13DFABC", Slot = "6")]
	[DebuggerHidden]
	public virtual IEnumerator OnEnd()
	{
		return null;
	}

	[Token(Token = "0x60033F7")]
	[Address(RVA = "0x13DFB50", Offset = "0x13DFB50", VA = "0x13DFB50", Slot = "7")]
	public virtual void OnUpdate()
	{
	}

	[Token(Token = "0x60033F8")]
	[Address(RVA = "0x13DFB54", Offset = "0x13DFB54", VA = "0x13DFB54", Slot = "8")]
	public virtual void OnFixedUpdate()
	{
	}

	[Token(Token = "0x60033F9")]
	[Address(RVA = "0x13DFB58", Offset = "0x13DFB58", VA = "0x13DFB58", Slot = "9")]
	public virtual void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60033FA")]
	[Address(RVA = "0x13DFB5C", Offset = "0x13DFB5C", VA = "0x13DFB5C", Slot = "10")]
	public virtual bool IsLoadedComplete()
	{
		return default(bool);
	}

	[Token(Token = "0x60033FB")]
	[Address(RVA = "0x13DFB64", Offset = "0x13DFB64", VA = "0x13DFB64", Slot = "11")]
	public virtual void blockUpdate()
	{
	}
}
