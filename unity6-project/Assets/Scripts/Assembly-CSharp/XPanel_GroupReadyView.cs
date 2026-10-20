using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F08")]
public class XPanel_GroupReadyView : XUIBasePanel, IFriendPartyListener
{
	[Token(Token = "0x4004FAB")]
	[FieldOffset(Offset = "0x10")]
	public Transform groupInviteInfoParent;

	[Token(Token = "0x4004FAC")]
	[FieldOffset(Offset = "0x14")]
	private XWidget_GroupInviteParty groupPartyInviteInfo;

	[Token(Token = "0x4004FAD")]
	[FieldOffset(Offset = "0x18")]
	public Transform partyViewTransform;

	[Token(Token = "0x4004FAE")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_PartyViewer partyViewer;

	[Token(Token = "0x4004FAF")]
	[FieldOffset(Offset = "0x20")]
	public Transform teamSettingParent;

	[Token(Token = "0x4004FB0")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_StageTeamInfoSetting teamSetting;

	[Token(Token = "0x4004FB1")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_Button btnStart;

	[Token(Token = "0x4004FB2")]
	[FieldOffset(Offset = "0x2C")]
	private XWidget_PVPReadyView _pvpInfo;

	[Token(Token = "0x4004FB3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject goDisableColider;

	[Token(Token = "0x4004FB4")]
	[FieldOffset(Offset = "0x34")]
	private bool IsReady;

	[Token(Token = "0x4004FB5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblRoomName;

	[Token(Token = "0x4004FB6")]
	[FieldOffset(Offset = "0x3C")]
	private readonly string Path_PVPInfo;

	[Token(Token = "0x4004FB7")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<NetMatchPlayerInfo> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x4004FB8")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x17000E2E")]
	protected override int BackableStackCount
	{
		[Token(Token = "0x6007026")]
		[Address(RVA = "0xFF33E8", Offset = "0xFF33E8", VA = "0xFF33E8", Slot = "18")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E2F")]
	public XWidget_GroupInviteParty GroupInviteParty
	{
		[Token(Token = "0x6007027")]
		[Address(RVA = "0xFF33F0", Offset = "0xFF33F0", VA = "0xFF33F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E30")]
	private XWidget_PVPReadyView pvpInfo
	{
		[Token(Token = "0x6007028")]
		[Address(RVA = "0xFF33F8", Offset = "0xFF33F8", VA = "0xFF33F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007025")]
	[Address(RVA = "0xFF335C", Offset = "0xFF335C", VA = "0xFF335C")]
	public XPanel_GroupReadyView()
	{
	}

	[Token(Token = "0x6007029")]
	[Address(RVA = "0xFF34F8", Offset = "0xFF34F8", VA = "0xFF34F8")]
	private void BuildModenfo(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x600702A")]
	[Address(RVA = "0xFF3614", Offset = "0xFF3614", VA = "0xFF3614")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600702B")]
	[Address(RVA = "0xFF36F8", Offset = "0xFF36F8", VA = "0xFF36F8")]
	public void Show(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x600702C")]
	[Address(RVA = "0xFF3B7C", Offset = "0xFF3B7C", VA = "0xFF3B7C")]
	private void BuildPartyViewer()
	{
	}

	[Token(Token = "0x600702D")]
	[Address(RVA = "0xFF3E80", Offset = "0xFF3E80", VA = "0xFF3E80")]
	private void BuildTeamSetting(XGameModeType gameModeType, bool isRandomMode)
	{
	}

	[Token(Token = "0x600702E")]
	[Address(RVA = "0xFF3D4C", Offset = "0xFF3D4C", VA = "0xFF3D4C")]
	private void BuildGroupParty(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x600702F")]
	[Address(RVA = "0xFF4090", Offset = "0xFF4090", VA = "0xFF4090")]
	private void OnClick_ChangeReady()
	{
	}

	[Token(Token = "0x6007030")]
	[Address(RVA = "0xFF406C", Offset = "0xFF406C", VA = "0xFF406C")]
	private void BuildReady(bool isReady)
	{
	}

	[Token(Token = "0x6007031")]
	[Address(RVA = "0xFF427C", Offset = "0xFF427C", VA = "0xFF427C")]
	private void BuildReadyButtonText(bool isReady)
	{
	}

	[Token(Token = "0x6007032")]
	[Address(RVA = "0xFF419C", Offset = "0xFF419C", VA = "0xFF419C")]
	private void ChangeReady(bool ready)
	{
	}

	[Token(Token = "0x6007033")]
	[Address(RVA = "0xFF4340", Offset = "0xFF4340", VA = "0xFF4340", Slot = "19")]
	public void OnUpdatePartyInfo(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6007034")]
	[Address(RVA = "0xFF4344", Offset = "0xFF4344", VA = "0xFF4344", Slot = "26")]
	public void OnBreakParty()
	{
	}

	[Token(Token = "0x6007035")]
	[Address(RVA = "0xFF45F4", Offset = "0xFF45F4", VA = "0xFF45F4", Slot = "20")]
	public void OnDisconnectFromPhoton()
	{
	}

	[Token(Token = "0x6007036")]
	[Address(RVA = "0xFF4348", Offset = "0xFF4348", VA = "0xFF4348")]
	private void ProcessGroupPlayCancel()
	{
	}

	[Token(Token = "0x6007037")]
	[Address(RVA = "0xFF45F8", Offset = "0xFF45F8", VA = "0xFF45F8", Slot = "24")]
	public void OnCreatePary()
	{
	}

	[Token(Token = "0x6007038")]
	[Address(RVA = "0xFF45FC", Offset = "0xFF45FC", VA = "0xFF45FC", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6007039")]
	[Address(RVA = "0xFF48F4", Offset = "0xFF48F4", VA = "0xFF48F4", Slot = "21")]
	public void OnChangeGameModeInfo(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x600703A")]
	[Address(RVA = "0xFF49E0", Offset = "0xFF49E0", VA = "0xFF49E0", Slot = "22")]
	public void OnReciveAccept(string accepter)
	{
	}

	[Token(Token = "0x600703B")]
	[Address(RVA = "0xFF49E4", Offset = "0xFF49E4", VA = "0xFF49E4", Slot = "23")]
	public void OnReciveRefuse(string refuser)
	{
	}

	[Token(Token = "0x600703C")]
	[Address(RVA = "0xFF49E8", Offset = "0xFF49E8", VA = "0xFF49E8", Slot = "25")]
	public void OnLeaveParty()
	{
	}

	[Token(Token = "0x600703D")]
	[Address(RVA = "0xFF49EC", Offset = "0xFF49EC", VA = "0xFF49EC")]
	private static bool _003CShow_003Em__45A(NetMatchPlayerInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x600703E")]
	[Address(RVA = "0xFF4B24", Offset = "0xFF4B24", VA = "0xFF4B24")]
	private static void _003CBack_003Em__45B()
	{
	}
}
