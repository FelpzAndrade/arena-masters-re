using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000024")]
public class GConsoleSuggestionDemonstration : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0xC")]
	private string[] phoneyCommands;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x10")]
	private string[] phoneyDescriptions;

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1F32BE4", Offset = "0x1F32BE4", VA = "0x1F32BE4")]
	public GConsoleSuggestionDemonstration()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1F333C8", Offset = "0x1F333C8", VA = "0x1F333C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1F33550", Offset = "0x1F33550", VA = "0x1F33550")]
	private string PhoneyCommand(string param)
	{
		return null;
	}
}
