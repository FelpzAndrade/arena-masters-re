using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E8F")]
public class XWidget_ClanJoin : XUIBaseWidget, IClanPanel
{
	[Token(Token = "0x2000E90")]
	private sealed class _003CRefreshCoolTimeButton_003Ec__IteratorAA : IDisposable
	{
		[Token(Token = "0x4004C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4004C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4004C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_ClanJoin _003C_003Ef__this;

		[Token(Token = "0x17000DEE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006CBC")]
			[Address(RVA = "0x15DB14C", Offset = "0x15DB14C", VA = "0x15DB14C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000DEF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006CBD")]
			[Address(RVA = "0x15DB154", Offset = "0x15DB154", VA = "0x15DB154", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0x15D98CC", Offset = "0x15D98CC", VA = "0x15D98CC")]
		public _003CRefreshCoolTimeButton_003Ec__IteratorAA()
		{
		}

		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0x15DB14C", Offset = "0x15DB14C", VA = "0x15DB14C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0x15DB154", Offset = "0x15DB154", VA = "0x15DB154", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0x15DB15C", Offset = "0x15DB15C", VA = "0x15DB15C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0x15DB268", Offset = "0x15DB268", VA = "0x15DB268", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0x15DB274", Offset = "0x15DB274", VA = "0x15DB274", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000E91")]
	private sealed class _003COnClick_Tab_003Ec__AnonStorey1FB
	{
		[Token(Token = "0x4004C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action tabSelectEndCallback;

		[Token(Token = "0x4004C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_ClanJoin _003C_003Ef__this;

		[Token(Token = "0x6006CC1")]
		[Address(RVA = "0x15D9E7C", Offset = "0x15D9E7C", VA = "0x15D9E7C")]
		public _003COnClick_Tab_003Ec__AnonStorey1FB()
		{
		}
	}

	[Token(Token = "0x2000E92")]
	private sealed class _003COnClick_Tab_003Ec__AnonStorey1FA
	{
		[Token(Token = "0x4004C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XListView_ClanList.ListType listType;

		[Token(Token = "0x4004C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal _003COnClick_Tab_003Ec__AnonStorey1FB _003C_003Ef__ref_0024507;

		[Token(Token = "0x4004C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_ClanJoin _003C_003Ef__this;

		[Token(Token = "0x6006CC2")]
		[Address(RVA = "0x15D9E84", Offset = "0x15D9E84", VA = "0x15D9E84")]
		public _003COnClick_Tab_003Ec__AnonStorey1FA()
		{
		}

		[Token(Token = "0x6006CC3")]
		[Address(RVA = "0x15DACB4", Offset = "0x15DACB4", VA = "0x15DACB4")]
		internal void _003C_003Em__3E9(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E93")]
	private sealed class _003COnClick_Tab_003Ec__AnonStorey1FC
	{
		[Token(Token = "0x4004C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XListView_ClanList.ListType listType;

		[Token(Token = "0x4004C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal _003COnClick_Tab_003Ec__AnonStorey1FB _003C_003Ef__ref_0024507;

		[Token(Token = "0x4004C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_ClanJoin _003C_003Ef__this;

		[Token(Token = "0x6006CC4")]
		[Address(RVA = "0x15D9E8C", Offset = "0x15D9E8C", VA = "0x15D9E8C")]
		public _003COnClick_Tab_003Ec__AnonStorey1FC()
		{
		}

		[Token(Token = "0x6006CC5")]
		[Address(RVA = "0x15DAFB4", Offset = "0x15DAFB4", VA = "0x15DAFB4")]
		internal void _003C_003Em__3EA(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004C6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject goSearchArea;

	[Token(Token = "0x4004C6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UIInput clanNameInput;

	[Token(Token = "0x4004C6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public XListView_ClanList m_clanListView;

	[Token(Token = "0x4004C6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblNoClan;

	[Token(Token = "0x4004C6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GameObject BtnRefresh;

	[Token(Token = "0x4004C70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string Path_ClanCreate;

	[Token(Token = "0x4004C71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private readonly string Path_ClanMemPopup;

	[Token(Token = "0x4004C72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XWidget_ClanCreate _clanCreate;

	[Token(Token = "0x4004C73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XWidget_ClanMemListPopup _clanMemPopup;

	[Token(Token = "0x4004C74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_isRefeshCoolTime;

	[Token(Token = "0x4004C75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Coroutine m_refreshCorutine;

	[Token(Token = "0x4004C76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<ClanMetaData> m_cacheJoinClanMetaData;

	[Token(Token = "0x4004C77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private List<ClanMetaData> m_cacheRequestClanMetaData;

	[Token(Token = "0x4004C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UILabel lblListName;

	[Token(Token = "0x4004C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Action<Netdata_Clan> m_refreshClanMain;

	[Token(Token = "0x4004C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CompletedClanMember m_myClanMemberInfo;

	[Token(Token = "0x4004C7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private XPanel_Clan.ClanTab m_curShowedTab;

	[Token(Token = "0x17000DEA")]
	public XWidget_ClanCreate widgetClanCreate
	{
		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0x15D8BB8", Offset = "0x15D8BB8", VA = "0x15D8BB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DEB")]
	public XWidget_ClanMemListPopup m_clanMemPopup
	{
		[Token(Token = "0x6006CA5")]
		[Address(RVA = "0x15D8CB8", Offset = "0x15D8CB8", VA = "0x15D8CB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DEC")]
	public XPanel_Clan.ClanTab FirstSelectTab
	{
		[Token(Token = "0x6006CA6")]
		[Address(RVA = "0x15D8DB8", Offset = "0x15D8DB8", VA = "0x15D8DB8", Slot = "18")]
		get
		{
			return default(XPanel_Clan.ClanTab);
		}
	}

	[Token(Token = "0x17000DED")]
	public CompletedClanMember MyClanMemberInfo
	{
		[Token(Token = "0x6006CA7")]
		[Address(RVA = "0x15D8DC0", Offset = "0x15D8DC0", VA = "0x15D8DC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006CA3")]
	[Address(RVA = "0x15D8B18", Offset = "0x15D8B18", VA = "0x15D8B18")]
	public XWidget_ClanJoin()
	{
	}

	[Token(Token = "0x6006CA8")]
	[Address(RVA = "0x15D8DC8", Offset = "0x15D8DC8", VA = "0x15D8DC8", Slot = "20")]
	public void Build(Netdata_Clan buildData, CompletedClanMember myClanMemberInfo, Action<Netdata_Clan> refreshClanMain)
	{
	}

	[Token(Token = "0x6006CA9")]
	[Address(RVA = "0x15D8DD4", Offset = "0x15D8DD4", VA = "0x15D8DD4", Slot = "25")]
	public List<XPanel_Clan.ClanTab> GetBuildTabEnums()
	{
		return null;
	}

	[Token(Token = "0x6006CAA")]
	[Address(RVA = "0x15D8EBC", Offset = "0x15D8EBC", VA = "0x15D8EBC", Slot = "22")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6006CAB")]
	[Address(RVA = "0x15D8F94", Offset = "0x15D8F94", VA = "0x15D8F94", Slot = "23")]
	public void OnClick_ListRefresh()
	{
	}

	[Token(Token = "0x6006CAC")]
	[Address(RVA = "0x15D9860", Offset = "0x15D9860", VA = "0x15D9860")]
	public void ResetRefreshButton(bool isEnable)
	{
	}

	[Token(Token = "0x6006CAD")]
	[Address(RVA = "0x15D97BC", Offset = "0x15D97BC", VA = "0x15D97BC")]
	[DebuggerHidden]
	private IEnumerator RefreshCoolTimeButton()
	{
		return null;
	}

	[Token(Token = "0x6006CAE")]
	[Address(RVA = "0x15D98D4", Offset = "0x15D98D4", VA = "0x15D98D4", Slot = "21")]
	public void OnClick_Search()
	{
	}

	[Token(Token = "0x6006CAF")]
	[Address(RVA = "0x15D9B50", Offset = "0x15D9B50", VA = "0x15D9B50")]
	private void BuildList(XListView_ClanList.ListType listType, List<ClanMetaData> clanDataList)
	{
	}

	[Token(Token = "0x6006CB0")]
	[Address(RVA = "0x15D9E70", Offset = "0x15D9E70", VA = "0x15D9E70")]
	private void RefreshBuildList()
	{
	}

	[Token(Token = "0x6006CB1")]
	[Address(RVA = "0x15D9C98", Offset = "0x15D9C98", VA = "0x15D9C98")]
	private void SetNoClanLabel(XListView_ClanList.ListType listType)
	{
	}

	[Token(Token = "0x6006CB2")]
	[Address(RVA = "0x15D9028", Offset = "0x15D9028", VA = "0x15D9028", Slot = "24")]
	public bool OnClick_Tab(XPanel_Clan.ClanTab tabEnum, [Optional] Action tabSelectEndCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x6006CB3")]
	[Address(RVA = "0x15D9E94", Offset = "0x15D9E94", VA = "0x15D9E94")]
	public void OnClick_ClanCreate()
	{
	}

	[Token(Token = "0x6006CB4")]
	[Address(RVA = "0x15DA00C", Offset = "0x15DA00C", VA = "0x15DA00C")]
	public void ShowClanCreatePopup(int defaultMarkID, int defaultColorID)
	{
	}

	[Token(Token = "0x6006CB5")]
	[Address(RVA = "0x15DA054", Offset = "0x15DA054", VA = "0x15DA054", Slot = "26")]
	public void Show()
	{
	}

	[Token(Token = "0x6006CB6")]
	[Address(RVA = "0x15DA0A0", Offset = "0x15DA0A0", VA = "0x15DA0A0", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006CB7")]
	[Address(RVA = "0x15DA2B8", Offset = "0x15DA2B8", VA = "0x15DA2B8")]
	public void OnClick_Detail(ClanMetaData clanData)
	{
	}

	[Token(Token = "0x6006CB8")]
	[Address(RVA = "0x15DA4E8", Offset = "0x15DA4E8", VA = "0x15DA4E8")]
	public void ShowClanMemberPopup(string clanName, List<CompletedClanMember> memList)
	{
	}

	[Token(Token = "0x6006CB9")]
	[Address(RVA = "0x15DA6B8", Offset = "0x15DA6B8", VA = "0x15DA6B8")]
	private void _003COnClick_Search_003Em__3E8(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006CBA")]
	[Address(RVA = "0x15DAB64", Offset = "0x15DAB64", VA = "0x15DAB64")]
	private void _003COnClick_Detail_003Em__3EB(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
