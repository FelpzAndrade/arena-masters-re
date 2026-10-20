using System;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C1")]
internal class NetworkingPeer : LoadBalancingPeer, IPhotonPeerListener
{
	[Token(Token = "0x4000E57")]
	public const string NameServerHost = "ns.exitgames.com";

	[Token(Token = "0x4000E58")]
	public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

	[Token(Token = "0x4000E59")]
	protected internal const string CurrentSceneProperty = "curScn";

	[Token(Token = "0x4000E5A")]
	public const int SyncViewId = 0;

	[Token(Token = "0x4000E5B")]
	public const int SyncCompressed = 1;

	[Token(Token = "0x4000E5C")]
	public const int SyncNullValues = 2;

	[Token(Token = "0x4000E5D")]
	public const int SyncFirstValue = 3;

	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x8C")]
	protected internal string AppId;

	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x90")]
	private string tokenCache;

	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x94")]
	public AuthModeOption AuthMode;

	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x98")]
	public EncryptionMode EncryptionMode;

	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x9C")]
	public bool IsInitialConnect;

	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x9D")]
	public bool insideLobby;

	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0xA0")]
	protected internal List<TypedLobbyInfo> LobbyStatistics;

	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0xA4")]
	public Dictionary<string, RoomInfo> mGameList;

	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0xA8")]
	public RoomInfo[] mGameListCopy;

	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0xAC")]
	private string playername;

	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0xB0")]
	private bool mPlayernameHasToBeUpdated;

	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0xB4")]
	private Room currentRoom;

	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0xB8")]
	private JoinType lastJoinType;

	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0xBC")]
	protected internal EnterRoomParams enterRoomParamsCache;

	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0xC0")]
	private bool didAuthenticate;

	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0xC4")]
	private string[] friendListRequested;

	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0xC8")]
	private int friendListTimestamp;

	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0xCC")]
	private bool isFetchingFriendList;

	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0xD0")]
	public Dictionary<int, PhotonPlayer> mActors;

	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0xD4")]
	public PhotonPlayer[] mOtherPlayerListCopy;

	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0xD8")]
	public PhotonPlayer[] mPlayerListCopy;

	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0xDC")]
	public bool hasSwitchedMC;

	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0xE0")]
	private HashSet<byte> allowedReceivingGroups;

	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0xE4")]
	private HashSet<byte> blockSendingGroups;

	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0xE8")]
	protected internal Dictionary<int, PhotonView> photonViewList;

	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0xEC")]
	private readonly PhotonStream readStream;

	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0xF0")]
	private readonly PhotonStream pStream;

	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0xF4")]
	private readonly Dictionary<int, Hashtable> dataPerGroupReliable;

	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0xF8")]
	private readonly Dictionary<int, Hashtable> dataPerGroupUnreliable;

	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0xFC")]
	protected internal short currentLevelPrefix;

	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0xFE")]
	protected internal bool loadingLevelAndPausedNetwork;

	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x4")]
	public static bool UsePrefabCache;

	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x100")]
	internal IPunPrefabPool ObjectPool;

	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<string, GameObject> PrefabCache;

	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x104")]
	private Dictionary<Type, List<MethodInfo>> monoRPCMethodsCache;

	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x108")]
	private readonly Dictionary<string, int> rpcShortcuts;

	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0xC")]
	private static readonly string OnPhotonInstantiateString;

	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x10C")]
	private string cachedServerAddress;

	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x110")]
	private string cachedApplicationName;

	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x114")]
	private ServerConnection cachedProtocolType;

	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x118")]
	private bool _isReconnecting;

	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x11C")]
	private Dictionary<int, object[]> tempInstantiationData;

	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x10")]
	public static int ObjectsInOneUpdate;

	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x120")]
	private RaiseEventOptions options;

	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x124")]
	private AuthenticationValues AuthValues__BackingField;

	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x128")]
	private bool IsUsingNameServer__BackingField;

	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x12C")]
	private string MasterServerAddress__BackingField;

	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x130")]
	private string GameServerAddress__BackingField;

	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x134")]
	private ServerConnection Server__BackingField;

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x138")]
	private ClientState State__BackingField;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x13C")]
	private TypedLobby lobby__BackingField;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x140")]
	private PhotonPlayer LocalPlayer__BackingField;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x144")]
	private int PlayersOnMasterCount__BackingField;

	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x148")]
	private int PlayersInRoomsCount__BackingField;

	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x14C")]
	private int RoomsCount__BackingField;

	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x150")]
	private List<Region> AvailableRegions__BackingField;

	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x154")]
	private CloudRegionCode CloudRegion__BackingField;

