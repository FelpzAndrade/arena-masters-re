using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DDE")]
public class XPanel_Friend : MonoBehaviour
{
	[Token(Token = "0x2000DDF")]
	private sealed class _003CRefreshCoolTimeButton_003Ec__IteratorA4 : IDisposable
	{
		[Token(Token = "0x400485D")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x400485E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400485F")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Friend _003C_003Ef__this;

		[Token(Token = "0x17000D62")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006678")]
			[Address(RVA = "0x16BD84C", Offset = "0x16BD84C", VA = "0x16BD84C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D63")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006679")]
			[Address(RVA = "0x16BD854", Offset = "0x16BD854", VA = "0x16BD854", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006677")]
		[Address(RVA = "0x16BAF90", Offset = "0x16BAF90", VA = "0x16BAF90")]
		public _003CRefreshCoolTimeButton_003Ec__IteratorA4()
		{
		}

		[Token(Token = "0x6006678")]
		[Address(RVA = "0x16BD84C", Offset = "0x16BD84C", VA = "0x16BD84C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006679")]
		[Address(RVA = "0x16BD854", Offset = "0x16BD854", VA = "0x16BD854", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600667A")]
		[Address(RVA = "0x16BD85C", Offset = "0x16BD85C", VA = "0x16BD85C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600667B")]
		[Address(RVA = "0x16BD968", Offset = "0x16BD968", VA = "0x16BD968", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600667C")]
		[Address(RVA = "0x16BD974", Offset = "0x16BD974", VA = "0x16BD974", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000DE0")]
	private sealed class _003CRefreshFriendList_003Ec__AnonStorey1C7
	{
		[Token(Token = "0x4004860")]
		[FieldOffset(Offset = "0x8")]
		internal bool isKeepScrollView;

		[Token(Token = "0x4004861")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Friend _003C_003Ef__this;

		[Token(Token = "0x600667D")]
		[Address(RVA = "0xFCBDAC", Offset = "0xFCBDAC", VA = "0xFCBDAC")]
		public _003CRefreshFriendList_003Ec__AnonStorey1C7()
		{
		}

		[Token(Token = "0x600667E")]
		[Address(RVA = "0xFCBDB4", Offset = "0xFCBDB4", VA = "0xFCBDB4")]
		internal void _003C_003Em__35E(ApiReturnCode result, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x600667F")]
		[Address(RVA = "0xFCBFD4", Offset = "0xFCBFD4", VA = "0xFCBFD4")]
		internal void _003C_003Em__373()
		{
		}
	}

	[Token(Token = "0x2000DE1")]
	private sealed class _003CRefreshBlockUserList_003Ec__AnonStorey1C8
	{
		[Token(Token = "0x4004862")]
		[FieldOffset(Offset = "0x8")]
		internal bool isKeepScrollView;

		[Token(Token = "0x4004863")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Friend _003C_003Ef__this;

		[Token(Token = "0x6006680")]
		[Address(RVA = "0x16B9B88", Offset = "0x16B9B88", VA = "0x16B9B88")]
		public _003CRefreshBlockUserList_003Ec__AnonStorey1C8()
		{
		}

		[Token(Token = "0x6006681")]
		[Address(RVA = "0x16BD6BC", Offset = "0x16BD6BC", VA = "0x16BD6BC")]
		internal void _003C_003Em__361(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000DE2")]
	private sealed class _003CRefreshFriendRequest_003Ec__AnonStorey1C9
	{
		[Token(Token = "0x2000DE3")]
		private sealed class _003CRefreshFriendRequest_003Ec__AnonStorey1CA
		{
			[Token(Token = "0x4004866")]
			[FieldOffset(Offset = "0x8")]
			internal List<Friend> requestList;

			[Token(Token = "0x4004867")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRefreshFriendRequest_003Ec__AnonStorey1C9 _003C_003Ef__ref_0024457;

			[Token(Token = "0x6006684")]
			[Address(RVA = "0xFCC4C8", Offset = "0xFCC4C8", VA = "0xFCC4C8")]
			public _003CRefreshFriendRequest_003Ec__AnonStorey1CA()
			{
			}

			[Token(Token = "0x6006685")]
			[Address(RVA = "0xFCC4D0", Offset = "0xFCC4D0", VA = "0xFCC4D0")]
			internal void _003C_003Em__374()
			{
			}
		}

		[Token(Token = "0x4004864")]
		[FieldOffset(Offset = "0x8")]
		internal bool isKeepScrollPos;

		[Token(Token = "0x4004865")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Friend _003C_003Ef__this;

		[Token(Token = "0x6006682")]
		[Address(RVA = "0xFCC0D8", Offset = "0xFCC0D8", VA = "0xFCC0D8")]
		public _003CRefreshFriendRequest_003Ec__AnonStorey1C9()
		{
		}

		[Token(Token = "0x6006683")]
		[Address(RVA = "0xFCC0E0", Offset = "0xFCC0E0", VA = "0xFCC0E0")]
		internal void _003C_003Em__36D(ApiReturnCode result_1, string errmsg_1, JObject json_1)
		{
		}
	}

	[Token(Token = "0x2000DE4")]
	private sealed class _003CSetRequestFriendShip_003Ec__AnonStorey1CB
	{
		[Token(Token = "0x4004868")]
		[FieldOffset(Offset = "0x8")]
		internal string aid;

		[Token(Token = "0x4004869")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Friend _003C_003Ef__this;

		[Token(Token = "0x6006686")]
		[Address(RVA = "0xFCC5EC", Offset = "0xFCC5EC", VA = "0xFCC5EC")]
		public _003CSetRequestFriendShip_003Ec__AnonStorey1CB()
		{
		}

		[Token(Token = "0x6006687")]
		[Address(RVA = "0xFCC5F4", Offset = "0xFCC5F4", VA = "0xFCC5F4")]
		internal void _003C_003Em__36E()
		{
		}

		[Token(Token = "0x6006688")]
		[Address(RVA = "0xFCC6F0", Offset = "0xFCC6F0", VA = "0xFCC6F0")]
		internal void _003C_003Em__36F()
		{
		}

		[Token(Token = "0x6006689")]
		[Address(RVA = "0xFCC718", Offset = "0xFCC718", VA = "0xFCC718")]
		internal void _003C_003Em__375()
		{
		}
	}

	[Token(Token = "0x2000DE5")]
	private sealed class _003CRemoveRefrechRecommandList_003Ec__AnonStorey1CC
	{
		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x8")]
		internal string aid;

		[Token(Token = "0x600668A")]
		[Address(RVA = "0xFCC50C", Offset = "0xFCC50C", VA = "0xFCC50C")]
		public _003CRemoveRefrechRecommandList_003Ec__AnonStorey1CC()
		{
		}

		[Token(Token = "0x600668B")]
		[Address(RVA = "0xFCC514", Offset = "0xFCC514", VA = "0xFCC514")]
		internal bool _003C_003Em__370(Friend x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400482C")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_ToggleTab[] tabs;

	[Token(Token = "0x400482D")]
	[FieldOffset(Offset = "0x10")]
	public GameObject gameFriend;

	[Token(Token = "0x400482E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject gameFriendMake;

	[Token(Token = "0x400482F")]
	[FieldOffset(Offset = "0x18")]
	public XUISnsFriendInvite snsFriendInvite;

	[Token(Token = "0x4004830")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject gameBlockFriend;

	[Token(Token = "0x4004831")]
	[FieldOffset(Offset = "0x20")]
	public XUIFriendList m_friendList;

	[Token(Token = "0x4004832")]
	[FieldOffset(Offset = "0x24")]
	public XUIFriendRecommendList m_recommendList;

	[Token(Token = "0x4004833")]
	[FieldOffset(Offset = "0x28")]
	public XUIFriendRequestList m_requestList;

	[Token(Token = "0x4004834")]
	[FieldOffset(Offset = "0x2C")]
	public XUIBlockFriendList m_blockFriendList;

	[Token(Token = "0x4004835")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblFriendCount;

	[Token(Token = "0x4004836")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblRequestCount;

	[Token(Token = "0x4004837")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblBlockFriendCount;

	[Token(Token = "0x4004838")]
	[FieldOffset(Offset = "0x3C")]
	public UIInput InputName;

	[Token(Token = "0x4004839")]
	[FieldOffset(Offset = "0x40")]
	private string user_name;

	[Token(Token = "0x400483A")]
	[FieldOffset(Offset = "0x44")]
	public UISprite sprLevelSortArrow;

	[Token(Token = "0x400483B")]
	[FieldOffset(Offset = "0x48")]
	public UISprite sprLevelSortArrowActive;

	[Token(Token = "0x400483C")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite sprTimeSortArrow;

	[Token(Token = "0x400483D")]
	[FieldOffset(Offset = "0x50")]
	public UISprite sprTimeSortArrowActive;

	[Token(Token = "0x400483E")]
	[FieldOffset(Offset = "0x54")]
	public UISprite sprNameSortArrow;

	[Token(Token = "0x400483F")]
	[FieldOffset(Offset = "0x58")]
	public UISprite sprNameSortArrowActive;

	[Token(Token = "0x4004840")]
	[FieldOffset(Offset = "0x5C")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x4004841")]
	[FieldOffset(Offset = "0x60")]
	public UILabel lblIsFriendList;

	[Token(Token = "0x4004842")]
	[FieldOffset(Offset = "0x64")]
	public UILabel lblIsRequestList;

	[Token(Token = "0x4004843")]
	[FieldOffset(Offset = "0x68")]
	public UILabel lblIsRecommendList;

	[Token(Token = "0x4004844")]
	[FieldOffset(Offset = "0x6C")]
	public XWidget_NewBadge friendSocializeTabNewBadge;

	[Token(Token = "0x4004845")]
	[FieldOffset(Offset = "0x70")]
	public GameObject BtnRefresh;

	[Token(Token = "0x4004846")]
	[FieldOffset(Offset = "0x74")]
	private bool m_isRefeshCoolTime;

	[Token(Token = "0x4004847")]
	[FieldOffset(Offset = "0x78")]
	private Coroutine m_refreshCorutine;

	[Token(Token = "0x4004848")]
	[FieldOffset(Offset = "0x7C")]
	private List<XFriendData> m_cacheFriendData;

	[Token(Token = "0x4004849")]
	[FieldOffset(Offset = "0x80")]
	private List<Friend> m_cacheWaitFriendData;

	[Token(Token = "0x400484A")]
	[FieldOffset(Offset = "0x84")]
	private List<Friend> m_cacheRecommandedFriendData;

	[Token(Token = "0x400484B")]
	[FieldOffset(Offset = "0x88")]
	private List<Friend> m_cacheBlockUserData;

	[Token(Token = "0x400484C")]
	[FieldOffset(Offset = "0x8C")]
	private bool IsRemoveHandling;

	[Token(Token = "0x400484D")]
	[FieldOffset(Offset = "0x8D")]
	private bool levelSort;

	[Token(Token = "0x400484E")]
	[FieldOffset(Offset = "0x8E")]
	private bool IsLevelAsend;

	[Token(Token = "0x400484F")]
	[FieldOffset(Offset = "0x8F")]
	private bool timeSort;

	[Token(Token = "0x4004850")]
	[FieldOffset(Offset = "0x90")]
	private bool isTimeAsend;

	[Token(Token = "0x4004851")]
	[FieldOffset(Offset = "0x91")]
	private bool IsNameAsend;

	[Token(Token = "0x4004852")]
	[FieldOffset(Offset = "0x92")]
	private bool sendAllPoint;

	[Token(Token = "0x4004853")]
	[FieldOffset(Offset = "0x93")]
	private bool friendSearch;

	[Token(Token = "0x4004854")]
	[FieldOffset(Offset = "0x94")]
	private bool requestFriendShip;

	[Token(Token = "0x4004855")]
	[FieldOffset(Offset = "0x95")]
	private bool acceptFriendShip;

	[Token(Token = "0x4004856")]
	[FieldOffset(Offset = "0x96")]
	private bool rejectFriendShip;

	[Token(Token = "0x4004857")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XFriendData, int> _003C_003Ef__am_0024cache2B;

	[Token(Token = "0x4004858")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XFriendData, int> _003C_003Ef__am_0024cache2C;

	[Token(Token = "0x4004859")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XFriendData, DateTime> _003C_003Ef__am_0024cache2D;

	[Token(Token = "0x400485A")]
	[FieldOffset(Offset = "0xC")]
	private static Func<XFriendData, DateTime> _003C_003Ef__am_0024cache2E;

	[Token(Token = "0x400485B")]
	[FieldOffset(Offset = "0x10")]
	private static Func<Friend, string> _003C_003Ef__am_0024cache2F;

	[Token(Token = "0x400485C")]
	[FieldOffset(Offset = "0x14")]
	private static Func<Friend, string> _003C_003Ef__am_0024cache30;

	[Token(Token = "0x6006633")]
	[Address(RVA = "0x16B85A8", Offset = "0x16B85A8", VA = "0x16B85A8")]
	public XPanel_Friend()
	{
	}

	[Token(Token = "0x6006634")]
	[Address(RVA = "0x16B8674", Offset = "0x16B8674", VA = "0x16B8674")]
	public void Build()
	{
	}

	[Token(Token = "0x6006635")]
	[Address(RVA = "0x16B86DC", Offset = "0x16B86DC", VA = "0x16B86DC")]
	public void Show()
	{
	}

	[Token(Token = "0x6006636")]
	[Address(RVA = "0x16B8890", Offset = "0x16B8890", VA = "0x16B8890")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006637")]
	[Address(RVA = "0x16B89F4", Offset = "0x16B89F4", VA = "0x16B89F4")]
	public void OnClickTabs(int type)
	{
	}

	[Token(Token = "0x6006638")]
	[Address(RVA = "0x16B8828", Offset = "0x16B8828", VA = "0x16B8828")]
	public void ShowGameFriend()
	{
	}

	[Token(Token = "0x6006639")]
	[Address(RVA = "0x16B8EE8", Offset = "0x16B8EE8", VA = "0x16B8EE8")]
	public void ShowGameBlockFriend()
	{
	}

	[Token(Token = "0x600663A")]
	[Address(RVA = "0x16B915C", Offset = "0x16B915C", VA = "0x16B915C")]
	private void ScrollViewBackupAndRestore(UIScrollView targetScrollView, Action processBuildList)
	{
	}

	[Token(Token = "0x600663B")]
	[Address(RVA = "0x16B8C9C", Offset = "0x16B8C9C", VA = "0x16B8C9C")]
	private void RefreshFriendList(bool isKeepScrollView)
	{
	}

	[Token(Token = "0x600663C")]
	[Address(RVA = "0x16B9300", Offset = "0x16B9300", VA = "0x16B9300")]
	private void UpdateFriendScollView(bool isKeepScrollView)
	{
	}

	[Token(Token = "0x600663D")]
	[Address(RVA = "0x16B9440", Offset = "0x16B9440", VA = "0x16B9440")]
	private void SetSort()
	{
	}

	[Token(Token = "0x600663E")]
	[Address(RVA = "0x16B9958", Offset = "0x16B9958", VA = "0x16B9958")]
	public void MyFriendRemove(string aid)
	{
	}

	[Token(Token = "0x600663F")]
	[Address(RVA = "0x16B8F24", Offset = "0x16B8F24", VA = "0x16B8F24")]
	private void RefreshBlockUserList(bool isKeepScrollView)
	{
	}

	[Token(Token = "0x6006640")]
	[Address(RVA = "0x16B9B90", Offset = "0x16B9B90", VA = "0x16B9B90")]
	private void UpdateBlockUserScollView(bool isKeepScrollView)
	{
	}

	[Token(Token = "0x6006641")]
	[Address(RVA = "0x16B9CD4", Offset = "0x16B9CD4", VA = "0x16B9CD4")]
	private void SetBlockFriendSort()
	{
	}

	[Token(Token = "0x6006642")]
	[Address(RVA = "0x16B9F3C", Offset = "0x16B9F3C", VA = "0x16B9F3C")]
	public void BlockFriendRemove(string aid)
	{
	}

	[Token(Token = "0x6006643")]
	[Address(RVA = "0x16BA16C", Offset = "0x16BA16C", VA = "0x16BA16C")]
	private void RefreshBlockUserList()
	{
	}

	[Token(Token = "0x6006644")]
	[Address(RVA = "0x16BA264", Offset = "0x16BA264", VA = "0x16BA264")]
	private void SetActiveTimeSort(bool isActive)
	{
	}

	[Token(Token = "0x6006645")]
	[Address(RVA = "0x16BA2A8", Offset = "0x16BA2A8", VA = "0x16BA2A8")]
	private void SetActiveLevelSort(bool isActive)
	{
	}

	[Token(Token = "0x6006646")]
	[Address(RVA = "0x16BA2EC", Offset = "0x16BA2EC", VA = "0x16BA2EC")]
	private void SetActiveNameSort(bool isActive)
	{
	}

	[Token(Token = "0x6006647")]
	[Address(RVA = "0x16B9480", Offset = "0x16B9480", VA = "0x16B9480")]
	public void BuildLevelSorting(bool isAscend)
	{
	}

	[Token(Token = "0x6006648")]
	[Address(RVA = "0x16BA3D8", Offset = "0x16BA3D8", VA = "0x16BA3D8")]
	private void BuildFriendList(List<XFriendData> sortedList)
	{
	}

	[Token(Token = "0x6006649")]
	[Address(RVA = "0x16BA590", Offset = "0x16BA590", VA = "0x16BA590")]
	public void OnClick_SortedLevel()
	{
	}

	[Token(Token = "0x600664A")]
	[Address(RVA = "0x16BA5E0", Offset = "0x16BA5E0", VA = "0x16BA5E0")]
	public void OnClick_SortedLastTime()
	{
	}

	[Token(Token = "0x600664B")]
	[Address(RVA = "0x16B96EC", Offset = "0x16B96EC", VA = "0x16B96EC")]
	private void BuildLastTimeSorting(bool isAscend)
	{
	}

	[Token(Token = "0x600664C")]
	[Address(RVA = "0x16BA630", Offset = "0x16BA630", VA = "0x16BA630")]
	public void OnClick_SortedName()
	{
	}

	[Token(Token = "0x600664D")]
	[Address(RVA = "0x16B9CDC", Offset = "0x16B9CDC", VA = "0x16B9CDC")]
	private void BuildNameSorting(bool isAscend)
	{
	}

	[Token(Token = "0x600664E")]
	[Address(RVA = "0x16BA64C", Offset = "0x16BA64C", VA = "0x16BA64C")]
	private void BuildBlockFriendList(List<Friend> sortedList)
	{
	}

	[Token(Token = "0x600664F")]
	[Address(RVA = "0x16BA330", Offset = "0x16BA330", VA = "0x16BA330")]
	private void SetArrowRotation(UISprite sprArrow, UISprite sprActiveArrow, bool isAscend)
	{
	}

	[Token(Token = "0x6006650")]
	[Address(RVA = "0x16BA7B0", Offset = "0x16BA7B0", VA = "0x16BA7B0")]
	public void OnClick_AllFriendPoint()
	{
	}

	[Token(Token = "0x6006651")]
	[Address(RVA = "0x16BA7B4", Offset = "0x16BA7B4", VA = "0x16BA7B4")]
	private void SendAllFriendPoint()
	{
	}

	[Token(Token = "0x6006652")]
	[Address(RVA = "0x16BA9A0", Offset = "0x16BA9A0", VA = "0x16BA9A0")]
	public void ShowGameFriendSocialize()
	{
	}

	[Token(Token = "0x6006653")]
	[Address(RVA = "0x16BAC20", Offset = "0x16BAC20", VA = "0x16BAC20")]
	private void RefreshFriendSocializeList()
	{
	}

	[Token(Token = "0x6006654")]
	[Address(RVA = "0x16BAE60", Offset = "0x16BAE60", VA = "0x16BAE60")]
	public void OnClick_RecommendFriendList()
	{
	}

	[Token(Token = "0x6006655")]
	[Address(RVA = "0x16B8C30", Offset = "0x16B8C30", VA = "0x16B8C30")]
	public void ResetRefreshButton(bool isEnable)
	{
	}

	[Token(Token = "0x6006656")]
	[Address(RVA = "0x16BAEEC", Offset = "0x16BAEEC", VA = "0x16BAEEC")]
	[DebuggerHidden]
	private IEnumerator RefreshCoolTimeButton()
	{
		return null;
	}

	[Token(Token = "0x6006657")]
	[Address(RVA = "0x16BAE14", Offset = "0x16BAE14", VA = "0x16BAE14")]
	private void RefreshRecommandedFriendList(List<Friend> recommandList)
	{
	}

	[Token(Token = "0x6006658")]
	[Address(RVA = "0x16BAF98", Offset = "0x16BAF98", VA = "0x16BAF98")]
	private void SetRecommendListLabel(List<Friend> recommandList)
	{
	}

	[Token(Token = "0x6006659")]
	[Address(RVA = "0x16BB260", Offset = "0x16BB260", VA = "0x16BB260")]
	public void OnClick_SearchFriend()
	{
	}

	[Token(Token = "0x600665A")]
	[Address(RVA = "0x16BB4F0", Offset = "0x16BB4F0", VA = "0x16BB4F0")]
	private void SearchFriend()
	{
	}

	[Token(Token = "0x600665B")]
	[Address(RVA = "0x16BA9E4", Offset = "0x16BA9E4", VA = "0x16BA9E4")]
	private void RefreshFriendRequest(bool isKeepScrollPos)
	{
	}

	[Token(Token = "0x600665C")]
	[Address(RVA = "0x16BB708", Offset = "0x16BB708", VA = "0x16BB708")]
	private void RefreshRequestFriendList(List<Friend> requestList)
	{
	}

	[Token(Token = "0x600665D")]
	[Address(RVA = "0x16BB8BC", Offset = "0x16BB8BC", VA = "0x16BB8BC")]
	public void SetRequestFriendShip(string aid)
	{
	}

	[Token(Token = "0x600665E")]
	[Address(RVA = "0x16BBA14", Offset = "0x16BBA14", VA = "0x16BBA14")]
	private void RemoveRefrechRecommandList(string aid)
	{
	}

	[Token(Token = "0x600665F")]
	[Address(RVA = "0x16BBB74", Offset = "0x16BBB74", VA = "0x16BBB74")]
	public void AcceptRequestFriend(string aid)
	{
	}

	[Token(Token = "0x6006660")]
	[Address(RVA = "0x16BBDAC", Offset = "0x16BBDAC", VA = "0x16BBDAC")]
	public void UserRejectFriend(string aid)
	{
	}

	[Token(Token = "0x6006661")]
	[Address(RVA = "0x16BBFE4", Offset = "0x16BBFE4", VA = "0x16BBFE4")]
	public void RefreshOneFriendPointCoolTime(string aid)
	{
	}

	[Token(Token = "0x6006662")]
	[Address(RVA = "0x16BB0C8", Offset = "0x16BB0C8", VA = "0x16BB0C8")]
	private void SetFriendTutorialObject()
	{
	}

	[Token(Token = "0x6006663")]
	[Address(RVA = "0x16BC010", Offset = "0x16BC010", VA = "0x16BC010")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6006664")]
	[Address(RVA = "0x16B8864", Offset = "0x16B8864", VA = "0x16B8864")]
	private void RefreshNewBadge()
	{
	}

	[Token(Token = "0x6006665")]
	[Address(RVA = "0x16BC0E8", Offset = "0x16BC0E8", VA = "0x16BC0E8")]
	public void OnClick_SnsFriend()
	{
	}

	[Token(Token = "0x6006666")]
	[Address(RVA = "0x16B8A48", Offset = "0x16B8A48", VA = "0x16B8A48")]
	private void SetViewVisible(FriendTabType tab)
	{
	}

	[Token(Token = "0x6006667")]
	[Address(RVA = "0x16BC0EC", Offset = "0x16BC0EC", VA = "0x16BC0EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006668")]
	[Address(RVA = "0x16BC1B8", Offset = "0x16BC1B8", VA = "0x16BC1B8")]
	private void _003CUpdateFriendScollView_003Em__35F()
	{
	}

	[Token(Token = "0x6006669")]
	[Address(RVA = "0x16BC1BC", Offset = "0x16BC1BC", VA = "0x16BC1BC")]
	private void _003CMyFriendRemove_003Em__360(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x600666A")]
	[Address(RVA = "0x16BC3D0", Offset = "0x16BC3D0", VA = "0x16BC3D0")]
	private void _003CUpdateBlockUserScollView_003Em__362()
	{
	}

	[Token(Token = "0x600666B")]
	[Address(RVA = "0x16BC3D8", Offset = "0x16BC3D8", VA = "0x16BC3D8")]
	private void _003CBlockFriendRemove_003Em__363(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x600666C")]
	[Address(RVA = "0x16BC40C", Offset = "0x16BC40C", VA = "0x16BC40C")]
	private static int _003CBuildLevelSorting_003Em__364(XFriendData o)
	{
		return default(int);
	}

	[Token(Token = "0x600666D")]
	[Address(RVA = "0x16BC448", Offset = "0x16BC448", VA = "0x16BC448")]
	private static int _003CBuildLevelSorting_003Em__365(XFriendData o)
	{
		return default(int);
	}

	[Token(Token = "0x600666E")]
	[Address(RVA = "0x16BC484", Offset = "0x16BC484", VA = "0x16BC484")]
	private static DateTime _003CBuildLastTimeSorting_003Em__366(XFriendData o)
	{
		return default(DateTime);
	}

	[Token(Token = "0x600666F")]
	[Address(RVA = "0x16BC4CC", Offset = "0x16BC4CC", VA = "0x16BC4CC")]
	private static DateTime _003CBuildLastTimeSorting_003Em__367(XFriendData o)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6006670")]
	[Address(RVA = "0x16BC514", Offset = "0x16BC514", VA = "0x16BC514")]
	private static string _003CBuildNameSorting_003Em__368(Friend o)
	{
		return null;
	}

	[Token(Token = "0x6006671")]
	[Address(RVA = "0x16BC540", Offset = "0x16BC540", VA = "0x16BC540")]
	private static string _003CBuildNameSorting_003Em__369(Friend o)
	{
		return null;
	}

	[Token(Token = "0x6006672")]
	[Address(RVA = "0x16BC56C", Offset = "0x16BC56C", VA = "0x16BC56C")]
	private void _003CSendAllFriendPoint_003Em__36A(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6006673")]
	[Address(RVA = "0x16BCA40", Offset = "0x16BCA40", VA = "0x16BCA40")]
	private void _003CRefreshFriendSocializeList_003Em__36B(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6006674")]
	[Address(RVA = "0x16BCCF0", Offset = "0x16BCCF0", VA = "0x16BCCF0")]
	private void _003CSearchFriend_003Em__36C(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6006675")]
	[Address(RVA = "0x16BD1AC", Offset = "0x16BD1AC", VA = "0x16BD1AC")]
	private void _003CAcceptRequestFriend_003Em__371(ApiReturnCode result, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6006676")]
	[Address(RVA = "0x16BD690", Offset = "0x16BD690", VA = "0x16BD690")]
	private void _003CUserRejectFriend_003Em__372(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
