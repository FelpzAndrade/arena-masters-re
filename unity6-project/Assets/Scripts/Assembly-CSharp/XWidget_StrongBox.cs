using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D49")]
public class XWidget_StrongBox : MonoBehaviour, IStrongBoxEventReciver
{
	[Token(Token = "0x4004458")]
	[FieldOffset(Offset = "0xC")]
	public UISprite occupied;

	[Token(Token = "0x6006196")]
	[Address(RVA = "0x1B119A4", Offset = "0x1B119A4", VA = "0x1B119A4")]
	public XWidget_StrongBox()
	{
	}

	[Token(Token = "0x6006197")]
	[Address(RVA = "0x1B119AC", Offset = "0x1B119AC", VA = "0x1B119AC", Slot = "4")]
	public void OnAccumulate(float percent)
	{
	}
}
