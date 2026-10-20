using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EDE")]
public class XWidget_OptionChangeCheckPopup : XWidget_PopupTween
{
	[Token(Token = "0x2000EDF")]
	private sealed class _003CShowOptionChangeConfirmCheckPopup_003Ec__AnonStorey218
	{
		[Token(Token = "0x4004EB0")]
		[FieldOffset(Offset = "0x8")]
		internal Action onConfirm;

		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0x1307774", Offset = "0x1307774", VA = "0x1307774")]
		public _003CShowOptionChangeConfirmCheckPopup_003Ec__AnonStorey218()
		{
		}

		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0x1308754", Offset = "0x1308754", VA = "0x1308754")]
		internal void _003C_003Em__430()
		{
		}
	}

	[Token(Token = "0x4004E9C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PATH;

	[Token(Token = "0x4004E9D")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_ItemBaseInfo itembaseInfo;

	[Token(Token = "0x4004E9E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblTitle;

	[Token(Token = "0x4004E9F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject tweenPaenl;

	[Token(Token = "0x4004EA0")]
	[FieldOffset(Offset = "0x3C")]
	public Transform changeOptionStatParent;

	[Token(Token = "0x4004EA1")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_OptionStatSwitch m_changeOptionStat;

	[Token(Token = "0x4004EA2")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid buttonGrid;

	[Token(Token = "0x4004EA3")]
	[FieldOffset(Offset = "0x48")]
	public XWidget_Button btnNoraml;

	[Token(Token = "0x4004EA4")]
	[FieldOffset(Offset = "0x4C")]
	public XWidget_Button btnPoint;

	[Token(Token = "0x4004EA5")]
	[FieldOffset(Offset = "0x50")]
	public UIBasicSprite sprRootBG;

	[Token(Token = "0x4004EA6")]
	[FieldOffset(Offset = "0x54")]
	public UIBasicSprite sprEffectBG;

	[Token(Token = "0x4004EA7")]
	[FieldOffset(Offset = "0x58")]
	public UIBasicSprite sprOptionBG;

	[Token(Token = "0x4004EA8")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject goLabelCheckConfirm;

	[Token(Token = "0x4004EA9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject goResultEffect;

	[Token(Token = "0x4004EAA")]
	[FieldOffset(Offset = "0x64")]
	public int oneStatHeight;

	[Token(Token = "0x4004EAB")]
	[FieldOffset(Offset = "0x68")]
	public int twoStatHeight;

	[Token(Token = "0x4004EAC")]
	[FieldOffset(Offset = "0x6C")]
	public int resultPopupHeight;

	[Token(Token = "0x4004EAD")]
	[FieldOffset(Offset = "0x70")]
	public int checkPopupHeight;

	[Token(Token = "0x4004EAE")]
	[FieldOffset(Offset = "0x74")]
	private UITweener[] m_tweeners;

	[Token(Token = "0x4004EAF")]
	[FieldOffset(Offset = "0x78")]
	private Action m_onConfirm;

	[Token(Token = "0x17000E1F")]
	public XWidget_OptionStatSwitch changeOptionStat
	{
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0x1307254", Offset = "0x1307254", VA = "0x1307254")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E20")]
	private UITweener[] Tweeners
	{
		[Token(Token = "0x6006EF5")]
		[Address(RVA = "0x1307458", Offset = "0x1307458", VA = "0x1307458")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006EF2")]
	[Address(RVA = "0x13071B4", Offset = "0x13071B4", VA = "0x13071B4")]
	public XWidget_OptionChangeCheckPopup()
	{
	}

	[Token(Token = "0x6006EF6")]
	[Address(RVA = "0x1307564", Offset = "0x1307564", VA = "0x1307564")]
	public void ShowOptionChangeConfirmCheckPopup(XItem item, int changeIndex, int changeOptionID, Action onConfirm)
	{
	}

	[Token(Token = "0x6006EF7")]
	[Address(RVA = "0x1307C34", Offset = "0x1307C34", VA = "0x1307C34")]
	public void ShowOptionChangeResultPopup(XItem item, int changeIndex, List<int> prevRandomOptionList, Action onConfirm)
	{
	}

	[Token(Token = "0x6006EF8")]
	[Address(RVA = "0x1307BA8", Offset = "0x1307BA8", VA = "0x1307BA8")]
	private void BuildUIFrame(XItem item, bool isCheckPopup)
	{
	}

	[Token(Token = "0x6006EF9")]
	[Address(RVA = "0x1308188", Offset = "0x1308188", VA = "0x1308188")]
	public void UpdateBGsHeight(bool isCheckPopup)
	{
	}

	[Token(Token = "0x6006EFA")]
	[Address(RVA = "0x1308460", Offset = "0x1308460", VA = "0x1308460")]
	public void BuildButton(bool isCheckPopup)
	{
	}

	[Token(Token = "0x6006EFB")]
	[Address(RVA = "0x1308704", Offset = "0x1308704", VA = "0x1308704")]
	private void OnExecuteConfirmAndClose()
	{
	}

	[Token(Token = "0x6006EFC")]
	[Address(RVA = "0x1308368", Offset = "0x1308368", VA = "0x1308368")]
	private void TweenResetInPanel(bool play = false)
	{
	}
}
