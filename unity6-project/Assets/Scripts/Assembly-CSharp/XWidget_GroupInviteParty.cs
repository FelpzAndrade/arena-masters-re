using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D9E")]
public class XWidget_GroupInviteParty : MonoBehaviour, IFriendPartyListener
{
	[Token(Token = "0x40046B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string PREFAB_PATH;

	[Token(Token = "0x40046B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject goInviteButton;

	[Token(Token = "0x40046B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder memberBuilder;

	[Token(Token = "0x40046BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Action onClickShowInvitePopup;

	[Token(Token = "0x40046BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Func<XGameModeType> doGetGameModeType;

	[Token(Token = "0x40046BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool IsMaster__BackingField;

	[Token(Token = "0x17000D49")]
	public bool IsMaster
	{
		[Token(Token = "0x600642A")]
		[Address(RVA = "0x143DA44", Offset = "0x143DA44", VA = "0x143DA44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600642B")]
		[Address(RVA = "0x143DA4C", Offset = "0x143DA4C", VA = "0x143DA4C")]
		private set
		{
		}
	}

	[Token(Token = "0x6006427")]
	[Address(RVA = "0x143D80C", Offset = "0x143D80C", VA = "0x143D80C")]
	public XWidget_GroupInviteParty()
	{
	}

	[Token(Token = "0x6006429")]
	[Address(RVA = "0x143D8A4", Offset = "0x143D8A4", VA = "0x143D8A4")]
	public static XWidget_GroupInviteParty Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600642C")]
	[Address(RVA = "0x143DA54", Offset = "0x143DA54", VA = "0x143DA54", Slot = "4")]
	public void OnUpdatePartyInfo(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x600642D")]
	[Address(RVA = "0x143DD3C", Offset = "0x143DD3C", VA = "0x143DD3C", Slot = "11")]
	public void OnBreakParty()
	{
	}

	[Token(Token = "0x600642E")]
	[Address(RVA = "0x143DDD8", Offset = "0x143DDD8", VA = "0x143DDD8", Slot = "5")]
	public void OnDisconnectFromPhoton()
	{
	}

	[Token(Token = "0x600642F")]
	[Address(RVA = "0x143DE74", Offset = "0x143DE74", VA = "0x143DE74", Slot = "9")]
	public void OnCreatePary()
	{
	}

	[Token(Token = "0x6006430")]
	[Address(RVA = "0x143DE9C", Offset = "0x143DE9C", VA = "0x143DE9C")]
	public void BuildMasterView(DTPartyInfo partyInfo, [Optional] Action onClickShowInvitePopup, [Optional] Func<XGameModeType> doGetGameModeType)
	{
	}

	[Token(Token = "0x6006431")]
	[Address(RVA = "0x143E048", Offset = "0x143E048", VA = "0x143E048")]
	public void BuildReadyView(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6006432")]
	[Address(RVA = "0x143DEC8", Offset = "0x143DEC8", VA = "0x143DEC8")]
	private void Build(DTPartyInfo partyInfo, bool isMaster, [Optional] Action onClickShowInvitePopup)
	{
	}

	[Token(Token = "0x6006433")]
	[Address(RVA = "0x143E074", Offset = "0x143E074", VA = "0x143E074")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006434")]
	[Address(RVA = "0x143DC04", Offset = "0x143DC04", VA = "0x143DC04")]
	private void BuildInviteButton(bool isMaster, DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6006435")]
	[Address(RVA = "0x143DA7C", Offset = "0x143DA7C", VA = "0x143DA7C")]
	private void BuildMember(DTPartyInfo partyInfo)
	{
	}

	[Token(Token = "0x6006436")]
	[Address(RVA = "0x143DE88", Offset = "0x143DE88", VA = "0x143DE88")]
	private void OnShowInvitePopup()
	{
	}

	[Token(Token = "0x6006437")]
	[Address(RVA = "0x143E530", Offset = "0x143E530", VA = "0x143E530")]
	public void OnClick_InviteButton()
	{
	}

	[Token(Token = "0x6006438")]
	[Address(RVA = "0x143E6D4", Offset = "0x143E6D4", VA = "0x143E6D4", Slot = "6")]
	public void OnChangeGameModeInfo(XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x6006439")]
	[Address(RVA = "0x143E6D8", Offset = "0x143E6D8", VA = "0x143E6D8", Slot = "7")]
	public void OnReciveAccept(string accepter)
	{
	}

	[Token(Token = "0x600643A")]
	[Address(RVA = "0x143E6DC", Offset = "0x143E6DC", VA = "0x143E6DC", Slot = "8")]
	public void OnReciveRefuse(string refuser)
	{
	}

	[Token(Token = "0x600643B")]
	[Address(RVA = "0x143E6E0", Offset = "0x143E6E0", VA = "0x143E6E0", Slot = "10")]
	public void OnLeaveParty()
	{
	}
}
