using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AB")]
public class ExampleDragDropItem : UIDragDropItem
{
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject prefab;

	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x1E75EE4", Offset = "0x1E75EE4", VA = "0x1E75EE4")]
	public ExampleDragDropItem()
	{
	}

	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x1E75F88", Offset = "0x1E75F88", VA = "0x1E75F88", Slot = "17")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}
}
