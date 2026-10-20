using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x2001097")]
	public interface INPEndingBannerListener : INPListenerType
	{
		[Token(Token = "0x6007D15")]
		void OnEndingBannerClick(string landInfo);

		[Token(Token = "0x6007D16")]
		void OnEndingBannerFailed(NPResult npResult);

		[Token(Token = "0x6007D17")]
		void OnEndingBannerDismiss();

		[Token(Token = "0x6007D18")]
		void OnEndingBannerExit();
	}
}
