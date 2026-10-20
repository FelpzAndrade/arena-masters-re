using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F7B")]
public class XWidget_CustomRoom : MonoBehaviour
{
	[Token(Token = "0x40051B5")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Mark modeMark;

	[Token(Token = "0x40051B6")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblRoomNumber;

	[Token(Token = "0x40051B7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblMasterName;

	[Token(Token = "0x40051B8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRoomTitle;

	[Token(Token = "0x40051B9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblModeName;

	[Token(Token = "0x40051BA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblMapName;

	[Token(Token = "0x40051BB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblPlayerCounting;

	[Token(Token = "0x40051BC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lockObject;

	[Token(Token = "0x40051BD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goCombatPowerCorrectionMark;

	[Token(Token = "0x40051BE")]
	[FieldOffset(Offset = "0x30")]
	private Action<XUICustomRoomInfo> clickAction;

	[Token(Token = "0x40051BF")]
	[FieldOffset(Offset = "0x34")]
	private int sectorID;

	[Token(Token = "0x40051C0")]
	[FieldOffset(Offset = "0x38")]
	private int gameModeInstanceId;

	[Token(Token = "0x40051C1")]
	[FieldOffset(Offset = "0x3C")]
	private XUICustomRoomInfo m_roomInfo;

	[Token(Token = "0x6007345")]
	[Address(RVA = "0x15ED814", Offset = "0x15ED814", VA = "0x15ED814")]
	public XWidget_CustomRoom()
	{
	}

	[Token(Token = "0x6007346")]
	[Address(RVA = "0x15ED828", Offset = "0x15ED828", VA = "0x15ED828")]
	public void Build(XUICustomRoomInfo roomInfo)
	{
	}

	[Token(Token = "0x6007347")]
	[Address(RVA = "0x15EDE9C", Offset = "0x15EDE9C", VA = "0x15EDE9C")]
	public void OnClickItem()
	{
	}
}
