using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CEE")]
public class XUIMessageBarDesc : MonoBehaviour
{
	[Token(Token = "0x40041ED")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_Sprite;

	[Token(Token = "0x40041EE")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_Label;

	[Token(Token = "0x40041EF")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite m_IconSprite;

	[Token(Token = "0x40041F0")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_effectRoot;

	[Token(Token = "0x40041F1")]
	[FieldOffset(Offset = "0x1C")]
	private XUIMessageBarKillEffect m_SpriteKill;

	[Token(Token = "0x40041F2")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 labelInitPos_;

	[Token(Token = "0x40041F3")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 iconInitPos_;

	[Token(Token = "0x40041F4")]
	[FieldOffset(Offset = "0x38")]
	private UISprite textBgSprite_;

	[Token(Token = "0x6005D58")]
	[Address(RVA = "0x10B6E6C", Offset = "0x10B6E6C", VA = "0x10B6E6C")]
	public XUIMessageBarDesc()
	{
	}

	[Token(Token = "0x6005D59")]
	[Address(RVA = "0x10B6E74", Offset = "0x10B6E74", VA = "0x10B6E74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005D5A")]
	[Address(RVA = "0x10B6A10", Offset = "0x10B6A10", VA = "0x10B6A10")]
	public void ShowMessageBar(XMessageBarNode node)
	{
	}

	[Token(Token = "0x6005D5B")]
	[Address(RVA = "0x10B7088", Offset = "0x10B7088", VA = "0x10B7088")]
	private void SetText(string strText)
	{
	}

	[Token(Token = "0x6005D5C")]
	[Address(RVA = "0x10B7190", Offset = "0x10B7190", VA = "0x10B7190")]
	private void SetTextBackground(bool isIcon)
	{
	}

	[Token(Token = "0x6005D5D")]
	[Address(RVA = "0x10B74F8", Offset = "0x10B74F8", VA = "0x10B74F8")]
	private void HideSpriteKill()
	{
	}

	[Token(Token = "0x6005D5E")]
	[Address(RVA = "0x10B6984", Offset = "0x10B6984", VA = "0x10B6984")]
	public void HideMessageBar()
	{
	}
}
