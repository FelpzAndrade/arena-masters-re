using Il2CppDummyDll;

[Token(Token = "0x200018A")]
public class GLinkNaverIdiOS : IGLinkNaverId
{
	[Token(Token = "0x200018B")]
	private delegate void NaverIdLoginDelelgate();

	[Token(Token = "0x200018C")]
	private delegate void NaverIdGetProfileDelegate(string result);

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x1F37934", Offset = "0x1F37934", VA = "0x1F37934")]
	public GLinkNaverIdiOS()
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x1F3793C", Offset = "0x1F3793C", VA = "0x1F3793C")]
	public static void _NaverIdLoginCallback()
	{
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x1F37A34", Offset = "0x1F37A34", VA = "0x1F37A34")]
	public static void _NaverIdGetProfileCallback(string result)
	{
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x1F37B84", Offset = "0x1F37B84", VA = "0x1F37B84", Slot = "4")]
	public void init(string clientId, string clientSecret)
	{
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x1F37B88", Offset = "0x1F37B88", VA = "0x1F37B88", Slot = "5")]
	public void login()
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x1F37B8C", Offset = "0x1F37B8C", VA = "0x1F37B8C", Slot = "6")]
	public void logout()
	{
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x1F37B90", Offset = "0x1F37B90", VA = "0x1F37B90", Slot = "7")]
	public bool isLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x1F37B98", Offset = "0x1F37B98", VA = "0x1F37B98", Slot = "8")]
	public void getProfile()
	{
	}
}
