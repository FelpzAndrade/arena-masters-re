using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002CE")]
public class PhotonLagSimulationGui : MonoBehaviour
{
	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0xC")]
	public Rect WindowRect;

	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x1C")]
	public int WindowId;

	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0x20")]
	public bool Visible;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x24")]
	private PhotonPeer Peer__BackingField;

	[Token(Token = "0x1700040D")]
	public PhotonPeer Peer
	{
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x1B8799C", Offset = "0x1B8799C", VA = "0x1B8799C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x1B879A4", Offset = "0x1B879A4", VA = "0x1B879A4")]
		set
		{
		}
	}

	[Token(Token = "0x6001846")]
	[Address(RVA = "0x1B87924", Offset = "0x1B87924", VA = "0x1B87924")]
	public PhotonLagSimulationGui()
	{
	}

	[Token(Token = "0x6001849")]
	[Address(RVA = "0x1B879AC", Offset = "0x1B879AC", VA = "0x1B879AC")]
	public void Start()
	{
	}

	[Token(Token = "0x600184A")]
	[Address(RVA = "0x1B87A64", Offset = "0x1B87A64", VA = "0x1B87A64")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x600184B")]
	[Address(RVA = "0x1B87C5C", Offset = "0x1B87C5C", VA = "0x1B87C5C")]
	private void NetSimHasNoPeerWindow(int windowId)
	{
	}

	[Token(Token = "0x600184C")]
	[Address(RVA = "0x1B87D0C", Offset = "0x1B87D0C", VA = "0x1B87D0C")]
	private void NetSimWindow(int windowId)
	{
	}
}
