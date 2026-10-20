using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x2000526")]
public class JailKeyTrigger : Photon.MonoBehaviour
{
	[Token(Token = "0x40019FF")]
	[FieldOffset(Offset = "0x10")]
	public float respawnTime;

	[Token(Token = "0x4001A00")]
	[FieldOffset(Offset = "0x14")]
	public float elapsed;

	[Token(Token = "0x4001A01")]
	[FieldOffset(Offset = "0x18")]
	public Collider bound;

	[Token(Token = "0x4001A02")]
	[FieldOffset(Offset = "0x1C")]
	private XModuleEntity _key;

	[Token(Token = "0x4001A03")]
	[FieldOffset(Offset = "0x20")]
	private bool sendedRpc;

	[Token(Token = "0x170006DC")]
	public XModuleEntity key
	{
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0xDCDC20", Offset = "0xDCDC20", VA = "0xDCDC20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C16")]
	[Address(RVA = "0xDCDC0C", Offset = "0xDCDC0C", VA = "0xDCDC0C")]
	public JailKeyTrigger()
	{
	}

	[Token(Token = "0x6002C18")]
	[Address(RVA = "0xDCDE3C", Offset = "0xDCDE3C", VA = "0xDCDE3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C19")]
	[Address(RVA = "0xDCE05C", Offset = "0xDCE05C", VA = "0xDCE05C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002C1A")]
	[Address(RVA = "0xDCE2F8", Offset = "0xDCE2F8", VA = "0xDCE2F8")]
	private void OpenJail()
	{
	}

	[Token(Token = "0x6002C1B")]
	[Address(RVA = "0xDCE3E0", Offset = "0xDCE3E0", VA = "0xDCE3E0")]
	[PunRPC]
	private void _OpenJail(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002C1C")]
	[Address(RVA = "0xDCDF60", Offset = "0xDCDF60", VA = "0xDCDF60")]
	public void ReqResetJailKey()
	{
	}

	[Token(Token = "0x6002C1D")]
	[Address(RVA = "0xDCEF9C", Offset = "0xDCEF9C", VA = "0xDCEF9C")]
	[PunRPC]
	private void _ResetJailKey(PhotonMessageInfo mi)
	{
	}

	[Token(Token = "0x6002C1E")]
	[Address(RVA = "0xDCEFAC", Offset = "0xDCEFAC", VA = "0xDCEFAC")]
	public void ResetJailKey()
	{
	}

	[Token(Token = "0x6002C1F")]
	[Address(RVA = "0xDCECD8", Offset = "0xDCECD8", VA = "0xDCECD8")]
	private void EnableKey(bool b)
	{
	}
}
