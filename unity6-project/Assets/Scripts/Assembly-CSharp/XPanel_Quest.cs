using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000E11")]
public class XPanel_Quest : MonoBehaviour
{
	[Token(Token = "0x2000E12")]
	private sealed class _003CRefreshTimeOnSec_003Ec__IteratorA7 : IDisposable
	{
		[Token(Token = "0x40049C7")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x40049C8")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40049C9")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Quest _003C_003Ef__this;

		[Token(Token = "0x17000D83")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600687C")]
			[Address(RVA = "0x101C200", Offset = "0x101C200", VA = "0x101C200", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D84")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600687D")]
			[Address(RVA = "0x101C208", Offset = "0x101C208", VA = "0x101C208", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600687B")]
		[Address(RVA = "0x101B5DC", Offset = "0x101B5DC", VA = "0x101B5DC")]
		public _003CRefreshTimeOnSec_003Ec__IteratorA7()
		{
		}

		[Token(Token = "0x600687C")]
		[Address(RVA = "0x101C200", Offset = "0x101C200", VA = "0x101C200", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600687D")]
		[Address(RVA = "0x101C208", Offset = "0x101C208", VA = "0x101C208", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600687E")]
		[Address(RVA = "0x101C210", Offset = "0x101C210", VA = "0x101C210", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600687F")]
		[Address(RVA = "0x101C2E0", Offset = "0x101C2E0", VA = "0x101C2E0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006880")]
		[Address(RVA = "0x101C2EC", Offset = "0x101C2EC", VA = "0x101C2EC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000E13")]
	private sealed class _003CRequestComplete_003Ec__AnonStorey1E1
	{
		[Token(Token = "0x40049CA")]
		[FieldOffset(Offset = "0x8")]
		internal QuestInfo questInfo;

		[Token(Token = "0x40049CB")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Quest _003C_003Ef__this;

		[Token(Token = "0x40049CC")]
		[FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache2;

		[Token(Token = "0x6006881")]
		[Address(RVA = "0x101C120", Offset = "0x101C120", VA = "0x101C120")]
		public _003CRequestComplete_003Ec__AnonStorey1E1()
		{
		}

		[Token(Token = "0x6006882")]
		[Address(RVA = "0x101C380", Offset = "0x101C380", VA = "0x101C380")]
		internal void _003C_003Em__3B0(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}

		[Token(Token = "0x6006883")]
		[Address(RVA = "0x101C9EC", Offset = "0x101C9EC", VA = "0x101C9EC")]
		private static void _003C_003Em__3B1()
		{
		}
	}

	[Token(Token = "0x40049BD")]
	[FieldOffset(Offset = "0xC")]
	public XUIQuestList m_daiyQuestList;

	[Token(Token = "0x40049BE")]
	[FieldOffset(Offset = "0x10")]
	public GameObject allClearItem;

	[Token(Token = "0x40049BF")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView m_itemScrollView;

	[Token(Token = "0x40049C0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goRemainTime;

	[Token(Token = "0x40049C1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblRemainTime;

	[Token(Token = "0x40049C2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblNoQuest;

	[Token(Token = "0x40049C3")]
	[FieldOffset(Offset = "0x24")]
	private QuestGroup m_group;

	[Token(Token = "0x40049C4")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_ToggleTab[] m_Tabs;

	[Token(Token = "0x40049C5")]
	[FieldOffset(Offset = "0x2C")]
	public XUIQuestList m_questUIList;

	[Token(Token = "0x40049C6")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isRequesting;

	[Token(Token = "0x6006869")]
	[Address(RVA = "0x101B228", Offset = "0x101B228", VA = "0x101B228")]
	public XPanel_Quest()
	{
	}

	[Token(Token = "0x600686A")]
	[Address(RVA = "0x101B238", Offset = "0x101B238", VA = "0x101B238")]
	private void RefreshTimeLabel()
	{
	}

	[Token(Token = "0x600686B")]
	[Address(RVA = "0x101B538", Offset = "0x101B538", VA = "0x101B538")]
	[DebuggerHidden]
	private IEnumerator RefreshTimeOnSec()
	{
		return null;
	}

	[Token(Token = "0x600686C")]
	[Address(RVA = "0x101B5E4", Offset = "0x101B5E4", VA = "0x101B5E4")]
	public void Show(bool bShow)
	{
	}

	[Token(Token = "0x600686D")]
	[Address(RVA = "0x101B680", Offset = "0x101B680", VA = "0x101B680")]
	public void BuildDailyQuests()
	{
	}

	[Token(Token = "0x600686E")]
	[Address(RVA = "0x101B854", Offset = "0x101B854", VA = "0x101B854")]
	public void BuildList()
	{
	}

	[Token(Token = "0x600686F")]
	[Address(RVA = "0x101B99C", Offset = "0x101B99C", VA = "0x101B99C")]
	public void ShowDayGroupList()
	{
	}

	[Token(Token = "0x6006870")]
	[Address(RVA = "0x101B9A4", Offset = "0x101B9A4", VA = "0x101B9A4")]
	public void ShowWeekGroupList()
	{
	}

	[Token(Token = "0x6006871")]
	[Address(RVA = "0x101B9AC", Offset = "0x101B9AC", VA = "0x101B9AC")]
	public void ShowEventGroupList()
	{
	}

	[Token(Token = "0x6006872")]
	[Address(RVA = "0x101B9B4", Offset = "0x101B9B4", VA = "0x101B9B4")]
	public void ShowCombatGroupList()
	{
	}

	[Token(Token = "0x6006873")]
	[Address(RVA = "0x101B9BC", Offset = "0x101B9BC", VA = "0x101B9BC")]
	public void ShowAllClearItem(bool bShow)
	{
	}

	[Token(Token = "0x6006874")]
	[Address(RVA = "0x101B85C", Offset = "0x101B85C", VA = "0x101B85C")]
	private void BuildTabList(QuestGroup type)
	{
	}

	[Token(Token = "0x6006875")]
	[Address(RVA = "0x101BAC4", Offset = "0x101BAC4", VA = "0x101BAC4")]
	private void SetNoQuestLabel()
	{
	}

	[Token(Token = "0x6006876")]
	[Address(RVA = "0x101B700", Offset = "0x101B700", VA = "0x101B700")]
	public void InitTabsBadge()
	{
	}

	[Token(Token = "0x6006877")]
	[Address(RVA = "0x101BC24", Offset = "0x101BC24", VA = "0x101BC24")]
	public void SetTabsBadge(int number)
	{
	}

	[Token(Token = "0x6006878")]
	[Address(RVA = "0x101BDA0", Offset = "0x101BDA0", VA = "0x101BDA0")]
	public void OnButtonClick_CloseWindow()
	{
	}

	[Token(Token = "0x6006879")]
	[Address(RVA = "0x101BE74", Offset = "0x101BE74", VA = "0x101BE74")]
	public void RequestComplete(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x600687A")]
	[Address(RVA = "0x101C128", Offset = "0x101C128", VA = "0x101C128")]
	public void OnClick_Help()
	{
	}
}
