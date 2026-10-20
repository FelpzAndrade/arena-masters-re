using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001028")]
public class XUIMailItem : MonoBehaviour
{
	[Token(Token = "0x40056C7")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x40056C8")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblDesc;

	[Token(Token = "0x40056C9")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder gridContents;

	[Token(Token = "0x40056CA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goClanIcon;

	[Token(Token = "0x40056CB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblRemainTimer;

	[Token(Token = "0x40056CC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblRecieveText;

	[Token(Token = "0x40056CD")]
	[FieldOffset(Offset = "0x24")]
	private CSMailData m_mailItem;

	[Token(Token = "0x40056CE")]
	[FieldOffset(Offset = "0x28")]
	private string m_mailUID;

	[Token(Token = "0x40056CF")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_unlimit;

	[Token(Token = "0x40056D0")]
	[FieldOffset(Offset = "0x0")]
	private static bool isPopingMail;

	[Token(Token = "0x600788C")]
	[Address(RVA = "0x10AEFE8", Offset = "0x10AEFE8", VA = "0x10AEFE8")]
	public XUIMailItem()
	{
	}

	[Token(Token = "0x600788E")]
	[Address(RVA = "0x10AEFF4", Offset = "0x10AEFF4", VA = "0x10AEFF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600788F")]
	[Address(RVA = "0x10AF090", Offset = "0x10AF090", VA = "0x10AF090")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007890")]
	[Address(RVA = "0x10AF098", Offset = "0x10AF098", VA = "0x10AF098")]
	public void Build(CSMailData mailItem)
	{
	}

	[Token(Token = "0x6007891")]
	[Address(RVA = "0x10AF900", Offset = "0x10AF900", VA = "0x10AF900")]
	private bool IsUnlimited(CSMailData mailData)
	{
		return default(bool);
	}

	[Token(Token = "0x6007892")]
	[Address(RVA = "0x10AFBC0", Offset = "0x10AFBC0", VA = "0x10AFBC0")]
	private TimeSpan GetRemainTimeSpan(CSMailData mailData)
	{
		return default(TimeSpan);
	}

	[Token(Token = "0x6007893")]
	[Address(RVA = "0x10AF6C0", Offset = "0x10AF6C0", VA = "0x10AF6C0")]
	private bool IsClanNoti(CSMailData mailItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6007894")]
	[Address(RVA = "0x10AF6F0", Offset = "0x10AF6F0", VA = "0x10AF6F0")]
	private void BuildIcon(CSMailData mailItem)
	{
	}

	[Token(Token = "0x6007895")]
	[Address(RVA = "0x10AF9A0", Offset = "0x10AF9A0", VA = "0x10AF9A0")]
	private void UpdateTime()
	{
	}

	[Token(Token = "0x6007896")]
	[Address(RVA = "0x10AFDAC", Offset = "0x10AFDAC", VA = "0x10AFDAC")]
	public void OnButtonClick_PopMail()
	{
	}

	[Token(Token = "0x6007897")]
	[Address(RVA = "0x10B0394", Offset = "0x10B0394", VA = "0x10B0394")]
	private void PostPopMail()
	{
	}

	[Token(Token = "0x6007898")]
	[Address(RVA = "0x10B0604", Offset = "0x10B0604", VA = "0x10B0604")]
	private void ResetPopingMail()
	{
	}

	[Token(Token = "0x6007899")]
	[Address(RVA = "0x10B06B8", Offset = "0x10B06B8", VA = "0x10B06B8")]
	private void ShowFullFPPopup()
	{
	}

	[Token(Token = "0x600789A")]
	[Address(RVA = "0x10B0890", Offset = "0x10B0890", VA = "0x10B0890")]
	private void _003COnButtonClick_PopMail_003Em__506()
	{
	}

	[Token(Token = "0x600789B")]
	[Address(RVA = "0x10B0894", Offset = "0x10B0894", VA = "0x10B0894")]
	private void _003CPostPopMail_003Em__507(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
