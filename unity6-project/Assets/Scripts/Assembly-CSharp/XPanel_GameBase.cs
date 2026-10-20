using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D0D")]
public class XPanel_GameBase : MonoBehaviour
{
	[Token(Token = "0x400424D")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTime;

	[Token(Token = "0x400424E")]
	[FieldOffset(Offset = "0x10")]
	protected int m_time;

	[Token(Token = "0x6005F2A")]
	[Address(RVA = "0xFD0374", Offset = "0xFD0374", VA = "0xFD0374")]
	public XPanel_GameBase()
	{
	}

	[Token(Token = "0x6005F2B")]
	[Address(RVA = "0xFD037C", Offset = "0xFD037C", VA = "0xFD037C", Slot = "4")]
	protected virtual void RefreshTime()
	{
	}
}
