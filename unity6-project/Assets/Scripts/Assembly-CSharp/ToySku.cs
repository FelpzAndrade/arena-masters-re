using Il2CppDummyDll;

[Token(Token = "0x2000BD7")]
public class ToySku
{
	[Token(Token = "0x4003C1A")]
	private const int Micro = 1000000;

	[Token(Token = "0x4003C1B")]
	[FieldOffset(Offset = "0x8")]
	public string productId;

	[Token(Token = "0x4003C1C")]
	[FieldOffset(Offset = "0xC")]
	public string localizedTitle;

	[Token(Token = "0x4003C1D")]
	[FieldOffset(Offset = "0x10")]
	public string localizedDescription;

	[Token(Token = "0x4003C1E")]
	[FieldOffset(Offset = "0x14")]
	public string localizedPrice;

	[Token(Token = "0x4003C1F")]
	[FieldOffset(Offset = "0x18")]
	public long priceAmountMicros;

	[Token(Token = "0x4003C20")]
	[FieldOffset(Offset = "0x20")]
	public string priceCurrencyCode;

	[Token(Token = "0x60055B0")]
	[Address(RVA = "0x1D5791C", Offset = "0x1D5791C", VA = "0x1D5791C")]
	public ToySku()
	{
	}

	[Token(Token = "0x60055B1")]
	[Address(RVA = "0x1D52FA0", Offset = "0x1D52FA0", VA = "0x1D52FA0")]
	public static ToySku Create(string productId, long priceAmountMicros, string localizedDescription, string localizedPrice, string localizedTitle, string priceCurrencyCode)
	{
		return null;
	}

	[Token(Token = "0x60055B2")]
	[Address(RVA = "0x1D53A10", Offset = "0x1D53A10", VA = "0x1D53A10")]
	public float GetAmount()
	{
		return default(float);
	}
}
