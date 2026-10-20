using Il2CppDummyDll;

[Token(Token = "0x2000192")]
public class GLinkStatisticsiOS : IGLinkStatistics
{
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x1F38350", Offset = "0x1F38350", VA = "0x1F38350")]
	public GLinkStatisticsiOS()
	{
	}

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x1F38358", Offset = "0x1F38358", VA = "0x1F38358", Slot = "4")]
	public void sendNewUser(string gameUserId, string market)
	{
	}

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x1F3835C", Offset = "0x1F3835C", VA = "0x1F3835C", Slot = "5")]
	public void sendPayUser(string gameUserId, double pay, string productCode, string currency, string market)
	{
	}
}
