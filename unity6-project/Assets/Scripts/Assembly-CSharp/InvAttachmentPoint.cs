using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019D")]
public class InvAttachmentPoint : MonoBehaviour
{
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0xC")]
	public InvBaseItem.Slot slot;

	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x10")]
	private GameObject mPrefab;

	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x14")]
	private GameObject mChild;

	[Token(Token = "0x6000E80")]
	[Address(RVA = "0xD8F2E4", Offset = "0xD8F2E4", VA = "0xD8F2E4")]
	public InvAttachmentPoint()
	{
	}

	[Token(Token = "0x6000E81")]
	[Address(RVA = "0xD8F2EC", Offset = "0xD8F2EC", VA = "0xD8F2EC")]
	public GameObject Attach(GameObject prefab)
	{
		return null;
	}
}
