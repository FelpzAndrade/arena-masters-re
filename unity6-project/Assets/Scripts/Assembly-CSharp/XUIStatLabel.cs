using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6C")]
public class XUIStatLabel : MonoBehaviour
{
	[Token(Token = "0x4003EF9")]
	[FieldOffset(Offset = "0xC")]
	public Rect StatStartRect;

	[Token(Token = "0x4003EFA")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 m_scrollPos;

	[Token(Token = "0x4003EFB")]
	[FieldOffset(Offset = "0x24")]
	public bool m_bAllowDrag;

	[Token(Token = "0x4003EFC")]
	[FieldOffset(Offset = "0x28")]
	private Color m_Color;

	[Token(Token = "0x4003EFD")]
	[FieldOffset(Offset = "0x38")]
	private string m_strStat;

	[Token(Token = "0x4003EFE")]
	[FieldOffset(Offset = "0x3C")]
	private GUIStyle m_guiStyle;

	[Token(Token = "0x4003EFF")]
	[FieldOffset(Offset = "0x40")]
	private float m_fUpdateInterval;

	[Token(Token = "0x4003F00")]
	[FieldOffset(Offset = "0x44")]
	private float m_fLastInterval;

	[Token(Token = "0x4003F01")]
	[FieldOffset(Offset = "0x48")]
	private int m_nFrames;

	[Token(Token = "0x4003F02")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_myPlayer;

	[Token(Token = "0x4003F03")]
	[FieldOffset(Offset = "0x50")]
	private XModuleEntity m_myPlayerEntity;

	[Token(Token = "0x60059A9")]
	[Address(RVA = "0x1931FE4", Offset = "0x1931FE4", VA = "0x1931FE4")]
	public XUIStatLabel()
	{
	}

	[Token(Token = "0x60059AA")]
	[Address(RVA = "0x1932104", Offset = "0x1932104", VA = "0x1932104")]
	private void Start()
	{
	}

	[Token(Token = "0x60059AB")]
	[Address(RVA = "0x193212C", Offset = "0x193212C", VA = "0x193212C")]
	private void Update()
	{
	}

	[Token(Token = "0x60059AC")]
	[Address(RVA = "0x1932984", Offset = "0x1932984", VA = "0x1932984")]
	private bool IsEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60059AD")]
	[Address(RVA = "0x1932AE4", Offset = "0x1932AE4", VA = "0x1932AE4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60059AE")]
	[Address(RVA = "0x1932D84", Offset = "0x1932D84", VA = "0x1932D84")]
	private void DoMyWindow(int nWindowID)
	{
	}
}
