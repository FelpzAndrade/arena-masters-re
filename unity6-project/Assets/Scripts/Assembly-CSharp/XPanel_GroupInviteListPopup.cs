using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000D99")]
public class XPanel_GroupInviteListPopup : MonoBehaviour, IFriendListener, IFriendPartyListener
{
	[Token(Token = "0x40046A9")]
	[FieldOffset(Offset = "0xC")]
	public XUIList_GroupInviteList inviteUIList;

	[Token(Token = "0x40046AA")]
	[FieldOffset(Offset = "0x10")]
	public List<XFriendData> friendData;

	[Token(Token = "0x40046AB")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<XFriendData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40046AC")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<XFriendData> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40046AD")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<XFriendData> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x6006400")]
	[Address(RVA = "0xFF1A78", Offset = "0xFF1A78", VA = "0xFF1A78")]
	public XPanel_GroupInviteListPopup()
	{
	}

	[Token(Token = "0x6006401")]
	[Address(RVA = "0xFF1B24", Offset = "0xFF1B24", VA = "0xFF1B24")]
	private void BuildInviteUI(List<XFriendData> liFriendData, int latelyPlayedFriendCount)
	{
	}

	[Token(Token = "0x6006402")]
	[Address(RVA = "0xFF1B50", Offset = "0xFF1B50", VA = "0xFF1B50")]
	private void TryGetFriendData(List<XFriendData> originData, out List<XFriendData> friendData, out int latelyPlayedFriendCount)
	{
		friendData = default;
		latelyPlayedFriendCount = default;
	}

	[Token(Token = "0x6006403")]
	[Address(RVA = "0xFDDC8C", Offset = "0xFDDC8C", VA = "0xFDDC8C")]
	public void Show()
	{
	}

	[Token(Token = "0x6006404")]
	[Address(RVA = "0xFF2164", Offset = "0xFF2164", VA = "0xFF2164")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006405")]
	[Address(RVA = "0xFF1F8C", Offset = "0xFF1F8C", VA = "0xFF1F8C")]
	private void SendProcessFriendList()
	{
	}

	[Token(Token = "0x6006406")]
	[Address(RVA = "0xFDA4FC", Offset = "0xFDA4FC", VA = "0xFDA4FC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006407")]
	[Address(RVA = "0xFF22A4", Offset = "0xFF22A4", VA = "0xFF22A4", Slot = "11")]
	public void OnLeaveParty()
	{
	}

	[Token(Token = "0x6006408")]
	[Address(RVA = "0xFF22A8", Offset = "0xFF22A8", VA = "0xFF22A8")]
	private void RefreshPartyJoinedState()
	{
	}

	[Token(Token = "0x6006409")]
	[Address(RVA = "0xFF25A0", Offset = "0xFF25A0", VA = "0xFF25A0", Slot = "8")]
	public void OnReciveAccept(string accepter)
	{
	}

	[Token(Token = "0x600640A")]
	[Address(RVA = "0xFF2680", Offset = "0xFF2680", VA = "0xFF2680", Slot = "12")]
	public void OnBreakParty()
	{
	}

	[Token(Token = "0x600640B")]
	[Address(RVA = "0xFF2864", Offset = "0xFF2864", VA = "0xFF2864", Slot = "6")]
	public void OnDisconnectFromPhoton()
	{
	}

	[Token(Token = "0x600640C")]
	[Address(RVA = "0xFF2A48", Offset = "0xFF2A48", VA = "0xFF2A48", Slot = "9")]
	public void OnReciveRefuse(string refuser)
	{
	}

	[Token(Token = "0x600640D")]
	[Address(RVA = "0xFF1F48", Offset = "0xFF1F48", VA = "0xFF1F48", Slot = "4")]
	public void OnUpdateFriendList(List<XFriendData> liFriendData)
	{
	}

	[Token(Token = "0x600640E")]
	[Address(RVA = "0xFF2B28", Offset = "0xFF2B28", VA = "0xFF2B28", Slot = "5")]
	public void OnUpdatePartyInfo(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x600640F")]
	[Address(RVA = "0xFF2B2C", Offset = "0xFF2B2C", VA = "0xFF2B2C", Slot = "10")]
	public void OnCreatePary()
	{
	}

	[Token(Token = "0x6006410")]
	[Address(RVA = "0xFF2B30", Offset = "0xFF2B30", VA = "0xFF2B30", Slot = "7")]
	public void OnChangeGameModeInfo(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6006411")]
	[Address(RVA = "0xFF2B34", Offset = "0xFF2B34", VA = "0xFF2B34")]
	private static bool _003CTryGetFriendData_003Em__31C(XFriendData x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006412")]
	[Address(RVA = "0xFF2B84", Offset = "0xFF2B84", VA = "0xFF2B84")]
	private static bool _003CTryGetFriendData_003Em__31D(XFriendData x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006413")]
	[Address(RVA = "0xFF2C94", Offset = "0xFF2C94", VA = "0xFF2C94")]
	private static bool _003CTryGetFriendData_003Em__31E(XFriendData x)
	{
		return default(bool);
	}

	[Token(Token = "0x6006414")]
	[Address(RVA = "0xFF2DA4", Offset = "0xFF2DA4", VA = "0xFF2DA4")]
	private void _003CShow_003Em__31F()
	{
	}

	[Token(Token = "0x6006415")]
	[Address(RVA = "0xFF2E90", Offset = "0xFF2E90", VA = "0xFF2E90")]
	private void _003CSendProcessFriendList_003Em__320(ApiReturnCode result, string errmsg, JObject json)
	{
	}
}
