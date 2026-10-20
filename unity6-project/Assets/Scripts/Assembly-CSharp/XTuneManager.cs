using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BFC")]
public class XTuneManager : MonoBehaviour
{
	[Token(Token = "0x4003CB1")]
	[FieldOffset(Offset = "0xC")]
	private string TUNE_ADVERTISER_ID;

	[Token(Token = "0x4003CB2")]
	[FieldOffset(Offset = "0x10")]
	private string TUNE_CONVERSION_KEY;

	[Token(Token = "0x60056CD")]
	[Address(RVA = "0x184B248", Offset = "0x184B248", VA = "0x184B248")]
	public XTuneManager()
	{
	}

	[Token(Token = "0x60056CE")]
	[Address(RVA = "0x184B2E8", Offset = "0x184B2E8", VA = "0x184B2E8")]
	public void Init()
	{
	}

	[Token(Token = "0x60056CF")]
	[Address(RVA = "0x183758C", Offset = "0x183758C", VA = "0x183758C")]
	public void TrackEvent(string eventName)
	{
	}

	[Token(Token = "0x60056D0")]
	[Address(RVA = "0x184B514", Offset = "0x184B514", VA = "0x184B514")]
	public void TrackPurchaseEvent(string eventName, string purchaseId, string currencyCode, float price)
	{
	}

	[Token(Token = "0x60056D1")]
	[Address(RVA = "0x184B638", Offset = "0x184B638", VA = "0x184B638")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
