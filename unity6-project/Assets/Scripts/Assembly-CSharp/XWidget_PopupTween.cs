using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C8E")]
public class XWidget_PopupTween : XUIBaseWidget
{
	[Token(Token = "0x2000C8F")]
	private sealed class _003CAppear_003Ec__AnonStorey185
	{
		[Token(Token = "0x4003FE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action apeearEndCallback;

		[Token(Token = "0x4003FEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_PopupTween _003C_003Ef__this;

		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x131DBEC", Offset = "0x131DBEC", VA = "0x131DBEC")]
		public _003CAppear_003Ec__AnonStorey185()
		{
		}

		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x131E250", Offset = "0x131E250", VA = "0x131E250")]
		internal void _003C_003Em__263()
		{
		}

		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x131E278", Offset = "0x131E278", VA = "0x131E278")]
		internal void _003C_003Em__264()
		{
		}
	}

	[Token(Token = "0x2000C90")]
	private sealed class _003CBuildButton_003Ec__AnonStorey186
	{
		[Token(Token = "0x4003FEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action onClick;

		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0x131E06C", Offset = "0x131E06C", VA = "0x131E06C")]
		public _003CBuildButton_003Ec__AnonStorey186()
		{
		}

		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x131E2A4", Offset = "0x131E2A4", VA = "0x131E2A4")]
		internal void _003C_003Em__265()
		{
		}
	}

	[Token(Token = "0x4003FE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected Vector3 m_initPos;

	[Token(Token = "0x4003FE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected TweenScale m_tweenScale;

	[Token(Token = "0x4003FE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isAppearing;

	[Token(Token = "0x4003FE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	private bool isVanishing;

	[Token(Token = "0x6005AAE")]
	[Address(RVA = "0x13071BC", Offset = "0x13071BC", VA = "0x13071BC")]
	public XWidget_PopupTween()
	{
	}

	[Token(Token = "0x6005AAF")]
	[Address(RVA = "0x131DBBC", Offset = "0x131DBBC", VA = "0x131DBBC")]
	public bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005AB0")]
	[Address(RVA = "0x1303E6C", Offset = "0x1303E6C", VA = "0x1303E6C")]
	public void Appear([Optional] Action apeearEndCallback, float duration = 0.1f)
	{
	}

	[Token(Token = "0x6005AB1")]
	[Address(RVA = "0x131DC44", Offset = "0x131DC44", VA = "0x131DC44")]
	public void Vanish(float duration = 0.1f)
	{
	}

	[Token(Token = "0x6005AB2")]
	[Address(RVA = "0x131DE04", Offset = "0x131DE04", VA = "0x131DE04")]
	protected void BuildButton(GameObject go, string title, Action onClick)
	{
	}

	[Token(Token = "0x6005AB3")]
	[Address(RVA = "0x131E074", Offset = "0x131E074", VA = "0x131E074", Slot = "18")]
	public virtual void OnClick_Close()
	{
	}

	[Token(Token = "0x6005AB4")]
	[Address(RVA = "0x1306164", Offset = "0x1306164", VA = "0x1306164", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6005AB5")]
	[Address(RVA = "0x131E194", Offset = "0x131E194", VA = "0x131E194")]
	protected void Show()
	{
	}

	[Token(Token = "0x6005AB6")]
	[Address(RVA = "0x131E0B8", Offset = "0x131E0B8", VA = "0x131E0B8")]
	protected void CancleTweenScale()
	{
	}

	[Token(Token = "0x6005AB7")]
	[Address(RVA = "0x131DBF4", Offset = "0x131DBF4", VA = "0x131DBF4")]
	public bool IsHide()
	{
		return default(bool);
	}
}
