using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002CF")]
public static class PhotonNetwork
{
	[Token(Token = "0x20002D0")]
	public delegate void EventCallback(byte eventCode, object content, int senderId);

	[Token(Token = "0x4000EC7")]
	public const string versionPUN = "1.87";

	[Token(Token = "0x4000EC8")]
	internal const string serverSettingsAssetFile = "PhotonServerSettings";

	[Token(Token = "0x4000EC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly PhotonHandler photonMono;

	[Token(Token = "0x4000ECA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	internal static NetworkingPeer networkingPeer;

	[Token(Token = "0x4000ECB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly int MAX_VIEW_IDS;

	[Token(Token = "0x4000ECC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static ServerSettings PhotonServerSettings;

	[Token(Token = "0x4000ECD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool InstantiateInRoomOnly;

	[Token(Token = "0x4000ECE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static PhotonLogLevel logLevel;

	[Token(Token = "0x4000ECF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static float precisionForVectorSynchronization;

	[Token(Token = "0x4000ED0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static float precisionForQuaternionSynchronization;

	[Token(Token = "0x4000ED1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static float precisionForFloatSynchronization;

	[Token(Token = "0x4000ED2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static bool UseRpcMonoBehaviourCache;

	[Token(Token = "0x4000ED3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public static bool UsePrefabCache;

	[Token(Token = "0x4000ED4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Dictionary<string, GameObject> PrefabCache;

	[Token(Token = "0x4000ED5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static HashSet<GameObject> SendMonoMessageTargets;

	[Token(Token = "0x4000ED6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Type SendMonoMessageTargetType;

	[Token(Token = "0x4000ED7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static bool StartRpcsAsCoroutine;

	[Token(Token = "0x4000ED8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private static bool isOfflineMode;

	[Token(Token = "0x4000ED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Room offlineModeRoom;

	[Token(Token = "0x4000EDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static int maxConnections;

	[Token(Token = "0x4000EDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static bool _mAutomaticallySyncScene;

	[Token(Token = "0x4000EDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private static bool m_autoCleanUpPlayerObjects;

	[Token(Token = "0x4000EDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int sendInterval;

	[Token(Token = "0x4000EDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int sendIntervalOnSerialize;

	[Token(Token = "0x4000EDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static bool m_isMessageQueueRunning;

	[Token(Token = "0x4000EE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private static bool UsePreciseTimer;

	[Token(Token = "0x4000EE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Stopwatch startupStopwatch;

	[Token(Token = "0x4000EE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static float BackgroundTimeout;

	[Token(Token = "0x4000EE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static EventCallback OnEventCall;

	[Token(Token = "0x4000EE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal static int lastUsedViewSubId;

	[Token(Token = "0x4000EE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal static int lastUsedViewSubIdStatic;

	[Token(Token = "0x4000EE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	internal static List<int> manuallyAllocatedViewIds;

	[Token(Token = "0x4000EE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string gameVersion__BackingField;

	[Token(Token = "0x4000EE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private static List<FriendInfo> Friends__BackingField;

	[Token(Token = "0x4000EE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static SupportClass.IntegerMillisecondsDelegate _003C_003Ef__am_0024cache20;

	[Token(Token = "0x1700040E")]
	public static string gameVersion
	{
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x1B88C74", Offset = "0x1B88C74", VA = "0x1B88C74")]
		get
		{
			return null;
		}
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x1B88D24", Offset = "0x1B88D24", VA = "0x1B88D24")]
		set
		{
		}
	}

	[Token(Token = "0x1700040F")]
	public static string ServerAddress
	{
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x1B88DD8", Offset = "0x1B88DD8", VA = "0x1B88DD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000410")]
	public static CloudRegionCode CloudRegion
	{
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x1B88F08", Offset = "0x1B88F08", VA = "0x1B88F08")]
		get
		{
			return default(CloudRegionCode);
		}
	}

	[Token(Token = "0x17000411")]
	public static bool connected
	{
		[Token(Token = "0x6001852")]
		[Address(RVA = "0x1B80A50", Offset = "0x1B80A50", VA = "0x1B80A50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000412")]
	public static bool connecting
	{
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x1B89094", Offset = "0x1B89094", VA = "0x1B89094")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000413")]
	public static bool connectedAndReady
	{
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x1B89190", Offset = "0x1B89190", VA = "0x1B89190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000414")]
	public static ConnectionState connectionState
	{
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x1B892F4", Offset = "0x1B892F4", VA = "0x1B892F4")]
		get
		{
			return default(ConnectionState);
		}
	}

	[Token(Token = "0x17000415")]
	public static ClientState connectionStateDetailed
	{
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x1B85588", Offset = "0x1B85588", VA = "0x1B85588")]
		get
		{
			return default(ClientState);
		}
	}

	[Token(Token = "0x17000416")]
	public static ServerConnection Server
	{
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x1B87310", Offset = "0x1B87310", VA = "0x1B87310")]
		get
		{
			return default(ServerConnection);
		}
	}

	[Token(Token = "0x17000417")]
	public static AuthenticationValues AuthValues
	{
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x1B89490", Offset = "0x1B89490", VA = "0x1B89490")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x1B895A8", Offset = "0x1B895A8", VA = "0x1B895A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000418")]
	public static Room room
	{
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x1B80DE0", Offset = "0x1B80DE0", VA = "0x1B80DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000419")]
	public static PhotonPlayer player
	{
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x1B896C0", Offset = "0x1B896C0", VA = "0x1B896C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041A")]
	public static PhotonPlayer masterClient
	{
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x1B897D8", Offset = "0x1B897D8", VA = "0x1B897D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041B")]
	public static string playerName
	{
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x1B8996C", Offset = "0x1B8996C", VA = "0x1B8996C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x1B89A38", Offset = "0x1B89A38", VA = "0x1B89A38")]
		set
		{
		}
	}

	[Token(Token = "0x1700041C")]
	public static PhotonPlayer[] playerList
	{
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x1B89B0C", Offset = "0x1B89B0C", VA = "0x1B89B0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041D")]
	public static PhotonPlayer[] otherPlayers
	{
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x1B89C48", Offset = "0x1B89C48", VA = "0x1B89C48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041E")]
	public static List<FriendInfo> Friends
	{
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x1B89D84", Offset = "0x1B89D84", VA = "0x1B89D84")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x1B89E34", Offset = "0x1B89E34", VA = "0x1B89E34")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700041F")]
	public static int FriendsListAge
	{
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x1B89EE8", Offset = "0x1B89EE8", VA = "0x1B89EE8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000420")]
	public static IPunPrefabPool PrefabPool
	{
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x1B8A000", Offset = "0x1B8A000", VA = "0x1B8A000")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001865")]
		[Address(RVA = "0x1B8A0C4", Offset = "0x1B8A0C4", VA = "0x1B8A0C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000421")]
	public static bool offlineMode
	{
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x1B85734", Offset = "0x1B85734", VA = "0x1B85734")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x1B8A18C", Offset = "0x1B8A18C", VA = "0x1B8A18C")]
		set
		{
		}
	}

	[Token(Token = "0x17000422")]
	public static bool automaticallySyncScene
	{
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x1B8A584", Offset = "0x1B8A584", VA = "0x1B8A584")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x1B8A634", Offset = "0x1B8A634", VA = "0x1B8A634")]
		set
		{
		}
	}

	[Token(Token = "0x17000423")]
	public static bool autoCleanUpPlayerObjects
	{
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x1B8A7A0", Offset = "0x1B8A7A0", VA = "0x1B8A7A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x1B8A850", Offset = "0x1B8A850", VA = "0x1B8A850")]
		set
		{
		}
	}

	[Token(Token = "0x17000424")]
	public static bool autoJoinLobby
	{
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x1B8A9A4", Offset = "0x1B8A9A4", VA = "0x1B8A9A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x1B8AA68", Offset = "0x1B8AA68", VA = "0x1B8AA68")]
		set
		{
		}
	}

	[Token(Token = "0x17000425")]
	public static bool EnableLobbyStatistics
	{
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x1B8AB30", Offset = "0x1B8AB30", VA = "0x1B8AB30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x1B8ABF4", Offset = "0x1B8ABF4", VA = "0x1B8ABF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000426")]
	public static List<TypedLobbyInfo> LobbyStatistics
	{
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x1B8ACBC", Offset = "0x1B8ACBC", VA = "0x1B8ACBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x1B8AD80", Offset = "0x1B8AD80", VA = "0x1B8AD80")]
		private set
		{
		}
	}

	[Token(Token = "0x17000427")]
	public static bool insideLobby
	{
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x1B8AE48", Offset = "0x1B8AE48", VA = "0x1B8AE48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000428")]
	public static TypedLobby lobby
	{
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x1B8AF0C", Offset = "0x1B8AF0C", VA = "0x1B8AF0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x1B8AFD8", Offset = "0x1B8AFD8", VA = "0x1B8AFD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000429")]
	public static int sendRate
	{
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x1B842EC", Offset = "0x1B842EC", VA = "0x1B842EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x1B8B0AC", Offset = "0x1B8B0AC", VA = "0x1B8B0AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700042A")]
	public static int sendRateOnSerialize
	{
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x1B843A4", Offset = "0x1B843A4", VA = "0x1B843A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x1B8B2B0", Offset = "0x1B8B2B0", VA = "0x1B8B2B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700042B")]
	public static bool isMessageQueueRunning
	{
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x1B857E4", Offset = "0x1B857E4", VA = "0x1B857E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x1B8B508", Offset = "0x1B8B508", VA = "0x1B8B508")]
		set
		{
		}
	}

	[Token(Token = "0x1700042C")]
	public static int unreliableCommandsLimit
	{
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x1B8B63C", Offset = "0x1B8B63C", VA = "0x1B8B63C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x1B8B708", Offset = "0x1B8B708", VA = "0x1B8B708")]
		set
		{
		}
	}

	[Token(Token = "0x1700042D")]
	public static double time
	{
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x1B8B7E0", Offset = "0x1B8B7E0", VA = "0x1B8B7E0")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700042E")]
	public static int ServerTimestamp
	{
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x1B8B898", Offset = "0x1B8B898", VA = "0x1B8B898")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700042F")]
	public static bool isMasterClient
	{
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x1B8BAF0", Offset = "0x1B8BAF0", VA = "0x1B8BAF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000430")]
	public static bool inRoom
	{
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x1B80D38", Offset = "0x1B80D38", VA = "0x1B80D38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000431")]
	public static bool isNonMasterClientInRoom
	{
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x1B8BC28", Offset = "0x1B8BC28", VA = "0x1B8BC28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000432")]
	public static int countOfPlayersOnMaster
	{
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x1B8BD0C", Offset = "0x1B8BD0C", VA = "0x1B8BD0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000433")]
	public static int countOfPlayersInRooms
	{
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x1B8BDD8", Offset = "0x1B8BDD8", VA = "0x1B8BDD8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000434")]
	public static int countOfPlayers
	{
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x1B8BEA4", Offset = "0x1B8BEA4", VA = "0x1B8BEA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000435")]
	public static int countOfRooms
	{
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x1B8BFA4", Offset = "0x1B8BFA4", VA = "0x1B8BFA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000436")]
	public static bool NetworkStatisticsEnabled
	{
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x1B8C070", Offset = "0x1B8C070", VA = "0x1B8C070")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x1B8C13C", Offset = "0x1B8C13C", VA = "0x1B8C13C")]
		set
		{
		}
	}

	[Token(Token = "0x17000437")]
	public static int ResentReliableCommands
	{
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x1B8C210", Offset = "0x1B8C210", VA = "0x1B8C210")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000438")]
	public static bool CrcCheckEnabled
	{
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x1B8C2DC", Offset = "0x1B8C2DC", VA = "0x1B8C2DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x1B8C3A8", Offset = "0x1B8C3A8", VA = "0x1B8C3A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000439")]
	public static int PacketLossByCrcCheck
	{
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x1B8C624", Offset = "0x1B8C624", VA = "0x1B8C624")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700043A")]
	public static int MaxResendsBeforeDisconnect
	{
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x1B8C6F0", Offset = "0x1B8C6F0", VA = "0x1B8C6F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x1B8C7B4", Offset = "0x1B8C7B4", VA = "0x1B8C7B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	public static int QuickResends
	{
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x1B8C88C", Offset = "0x1B8C88C", VA = "0x1B8C88C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x1B8C958", Offset = "0x1B8C958", VA = "0x1B8C958")]
		set
		{
		}
	}

	[Token(Token = "0x600184D")]
	[Address(RVA = "0x1B885D0", Offset = "0x1B885D0", VA = "0x1B885D0")]
	static PhotonNetwork()
	{
	}

	[Token(Token = "0x6001890")]
	[Address(RVA = "0x1B8CA3C", Offset = "0x1B8CA3C", VA = "0x1B8CA3C")]
	public static void SwitchToProtocol(ConnectionProtocol cp)
	{
	}

	[Token(Token = "0x6001891")]
	[Address(RVA = "0x1B8CB10", Offset = "0x1B8CB10", VA = "0x1B8CB10")]
	public static bool ConnectUsingSettings(string gameVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6001892")]
	[Address(RVA = "0x1B8DB04", Offset = "0x1B8DB04", VA = "0x1B8DB04")]
	public static bool ConnectToMaster(string masterServerAddress, int port, string appID, string gameVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6001893")]
	[Address(RVA = "0x1B8E0B0", Offset = "0x1B8E0B0", VA = "0x1B8E0B0")]
	public static bool Reconnect()
	{
		return default(bool);
	}

	[Token(Token = "0x6001894")]
	[Address(RVA = "0x1B8E668", Offset = "0x1B8E668", VA = "0x1B8E668")]
	public static bool ReconnectAndRejoin()
	{
		return default(bool);
	}

	[Token(Token = "0x6001895")]
	[Address(RVA = "0x1B8D520", Offset = "0x1B8D520", VA = "0x1B8D520")]
	public static bool ConnectToBestCloudServer(string gameVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6001896")]
	[Address(RVA = "0x1B8EC60", Offset = "0x1B8EC60", VA = "0x1B8EC60")]
	public static bool ConnectToRegion(CloudRegionCode region, string gameVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6001897")]
	[Address(RVA = "0x1B8F1AC", Offset = "0x1B8F1AC", VA = "0x1B8F1AC")]
	public static void OverrideBestCloudServer(CloudRegionCode region)
	{
	}

	[Token(Token = "0x6001898")]
	[Address(RVA = "0x1B8F24C", Offset = "0x1B8F24C", VA = "0x1B8F24C")]
	public static void RefreshCloudServerRating()
	{
	}

	[Token(Token = "0x6001899")]
	[Address(RVA = "0x1B8F2F4", Offset = "0x1B8F2F4", VA = "0x1B8F2F4")]
	public static void NetworkStatisticsReset()
	{
	}

	[Token(Token = "0x600189A")]
	[Address(RVA = "0x1B8F3C0", Offset = "0x1B8F3C0", VA = "0x1B8F3C0")]
	public static string NetworkStatisticsToString()
	{
		return null;
	}

	[Token(Token = "0x600189B")]
	[Address(RVA = "0x1B8F52C", Offset = "0x1B8F52C", VA = "0x1B8F52C")]
	public static void InitializeSecurity()
	{
	}

	[Token(Token = "0x600189C")]
	[Address(RVA = "0x1B8F530", Offset = "0x1B8F530", VA = "0x1B8F530")]
	private static bool VerifyCanUseNetwork()
	{
		return default(bool);
	}

	[Token(Token = "0x600189D")]
	[Address(RVA = "0x1B84994", Offset = "0x1B84994", VA = "0x1B84994")]
	public static void Disconnect()
	{
	}

	[Token(Token = "0x600189E")]
	[Address(RVA = "0x1B8F63C", Offset = "0x1B8F63C", VA = "0x1B8F63C")]
	public static bool FindFriends(string[] friendsToFind)
	{
		return default(bool);
	}

	[Token(Token = "0x600189F")]
	[Address(RVA = "0x1B8F7C0", Offset = "0x1B8F7C0", VA = "0x1B8F7C0")]
	public static bool CreateRoom(string roomName)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x1B8FC78", Offset = "0x1B8FC78", VA = "0x1B8FC78")]
	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x1B8F878", Offset = "0x1B8F878", VA = "0x1B8F878")]
	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x1B8FF80", Offset = "0x1B8FF80", VA = "0x1B8FF80")]
	public static bool JoinRoom(string roomName)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x1B90024", Offset = "0x1B90024", VA = "0x1B90024")]
	public static bool JoinRoom(string roomName, string[] expectedUsers)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x1B90418", Offset = "0x1B90418", VA = "0x1B90418")]
	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x1B904D8", Offset = "0x1B904D8", VA = "0x1B904D8")]
	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x1B909B8", Offset = "0x1B909B8", VA = "0x1B909B8")]
	public static bool JoinRandomRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x1B90EC0", Offset = "0x1B90EC0", VA = "0x1B90EC0")]
	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x1B90A74", Offset = "0x1B90A74", VA = "0x1B90A74")]
	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x1B90F84", Offset = "0x1B90F84", VA = "0x1B90F84")]
	public static bool ReJoinRoom(string roomName)
	{
		return default(bool);
	}

	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x1B8FD38", Offset = "0x1B8FD38", VA = "0x1B8FD38")]
	private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom)
	{
	}

	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x1B91300", Offset = "0x1B91300", VA = "0x1B91300")]
	public static bool JoinLobby()
	{
		return default(bool);
	}

	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x1B9139C", Offset = "0x1B9139C", VA = "0x1B9139C")]
	public static bool JoinLobby(TypedLobby typedLobby)
	{
		return default(bool);
	}

	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x1B915DC", Offset = "0x1B915DC", VA = "0x1B915DC")]
	public static bool LeaveLobby()
	{
		return default(bool);
	}

	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x1B91750", Offset = "0x1B91750", VA = "0x1B91750")]
	public static bool LeaveRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x1B91A8C", Offset = "0x1B91A8C", VA = "0x1B91A8C")]
	public static bool GetCustomRoomList(TypedLobby typedLobby, string sqlLobbyFilter)
	{
		return default(bool);
	}

	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x1B91B94", Offset = "0x1B91B94", VA = "0x1B91B94")]
	public static RoomInfo[] GetRoomList()
	{
		return null;
	}

	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x1B91D0C", Offset = "0x1B91D0C", VA = "0x1B91D0C")]
	public static void SetPlayerCustomProperties(Hashtable customProperties)
	{
	}

	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x1B92AB8", Offset = "0x1B92AB8", VA = "0x1B92AB8")]
	public static void RemovePlayerCustomProperties(string[] customPropertiesToDelete)
	{
	}

	[Token(Token = "0x60018B3")]
	[Address(RVA = "0x1B92D18", Offset = "0x1B92D18", VA = "0x1B92D18")]
	public static bool RaiseEvent(byte eventCode, object eventContent, bool sendReliable, RaiseEventOptions options)
	{
		return default(bool);
	}

	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x1B92EE4", Offset = "0x1B92EE4", VA = "0x1B92EE4")]
	public static int AllocateViewID()
	{
		return default(int);
	}

	[Token(Token = "0x60018B5")]
	[Address(RVA = "0x1B935D8", Offset = "0x1B935D8", VA = "0x1B935D8")]
	public static int AllocateSceneViewID()
	{
		return default(int);
	}

	[Token(Token = "0x60018B6")]
	[Address(RVA = "0x1B92FE8", Offset = "0x1B92FE8", VA = "0x1B92FE8")]
	private static int AllocateViewID(int ownerId)
	{
		return default(int);
	}

	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x1B93774", Offset = "0x1B93774", VA = "0x1B93774")]
	private static int[] AllocateSceneViewIDs(int countOfNewViews)
	{
		return null;
	}

	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x1B93898", Offset = "0x1B93898", VA = "0x1B93898")]
	public static void UnAllocateViewID(int viewID)
	{
	}

	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x1B93B1C", Offset = "0x1B93B1C", VA = "0x1B93B1C")]
	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group)
	{
		return null;
	}

	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x1B93C14", Offset = "0x1B93C14", VA = "0x1B93C14")]
	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group, object[] data)
	{
		return null;
	}

	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x1B946A0", Offset = "0x1B946A0", VA = "0x1B946A0")]
	public static GameObject InstantiateSceneObject(string prefabName, Vector3 position, Quaternion rotation, byte group, object[] data)
	{
		return null;
	}

	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x1B95390", Offset = "0x1B95390", VA = "0x1B95390")]
	public static int GetPing()
	{
		return default(int);
	}

	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x1B9545C", Offset = "0x1B9545C", VA = "0x1B9545C")]
	public static void FetchServerTimestamp()
	{
	}

	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x1B95594", Offset = "0x1B95594", VA = "0x1B95594")]
	public static void SendOutgoingCommands()
	{
	}

	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x1B956C8", Offset = "0x1B956C8", VA = "0x1B956C8")]
	public static bool CloseConnection(PhotonPlayer kickPlayer)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x1B95A84", Offset = "0x1B95A84", VA = "0x1B95A84")]
	public static bool SetMasterClient(PhotonPlayer masterClientPlayer)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x1B95F34", Offset = "0x1B95F34", VA = "0x1B95F34")]
	public static void Destroy(PhotonView targetView)
	{
	}

	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x1B960E4", Offset = "0x1B960E4", VA = "0x1B960E4")]
	public static void Destroy(GameObject targetGo)
	{
	}

	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x1B961C4", Offset = "0x1B961C4", VA = "0x1B961C4")]
	public static void DestroyPlayerObjects(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x1B96318", Offset = "0x1B96318", VA = "0x1B96318")]
	public static void DestroyPlayerObjects(int targetPlayerId)
	{
	}

	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x1B965C4", Offset = "0x1B965C4", VA = "0x1B965C4")]
	public static void DestroyAll()
	{
	}

	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x1B96734", Offset = "0x1B96734", VA = "0x1B96734")]
	public static void RemoveRPCs(PhotonPlayer targetPlayer)
	{
	}

	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x1B968F8", Offset = "0x1B968F8", VA = "0x1B968F8")]
	public static void RemoveRPCs(PhotonView targetPhotonView)
	{
	}

	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x1B96A08", Offset = "0x1B96A08", VA = "0x1B96A08")]
	public static void RemoveRPCsInGroup(int targetGroup)
	{
	}

	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x1B96B18", Offset = "0x1B96B18", VA = "0x1B96B18")]
	internal static void RPC(PhotonView view, string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x1B96F60", Offset = "0x1B96F60", VA = "0x1B96F60")]
	internal static void RPC(PhotonView view, string methodName, PhotonPlayer targetPlayer, bool encrpyt, params object[] parameters)
	{
	}

	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x1B97320", Offset = "0x1B97320", VA = "0x1B97320")]
	public static void CacheSendMonoMessageTargets(Type type)
	{
	}

	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x1B9741C", Offset = "0x1B9741C", VA = "0x1B9741C")]
	public static HashSet<GameObject> FindGameObjectsWithComponent(Type type)
	{
		return null;
	}

	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x1B9760C", Offset = "0x1B9760C", VA = "0x1B9760C")]
	public static void SetReceivingEnabled(int group, bool enabled)
	{
	}

	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x1B976F0", Offset = "0x1B976F0", VA = "0x1B976F0")]
	public static void SetInterestGroups(byte group, bool enabled)
	{
	}

	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x1B978D8", Offset = "0x1B978D8", VA = "0x1B978D8")]
	public static void SetReceivingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x1B97ABC", Offset = "0x1B97ABC", VA = "0x1B97ABC")]
	public static void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
	{
	}

	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x1B97BD4", Offset = "0x1B97BD4", VA = "0x1B97BD4")]
	public static void SetSendingEnabled(int group, bool enabled)
	{
	}

	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x1B97C7C", Offset = "0x1B97C7C", VA = "0x1B97C7C")]
	public static void SetSendingEnabled(byte group, bool enabled)
	{
	}

	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x1B97D94", Offset = "0x1B97D94", VA = "0x1B97D94")]
	public static void SetSendingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x1B97F00", Offset = "0x1B97F00", VA = "0x1B97F00")]
	public static void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
	{
	}

	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x1B98018", Offset = "0x1B98018", VA = "0x1B98018")]
	public static void SetLevelPrefix(short prefix)
	{
	}

	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x1B98128", Offset = "0x1B98128", VA = "0x1B98128")]
	public static void LoadLevel(int levelNumber)
	{
	}

	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x1B98274", Offset = "0x1B98274", VA = "0x1B98274")]
	public static void LoadLevel(string levelName)
	{
	}

	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x1B9838C", Offset = "0x1B9838C", VA = "0x1B9838C")]
	public static bool WebRpc(string name, object parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x1B98468", Offset = "0x1B98468", VA = "0x1B98468")]
	public static bool JoinMatch(Hashtable match_properties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x1B98568", Offset = "0x1B98568", VA = "0x1B98568")]
	public static bool CancelMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x1B98660", Offset = "0x1B98660", VA = "0x1B98660")]
	public static bool MatchGameStart(string usreID)
	{
		return default(bool);
	}

	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x1B98760", Offset = "0x1B98760", VA = "0x1B98760")]
	public static bool LeaveMatchRoom(string usreID)
	{
		return default(bool);
	}

	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x1B98860", Offset = "0x1B98860", VA = "0x1B98860")]
	internal static bool CreateClanParty(Hashtable createPartyProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x1B98960", Offset = "0x1B98960", VA = "0x1B98960")]
	internal static bool JoinClanParty(Hashtable joinPartyProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x1B98A60", Offset = "0x1B98A60", VA = "0x1B98A60")]
	internal static bool RefreshClanParty(string userAID, long partyKey)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x1B98B70", Offset = "0x1B98B70", VA = "0x1B98B70")]
	internal static bool LeaveClanParty(Hashtable leavePartyProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x1B98C70", Offset = "0x1B98C70", VA = "0x1B98C70")]
	internal static bool GetClanPartyList(Hashtable htParam)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x1B98D70", Offset = "0x1B98D70", VA = "0x1B98D70")]
	internal static bool StartClanWar(Hashtable startClanWarProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x1B98E70", Offset = "0x1B98E70", VA = "0x1B98E70")]
	internal static bool ChangeReadyState(Hashtable ChangeReadyStateProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x1B98F70", Offset = "0x1B98F70", VA = "0x1B98F70")]
	internal static bool CreateParty(Hashtable createPartyProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x1B99070", Offset = "0x1B99070", VA = "0x1B99070")]
	internal static bool JoinParty(Hashtable joinPartyProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x1B99170", Offset = "0x1B99170", VA = "0x1B99170")]
	internal static bool LeaveParty(Hashtable leavePartyProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x1B99270", Offset = "0x1B99270", VA = "0x1B99270")]
	internal static bool StartPartyGame(Hashtable paramProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x1B99370", Offset = "0x1B99370", VA = "0x1B99370")]
	internal static bool ChangePartyInfoState(Hashtable paramProperties)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x1B99470", Offset = "0x1B99470", VA = "0x1B99470")]
	private static int _003CPhotonNetwork_003Em__7F()
	{
		return default(int);
	}
}
