using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D9F")]
public class XWidget_GroupInviteUserItem : MonoBehaviour
{
	[Token(Token = "0x40046BD")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x40046BE")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x40046BF")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x40046C0")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x40046C1")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x40046C2")]
	[FieldOffset(Offset = "0x20")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x40046C3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblState;

	[Token(Token = "0x40046C4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goInviteButton;

	[Token(Token = "0x40046C5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goSprReady;

	[Token(Token = "0x40046C6")]
	[FieldOffset(Offset = "0x30")]
	public Color normalBGColor;

	[Token(Token = "0x40046C7")]
	[FieldOffset(Offset = "0x40")]
	public Color latelyPlayedBGColor;

	[Token(Token = "0x40046C8")]
	[FieldOffset(Offset = "0x50")]
	private XFriendData m_user;

	[Token(Token = "0x600643C")]
	[Address(RVA = "0x143E6E4", Offset = "0x143E6E4", VA = "0x143E6E4")]
	public XWidget_GroupInviteUserItem()
	{
	}

	[Token(Token = "0x600643D")]
	[Address(RVA = "0x143E6EC", Offset = "0x143E6EC", VA = "0x143E6EC")]
	public void Build(XFriendData user, bool isLatelyPlayedFriend)
	{
	}

	[Token(Token = "0x600643E")]
	[Address(RVA = "0x143ED7C", Offset = "0x143ED7C", VA = "0x143ED7C")]
	public void RefreshState(bool isJoined)
	{
	}

	[Token(Token = "0x600643F")]
	[Address(RVA = "0x143EE44", Offset = "0x143EE44", VA = "0x143EE44")]
	private void ChangeState(bool isShowButton, string stateKey, Color color)
	{
	}

	[Token(Token = "0x6006440")]
	[Address(RVA = "0x143EC98", Offset = "0x143EC98", VA = "0x143EC98")]
	public void ChangeAbailable()
	{
	}

	[Token(Token = "0x6006441")]
	[Address(RVA = "0x143EFD4", Offset = "0x143EFD4", VA = "0x143EFD4")]
	public void ChangeInviting()
	{
	}

	[Token(Token = "0x6006442")]
	[Address(RVA = "0x143F08C", Offset = "0x143F08C", VA = "0x143F08C")]
	public void ChangeRefused()
	{
	}

	[Token(Token = "0x6006443")]
	[Address(RVA = "0x143ED8C", Offset = "0x143ED8C", VA = "0x143ED8C")]
	public void ChangeAccepted()
	{
	}

	[Token(Token = "0x6006444")]
	[Address(RVA = "0x143F144", Offset = "0x143F144", VA = "0x143F144")]
	public void OnClick_Invite()
	{
	}
}
