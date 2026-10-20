using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20002DF")]
public class ServerSettings : ScriptableObject
{
	[Token(Token = "0x20002E0")]
	public enum HostingOption
	{
		[Token(Token = "0x4000F63")]
		NotSet = 0,
		[Token(Token = "0x4000F64")]
		PhotonCloud = 1,
		[Token(Token = "0x4000F65")]
		SelfHosted = 2,
		[Token(Token = "0x4000F66")]
		OfflineMode = 3,
		[Token(Token = "0x4000F67")]
		BestRegion = 4
	}

	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0xC")]
	public string AppID;

	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x10")]
	public string VoiceAppID;

	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x14")]
	public string ChatAppID;

	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x18")]
	public HostingOption HostType;

	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x1C")]
	public CloudRegionCode PreferredRegion;

	[Token(Token = "0x4000F56")]
	[FieldOffset(Offset = "0x20")]
	public CloudRegionFlag EnabledRegions;

	[Token(Token = "0x4000F57")]
	[FieldOffset(Offset = "0x24")]
	public ConnectionProtocol Protocol;

	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x28")]
	public string ServerAddress;

	[Token(Token = "0x4000F59")]
	[FieldOffset(Offset = "0x2C")]
	public int ServerPort;

	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x30")]
	public int VoiceServerPort;

	[Token(Token = "0x4000F5B")]
	[FieldOffset(Offset = "0x34")]
	public bool JoinLobby;

	[Token(Token = "0x4000F5C")]
	[FieldOffset(Offset = "0x35")]
	public bool EnableLobbyStatistics;

	[Token(Token = "0x4000F5D")]
	[FieldOffset(Offset = "0x38")]
	public PhotonLogLevel PunLogging;

	[Token(Token = "0x4000F5E")]
	[FieldOffset(Offset = "0x3C")]
	public DebugLevel NetworkLogging;

	[Token(Token = "0x4000F5F")]
	[FieldOffset(Offset = "0x3D")]
	public bool RunInBackground;

	[Token(Token = "0x4000F60")]
	[FieldOffset(Offset = "0x40")]
	public List<string> RpcList;

	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public bool DisableAutoOpenWizard;

	[Token(Token = "0x1700047A")]
	public static CloudRegionCode BestRegionCodeInPreferences
	{
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x20EFF80", Offset = "0x20EFF80", VA = "0x20EFF80")]
		get
		{
			return default(CloudRegionCode);
		}
	}

	[Token(Token = "0x6001999")]
	[Address(RVA = "0x20EFC18", Offset = "0x20EFC18", VA = "0x20EFC18")]
	public ServerSettings()
	{
	}

	[Token(Token = "0x600199A")]
	[Address(RVA = "0x20EFD6C", Offset = "0x20EFD6C", VA = "0x20EFD6C")]
	public void UseCloudBestRegion(string cloudAppid)
	{
	}

	[Token(Token = "0x600199B")]
	[Address(RVA = "0x20EFD7C", Offset = "0x20EFD7C", VA = "0x20EFD7C")]
	public void UseCloud(string cloudAppid)
	{
	}

	[Token(Token = "0x600199C")]
	[Address(RVA = "0x20EFD8C", Offset = "0x20EFD8C", VA = "0x20EFD8C")]
	public void UseCloud(string cloudAppid, CloudRegionCode code)
	{
	}

	[Token(Token = "0x600199D")]
	[Address(RVA = "0x20EFDA0", Offset = "0x20EFDA0", VA = "0x20EFDA0")]
	public void UseMyServer(string serverAddress, int serverPort, string application)
	{
	}

	[Token(Token = "0x600199E")]
	[Address(RVA = "0x20EFE58", Offset = "0x20EFE58", VA = "0x20EFE58")]
	public static bool IsAppId(string val)
	{
		return default(bool);
	}

	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x20F0020", Offset = "0x20F0020", VA = "0x20F0020")]
	public static void ResetBestRegionCodeInPreferences()
	{
	}

	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x20F00C4", Offset = "0x20F00C4", VA = "0x20F00C4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
