using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200018D")]
public class GLinkNaverIdAndroid : IGLinkNaverId
{
	[Token(Token = "0x200018E")]
	private class OnLoggedInListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x1F3743C", Offset = "0x1F3743C", VA = "0x1F3743C")]
		public OnLoggedInListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x1F37930", Offset = "0x1F37930", VA = "0x1F37930")]
		private void onLoggedIn(bool success)
		{
		}
	}

	[Token(Token = "0x200018F")]
	private class OnGetProfileListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x1F378A4", Offset = "0x1F378A4", VA = "0x1F378A4")]
		public OnGetProfileListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x1F3792C", Offset = "0x1F3792C", VA = "0x1F3792C")]
		private void onResult(string jsonString)
		{
		}
	}

	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x8")]
	private AndroidJavaClass delegateClass;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0xC")]
	private AndroidJavaObject currentActivity;

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x1F36F38", Offset = "0x1F36F38", VA = "0x1F36F38")]
	public GLinkNaverIdAndroid()
	{
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x1F3705C", Offset = "0x1F3705C", VA = "0x1F3705C", Slot = "4")]
	public void init(string clientId, string clientSecret)
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x1F372B0", Offset = "0x1F372B0", VA = "0x1F372B0", Slot = "5")]
	public void login()
	{
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x1F374C4", Offset = "0x1F374C4", VA = "0x1F374C4", Slot = "6")]
	public void logout()
	{
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x1F375E8", Offset = "0x1F375E8", VA = "0x1F375E8", Slot = "7")]
	public bool isLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x1F37718", Offset = "0x1F37718", VA = "0x1F37718", Slot = "8")]
	public void getProfile()
	{
	}
}
