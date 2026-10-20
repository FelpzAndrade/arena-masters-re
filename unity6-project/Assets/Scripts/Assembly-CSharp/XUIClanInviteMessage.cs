using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C40")]
public class XUIClanInviteMessage : XUIChatMessageBase
{
	[Token(Token = "0x2000C41")]
	private enum MsgUIState
	{
		[Token(Token = "0x4003E00")]
		Disable = 0,
		[Token(Token = "0x4003E01")]
		HostCreated = 1,
		[Token(Token = "0x4003E02")]
		HostStartAble = 2,
		[Token(Token = "0x4003E03")]
		JoinAble = 3,
		[Token(Token = "0x4003E04")]
		JoinNotAble = 4,
		[Token(Token = "0x4003E05")]
		Joined = 5,
		[Token(Token = "0x4003E06")]
		MatchingStart = 6,
		[Token(Token = "0x4003E07")]
		CanNotJoinInGame = 7,
		[Token(Token = "0x4003E08")]
		FullParty = 8,
		[Token(Token = "0x4003E09")]
		AlreadyMatching = 9
	}

	[Token(Token = "0x4003DE8")]
	private const float m_fRefreshClanPartydestTime = 2f;

	[Token(Token = "0x4003DE9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH_ClanInvitePlayer;

	[Token(Token = "0x4003DEA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject btnClanPartyCancel;

	[Token(Token = "0x4003DEB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject btnClanWarStart;

	[Token(Token = "0x4003DEC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject btnClanWarMatchCancel;

	[Token(Token = "0x4003DED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject btnClanWarDisable;

	[Token(Token = "0x4003DEE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject btnJoin;

	[Token(Token = "0x4003DEF")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject btnJoinDisable;

	[Token(Token = "0x4003DF0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject btnJoinCancel;

	[Token(Token = "0x4003DF1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject btnJoinCancelDisable;

	[Token(Token = "0x4003DF2")]
	[FieldOffset(Offset = "0x38")]
	public XUIChatSearching searchingLabel;

	[Token(Token = "0x4003DF3")]
	[FieldOffset(Offset = "0x3C")]
	public XUIChatWaiting waitingLabel;

	[Token(Token = "0x4003DF4")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblTitle;

	[Token(Token = "0x4003DF5")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblTitleCreateTime;

	[Token(Token = "0x4003DF6")]
	[FieldOffset(Offset = "0x48")]
	public List<Transform> trPlayerList;

	[Token(Token = "0x4003DF7")]
	[FieldOffset(Offset = "0x4C")]
	private List<XUIChatClanInvitePlayer> ChatPlayerList;

	[Token(Token = "0x4003DF8")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public long PartyID;

	[Token(Token = "0x4003DF9")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public string PartyHostName;

	[Token(Token = "0x4003DFA")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsClickHanding;

	[Token(Token = "0x4003DFB")]
	[FieldOffset(Offset = "0x60")]
	private XClanInviteChatMessageObject m_ChatMessageObj;

	[Token(Token = "0x4003DFC")]
	[FieldOffset(Offset = "0x64")]
	private float m_fRefreshClanPartyChecktime;

	[Token(Token = "0x4003DFD")]
	[FieldOffset(Offset = "0x68")]
	private bool m_isReqRefreshClanParty;

	[Token(Token = "0x4003DFE")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<NetMatchPlayerInfoForChat> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x6005889")]
	[Address(RVA = "0x1A3605C", Offset = "0x1A3605C", VA = "0x1A3605C")]
	public XUIClanInviteMessage()
	{
	}

	[Token(Token = "0x600588B")]
	[Address(RVA = "0x1A361A0", Offset = "0x1A361A0", VA = "0x1A361A0", Slot = "6")]
	public override void InitBuilder()
	{
	}

	[Token(Token = "0x600588C")]
	[Address(RVA = "0x1A363F4", Offset = "0x1A363F4", VA = "0x1A363F4", Slot = "4")]
	public override void Build(ChatMessage msg, Action<EventDelegate> infoAction)
	{
	}

	[Token(Token = "0x600588D")]
	[Address(RVA = "0x1A3683C", Offset = "0x1A3683C", VA = "0x1A3683C", Slot = "5")]
	public override void RefreshUI()
	{
	}

	[Token(Token = "0x600588E")]
	[Address(RVA = "0x1A361A4", Offset = "0x1A361A4", VA = "0x1A361A4")]
	private void ClanInvitePlayerBuild()
	{
	}

	[Token(Token = "0x600588F")]
	[Address(RVA = "0x1A3651C", Offset = "0x1A3651C", VA = "0x1A3651C")]
	private void ChatPlayersBuild(XClanInviteChatMessageObject msgObj)
	{
	}

	[Token(Token = "0x6005890")]
	[Address(RVA = "0x1A36790", Offset = "0x1A36790", VA = "0x1A36790")]
	private void ChatInfoBuild(XClanInviteChatMessageObject msgObj)
	{
	}

	[Token(Token = "0x6005891")]
	[Address(RVA = "0x1A36858", Offset = "0x1A36858", VA = "0x1A36858")]
	private string MakeServerTickToStringTime(long utcTick)
	{
		return null;
	}

	[Token(Token = "0x6005892")]
	[Address(RVA = "0x1A36BC4", Offset = "0x1A36BC4", VA = "0x1A36BC4")]
	private void BuildClanWarTitle()
	{
	}

	[Token(Token = "0x6005893")]
	[Address(RVA = "0x1A36C74", Offset = "0x1A36C74", VA = "0x1A36C74")]
	private MsgUIState GetUIStateFromMsg(XClanInviteChatMessageObject msgObj)
	{
		return default(MsgUIState);
	}

	[Token(Token = "0x6005894")]
	[Address(RVA = "0x1A370D4", Offset = "0x1A370D4", VA = "0x1A370D4")]
	private void RefreshClanParty(XClanInviteChatMessageObject.ClanInviteState state)
	{
	}

	[Token(Token = "0x6005895")]
	[Address(RVA = "0x1A37350", Offset = "0x1A37350", VA = "0x1A37350")]
	private void Update()
	{
	}

	[Token(Token = "0x6005896")]
	[Address(RVA = "0x1A3650C", Offset = "0x1A3650C", VA = "0x1A3650C")]
	private void ResetRefreshClanPartyState()
	{
	}

	[Token(Token = "0x6005897")]
	[Address(RVA = "0x1A37304", Offset = "0x1A37304", VA = "0x1A37304")]
	private bool IsInValidMessage(XClanInviteChatMessageObject obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6005898")]
	[Address(RVA = "0x1A373AC", Offset = "0x1A373AC", VA = "0x1A373AC")]
	private bool IsPartyMemeber(List<NetMatchPlayerInfoForChat> list)
	{
		return default(bool);
	}

	[Token(Token = "0x6005899")]
	[Address(RVA = "0x1A371E4", Offset = "0x1A371E4", VA = "0x1A371E4")]
	private bool isHost(string nickName)
	{
		return default(bool);
	}

	[Token(Token = "0x600589A")]
	[Address(RVA = "0x1A3706C", Offset = "0x1A3706C", VA = "0x1A3706C")]
	private void UIStateLayoutBuild(MsgUIState state)
	{
	}

	[Token(Token = "0x600589B")]
	[Address(RVA = "0x1A3757C", Offset = "0x1A3757C", VA = "0x1A3757C")]
	private void DisableLayoutUI()
	{
	}

	[Token(Token = "0x600589C")]
	[Address(RVA = "0x1A37638", Offset = "0x1A37638", VA = "0x1A37638")]
	private void HostCreateLayoutUI()
	{
	}

	[Token(Token = "0x600589D")]
	[Address(RVA = "0x1A3770C", Offset = "0x1A3770C", VA = "0x1A3770C")]
	private void HostStartAbleLayoutUI()
	{
	}

	[Token(Token = "0x600589E")]
	[Address(RVA = "0x1A377E0", Offset = "0x1A377E0", VA = "0x1A377E0")]
	private void JoinAbleLayoutUI()
	{
	}

	[Token(Token = "0x600589F")]
	[Address(RVA = "0x1A37950", Offset = "0x1A37950", VA = "0x1A37950")]
	private void JoinNotAbleLayoutUI()
	{
	}

	[Token(Token = "0x60058A0")]
	[Address(RVA = "0x1A37A24", Offset = "0x1A37A24", VA = "0x1A37A24")]
	private void JoinedLayoutUI()
	{
	}

	[Token(Token = "0x60058A1")]
	[Address(RVA = "0x1A37AF8", Offset = "0x1A37AF8", VA = "0x1A37AF8")]
	private void MatchingStartLayoutUI()
	{
	}

	[Token(Token = "0x60058A2")]
	[Address(RVA = "0x1A37BB4", Offset = "0x1A37BB4", VA = "0x1A37BB4")]
	private void CanNotJoinInGameLayoutUI()
	{
	}

	[Token(Token = "0x60058A3")]
	[Address(RVA = "0x1A37C88", Offset = "0x1A37C88", VA = "0x1A37C88")]
	private void FullPartyLayoutUI()
	{
	}

	[Token(Token = "0x60058A4")]
	[Address(RVA = "0x1A37D5C", Offset = "0x1A37D5C", VA = "0x1A37D5C")]
	private void AlreadyMatchingLayoutUI()
	{
	}

	[Token(Token = "0x60058A5")]
	[Address(RVA = "0x1A37E44", Offset = "0x1A37E44", VA = "0x1A37E44")]
	public void OnClickMatchCancelButton()
	{
	}

	[Token(Token = "0x60058A6")]
	[Address(RVA = "0x1A37FA0", Offset = "0x1A37FA0", VA = "0x1A37FA0")]
	private void LeaveFunc()
	{
	}

	[Token(Token = "0x60058A7")]
	[Address(RVA = "0x1A37FAC", Offset = "0x1A37FAC", VA = "0x1A37FAC")]
	public void OnClickPartyCancelButton()
	{
	}

	[Token(Token = "0x60058A8")]
	[Address(RVA = "0x1A38108", Offset = "0x1A38108", VA = "0x1A38108")]
	private void PartyCancelButtonFunc()
	{
	}

	[Token(Token = "0x60058A9")]
	[Address(RVA = "0x1A38124", Offset = "0x1A38124", VA = "0x1A38124")]
	public void OnClickStartButton()
	{
	}

	[Token(Token = "0x60058AA")]
	[Address(RVA = "0x1A38224", Offset = "0x1A38224", VA = "0x1A38224")]
	public void OnClickJoinCancelButton()
	{
	}

	[Token(Token = "0x60058AB")]
	[Address(RVA = "0x1A38380", Offset = "0x1A38380", VA = "0x1A38380")]
	public void OnClickJoinButton()
	{
	}

	[Token(Token = "0x60058AC")]
	[Address(RVA = "0x1A38490", Offset = "0x1A38490", VA = "0x1A38490")]
	public void OnClickJoinNotAbleButton()
	{
	}

	[Token(Token = "0x60058AD")]
	[Address(RVA = "0x1A3856C", Offset = "0x1A3856C", VA = "0x1A3856C")]
	private static bool _003CIsPartyMemeber_003Em__24D(NetMatchPlayerInfoForChat x)
	{
		return default(bool);
	}
}
