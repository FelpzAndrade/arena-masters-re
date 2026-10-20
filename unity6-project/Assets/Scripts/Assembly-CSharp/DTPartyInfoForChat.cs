using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003DF")]
public class DTPartyInfoForChat
{
	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0x8")]
	private long PartyKey__BackingField;

	[Token(Token = "0x4001374")]
	[FieldOffset(Offset = "0x10")]
	private string MasterID__BackingField;

	[Token(Token = "0x4001375")]
	[FieldOffset(Offset = "0x14")]
	private string MasterName__BackingField;

	[Token(Token = "0x4001376")]
	[FieldOffset(Offset = "0x18")]
	private byte PlayerCount__BackingField;

	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x1C")]
	private List<NetMatchPlayerInfoForChat> MemberInfo__BackingField;

	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0x20")]
	private long CreateTime__BackingField;

	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0x28")]
	private int GameMode__BackingField;

	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x0")]
	private static Func<NetMatchPlayerInfoForChat, string> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x1700055F")]
	public long PartyKey
	{
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x1E673E8", Offset = "0x1E673E8", VA = "0x1E673E8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x1E671D4", Offset = "0x1E671D4", VA = "0x1E671D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000560")]
	public string MasterID
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x1E673F0", Offset = "0x1E673F0", VA = "0x1E673F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x1E671E4", Offset = "0x1E671E4", VA = "0x1E671E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000561")]
	public string MasterName
	{
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x1E673F8", Offset = "0x1E673F8", VA = "0x1E673F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x1E671EC", Offset = "0x1E671EC", VA = "0x1E671EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000562")]
	public byte PlayerCount
	{
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x1E67400", Offset = "0x1E67400", VA = "0x1E67400")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x1E671F4", Offset = "0x1E671F4", VA = "0x1E671F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000563")]
	public List<NetMatchPlayerInfoForChat> MemberInfo
	{
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x1E67408", Offset = "0x1E67408", VA = "0x1E67408")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x1E67150", Offset = "0x1E67150", VA = "0x1E67150")]
		set
		{
		}
	}

	[Token(Token = "0x17000564")]
	public long CreateTime
	{
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x1E67410", Offset = "0x1E67410", VA = "0x1E67410")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x1E673D0", Offset = "0x1E673D0", VA = "0x1E673D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000565")]
	public int GameMode
	{
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x1E67418", Offset = "0x1E67418", VA = "0x1E67418")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0x1E673E0", Offset = "0x1E673E0", VA = "0x1E673E0")]
		set
		{
		}
	}

	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x1E670A4", Offset = "0x1E670A4", VA = "0x1E670A4")]
	public DTPartyInfoForChat()
	{
	}

	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x1E67158", Offset = "0x1E67158", VA = "0x1E67158")]
	public DTPartyInfoForChat(DTPartyInfo party)
	{
	}

	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x1E671FC", Offset = "0x1E671FC", VA = "0x1E671FC")]
	private List<NetMatchPlayerInfoForChat> ConvertMemberInfoList(List<NetMatchPlayerInfo> memberInfo)
	{
		return null;
	}

	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x1E67420", Offset = "0x1E67420", VA = "0x1E67420")]
	public int GetMemberCount()
	{
		return default(int);
	}

	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x1E674B8", Offset = "0x1E674B8", VA = "0x1E674B8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x1E676C0", Offset = "0x1E676C0", VA = "0x1E676C0")]
	private static string _003CToString_003Em__A3(NetMatchPlayerInfoForChat item)
	{
		return null;
	}
}
