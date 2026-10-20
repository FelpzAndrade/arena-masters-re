using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200030B")]
public class OnJoinedInstantiate : MonoBehaviour
{
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0xC")]
	public Transform SpawnPosition;

	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x10")]
	public float PositionOffset;

	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x14")]
	public GameObject[] PrefabsToInstantiate;

	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x11E62F0", Offset = "0x11E62F0", VA = "0x11E62F0")]
	public OnJoinedInstantiate()
	{
	}

	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x11E6300", Offset = "0x11E6300", VA = "0x11E6300")]
	public void OnJoinedRoom()
	{
	}
}
