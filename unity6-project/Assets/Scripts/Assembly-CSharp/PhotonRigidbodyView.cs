using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002ED")]
public class PhotonRigidbodyView : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private bool m_SynchronizeVelocity;

	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0xD")]
	[SerializeField]
	private bool m_SynchronizeAngularVelocity;

	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x10")]
	private Rigidbody m_Body;

	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x1B9BF90", Offset = "0x1B9BF90", VA = "0x1B9BF90")]
	public PhotonRigidbodyView()
	{
	}

	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x1B9BFA0", Offset = "0x1B9BFA0", VA = "0x1B9BFA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x1B9C028", Offset = "0x1B9C028", VA = "0x1B9C028", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
