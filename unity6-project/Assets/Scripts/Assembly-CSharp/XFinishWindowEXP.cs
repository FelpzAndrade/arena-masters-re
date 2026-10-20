using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C2D")]
public class XFinishWindowEXP : MonoBehaviour
{
	[Token(Token = "0x2000C2E")]
	private sealed class _003CUIAnimation_003Ec__Iterator95 : IDisposable
	{
		[Token(Token = "0x4003D9A")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cx_003E__0;

		[Token(Token = "0x4003D9B")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cy_003E__1;

		[Token(Token = "0x4003D9C")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4003D9D")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4003D9E")]
		[FieldOffset(Offset = "0x18")]
		internal XFinishWindowEXP _003C_003Ef__this;

		[Token(Token = "0x17000CA9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600581F")]
			[Address(RVA = "0x19B24F8", Offset = "0x19B24F8", VA = "0x19B24F8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000CAA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005820")]
			[Address(RVA = "0x19B2500", Offset = "0x19B2500", VA = "0x19B2500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600581E")]
		[Address(RVA = "0x19B24F0", Offset = "0x19B24F0", VA = "0x19B24F0")]
		public _003CUIAnimation_003Ec__Iterator95()
		{
		}

		[Token(Token = "0x600581F")]
		[Address(RVA = "0x19B24F8", Offset = "0x19B24F8", VA = "0x19B24F8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005820")]
		[Address(RVA = "0x19B2500", Offset = "0x19B2500", VA = "0x19B2500", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005821")]
		[Address(RVA = "0x19B2508", Offset = "0x19B2508", VA = "0x19B2508", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005822")]
		[Address(RVA = "0x19B2FC8", Offset = "0x19B2FC8", VA = "0x19B2FC8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005823")]
		[Address(RVA = "0x19B2FD4", Offset = "0x19B2FD4", VA = "0x19B2FD4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003D90")]
	[FieldOffset(Offset = "0xC")]
	public int nCharIndex;

	[Token(Token = "0x4003D91")]
	[FieldOffset(Offset = "0x10")]
	private XModuleActor character;

	[Token(Token = "0x4003D92")]
	[FieldOffset(Offset = "0x14")]
	private int nLv;

	[Token(Token = "0x4003D93")]
	[FieldOffset(Offset = "0x18")]
	private int nXP;

	[Token(Token = "0x4003D94")]
	[FieldOffset(Offset = "0x1C")]
	private int nRewardXP;

	[Token(Token = "0x4003D95")]
	[FieldOffset(Offset = "0x20")]
	private int nMaxXP;

	[Token(Token = "0x4003D96")]
	[FieldOffset(Offset = "0x24")]
	private float fTime;

	[Token(Token = "0x4003D97")]
	[FieldOffset(Offset = "0x28")]
	private UISprite sprExp;

	[Token(Token = "0x4003D98")]
	[FieldOffset(Offset = "0x2C")]
	private GameObject goLv;

	[Token(Token = "0x4003D99")]
	[FieldOffset(Offset = "0x30")]
	private UILabel lblLv;

	[Token(Token = "0x600581A")]
	[Address(RVA = "0x19B1CAC", Offset = "0x19B1CAC", VA = "0x19B1CAC")]
	public XFinishWindowEXP()
	{
	}

	[Token(Token = "0x600581B")]
	[Address(RVA = "0x19B1CB4", Offset = "0x19B1CB4", VA = "0x19B1CB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600581C")]
	[Address(RVA = "0x19B20E8", Offset = "0x19B20E8", VA = "0x19B20E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600581D")]
	[Address(RVA = "0x19B244C", Offset = "0x19B244C", VA = "0x19B244C")]
	[DebuggerHidden]
	private IEnumerator UIAnimation()
	{
		return null;
	}
}
