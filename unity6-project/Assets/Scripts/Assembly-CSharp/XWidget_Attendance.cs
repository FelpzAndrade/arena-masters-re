using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAB")]
public class XWidget_Attendance : MonoBehaviour, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x2000DAC")]
	private sealed class _003CBuild_003Ec__AnonStorey1B2
	{
		[Token(Token = "0x40046ED")]
		[FieldOffset(Offset = "0x8")]
		internal CSContent reward;

		[Token(Token = "0x40046EE")]
		[FieldOffset(Offset = "0xC")]
		internal CSContent actualReward;

		[Token(Token = "0x40046EF")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_Attendance _003C_003Ef__this;

		[Token(Token = "0x6006483")]
		[Address(RVA = "0x193E070", Offset = "0x193E070", VA = "0x193E070")]
		public _003CBuild_003Ec__AnonStorey1B2()
		{
		}

		[Token(Token = "0x6006484")]
		[Address(RVA = "0x193F1B0", Offset = "0x193F1B0", VA = "0x193F1B0")]
		internal void _003C_003Em__327()
		{
		}

		[Token(Token = "0x6006485")]
		[Address(RVA = "0x193F234", Offset = "0x193F234", VA = "0x193F234")]
		internal void _003C_003Em__328()
		{
		}
	}

	[Token(Token = "0x2000DAD")]
	private sealed class _003CSetTutorialObject_003Ec__AnonStorey1B3
	{
		[Token(Token = "0x40046F0")]
		[FieldOffset(Offset = "0x8")]
		internal XTutorialObjContainer tutoContainer;

		[Token(Token = "0x40046F1")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_Attendance _003C_003Ef__this;

		[Token(Token = "0x6006486")]
		[Address(RVA = "0x193EBB0", Offset = "0x193EBB0", VA = "0x193EBB0")]
		public _003CSetTutorialObject_003Ec__AnonStorey1B3()
		{
		}

		[Token(Token = "0x6006487")]
		[Address(RVA = "0x193F270", Offset = "0x193F270", VA = "0x193F270")]
		internal void _003C_003Em__329()
		{
		}
	}

	[Token(Token = "0x40046E3")]
	[FieldOffset(Offset = "0xC")]
	public XTutorialObjContainer tutoContainer;

	[Token(Token = "0x40046E4")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder rewardsGrid;

	[Token(Token = "0x40046E5")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale tweenScale;

	[Token(Token = "0x40046E6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject gachaConfirm;

	[Token(Token = "0x40046E7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject btnClose;

	[Token(Token = "0x40046E8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblTitle;

	[Token(Token = "0x40046E9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblComment;

	[Token(Token = "0x40046EA")]
	[FieldOffset(Offset = "0x28")]
	private UIDirector m_direction;

	[Token(Token = "0x40046EB")]
	[FieldOffset(Offset = "0x2C")]
	private XWidget_AttendanceReward[] rewardGos;

	[Token(Token = "0x40046EC")]
	[FieldOffset(Offset = "0x30")]
	private Action m_queue;

	[Token(Token = "0x6006478")]
	[Address(RVA = "0x193DA20", Offset = "0x193DA20", VA = "0x193DA20")]
	public XWidget_Attendance()
	{
	}

	[Token(Token = "0x6006479")]
	[Address(RVA = "0x193DAC0", Offset = "0x193DAC0", VA = "0x193DAC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600647A")]
	[Address(RVA = "0x193DBBC", Offset = "0x193DBBC", VA = "0x193DBBC")]
	public void Build(List<CSContent> rewards, int today, CSContent actualReward, Action queue)
	{
	}

	[Token(Token = "0x600647B")]
	[Address(RVA = "0x193E8E0", Offset = "0x193E8E0", VA = "0x193E8E0")]
	private void ShowGachaConfirm(bool bShow, CSContent box, CSContent reward)
	{
	}

	[Token(Token = "0x600647C")]
	[Address(RVA = "0x193EA00", Offset = "0x193EA00", VA = "0x193EA00")]
	public void HideConfirm()
	{
	}

	[Token(Token = "0x600647D")]
	[Address(RVA = "0x193EA2C", Offset = "0x193EA2C", VA = "0x193EA2C")]
	public void SetTutorialObject(XTutorialObjContainer tutoContainer)
	{
	}

	[Token(Token = "0x600647E")]
	[Address(RVA = "0x193EBB8", Offset = "0x193EBB8", VA = "0x193EBB8", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600647F")]
	[Address(RVA = "0x193EBE8", Offset = "0x193EBE8", VA = "0x193EBE8")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x6006480")]
	[Address(RVA = "0x193ED18", Offset = "0x193ED18", VA = "0x193ED18", Slot = "5")]
	public void OnHide()
	{
	}

	[Token(Token = "0x6006481")]
	[Address(RVA = "0x193EE2C", Offset = "0x193EE2C", VA = "0x193EE2C")]
	public void ShowAttendanceRewards()
	{
	}

	[Token(Token = "0x6006482")]
	[Address(RVA = "0x193E078", Offset = "0x193E078", VA = "0x193E078")]
	private void SetLabel()
	{
	}
}
