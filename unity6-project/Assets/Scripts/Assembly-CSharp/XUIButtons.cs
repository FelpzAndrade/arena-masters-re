using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C57")]
public class XUIButtons : XUIBaseWidget
{
	[Token(Token = "0x2000C58")]
	public enum ButtonType
	{
		[Token(Token = "0x4003E8F")]
		NONE = 0,
		[Token(Token = "0x4003E90")]
		OK = 1,
		[Token(Token = "0x4003E91")]
		CANCEL = 2,
		[Token(Token = "0x4003E92")]
		LEAVE = 3
	}

	[Token(Token = "0x2000C59")]
	private sealed class _003CSet_003Ec__AnonStorey17B
	{
		[Token(Token = "0x4003E93")]
		[FieldOffset(Offset = "0x8")]
		internal Action OnClick;

		[Token(Token = "0x4003E94")]
		[FieldOffset(Offset = "0xC")]
		internal XUIButtons _003C_003Ef__this;

		[Token(Token = "0x6005945")]
		[Address(RVA = "0x1A2F6A0", Offset = "0x1A2F6A0", VA = "0x1A2F6A0")]
		public _003CSet_003Ec__AnonStorey17B()
		{
		}

		[Token(Token = "0x6005946")]
		[Address(RVA = "0x1A2F864", Offset = "0x1A2F864", VA = "0x1A2F864")]
		internal void _003C_003Em__254()
		{
		}
	}

	[Token(Token = "0x2000C5A")]
	private sealed class _003CSetLink_003Ec__AnonStorey17C
	{
		[Token(Token = "0x4003E95")]
		[FieldOffset(Offset = "0x8")]
		internal Action delegateClickAction;

		[Token(Token = "0x4003E96")]
		[FieldOffset(Offset = "0xC")]
		internal XUIButtons _003C_003Ef__this;

		[Token(Token = "0x6005947")]
		[Address(RVA = "0x1A2F6A8", Offset = "0x1A2F6A8", VA = "0x1A2F6A8")]
		public _003CSetLink_003Ec__AnonStorey17C()
		{
		}

		[Token(Token = "0x6005948")]
		[Address(RVA = "0x1A2F894", Offset = "0x1A2F894", VA = "0x1A2F894")]
		internal void _003C_003Em__255()
		{
		}
	}

	[Token(Token = "0x4003E87")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goClose;

	[Token(Token = "0x4003E88")]
	[FieldOffset(Offset = "0x20")]
	public XWiget_GridBuilder gridButton;

	[Token(Token = "0x4003E89")]
	[FieldOffset(Offset = "0x24")]
	private XMessageBoxButtons m_nButtons;

	[Token(Token = "0x4003E8A")]
	[FieldOffset(Offset = "0x28")]
	private XWidget_Button[] btns;

	[Token(Token = "0x4003E8B")]
	[FieldOffset(Offset = "0x2C")]
	protected bool isFirstBtnEmphasis;

	[Token(Token = "0x4003E8C")]
	[FieldOffset(Offset = "0x2D")]
	protected bool isSecondBtnEmphasis;

	[Token(Token = "0x4003E8D")]
	[FieldOffset(Offset = "0x2E")]
	protected bool isThirdBtnEmphasis;

	[Token(Token = "0x600593D")]
	[Address(RVA = "0x1A2EA9C", Offset = "0x1A2EA9C", VA = "0x1A2EA9C")]
	public XUIButtons()
	{
	}

	[Token(Token = "0x600593E")]
	[Address(RVA = "0x1A2EAAC", Offset = "0x1A2EAAC", VA = "0x1A2EAAC")]
	public void SetButtonMsg(XMessageBoxButtons nButtons, string ok, string cancle, string link)
	{
	}

	[Token(Token = "0x600593F")]
	[Address(RVA = "0x1A2EC54", Offset = "0x1A2EC54", VA = "0x1A2EC54")]
	protected void SetupButtons(XMessageBoxButtons nButtons, Action delegateOK, Action delegateCancle, Action delegateLink, string strLinkLabel)
	{
	}

	[Token(Token = "0x6005940")]
	[Address(RVA = "0x1A2F348", Offset = "0x1A2F348", VA = "0x1A2F348")]
	private void Set(XWidget_Button btn, ButtonType type, Action OnClick)
	{
	}

	[Token(Token = "0x6005941")]
	[Address(RVA = "0x1A2F55C", Offset = "0x1A2F55C", VA = "0x1A2F55C")]
	private void SetLink(XWidget_Button btn, string strLink, Action delegateClickAction)
	{
	}

	[Token(Token = "0x6005942")]
	[Address(RVA = "0x1A2F6B0", Offset = "0x1A2F6B0", VA = "0x1A2F6B0")]
	private void ButtonAction(Action delegateClickAction)
	{
	}

	[Token(Token = "0x6005943")]
	[Address(RVA = "0x1A2F180", Offset = "0x1A2F180", VA = "0x1A2F180")]
	protected void SetSprButton(GameObject btn, bool emphasis)
	{
	}

	[Token(Token = "0x6005944")]
	[Address(RVA = "0x1A2F738", Offset = "0x1A2F738", VA = "0x1A2F738", Slot = "18")]
	public virtual void Hide(bool bDoEventHandler = false)
	{
	}
}
