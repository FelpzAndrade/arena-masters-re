using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x2001096")]
	public interface INPBannerListener : INPListenerType
	{
		[Token(Token = "0x6007D12")]
		void OnBannerClick(string landInfo);

		[Token(Token = "0x6007D13")]
		void OnBannerFailed(NPResult npResult);

		[Token(Token = "0x6007D14")]
		void OnBannerDismiss();
	}
}
