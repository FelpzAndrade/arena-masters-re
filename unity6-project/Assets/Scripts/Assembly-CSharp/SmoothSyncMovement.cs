using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000320")]
public class SmoothSyncMovement : Photon.MonoBehaviour, IPunObservable
{
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x10")]
	public float SmoothingDelay;

	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 correctPlayerPos;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x20")]
	private Quaternion correctPlayerRot;

	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x21041C8", Offset = "0x21041C8", VA = "0x21041C8")]
	public SmoothSyncMovement()
	{
	}

	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x210423C", Offset = "0x210423C", VA = "0x210423C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x210457C", Offset = "0x210457C", VA = "0x210457C", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x2104740", Offset = "0x2104740", VA = "0x2104740")]
	public void Update()
	{
	}
}
