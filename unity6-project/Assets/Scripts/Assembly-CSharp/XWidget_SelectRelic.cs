using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FE1")]
public class XWidget_SelectRelic : MonoBehaviour
{
	[Token(Token = "0x2000FE2")]
	private sealed class _003CRefreshTimeOnSec_003Ec__IteratorB1 : IDisposable
	{
		[Token(Token = "0x40054BF")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x40054C0")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40054C1")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_SelectRelic _003C_003Ef__this;

		[Token(Token = "0x17000EE3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007680")]
			[Address(RVA = "0x134845C", Offset = "0x134845C", VA = "0x134845C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000EE4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007681")]
			[Address(RVA = "0x1348464", Offset = "0x1348464", VA = "0x1348464", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600767F")]
		[Address(RVA = "0x1348254", Offset = "0x1348254", VA = "0x1348254")]
		public _003CRefreshTimeOnSec_003Ec__IteratorB1()
		{
		}

		[Token(Token = "0x6007680")]
		[Address(RVA = "0x134845C", Offset = "0x134845C", VA = "0x134845C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007681")]
		[Address(RVA = "0x1348464", Offset = "0x1348464", VA = "0x1348464", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007682")]
		[Address(RVA = "0x134846C", Offset = "0x134846C", VA = "0x134846C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007683")]
		[Address(RVA = "0x1348540", Offset = "0x1348540", VA = "0x1348540", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007684")]
		[Address(RVA = "0x134854C", Offset = "0x134854C", VA = "0x134854C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40054B0")]
	[FieldOffset(Offset = "0xC")]
	private bool m_isSelect;

	[Token(Token = "0x40054B1")]
	[FieldOffset(Offset = "0xD")]
	private bool m_isEnable;

	[Token(Token = "0x40054B2")]
	[FieldOffset(Offset = "0xE")]
	private bool m_isLock;

	[Token(Token = "0x40054B3")]
	[FieldOffset(Offset = "0x10")]
	public XUISound sound;

	[Token(Token = "0x40054B4")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprSkillIcon;

	[Token(Token = "0x40054B5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject goLock;

	[Token(Token = "0x40054B6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goHighlight;

	[Token(Token = "0x40054B7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goCheckMark;

	[Token(Token = "0x40054B8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goDisable;

	[Token(Token = "0x40054B9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goBG;

	[Token(Token = "0x40054BA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goDailyRelicBG;

	[Token(Token = "0x40054BB")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblRemainTime;

	[Token(Token = "0x40054BC")]
	[FieldOffset(Offset = "0x34")]
	private Action<int> m_onClick;

	[Token(Token = "0x40054BD")]
	[FieldOffset(Offset = "0x38")]
	private int m_relicID;

	[Token(Token = "0x40054BE")]
	[FieldOffset(Offset = "0x3C")]
	private int m_relicIndex;

	[Token(Token = "0x600766E")]
	[Address(RVA = "0x13473E4", Offset = "0x13473E4", VA = "0x13473E4")]
	public XWidget_SelectRelic()
	{
	}

	[Token(Token = "0x600766F")]
	[Address(RVA = "0x13473F4", Offset = "0x13473F4", VA = "0x13473F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007670")]
	[Address(RVA = "0x13475B0", Offset = "0x13475B0", VA = "0x13475B0")]
	public void Build(int index, int selectRelicIndex, int relicID, Action<int> onClick)
	{
	}

	[Token(Token = "0x6007671")]
	[Address(RVA = "0x13478BC", Offset = "0x13478BC", VA = "0x13478BC")]
	private void BuildSkillInfo(int relicID)
	{
	}

	[Token(Token = "0x6007672")]
	[Address(RVA = "0x13477C0", Offset = "0x13477C0", VA = "0x13477C0")]
	private void BuildLock(int relicID)
	{
	}

	[Token(Token = "0x6007673")]
	[Address(RVA = "0x1347E28", Offset = "0x1347E28", VA = "0x1347E28")]
	public void RefreshSelectRelic(int selectRelicID)
	{
	}

	[Token(Token = "0x6007674")]
	[Address(RVA = "0x1347B70", Offset = "0x1347B70", VA = "0x1347B70")]
	public void RefreshSelectRelicIndex(int selectRelicIndex)
	{
	}

	[Token(Token = "0x6007675")]
	[Address(RVA = "0x1347C78", Offset = "0x1347C78", VA = "0x1347C78")]
	private int GetOpenRelicLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6007676")]
	[Address(RVA = "0x1347B14", Offset = "0x1347B14", VA = "0x1347B14")]
	private void SetNullRelic()
	{
	}

	[Token(Token = "0x6007677")]
	[Address(RVA = "0x1347F98", Offset = "0x1347F98", VA = "0x1347F98")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6007678")]
	[Address(RVA = "0x1347E50", Offset = "0x1347E50", VA = "0x1347E50")]
	public void ShowCheckMark(bool isShow)
	{
	}

	[Token(Token = "0x6007679")]
	[Address(RVA = "0x1347B98", Offset = "0x1347B98", VA = "0x1347B98")]
	public void ShowDisable(bool isShow)
	{
	}

	[Token(Token = "0x600767A")]
	[Address(RVA = "0x134805C", Offset = "0x134805C", VA = "0x134805C")]
	private void SetSound(bool isChecked, bool isEnable)
	{
	}

	[Token(Token = "0x600767B")]
	[Address(RVA = "0x1348140", Offset = "0x1348140", VA = "0x1348140")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600767C")]
	[Address(RVA = "0x1348148", Offset = "0x1348148", VA = "0x1348148")]
	public void CalculateRelicRemainTime()
	{
	}

	[Token(Token = "0x600767D")]
	[Address(RVA = "0x13481B0", Offset = "0x13481B0", VA = "0x13481B0")]
	[DebuggerHidden]
	private IEnumerator RefreshTimeOnSec()
	{
		return null;
	}

	[Token(Token = "0x600767E")]
	[Address(RVA = "0x134825C", Offset = "0x134825C", VA = "0x134825C")]
	private void RefreshDailyBoxResetTime()
	{
	}
}
