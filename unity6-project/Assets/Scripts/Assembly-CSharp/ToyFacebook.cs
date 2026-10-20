using System;
using System.Collections.Generic;
using CS;
using Facebook.Unity;
using Il2CppDummyDll;
using NPA;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000BDD")]
public class ToyFacebook : INPListenerType, INPListener
{
	[Token(Token = "0x2000BDE")]
	private sealed class _003CRequestFriendsDataToServer_003Ec__AnonStorey164
	{
		[Token(Token = "0x4003C33")]
		[FieldOffset(Offset = "0x8")]
		internal List<FacebookFriend> appendList;

		[Token(Token = "0x4003C34")]
		[FieldOffset(Offset = "0xC")]
		internal ToyFacebook _003C_003Ef__this;

		[Token(Token = "0x4003C35")]
		[FieldOffset(Offset = "0x0")]
		private static Func<FacebookFriend, string> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x4003C36")]
		[FieldOffset(Offset = "0x4")]
		private static Func<FacebookFriend, FacebookFriend> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x1D56CE4", Offset = "0x1D56CE4", VA = "0x1D56CE4")]
		public _003CRequestFriendsDataToServer_003Ec__AnonStorey164()
		{
		}

		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x1D56D0C", Offset = "0x1D56D0C", VA = "0x1D56D0C")]
		internal void _003C_003Em__22A(ApiReturnCode errno, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x1D57334", Offset = "0x1D57334", VA = "0x1D57334")]
		private static string _003C_003Em__22B(FacebookFriend x)
		{
			return null;
		}

		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x1D57354", Offset = "0x1D57354", VA = "0x1D57354")]
		private static FacebookFriend _003C_003Em__22C(FacebookFriend x)
		{
			return null;
		}
	}

	[Token(Token = "0x4003C2C")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly ToyFacebook Instance;

	[Token(Token = "0x4003C2D")]
	[FieldOffset(Offset = "0x8")]
	private IToyFacebookListener listener;

	[Token(Token = "0x4003C2E")]
	[FieldOffset(Offset = "0xC")]
	private List<SnsConnectStatus> snsConnectStatus;

	[Token(Token = "0x4003C2F")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, FacebookFriend> FriendDict__BackingField;

	[Token(Token = "0x4003C30")]
	[FieldOffset(Offset = "0x14")]
	private int HasNext__BackingField;

	[Token(Token = "0x4003C31")]
	[FieldOffset(Offset = "0x18")]
	private bool IsConnected__BackingField;

	[Token(Token = "0x4003C32")]
	[FieldOffset(Offset = "0x4")]
	private static Func<FacebookFriend, string> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x17000C8D")]
	public IToyFacebookListener Listener
	{
		[Token(Token = "0x60055CE")]
		[Address(RVA = "0x1D54EB4", Offset = "0x1D54EB4", VA = "0x1D54EB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x1D54F54", Offset = "0x1D54F54", VA = "0x1D54F54")]
		set
		{
		}
	}

	[Token(Token = "0x17000C8E")]
	private Dictionary<string, FacebookFriend> FriendDict
	{
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x1D54F5C", Offset = "0x1D54F5C", VA = "0x1D54F5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x1D54E0C", Offset = "0x1D54E0C", VA = "0x1D54E0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C8F")]
	public List<FacebookFriend> FriendList
	{
		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x1D54F64", Offset = "0x1D54F64", VA = "0x1D54F64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C90")]
	public int HasNext
	{
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x1D55018", Offset = "0x1D55018", VA = "0x1D55018")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x1D54E14", Offset = "0x1D54E14", VA = "0x1D54E14")]
		set
		{
		}
	}

	[Token(Token = "0x17000C91")]
	public bool IsConnected
	{
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x1D55020", Offset = "0x1D55020", VA = "0x1D55020")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x1D54E1C", Offset = "0x1D54E1C", VA = "0x1D54E1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C92")]
	private string AppLinkUrl
	{
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x1D55028", Offset = "0x1D55028", VA = "0x1D55028")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C93")]
	private string PreviewImageUrl
	{
		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x1D550A0", Offset = "0x1D550A0", VA = "0x1D550A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055CC")]
	[Address(RVA = "0x1D54D1C", Offset = "0x1D54D1C", VA = "0x1D54D1C")]
	public ToyFacebook()
	{
	}

	[Token(Token = "0x60055D9")]
	[Address(RVA = "0x1D551A8", Offset = "0x1D551A8", VA = "0x1D551A8")]
	public void OnLobbyEntered()
	{
	}

	[Token(Token = "0x60055DA")]
	[Address(RVA = "0x1D551AC", Offset = "0x1D551AC", VA = "0x1D551AC")]
	public void RequestAppInvite()
	{
	}

	[Token(Token = "0x60055DB")]
	[Address(RVA = "0x1D55380", Offset = "0x1D55380", VA = "0x1D55380")]
	private void callback(IAppInviteResult result)
	{
	}

	[Token(Token = "0x60055DC")]
	[Address(RVA = "0x1D55720", Offset = "0x1D55720", VA = "0x1D55720", Slot = "4")]
	public void OnResult(NPResult npResult)
	{
	}

	[Token(Token = "0x60055DD")]
	[Address(RVA = "0x1D55BE4", Offset = "0x1D55BE4", VA = "0x1D55BE4")]
	public void OnResultGetSnsConnectionStatus(NPResult npResult)
	{
	}

	[Token(Token = "0x60055DE")]
	[Address(RVA = "0x1D560C0", Offset = "0x1D560C0", VA = "0x1D560C0")]
	public void OnResultSNSConnectWithFacebook(NPResult npResult)
	{
	}

	[Token(Token = "0x60055DF")]
	[Address(RVA = "0x1D561E8", Offset = "0x1D561E8", VA = "0x1D561E8")]
	public void OnResultGetFriends(NPResult npResult)
	{
	}

	[Token(Token = "0x60055E0")]
	[Address(RVA = "0x1D56310", Offset = "0x1D56310", VA = "0x1D56310")]
	private List<FacebookFriend> ParseFacebookFriends(NPResult npResult)
	{
		return null;
	}

	[Token(Token = "0x60055E1")]
	[Address(RVA = "0x1D561E4", Offset = "0x1D561E4", VA = "0x1D561E4")]
	private void OnResultAppInviteFacebook(NPResult npResult)
	{
	}

	[Token(Token = "0x60055E2")]
	[Address(RVA = "0x1D55AC4", Offset = "0x1D55AC4", VA = "0x1D55AC4")]
	private bool TryResponseError(NPErrorCode errno)
	{
		return default(bool);
	}

	[Token(Token = "0x60055E3")]
	[Address(RVA = "0x1D56BC4", Offset = "0x1D56BC4", VA = "0x1D56BC4")]
	private bool TryResponseError(ApiReturnCode errno)
	{
		return default(bool);
	}

	[Token(Token = "0x60055E4")]
	[Address(RVA = "0x1D56754", Offset = "0x1D56754", VA = "0x1D56754")]
	private void RequestFriendsDataToServer(List<FacebookFriend> appendList)
	{
	}

	[Token(Token = "0x60055E5")]
	[Address(RVA = "0x1D56CEC", Offset = "0x1D56CEC", VA = "0x1D56CEC")]
	private static string _003CRequestFriendsDataToServer_003Em__229(FacebookFriend item)
	{
		return null;
	}
}
