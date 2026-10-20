using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000322")]
public class SupportLogging : MonoBehaviour
{
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0xC")]
	public bool LogTrafficStats;

	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x1D48030", Offset = "0x1D48030", VA = "0x1D48030")]
	public SupportLogging()
	{
	}

	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x1D48038", Offset = "0x1D48038", VA = "0x1D48038")]
	public void Start()
	{
	}

	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x1D480E4", Offset = "0x1D480E4", VA = "0x1D480E4")]
	protected void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x1D48404", Offset = "0x1D48404", VA = "0x1D48404")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x1D4840C", Offset = "0x1D4840C", VA = "0x1D4840C")]
	public void LogStats()
	{
	}

	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x1D48564", Offset = "0x1D48564", VA = "0x1D48564")]
	private void LogBasics()
	{
	}

	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x1D4886C", Offset = "0x1D4886C", VA = "0x1D4886C")]
	public void OnConnectedToPhoton()
	{
	}

	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x1D48984", Offset = "0x1D48984", VA = "0x1D48984")]
	public void OnFailedToConnectToPhoton(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x1D48AC8", Offset = "0x1D48AC8", VA = "0x1D48AC8")]
	public void OnJoinedLobby()
	{
	}

	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x1D48C2C", Offset = "0x1D48C2C", VA = "0x1D48C2C")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x1D48FD0", Offset = "0x1D48FD0", VA = "0x1D48FD0")]
	public void OnCreatedRoom()
	{
	}

	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x1D49374", Offset = "0x1D49374", VA = "0x1D49374")]
	public void OnLeftRoom()
	{
	}

	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x1D49430", Offset = "0x1D49430", VA = "0x1D49430")]
	public void OnDisconnectedFromPhoton()
	{
	}
}
