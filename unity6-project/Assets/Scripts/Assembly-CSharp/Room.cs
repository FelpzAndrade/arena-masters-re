using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002DC")]
public class Room : RoomInfo
{
	[Token(Token = "0x4000F40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private string[] PropertiesListedInLobby__BackingField;

	[Token(Token = "0x17000458")]
	public new string Name
	{
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x20EC880", Offset = "0x20EC880", VA = "0x20EC880")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x20EC888", Offset = "0x20EC888", VA = "0x20EC888")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000459")]
	public new bool IsOpen
	{
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x20EC890", Offset = "0x20EC890", VA = "0x20EC890")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x20EC898", Offset = "0x20EC898", VA = "0x20EC898")]
		set
		{
		}
	}

	[Token(Token = "0x1700045A")]
	public new bool IsVisible
	{
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x20ECB58", Offset = "0x20ECB58", VA = "0x20ECB58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x20ECB60", Offset = "0x20ECB60", VA = "0x20ECB60")]
		set
		{
		}
	}

	[Token(Token = "0x1700045B")]
	public string[] PropertiesListedInLobby
	{
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x20ECE20", Offset = "0x20ECE20", VA = "0x20ECE20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x20EC878", Offset = "0x20EC878", VA = "0x20EC878")]
		private set
		{
		}
	}

	[Token(Token = "0x1700045C")]
	public bool AutoCleanUp
	{
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x20ECE28", Offset = "0x20ECE28", VA = "0x20ECE28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700045D")]
	public new int MaxPlayers
	{
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x20ECE30", Offset = "0x20ECE30", VA = "0x20ECE30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x20ECE38", Offset = "0x20ECE38", VA = "0x20ECE38")]
		set
		{
		}
	}

	[Token(Token = "0x1700045E")]
	public new int PlayerCount
	{
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x20E8D3C", Offset = "0x20E8D3C", VA = "0x20E8D3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700045F")]
	public string[] ExpectedUsers
	{
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x20ED1C4", Offset = "0x20ED1C4", VA = "0x20ED1C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000460")]
	protected internal int MasterClientId
	{
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x20ED1CC", Offset = "0x20ED1CC", VA = "0x20ED1CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x20ED1D4", Offset = "0x20ED1D4", VA = "0x20ED1D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000461")]
	public new string name
	{
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x20EE100", Offset = "0x20EE100", VA = "0x20EE100")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x20EE108", Offset = "0x20EE108", VA = "0x20EE108")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000462")]
	public new bool open
	{
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x20EE110", Offset = "0x20EE110", VA = "0x20EE110")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x20EE118", Offset = "0x20EE118", VA = "0x20EE118")]
		set
		{
		}
	}

	[Token(Token = "0x17000463")]
	public new bool visible
	{
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x20EE11C", Offset = "0x20EE11C", VA = "0x20EE11C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x20EE124", Offset = "0x20EE124", VA = "0x20EE124")]
		set
		{
		}
	}

	[Token(Token = "0x17000464")]
	public string[] propertiesListedInLobby
	{
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x20EE128", Offset = "0x20EE128", VA = "0x20EE128")]
		get
		{
			return null;
		}
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x20EE130", Offset = "0x20EE130", VA = "0x20EE130")]
		private set
		{
		}
	}

	[Token(Token = "0x17000465")]
	public bool autoCleanUp
	{
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x20EE138", Offset = "0x20EE138", VA = "0x20EE138")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000466")]
	public new int maxPlayers
	{
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x20EE140", Offset = "0x20EE140", VA = "0x20EE140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x20EE148", Offset = "0x20EE148", VA = "0x20EE148")]
		set
		{
		}
	}

	[Token(Token = "0x17000467")]
	public new int playerCount
	{
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x20EE14C", Offset = "0x20EE14C", VA = "0x20EE14C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000468")]
	public string[] expectedUsers
	{
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x20EE150", Offset = "0x20EE150", VA = "0x20EE150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000469")]
	protected internal int masterClientId
	{
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x20EE158", Offset = "0x20EE158", VA = "0x20EE158")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x20EE160", Offset = "0x20EE160", VA = "0x20EE160")]
		set
		{
		}
	}

	[Token(Token = "0x6001952")]
	[Address(RVA = "0x20EBF7C", Offset = "0x20EBF7C", VA = "0x20EBF7C")]
	public Room(string roomName, RoomOptions options)
	{
	}

	[Token(Token = "0x6001962")]
	[Address(RVA = "0x20ED1DC", Offset = "0x20ED1DC", VA = "0x20ED1DC")]
	public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, bool webForward = false)
	{
	}

	[Token(Token = "0x6001963")]
	[Address(RVA = "0x20ED580", Offset = "0x20ED580", VA = "0x20ED580")]
	public void SetPropertiesListedInLobby(string[] propsListedInLobby)
	{
	}

	[Token(Token = "0x6001964")]
	[Address(RVA = "0x20ED6D8", Offset = "0x20ED6D8", VA = "0x20ED6D8")]
	public void ClearExpectedUsers()
	{
	}

	[Token(Token = "0x6001965")]
	[Address(RVA = "0x20ED8A8", Offset = "0x20ED8A8", VA = "0x20ED8A8")]
	public void SetExpectedUsers(string[] expectedUsers)
	{
	}

	[Token(Token = "0x6001966")]
	[Address(RVA = "0x20EDA50", Offset = "0x20EDA50", VA = "0x20EDA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001967")]
	[Address(RVA = "0x20EDD60", Offset = "0x20EDD60", VA = "0x20EDD60")]
	public new string ToStringFull()
	{
		return null;
	}
}
