using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C4F")]
public class XPanel_Message : MonoBehaviour
{
	[Token(Token = "0x4003E5D")]
	[FieldOffset(Offset = "0xC")]
	public GameObject panel;

	[Token(Token = "0x4003E5E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblMessage;

	[Token(Token = "0x4003E5F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite sprBg;

	[Token(Token = "0x4003E60")]
	[FieldOffset(Offset = "0x18")]
	private float m_durationTime;

	[Token(Token = "0x600590D")]
	[Address(RVA = "0x10066E0", Offset = "0x10066E0", VA = "0x10066E0")]
	public XPanel_Message()
	{
	}

	[Token(Token = "0x600590E")]
	[Address(RVA = "0x10066E8", Offset = "0x10066E8", VA = "0x10066E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600590F")]
	[Address(RVA = "0x1006720", Offset = "0x1006720", VA = "0x1006720")]
	private void Update()
	{
	}

	[Token(Token = "0x6005910")]
	[Address(RVA = "0x10067A0", Offset = "0x10067A0", VA = "0x10067A0")]
	public void ShowBottom(string text, float durationtime)
	{
	}

	[Token(Token = "0x6005911")]
	[Address(RVA = "0x1006770", Offset = "0x1006770", VA = "0x1006770")]
	private void UpdateBottom(float delta)
	{
	}

	[Token(Token = "0x6005912")]
	[Address(RVA = "0x10066EC", Offset = "0x10066EC", VA = "0x10066EC")]
	public void Hide()
	{
	}
}
