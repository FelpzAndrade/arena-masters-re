using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E31")]
public class XPanel_SnsFriendInvite : UIPopup
{
	[Token(Token = "0x4004A99")]
	[FieldOffset(Offset = "0x20")]
	public GameObject btn_facebook;

	[Token(Token = "0x4004A9A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject btn_kakao;

	[Token(Token = "0x17000D9C")]
	public static XPanel_SnsFriendInvite Instance
	{
		[Token(Token = "0x6006973")]
		[Address(RVA = "0xACBE70", Offset = "0xACBE70", VA = "0xACBE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006971")]
	[Address(RVA = "0xACBD74", Offset = "0xACBD74", VA = "0xACBD74")]
	public XPanel_SnsFriendInvite()
	{
	}

	[Token(Token = "0x6006972")]
	[Address(RVA = "0xACBD7C", Offset = "0xACBD7C", VA = "0xACBD7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006974")]
	[Address(RVA = "0xACBF7C", Offset = "0xACBF7C", VA = "0xACBF7C")]
	public void OnClick_InviteFacebook()
	{
	}

	[Token(Token = "0x6006975")]
	[Address(RVA = "0xACC238", Offset = "0xACC238", VA = "0xACC238")]
	public void OnClick_InviteTwitter()
	{
	}

	[Token(Token = "0x6006976")]
	[Address(RVA = "0xACC41C", Offset = "0xACC41C", VA = "0xACC41C")]
	public void OnClick_InviteKakao()
	{
	}

	[Token(Token = "0x6006977")]
	[Address(RVA = "0xACC5F0", Offset = "0xACC5F0", VA = "0xACC5F0")]
	public void OnResult_InviteKakao(bool result)
	{
	}

	[Token(Token = "0x6006978")]
	[Address(RVA = "0xACC8BC", Offset = "0xACC8BC", VA = "0xACC8BC")]
	public void OnClick_InviteLine()
	{
	}

	[Token(Token = "0x6006979")]
	[Address(RVA = "0xACC054", Offset = "0xACC054", VA = "0xACC054")]
	private bool TryCheckPlatformError()
	{
		return default(bool);
	}

	[Token(Token = "0x600697A")]
	[Address(RVA = "0xACC8C0", Offset = "0xACC8C0", VA = "0xACC8C0")]
	public void OnClick_Close()
	{
	}
}
