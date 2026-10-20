using System.Collections.Generic;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000310")]
public class PickupItem : Photon.MonoBehaviour, IPunObservable
{
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x10")]
	public float SecondsBeforeRespawn;

	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x14")]
	public bool PickupOnTrigger;

	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x15")]
	public bool PickupIsMine;

	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x18")]
	public UnityEngine.MonoBehaviour OnPickedUpCall;

	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0x1C")]
	public bool SentPickup;

	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x20")]
	public double TimeOfRespawn;

	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x0")]
	public static HashSet<PickupItem> DisabledPickupItems;

	[Token(Token = "0x17000489")]
	public int ViewID
	{
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x1BA4EEC", Offset = "0x1BA4EEC", VA = "0x1BA4EEC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x1BA4E2C", Offset = "0x1BA4E2C", VA = "0x1BA4E2C")]
	public PickupItem()
	{
	}

	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x1BA4F10", Offset = "0x1BA4F10", VA = "0x1BA4F10")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001A70")]
	[Address(RVA = "0x1BA5124", Offset = "0x1BA5124", VA = "0x1BA5124", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6001A71")]
	[Address(RVA = "0x1BA5034", Offset = "0x1BA5034", VA = "0x1BA5034")]
	public void Pickup()
	{
	}

	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x1BA52A0", Offset = "0x1BA52A0", VA = "0x1BA52A0")]
	public void Drop()
	{
	}

	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x1BA5388", Offset = "0x1BA5388", VA = "0x1BA5388")]
	public void Drop(Vector3 newPosition)
	{
	}

	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x1BA54F8", Offset = "0x1BA54F8", VA = "0x1BA54F8")]
	[PunRPC]
	public void PunPickup(PhotonMessageInfo msgInfo)
	{
	}

	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x1BA5B50", Offset = "0x1BA5B50", VA = "0x1BA5B50")]
	internal void PickedUp(float timeUntilRespawn)
	{
	}

	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x1BA5D00", Offset = "0x1BA5D00", VA = "0x1BA5D00")]
	[PunRPC]
	internal void PunRespawn(Vector3 pos)
	{
	}

	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x1BA5E24", Offset = "0x1BA5E24", VA = "0x1BA5E24")]
	[PunRPC]
	internal void PunRespawn()
	{
	}
}
