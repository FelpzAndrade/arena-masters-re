using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D10")]
public class XPanel_GameReady : MonoBehaviour
{
	[Token(Token = "0x40042A5")]
	[FieldOffset(Offset = "0xC")]
	public GameObject btnStart;

	[Token(Token = "0x40042A6")]
	[FieldOffset(Offset = "0x10")]
	public GameObject lblWaiting;

	[Token(Token = "0x40042A7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject lblDuelMatchWaiting;

	[Token(Token = "0x40042A8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblTotalPlayer_StartBtn;

	[Token(Token = "0x40042A9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTotalPlayer_GameWaiting;

	[Token(Token = "0x6005F84")]
	[Address(RVA = "0xFD94C0", Offset = "0xFD94C0", VA = "0xFD94C0")]
	public XPanel_GameReady()
	{
	}

	[Token(Token = "0x6005F85")]
	[Address(RVA = "0xFD94C8", Offset = "0xFD94C8", VA = "0xFD94C8")]
	public void ShowStartButton()
	{
	}

	[Token(Token = "0x6005F86")]
	[Address(RVA = "0xFD99E4", Offset = "0xFD99E4", VA = "0xFD99E4")]
	public void ShowWaitingLabel()
	{
	}

	[Token(Token = "0x6005F87")]
	[Address(RVA = "0xFD9ABC", Offset = "0xFD9ABC", VA = "0xFD9ABC")]
	public void ShowDuelWaitingLabel()
	{
	}

	[Token(Token = "0x6005F88")]
	[Address(RVA = "0xFD9B94", Offset = "0xFD9B94", VA = "0xFD9B94")]
	public void HideDuelWaitingLabel()
	{
	}

	[Token(Token = "0x6005F89")]
	[Address(RVA = "0xFD9BE4", Offset = "0xFD9BE4", VA = "0xFD9BE4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005F8A")]
	[Address(RVA = "0xFD95A0", Offset = "0xFD95A0", VA = "0xFD95A0")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6005F8B")]
	[Address(RVA = "0xFD9C18", Offset = "0xFD9C18", VA = "0xFD9C18")]
	public void OnClickGameStartButton()
	{
	}
}
