using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C67")]
public class XUIPINGLabel : MonoBehaviour
{
	[Token(Token = "0x4003EDA")]
	[FieldOffset(Offset = "0xC")]
	public Rect PingStartRect;

	[Token(Token = "0x4003EDB")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_bUpdateColor;

	[Token(Token = "0x4003EDC")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_bAllowDrag;

	[Token(Token = "0x4003EDD")]
	[FieldOffset(Offset = "0x20")]
	private Color m_Color;

	[Token(Token = "0x4003EDE")]
	[FieldOffset(Offset = "0x30")]
	private string m_strPing;

	[Token(Token = "0x4003EDF")]
	[FieldOffset(Offset = "0x34")]
	private GUIStyle m_guiStyle;

	[Token(Token = "0x4003EE0")]
	[FieldOffset(Offset = "0x38")]
	private float m_fUpdateInterval;

	[Token(Token = "0x4003EE1")]
	[FieldOffset(Offset = "0x3C")]
	private float m_fLastInterval;

	[Token(Token = "0x4003EE2")]
	[FieldOffset(Offset = "0x40")]
	private int m_nFrames;

	[Token(Token = "0x600598E")]
	[Address(RVA = "0x190E9D8", Offset = "0x190E9D8", VA = "0x190E9D8")]
	public XUIPINGLabel()
	{
	}

	[Token(Token = "0x600598F")]
	[Address(RVA = "0x190EB20", Offset = "0x190EB20", VA = "0x190EB20")]
	private void Start()
	{
	}

	[Token(Token = "0x6005990")]
	[Address(RVA = "0x190EB48", Offset = "0x190EB48", VA = "0x190EB48")]
	private void Update()
	{
	}

	[Token(Token = "0x6005991")]
	[Address(RVA = "0x190F0BC", Offset = "0x190F0BC", VA = "0x190F0BC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005992")]
	[Address(RVA = "0x190F454", Offset = "0x190F454", VA = "0x190F454")]
	private void DoMyWindow(int nWindowID)
	{
	}
}
