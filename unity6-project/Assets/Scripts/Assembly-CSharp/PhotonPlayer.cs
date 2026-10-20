using System;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x20002D1")]
public class PhotonPlayer : IComparable<PhotonPlayer>, IComparable<int>, IEquatable<PhotonPlayer>, IEquatable<int>
{
	[Token(Token = "0x4000EEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int actorID;

	[Token(Token = "0x4000EEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string nameField;

	[Token(Token = "0x4000EEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly bool IsLocal;

	[Token(Token = "0x4000EED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public object TagObject;

	[Token(Token = "0x4000EEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string UserId__BackingField;

	[Token(Token = "0x4000EEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool IsInactive__BackingField;

	[Token(Token = "0x4000EF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Hashtable CustomProperties__BackingField;

	[Token(Token = "0x1700043C")]
	public int ID
	{
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x1B8BC20", Offset = "0x1B8BC20", VA = "0x1B8BC20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700043D")]
	public string NickName
	{
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x1B9AA60", Offset = "0x1B9AA60", VA = "0x1B9AA60")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x1B9AA68", Offset = "0x1B9AA68", VA = "0x1B9AA68")]
		set
		{
		}
	}

	[Token(Token = "0x1700043E")]
	public string nickname
	{
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x1B9AC00", Offset = "0x1B9AC00", VA = "0x1B9AC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043F")]
	public string UserId
	{
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x1B9ACEC", Offset = "0x1B9ACEC", VA = "0x1B9ACEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x1B9ACF4", Offset = "0x1B9ACF4", VA = "0x1B9ACF4")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000440")]
	public bool IsMasterClient
	{
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x1B959A0", Offset = "0x1B959A0", VA = "0x1B959A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000441")]
	public bool IsInactive
	{
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x1B9ACFC", Offset = "0x1B9ACFC", VA = "0x1B9ACFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x1B9AD04", Offset = "0x1B9AD04", VA = "0x1B9AD04")]
		set
		{
		}
	}

	[Token(Token = "0x17000442")]
	public Hashtable CustomProperties
	{
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x1B909B0", Offset = "0x1B909B0", VA = "0x1B909B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x1B92D10", Offset = "0x1B92D10", VA = "0x1B92D10")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000443")]
	public Hashtable AllProperties
	{
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x1B9AD0C", Offset = "0x1B9AD0C", VA = "0x1B9AD0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000444")]
	public string name
	{
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x1B9BCDC", Offset = "0x1B9BCDC", VA = "0x1B9BCDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x1B9BCE4", Offset = "0x1B9BCE4", VA = "0x1B9BCE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000445")]
	public string userId
	{
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x1B9BCE8", Offset = "0x1B9BCE8", VA = "0x1B9BCE8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x1B9BCF0", Offset = "0x1B9BCF0", VA = "0x1B9BCF0")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000446")]
	public bool isLocal
	{
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x1B9BCF8", Offset = "0x1B9BCF8", VA = "0x1B9BCF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000447")]
	public bool isMasterClient
	{
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x1B9BD00", Offset = "0x1B9BD00", VA = "0x1B9BD00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000448")]
	public bool isInactive
	{
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x1B9BD04", Offset = "0x1B9BD04", VA = "0x1B9BD04")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x1B9BD0C", Offset = "0x1B9BD0C", VA = "0x1B9BD0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000449")]
	public Hashtable customProperties
	{
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x1B9ACE4", Offset = "0x1B9ACE4", VA = "0x1B9ACE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x1B9BD14", Offset = "0x1B9BD14", VA = "0x1B9BD14")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700044A")]
	public Hashtable allProperties
	{
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x1B9BD1C", Offset = "0x1B9BD1C", VA = "0x1B9BD1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x1B9A830", Offset = "0x1B9A830", VA = "0x1B9A830")]
	public PhotonPlayer(bool isLocal, int actorID, string name)
	{
	}

	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x1B9A944", Offset = "0x1B9A944", VA = "0x1B9A944")]
	protected internal PhotonPlayer(bool isLocal, int actorID, Hashtable properties)
	{
	}

	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x1B9AE3C", Offset = "0x1B9AE3C", VA = "0x1B9AE3C", Slot = "0")]
	public override bool Equals(object p)
	{
		return default(bool);
	}

	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x1B9AF5C", Offset = "0x1B9AF5C", VA = "0x1B9AF5C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x1B9AF64", Offset = "0x1B9AF64", VA = "0x1B9AF64")]
	internal void InternalChangeLocalID(int newID)
	{
	}

	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x1B925B0", Offset = "0x1B925B0", VA = "0x1B925B0")]
	internal void InternalCacheProperties(Hashtable properties)
	{
	}

	[Token(Token = "0x6001900")]
	[Address(RVA = "0x1B9223C", Offset = "0x1B9223C", VA = "0x1B9223C")]
	public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, bool webForward = false)
	{
	}

	[Token(Token = "0x6001901")]
	[Address(RVA = "0x1B9B038", Offset = "0x1B9B038", VA = "0x1B9B038")]
	public static PhotonPlayer Find(int ID)
	{
		return null;
	}

	[Token(Token = "0x6001902")]
	[Address(RVA = "0x1B9B158", Offset = "0x1B9B158", VA = "0x1B9B158")]
	public PhotonPlayer Get(int id)
	{
		return null;
	}

	[Token(Token = "0x6001903")]
	[Address(RVA = "0x1B9B15C", Offset = "0x1B9B15C", VA = "0x1B9B15C")]
	public PhotonPlayer GetNext()
	{
		return null;
	}

	[Token(Token = "0x6001904")]
	[Address(RVA = "0x1B9B590", Offset = "0x1B9B590", VA = "0x1B9B590")]
	public PhotonPlayer GetNextFor(PhotonPlayer currentPlayer)
	{
		return null;
	}

	[Token(Token = "0x6001905")]
	[Address(RVA = "0x1B9B164", Offset = "0x1B9B164", VA = "0x1B9B164")]
	public PhotonPlayer GetNextFor(int currentPlayerId)
	{
		return null;
	}

	[Token(Token = "0x6001906")]
	[Address(RVA = "0x1B9B5A4", Offset = "0x1B9B5A4", VA = "0x1B9B5A4", Slot = "4")]
	public int CompareTo(PhotonPlayer other)
	{
		return default(int);
	}

	[Token(Token = "0x6001907")]
	[Address(RVA = "0x1B9B63C", Offset = "0x1B9B63C", VA = "0x1B9B63C", Slot = "5")]
	public int CompareTo(int other)
	{
		return default(int);
	}

	[Token(Token = "0x6001908")]
	[Address(RVA = "0x1B9B6A0", Offset = "0x1B9B6A0", VA = "0x1B9B6A0", Slot = "6")]
	public bool Equals(PhotonPlayer other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001909")]
	[Address(RVA = "0x1B9B738", Offset = "0x1B9B738", VA = "0x1B9B738", Slot = "7")]
	public bool Equals(int other)
	{
		return default(bool);
	}

	[Token(Token = "0x600190A")]
	[Address(RVA = "0x1B9B79C", Offset = "0x1B9B79C", VA = "0x1B9B79C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600190B")]
	[Address(RVA = "0x1B9B9E0", Offset = "0x1B9B9E0", VA = "0x1B9B9E0")]
	public string ToStringFull()
	{
		return null;
	}
}
