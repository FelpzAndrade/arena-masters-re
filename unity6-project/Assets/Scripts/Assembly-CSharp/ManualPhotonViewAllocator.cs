using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000304")]
public class ManualPhotonViewAllocator : MonoBehaviour
{
	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Prefab;

	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x135AAF4", Offset = "0x135AAF4", VA = "0x135AAF4")]
	public ManualPhotonViewAllocator()
	{
	}

	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x135AAFC", Offset = "0x135AAFC", VA = "0x135AAFC")]
	public void AllocateManualPhotonView()
	{
	}

	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x135ADA8", Offset = "0x135ADA8", VA = "0x135ADA8")]
	[PunRPC]
	public void InstantiateRpc(int viewID)
	{
	}
}
