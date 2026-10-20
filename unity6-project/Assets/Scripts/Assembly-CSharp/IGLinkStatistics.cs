using Il2CppDummyDll;

[Token(Token = "0x2000191")]
public interface IGLinkStatistics
{
	[Token(Token = "0x6000E2E")]
	void sendNewUser(string gameUserId, string market);

	[Token(Token = "0x6000E2F")]
	void sendPayUser(string gameUserId, double pay, string productCode, string currency, string market);
}
