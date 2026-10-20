using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DD4")]
public class XPanel_CombatMissionReward : MonoBehaviour
{
	[Token(Token = "0x2000DD5")]
	public enum RewardState
	{
		[Token(Token = "0x4004811")]
		None = 0,
		[Token(Token = "0x4004812")]
		Point = 1,
		[Token(Token = "0x4004813")]
		Active = 2,
		[Token(Token = "0x4004814")]
		Cool = 3
	}

	[Token(Token = "0x2000DD6")]
	private sealed class _003CRefreshResetTimeOnMin_003Ec__IteratorA3 : IDisposable
	{
		[Token(Token = "0x4004815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4004816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4004817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_CombatMissionReward _003C_003Ef__this;

		[Token(Token = "0x17000D60")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006617")]
			[Address(RVA = "0x16B4B50", Offset = "0x16B4B50", VA = "0x16B4B50", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D61")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006618")]
			[Address(RVA = "0x16B4B58", Offset = "0x16B4B58", VA = "0x16B4B58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006616")]
		[Address(RVA = "0x16B4468", Offset = "0x16B4468", VA = "0x16B4468")]
		public _003CRefreshResetTimeOnMin_003Ec__IteratorA3()
		{
		}

		[Token(Token = "0x6006617")]
		[Address(RVA = "0x16B4B50", Offset = "0x16B4B50", VA = "0x16B4B50", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006618")]
		[Address(RVA = "0x16B4B58", Offset = "0x16B4B58", VA = "0x16B4B58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006619")]
		[Address(RVA = "0x16B4B60", Offset = "0x16B4B60", VA = "0x16B4B60", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600661A")]
		[Address(RVA = "0x16B4C30", Offset = "0x16B4C30", VA = "0x16B4C30", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600661B")]
		[Address(RVA = "0x16B4C3C", Offset = "0x16B4C3C", VA = "0x16B4C3C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40047FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XUIAcquisitionDirection acqusitionDirection;

	[Token(Token = "0x40047FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject BackgroundCollider;

	[Token(Token = "0x4004800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private RewardState m_rewardState;

	[Token(Token = "0x4004801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject PointState;

	[Token(Token = "0x4004802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject ActiveState;

	[Token(Token = "0x4004803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblReceiveReward;

	[Token(Token = "0x4004804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject CoolTimeState;

	[Token(Token = "0x4004805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UIProgressBar progressBar;

	[Token(Token = "0x4004806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblProgress;

	[Token(Token = "0x4004807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XWidget_RewardItem rewardItem;

	[Token(Token = "0x4004808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Action m_viewAction;

	[Token(Token = "0x4004809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action m_ProcessingStartGame;

	[Token(Token = "0x400480A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private readonly string Path_CombatMissionHelp;

	[Token(Token = "0x400480B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject _pnlHelp;

	[Token(Token = "0x400480C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UILabel lblCombatMissionPoint;

	[Token(Token = "0x400480D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblCombatMissionRewardResetTime;

	[Token(Token = "0x400480E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private CSPvpRewardInfo m_missionRewardInfo;

	[Token(Token = "0x400480F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isClick;

	[Token(Token = "0x17000D5E")]
	public GameObject pnlHelp
	{
		[Token(Token = "0x6006604")]
		[Address(RVA = "0x16B3644", Offset = "0x16B3644", VA = "0x16B3644")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D5F")]
	private bool AllRewardDone
	{
		[Token(Token = "0x6006605")]
		[Address(RVA = "0x16B37E0", Offset = "0x16B37E0", VA = "0x16B37E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006603")]
	[Address(RVA = "0x16B35B8", Offset = "0x16B35B8", VA = "0x16B35B8")]
	public XPanel_CombatMissionReward()
	{
	}

	[Token(Token = "0x6006606")]
	[Address(RVA = "0x16B37F4", Offset = "0x16B37F4", VA = "0x16B37F4")]
	private void ChangeState(RewardState rewardState)
	{
	}

	[Token(Token = "0x6006607")]
	[Address(RVA = "0x16B37FC", Offset = "0x16B37FC", VA = "0x16B37FC")]
	private void State()
	{
	}

	[Token(Token = "0x6006608")]
	[Address(RVA = "0x16B3948", Offset = "0x16B3948", VA = "0x16B3948")]
	public void Build(CSPvpRewardInfo info, XWidget_ItemDetailToolTip toolTip, int combatPoint, bool enable, Action viewAction)
	{
	}

	[Token(Token = "0x6006609")]
	[Address(RVA = "0x16B3C7C", Offset = "0x16B3C7C", VA = "0x16B3C7C")]
	private void ShowCombatMissionRewardCompleteDone(bool bShow)
	{
	}

	[Token(Token = "0x600660A")]
	[Address(RVA = "0x16B3CE0", Offset = "0x16B3CE0", VA = "0x16B3CE0")]
	private void BuildReward(int cur, int total, bool enable)
	{
	}

	[Token(Token = "0x600660B")]
	[Address(RVA = "0x16B3CBC", Offset = "0x16B3CBC", VA = "0x16B3CBC")]
	private void BuildRewardDone()
	{
	}

	[Token(Token = "0x600660C")]
	[Address(RVA = "0x16B3DE0", Offset = "0x16B3DE0", VA = "0x16B3DE0")]
	private void BuildCurrentCombatMissionPoint(int nCurrent, int nTotal)
	{
	}

	[Token(Token = "0x600660D")]
	[Address(RVA = "0x16B4018", Offset = "0x16B4018", VA = "0x16B4018")]
	private void BuildProgressBar(int cur, int total)
	{
	}

	[Token(Token = "0x600660E")]
	[Address(RVA = "0x16B426C", Offset = "0x16B426C", VA = "0x16B426C")]
	private void RefreshResetTimeLabel()
	{
	}

	[Token(Token = "0x600660F")]
	[Address(RVA = "0x16B3F74", Offset = "0x16B3F74", VA = "0x16B3F74")]
	[DebuggerHidden]
	private IEnumerator RefreshResetTimeOnMin()
	{
		return null;
	}

	[Token(Token = "0x6006610")]
	[Address(RVA = "0x16B4470", Offset = "0x16B4470", VA = "0x16B4470")]
	public void OnClick_GetRewarButton([Optional] Action ProcessingStartGame)
	{
	}

	[Token(Token = "0x6006611")]
	[Address(RVA = "0x16B44C4", Offset = "0x16B44C4", VA = "0x16B44C4")]
	private void SendNetProcess()
	{
	}

	[Token(Token = "0x6006612")]
	[Address(RVA = "0x16B4714", Offset = "0x16B4714", VA = "0x16B4714")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x6006613")]
	[Address(RVA = "0x16B47EC", Offset = "0x16B47EC", VA = "0x16B47EC")]
	private void ResetDirection()
	{
	}

	[Token(Token = "0x6006614")]
	[Address(RVA = "0x16B481C", Offset = "0x16B481C", VA = "0x16B481C")]
	private void EndDirection()
	{
	}

	[Token(Token = "0x6006615")]
	[Address(RVA = "0x16B4910", Offset = "0x16B4910", VA = "0x16B4910")]
	private void _003CSendNetProcess_003Em__35A(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
