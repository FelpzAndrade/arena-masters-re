using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D93")]
public class XButtonDelegator : MonoBehaviour
{
	[Token(Token = "0x2000D94")]
	public delegate void ClickDelegate(GameObject gameObject);

	[Token(Token = "0x4004683")]
	[FieldOffset(Offset = "0xC")]
	public ClickDelegate m_ClickDelegate;

	[Token(Token = "0x60063C3")]
	[Address(RVA = "0x1A9A0C8", Offset = "0x1A9A0C8", VA = "0x1A9A0C8")]
	public XButtonDelegator()
	{
	}

	[Token(Token = "0x60063C4")]
	[Address(RVA = "0x1A9A0D0", Offset = "0x1A9A0D0", VA = "0x1A9A0D0")]
	public void OnClick()
	{
	}
}
