using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C8C")]
public class XWidget_Notification : MonoBehaviour
{
	[Token(Token = "0x4003FDE")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblMessage;

	[Token(Token = "0x4003FDF")]
	[FieldOffset(Offset = "0x10")]
	public UIPanel m_panel;

	[Token(Token = "0x4003FE0")]
	[FieldOffset(Offset = "0x14")]
	public UITweener[] tween;

	[Token(Token = "0x4003FE1")]
	[FieldOffset(Offset = "0x18")]
	private float m_elapsed;

	[Token(Token = "0x6005AA5")]
	[Address(RVA = "0x1301950", Offset = "0x1301950", VA = "0x1301950")]
	public XWidget_Notification()
	{
	}

	[Token(Token = "0x6005AA6")]
	[Address(RVA = "0x1301958", Offset = "0x1301958", VA = "0x1301958")]
	public void Show(string message, float duration, float positionY = 0f)
	{
	}

	[Token(Token = "0x6005AA7")]
	[Address(RVA = "0x1301B98", Offset = "0x1301B98", VA = "0x1301B98")]
	public void Show(string message, Color color, float duration, float positionY = 0f)
	{
	}

	[Token(Token = "0x6005AA8")]
	[Address(RVA = "0x13019D4", Offset = "0x13019D4", VA = "0x13019D4")]
	public void ShowMessage(string message, float duration, float positionY = 0f)
	{
	}

	[Token(Token = "0x6005AA9")]
	[Address(RVA = "0x1301C14", Offset = "0x1301C14", VA = "0x1301C14")]
	public void Hide()
	{
	}
}
