using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000864")]
	public enum ToyReturnCode
	{
		[Token(Token = "0x4002692")]
		UnknownError = -100,
		[Token(Token = "0x4002693")]
		NetworkError = -101,
		[Token(Token = "0x4002694")]
		DBError = -102,
		[Token(Token = "0x4002695")]
		InvalidProductId = -110,
		[Token(Token = "0x4002696")]
		IsHiddenProduct = -111,
		[Token(Token = "0x4002697")]
		IsNotSaleTime = -112,
		[Token(Token = "0x4002698")]
		IsDuplicateBuy = -113,
		[Token(Token = "0x4002699")]
		AlreadGetProduct = -114,
		[Token(Token = "0x400269A")]
		ShopBuyItemError = -120,
		[Token(Token = "0x400269B")]
		Success = 0,
		[Token(Token = "0x400269C")]
		InvalidStampToken = 24002,
		[Token(Token = "0x400269D")]
		ExpiredStampToken = 24003,
		[Token(Token = "0x400269E")]
		InvalidStampId = 24004,
		[Token(Token = "0x400269F")]
		FailedPurchaseVerify = 24100,
		[Token(Token = "0x40026A0")]
		AbnormalFinish = 24900,
		[Token(Token = "0x40026A1")]
		GoogleNotConsumed = 24701,
		[Token(Token = "0x40026A2")]
		GooglePurchaseCanceled = 24703
	}
}
