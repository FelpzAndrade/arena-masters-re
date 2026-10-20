using System;
using GoogleMobileAds.Api;
using Il2CppDummyDll;

[Token(Token = "0x2000BCC")]
public interface IAdmobListener
{
	[Token(Token = "0x6005539")]
	void OnAdRequested(object sender, EventArgs args);

	[Token(Token = "0x600553A")]
	void OnAdLoaded(object sender, EventArgs args);

	[Token(Token = "0x600553B")]
	void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args);

	[Token(Token = "0x600553C")]
	void OnAdOpening(object sender, EventArgs args);

	[Token(Token = "0x600553D")]
	void OnAdStarted(object sender, EventArgs args);

	[Token(Token = "0x600553E")]
	void OnAdRewarded(object sender, Reward args);

	[Token(Token = "0x600553F")]
	void OnAdClosed(object sender, EventArgs args);

	[Token(Token = "0x6005540")]
	void OnAdLeavingApplication(object sender, EventArgs args);
}
