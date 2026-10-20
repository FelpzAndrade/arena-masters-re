using Il2CppDummyDll;
using Photon;

[Token(Token = "0x2000312")]
public class PickupItemSyncer : MonoBehaviour
{
	[Token(Token = "0x4001036")]
	private const float TimeDeltaToIgnore = 0.2f;

	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x10")]
	public bool IsWaitingForPickupInit;

	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x1BA651C", Offset = "0x1BA651C", VA = "0x1BA651C")]
	public PickupItemSyncer()
	{
	}

	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x1BA6524", Offset = "0x1BA6524", VA = "0x1BA6524")]
	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
	{
	}

	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x1BA7294", Offset = "0x1BA7294", VA = "0x1BA7294")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x1BA7620", Offset = "0x1BA7620", VA = "0x1BA7620")]
	public void AskForPickupItemSpawnTimes()
	{
	}

	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x1BA7940", Offset = "0x1BA7940", VA = "0x1BA7940")]
	[PunRPC]
	public void RequestForPickupTimes(PhotonMessageInfo msgInfo)
	{
	}

	[Token(Token = "0x6001A82")]
	[Address(RVA = "0x1BA7958", Offset = "0x1BA7958", VA = "0x1BA7958")]
	[PunRPC]
	public void RequestForPickupItems(PhotonMessageInfo msgInfo)
	{
	}

	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x1BA65D8", Offset = "0x1BA65D8", VA = "0x1BA65D8")]
	private void SendPickedUpItems(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x1BA7A34", Offset = "0x1BA7A34", VA = "0x1BA7A34")]
	[PunRPC]
	public void PickupItemInit(double timeBase, float[] inactivePickupsAndTimes)
	{
	}
}
