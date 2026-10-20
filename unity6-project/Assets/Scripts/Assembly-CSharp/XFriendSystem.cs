using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004B7")]
public class XFriendSystem
{
	[Token(Token = "0x20004B8")]
	private sealed class _003COnRefreshFriendStatus_003Ec__AnonStorey108
	{
		[Token(Token = "0x4001775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<XFriendData> liFriendData;

		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x19BD504", Offset = "0x19BD504", VA = "0x19BD504")]
		public _003COnRefreshFriendStatus_003Ec__AnonStorey108()
		{
		}

		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x19BDE10", Offset = "0x19BDE10", VA = "0x19BDE10")]
		internal void _003C_003Em__EC(IFriendListener listenes)
		{
		}
	}

	[Token(Token = "0x400176F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Action actionUIUpdate;

	[Token(Token = "0x4001770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private List<IFriendListener> m_Listeners;

	[Token(Token = "0x4001771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private XFriendPartySystem Party__BackingField;

	[Token(Token = "0x4001772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XFriendManager FriendManager__BackingField;

	[Token(Token = "0x4001773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XBlockUserManager BlockUserManager__BackingField;

	[Token(Token = "0x4001774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache5;

	[Token(Token = "0x17000669")]
	public XFriendPartySystem Party
	{
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x198E4B0", Offset = "0x198E4B0", VA = "0x198E4B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x19BCAD8", Offset = "0x19BCAD8", VA = "0x19BCAD8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700066A")]
	public XFriendManager FriendManager
	{
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x19BCAF0", Offset = "0x19BCAF0", VA = "0x19BCAF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x19BCAE0", Offset = "0x19BCAE0", VA = "0x19BCAE0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700066B")]
	public XBlockUserManager BlockUserManager
	{
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x19BCAF8", Offset = "0x19BCAF8", VA = "0x19BCAF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x19BCAE8", Offset = "0x19BCAE8", VA = "0x19BCAE8")]
		private set
		{
		}
	}

	[Token(Token = "0x6002887")]
	[Address(RVA = "0x19BC9C8", Offset = "0x19BC9C8", VA = "0x19BC9C8")]
	public XFriendSystem()
	{
	}

	[Token(Token = "0x600288E")]
	[Address(RVA = "0x19BCB00", Offset = "0x19BCB00", VA = "0x19BCB00")]
	internal void Clear()
	{
	}

	[Token(Token = "0x600288F")]
	[Address(RVA = "0x19BCBDC", Offset = "0x19BCBDC", VA = "0x19BCBDC")]
	public void AttachListener(IFriendListener listener)
	{
	}

	[Token(Token = "0x6002890")]
	[Address(RVA = "0x19BCCC0", Offset = "0x19BCCC0", VA = "0x19BCCC0")]
	public void DetachListener(IFriendListener listener)
	{
	}

	[Token(Token = "0x6002891")]
	[Address(RVA = "0x19BCDA4", Offset = "0x19BCDA4", VA = "0x19BCDA4")]
	public void Update(float delta)
	{
	}

	[Token(Token = "0x6002892")]
	[Address(RVA = "0x19BCDCC", Offset = "0x19BCDCC", VA = "0x19BCDCC")]
	public void PartyDataClear()
	{
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0x19BCDF4", Offset = "0x19BCDF4", VA = "0x19BCDF4")]
	internal bool BuildFriend(List<Friend> liFriend, [Optional] Action updateScrollView)
	{
		return default(bool);
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0x19BD020", Offset = "0x19BD020", VA = "0x19BD020")]
	public void ClearActionUIUpdate()
	{
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0x19BD02C", Offset = "0x19BD02C", VA = "0x19BD02C")]
	internal void BuildBlockUserList(List<Friend> blockUserList)
	{
	}

	[Token(Token = "0x6002896")]
	[Address(RVA = "0x19BD058", Offset = "0x19BD058", VA = "0x19BD058")]
	internal void UpdateBlockedMeUserList(List<string> blockUserList)
	{
	}

	[Token(Token = "0x6002897")]
	[Address(RVA = "0x19BD084", Offset = "0x19BD084", VA = "0x19BD084")]
	public void AttachBlockUserRefreshFunc(Action blockFriendRefreshFunc)
	{
	}

	[Token(Token = "0x6002898")]
	[Address(RVA = "0x19BD0A8", Offset = "0x19BD0A8", VA = "0x19BD0A8")]
	public void ClearBlockFriendRefreshFunc()
	{
	}

	[Token(Token = "0x6002899")]
	[Address(RVA = "0x19BD0D0", Offset = "0x19BD0D0", VA = "0x19BD0D0")]
	public void InvokeBlockFriendRefreshFunc()
	{
	}

	[Token(Token = "0x600289A")]
	[Address(RVA = "0x19BCE40", Offset = "0x19BCE40", VA = "0x19BCE40")]
	public bool RefreshFriendStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x600289B")]
	[Address(RVA = "0x19BD108", Offset = "0x19BD108", VA = "0x19BD108")]
	public bool RefreshFriendStatus(Action callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600289C")]
	[Address(RVA = "0x19BD308", Offset = "0x19BD308", VA = "0x19BD308")]
	public void OnRefreshFriendStatus(List<FriendInfo> friends)
	{
	}

	[Token(Token = "0x600289D")]
	[Address(RVA = "0x19BD50C", Offset = "0x19BD50C", VA = "0x19BD50C")]
	public bool IsExistFriendData()
	{
		return default(bool);
	}

	[Token(Token = "0x600289E")]
	[Address(RVA = "0x19BD534", Offset = "0x19BD534", VA = "0x19BD534")]
	public bool IsOnlineFriend(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600289F")]
	[Address(RVA = "0x19BD67C", Offset = "0x19BD67C", VA = "0x19BD67C")]
	public void SnsFriendInvite()
	{
	}

	[Token(Token = "0x60028A0")]
	[Address(RVA = "0x19BD9E0", Offset = "0x19BD9E0", VA = "0x19BD9E0")]
	private static void _003CSnsFriendInvite_003Em__ED(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
