using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000316")]
public class PunTeams : MonoBehaviour
{
	[Token(Token = "0x2000317")]
	public enum Team : byte
	{
		[Token(Token = "0x400103C")]
		none = 0,
		[Token(Token = "0x400103D")]
		red = 1,
		[Token(Token = "0x400103E")]
		blue = 2
	}

	[Token(Token = "0x4001039")]
	public const string TeamPlayerProp = "team";

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<Team, List<PhotonPlayer>> PlayersPerTeam;

	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x20E7CD8", Offset = "0x20E7CD8", VA = "0x20E7CD8")]
	public PunTeams()
	{
	}

	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x20E7CE0", Offset = "0x20E7CE0", VA = "0x20E7CE0")]
	public void Start()
	{
	}

	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x20E8148", Offset = "0x20E8148", VA = "0x20E8148")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x20E81F8", Offset = "0x20E81F8", VA = "0x20E81F8")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x20E8754", Offset = "0x20E8754", VA = "0x20E8754")]
	public void OnLeftRoom()
	{
	}

	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x20E8758", Offset = "0x20E8758", VA = "0x20E8758")]
	public void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
	{
	}

	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x20E875C", Offset = "0x20E875C", VA = "0x20E875C")]
	public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
	{
	}

	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x20E8760", Offset = "0x20E8760", VA = "0x20E8760")]
	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
	{
	}

	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x20E81FC", Offset = "0x20E81FC", VA = "0x20E81FC")]
	public void UpdateTeams()
	{
	}
}
