using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200040D")]
public class DTPartyInfo
{
	[Token(Token = "0x400140C")]
	[FieldOffset(Offset = "0x8")]
	private long PartyKey__BackingField;

	[Token(Token = "0x400140D")]
	[FieldOffset(Offset = "0x10")]
	private string MasterID__BackingField;

	[Token(Token = "0x400140E")]
	[FieldOffset(Offset = "0x14")]
	private string MasterName__BackingField;

	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x18")]
	private byte PlayerCount__BackingField;

	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x1C")]
	private List<NetMatchPlayerInfo> MemberInfo__BackingField;

	[Token(Token = "0x4001411")]
	[FieldOffset(Offset = "0x20")]
	private long CreateTime__BackingField;

	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x28")]
	private int GameMode__BackingField;

	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x0")]
	private static Func<NetMatchPlayerInfo, string> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x17000587")]
	public long PartyKey
	{
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x1E66D60", Offset = "0x1E66D60", VA = "0x1E66D60")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x1E66D68", Offset = "0x1E66D68", VA = "0x1E66D68")]
		set
		{
		}
	}

	[Token(Token = "0x17000588")]
	public string MasterID
	{
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x1E66D78", Offset = "0x1E66D78", VA = "0x1E66D78")]
		get
		{
			return null;
		}
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x1E66D80", Offset = "0x1E66D80", VA = "0x1E66D80")]
		set
		{
		}
	}

	[Token(Token = "0x17000589")]
	public string MasterName
	{
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x1E66D88", Offset = "0x1E66D88", VA = "0x1E66D88")]
		get
		{
			return null;
		}
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x1E66D90", Offset = "0x1E66D90", VA = "0x1E66D90")]
		set
		{
		}
	}

	[Token(Token = "0x1700058A")]
	public byte PlayerCount
	{
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x1E66D98", Offset = "0x1E66D98", VA = "0x1E66D98")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x1E66DA0", Offset = "0x1E66DA0", VA = "0x1E66DA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700058B")]
	public List<NetMatchPlayerInfo> MemberInfo
	{
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x1E66DA8", Offset = "0x1E66DA8", VA = "0x1E66DA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x1E66D58", Offset = "0x1E66D58", VA = "0x1E66D58")]
		set
		{
		}
	}

	[Token(Token = "0x1700058C")]
	public long CreateTime
	{
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x1E66DB0", Offset = "0x1E66DB0", VA = "0x1E66DB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x1E66DB8", Offset = "0x1E66DB8", VA = "0x1E66DB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700058D")]
	public int GameMode
	{
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x1E66DC8", Offset = "0x1E66DC8", VA = "0x1E66DC8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x1E66DD0", Offset = "0x1E66DD0", VA = "0x1E66DD0")]
		set
		{
		}
	}

	[Token(Token = "0x6002116")]
	[Address(RVA = "0x1E66CAC", Offset = "0x1E66CAC", VA = "0x1E66CAC")]
	public DTPartyInfo()
	{
	}

	[Token(Token = "0x6002125")]
	[Address(RVA = "0x1E66DD8", Offset = "0x1E66DD8", VA = "0x1E66DD8", Slot = "4")]
	public virtual int GetMemberCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002126")]
	[Address(RVA = "0x1E66E70", Offset = "0x1E66E70", VA = "0x1E66E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002127")]
	[Address(RVA = "0x1E67078", Offset = "0x1E67078", VA = "0x1E67078")]
	private static string _003CToString_003Em__CE(NetMatchPlayerInfo item)
	{
		return null;
	}
}
