using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DAF")]
public class XWidget_EventAttendance : MonoBehaviour, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x2000DB0")]
	public static class UILogic
	{
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0x15F94B8", Offset = "0x15F94B8", VA = "0x15F94B8")]
		public static bool AttendanceDisable(DateTime nowTime, DateTime lastTime, int GroupId, List<ExpireNode> _list)
		{
			return default(bool);
		}

		[Token(Token = "0x60064A6")]
		[Address(RVA = "0x15F9518", Offset = "0x15F9518", VA = "0x15F9518")]
		public static bool CheckEventAttendanceTime(DateTime nowTime, DateTime lastTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60064A7")]
		[Address(RVA = "0x15F9634", Offset = "0x15F9634", VA = "0x15F9634")]
		public static int GetGroupDay(int GroupId, List<ExpireNode> _list)
		{
			return default(int);
		}

		[Token(Token = "0x60064A8")]
		[Address(RVA = "0x15F89D4", Offset = "0x15F89D4", VA = "0x15F89D4")]
		public static void GetCurrentRewardRecievableDay(int GroupId, int groupCount, List<ExpireNode> _list, DateTime nowTime, DateTime lastTime, out int attendDay, out bool isAttendTime)
		{
			attendDay = default;
			isAttendTime = default;
		}
	}

	[Token(Token = "0x4004704")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4004705")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_Builder gridBuilder;

	[Token(Token = "0x4004706")]
	[FieldOffset(Offset = "0x14")]
	public Transform[] m_dayRoot;

	[Token(Token = "0x4004707")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Button btnReward;

	[Token(Token = "0x4004708")]
	[FieldOffset(Offset = "0x1C")]
	public TweenScale tweenScale;

	[Token(Token = "0x4004709")]
	[FieldOffset(Offset = "0x20")]
	private XUIEventAttendanceItem[] m_dayItem;

	[Token(Token = "0x400470A")]
	[FieldOffset(Offset = "0x24")]
	private Action m_closeAction;

	[Token(Token = "0x400470B")]
	[FieldOffset(Offset = "0x28")]
	private EventAttendanceGroup m_groupAttendItem;

	[Token(Token = "0x400470C")]
	[FieldOffset(Offset = "0x2C")]
	private List<CSEventAttendanceBookItem> m_itemlist;

	[Token(Token = "0x400470D")]
	[FieldOffset(Offset = "0x30")]
	private bool rewardClicked;

	[Token(Token = "0x400470E")]
	[FieldOffset(Offset = "0x0")]
	private static Func<CSEventAttendanceBookItem, int> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x6006491")]
	[Address(RVA = "0x15F7BB8", Offset = "0x15F7BB8", VA = "0x15F7BB8")]
	public XWidget_EventAttendance()
	{
	}

	[Token(Token = "0x6006492")]
	[Address(RVA = "0x15F7C64", Offset = "0x15F7C64", VA = "0x15F7C64")]
	public void Build(Action closeAction, bool btnActive)
	{
	}

	[Token(Token = "0x6006493")]
	[Address(RVA = "0x15F7D88", Offset = "0x15F7D88", VA = "0x15F7D88")]
	private void UIBuild()
	{
	}

	[Token(Token = "0x6006494")]
	[Address(RVA = "0x15F8798", Offset = "0x15F8798", VA = "0x15F8798")]
	private void CurrentRewardRecievableDay(int groupId, int groupListCount, out int day, out bool isAttendTime)
	{
		day = default;
		isAttendTime = default;
	}

	[Token(Token = "0x6006495")]
	[Address(RVA = "0x15F7FA4", Offset = "0x15F7FA4", VA = "0x15F7FA4")]
	private int GetGroupValue(int GroupId)
	{
		return default(int);
	}

	[Token(Token = "0x6006496")]
	[Address(RVA = "0x15F8178", Offset = "0x15F8178", VA = "0x15F8178")]
	private void SetGroupInfo()
	{
	}

	[Token(Token = "0x6006497")]
	[Address(RVA = "0x15F82E0", Offset = "0x15F82E0", VA = "0x15F82E0")]
	private void BuildList()
	{
	}

	[Token(Token = "0x6006498")]
	[Address(RVA = "0x15F8A7C", Offset = "0x15F8A7C", VA = "0x15F8A7C")]
	private List<CSEventAttendanceBookItem> GetEventAttendanceList()
	{
		return null;
	}

	[Token(Token = "0x6006499")]
	[Address(RVA = "0x15F8D2C", Offset = "0x15F8D2C", VA = "0x15F8D2C")]
	public void OnClick_Reward()
	{
	}

	[Token(Token = "0x600649A")]
	[Address(RVA = "0x15F8D3C", Offset = "0x15F8D3C", VA = "0x15F8D3C")]
	private void RewardEventAttendance()
	{
	}

	[Token(Token = "0x600649B")]
	[Address(RVA = "0x15F8F1C", Offset = "0x15F8F1C", VA = "0x15F8F1C")]
	public void CallBack_RecivePacket(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x600649C")]
	[Address(RVA = "0x15F9294", Offset = "0x15F9294", VA = "0x15F9294")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x600649D")]
	[Address(RVA = "0x15F92E8", Offset = "0x15F92E8", VA = "0x15F92E8")]
	private void SaveCloseTime()
	{
	}

	[Token(Token = "0x600649E")]
	[Address(RVA = "0x15F9404", Offset = "0x15F9404", VA = "0x15F9404")]
	public void Hide()
	{
	}

	[Token(Token = "0x600649F")]
	[Address(RVA = "0x15F9444", Offset = "0x15F9444", VA = "0x15F9444", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60064A0")]
	[Address(RVA = "0x15F9474", Offset = "0x15F9474", VA = "0x15F9474", Slot = "5")]
	public void OnHide()
	{
	}

	[Token(Token = "0x60064A1")]
	[Address(RVA = "0x15F876C", Offset = "0x15F876C", VA = "0x15F876C")]
	private void StartTween()
	{
	}

	[Token(Token = "0x60064A2")]
	[Address(RVA = "0x15F8740", Offset = "0x15F8740", VA = "0x15F8740")]
	private void ResetTween()
	{
	}

	[Token(Token = "0x60064A3")]
	[Address(RVA = "0x15F9478", Offset = "0x15F9478", VA = "0x15F9478")]
	private static int _003CGetEventAttendanceList_003Em__32C(CSEventAttendanceBookItem o)
	{
		return default(int);
	}

	[Token(Token = "0x60064A4")]
	[Address(RVA = "0x15F9498", Offset = "0x15F9498", VA = "0x15F9498")]
	private void _003CRewardEventAttendance_003Em__32D(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
