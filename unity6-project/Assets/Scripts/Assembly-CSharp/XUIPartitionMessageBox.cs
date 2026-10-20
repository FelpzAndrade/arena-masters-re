using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000C68")]
public class XUIPartitionMessageBox : XUIMessageBox
{
	[Token(Token = "0x4003EE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public UILabel lblBottomMessage;

	[Token(Token = "0x6005993")]
	[Address(RVA = "0x190D024", Offset = "0x190D024", VA = "0x190D024")]
	public XUIPartitionMessageBox()
	{
	}

	[Token(Token = "0x6005994")]
	[Address(RVA = "0x190D02C", Offset = "0x190D02C", VA = "0x190D02C")]
	public void Show(string strTitle, string strMessage, string strMessageBottom, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancel, [Optional] Action delegateLink, string strLinkLabel = "", bool forceLeftAlignment = false, int backgroundWidth = 606, int backgroundHeight = 406)
	{
	}

	[Token(Token = "0x6005995")]
	[Address(RVA = "0x190D264", Offset = "0x190D264", VA = "0x190D264", Slot = "24")]
	protected override void SetMessage(string strMessage, UIWidget.Pivot pivot, bool forceLeftAlignment = false, int messageWidth = 460)
	{
	}
}
