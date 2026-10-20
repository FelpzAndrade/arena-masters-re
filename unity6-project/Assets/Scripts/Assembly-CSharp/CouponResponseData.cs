using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x20008E7")]
public class CouponResponseData : IHttpData
{
	[Token(Token = "0x4002B29")]
	[FieldOffset(Offset = "0x8")]
	public int resultCode;

	[Token(Token = "0x4002B2A")]
	[FieldOffset(Offset = "0xC")]
	public string resultMessage;

	[Token(Token = "0x4002B2B")]
	[FieldOffset(Offset = "0x10")]
	public string resultCouponNum;

	[Token(Token = "0x4002B2C")]
	[FieldOffset(Offset = "0x14")]
	public string itemInfoJsonStr;

	[Token(Token = "0x4002B2D")]
	[FieldOffset(Offset = "0x18")]
	[JsonIgnore]
	public List<CouponItemInfo> itemInfo;

	[Token(Token = "0x4002B2E")]
	[FieldOffset(Offset = "0x0")]
	[JsonIgnore]
	public static readonly string Key;

	[Token(Token = "0x6004780")]
	[Address(RVA = "0x23E4004", Offset = "0x23E4004", VA = "0x23E4004")]
	public CouponResponseData()
	{
	}
}
