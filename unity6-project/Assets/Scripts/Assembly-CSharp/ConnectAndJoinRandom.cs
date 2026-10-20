using Il2CppDummyDll;
using Photon;

[Token(Token = "0x20002F9")]
public class ConnectAndJoinRandom : MonoBehaviour
{
	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x10")]
	public bool AutoConnect;

	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x11")]
	public byte Version;

	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x12")]
	private bool ConnectInUpdate;

	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x20CCBA4", Offset = "0x20CCBA4", VA = "0x20CCBA4")]
	public ConnectAndJoinRandom()
	{
	}

	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x20CCBBC", Offset = "0x20CCBBC", VA = "0x20CCBBC", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x20CCC60", Offset = "0x20CCC60", VA = "0x20CCC60", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x20CCE74", Offset = "0x20CCE74", VA = "0x20CCE74", Slot = "6")]
	public virtual void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x20CCF68", Offset = "0x20CCF68", VA = "0x20CCF68", Slot = "7")]
	public virtual void OnJoinedLobby()
	{
	}

	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x20CD05C", Offset = "0x20CD05C", VA = "0x20CD05C", Slot = "8")]
	public virtual void OnPhotonRandomJoinFailed()
	{
	}

	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x20CD1B0", Offset = "0x20CD1B0", VA = "0x20CD1B0", Slot = "9")]
	public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x20CD2DC", Offset = "0x20CD2DC", VA = "0x20CD2DC")]
	public void OnJoinedRoom()
	{
	}
}
