using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DCD")]
public class XPanel_Chat : XCommonBackUI, IChatUI
{
	[Token(Token = "0x2000DCE")]
	public enum ChatTab
	{
		[Token(Token = "0x40047E3")]
		Channel = 0,
		[Token(Token = "0x40047E4")]
		Clan = 1,
		[Token(Token = "0x40047E5")]
		Friend = 2,
		[Token(Token = "0x40047E6")]
		Ingame = 3
	}

	[Token(Token = "0x2000DCF")]
	public enum ChatMode
	{
		[Token(Token = "0x40047E8")]
		Lobby = 0,
		[Token(Token = "0x40047E9")]
		Ingame = 1
	}

	[Token(Token = "0x40047C7")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Slide slide;

	[Token(Token = "0x40047C8")]
	[FieldOffset(Offset = "0x1C")]
	public XUIChatGround chatGround;

	[Token(Token = "0x40047C9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblChannelTab;

	[Token(Token = "0x40047CA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblGameTab;

	[Token(Token = "0x40047CB")]
	[FieldOffset(Offset = "0x28")]
	public UIButton btnChangeChannel;

	[Token(Token = "0x40047CC")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_ButtonOpenClanWar goBtnClanWar;

	[Token(Token = "0x40047CD")]
	[FieldOffset(Offset = "0x30")]
	public GameObject panel;

	[Token(Token = "0x40047CE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject clanWarReady;

	[Token(Token = "0x40047CF")]
	[FieldOffset(Offset = "0x38")]
	private ChatTab m_tabType;

	[Token(Token = "0x40047D0")]
	[FieldOffset(Offset = "0x3C")]
	private ChatMode m_chatMode;

	[Token(Token = "0x40047D1")]
	[FieldOffset(Offset = "0x40")]
	private bool m_canlobbyChat;

	[Token(Token = "0x40047D2")]
	[FieldOffset(Offset = "0x41")]
	private bool m_canIngameChat;

	[Token(Token = "0x40047D3")]
	[FieldOffset(Offset = "0x42")]
	private bool changingChannel;

	[Token(Token = "0x40047D4")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid tabGrid;

	[Token(Token = "0x40047D5")]
	[FieldOffset(Offset = "0x48")]
	public XWidget_ToggleTab[] m_tabs;

	[Token(Token = "0x40047D6")]
	[FieldOffset(Offset = "0x4C")]
	public bool[] m_tabNew;

	[Token(Token = "0x40047D7")]
	[FieldOffset(Offset = "0x50")]
	public UIButton btnFriend;

	[Token(Token = "0x40047D8")]
	[FieldOffset(Offset = "0x54")]
	public XWidget_ChannelLanguage LanguageChannelPopup;

	[Token(Token = "0x40047D9")]
	[FieldOffset(Offset = "0x58")]
	public UIButton btnTouchHide;

	[Token(Token = "0x40047DA")]
	[FieldOffset(Offset = "0x5C")]
	public UIInput input;

	[Token(Token = "0x40047DB")]
	[FieldOffset(Offset = "0x60")]
	public Transform dstClanBtnParentTr;

	[Token(Token = "0x40047DC")]
	[FieldOffset(Offset = "0x64")]
	private GameObject m_btnClanWar;

	[Token(Token = "0x40047DD")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_srcClanBtnParentTr;

	[Token(Token = "0x40047DE")]
	[FieldOffset(Offset = "0x6C")]
	private Action onConfirmMessage;

	[Token(Token = "0x40047DF")]
	[FieldOffset(Offset = "0x70")]
	private Action onRecieveMessage;

	[Token(Token = "0x40047E0")]
	[FieldOffset(Offset = "0x74")]
	public UILabel lblClanPartyCount;

	[Token(Token = "0x40047E1")]
	[FieldOffset(Offset = "0x78")]
	private bool m_isClanNew;

	[Token(Token = "0x17000D57")]
	public ChatTab TabType
	{
		[Token(Token = "0x60065AE")]
		[Address(RVA = "0x16A9900", Offset = "0x16A9900", VA = "0x16A9900")]
		get
		{
			return default(ChatTab);
		}
	}

	[Token(Token = "0x60065A5")]
	[Address(RVA = "0x16A8D20", Offset = "0x16A8D20", VA = "0x16A8D20")]
	public XPanel_Chat()
	{
	}

	[Token(Token = "0x60065A6")]
	[Address(RVA = "0x16A8D28", Offset = "0x16A8D28", VA = "0x16A8D28", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x60065A7")]
	[Address(RVA = "0x16A8E28", Offset = "0x16A8E28", VA = "0x16A8E28")]
	private bool FuncBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60065A8")]
	[Address(RVA = "0x16A9154", Offset = "0x16A9154", VA = "0x16A9154")]
	public void Init()
	{
	}

	[Token(Token = "0x60065A9")]
	[Address(RVA = "0x16A9160", Offset = "0x16A9160", VA = "0x16A9160")]
	public void RegisterOnConfirmMessage(Action onConfirmMessage)
	{
	}

	[Token(Token = "0x60065AA")]
	[Address(RVA = "0x16A93FC", Offset = "0x16A93FC", VA = "0x16A93FC")]
	public void RegisterOnRecieveMessage(Action onRecieveMessage)
	{
	}

	[Token(Token = "0x60065AB")]
	[Address(RVA = "0x16A9698", Offset = "0x16A9698", VA = "0x16A9698")]
	public void RegisterClanWarBtnToChat(Transform ParentTr, GameObject btnClanWar)
	{
	}

	[Token(Token = "0x60065AC")]
	[Address(RVA = "0x16A9774", Offset = "0x16A9774", VA = "0x16A9774")]
	public void MoveClanWarBtnToChat()
	{
	}

	[Token(Token = "0x60065AD")]
	[Address(RVA = "0x16A8FC8", Offset = "0x16A8FC8", VA = "0x16A8FC8")]
	public void MoveClanWarBtnToClanMain()
	{
	}

	[Token(Token = "0x60065AF")]
	[Address(RVA = "0x16A9908", Offset = "0x16A9908", VA = "0x16A9908")]
	private bool SoloModeType()
	{
		return default(bool);
	}

	[Token(Token = "0x60065B0")]
	[Address(RVA = "0x16A99F0", Offset = "0x16A99F0", VA = "0x16A99F0")]
	private bool IsPVEMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60065B1")]
	[Address(RVA = "0x16A9B10", Offset = "0x16A9B10", VA = "0x16A9B10")]
	public void BuildTab()
	{
	}

	[Token(Token = "0x60065B2")]
	[Address(RVA = "0x16A9F48", Offset = "0x16A9F48", VA = "0x16A9F48")]
	public void OnClick_ChannelTab()
	{
	}

	[Token(Token = "0x60065B3")]
	[Address(RVA = "0x16AA300", Offset = "0x16AA300", VA = "0x16AA300")]
	public void OnClick_ClanTab()
	{
	}

	[Token(Token = "0x60065B4")]
	[Address(RVA = "0x16AA4C0", Offset = "0x16AA4C0", VA = "0x16AA4C0")]
	public void SetClanTab()
	{
	}

	[Token(Token = "0x60065B5")]
	[Address(RVA = "0x16AA5A8", Offset = "0x16AA5A8", VA = "0x16AA5A8")]
	public void OnClick_FriendTab()
	{
	}

	[Token(Token = "0x60065B6")]
	[Address(RVA = "0x16AA790", Offset = "0x16AA790", VA = "0x16AA790")]
	public void OnClick_IngameTab()
	{
	}

	[Token(Token = "0x60065B7")]
	[Address(RVA = "0x16A9CDC", Offset = "0x16A9CDC", VA = "0x16A9CDC")]
	private void BuildTabChat(ChatTab type, ChatMode mode)
	{
	}

	[Token(Token = "0x60065B8")]
	[Address(RVA = "0x16AA8A4", Offset = "0x16AA8A4", VA = "0x16AA8A4")]
	private void BuildInputButton(ChatTab type)
	{
	}

	[Token(Token = "0x60065B9")]
	[Address(RVA = "0x16AAA40", Offset = "0x16AAA40", VA = "0x16AAA40")]
	private void ShowTabs()
	{
	}

	[Token(Token = "0x60065BA")]
	[Address(RVA = "0x16AAB90", Offset = "0x16AAB90", VA = "0x16AAB90")]
	private void Awake()
	{
	}

	[Token(Token = "0x60065BB")]
	[Address(RVA = "0x16AADE4", Offset = "0x16AADE4", VA = "0x16AADE4")]
	private void SetActiveTabNewBadge(int index, bool active)
	{
	}

	[Token(Token = "0x60065BC")]
	[Address(RVA = "0x16AAE74", Offset = "0x16AAE74", VA = "0x16AAE74")]
	private void OnSlideInStart()
	{
	}

	[Token(Token = "0x60065BD")]
	[Address(RVA = "0x16AB2C8", Offset = "0x16AB2C8", VA = "0x16AB2C8")]
	private void RefreshClanTabLock()
	{
	}

	[Token(Token = "0x60065BE")]
	[Address(RVA = "0x16AB484", Offset = "0x16AB484", VA = "0x16AB484")]
	private void OnSlideOut()
	{
	}

	[Token(Token = "0x60065BF")]
	[Address(RVA = "0x16AB510", Offset = "0x16AB510", VA = "0x16AB510", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60065C0")]
	[Address(RVA = "0x16AB4D0", Offset = "0x16AB4D0", VA = "0x16AB4D0")]
	private void privateHide()
	{
	}

	[Token(Token = "0x60065C1")]
	[Address(RVA = "0x16AB53C", Offset = "0x16AB53C", VA = "0x16AB53C")]
	public void BuildChatWindow(string channelTitle, string gameTabTitle, bool canlobbyChat, bool canIngameChat, List<ChatMessage> msgs)
	{
	}

	[Token(Token = "0x60065C2")]
	[Address(RVA = "0x16AB8B4", Offset = "0x16AB8B4", VA = "0x16AB8B4", Slot = "24")]
	public void RefreshClanWarPartyCount(int clanWarPartyCount)
	{
	}

	[Token(Token = "0x60065C3")]
	[Address(RVA = "0x16ABAE8", Offset = "0x16ABAE8", VA = "0x16ABAE8", Slot = "23")]
	public bool CheckMessageTypeInTab(PhotonChatMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x60065C4")]
	[Address(RVA = "0x16ABBD0", Offset = "0x16ABBD0", VA = "0x16ABBD0", Slot = "22")]
	public void AddChatMessage(ChatMessage msg)
	{
	}

	[Token(Token = "0x60065C5")]
	[Address(RVA = "0x16A9F7C", Offset = "0x16A9F7C", VA = "0x16A9F7C", Slot = "19")]
	public void ChatWindowRefresh()
	{
	}

	[Token(Token = "0x60065C6")]
	[Address(RVA = "0x16ABBFC", Offset = "0x16ABBFC", VA = "0x16ABBFC", Slot = "20")]
	public void RefreshUIChatMessages(XUIChatGround.XUIChatMessageType type)
	{
	}

	[Token(Token = "0x60065C7")]
	[Address(RVA = "0x16ABCDC", Offset = "0x16ABCDC", VA = "0x16ABCDC", Slot = "21")]
	public void RefreshMessages(List<ChatMessage> messages)
	{
	}

	[Token(Token = "0x60065C8")]
	[Address(RVA = "0x16ABDBC", Offset = "0x16ABDBC", VA = "0x16ABDBC", Slot = "25")]
	public void ChatUIClear()
	{
	}

	[Token(Token = "0x60065C9")]
	[Address(RVA = "0x16ABE94", Offset = "0x16ABE94", VA = "0x16ABE94", Slot = "26")]
	public void RefreshChatTab()
	{
	}

	[Token(Token = "0x60065CA")]
	[Address(RVA = "0x16ABEB0", Offset = "0x16ABEB0", VA = "0x16ABEB0")]
	public void OnReceiveMessage(ChannelState state)
	{
	}

	[Token(Token = "0x60065CB")]
	[Address(RVA = "0x16AC008", Offset = "0x16AC008", VA = "0x16AC008")]
	public void SetClanInviteChatNew(bool isEnable)
	{
	}

	[Token(Token = "0x60065CC")]
	[Address(RVA = "0x16AAA10", Offset = "0x16AAA10", VA = "0x16AAA10")]
	private void OnConfirmMessage()
	{
	}

	[Token(Token = "0x60065CD")]
	[Address(RVA = "0x16AC0A8", Offset = "0x16AC0A8", VA = "0x16AC0A8")]
	public bool HasNewMessage()
	{
		return default(bool);
	}

	[Token(Token = "0x60065CE")]
	[Address(RVA = "0x16AB8E4", Offset = "0x16AB8E4", VA = "0x16AB8E4")]
	private void OnClanWarPartyUpdated(int clanWarPartyCount)
	{
	}

	[Token(Token = "0x60065CF")]
	[Address(RVA = "0x16AC158", Offset = "0x16AC158", VA = "0x16AC158")]
	public void OnInputSubmit()
	{
	}

	[Token(Token = "0x60065D0")]
	[Address(RVA = "0x16AC460", Offset = "0x16AC460", VA = "0x16AC460")]
	private void SendChatMessage(string strMsg, string strOriginMessage, object chatParams)
	{
	}

	[Token(Token = "0x60065D1")]
	[Address(RVA = "0x16AC724", Offset = "0x16AC724", VA = "0x16AC724")]
	public void RefreshChannel()
	{
	}

	[Token(Token = "0x60065D2")]
	[Address(RVA = "0x16AC358", Offset = "0x16AC358", VA = "0x16AC358")]
	private string GetAbuseFiltering(string val)
	{
		return null;
	}

	[Token(Token = "0x60065D3")]
	[Address(RVA = "0x16ACAB8", Offset = "0x16ACAB8", VA = "0x16ACAB8")]
	public void OnClick_ShowFriendListPopup()
	{
	}

	[Token(Token = "0x60065D4")]
	[Address(RVA = "0x16ACABC", Offset = "0x16ACABC", VA = "0x16ACABC")]
	public void OnClick_HideFriendListPopup()
	{
	}

	[Token(Token = "0x60065D5")]
	[Address(RVA = "0x16ACAC0", Offset = "0x16ACAC0", VA = "0x16ACAC0")]
	public void OnClick_Infomation(EventDelegate eventDelegate)
	{
	}

	[Token(Token = "0x60065D6")]
	[Address(RVA = "0x16ACC64", Offset = "0x16ACC64", VA = "0x16ACC64")]
	public void OnClick_HideInfomation()
	{
	}

	[Token(Token = "0x60065D7")]
	[Address(RVA = "0x16ACCA4", Offset = "0x16ACCA4", VA = "0x16ACCA4")]
	public void OnClickShowLanguageCannelPopup()
	{
	}

	[Token(Token = "0x60065D8")]
	[Address(RVA = "0x16A8DB8", Offset = "0x16A8DB8", VA = "0x16A8DB8")]
	public void HideLanguageCannelPopup()
	{
	}

	[Token(Token = "0x60065D9")]
	[Address(RVA = "0x16ACE94", Offset = "0x16ACE94", VA = "0x16ACE94")]
	public void OnChangeLanguageChannel(string changeLang, int changeChannelID)
	{
	}

	[Token(Token = "0x60065DA")]
	[Address(RVA = "0x16AD0FC", Offset = "0x16AD0FC", VA = "0x16AD0FC")]
	public void GlobalChatSlideIn()
	{
	}

	[Token(Token = "0x60065DB")]
	[Address(RVA = "0x16AD324", Offset = "0x16AD324", VA = "0x16AD324")]
	public void ClanChatSlideIn()
	{
	}

	[Token(Token = "0x60065DC")]
	[Address(RVA = "0x16AD2C0", Offset = "0x16AD2C0", VA = "0x16AD2C0")]
	public void OutingToSlideIn()
	{
	}

	[Token(Token = "0x60065DD")]
	[Address(RVA = "0x16AD340", Offset = "0x16AD340", VA = "0x16AD340")]
	public void OnClickHideCollider()
	{
	}

	[Token(Token = "0x60065DE")]
	[Address(RVA = "0x16AD4EC", Offset = "0x16AD4EC", VA = "0x16AD4EC", Slot = "18")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60065DF")]
	[Address(RVA = "0x16AD518", Offset = "0x16AD518", VA = "0x16AD518")]
	private void _003COnClick_Infomation_003Em__356()
	{
	}
}
