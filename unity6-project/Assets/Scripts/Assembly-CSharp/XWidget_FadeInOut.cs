using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C76")]
public class XWidget_FadeInOut : MonoBehaviour
{
	[Token(Token = "0x2000C77")]
	public enum State
	{
		[Token(Token = "0x4003F3F")]
		None = 0,
		[Token(Token = "0x4003F40")]
		FadeOut = 1,
		[Token(Token = "0x4003F41")]
		FadeIn = 2,
		[Token(Token = "0x4003F42")]
		FadeOutEnd = 3,
		[Token(Token = "0x4003F43")]
		FadeInEnd = 4
	}

	[Token(Token = "0x2000C78")]
	private sealed class _003CStartFadeOut_003Ec__AnonStorey17F
	{
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0x8")]
		internal Action finishAction;

		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0xC")]
		internal bool finishHide;

		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_FadeInOut _003C_003Ef__this;

		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x142C58C", Offset = "0x142C58C", VA = "0x142C58C")]
		public _003CStartFadeOut_003Ec__AnonStorey17F()
		{
		}

		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x142C840", Offset = "0x142C840", VA = "0x142C840")]
		internal void _003C_003Em__25B()
		{
		}
	}

	[Token(Token = "0x2000C79")]
	private sealed class _003CStartFadeInOut_003Ec__AnonStorey180
	{
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0x8")]
		internal Action fadeOutFinishAction;

		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_FadeInOut _003C_003Ef__this;

		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x142C7A0", Offset = "0x142C7A0", VA = "0x142C7A0")]
		public _003CStartFadeInOut_003Ec__AnonStorey180()
		{
		}

		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x142C7FC", Offset = "0x142C7FC", VA = "0x142C7FC")]
		internal void _003C_003Em__25C()
		{
		}
	}

	[Token(Token = "0x4003F37")]
	private const float epsilonF = 0.001f;

	[Token(Token = "0x4003F38")]
	[FieldOffset(Offset = "0xC")]
	public float m_fadeInDuration;

	[Token(Token = "0x4003F39")]
	[FieldOffset(Offset = "0x10")]
	public float m_fadeOutDuration;

	[Token(Token = "0x4003F3A")]
	[FieldOffset(Offset = "0x14")]
	private Action m_fadeInFinish;

	[Token(Token = "0x4003F3B")]
	[FieldOffset(Offset = "0x18")]
	private Action m_fadeOutFinish;

	[Token(Token = "0x4003F3C")]
	[FieldOffset(Offset = "0x1C")]
	private TweenAlpha _fadeAlpha;

	[Token(Token = "0x4003F3D")]
	[FieldOffset(Offset = "0x20")]
	private State FadeState__BackingField;

	[Token(Token = "0x17000CBF")]
	public State FadeState
	{
		[Token(Token = "0x60059EB")]
		[Address(RVA = "0x142C0F0", Offset = "0x142C0F0", VA = "0x142C0F0")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x60059EC")]
		[Address(RVA = "0x142C0F8", Offset = "0x142C0F8", VA = "0x142C0F8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CC0")]
	public TweenAlpha fadeAlpha
	{
		[Token(Token = "0x60059ED")]
		[Address(RVA = "0x142C100", Offset = "0x142C100", VA = "0x142C100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60059E9")]
	[Address(RVA = "0x142C0D0", Offset = "0x142C0D0", VA = "0x142C0D0")]
	public XWidget_FadeInOut()
	{
	}

	[Token(Token = "0x60059EA")]
	[Address(RVA = "0x142C0E4", Offset = "0x142C0E4", VA = "0x142C0E4")]
	public void SetFadeInOutDuration(float fadeInDuration, float fadeOutDuration)
	{
	}

	[Token(Token = "0x60059EE")]
	[Address(RVA = "0x142C1E8", Offset = "0x142C1E8", VA = "0x142C1E8")]
	public void Init()
	{
	}

	[Token(Token = "0x60059EF")]
	[Address(RVA = "0x142C348", Offset = "0x142C348", VA = "0x142C348")]
	private void FadeInOutFinish()
	{
	}

	[Token(Token = "0x60059F0")]
	[Address(RVA = "0x142C3E0", Offset = "0x142C3E0", VA = "0x142C3E0")]
	public void StartFadeOut(bool finishHide, Action finishAction)
	{
	}

	[Token(Token = "0x60059F1")]
	[Address(RVA = "0x142C5CC", Offset = "0x142C5CC", VA = "0x142C5CC")]
	public void StartFadeIn(Action finishAction)
	{
	}

	[Token(Token = "0x60059F2")]
	[Address(RVA = "0x142C6A0", Offset = "0x142C6A0", VA = "0x142C6A0")]
	public void StartFadeInOut(Action fadeOutFinishAction)
	{
	}

	[Token(Token = "0x60059F3")]
	[Address(RVA = "0x142C7A8", Offset = "0x142C7A8", VA = "0x142C7A8")]
	public void Hide()
	{
	}

	[Token(Token = "0x60059F4")]
	[Address(RVA = "0x142C594", Offset = "0x142C594", VA = "0x142C594")]
	private void SetActive(bool bActive)
	{
	}
}
