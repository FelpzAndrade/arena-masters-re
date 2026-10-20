using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BEC")]
public class XKakaoLinkManager : MonoBehaviour
{
	[Token(Token = "0x2000BED")]
	public delegate void CallBack(bool result);

	[Token(Token = "0x4003C4A")]
	[FieldOffset(Offset = "0x0")]
	private static XKakaoLinkManager m_Instance;

	[Token(Token = "0x4003C4B")]
	[FieldOffset(Offset = "0xC")]
	private CallBack callback;

	[Token(Token = "0x4003C4C")]
	[FieldOffset(Offset = "0x10")]
	private string templateId;

	[Token(Token = "0x4003C4D")]
	[FieldOffset(Offset = "0x14")]
	private string description;

	[Token(Token = "0x4003C4E")]
	[FieldOffset(Offset = "0x18")]
	private string buttonText;

	[Token(Token = "0x17000C97")]
	public static XKakaoLinkManager instance
	{
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x1D37840", Offset = "0x1D37840", VA = "0x1D37840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600561E")]
	[Address(RVA = "0x1D37744", Offset = "0x1D37744", VA = "0x1D37744")]
	public XKakaoLinkManager()
	{
	}

	[Token(Token = "0x6005621")]
	[Address(RVA = "0x1D37A94", Offset = "0x1D37A94", VA = "0x1D37A94")]
	public void InviteKakaoFriends(CallBack _callback)
	{
	}

	[Token(Token = "0x6005622")]
	[Address(RVA = "0x1D37ED8", Offset = "0x1D37ED8", VA = "0x1D37ED8")]
	public void GetResult(string result)
	{
	}
}
