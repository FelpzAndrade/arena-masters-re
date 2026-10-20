using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C5C")]
public class XUIELOLabel : MonoBehaviour
{
	[Token(Token = "0x4003E98")]
	[FieldOffset(Offset = "0xC")]
	public Rect ELOStartRect;

	[Token(Token = "0x4003E99")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_bUpdateColor;

	[Token(Token = "0x4003E9A")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_bAllowDrag;

	[Token(Token = "0x4003E9B")]
	[FieldOffset(Offset = "0x20")]
	private Color m_Color;

	[Token(Token = "0x4003E9C")]
	[FieldOffset(Offset = "0x30")]
	private string m_strELO;

	[Token(Token = "0x4003E9D")]
	[FieldOffset(Offset = "0x34")]
	private GUIStyle m_guiStyle;

	[Token(Token = "0x4003E9E")]
	[FieldOffset(Offset = "0x38")]
	private float m_fUpdateInterval;

	[Token(Token = "0x4003E9F")]
	[FieldOffset(Offset = "0x3C")]
	private float m_fLastInterval;

	[Token(Token = "0x4003EA0")]
	[FieldOffset(Offset = "0x40")]
	private int m_nFrames;

	[Token(Token = "0x600594E")]
	[Address(RVA = "0x1A3CA5C", Offset = "0x1A3CA5C", VA = "0x1A3CA5C")]
	public XUIELOLabel()
	{
	}

	[Token(Token = "0x600594F")]
	[Address(RVA = "0x1A3CBA4", Offset = "0x1A3CBA4", VA = "0x1A3CBA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6005950")]
	[Address(RVA = "0x1A3CBCC", Offset = "0x1A3CBCC", VA = "0x1A3CBCC")]
	private void Update()
	{
	}

	[Token(Token = "0x6005951")]
	[Address(RVA = "0x1A3DE1C", Offset = "0x1A3DE1C", VA = "0x1A3DE1C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005952")]
	[Address(RVA = "0x1A3E1B4", Offset = "0x1A3E1B4", VA = "0x1A3E1B4")]
	private void DoMyWindow(int nWindowID)
	{
	}
}
