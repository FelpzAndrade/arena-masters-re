using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200104E")]
public class XPanel_Splash : MonoBehaviour
{
	[Token(Token = "0x200104F")]
	private sealed class _003CSplashLogo_003Ec__IteratorB3 : IDisposable
	{
		[Token(Token = "0x40057ED")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x40057EE")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40057EF")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Splash _003C_003Ef__this;

		[Token(Token = "0x17000F0C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60079AD")]
			[Address(RVA = "0xACDAFC", Offset = "0xACDAFC", VA = "0xACDAFC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000F0D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60079AE")]
			[Address(RVA = "0xACDB04", Offset = "0xACDB04", VA = "0xACDB04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60079AC")]
		[Address(RVA = "0xACDAC0", Offset = "0xACDAC0", VA = "0xACDAC0")]
		public _003CSplashLogo_003Ec__IteratorB3()
		{
		}

		[Token(Token = "0x60079AD")]
		[Address(RVA = "0xACDAFC", Offset = "0xACDAFC", VA = "0xACDAFC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60079AE")]
		[Address(RVA = "0xACDB04", Offset = "0xACDB04", VA = "0xACDB04", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60079AF")]
		[Address(RVA = "0xACDB0C", Offset = "0xACDB0C", VA = "0xACDB0C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60079B0")]
		[Address(RVA = "0xACDE58", Offset = "0xACDE58", VA = "0xACDE58", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60079B1")]
		[Address(RVA = "0xACDE64", Offset = "0xACDE64", VA = "0xACDE64", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x60079B2")]
		[Address(RVA = "0xACDEF8", Offset = "0xACDEF8", VA = "0xACDEF8")]
		internal void _003C_003Em__514()
		{
		}
	}

	[Token(Token = "0x40057E6")]
	[FieldOffset(Offset = "0xC")]
	public UISprite sprBackGround;

	[Token(Token = "0x40057E7")]
	[FieldOffset(Offset = "0x10")]
	public TweenAlpha logoTweenAlpha;

	[Token(Token = "0x40057E8")]
	[FieldOffset(Offset = "0x14")]
	public float m_fadeInDuration;

	[Token(Token = "0x40057E9")]
	[FieldOffset(Offset = "0x18")]
	public float m_logoWaitTime;

	[Token(Token = "0x40057EA")]
	[FieldOffset(Offset = "0x1C")]
	public float m_fadeOutDuration;

	[Token(Token = "0x40057EB")]
	[FieldOffset(Offset = "0x20")]
	public float m_bgWaitTime;

	[Token(Token = "0x40057EC")]
	[FieldOffset(Offset = "0x24")]
	private List<EventDelegate> titleInitEvent;

	[Token(Token = "0x60079A6")]
	[Address(RVA = "0xACD7C0", Offset = "0xACD7C0", VA = "0xACD7C0")]
	public XPanel_Splash()
	{
	}

	[Token(Token = "0x60079A7")]
	[Address(RVA = "0xACD890", Offset = "0xACD890", VA = "0xACD890")]
	public void Init()
	{
	}

	[Token(Token = "0x60079A8")]
	[Address(RVA = "0xACD944", Offset = "0xACD944", VA = "0xACD944")]
	public void Show(EventDelegate titleInit)
	{
	}

	[Token(Token = "0x60079A9")]
	[Address(RVA = "0xACDA1C", Offset = "0xACDA1C", VA = "0xACDA1C")]
	[DebuggerHidden]
	private IEnumerator SplashLogo()
	{
		return null;
	}

	[Token(Token = "0x60079AA")]
	[Address(RVA = "0xACD908", Offset = "0xACD908", VA = "0xACD908")]
	private void SetBackGroundColor(Color color)
	{
	}

	[Token(Token = "0x60079AB")]
	[Address(RVA = "0xACDAC8", Offset = "0xACDAC8", VA = "0xACDAC8")]
	public void Hide()
	{
	}
}
