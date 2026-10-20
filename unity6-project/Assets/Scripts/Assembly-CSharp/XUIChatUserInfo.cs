using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3E")]
public class XUIChatUserInfo : MonoBehaviour
{
	[Token(Token = "0x4003DE0")]
	[FieldOffset(Offset = "0x0")]
	public static XUIChatUserInfo current;

	[Token(Token = "0x4003DE1")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Button btnRequestFriend;

	[Token(Token = "0x4003DE2")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_Button btnOtherFriendInfo;

	[Token(Token = "0x4003DE3")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_Button btnBlockFriend;

	[Token(Token = "0x4003DE4")]
	[FieldOffset(Offset = "0x18")]
	private string m_strNickName;

	[Token(Token = "0x4003DE5")]
	[FieldOffset(Offset = "0x1C")]
	private string m_strAid;

	[Token(Token = "0x4003DE6")]
	[FieldOffset(Offset = "0x20")]
	private bool alreadySend;

	[Token(Token = "0x6005879")]
	[Address(RVA = "0x1A353F8", Offset = "0x1A353F8", VA = "0x1A353F8")]
	public XUIChatUserInfo()
	{
	}

	[Token(Token = "0x600587A")]
	[Address(RVA = "0x1A354DC", Offset = "0x1A354DC", VA = "0x1A354DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600587B")]
	[Address(RVA = "0x1A34C70", Offset = "0x1A34C70", VA = "0x1A34C70")]
	public void Show(string strName, string aid)
	{
	}

	[Token(Token = "0x600587C")]
	[Address(RVA = "0x1A34BBC", Offset = "0x1A34BBC", VA = "0x1A34BBC")]
	public void Hide()
	{
	}

	[Token(Token = "0x600587D")]
	[Address(RVA = "0x1A359B0", Offset = "0x1A359B0", VA = "0x1A359B0")]
	public void OnClickFriendRequest()
	{
	}

	[Token(Token = "0x600587E")]
	[Address(RVA = "0x1A35A84", Offset = "0x1A35A84", VA = "0x1A35A84")]
	public void OnClickOtherFriendInfo()
	{
	}

	[Token(Token = "0x600587F")]
	[Address(RVA = "0x1A35C18", Offset = "0x1A35C18", VA = "0x1A35C18")]
	public void OnClickBlockFriendRequest()
	{
	}

	[Token(Token = "0x6005880")]
	[Address(RVA = "0x1A35CDC", Offset = "0x1A35CDC", VA = "0x1A35CDC")]
	private void OnBlockFriendRequest()
	{
	}

	[Token(Token = "0x6005881")]
	[Address(RVA = "0x1A356E4", Offset = "0x1A356E4", VA = "0x1A356E4")]
	private void RefreshFriendRequestButton()
	{
	}

	[Token(Token = "0x6005882")]
	[Address(RVA = "0x1A357D8", Offset = "0x1A357D8", VA = "0x1A357D8")]
	private void RefreshOtherFriendInfoButton()
	{
	}

	[Token(Token = "0x6005883")]
	[Address(RVA = "0x1A358BC", Offset = "0x1A358BC", VA = "0x1A358BC")]
	private void RefreshAddBlockFriendButton()
	{
	}

	[Token(Token = "0x6005884")]
	[Address(RVA = "0x1A35DBC", Offset = "0x1A35DBC", VA = "0x1A35DBC")]
	private bool IsInGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6005885")]
	[Address(RVA = "0x1A35E60", Offset = "0x1A35E60", VA = "0x1A35E60")]
	private void _003COnClickFriendRequest_003Em__24C()
	{
	}
}
