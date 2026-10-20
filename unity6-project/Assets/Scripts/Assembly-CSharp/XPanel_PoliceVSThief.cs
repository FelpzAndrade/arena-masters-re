using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XCasualModeLogic.PoliceVsThief;

[Token(Token = "0x2000D16")]
public class XPanel_PoliceVSThief : MonoBehaviour
{
	[Token(Token = "0x2000D17")]
	private sealed class _003CShowAlarm_003Ec__Iterator9B : IDisposable
	{
		[Token(Token = "0x40042EC")]
		[FieldOffset(Offset = "0x8")]
		internal XTeamEnum team;

		[Token(Token = "0x40042ED")]
		[FieldOffset(Offset = "0xC")]
		internal float duration;

		[Token(Token = "0x40042EE")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x40042EF")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x40042F0")]
		[FieldOffset(Offset = "0x18")]
		internal XTeamEnum _003C_0024_003Eteam;

		[Token(Token = "0x40042F1")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003Eduration;

		[Token(Token = "0x40042F2")]
		[FieldOffset(Offset = "0x20")]
		internal XPanel_PoliceVSThief _003C_003Ef__this;

		[Token(Token = "0x17000D0C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005FD7")]
			[Address(RVA = "0x101AF78", Offset = "0x101AF78", VA = "0x101AF78", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D0D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005FD8")]
			[Address(RVA = "0x101AF80", Offset = "0x101AF80", VA = "0x101AF80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x101ACA0", Offset = "0x101ACA0", VA = "0x101ACA0")]
		public _003CShowAlarm_003Ec__Iterator9B()
		{
		}

		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0x101AF78", Offset = "0x101AF78", VA = "0x101AF78", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x101AF80", Offset = "0x101AF80", VA = "0x101AF80", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0x101AF88", Offset = "0x101AF88", VA = "0x101AF88", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0x101B088", Offset = "0x101B088", VA = "0x101B088", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0x101B094", Offset = "0x101B094", VA = "0x101B094", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40042DB")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTime;

	[Token(Token = "0x40042DC")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblRound;

	[Token(Token = "0x40042DD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblAWinCount;

	[Token(Token = "0x40042DE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblBWinCount;

	[Token(Token = "0x40042DF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblASafeCount;

	[Token(Token = "0x40042E0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblBSafeCount;

	[Token(Token = "0x40042E1")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridAteam;

	[Token(Token = "0x40042E2")]
	[FieldOffset(Offset = "0x28")]
	public XWiget_GridBuilder gridBteam;

	[Token(Token = "0x40042E3")]
	[FieldOffset(Offset = "0x2C")]
	public XWiget_GridBuilder gridAteamKey;

	[Token(Token = "0x40042E4")]
	[FieldOffset(Offset = "0x30")]
	public XWiget_GridBuilder gridBteamKey;

	[Token(Token = "0x40042E5")]
	[FieldOffset(Offset = "0x34")]
	public GameObject sprScoreBoardLight_ATeam;

	[Token(Token = "0x40042E6")]
	[FieldOffset(Offset = "0x38")]
	public TweenAlpha sprScoreBoardLightTween_ATeam;

	[Token(Token = "0x40042E7")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject sprScoreBoardLight_BTeam;

	[Token(Token = "0x40042E8")]
	[FieldOffset(Offset = "0x40")]
	public TweenAlpha sprScoreBoardLightTweeb_BTeam;

	[Token(Token = "0x40042E9")]
	[FieldOffset(Offset = "0x44")]
	private Mode mode;

	[Token(Token = "0x40042EA")]
	[FieldOffset(Offset = "0x48")]
	private PeriodUpdater timeUpdater;

	[Token(Token = "0x40042EB")]
	[FieldOffset(Offset = "0x4C")]
	private bool reserveBuild;

	[Token(Token = "0x6005FC8")]
	[Address(RVA = "0x1019F8C", Offset = "0x1019F8C", VA = "0x1019F8C")]
	public XPanel_PoliceVSThief()
	{
	}

	[Token(Token = "0x6005FC9")]
	[Address(RVA = "0x1019F94", Offset = "0x1019F94", VA = "0x1019F94")]
	private void Start()
	{
	}

	[Token(Token = "0x6005FCA")]
	[Address(RVA = "0x101A088", Offset = "0x101A088", VA = "0x101A088")]
	public void Build()
	{
	}

	[Token(Token = "0x6005FCB")]
	[Address(RVA = "0x101A0A0", Offset = "0x101A0A0", VA = "0x101A0A0")]
	public void Build(Mode mode)
	{
	}

	[Token(Token = "0x6005FCC")]
	[Address(RVA = "0x101A270", Offset = "0x101A270", VA = "0x101A270")]
	private void _Build()
	{
	}

	[Token(Token = "0x6005FCD")]
	[Address(RVA = "0x101A0DC", Offset = "0x101A0DC", VA = "0x101A0DC")]
	public void RefreshSafeScore()
	{
	}

	[Token(Token = "0x6005FCE")]
	[Address(RVA = "0x101A858", Offset = "0x101A858", VA = "0x101A858")]
	private void BuildKey(XWiget_GridBuilder grid, XTeamEnum team, List<IPlayer> players)
	{
	}

	[Token(Token = "0x6005FCF")]
	[Address(RVA = "0x101A540", Offset = "0x101A540", VA = "0x101A540")]
	private void BuildTeam(XWiget_GridBuilder grid, List<IPlayer> team)
	{
	}

	[Token(Token = "0x6005FD0")]
	[Address(RVA = "0x101ABBC", Offset = "0x101ABBC", VA = "0x101ABBC")]
	public void ShowTeamAlarm(XTeamEnum team, float duration)
	{
	}

	[Token(Token = "0x6005FD1")]
	[Address(RVA = "0x101ABE0", Offset = "0x101ABE0", VA = "0x101ABE0")]
	[DebuggerHidden]
	private IEnumerator ShowAlarm(XTeamEnum team, float duration)
	{
		return null;
	}

	[Token(Token = "0x6005FD2")]
	[Address(RVA = "0x101ACA8", Offset = "0x101ACA8", VA = "0x101ACA8")]
	private void StartSelectedMyTeamAlarm(XTeamEnum team)
	{
	}

	[Token(Token = "0x6005FD3")]
	[Address(RVA = "0x101AD30", Offset = "0x101AD30", VA = "0x101AD30")]
	private void StopSelectedMyTeamAlarmTween()
	{
	}

	[Token(Token = "0x6005FD4")]
	[Address(RVA = "0x101ADC4", Offset = "0x101ADC4", VA = "0x101ADC4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6005FD5")]
	[Address(RVA = "0x101AE44", Offset = "0x101AE44", VA = "0x101AE44")]
	private void RefreshTime(float dt)
	{
	}
}
