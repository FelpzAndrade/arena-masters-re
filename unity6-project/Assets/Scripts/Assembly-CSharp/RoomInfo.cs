using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002DD")]
public class RoomInfo
{
		protected RoomInfo()
		{
		}

	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0x8")]
	private Hashtable customPropertiesField;

	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0xC")]
	protected byte maxPlayersField;

	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0x10")]
	protected string[] expectedUsersField;

	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x14")]
	protected bool openField;

	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x15")]
	protected bool visibleField;

	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x16")]
	protected bool autoCleanUpField;

	[Token(Token = "0x4000F47")]
	[FieldOffset(Offset = "0x18")]
	protected string nameField;

	[Token(Token = "0x4000F48")]
	[FieldOffset(Offset = "0x1C")]
	protected internal int masterClientIdField;

	[Token(Token = "0x4000F49")]
	[FieldOffset(Offset = "0x20")]
	private bool removedFromList__BackingField;

	[Token(Token = "0x4000F4A")]
	[FieldOffset(Offset = "0x21")]
	private bool serverSideMasterClient__BackingField;

	[Token(Token = "0x4000F4B")]
	[FieldOffset(Offset = "0x24")]
	private int PlayerCount__BackingField;

	[Token(Token = "0x4000F4C")]
	[FieldOffset(Offset = "0x28")]
	private bool IsLocalClientInside__BackingField;

	[Token(Token = "0x1700046A")]
	public bool removedFromList
	{
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x20EE168", Offset = "0x20EE168", VA = "0x20EE168")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x20EE170", Offset = "0x20EE170", VA = "0x20EE170")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700046B")]
	protected internal bool serverSideMasterClient
	{
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x20EE178", Offset = "0x20EE178", VA = "0x20EE178")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x20EE180", Offset = "0x20EE180", VA = "0x20EE180")]
		private set
		{
		}
	}

	[Token(Token = "0x1700046C")]
	public Hashtable CustomProperties
	{
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x20ED578", Offset = "0x20ED578", VA = "0x20ED578")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700046D")]
	public string Name
	{
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x20EE188", Offset = "0x20EE188", VA = "0x20EE188")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700046E")]
	public int PlayerCount
	{
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x20EE190", Offset = "0x20EE190", VA = "0x20EE190")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x20EE198", Offset = "0x20EE198", VA = "0x20EE198")]
		private set
		{
		}
	}

	[Token(Token = "0x1700046F")]
	public bool IsLocalClientInside
	{
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x20EE1A0", Offset = "0x20EE1A0", VA = "0x20EE1A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x20EE1A8", Offset = "0x20EE1A8", VA = "0x20EE1A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000470")]
	public byte MaxPlayers
	{
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x20EE1B0", Offset = "0x20EE1B0", VA = "0x20EE1B0")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000471")]
	public bool IsOpen
	{
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x20EE1B8", Offset = "0x20EE1B8", VA = "0x20EE1B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000472")]
	public bool IsVisible
	{
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x20EE1C0", Offset = "0x20EE1C0", VA = "0x20EE1C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000473")]
	public Hashtable customProperties
	{
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x20EE97C", Offset = "0x20EE97C", VA = "0x20EE97C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000474")]
	public string name
	{
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x20EE984", Offset = "0x20EE984", VA = "0x20EE984")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000475")]
	public int playerCount
	{
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x20EE98C", Offset = "0x20EE98C", VA = "0x20EE98C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x20EE994", Offset = "0x20EE994", VA = "0x20EE994")]
		set
		{
		}
	}

	[Token(Token = "0x17000476")]
	public bool isLocalClientInside
	{
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x20EE99C", Offset = "0x20EE99C", VA = "0x20EE99C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x20EE9A4", Offset = "0x20EE9A4", VA = "0x20EE9A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000477")]
	public byte maxPlayers
	{
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x20EE9AC", Offset = "0x20EE9AC", VA = "0x20EE9AC")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000478")]
	public bool open
	{
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x20EE9B4", Offset = "0x20EE9B4", VA = "0x20EE9B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000479")]
	public bool visible
	{
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x20EE9BC", Offset = "0x20EE9BC", VA = "0x20EE9BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001977")]
	[Address(RVA = "0x20EC06C", Offset = "0x20EC06C", VA = "0x20EC06C")]
	protected internal RoomInfo(string roomName, Hashtable properties)
	{
	}

	[Token(Token = "0x6001985")]
	[Address(RVA = "0x20EE1C8", Offset = "0x20EE1C8", VA = "0x20EE1C8", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001986")]
	[Address(RVA = "0x20EE2A0", Offset = "0x20EE2A0", VA = "0x20EE2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001987")]
	[Address(RVA = "0x20EE2CC", Offset = "0x20EE2CC", VA = "0x20EE2CC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001988")]
	[Address(RVA = "0x20EE5DC", Offset = "0x20EE5DC", VA = "0x20EE5DC")]
	public string ToStringFull()
	{
		return null;
	}

	[Token(Token = "0x6001989")]
	[Address(RVA = "0x20EC264", Offset = "0x20EC264", VA = "0x20EC264")]
	protected internal void InternalCacheProperties(Hashtable propertiesToCache)
	{
	}
}
