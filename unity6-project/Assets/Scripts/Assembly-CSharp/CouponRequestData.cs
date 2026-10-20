using System.Collections.Specialized;
using Il2CppDummyDll;

[Token(Token = "0x20008E6")]
public class CouponRequestData : IHttpData
{
	[Token(Token = "0x4002B24")]
	[FieldOffset(Offset = "0x8")]
	public string couponNum;

	[Token(Token = "0x4002B25")]
	[FieldOffset(Offset = "0xC")]
	public string npsn;

	[Token(Token = "0x4002B26")]
	[FieldOffset(Offset = "0x10")]
	public string serviceCode;

	[Token(Token = "0x4002B27")]
	[FieldOffset(Offset = "0x14")]
	public string toyToken;

	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x18")]
	public string accessToken;

	[Token(Token = "0x600477E")]
	[Address(RVA = "0x23E3EB4", Offset = "0x23E3EB4", VA = "0x23E3EB4")]
	public CouponRequestData()
	{
	}

	[Token(Token = "0x600477F")]
	[Address(RVA = "0x23E3EBC", Offset = "0x23E3EBC", VA = "0x23E3EBC")]
	public NameValueCollection GetNameValueCollection()
	{
		return null;
	}
}
