using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000306")]
public class NetworkCullingHandler : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0xC")]
	private int orderIndex;

	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x10")]
	private CullArea cullArea;

	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x14")]
	private List<byte> previousActiveCells;

	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x18")]
	private List<byte> activeCells;

	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x1C")]
	private PhotonView pView;

	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 lastPosition;

	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 currentPosition;

	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x135E20C", Offset = "0x135E20C", VA = "0x135E20C")]
	public NetworkCullingHandler()
	{
	}

	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x135E214", Offset = "0x135E214", VA = "0x135E214")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x135E460", Offset = "0x135E460", VA = "0x135E460")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x135E5EC", Offset = "0x135E5EC", VA = "0x135E5EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x135ECA4", Offset = "0x135ECA4", VA = "0x135ECA4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x135E6A4", Offset = "0x135E6A4", VA = "0x135E6A4")]
	private bool HaveActiveCellsChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x135E91C", Offset = "0x135E91C", VA = "0x135E91C")]
	private void UpdateInterestGroups()
	{
	}

	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x135F294", Offset = "0x135F294", VA = "0x135F294", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
