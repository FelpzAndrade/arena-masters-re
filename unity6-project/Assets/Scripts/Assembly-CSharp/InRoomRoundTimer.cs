using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000300")]
public class InRoomRoundTimer : MonoBehaviour
{
	[Token(Token = "0x4000FF7")]
	private const string StartTimeKey = "st";

	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0xC")]
	public int SecondsPerTurn;

	[Token(Token = "0x4000FF9")]
	[FieldOffset(Offset = "0x10")]
	public double StartTime;

	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x18")]
	public Rect TextPos;

	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0x28")]
	private bool startRoundWhenTimeIsSynced;

	[Token(Token = "0x6001A18")]
	[Address(RVA = "0xD8C5B8", Offset = "0xD8C5B8", VA = "0xD8C5B8")]
	public InRoomRoundTimer()
	{
	}

	[Token(Token = "0x6001A19")]
	[Address(RVA = "0xD8C630", Offset = "0xD8C630", VA = "0xD8C630")]
	private void StartRoundNow()
	{
	}

	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0xD8C800", Offset = "0xD8C800", VA = "0xD8C800")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0xD8CA0C", Offset = "0xD8CA0C", VA = "0xD8CA0C")]
	public void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
	{
	}

	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0xD8CAFC", Offset = "0xD8CAFC", VA = "0xD8CAFC")]
	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0xD8CC64", Offset = "0xD8CC64", VA = "0xD8CC64")]
	private void Update()
	{
	}

	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0xD8CC74", Offset = "0xD8CC74", VA = "0xD8CC74")]
	public void OnGUI()
	{
	}
}
