using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20006B5")]
public static class XRequestHelper
{
	[Token(Token = "0x20006B6")]
	private sealed class _003CRequestOtherUserInfo_003Ec__AnonStorey12D
	{
		[Token(Token = "0x400204B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action<NetData_OtherUserMetaData> onSuccess;

		[Token(Token = "0x600382A")]
		[Address(RVA = "0x1CA04D8", Offset = "0x1CA04D8", VA = "0x1CA04D8")]
		public _003CRequestOtherUserInfo_003Ec__AnonStorey12D()
		{
		}

		[Token(Token = "0x600382B")]
		[Address(RVA = "0x1CA1EA4", Offset = "0x1CA1EA4", VA = "0x1CA1EA4")]
		internal void _003C_003Em__18C(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x20006B7")]
	private sealed class _003CRequestGetMyClan_003Ec__AnonStorey12E
	{
		[Token(Token = "0x400204C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action<Netdata_Clan> action;

		[Token(Token = "0x600382C")]
		[Address(RVA = "0x1CA0680", Offset = "0x1CA0680", VA = "0x1CA0680")]
		public _003CRequestGetMyClan_003Ec__AnonStorey12E()
		{
		}

		[Token(Token = "0x600382D")]
		[Address(RVA = "0x1CA19EC", Offset = "0x1CA19EC", VA = "0x1CA19EC")]
		internal void _003C_003Em__18D(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x20006B8")]
	private sealed class _003CRequestFriendShip_003Ec__AnonStorey12F
	{
		[Token(Token = "0x400204D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action RefreshFriendAction;

		[Token(Token = "0x400204E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Action responseCallBack;

		[Token(Token = "0x600382E")]
		[Address(RVA = "0x1CA0894", Offset = "0x1CA0894", VA = "0x1CA0894")]
		public _003CRequestFriendShip_003Ec__AnonStorey12F()
		{
		}

		[Token(Token = "0x600382F")]
		[Address(RVA = "0x1CA1594", Offset = "0x1CA1594", VA = "0x1CA1594")]
		internal void _003C_003Em__18E(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x20006B9")]
	private sealed class _003CAddBlockFriend_003Ec__AnonStorey130
	{
		[Token(Token = "0x400204F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action responseCallBack;

		[Token(Token = "0x6003830")]
		[Address(RVA = "0x1CA0AA0", Offset = "0x1CA0AA0", VA = "0x1CA0AA0")]
		public _003CAddBlockFriend_003Ec__AnonStorey130()
		{
		}

		[Token(Token = "0x6003831")]
		[Address(RVA = "0x1CA1298", Offset = "0x1CA1298", VA = "0x1CA1298")]
		internal void _003C_003Em__18F(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x20006BA")]
	private sealed class _003CGetBlockUserList_003Ec__AnonStorey131
	{
		[Token(Token = "0x4002050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action responseCallBack;

		[Token(Token = "0x6003832")]
		[Address(RVA = "0x1CA0C68", Offset = "0x1CA0C68", VA = "0x1CA0C68")]
		public _003CGetBlockUserList_003Ec__AnonStorey131()
		{
		}

		[Token(Token = "0x6003833")]
		[Address(RVA = "0x1CA1448", Offset = "0x1CA1448", VA = "0x1CA1448")]
		internal void _003C_003Em__190(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x400204A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003823")]
	[Address(RVA = "0x1CA02D4", Offset = "0x1CA02D4", VA = "0x1CA02D4")]
	public static void RequestOtherUserInfo(string nickname, Action<NetData_OtherUserMetaData> onSuccess)
	{
	}

	[Token(Token = "0x6003824")]
	[Address(RVA = "0x1CA04E0", Offset = "0x1CA04E0", VA = "0x1CA04E0")]
	public static void RequestGetMyClan(Action<Netdata_Clan> action)
	{
	}

	[Token(Token = "0x6003825")]
	[Address(RVA = "0x1CA0688", Offset = "0x1CA0688", VA = "0x1CA0688")]
	public static void RequestFriendShip(string aid, Action RefreshFriendAction, [Optional] Action responseCallBack)
	{
	}

	[Token(Token = "0x6003826")]
	[Address(RVA = "0x1CA089C", Offset = "0x1CA089C", VA = "0x1CA089C")]
	public static void AddBlockFriend(string aid, [Optional] Action responseCallBack)
	{
	}

	[Token(Token = "0x6003827")]
	[Address(RVA = "0x1CA0AA8", Offset = "0x1CA0AA8", VA = "0x1CA0AA8")]
	public static void GetBlockUserList([Optional] Action responseCallBack)
	{
	}

	[Token(Token = "0x6003828")]
	[Address(RVA = "0x1CA0C70", Offset = "0x1CA0C70", VA = "0x1CA0C70")]
	public static void GetBlockedMeUserList(bool isInit)
	{
	}

	[Token(Token = "0x6003829")]
	[Address(RVA = "0x1CA0EA8", Offset = "0x1CA0EA8", VA = "0x1CA0EA8")]
	private static void _003CGetBlockedMeUserList_003Em__191(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
