using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x200060B")]
public class XGameFlow_Title : XGameFlow
{
	[Token(Token = "0x200060C")]
	private sealed class _003COnEnd_003Ec__Iterator73 : IDisposable
	{
		[Token(Token = "0x4001CEF")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001CF0")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x170007A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600340D")]
			[Address(RVA = "0x13E95A0", Offset = "0x13E95A0", VA = "0x13E95A0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600340E")]
			[Address(RVA = "0x13E95A8", Offset = "0x13E95A8", VA = "0x13E95A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600340C")]
		[Address(RVA = "0x13E931C", Offset = "0x13E931C", VA = "0x13E931C")]
		public _003COnEnd_003Ec__Iterator73()
		{
		}

		[Token(Token = "0x600340D")]
		[Address(RVA = "0x13E95A0", Offset = "0x13E95A0", VA = "0x13E95A0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600340E")]
		[Address(RVA = "0x13E95A8", Offset = "0x13E95A8", VA = "0x13E95A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600340F")]
		[Address(RVA = "0x13E95B0", Offset = "0x13E95B0", VA = "0x13E95B0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003410")]
		[Address(RVA = "0x13E98F0", Offset = "0x13E98F0", VA = "0x13E98F0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003411")]
		[Address(RVA = "0x13E98FC", Offset = "0x13E98FC", VA = "0x13E98FC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x0")]
	public static bool seeSplash;

	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x8")]
	private bool m_clearComplete;

	[Token(Token = "0x6003402")]
	[Address(RVA = "0x13E87C4", Offset = "0x13E87C4", VA = "0x13E87C4")]
	public XGameFlow_Title()
	{
	}

	[Token(Token = "0x6003404")]
	[Address(RVA = "0x13E87D0", Offset = "0x13E87D0", VA = "0x13E87D0", Slot = "4")]
	public override GameFlowTypes GetFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x6003405")]
	[Address(RVA = "0x13E87D8", Offset = "0x13E87D8", VA = "0x13E87D8", Slot = "11")]
	public override void blockUpdate()
	{
	}

	[Token(Token = "0x6003406")]
	[Address(RVA = "0x13E87E4", Offset = "0x13E87E4", VA = "0x13E87E4", Slot = "5")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6003407")]
	[Address(RVA = "0x13E8CE0", Offset = "0x13E8CE0", VA = "0x13E8CE0")]
	private void InitSDK()
	{
	}

	[Token(Token = "0x6003408")]
	[Address(RVA = "0x13E8E60", Offset = "0x13E8E60", VA = "0x13E8E60")]
	private void OnTitleLoad()
	{
	}

	[Token(Token = "0x6003409")]
	[Address(RVA = "0x13E9290", Offset = "0x13E9290", VA = "0x13E9290", Slot = "6")]
	[DebuggerHidden]
	public override IEnumerator OnEnd()
	{
		return null;
	}

	[Token(Token = "0x600340A")]
	[Address(RVA = "0x13E9324", Offset = "0x13E9324", VA = "0x13E9324", Slot = "7")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600340B")]
	[Address(RVA = "0x13E94E8", Offset = "0x13E94E8", VA = "0x13E94E8")]
	private void _003COnStart_003Em__165()
	{
	}
}
