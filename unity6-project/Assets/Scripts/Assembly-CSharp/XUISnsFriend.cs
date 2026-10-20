using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using NPA;

[Token(Token = "0x200103C")]
public class XUISnsFriend : UIBase, IToyFacebookListener, IScrollViewListener
{
	[Token(Token = "0x4005769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblFriendCount;

	[Token(Token = "0x400576A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UISprite sprSortLevel;

	[Token(Token = "0x400576B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UISprite sprSortTime;

	[Token(Token = "0x400576C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIButton btnConnect;

	[Token(Token = "0x400576D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public XUIScrollView FriendListView;

	[Token(Token = "0x400576E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblEmptyText;

	[Token(Token = "0x400576F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private SortType sortType;

	[Token(Token = "0x4005770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isAscendingLevel;

	[Token(Token = "0x4005771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool isAscendingTime;

	[Token(Token = "0x4005772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Func<FacebookFriend, int> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4005773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Func<FacebookFriend, int> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4005774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Func<FacebookFriend, DateTime> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x4005775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Func<FacebookFriend, DateTime> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x6007919")]
	[Address(RVA = "0x192DF3C", Offset = "0x192DF3C", VA = "0x192DF3C")]
	public XUISnsFriend()
	{
	}

	[Token(Token = "0x600791A")]
	[Address(RVA = "0x192DF44", Offset = "0x192DF44", VA = "0x192DF44")]
	public void Build()
	{
	}

	[Token(Token = "0x600791B")]
	[Address(RVA = "0x192DF48", Offset = "0x192DF48", VA = "0x192DF48", Slot = "9")]
	public override void Show()
	{
	}

	[Token(Token = "0x600791C")]
	[Address(RVA = "0x192E038", Offset = "0x192E038", VA = "0x192E038", Slot = "11")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600791D")]
	[Address(RVA = "0x192E118", Offset = "0x192E118", VA = "0x192E118", Slot = "12")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x600791E")]
	[Address(RVA = "0x192E158", Offset = "0x192E158", VA = "0x192E158")]
	private void SetFriendCount()
	{
	}

	[Token(Token = "0x600791F")]
	[Address(RVA = "0x192E2E4", Offset = "0x192E2E4", VA = "0x192E2E4")]
	private void SetSortButtons()
	{
	}

	[Token(Token = "0x6007920")]
	[Address(RVA = "0x192E97C", Offset = "0x192E97C", VA = "0x192E97C")]
	private void SetArrowSprite(UISprite sprite, bool active, bool isAscending)
	{
	}

	[Token(Token = "0x6007921")]
	[Address(RVA = "0x192E330", Offset = "0x192E330", VA = "0x192E330")]
	private void SetConnectButton()
	{
	}

	[Token(Token = "0x6007922")]
	[Address(RVA = "0x192E488", Offset = "0x192E488", VA = "0x192E488")]
	private void SetListView()
	{
	}

	[Token(Token = "0x6007923")]
	[Address(RVA = "0x192EB48", Offset = "0x192EB48", VA = "0x192EB48")]
	private IOrderedEnumerable<FacebookFriend> GetSortedList(List<FacebookFriend> list)
	{
		return null;
	}

	[Token(Token = "0x6007924")]
	[Address(RVA = "0x192E81C", Offset = "0x192E81C", VA = "0x192E81C")]
	private void SetEmptyText()
	{
	}

	[Token(Token = "0x6007925")]
	[Address(RVA = "0x192F0BC", Offset = "0x192F0BC", VA = "0x192F0BC", Slot = "17")]
	public void OnScrollViewEndPosition()
	{
	}

	[Token(Token = "0x6007926")]
	[Address(RVA = "0x192F188", Offset = "0x192F188", VA = "0x192F188", Slot = "13")]
	public void OnResponseConnect(NPErrorCode errno)
	{
	}

	[Token(Token = "0x6007927")]
	[Address(RVA = "0x192F18C", Offset = "0x192F18C", VA = "0x192F18C", Slot = "14")]
	public void OnResponseFriendList(ApiReturnCode errno, List<FacebookFriend> appendfriends)
	{
	}

	[Token(Token = "0x6007928")]
	[Address(RVA = "0x192F320", Offset = "0x192F320", VA = "0x192F320", Slot = "15")]
	public void OnResponseError(NPErrorCode errno)
	{
	}

	[Token(Token = "0x6007929")]
	[Address(RVA = "0x192F3C8", Offset = "0x192F3C8", VA = "0x192F3C8", Slot = "16")]
	public void OnResponseError(ApiReturnCode errno)
	{
	}

	[Token(Token = "0x600792A")]
	[Address(RVA = "0x192F470", Offset = "0x192F470", VA = "0x192F470")]
	public void OnClick_SortByLevel()
	{
	}

	[Token(Token = "0x600792B")]
	[Address(RVA = "0x192F4B4", Offset = "0x192F4B4", VA = "0x192F4B4")]
	public void OnClick_SortByTime()
	{
	}

	[Token(Token = "0x600792C")]
	[Address(RVA = "0x192F4F8", Offset = "0x192F4F8", VA = "0x192F4F8")]
	public void OnClick_Invite()
	{
	}

	[Token(Token = "0x600792D")]
	[Address(RVA = "0x192F55C", Offset = "0x192F55C", VA = "0x192F55C")]
	public void OnClick_Connect()
	{
	}

	[Token(Token = "0x600792E")]
	[Address(RVA = "0x192F734", Offset = "0x192F734", VA = "0x192F734")]
	private static int _003CGetSortedList_003Em__50D(FacebookFriend item)
	{
		return default(int);
	}

	[Token(Token = "0x600792F")]
	[Address(RVA = "0x192F764", Offset = "0x192F764", VA = "0x192F764")]
	private static int _003CGetSortedList_003Em__50E(FacebookFriend item)
	{
		return default(int);
	}

	[Token(Token = "0x6007930")]
	[Address(RVA = "0x192F794", Offset = "0x192F794", VA = "0x192F794")]
	private static DateTime _003CGetSortedList_003Em__50F(FacebookFriend item)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6007931")]
	[Address(RVA = "0x192F7C4", Offset = "0x192F7C4", VA = "0x192F7C4")]
	private static DateTime _003CGetSortedList_003Em__510(FacebookFriend item)
	{
		return default(DateTime);
	}
}
