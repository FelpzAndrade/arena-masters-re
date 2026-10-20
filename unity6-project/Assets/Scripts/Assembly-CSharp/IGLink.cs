using Il2CppDummyDll;

[Token(Token = "0x2000195")]
public interface IGLink
{
	[Token(Token = "0x6000E4C")]
	void executeHome();

	[Token(Token = "0x6000E4D")]
	void executeNotice();

	[Token(Token = "0x6000E4E")]
	void executeEvent();

	[Token(Token = "0x6000E4F")]
	void executeMenu();

	[Token(Token = "0x6000E50")]
	void executeProfile();

	[Token(Token = "0x6000E51")]
	void executeArticle(int articleId);

	[Token(Token = "0x6000E52")]
	void executeArticlePost();

	[Token(Token = "0x6000E53")]
	void executeArticlePostWithImage(string filePath);

	[Token(Token = "0x6000E54")]
	void executeArticlePostWithVideo(string filePath);

	[Token(Token = "0x6000E55")]
	void syncGameUserId(string gameUserId);

	[Token(Token = "0x6000E56")]
	void startWidget();

	[Token(Token = "0x6000E57")]
	void stopWidget();

	[Token(Token = "0x6000E58")]
	void setUseWidgetVideoRecord(bool useVideoRecord);

	[Token(Token = "0x6000E59")]
	void setUseWidgetScreenShot(bool useScreenShot);

	[Token(Token = "0x6000E5A")]
	void setShowWidgetWhenUnloadSDK(bool useWidget);

	[Token(Token = "0x6000E5B")]
	void executeMore();

	[Token(Token = "0x6000E5C")]
	string getCurrentChannelCode();

	[Token(Token = "0x6000E5D")]
	void setChannelCode(string channelCode);

	[Token(Token = "0x6000E5E")]
	void setThemeColor(string themeColorCSSString);

	[Token(Token = "0x6000E5F")]
	void setThemeColor(string themeColorCSSString, string backgroundCSSString);

	[Token(Token = "0x6000E60")]
	void setWidgetStartPosition(bool isLeft, int heightPercentage);
}
