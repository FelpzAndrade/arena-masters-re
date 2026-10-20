using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000C5E")]
public class XUIFlatMessageBox : XUIMessageBox
{
	[Token(Token = "0x6005958")]
	[Address(RVA = "0x1A44FBC", Offset = "0x1A44FBC", VA = "0x1A44FBC")]
	public XUIFlatMessageBox()
	{
	}

	[Token(Token = "0x6005959")]
	[Address(RVA = "0x1A44FC4", Offset = "0x1A44FC4", VA = "0x1A44FC4", Slot = "22")]
	public override void Show(Currency costType, int cost, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancel, [Optional] Action delegateLink, string strLinkLabel = "", bool forceLeftAlignment = false, UIWidget.Pivot pivot = UIWidget.Pivot.Top)
	{
	}
}
