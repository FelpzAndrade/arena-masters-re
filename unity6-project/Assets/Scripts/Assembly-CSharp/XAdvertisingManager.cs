using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000368")]
public class XAdvertisingManager
{
	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x8")]
	private XAdvertisingBase UnityAd;

	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0xC")]
	private XAdvertisingBase AdColony;

	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x10")]
	private List<XAdvertisingBase> AdvertisingSDKList;

	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x14")]
	private XAdvertisingBase m_selectedAdvertisingSDK;

	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x18")]
	private int m_lastSelectIndex;

	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_isReady;

	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x20")]
	private CSShopItem m_shopItem;

	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache7;

	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x1EDCD38", Offset = "0x1EDCD38", VA = "0x1EDCD38")]
	public XAdvertisingManager()
	{
	}

	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x1EDCDE4", Offset = "0x1EDCDE4", VA = "0x1EDCDE4")]
	public void Init()
	{
	}

	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x1EDD0E8", Offset = "0x1EDD0E8", VA = "0x1EDD0E8")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x1EDD1D8", Offset = "0x1EDD1D8", VA = "0x1EDD1D8")]
	private bool SetReadyAdvertisingSDK(int sdkIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x1EDD2F4", Offset = "0x1EDD2F4", VA = "0x1EDD2F4")]
	public bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x1EDD2FC", Offset = "0x1EDD2FC", VA = "0x1EDD2FC")]
	public void Show(CSShopItem item)
	{
	}

	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x1EDD454", Offset = "0x1EDD454", VA = "0x1EDD454")]
	private void ShowFinished()
	{
	}

	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x1EDD7B8", Offset = "0x1EDD7B8", VA = "0x1EDD7B8")]
	private static void _003CShowFinished_003Em__8E(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
