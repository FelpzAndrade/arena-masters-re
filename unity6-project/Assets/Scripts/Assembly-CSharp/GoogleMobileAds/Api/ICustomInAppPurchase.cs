using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x200003D")]
	public interface ICustomInAppPurchase
	{
		[Token(Token = "0x17000047")]
		string ProductId
		{
			[Token(Token = "0x600017E")]
			get;
		}

		[Token(Token = "0x600017F")]
		void RecordResolution(PurchaseResolutionType resolution);
	}
}
