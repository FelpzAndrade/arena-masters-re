using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000311")]
public class PickupItemSimple : Photon.MonoBehaviour
{
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x10")]
	public float SecondsBeforeRespawn;

	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x14")]
	public bool PickupOnCollide;

	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x15")]
	public bool SentPickup;

	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x1BA5F98", Offset = "0x1BA5F98", VA = "0x1BA5F98")]
	public PickupItemSimple()
	{
	}

	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x1BA5FA8", Offset = "0x1BA5FA8", VA = "0x1BA5FA8")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x1BA60CC", Offset = "0x1BA60CC", VA = "0x1BA60CC")]
	public void Pickup()
	{
	}

	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x1BA61C0", Offset = "0x1BA61C0", VA = "0x1BA61C0")]
	[PunRPC]
	public void PunPickupSimple(PhotonMessageInfo msgInfo)
	{
	}

	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x1BA642C", Offset = "0x1BA642C", VA = "0x1BA642C")]
	public void RespawnAfter()
	{
	}
}
