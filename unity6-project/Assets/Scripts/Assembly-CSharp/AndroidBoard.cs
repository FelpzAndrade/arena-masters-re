using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE6")]
internal class AndroidBoard : IBoard
{
	[Token(Token = "0x4003C42")]
	[FieldOffset(Offset = "0x8")]
	private AndroidJavaClass cb;

	[Token(Token = "0x60055FF")]
	[Address(RVA = "0x20BB25C", Offset = "0x20BB25C", VA = "0x20BB25C")]
	public AndroidBoard()
	{
	}

	[Token(Token = "0x6005600")]
	[Address(RVA = "0x20BB30C", Offset = "0x20BB30C", VA = "0x20BB30C", Slot = "4")]
	public void SetText(string str)
	{
	}

	[Token(Token = "0x6005601")]
	[Address(RVA = "0x20BB4D4", Offset = "0x20BB4D4", VA = "0x20BB4D4", Slot = "5")]
	public string GetText()
	{
		return null;
	}
}
