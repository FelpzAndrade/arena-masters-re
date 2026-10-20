using Il2CppDummyDll;

[Token(Token = "0x2000BE8")]
public class XAdjustManager
{
	[Token(Token = "0x4003C43")]
	[FieldOffset(Offset = "0x8")]
	private string npaCode;

	[Token(Token = "0x6005606")]
	[Address(RVA = "0x17B9018", Offset = "0x17B9018", VA = "0x17B9018")]
	public XAdjustManager()
	{
	}

	[Token(Token = "0x6005607")]
	[Address(RVA = "0x17B90DC", Offset = "0x17B90DC", VA = "0x17B90DC")]
	public void Init()
	{
	}

	[Token(Token = "0x6005608")]
	[Address(RVA = "0x17B9294", Offset = "0x17B9294", VA = "0x17B9294")]
	public void TrackEvent(string token)
	{
	}

	[Token(Token = "0x6005609")]
	[Address(RVA = "0x17B9360", Offset = "0x17B9360", VA = "0x17B9360")]
	public void TracEventWithNpaCode(string token)
	{
	}

	[Token(Token = "0x600560A")]
	[Address(RVA = "0x17B94C4", Offset = "0x17B94C4", VA = "0x17B94C4")]
	public void SetNpaCode(string _npaCode)
	{
	}

	[Token(Token = "0x600560B")]
	[Address(RVA = "0x17B94CC", Offset = "0x17B94CC", VA = "0x17B94CC")]
	public void TrackPurchaseEventWithNpaCod(string token, string productId, string currencyCode, float price)
	{
	}
}
