using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D9B")]
public class XPanel_GroupInviteMessagePopup : MonoBehaviour, IGroupInviteMsgPopup
{
	[Token(Token = "0x40046AE")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblMessage;

	[Token(Token = "0x40046AF")]
	[FieldOffset(Offset = "0x10")]
	private Action onClickAccept;

	[Token(Token = "0x40046B0")]
	[FieldOffset(Offset = "0x14")]
	private Action onClickReject;

	[Token(Token = "0x40046B1")]
	[FieldOffset(Offset = "0x18")]
	public string strShowSoundKey;

	[Token(Token = "0x6006417")]
	[Address(RVA = "0xFF308C", Offset = "0xFF308C", VA = "0xFF308C")]
	public XPanel_GroupInviteMessagePopup()
	{
	}

	[Token(Token = "0x6006418")]
	[Address(RVA = "0xFF3118", Offset = "0xFF3118", VA = "0xFF3118", Slot = "4")]
	public void Show(string groupMaster, Action onClickAccept, Action onClickReject)
	{
	}

	[Token(Token = "0x6006419")]
	[Address(RVA = "0xFF32BC", Offset = "0xFF32BC", VA = "0xFF32BC")]
	public void OnClick_Accept()
	{
	}

	[Token(Token = "0x600641A")]
	[Address(RVA = "0xFF330C", Offset = "0xFF330C", VA = "0xFF330C")]
	public void OnClick_Reject()
	{
	}
}
