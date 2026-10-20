using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6D")]
public class XUIToolTip : MonoBehaviour
{
	[Token(Token = "0x4003F04")]
	[FieldOffset(Offset = "0xC")]
	public GameObject TextLabel;

	[Token(Token = "0x4003F05")]
	[FieldOffset(Offset = "0x10")]
	public GameObject BackgroundSprite;

	[Token(Token = "0x60059AF")]
	[Address(RVA = "0x1939CF4", Offset = "0x1939CF4", VA = "0x1939CF4")]
	public XUIToolTip()
	{
	}

	[Token(Token = "0x60059B0")]
	[Address(RVA = "0x1939CFC", Offset = "0x1939CFC", VA = "0x1939CFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60059B1")]
	[Address(RVA = "0x1939D00", Offset = "0x1939D00", VA = "0x1939D00")]
	private void Update()
	{
	}

	[Token(Token = "0x60059B2")]
	[Address(RVA = "0x1939E04", Offset = "0x1939E04", VA = "0x1939E04")]
	public void Build(string strText)
	{
	}
}
