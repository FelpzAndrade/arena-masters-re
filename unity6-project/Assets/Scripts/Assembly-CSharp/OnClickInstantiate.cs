using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200030A")]
public class OnClickInstantiate : MonoBehaviour
{
	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Prefab;

	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x10")]
	public int InstantiateType;

	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x14")]
	private string[] InstantiateTypeNames;

	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x18")]
	public bool showGui;

	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x11E5D58", Offset = "0x11E5D58", VA = "0x11E5D58")]
	public OnClickInstantiate()
	{
	}

	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x11E5EF0", Offset = "0x11E5EF0", VA = "0x11E5EF0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x11E61BC", Offset = "0x11E61BC", VA = "0x11E61BC")]
	private void OnGUI()
	{
	}
}
