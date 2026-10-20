using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F6E")]
public class XWidget_CashBuyInfo : MonoBehaviour
{
	[Token(Token = "0x4005148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject goBtnCommerce;

	[Token(Token = "0x4005149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject goBtnBilling;

	[Token(Token = "0x400514A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject goKoTermRoot;

	[Token(Token = "0x60072CF")]
	[Address(RVA = "0x15C6EF8", Offset = "0x15C6EF8", VA = "0x15C6EF8")]
	public XWidget_CashBuyInfo()
	{
	}

	[Token(Token = "0x60072D0")]
	[Address(RVA = "0x15C6F00", Offset = "0x15C6F00", VA = "0x15C6F00")]
	public void Build([Optional] Func<bool> koTermCondition, [Optional] Func<bool> japanTermCondition)
	{
	}

	[Token(Token = "0x60072D1")]
	[Address(RVA = "0x15C71A8", Offset = "0x15C71A8", VA = "0x15C71A8")]
	public void OnClick_JapanCommerce()
	{
	}

	[Token(Token = "0x60072D2")]
	[Address(RVA = "0x15C71B4", Offset = "0x15C71B4", VA = "0x15C71B4")]
	public void OnClick_JapanBilling()
	{
	}

	[Token(Token = "0x60072D3")]
	[Address(RVA = "0x15C71C0", Offset = "0x15C71C0", VA = "0x15C71C0")]
	public void OnClick_KoTermDetail()
	{
	}
}
