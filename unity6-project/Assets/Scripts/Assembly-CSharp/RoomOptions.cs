using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002B3")]
public class RoomOptions
{
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x8")]
	private bool isVisibleField;

	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x9")]
	private bool isOpenField;

	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0xA")]
	public byte MaxPlayers;

	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0xC")]
	public int PlayerTtl;

	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x10")]
	public int EmptyRoomTtl;

	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x14")]
	private bool cleanupCacheOnLeaveField;

	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x18")]
	public Hashtable CustomRoomProperties;

	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x1C")]
	public string[] CustomRoomPropertiesForLobby;

	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x20")]
	public string[] Plugins;

	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x24")]
	private bool suppressRoomEventsField;

	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x25")]
	private bool publishUserIdField;

	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x26")]
	private bool deleteNullPropertiesField;

	[Token(Token = "0x170003D4")]
	public bool IsVisible
	{
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x20EC254", Offset = "0x20EC254", VA = "0x20EC254")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x20EE9C4", Offset = "0x20EE9C4", VA = "0x20EE9C4")]
		set
		{
		}
	}

	[Token(Token = "0x170003D5")]
	public bool IsOpen
	{
		[Token(Token = "0x6001710")]
		[Address(RVA = "0x20EC25C", Offset = "0x20EC25C", VA = "0x20EC25C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001711")]
		[Address(RVA = "0x20EE9CC", Offset = "0x20EE9CC", VA = "0x20EE9CC")]
		set
		{
		}
	}

	[Token(Token = "0x170003D6")]
	public bool CleanupCacheOnLeave
	{
		[Token(Token = "0x6001712")]
		[Address(RVA = "0x20EE9D4", Offset = "0x20EE9D4", VA = "0x20EE9D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001713")]
		[Address(RVA = "0x20EE9DC", Offset = "0x20EE9DC", VA = "0x20EE9DC")]
		set
		{
		}
	}

	[Token(Token = "0x170003D7")]
	public bool SuppressRoomEvents
	{
		[Token(Token = "0x6001714")]
		[Address(RVA = "0x20EE9E4", Offset = "0x20EE9E4", VA = "0x20EE9E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003D8")]
	public bool PublishUserId
	{
		[Token(Token = "0x6001715")]
		[Address(RVA = "0x20EE9EC", Offset = "0x20EE9EC", VA = "0x20EE9EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x20EE9F4", Offset = "0x20EE9F4", VA = "0x20EE9F4")]
		set
		{
		}
	}

	[Token(Token = "0x170003D9")]
	public bool DeleteNullProperties
	{
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x20EE9FC", Offset = "0x20EE9FC", VA = "0x20EE9FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001718")]
		[Address(RVA = "0x20EEA04", Offset = "0x20EEA04", VA = "0x20EEA04")]
		set
		{
		}
	}

	[Token(Token = "0x170003DA")]
	public bool isVisible
	{
		[Token(Token = "0x6001719")]
		[Address(RVA = "0x20EEA0C", Offset = "0x20EEA0C", VA = "0x20EEA0C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x20EEA14", Offset = "0x20EEA14", VA = "0x20EEA14")]
		set
		{
		}
	}

	[Token(Token = "0x170003DB")]
	public bool isOpen
	{
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x20EEA1C", Offset = "0x20EEA1C", VA = "0x20EEA1C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600171C")]
		[Address(RVA = "0x20EEA24", Offset = "0x20EEA24", VA = "0x20EEA24")]
		set
		{
		}
	}

	[Token(Token = "0x170003DC")]
	public byte maxPlayers
	{
		[Token(Token = "0x600171D")]
		[Address(RVA = "0x20EEA2C", Offset = "0x20EEA2C", VA = "0x20EEA2C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x600171E")]
		[Address(RVA = "0x20EEA34", Offset = "0x20EEA34", VA = "0x20EEA34")]
		set
		{
		}
	}

	[Token(Token = "0x170003DD")]
	public bool cleanupCacheOnLeave
	{
		[Token(Token = "0x600171F")]
		[Address(RVA = "0x20EEA3C", Offset = "0x20EEA3C", VA = "0x20EEA3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001720")]
		[Address(RVA = "0x20EEA44", Offset = "0x20EEA44", VA = "0x20EEA44")]
		set
		{
		}
	}

	[Token(Token = "0x170003DE")]
	public Hashtable customRoomProperties
	{
		[Token(Token = "0x6001721")]
		[Address(RVA = "0x20EEA4C", Offset = "0x20EEA4C", VA = "0x20EEA4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001722")]
		[Address(RVA = "0x20EEA54", Offset = "0x20EEA54", VA = "0x20EEA54")]
		set
		{
		}
	}

	[Token(Token = "0x170003DF")]
	public string[] customRoomPropertiesForLobby
	{
		[Token(Token = "0x6001723")]
		[Address(RVA = "0x20EEA5C", Offset = "0x20EEA5C", VA = "0x20EEA5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x20EEA64", Offset = "0x20EEA64", VA = "0x20EEA64")]
		set
		{
		}
	}

	[Token(Token = "0x170003E0")]
	public string[] plugins
	{
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x20EEA6C", Offset = "0x20EEA6C", VA = "0x20EEA6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x20EEA74", Offset = "0x20EEA74", VA = "0x20EEA74")]
		set
		{
		}
	}

	[Token(Token = "0x170003E1")]
	public bool suppressRoomEvents
	{
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x20EEA7C", Offset = "0x20EEA7C", VA = "0x20EEA7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003E2")]
	public bool publishUserId
	{
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x20EEA84", Offset = "0x20EEA84", VA = "0x20EEA84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x20EEA8C", Offset = "0x20EEA8C", VA = "0x20EEA8C")]
		set
		{
		}
	}

	[Token(Token = "0x600170D")]
	[Address(RVA = "0x20EC164", Offset = "0x20EC164", VA = "0x20EC164")]
	public RoomOptions()
	{
	}
}
