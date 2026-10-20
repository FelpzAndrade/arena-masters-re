using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C5D")]
public class XUIFPSLabel : MonoBehaviour
{
	[Token(Token = "0x4003EA1")]
	[FieldOffset(Offset = "0xC")]
	public Rect startRect;

	[Token(Token = "0x4003EA2")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_bUpdateColor;

	[Token(Token = "0x4003EA3")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_bAllowDrag;

	[Token(Token = "0x4003EA4")]
	[FieldOffset(Offset = "0x20")]
	private Color m_Color;

	[Token(Token = "0x4003EA5")]
	[FieldOffset(Offset = "0x30")]
	private string m_strFPS;

	[Token(Token = "0x4003EA6")]
	[FieldOffset(Offset = "0x34")]
	private GUIStyle m_guiStyle;

	[Token(Token = "0x4003EA7")]
	[FieldOffset(Offset = "0x38")]
	private float m_fUpdateInterval;

	[Token(Token = "0x4003EA8")]
	[FieldOffset(Offset = "0x3C")]
	private float m_fLastInterval;

	[Token(Token = "0x4003EA9")]
	[FieldOffset(Offset = "0x40")]
	private int m_nFrames;

	[Token(Token = "0x6005953")]
	[Address(RVA = "0x1A45E18", Offset = "0x1A45E18", VA = "0x1A45E18")]
	public XUIFPSLabel()
	{
	}

	[Token(Token = "0x6005954")]
	[Address(RVA = "0x1A45F60", Offset = "0x1A45F60", VA = "0x1A45F60")]
	private void Start()
	{
	}

	[Token(Token = "0x6005955")]
	[Address(RVA = "0x1A45F88", Offset = "0x1A45F88", VA = "0x1A45F88")]
	private void Update()
	{
	}

	[Token(Token = "0x6005956")]
	[Address(RVA = "0x1A46290", Offset = "0x1A46290", VA = "0x1A46290")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005957")]
	[Address(RVA = "0x1A46628", Offset = "0x1A46628", VA = "0x1A46628")]
	private void DoMyWindow(int nWindowID)
	{
	}
}
