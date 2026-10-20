using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000F6F")]
public class XWidget_ChannelLanguage : XUIBase
{
	[Token(Token = "0x400514B")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder languageBuilder;

	[Token(Token = "0x400514C")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_LanguageItem currentSelectItem;

	[Token(Token = "0x400514D")]
	[FieldOffset(Offset = "0x14")]
	private XWidget_LanguageItem wantSelectItem;

	[Token(Token = "0x400514E")]
	[FieldOffset(Offset = "0x18")]
	public UIInput input;

	[Token(Token = "0x400514F")]
	[FieldOffset(Offset = "0x1C")]
	public string CurrentChannelID;

	[Token(Token = "0x4005150")]
	[FieldOffset(Offset = "0x20")]
	public string wantChannelID;

	[Token(Token = "0x4005151")]
	[FieldOffset(Offset = "0x24")]
	public Action<string, int> changeChannelEvent;

	[Token(Token = "0x60072D4")]
	[Address(RVA = "0x15C72F4", Offset = "0x15C72F4", VA = "0x15C72F4")]
	public XWidget_ChannelLanguage()
	{
	}

	[Token(Token = "0x60072D5")]
	[Address(RVA = "0x15C72FC", Offset = "0x15C72FC", VA = "0x15C72FC")]
	public void BuildList(List<XLanguageInfo> infos, Action<string, int> changeEvent, string _eCurrentLang, int _currChannelID)
	{
	}

	[Token(Token = "0x60072D6")]
	[Address(RVA = "0x15C73F4", Offset = "0x15C73F4", VA = "0x15C73F4")]
	public void Build(List<XLanguageInfo> infos, string selectChannelNameLanguage)
	{
	}

	[Token(Token = "0x60072D7")]
	[Address(RVA = "0x15C7680", Offset = "0x15C7680", VA = "0x15C7680")]
	public void OnShow()
	{
	}

	[Token(Token = "0x60072D8")]
	[Address(RVA = "0x15C7800", Offset = "0x15C7800", VA = "0x15C7800")]
	public void OnSelect(XWidget_LanguageItem _wantSelectItem)
	{
	}

	[Token(Token = "0x60072D9")]
	[Address(RVA = "0x15C78F4", Offset = "0x15C78F4", VA = "0x15C78F4")]
	private void ChangeLanguage()
	{
	}

	[Token(Token = "0x60072DA")]
	[Address(RVA = "0x15C7A68", Offset = "0x15C7A68", VA = "0x15C7A68")]
	private void CancelChangeLanguage()
	{
	}

	[Token(Token = "0x60072DB")]
	[Address(RVA = "0x15C7B48", Offset = "0x15C7B48", VA = "0x15C7B48")]
	public void OnClickOK()
	{
	}

	[Token(Token = "0x60072DC")]
	[Address(RVA = "0x15C7C84", Offset = "0x15C7C84", VA = "0x15C7C84")]
	public void OnClickCancel()
	{
	}

	[Token(Token = "0x60072DD")]
	[Address(RVA = "0x15C7B90", Offset = "0x15C7B90", VA = "0x15C7B90")]
	private void ClearInputValue()
	{
	}

	[Token(Token = "0x60072DE")]
	[Address(RVA = "0x15C7CCC", Offset = "0x15C7CCC", VA = "0x15C7CCC")]
	public void OnChangeChannelInput(string value)
	{
	}
}
