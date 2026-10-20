using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200100C")]
public class XHelpInfo
{
	[Token(Token = "0x40055AF")]
	[FieldOffset(Offset = "0x8")]
	public int nID;

	[Token(Token = "0x40055B0")]
	[FieldOffset(Offset = "0xC")]
	public int nGroupID;

	[Token(Token = "0x40055B1")]
	[FieldOffset(Offset = "0x10")]
	public int order;

	[Token(Token = "0x40055B2")]
	[FieldOffset(Offset = "0x14")]
	public string strCategory_1;

	[Token(Token = "0x40055B3")]
	[FieldOffset(Offset = "0x18")]
	public string strCategory_2;

	[Token(Token = "0x40055B4")]
	[FieldOffset(Offset = "0x1C")]
	public HelpLink nLink;

	[Token(Token = "0x40055B5")]
	[FieldOffset(Offset = "0x20")]
	public string strTitle;

	[Token(Token = "0x40055B6")]
	[FieldOffset(Offset = "0x24")]
	public string strContent;

	[Token(Token = "0x40055B7")]
	[FieldOffset(Offset = "0x28")]
	public string str_disable_country;

	[Token(Token = "0x40055B8")]
	[FieldOffset(Offset = "0x2C")]
	private List<string> disableCountrys__BackingField;

	[Token(Token = "0x17000EEC")]
	public List<string> disableCountrys
	{
		[Token(Token = "0x60077C4")]
		[Address(RVA = "0x1D1F660", Offset = "0x1D1F660", VA = "0x1D1F660")]
		get
		{
			return null;
		}
		[Token(Token = "0x60077C5")]
		[Address(RVA = "0x1D1F668", Offset = "0x1D1F668", VA = "0x1D1F668")]
		set
		{
		}
	}

	[Token(Token = "0x60077C3")]
	[Address(RVA = "0x1D1F54C", Offset = "0x1D1F54C", VA = "0x1D1F54C")]
	public XHelpInfo()
	{
	}

	[Token(Token = "0x60077C6")]
	[Address(RVA = "0x1D1F670", Offset = "0x1D1F670", VA = "0x1D1F670")]
	public void Cooking()
	{
	}

	[Token(Token = "0x60077C7")]
	[Address(RVA = "0x1D1F840", Offset = "0x1D1F840", VA = "0x1D1F840")]
	public bool IsDisableCountry(string country)
	{
		return default(bool);
	}
}
