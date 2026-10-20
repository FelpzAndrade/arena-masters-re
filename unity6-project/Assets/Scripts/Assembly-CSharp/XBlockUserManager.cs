using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004AC")]
public class XBlockUserManager
{
	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x8")]
	public Action BlockUserRefreshFunc;

	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0xC")]
	private List<Friend> BlockUserList__BackingField;

	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x10")]
	private List<string> BlockedMeUserList__BackingField;

	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x14")]
	private List<string> BlockUserNameList__BackingField;

	[Token(Token = "0x17000665")]
	public List<Friend> BlockUserList
	{
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x1A942B8", Offset = "0x1A942B8", VA = "0x1A942B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x1A942A0", Offset = "0x1A942A0", VA = "0x1A942A0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000666")]
	public List<string> BlockedMeUserList
	{
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x1A942C0", Offset = "0x1A942C0", VA = "0x1A942C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x1A942A8", Offset = "0x1A942A8", VA = "0x1A942A8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000667")]
	public List<string> BlockUserNameList
	{
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x1A942C8", Offset = "0x1A942C8", VA = "0x1A942C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x1A942B0", Offset = "0x1A942B0", VA = "0x1A942B0")]
		private set
		{
		}
	}

	[Token(Token = "0x600281B")]
	[Address(RVA = "0x1A941A8", Offset = "0x1A941A8", VA = "0x1A941A8")]
	public XBlockUserManager()
	{
	}

	[Token(Token = "0x6002822")]
	[Address(RVA = "0x1A942D0", Offset = "0x1A942D0", VA = "0x1A942D0")]
	internal void Clear()
	{
	}

	[Token(Token = "0x6002823")]
	[Address(RVA = "0x1A943C0", Offset = "0x1A943C0", VA = "0x1A943C0")]
	internal void UpdateBlockUserList(List<Friend> blockUserList)
	{
	}

	[Token(Token = "0x6002824")]
	[Address(RVA = "0x1A94618", Offset = "0x1A94618", VA = "0x1A94618")]
	internal void UpdateBlockedMeUserList(List<string> blockedMeUserList)
	{
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0x1A94494", Offset = "0x1A94494", VA = "0x1A94494")]
	private void GetBlockUserList()
	{
	}
}
