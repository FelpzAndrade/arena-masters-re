using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C66")]
public class XUIMessageBox : XUIButtons, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x4003ECD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UIBasicSprite sprBg;

	[Token(Token = "0x4003ECE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblTitle;

	[Token(Token = "0x4003ECF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UILabel lblMessage;

	[Token(Token = "0x4003ED0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UIWidget widgetInnerSize;

	[Token(Token = "0x4003ED1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject goCostRoot;

	[Token(Token = "0x4003ED2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UI2DSprite sprCost;

	[Token(Token = "0x4003ED3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Currency m_costType;

	[Token(Token = "0x4003ED4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UILabel lblCost;

	[Token(Token = "0x4003ED5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public XWidget_CoolTime coolTime;

	[Token(Token = "0x4003ED6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private string m_strLinkLabel;

	[Token(Token = "0x4003ED7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int MinHeight;

	[Token(Token = "0x4003ED8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int BaseBackGroundWidth;

	[Token(Token = "0x4003ED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Action delegateBack;

	[Token(Token = "0x6005984")]
	[Address(RVA = "0x10B76CC", Offset = "0x10B76CC", VA = "0x10B76CC")]
	public XUIMessageBox()
	{
	}

	[Token(Token = "0x6005985")]
	[Address(RVA = "0x10B779C", Offset = "0x10B779C", VA = "0x10B779C")]
	public static void ShowPrepareService()
	{
	}

	[Token(Token = "0x6005986")]
	[Address(RVA = "0x10B79D4", Offset = "0x10B79D4", VA = "0x10B79D4", Slot = "21")]
	public virtual void ShowCoolDown(DateTime startDateTime, int coolSec, Action coolEndCallBack, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancel, [Optional] Action delegateLink, string strLinkLabel = "", bool forceLeftAlignment = false, UIWidget.Pivot pivot = UIWidget.Pivot.Top)
	{
	}

	[Token(Token = "0x6005987")]
	[Address(RVA = "0x10B7CD4", Offset = "0x10B7CD4", VA = "0x10B7CD4", Slot = "22")]
	public virtual void Show(Currency costType, int cost, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancel, [Optional] Action delegateLink, string strLinkLabel = "", bool forceLeftAlignment = false, UIWidget.Pivot pivot = UIWidget.Pivot.Top)
	{
	}

	[Token(Token = "0x6005988")]
	[Address(RVA = "0x10B8000", Offset = "0x10B8000", VA = "0x10B8000", Slot = "23")]
	public virtual void Show(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancel, [Optional] Action delegateLink, string strLinkLabel = "", bool forceLeftAlignment = false, int backgroundWidth = 606, int backgroundHeight = 406)
	{
	}

	[Token(Token = "0x6005989")]
	[Address(RVA = "0x10B8368", Offset = "0x10B8368", VA = "0x10B8368")]
	private void SetupBackDelegate(XMessageBoxButtons nButtons, Action delegateOK, Action delegateCancel)
	{
	}

	[Token(Token = "0x600598A")]
	[Address(RVA = "0x10B838C", Offset = "0x10B838C", VA = "0x10B838C", Slot = "24")]
	protected virtual void SetMessage(string strMessage, UIWidget.Pivot pivot, bool forceLeftAlignment = false, int messageWidth = 460)
	{
	}

	[Token(Token = "0x600598B")]
	[Address(RVA = "0x10B7B48", Offset = "0x10B7B48", VA = "0x10B7B48")]
	private void SetCoolTime(bool active, [Optional] DateTime? startDateTime, [Optional][DefaultParameterValue(0)] int coolSec, [Optional] Action coolEndCallBack)
	{
	}

	[Token(Token = "0x600598C")]
	[Address(RVA = "0x10B8904", Offset = "0x10B8904", VA = "0x10B8904", Slot = "18")]
	public override void Hide(bool bDoEventHandler = false)
	{
	}

	[Token(Token = "0x600598D")]
	[Address(RVA = "0x10B8944", Offset = "0x10B8944", VA = "0x10B8944", Slot = "20")]
	public void OnHide()
	{
	}
}