	[Token(Token = "0x170003E9")]
	protected internal string AppVersion
	{
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x13600A4", Offset = "0x13600A4", VA = "0x13600A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EA")]
	public AuthenticationValues AuthValues
	{
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x13601C8", Offset = "0x13601C8", VA = "0x13601C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x13601D0", Offset = "0x13601D0", VA = "0x13601D0")]
		set
		{
		}
	}

	[Token(Token = "0x170003EB")]
	private string TokenForInit
	{
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x13601D8", Offset = "0x13601D8", VA = "0x13601D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EC")]
	public bool IsUsingNameServer
	{
		[Token(Token = "0x600174A")]
		[Address(RVA = "0x13601FC", Offset = "0x13601FC", VA = "0x13601FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600174B")]
		[Address(RVA = "0x1360204", Offset = "0x1360204", VA = "0x1360204")]
		protected internal set
		{
		}
	}

	[Token(Token = "0x170003ED")]
	public string NameServerAddress
	{
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x136020C", Offset = "0x136020C", VA = "0x136020C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EE")]
	public string MasterServerAddress
	{
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x1360444", Offset = "0x1360444", VA = "0x1360444")]
		get
		{
			return null;
		}
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x136044C", Offset = "0x136044C", VA = "0x136044C")]
		protected internal set
		{
		}
	}

	[Token(Token = "0x170003EF")]
	public string GameServerAddress
	{
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x1360454", Offset = "0x1360454", VA = "0x1360454")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x136045C", Offset = "0x136045C", VA = "0x136045C")]
		protected internal set
		{
		}
	}

	[Token(Token = "0x170003F0")]
	protected internal ServerConnection Server
	{
		[Token(Token = "0x6001751")]
		[Address(RVA = "0x1360464", Offset = "0x1360464", VA = "0x1360464")]
		get
		{
			return default(ServerConnection);
		}
		[Token(Token = "0x6001752")]
		[Address(RVA = "0x136046C", Offset = "0x136046C", VA = "0x136046C")]
		private set
		{
		}
	}

	[Token(Token = "0x170003F1")]
	public ClientState State
	{
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x1360474", Offset = "0x1360474", VA = "0x1360474")]
		get
		{
			return default(ClientState);
		}
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x135FE98", Offset = "0x135FE98", VA = "0x135FE98")]
		internal set
		{
		}
	}

	[Token(Token = "0x170003F2")]
	public TypedLobby lobby
	{
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x136047C", Offset = "0x136047C", VA = "0x136047C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x135FB94", Offset = "0x135FB94", VA = "0x135FB94")]
		set
		{
		}
	}

	[Token(Token = "0x170003F3")]
	private bool requestLobbyStatistics
	{
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x1360484", Offset = "0x1360484", VA = "0x1360484")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003F4")]
	public string PlayerName
	{
		[Token(Token = "0x6001758")]
		[Address(RVA = "0x1360548", Offset = "0x1360548", VA = "0x1360548")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x135FB9C", Offset = "0x135FB9C", VA = "0x135FB9C")]
		set
		{
		}
	}

	[Token(Token = "0x170003F5")]
	public Room CurrentRoom
	{
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x1360550", Offset = "0x1360550", VA = "0x1360550")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x13606E4", Offset = "0x13606E4", VA = "0x13606E4")]
		private set
		{
		}
	}

	[Token(Token = "0x170003F6")]
	public PhotonPlayer LocalPlayer
	{
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x135FCD4", Offset = "0x135FCD4", VA = "0x135FCD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x135FCCC", Offset = "0x135FCCC", VA = "0x135FCCC")]
		internal set
		{
		}
	}

	[Token(Token = "0x170003F7")]
	public int PlayersOnMasterCount
	{
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x13606EC", Offset = "0x13606EC", VA = "0x13606EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600175F")]
		[Address(RVA = "0x13606F4", Offset = "0x13606F4", VA = "0x13606F4")]
		internal set
		{
		}
	}

	[Token(Token = "0x170003F8")]
	public int PlayersInRoomsCount
	{
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x13606FC", Offset = "0x13606FC", VA = "0x13606FC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x1360704", Offset = "0x1360704", VA = "0x1360704")]
		internal set
		{
		}
	}

	[Token(Token = "0x170003F9")]
	public int RoomsCount
	{
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x136070C", Offset = "0x136070C", VA = "0x136070C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x1360714", Offset = "0x1360714", VA = "0x1360714")]
		internal set
		{
		}
	}

	[Token(Token = "0x170003FA")]
	protected internal int FriendListAge
	{
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x136071C", Offset = "0x136071C", VA = "0x136071C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003FB")]
	public bool IsAuthorizeSecretAvailable
	{
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x136075C", Offset = "0x136075C", VA = "0x136075C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003FC")]
	public List<Region> AvailableRegions
	{
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x1360828", Offset = "0x1360828", VA = "0x1360828")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x1360830", Offset = "0x1360830", VA = "0x1360830")]
		protected internal set
		{
		}
	}

	[Token(Token = "0x170003FD")]
	public CloudRegionCode CloudRegion
	{
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x1360838", Offset = "0x1360838", VA = "0x1360838")]
		get
		{
			return default(CloudRegionCode);
		}
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x1360840", Offset = "0x1360840", VA = "0x1360840")]
		protected internal set
		{
		}
	}

	[Token(Token = "0x170003FE")]
	public int mMasterClientId
	{
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x1360848", Offset = "0x1360848", VA = "0x1360848")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x136096C", Offset = "0x136096C", VA = "0x136096C")]
		private set
		{
		}
	}

	[Token(Token = "0x6001744")]
	[Address(RVA = "0x135F504", Offset = "0x135F504", VA = "0x135F504")]
	public NetworkingPeer(string playername, ConnectionProtocol connectionProtocol)
	{
	}

	[Token(Token = "0x600176C")]
	[Address(RVA = "0x1360210", Offset = "0x1360210", VA = "0x1360210")]
	private string GetNameServerAddress()
	{
		return null;
	}

	[Token(Token = "0x600176D")]
	[Address(RVA = "0x13609E0", Offset = "0x13609E0", VA = "0x13609E0", Slot = "6")]
	public override bool Connect(string serverAddress, string applicationName)
	{
		return default(bool);
	}

	[Token(Token = "0x600176E")]
	[Address(RVA = "0x1360AA0", Offset = "0x1360AA0", VA = "0x1360AA0")]
	public bool ReconnectToMaster()
	{
		return default(bool);
	}

	[Token(Token = "0x600176F")]
	[Address(RVA = "0x1360F18", Offset = "0x1360F18", VA = "0x1360F18")]
	public bool ReconnectAndRejoin()
	{
		return default(bool);
	}

	[Token(Token = "0x6001770")]
	[Address(RVA = "0x1360BC4", Offset = "0x1360BC4", VA = "0x1360BC4")]
	public bool Connect(string serverAddress, ServerConnection type)
	{
		return default(bool);
	}

	[Token(Token = "0x6001771")]
	[Address(RVA = "0x1361994", Offset = "0x1361994", VA = "0x1361994")]
	private bool Reconnect()
	{
		return default(bool);
	}

	[Token(Token = "0x6001772")]
	[Address(RVA = "0x1361B10", Offset = "0x1361B10", VA = "0x1361B10")]
	public bool ConnectToNameServer()
	{
		return default(bool);
	}

	[Token(Token = "0x6001773")]
	[Address(RVA = "0x1361D0C", Offset = "0x1361D0C", VA = "0x1361D0C")]
	public bool ConnectToRegionMaster(CloudRegionCode region)
	{
		return default(bool);
	}

	[Token(Token = "0x6001774")]
	[Address(RVA = "0x13610B4", Offset = "0x13610B4", VA = "0x13610B4")]
	protected internal void SetupProtocol(ServerConnection serverType)
	{
	}

	[Token(Token = "0x6001775")]
	[Address(RVA = "0x13621CC", Offset = "0x13621CC", VA = "0x13621CC", Slot = "8")]
	public override void Disconnect()
	{
	}

	[Token(Token = "0x6001776")]
	[Address(RVA = "0x1361F18", Offset = "0x1361F18", VA = "0x1361F18")]
	private bool CallAuthenticate()
	{
		return default(bool);
	}

	[Token(Token = "0x6001777")]
	[Address(RVA = "0x1362388", Offset = "0x1362388", VA = "0x1362388")]
	private void DisconnectToReconnect()
	{
	}

	[Token(Token = "0x6001778")]
	[Address(RVA = "0x13623C4", Offset = "0x13623C4", VA = "0x13623C4")]
	public bool GetRegions()
	{
		return default(bool);
	}

	[Token(Token = "0x6001779")]
	[Address(RVA = "0x136242C", Offset = "0x136242C", VA = "0x136242C", Slot = "25")]
	public override bool OpFindFriends(string[] friendsToFind)
	{
		return default(bool);
	}

	[Token(Token = "0x600177A")]
	[Address(RVA = "0x1362460", Offset = "0x1362460", VA = "0x1362460")]
	public bool OpCreateGame(EnterRoomParams enterRoomParams)
	{
		return default(bool);
	}

	[Token(Token = "0x600177B")]
	[Address(RVA = "0x1362644", Offset = "0x1362644", VA = "0x1362644", Slot = "21")]
	public override bool OpJoinRoom(EnterRoomParams opParams)
	{
		return default(bool);
	}

	[Token(Token = "0x600177C")]
	[Address(RVA = "0x1362690", Offset = "0x1362690", VA = "0x1362690", Slot = "22")]
	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
	{
		return default(bool);
	}

	[Token(Token = "0x600177D")]
	[Address(RVA = "0x136276C", Offset = "0x136276C", VA = "0x136276C", Slot = "51")]
	public virtual bool OpLeave()
	{
		return default(bool);
	}

	[Token(Token = "0x600177E")]
	[Address(RVA = "0x13628F0", Offset = "0x13628F0", VA = "0x13628F0", Slot = "29")]
	public override bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
	{
		return default(bool);
	}

	[Token(Token = "0x600177F")]
	[Address(RVA = "0x13629D8", Offset = "0x13629D8", VA = "0x13629D8")]
	private void ReadoutProperties(Hashtable gameProperties, Hashtable pActorProperties, int targetActorNr)
	{
	}

	[Token(Token = "0x6001780")]
	[Address(RVA = "0x1363374", Offset = "0x1363374", VA = "0x1363374")]
	private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
	{
		return null;
	}

	[Token(Token = "0x6001781")]
	[Address(RVA = "0x1363F50", Offset = "0x1363F50", VA = "0x1363F50")]
	public void ChangeLocalID(int newID)
	{
	}

	[Token(Token = "0x6001782")]
	[Address(RVA = "0x13643D8", Offset = "0x13643D8", VA = "0x13643D8")]
	private void LeftLobbyCleanup()
	{
	}

	[Token(Token = "0x6001783")]
	[Address(RVA = "0x1364528", Offset = "0x1364528", VA = "0x1364528")]
	private void LeftRoomCleanup()
	{
	}

	[Token(Token = "0x6001784")]
	[Address(RVA = "0x13648CC", Offset = "0x13648CC", VA = "0x13648CC")]
	protected internal void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects)
	{
	}

	[Token(Token = "0x6001785")]
	[Address(RVA = "0x13656CC", Offset = "0x13656CC", VA = "0x13656CC")]
	private void GameEnteredOnGameServer(OperationResponse operationResponse)
	{
	}

	[Token(Token = "0x6001786")]
	[Address(RVA = "0x135FCDC", Offset = "0x135FCDC", VA = "0x135FCDC")]
	private void AddNewPlayer(int ID, PhotonPlayer player)
	{
	}

	[Token(Token = "0x6001787")]
	[Address(RVA = "0x1366680", Offset = "0x1366680", VA = "0x1366680")]
	private void RemovePlayer(int ID, PhotonPlayer player)
	{
	}

	[Token(Token = "0x6001788")]
	[Address(RVA = "0x13641D4", Offset = "0x13641D4", VA = "0x13641D4")]
	private void RebuildPlayerListCopies()
	{
	}

	[Token(Token = "0x6001789")]
	[Address(RVA = "0x1366740", Offset = "0x1366740", VA = "0x1366740")]
	private void ResetPhotonViewsOnSerialize()
	{
	}

	[Token(Token = "0x600178A")]
	[Address(RVA = "0x13669A8", Offset = "0x13669A8", VA = "0x13669A8")]
	private void HandleEventLeave(int actorID, EventData evLeave)
	{
	}

	[Token(Token = "0x600178B")]
	[Address(RVA = "0x13662AC", Offset = "0x13662AC", VA = "0x13662AC")]
	private void CheckMasterClient(int leavingPlayerId)
	{
	}

	[Token(Token = "0x600178C")]
	[Address(RVA = "0x1367434", Offset = "0x1367434", VA = "0x1367434")]
	protected internal void UpdateMasterClient()
	{
	}

	[Token(Token = "0x600178D")]
	[Address(RVA = "0x1367DE8", Offset = "0x1367DE8", VA = "0x1367DE8")]
	private static int ReturnLowestPlayerId(PhotonPlayer[] players, int playerIdToIgnore)
	{
		return default(int);
	}

	[Token(Token = "0x600178E")]
	[Address(RVA = "0x1367E94", Offset = "0x1367E94", VA = "0x1367E94")]
	protected internal bool SetMasterClient(int playerId, bool sync)
	{
		return default(bool);
	}

	[Token(Token = "0x600178F")]
	[Address(RVA = "0x136815C", Offset = "0x136815C", VA = "0x136815C")]
	public bool SetMasterClient(int nextMasterId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001790")]
	[Address(RVA = "0x13632BC", Offset = "0x13632BC", VA = "0x13632BC")]
	protected internal PhotonPlayer GetPlayerWithId(int number)
	{
		return null;
	}

	[Token(Token = "0x6001791")]
	[Address(RVA = "0x1360588", Offset = "0x1360588", VA = "0x1360588")]
	private void SendPlayerName()
	{
	}

	[Token(Token = "0x6001792")]
	[Address(RVA = "0x13624C4", Offset = "0x13624C4", VA = "0x13624C4")]
	private Hashtable GetLocalActorProperties()
	{
		return null;
	}

	[Token(Token = "0x6001793")]
	[Address(RVA = "0x1368310", Offset = "0x1368310", VA = "0x1368310", Slot = "47")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x6001794")]
	[Address(RVA = "0x136854C", Offset = "0x136854C", VA = "0x136854C", Slot = "48")]
	public void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	[Token(Token = "0x6001795")]
	[Address(RVA = "0x136E35C", Offset = "0x136E35C", VA = "0x136E35C", Slot = "49")]
	public void OnStatusChanged(StatusCode statusCode)
	{
	}

	[Token(Token = "0x6001796")]
	[Address(RVA = "0x136FDE8", Offset = "0x136FDE8", VA = "0x136FDE8", Slot = "50")]
	public void OnEvent(EventData photonEvent)
	{
	}

	[Token(Token = "0x6001797")]
	[Address(RVA = "0x1378500", Offset = "0x1378500", VA = "0x1378500")]
	public void OnMessage(object messages)
	{
	}

	[Token(Token = "0x6001798")]
	[Address(RVA = "0x136DFBC", Offset = "0x136DFBC", VA = "0x136DFBC")]
	private void SetupEncryption(Dictionary<byte, object> encryptionData)
	{
	}

	[Token(Token = "0x6001799")]
	[Address(RVA = "0x13660E4", Offset = "0x13660E4", VA = "0x13660E4")]
	protected internal void UpdatedActorList(int[] actorsInRoom)
	{
	}

	[Token(Token = "0x600179A")]
	[Address(RVA = "0x1378504", Offset = "0x1378504", VA = "0x1378504")]
	private void SendVacantViewIds()
	{
	}

	[Token(Token = "0x600179B")]
	[Address(RVA = "0x1363498", Offset = "0x1363498", VA = "0x1363498")]
	public static void SendMonoMessage(PhotonNetworkingMessage methodString, params object[] parameters)
	{
	}

	[Token(Token = "0x600179C")]
	[Address(RVA = "0x13789BC", Offset = "0x13789BC", VA = "0x13789BC")]
	private static bool IsGameProcessingDone(PhotonNetworkingMessage message)
	{
		return default(bool);
	}

	[Token(Token = "0x600179D")]
	[Address(RVA = "0x1373504", Offset = "0x1373504", VA = "0x1373504")]
	protected internal void ExecuteRpc(Hashtable rpcData, int senderID = 0)
	{
	}

	[Token(Token = "0x600179E")]
	[Address(RVA = "0x1378CE4", Offset = "0x1378CE4", VA = "0x1378CE4")]
	private bool CheckTypeMatch(ParameterInfo[] methodParameters, Type[] callParameterTypes)
	{
		return default(bool);
	}

	[Token(Token = "0x600179F")]
	[Address(RVA = "0x1378F4C", Offset = "0x1378F4C", VA = "0x1378F4C")]
	internal Hashtable SendInstantiate(string prefabName, Vector3 position, Quaternion rotation, byte group, int[] viewIDs, object[] data, bool isGlobalObject)
	{
		return null;
	}

	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x1377104", Offset = "0x1377104", VA = "0x1377104")]
	internal GameObject DoInstantiate(Hashtable evData, PhotonPlayer photonPlayer, GameObject resourceGameObject)
	{
		return null;
	}

	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x1379484", Offset = "0x1379484", VA = "0x1379484")]
	private void StoreInstantiationData(int instantiationId, object[] instantiationData)
	{
	}

	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x13795CC", Offset = "0x13795CC", VA = "0x13795CC")]
	public object[] FetchInstantiationData(int instantiationId)
	{
		return null;
	}

	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x137952C", Offset = "0x137952C", VA = "0x137952C")]
	private void RemoveInstantiationData(int instantiationId)
	{
	}

	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x1367598", Offset = "0x1367598", VA = "0x1367598")]
	public void DestroyPlayerObjects(int playerId, bool localOnly)
	{
	}

	[Token(Token = "0x60017A5")]
	[Address(RVA = "0x13784CC", Offset = "0x13784CC", VA = "0x13784CC")]
	public void DestroyAll(bool localOnly)
	{
	}

	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x1364EA4", Offset = "0x1364EA4", VA = "0x1364EA4")]
	protected internal void RemoveInstantiatedGO(GameObject go, bool localOnly)
	{
	}

	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x1379C8C", Offset = "0x1379C8C", VA = "0x1379C8C")]
	private void ServerCleanInstantiateAndDestroy(int instantiateId, int creatorId, bool isRuntimeInstantiated)
	{
	}

	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x137991C", Offset = "0x137991C", VA = "0x137991C")]
	private void SendDestroyOfPlayer(int actorNr)
	{
	}

	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x1379B4C", Offset = "0x1379B4C", VA = "0x1379B4C")]
	private void SendDestroyOfAll()
	{
	}

	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x137968C", Offset = "0x137968C", VA = "0x137968C")]
	private void OpRemoveFromServerInstantiationsOfPlayer(int actorNr)
	{
	}

	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x137A278", Offset = "0x137A278", VA = "0x137A278")]
	protected internal void RequestOwnership(int viewID, int fromOwner)
	{
	}

	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x137A72C", Offset = "0x137A72C", VA = "0x137A72C")]
	protected internal void TransferOwnership(int viewID, int playerID)
	{
	}

	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x137A024", Offset = "0x137A024", VA = "0x137A024")]
	public bool LocalCleanPhotonView(PhotonView view)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x1378A1C", Offset = "0x1378A1C", VA = "0x1378A1C")]
	public PhotonView GetPhotonView(int viewID)
	{
		return null;
	}

	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x137ABE0", Offset = "0x137ABE0", VA = "0x137ABE0")]
	public void RegisterPhotonView(PhotonView netView)
	{
	}

	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x13797D4", Offset = "0x13797D4", VA = "0x13797D4")]
	public void OpCleanRpcBuffer(int actorNumber)
	{
	}

	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x137B07C", Offset = "0x137B07C", VA = "0x137B07C")]
	public void OpRemoveCompleteCacheOfPlayer(int actorNumber)
	{
	}

	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x1379A5C", Offset = "0x1379A5C", VA = "0x1379A5C")]
	public void OpRemoveCompleteCache()
	{
	}

	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x137B1C4", Offset = "0x137B1C4", VA = "0x137B1C4")]
	private void RemoveCacheOfLeftPlayers()
	{
	}

	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x137B330", Offset = "0x137B330", VA = "0x137B330")]
	public void CleanRpcBufferIfMine(PhotonView view)
	{
	}

	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x137A0E4", Offset = "0x137A0E4", VA = "0x137A0E4")]
	public void OpCleanRpcBuffer(PhotonView view)
	{
	}

	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x137B668", Offset = "0x137B668", VA = "0x137B668")]
	public void RemoveRPCsInGroup(int group)
	{
	}

	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x137B8E8", Offset = "0x137B8E8", VA = "0x137B8E8")]
	public void SetLevelPrefix(short prefix)
	{
	}

	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x137B8F0", Offset = "0x137B8F0", VA = "0x137B8F0")]
	internal void RPC(PhotonView view, string methodName, PhotonTargets target, PhotonPlayer player, bool encrypt, params object[] parameters)
	{
	}

	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x137C964", Offset = "0x137C964", VA = "0x137C964")]
	public void SetInterestGroups(byte[] disableGroups, byte[] enableGroups)
	{
	}

	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x137CE04", Offset = "0x137CE04", VA = "0x137CE04")]
	public void SetSendingEnabled(byte group, bool enabled)
	{
	}

	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x137CED8", Offset = "0x137CED8", VA = "0x137CED8")]
	public void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups)
	{
	}

	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x137D010", Offset = "0x137D010", VA = "0x137D010")]
	public void NewSceneLoaded()
	{
	}

	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x137D5E8", Offset = "0x137D5E8", VA = "0x137D5E8")]
	public void RunViewUpdate()
	{
	}

	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x137ED6C", Offset = "0x137ED6C", VA = "0x137ED6C")]
	private object[] OnSerializeWrite(PhotonView view)
	{
		return null;
	}

	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x13765D4", Offset = "0x13765D4", VA = "0x13765D4")]
	private void OnSerializeRead(object[] data, PhotonPlayer sender, int networkTime, short correctPrefix)
	{
	}

	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x137F150", Offset = "0x137F150", VA = "0x137F150")]
	private object[] DeltaCompressionWrite(object[] previousContent, object[] currentContent)
	{
		return null;
	}

	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x137F518", Offset = "0x137F518", VA = "0x137F518")]
	private object[] DeltaCompressionRead(object[] lastOnSerializeDataReceived, object[] incomingData)
	{
		return null;
	}

	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x137F0AC", Offset = "0x137F0AC", VA = "0x137F0AC")]
	private bool AlmostEquals(object[] lastData, object[] currentContent)
	{
		return default(bool);
	}

	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x137F71C", Offset = "0x137F71C", VA = "0x137F71C")]
	private bool AlmostEquals(object one, object two)
	{
		return default(bool);
	}

	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x137FC6C", Offset = "0x137FC6C", VA = "0x137FC6C")]
	protected internal static bool GetMethod(MonoBehaviour monob, string methodType, out MethodInfo mi)
	{
		mi = default;
		return default(bool);
	}

	[Token(Token = "0x60017C5")]
	[Address(RVA = "0x1363990", Offset = "0x1363990", VA = "0x1363990")]
	protected internal void LoadLevelIfSynced()
	{
	}

	[Token(Token = "0x60017C6")]
	[Address(RVA = "0x137FED4", Offset = "0x137FED4", VA = "0x137FED4")]
	protected internal void SetLevelInPropsIfSynced(object levelId)
	{
	}

	[Token(Token = "0x60017C7")]
	[Address(RVA = "0x1380528", Offset = "0x1380528", VA = "0x1380528")]
	public void SetApp(string appId, string gameVersion)
	{
	}

	[Token(Token = "0x60017C8")]
	[Address(RVA = "0x1380664", Offset = "0x1380664", VA = "0x1380664")]
	public bool WebRpc(string uriPath, object parameters)
	{
		return default(bool);
	}
}
