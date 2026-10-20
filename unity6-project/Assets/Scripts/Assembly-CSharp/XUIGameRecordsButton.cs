using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D7A")]
public class XUIGameRecordsButton : MonoBehaviour
{
	[Token(Token = "0x4004581")]
	[FieldOffset(Offset = "0xC")]
	private Action<bool> onClickRecord;

	[Token(Token = "0x4004582")]
	[FieldOffset(Offset = "0x10")]
	private bool m_isEnable;

	[Token(Token = "0x60062E9")]
	[Address(RVA = "0x1A5BE04", Offset = "0x1A5BE04", VA = "0x1A5BE04")]
	public XUIGameRecordsButton()
	{
	}

	[Token(Token = "0x60062EA")]
	[Address(RVA = "0x1A5BE14", Offset = "0x1A5BE14", VA = "0x1A5BE14")]
	public void Build(bool enable, Action<bool> onClickRecord)
	{
	}

	[Token(Token = "0x60062EB")]
	[Address(RVA = "0x1A5BE60", Offset = "0x1A5BE60", VA = "0x1A5BE60")]
	public void SetEnable(bool isEnable)
	{
	}

	[Token(Token = "0x60062EC")]
	[Address(RVA = "0x1A5BE68", Offset = "0x1A5BE68", VA = "0x1A5BE68")]
	private void OnPress(bool isPressed)
	{
	}
}
