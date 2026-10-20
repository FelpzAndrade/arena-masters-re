using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D7C")]
public class XUIGameWindow : MonoBehaviour
{
	[Token(Token = "0x400459C")]
	[FieldOffset(Offset = "0xC")]
	public GameObject GoldLabel;

	[Token(Token = "0x400459D")]
	[FieldOffset(Offset = "0x10")]
	public GameObject KeyLabel;

	[Token(Token = "0x400459E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HeroLabel;

	[Token(Token = "0x400459F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemLabel;

	[Token(Token = "0x40045A0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MapLabel;

	[Token(Token = "0x40045A1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GameModeStateLabel;

	[Token(Token = "0x40045A2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GameTimeLabel;

	[Token(Token = "0x40045A3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject KillCountLabel;

	[Token(Token = "0x40045A4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MenuButton;

	[Token(Token = "0x40045A5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ChatButton;

	[Token(Token = "0x600630E")]
	[Address(RVA = "0x1A60428", Offset = "0x1A60428", VA = "0x1A60428")]
	public XUIGameWindow()
	{
	}

	[Token(Token = "0x600630F")]
	[Address(RVA = "0x1A60430", Offset = "0x1A60430", VA = "0x1A60430")]
	private void Start()
	{
	}

	[Token(Token = "0x6006310")]
	[Address(RVA = "0x1A60434", Offset = "0x1A60434", VA = "0x1A60434")]
	private void Update()
	{
	}

	[Token(Token = "0x6006311")]
	[Address(RVA = "0x1A60438", Offset = "0x1A60438", VA = "0x1A60438")]
	protected void RefreshLabels()
	{
	}
}
