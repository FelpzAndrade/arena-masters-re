using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004AB")]
public class XFriendManager
{
	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, Friend> DicFriendByName__BackingField;

	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, Friend> DicFriendByAID__BackingField;

	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, FriendInfo> DicFriendInfoByAID__BackingField;

	[Token(Token = "0x17000662")]
	public Dictionary<string, Friend> DicFriendByName
	{
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x19B5AD8", Offset = "0x19B5AD8", VA = "0x19B5AD8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x19B5AC0", Offset = "0x19B5AC0", VA = "0x19B5AC0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000663")]
	public Dictionary<string, Friend> DicFriendByAID
	{
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x19B5AE0", Offset = "0x19B5AE0", VA = "0x19B5AE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x19B5AC8", Offset = "0x19B5AC8", VA = "0x19B5AC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000664")]
	public Dictionary<string, FriendInfo> DicFriendInfoByAID
	{
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x19B5AE8", Offset = "0x19B5AE8", VA = "0x19B5AE8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x19B5AD0", Offset = "0x19B5AD0", VA = "0x19B5AD0")]
		private set
		{
		}
	}

	[Token(Token = "0x600280C")]
	[Address(RVA = "0x19B59C8", Offset = "0x19B59C8", VA = "0x19B59C8")]
	public XFriendManager()
	{
	}

	[Token(Token = "0x6002813")]
	[Address(RVA = "0x19B5AF0", Offset = "0x19B5AF0", VA = "0x19B5AF0")]
	internal void Clear()
	{
	}

	[Token(Token = "0x6002814")]
	[Address(RVA = "0x19B5BD8", Offset = "0x19B5BD8", VA = "0x19B5BD8")]
	internal bool IsExistData()
	{
		return default(bool);
	}

	[Token(Token = "0x6002815")]
	[Address(RVA = "0x19B5C80", Offset = "0x19B5C80", VA = "0x19B5C80")]
	internal void SetFriendList(List<Friend> liFriend)
	{
	}

	[Token(Token = "0x6002816")]
	[Address(RVA = "0x19B5EC8", Offset = "0x19B5EC8", VA = "0x19B5EC8")]
	public void AddFriendList(List<Friend> liFriend)
	{
	}

	[Token(Token = "0x6002817")]
	[Address(RVA = "0x19B61B8", Offset = "0x19B61B8", VA = "0x19B61B8")]
	public void MergeFriendInfoStatus(List<FriendInfo> liFriendInfo)
	{
	}

	[Token(Token = "0x6002818")]
	[Address(RVA = "0x19B638C", Offset = "0x19B638C", VA = "0x19B638C")]
	public List<XFriendData> GetCombindFriendDataList()
	{
		return null;
	}

	[Token(Token = "0x6002819")]
	[Address(RVA = "0x19B6728", Offset = "0x19B6728", VA = "0x19B6728")]
	public List<string> GetFriendListName()
	{
		return null;
	}

	[Token(Token = "0x600281A")]
	[Address(RVA = "0x19B67DC", Offset = "0x19B67DC", VA = "0x19B67DC")]
	public List<string> GetFriendListAID()
	{
		return null;
	}
}
