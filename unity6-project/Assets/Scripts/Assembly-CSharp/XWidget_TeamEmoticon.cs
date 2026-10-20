using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FF1")]
public class XWidget_TeamEmoticon : XUIBaseWidget
{
	[Token(Token = "0x2000FF2")]
	public static class UILogic
	{
		[Token(Token = "0x60076ED")]
		[Address(RVA = "0x1B143C0", Offset = "0x1B143C0", VA = "0x1B143C0")]
		public static bool IsEmoticonSetOpened(int emoticonSetId)
		{
			return default(bool);
		}

		[Token(Token = "0x60076EE")]
		[Address(RVA = "0x1B14C44", Offset = "0x1B14C44", VA = "0x1B14C44")]
		public static bool IsUsed(int nEmoticonSetID)
		{
			return default(bool);
		}

		[Token(Token = "0x60076EF")]
		[Address(RVA = "0x1B14584", Offset = "0x1B14584", VA = "0x1B14584")]
		public static CSEmoticonSetInfo GetUsingEmoticonInfo()
		{
			return null;
		}

		[Token(Token = "0x60076F0")]
		[Address(RVA = "0x1B14658", Offset = "0x1B14658", VA = "0x1B14658")]
		public static CSEmoticonSetInfo GetEmoticonSetInfo(int id)
		{
			return null;
		}

