using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D61")]
public class XPanel_GameResultExpression : MonoBehaviour
{
	[Token(Token = "0x2000D62")]
	private sealed class _003CDelayOneFrame_003Ec__IteratorA0 : IDisposable
	{
		[Token(Token = "0x40044EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XGameModeType gameModeType;

		[Token(Token = "0x40044EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal CSWinlose gameResult;

		[Token(Token = "0x40044F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Action endAction;

		[Token(Token = "0x40044F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40044F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40044F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal XGameModeType _003C_0024_003EgameModeType;

		[Token(Token = "0x40044F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal CSWinlose _003C_0024_003EgameResult;

		[Token(Token = "0x40044F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal Action _003C_0024_003EendAction;

		[Token(Token = "0x40044F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal XPanel_GameResultExpression _003C_003Ef__this;

		[Token(Token = "0x17000D2F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006246")]
			[Address(RVA = "0xFEB990", Offset = "0xFEB990", VA = "0xFEB990", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D30")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006247")]
			[Address(RVA = "0xFEB998", Offset = "0xFEB998", VA = "0xFEB998", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006245")]
		[Address(RVA = "0xFEB95C", Offset = "0xFEB95C", VA = "0xFEB95C")]
		public _003CDelayOneFrame_003Ec__IteratorA0()
		{
		}

		[Token(Token = "0x6006246")]
		[Address(RVA = "0xFEB990", Offset = "0xFEB990", VA = "0xFEB990", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006247")]
		[Address(RVA = "0xFEB998", Offset = "0xFEB998", VA = "0xFEB998", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006248")]
		[Address(RVA = "0xFEB9A0", Offset = "0xFEB9A0", VA = "0xFEB9A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006249")]
		[Address(RVA = "0xFEBAA8", Offset = "0xFEBAA8", VA = "0xFEBAA8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600624A")]
		[Address(RVA = "0xFEBAB4", Offset = "0xFEBAB4", VA = "0xFEBAB4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40044EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XWidget_ResultExpression resultExpression;

	[Token(Token = "0x40044ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Action m_endAction;

	[Token(Token = "0x6006240")]
	[Address(RVA = "0xFEB6F4", Offset = "0xFEB6F4", VA = "0xFEB6F4")]
	public XPanel_GameResultExpression()
	{
	}

	[Token(Token = "0x6006241")]
	[Address(RVA = "0xFEB6FC", Offset = "0xFEB6FC", VA = "0xFEB6FC")]
	public void Init()
	{
	}

	[Token(Token = "0x6006242")]
	[Address(RVA = "0xFEB75C", Offset = "0xFEB75C", VA = "0xFEB75C")]
	public void Show(XGameModeType gameModeType, CSWinlose gameResult, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x6006243")]
	[Address(RVA = "0xFEB894", Offset = "0xFEB894", VA = "0xFEB894")]
	[DebuggerHidden]
	private IEnumerator DelayOneFrame(XGameModeType gameModeType, CSWinlose gameResult, [Optional] Action endAction)
	{
		return null;
	}

	[Token(Token = "0x6006244")]
	[Address(RVA = "0xFEB964", Offset = "0xFEB964", VA = "0xFEB964")]
	public void Hide()
	{
	}
}
