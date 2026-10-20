using Il2CppDummyDll;

[Token(Token = "0x2000189")]
public interface IGLinkNaverId
{
	[Token(Token = "0x6000E0C")]
	void init(string clientId, string clientSecret);

	[Token(Token = "0x6000E0D")]
	void login();

	[Token(Token = "0x6000E0E")]
	void logout();

	[Token(Token = "0x6000E0F")]
	bool isLogin();

	[Token(Token = "0x6000E10")]
	void getProfile();
}
