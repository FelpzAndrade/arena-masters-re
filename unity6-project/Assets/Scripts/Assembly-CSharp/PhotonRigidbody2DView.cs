using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EC")]
public class PhotonRigidbody2DView : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x4000F87")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private bool m_SynchronizeVelocity;

	[Token(Token = "0x4000F88")]
	[FieldOffset(Offset = "0xD")]
	[SerializeField]
	private bool m_SynchronizeAngularVelocity;

	[Token(Token = "0x4000F89")]
	[FieldOffset(Offset = "0x10")]
	private Rigidbody2D m_Body;

	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x1B9BD20", Offset = "0x1B9BD20", VA = "0x1B9BD20")]
	public PhotonRigidbody2DView()
	{
	}

	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x1B9BD30", Offset = "0x1B9BD30", VA = "0x1B9BD30")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x1B9BDB8", Offset = "0x1B9BDB8", VA = "0x1B9BDB8", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}
}
