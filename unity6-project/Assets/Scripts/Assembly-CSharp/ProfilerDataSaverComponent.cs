using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000352")]
public class ProfilerDataSaverComponent : MonoBehaviour
{
	[Token(Token = "0x2000353")]
	private sealed class _003CSaveProfilerData_003Ec__Iterator2B : IDisposable
	{
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CfolderPath_003E__0;

		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0xC")]
		internal string _003Cfilepath_003E__1;

		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x10")]
		internal int _003Ci_003E__2;

		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x1C")]
		internal ProfilerDataSaverComponent _003C_003Ef__this;

		[Token(Token = "0x170004B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6001BEC")]
			[Address(RVA = "0x20E4980", Offset = "0x20E4980", VA = "0x20E4980", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001BED")]
			[Address(RVA = "0x20E4988", Offset = "0x20E4988", VA = "0x20E4988", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x20E4978", Offset = "0x20E4978", VA = "0x20E4978")]
		public _003CSaveProfilerData_003Ec__Iterator2B()
		{
		}

		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x20E4980", Offset = "0x20E4980", VA = "0x20E4980", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x20E4988", Offset = "0x20E4988", VA = "0x20E4988", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x20E4990", Offset = "0x20E4990", VA = "0x20E4990", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x20E4BEC", Offset = "0x20E4BEC", VA = "0x20E4BEC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x20E4BF8", Offset = "0x20E4BF8", VA = "0x20E4BF8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0xC")]
	private string folder;

	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x10")]
	private int _count;

	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x20E4668", Offset = "0x20E4668", VA = "0x20E4668")]
	public ProfilerDataSaverComponent()
	{
	}

	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x20E4670", Offset = "0x20E4670", VA = "0x20E4670")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x20E47AC", Offset = "0x20E47AC", VA = "0x20E47AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x20E48D4", Offset = "0x20E48D4", VA = "0x20E48D4")]
	[DebuggerHidden]
	private IEnumerator SaveProfilerData()
	{
		return null;
	}
}
