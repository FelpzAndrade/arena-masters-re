using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C51")]
public class XPanel_NotiBox : MonoBehaviour
{
	[Token(Token = "0x4003E61")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_lblMessage;

	[Token(Token = "0x4003E62")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite m_sptBg;

	[Token(Token = "0x4003E63")]
	[FieldOffset(Offset = "0x14")]
	public float m_fRemainShowTime;

	[Token(Token = "0x6005916")]
	[Address(RVA = "0x100BEB0", Offset = "0x100BEB0", VA = "0x100BEB0")]
	public XPanel_NotiBox()
	{
	}

	[Token(Token = "0x6005917")]
	[Address(RVA = "0x100BEB8", Offset = "0x100BEB8", VA = "0x100BEB8")]
	public void Update()
	{
	}

	[Token(Token = "0x6005918")]
	[Address(RVA = "0x100BF38", Offset = "0x100BF38", VA = "0x100BF38")]
	public void Show(string text = "", float durationtime = 2f)
	{
	}

	[Token(Token = "0x6005919")]
	[Address(RVA = "0x100C13C", Offset = "0x100C13C", VA = "0x100C13C")]
	public void Hide()
	{
	}

	[Token(Token = "0x600591A")]
	[Address(RVA = "0x100BF08", Offset = "0x100BF08", VA = "0x100BF08")]
	private void UpdateUI(float fDeltaTime)
	{
	}
}
