using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002C")]
public class GConsoleUIBinding : MonoBehaviour
{
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0xC")]
	public KeyCode consoleOpenKey;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x10")]
	public GameObject consoleGameObject;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1F335C8", Offset = "0x1F335C8", VA = "0x1F335C8")]
	public GConsoleUIBinding()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1F335D8", Offset = "0x1F335D8", VA = "0x1F335D8")]
	private void Update()
	{
	}
}
