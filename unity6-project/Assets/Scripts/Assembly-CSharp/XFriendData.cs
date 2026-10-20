using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004AA")]
public class XFriendData
{
	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x8")]
	private Friend Data__BackingField;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0xC")]
	private bool IsOnline__BackingField;

	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x10")]
	private string Room__BackingField;

	[Token(Token = "0x1700065E")]
	public Friend Data
	{
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x19B5564", Offset = "0x19B5564", VA = "0x19B5564")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x19B555C", Offset = "0x19B555C", VA = "0x19B555C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700065F")]
	public bool IsOnline
	{
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x19B556C", Offset = "0x19B556C", VA = "0x19B556C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x19B554C", Offset = "0x19B554C", VA = "0x19B554C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000660")]
	public string Room
	{
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x19B5574", Offset = "0x19B5574", VA = "0x19B5574")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x19B5554", Offset = "0x19B5554", VA = "0x19B5554")]
		private set
		{
		}
	}

	[Token(Token = "0x17000661")]
	public bool IsInRoom
	{
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x19B557C", Offset = "0x19B557C", VA = "0x19B557C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002803")]
	[Address(RVA = "0x19B54F4", Offset = "0x19B54F4", VA = "0x19B54F4")]
	public XFriendData(FriendInfo info, Friend data)
	{
	}

	[Token(Token = "0x600280B")]
	[Address(RVA = "0x19B563C", Offset = "0x19B563C", VA = "0x19B563C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
