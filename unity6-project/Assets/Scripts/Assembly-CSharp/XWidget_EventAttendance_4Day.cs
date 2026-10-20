using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000F82")]
public class XWidget_EventAttendance_4Day : MonoBehaviour, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x40051D8")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x40051D9")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x40051DA")]
	[FieldOffset(Offset = "0x14")]
	public XUIEventAttendanceItem[] m_attenanceItems;

	[Token(Token = "0x40051DB")]
	[FieldOffset(Offset = "0x18")]
	private EventAttendanceGroup m_groupAttendItem;

	[Token(Token = "0x40051DC")]
	[FieldOffset(Offset = "0x1C")]
	private List<CSEventAttendanceBookItem> m_itemlist;

	[Token(Token = "0x40051DD")]
	[FieldOffset(Offset = "0x0")]
	private static Func<CSEventAttendanceBookItem, int> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x6007369")]
	[Address(RVA = "0x15F9774", Offset = "0x15F9774", VA = "0x15F9774")]
	public XWidget_EventAttendance_4Day()
	{
	}

	[Token(Token = "0x600736A")]
	[Address(RVA = "0x15F9820", Offset = "0x15F9820", VA = "0x15F9820")]
	public void Build()
	{
	}

	[Token(Token = "0x600736B")]
	[Address(RVA = "0x15F9860", Offset = "0x15F9860", VA = "0x15F9860")]
	private void UIBuild()
	{
	}

	[Token(Token = "0x600736C")]
	[Address(RVA = "0x15F9D7C", Offset = "0x15F9D7C", VA = "0x15F9D7C")]
	private void CurrentRewardRecievableDay(int groupId, int groupListCount, out int day, out bool isAttendTime)
	{
		day = default;
		isAttendTime = default;
	}

	[Token(Token = "0x600736D")]
	[Address(RVA = "0x15F98B4", Offset = "0x15F98B4", VA = "0x15F98B4")]
	private void SetGroupInfo()
	{
	}

	[Token(Token = "0x600736E")]
	[Address(RVA = "0x15F9A1C", Offset = "0x15F9A1C", VA = "0x15F9A1C")]
	private void BuildList()
	{
	}

	[Token(Token = "0x600736F")]
	[Address(RVA = "0x15F9FB8", Offset = "0x15F9FB8", VA = "0x15F9FB8")]
	private List<CSEventAttendanceBookItem> GetEventAttendanceList()
	{
		return null;
	}

	[Token(Token = "0x6007370")]
	[Address(RVA = "0x15FA388", Offset = "0x15FA388", VA = "0x15FA388")]
	private void SendRewardEventAttendance()
	{
	}

	[Token(Token = "0x6007371")]
	[Address(RVA = "0x15FA560", Offset = "0x15FA560", VA = "0x15FA560")]
	public void CallBack_RecivePacket(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6007372")]
	[Address(RVA = "0x15FA8D8", Offset = "0x15FA8D8", VA = "0x15FA8D8")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x6007373")]
	[Address(RVA = "0x15FA918", Offset = "0x15FA918", VA = "0x15FA918")]
	private void SaveCloseTime()
	{
	}

	[Token(Token = "0x6007374")]
	[Address(RVA = "0x15FAA34", Offset = "0x15FAA34", VA = "0x15FAA34")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007375")]
	[Address(RVA = "0x15FAA68", Offset = "0x15FAA68", VA = "0x15FAA68", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6007376")]
	[Address(RVA = "0x15FAA98", Offset = "0x15FAA98", VA = "0x15FAA98", Slot = "5")]
	public void OnHide()
	{
	}

	[Token(Token = "0x6007377")]
	[Address(RVA = "0x15FAA9C", Offset = "0x15FAA9C", VA = "0x15FAA9C")]
	private static int _003CGetEventAttendanceList_003Em__4A4(CSEventAttendanceBookItem o)
	{
		return default(int);
	}

	[Token(Token = "0x6007378")]
	[Address(RVA = "0x15FAABC", Offset = "0x15FAABC", VA = "0x15FAABC")]
	private void _003CSendRewardEventAttendance_003Em__4A5(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
