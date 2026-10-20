using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F86")]
public class XWidget_FriendlyMatchRoom : MonoBehaviour
{
	[Token(Token = "0x40051F4")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Mark modeMark;

	[Token(Token = "0x40051F5")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblRoomNumber;

	[Token(Token = "0x40051F6")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblMasterName;

	[Token(Token = "0x40051F7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRoomTitle;

	[Token(Token = "0x40051F8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblModeName;

	[Token(Token = "0x40051F9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMapName;

	[Token(Token = "0x40051FA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblPlayerCounting;

	[Token(Token = "0x40051FB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lockObject;

	[Token(Token = "0x40051FC")]
	[FieldOffset(Offset = "0x2C")]
	private Action<FriendlyRoomInfo> clickAction;

	[Token(Token = "0x40051FD")]
	[FieldOffset(Offset = "0x30")]
	private int sectorID;

	[Token(Token = "0x40051FE")]
	[FieldOffset(Offset = "0x34")]
	private int gameModeInstanceId;

	[Token(Token = "0x40051FF")]
	[FieldOffset(Offset = "0x38")]
	private FriendlyRoomInfo m_roomInfo;

	[Token(Token = "0x6007388")]
	[Address(RVA = "0x142D0A0", Offset = "0x142D0A0", VA = "0x142D0A0")]
	public XWidget_FriendlyMatchRoom()
	{
	}

	[Token(Token = "0x6007389")]
	[Address(RVA = "0x142D0B4", Offset = "0x142D0B4", VA = "0x142D0B4")]
	public void Build(FriendlyRoomInfo roomInfo)
	{
	}

	[Token(Token = "0x600738A")]
	[Address(RVA = "0x142D708", Offset = "0x142D708", VA = "0x142D708")]
	public void OnClickItem()
	{
	}
}
