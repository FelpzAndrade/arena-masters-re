using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010A1")]
	public enum NPBillingTransactionState
	{
		[Token(Token = "0x4005A6F")]
		Initialized = 0,
		[Token(Token = "0x4005A70")]
		PromotionInitialized = 2,
		[Token(Token = "0x4005A71")]
		VendorChecked = 5,
		[Token(Token = "0x4005A72")]
		Issued = 10,
		[Token(Token = "0x4005A73")]
		VendorPurchased = 15,
		[Token(Token = "0x4005A74")]
		PromotionPurchased = 17,
		[Token(Token = "0x4005A75")]
		Purchased = 20,
		[Token(Token = "0x4005A76")]
		Consumed = 30,
		[Token(Token = "0x4005A77")]
		PaymentCompleted = 35,
		[Token(Token = "0x4005A78")]
		Verified = 40,
		[Token(Token = "0x4005A79")]
		Finished = 50,
		[Token(Token = "0x4005A7A")]
		Canceled = 93,
		[Token(Token = "0x4005A7B")]
		Failed = 99
	}
}