		[Token(Token = "0x60076F1")]
		[Address(RVA = "0x1B15550", Offset = "0x1B15550", VA = "0x1B15550")]
		public static bool CanBuy(CSEmoticonSetInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60076F2")]
		[Address(RVA = "0x1B14484", Offset = "0x1B14484", VA = "0x1B14484")]
		public static bool Showable(CSEmoticonSetInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60076F3")]
		[Address(RVA = "0x1B157D0", Offset = "0x1B157D0", VA = "0x1B157D0")]
		public static TimeSpan GetRemainTime(CSEmoticonSetInfo info)
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x2000FF3")]
	private sealed class _003CReqUseEmoticon_003Ec__AnonStorey24D
	{
		[Token(Token = "0x400551B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int nSelectedEmoticonId;

		[Token(Token = "0x400551C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_TeamEmoticon _003C_003Ef__this;

		[Token(Token = "0x60076F4")]
		[Address(RVA = "0x1B15EE4", Offset = "0x1B15EE4", VA = "0x1B15EE4")]
		public _003CReqUseEmoticon_003Ec__AnonStorey24D()
		{
		}

		[Token(Token = "0x60076F5")]
		[Address(RVA = "0x1B16348", Offset = "0x1B16348", VA = "0x1B16348")]
		internal void _003C_003Em__4E9(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000FF4")]
	private sealed class _003CReqBuyEmoticon_003Ec__AnonStorey24E
	{
		[Token(Token = "0x400551D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal CSEmoticonSetInfo info;

		[Token(Token = "0x400551E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_TeamEmoticon _003C_003Ef__this;

		[Token(Token = "0x60076F6")]
		[Address(RVA = "0x1B16130", Offset = "0x1B16130", VA = "0x1B16130")]
		public _003CReqBuyEmoticon_003Ec__AnonStorey24E()
		{
		}

		[Token(Token = "0x60076F7")]
		[Address(RVA = "0x1B16250", Offset = "0x1B16250", VA = "0x1B16250")]
		internal void _003C_003Em__4EA(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x400550D")]
	public const string Path = "Prefab/UI/Lobby/teamMgr/teamMGRBuyPopup";

	[Token(Token = "0x400550E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CSEmoticonSetInfo m_selected;

	[Token(Token = "0x400550F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XUIEmoticonItem m_SelectedItem;

	[Token(Token = "0x4005510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XUIEmoticonItem m_usingItem;

	[Token(Token = "0x4005511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XUIEmoticonListView m_EmoticonListView;

	[Token(Token = "0x4005512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblDetailTitle;

	[Token(Token = "0x4005513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XWidget_Button btn;

	[Token(Token = "0x4005514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GameObject conditionRoot;

	[Token(Token = "0x4005515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UILabel lblCondition;

	[Token(Token = "0x4005516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UILabel lblRemainTime;

	[Token(Token = "0x4005517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action getTitleAction;

	[Token(Token = "0x4005518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public XWiget_GridBuilder SubItemGrid;

	[Token(Token = "0x4005519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool m_updateRemainTime;

	[Token(Token = "0x400551A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private XWidget_TeamMGRBuyPopup _buyPopup;

	[Token(Token = "0x17000EE5")]
	public XWidget_TeamMGRBuyPopup buyPopup
	{
		[Token(Token = "0x60076DB")]
		[Address(RVA = "0x1B13E80", Offset = "0x1B13E80", VA = "0x1B13E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076DA")]
	[Address(RVA = "0x1B13E78", Offset = "0x1B13E78", VA = "0x1B13E78")]
	public XWidget_TeamEmoticon()
	{
	}

	[Token(Token = "0x60076DC")]
	[Address(RVA = "0x1B13F88", Offset = "0x1B13F88", VA = "0x1B13F88")]
	public void Build(Action getTitle, [Optional] CSEmoticonSetInfo selectedInfo)
	{
	}

	[Token(Token = "0x60076DD")]
	[Address(RVA = "0x1B14AEC", Offset = "0x1B14AEC", VA = "0x1B14AEC")]
	private void RefreshemoticonItem(XUIEmoticonItem emoticonItem)
	{
	}

	[Token(Token = "0x60076DE")]
	[Address(RVA = "0x1B14D24", Offset = "0x1B14D24", VA = "0x1B14D24")]
	public void OnSelect(XUIEmoticonItem uiTitleItem)
	{
	}

	[Token(Token = "0x60076DF")]
	[Address(RVA = "0x1B14760", Offset = "0x1B14760", VA = "0x1B14760")]
	public void SelectEmoticonItem(XUIEmoticonItem uiEmoticonItem)
	{
	}

	[Token(Token = "0x60076E0")]
	[Address(RVA = "0x1B1492C", Offset = "0x1B1492C", VA = "0x1B1492C")]
	public void CheckUsingEmoticonItem(XUIEmoticonItem uiEmoticonItem)
	{
	}

	[Token(Token = "0x60076E1")]
	[Address(RVA = "0x1B14D28", Offset = "0x1B14D28", VA = "0x1B14D28")]
	public void RefreshDetail(CSEmoticonSetInfo emoticonInfo)
	{
	}

	[Token(Token = "0x60076E2")]
	[Address(RVA = "0x1B15010", Offset = "0x1B15010", VA = "0x1B15010")]
	private void BuildButton(CSEmoticonSetInfo emoticonInfo, bool opened, bool isUsed)
	{
	}

	[Token(Token = "0x60076E3")]
	[Address(RVA = "0x1B15340", Offset = "0x1B15340", VA = "0x1B15340")]
	private bool BuildRemainTime(CSEmoticonSetInfo emoticonInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60076E4")]
	[Address(RVA = "0x1B1565C", Offset = "0x1B1565C", VA = "0x1B1565C")]
	private bool RefreshTime(CSEmoticonSetInfo emoticonInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60076E5")]
	[Address(RVA = "0x1B15404", Offset = "0x1B15404", VA = "0x1B15404")]
	private void BuildCondition(CSEmoticonSetInfo emoticonInfo, bool opened)
	{
	}

	[Token(Token = "0x60076E6")]
	[Address(RVA = "0x1B158D0", Offset = "0x1B158D0", VA = "0x1B158D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60076E7")]
	[Address(RVA = "0x1B1591C", Offset = "0x1B1591C", VA = "0x1B1591C")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x60076E8")]
	[Address(RVA = "0x1B159F4", Offset = "0x1B159F4", VA = "0x1B159F4")]
	public void OnClick_SelectEmoticon()
	{
	}

	[Token(Token = "0x60076E9")]
	[Address(RVA = "0x1B15CD8", Offset = "0x1B15CD8", VA = "0x1B15CD8")]
	public void OnClick_BuyEmoticon()
	{
	}

	[Token(Token = "0x60076EA")]
	[Address(RVA = "0x1B15A44", Offset = "0x1B15A44", VA = "0x1B15A44")]
	private void ReqUseEmoticon(int nSelectedEmoticonId)
	{
	}

	[Token(Token = "0x60076EB")]
	[Address(RVA = "0x1B15EEC", Offset = "0x1B15EEC", VA = "0x1B15EEC")]
	private void ReqBuyEmoticon(int nSelectedEmoticonId)
	{
	}

	[Token(Token = "0x60076EC")]
	[Address(RVA = "0x1B16138", Offset = "0x1B16138", VA = "0x1B16138")]
	private void _003COnClick_BuyEmoticon_003Em__4E8()
	{
	}
}
