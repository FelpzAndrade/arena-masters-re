using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000DA8")]
public class LobbyNotificationLogic
{
	[Token(Token = "0x2000DA9")]
	private sealed class _003CShowAttendancePopup_003Ec__AnonStorey1B1
	{
		[Token(Token = "0x40046D4")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSContent> rewards;

		[Token(Token = "0x40046D5")]
		[FieldOffset(Offset = "0xC")]
		internal int day;

		[Token(Token = "0x40046D6")]
		[FieldOffset(Offset = "0x10")]
		internal LobbyNotificationLogic _003C_003Ef__this;

		[Token(Token = "0x600646D")]
		[Address(RVA = "0x1353FA8", Offset = "0x1353FA8", VA = "0x1353FA8")]
		public _003CShowAttendancePopup_003Ec__AnonStorey1B1()
		{
		}

		[Token(Token = "0x600646E")]
		[Address(RVA = "0x1354658", Offset = "0x1354658", VA = "0x1354658")]
		internal IUIBackbutton _003C_003Em__324()
		{
			return null;
		}
	}

	[Token(Token = "0x40046D1")]
	[FieldOffset(Offset = "0x8")]
	private Queue<Func<IUIBackbutton>> m_showUIQueue;

	[Token(Token = "0x40046D2")]
	[FieldOffset(Offset = "0xC")]
	private IUIBackbutton curShowUI;

	[Token(Token = "0x40046D3")]
	[FieldOffset(Offset = "0x10")]
	private bool popupState;

	[Token(Token = "0x17000D4A")]
	public bool NotiReady
	{
		[Token(Token = "0x600645F")]
		[Address(RVA = "0x1352EBC", Offset = "0x1352EBC", VA = "0x1352EBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600645E")]
	[Address(RVA = "0x1352E10", Offset = "0x1352E10", VA = "0x1352E10")]
	public LobbyNotificationLogic()
	{
	}

	[Token(Token = "0x6006460")]
	[Address(RVA = "0x1352F70", Offset = "0x1352F70", VA = "0x1352F70")]
	public void LobbyNotiAllEnqueue(bool bShow)
	{
	}

	[Token(Token = "0x6006461")]
	[Address(RVA = "0x1353CD0", Offset = "0x1353CD0", VA = "0x1353CD0")]
	public void ShowNext()
	{
	}

	[Token(Token = "0x6006462")]
	[Address(RVA = "0x1353E60", Offset = "0x1353E60", VA = "0x1353E60")]
	public void EnqueueAction(Func<IUIBackbutton> ui)
	{
	}

	[Token(Token = "0x6006463")]
	[Address(RVA = "0x1353F08", Offset = "0x1353F08", VA = "0x1353F08")]
	public void Clear()
	{
	}

	[Token(Token = "0x6006464")]
	[Address(RVA = "0x1352FAC", Offset = "0x1352FAC", VA = "0x1352FAC")]
	private void ShowGameEvalPopup()
	{
	}

	[Token(Token = "0x6006465")]
	[Address(RVA = "0x1353198", Offset = "0x1353198", VA = "0x1353198")]
	private void ShowEventAttendancePopup()
	{
	}

	[Token(Token = "0x6006466")]
	[Address(RVA = "0x1353448", Offset = "0x1353448", VA = "0x1353448")]
	private void ShowAttendancePopup()
	{
	}

	[Token(Token = "0x6006467")]
	[Address(RVA = "0x1353868", Offset = "0x1353868", VA = "0x1353868")]
	private void ShowAcheiveNotice()
	{
	}

	[Token(Token = "0x6006468")]
	[Address(RVA = "0x1353ACC", Offset = "0x1353ACC", VA = "0x1353ACC")]
	private void StorageCheck()
	{
	}

	[Token(Token = "0x6006469")]
	[Address(RVA = "0x1353FB0", Offset = "0x1353FB0", VA = "0x1353FB0")]
	private IUIBackbutton _003CShowGameEvalPopup_003Em__322()
	{
		return null;
	}

	[Token(Token = "0x600646A")]
	[Address(RVA = "0x1354130", Offset = "0x1354130", VA = "0x1354130")]
	private IUIBackbutton _003CShowEventAttendancePopup_003Em__323()
	{
		return null;
	}

	[Token(Token = "0x600646B")]
	[Address(RVA = "0x13542D4", Offset = "0x13542D4", VA = "0x13542D4")]
	private IUIBackbutton _003CShowAcheiveNotice_003Em__325()
	{
		return null;
	}

	[Token(Token = "0x600646C")]
	[Address(RVA = "0x1354444", Offset = "0x1354444", VA = "0x1354444")]
	private IUIBackbutton _003CStorageCheck_003Em__326()
	{
		return null;
	}
}
