using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000350")]
public class TankTranslator : MonoBehaviour
{
	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0xC")]
	public float TranslateDistance;

	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x10")]
	public bool TrailTranslationEnabled;

	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x1D4AAB8", Offset = "0x1D4AAB8", VA = "0x1D4AAB8")]
	public TankTranslator()
	{
	}

	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x1D4AAC0", Offset = "0x1D4AAC0", VA = "0x1D4AAC0")]
	private void Update()
	{
	}
}
