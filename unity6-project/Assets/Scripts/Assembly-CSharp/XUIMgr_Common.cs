using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001057")]
public class XUIMgr_Common : XUIMgrBase
{
	[Token(Token = "0x4005810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private XUIInputBox inputBox;

	[Token(Token = "0x4005811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XPanel_Chat m_chatWindow;

	[Token(Token = "0x4005812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private XUIMessageBox m_messageBox;

	[Token(Token = "0x4005813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XUIFlatMessageBox m_flatMessageBox;

	[Token(Token = "0x4005814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private XWidget_Notification m_notification;

	[Token(Token = "0x4005815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XPanel_NetworkLoading m_pnlNetworkLoadingWindow;

	[Token(Token = "0x4005816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private GameObject m_pnlDisableInput;

	[Token(Token = "0x4005817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XPanel_Message m_messageWindow;

	[Token(Token = "0x4005818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XUIConsoleWindow m_consoleWindow;

	[Token(Token = "0x4005819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XPanel_NotiBox m_NotiBox;

	[Token(Token = "0x400581A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XPanel_QuestNotification m_pnlQuestNoti;

	[Token(Token = "0x400581B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private XPanel_Broadcast m_pnlBroadcast;

	[Token(Token = "0x400581C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool m_inited;

	[Token(Token = "0x17000F11")]
	public XPanel_Chat chatWindow
	{
		[Token(Token = "0x6007A13")]
		[Address(RVA = "0x10B8AE4", Offset = "0x10B8AE4", VA = "0x10B8AE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F12")]
	private XUIMessageBox messageBox
	{
		[Token(Token = "0x6007A14")]
		[Address(RVA = "0x10B8CD8", Offset = "0x10B8CD8", VA = "0x10B8CD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F13")]
	private XUIFlatMessageBox flatMessageBox
	{
		[Token(Token = "0x6007A15")]
		[Address(RVA = "0x10B8DE4", Offset = "0x10B8DE4", VA = "0x10B8DE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F14")]
	private XWidget_Notification notification
	{
		[Token(Token = "0x6007A16")]
		[Address(RVA = "0x10B8EF0", Offset = "0x10B8EF0", VA = "0x10B8EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F15")]
	private XPanel_NetworkLoading pnlNetworkLoadingWindow
	{
		[Token(Token = "0x6007A17")]
		[Address(RVA = "0x10B8FFC", Offset = "0x10B8FFC", VA = "0x10B8FFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F16")]
	private GameObject pnlDisableInput
	{
		[Token(Token = "0x6007A18")]
		[Address(RVA = "0x10B9108", Offset = "0x10B9108", VA = "0x10B9108")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F17")]
	private XPanel_Message messageWindow
	{
		[Token(Token = "0x6007A19")]
		[Address(RVA = "0x10B9208", Offset = "0x10B9208", VA = "0x10B9208")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F18")]
	private XUIConsoleWindow consoleWindow
	{
		[Token(Token = "0x6007A1A")]
		[Address(RVA = "0x10B9314", Offset = "0x10B9314", VA = "0x10B9314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F19")]
	private XPanel_NotiBox NotiBox
	{
		[Token(Token = "0x6007A1B")]
		[Address(RVA = "0x10B9420", Offset = "0x10B9420", VA = "0x10B9420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F1A")]
	private XPanel_QuestNotification pnlQuestNoti
	{
		[Token(Token = "0x6007A1C")]
		[Address(RVA = "0x10B952C", Offset = "0x10B952C", VA = "0x10B952C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F1B")]
	private XPanel_Broadcast pnlBroadcast
	{
		[Token(Token = "0x6007A1D")]
		[Address(RVA = "0x10B9638", Offset = "0x10B9638", VA = "0x10B9638")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A11")]
	[Address(RVA = "0x10B150C", Offset = "0x10B150C", VA = "0x10B150C")]
	public XUIMgr_Common()
	{
	}

	[Token(Token = "0x6007A12")]
	[Address(RVA = "0x10B8A6C", Offset = "0x10B8A6C", VA = "0x10B8A6C", Slot = "4")]
	public override string GetPrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6007A1E")]
	[Address(RVA = "0x10B9744", Offset = "0x10B9744", VA = "0x10B9744", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6007A1F")]
	[Address(RVA = "0x10B99DC", Offset = "0x10B99DC", VA = "0x10B99DC")]
	public void HideAll()
	{
	}

	[Token(Token = "0x6007A20")]
	[Address(RVA = "0x10B9EA4", Offset = "0x10B9EA4", VA = "0x10B9EA4")]
	public void OnFlowEnd()
	{
	}

	[Token(Token = "0x6007A21")]
	[Address(RVA = "0x10B9FEC", Offset = "0x10B9FEC", VA = "0x10B9FEC", Slot = "10")]
	public override void Update()
	{
	}

	[Token(Token = "0x6007A22")]
	[Address(RVA = "0x10BA16C", Offset = "0x10BA16C", VA = "0x10BA16C")]
	private void Update_ConsolewIndow()
	{
	}

	[Token(Token = "0x6007A23")]
	[Address(RVA = "0x10BA298", Offset = "0x10BA298", VA = "0x10BA298", Slot = "14")]
	public virtual ICommonBackableUI ShowInputBox(XUIMgrBase uiMgr, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] XUIInputBox.XInputBoxDelegate delegateOK, UIInput.KeyboardType keyboardType = UIInput.KeyboardType.Default, UIInput.Validation validation = UIInput.Validation.None, XUIInputBox.InputBoxType inputBoxType = XUIInputBox.InputBoxType.none)
	{
		return null;
	}

	[Token(Token = "0x6007A24")]
	[Address(RVA = "0x10B786C", Offset = "0x10B786C", VA = "0x10B786C")]
	public void ShowMessageBoxPrepareService()
	{
	}

	[Token(Token = "0x6007A25")]
	[Address(RVA = "0x10BA404", Offset = "0x10BA404", VA = "0x10BA404", Slot = "15")]
	public virtual IUIBackbutton ShowCoolDown(DateTime startDateTime, int coolSec, Action coolEndCallback, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional][DefaultParameterValue(false)] bool forceAlignmentLeft, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText)
	{
		return null;
	}

	[Token(Token = "0x6007A26")]
	[Address(RVA = "0x10BA560", Offset = "0x10BA560", VA = "0x10BA560", Slot = "16")]
	public virtual IUIBackbutton ShowMessageBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional][DefaultParameterValue(false)] bool forceAlignmentLeft, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText, int backgroundWidth = 606, int backgroundHeight = 406)
	{
		return null;
	}

	[Token(Token = "0x6007A27")]
	[Address(RVA = "0x10BA6A0", Offset = "0x10BA6A0", VA = "0x10BA6A0", Slot = "17")]
	public virtual IUIBackbutton ShowMessageBox(Currency costType, int cost, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional][DefaultParameterValue(false)] bool forceAlignmentLeft, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText, UIWidget.Pivot pivot = UIWidget.Pivot.Top)
	{
		return null;
	}

	[Token(Token = "0x6007A28")]
	[Address(RVA = "0x10BA7D0", Offset = "0x10BA7D0", VA = "0x10BA7D0", Slot = "18")]
	public virtual void ShowFlatMessageBox(string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText)
	{
	}

	[Token(Token = "0x6007A29")]
	[Address(RVA = "0x10BA8EC", Offset = "0x10BA8EC", VA = "0x10BA8EC", Slot = "19")]
	public virtual void ShowFlatMessageBox(Currency costType, int cost, string strTitle, string strMessage, XMessageBoxButtons nButtons, [Optional] Action delegateOK, [Optional] Action delegateCancle, [Optional] Action delegateLink, [Optional][DefaultParameterValue("")] string strLink, [Optional] string okText, [Optional] string cancleText, [Optional] string linkText)
	{
	}

	[Token(Token = "0x6007A2A")]
	[Address(RVA = "0x10BAA30", Offset = "0x10BAA30", VA = "0x10BAA30", Slot = "20")]
	public virtual void HideMessageBox(bool doEventHandler = false)
	{
	}

	[Token(Token = "0x6007A2B")]
	[Address(RVA = "0x10BAB44", Offset = "0x10BAB44", VA = "0x10BAB44", Slot = "21")]
	public virtual void SetMessageBoxBtnText()
	{
	}

	[Token(Token = "0x6007A2C")]
	[Address(RVA = "0x10BAC30", Offset = "0x10BAC30", VA = "0x10BAC30", Slot = "22")]
	public virtual void ShowNotification(string strMessage, float duration = 1f, float positionY = 0f)
	{
	}

	[Token(Token = "0x6007A2D")]
	[Address(RVA = "0x10BAC80", Offset = "0x10BAC80", VA = "0x10BAC80", Slot = "23")]
	public virtual void ShowNotification(string strMessage, Color color, float duration = 1f, float positionY = 0f)
	{
	}

	[Token(Token = "0x6007A2E")]
	[Address(RVA = "0x10BACF0", Offset = "0x10BACF0", VA = "0x10BACF0", Slot = "24")]
	public virtual void HideNotification()
	{
	}

	[Token(Token = "0x6007A2F")]
	[Address(RVA = "0x10BADCC", Offset = "0x10BADCC", VA = "0x10BADCC")]
	public void ShowMessageBottom(string text = "", float durationtime = 2f)
	{
	}

	[Token(Token = "0x6007A30")]
	[Address(RVA = "0x10BAE08", Offset = "0x10BAE08", VA = "0x10BAE08", Slot = "25")]
	public virtual void HideMessageWindow()
	{
	}

	[Token(Token = "0x6007A31")]
	[Address(RVA = "0x10BAEE4", Offset = "0x10BAEE4", VA = "0x10BAEE4", Slot = "26")]
	public virtual void ShowConsoleWindow(bool bShow)
	{
	}

	[Token(Token = "0x6007A32")]
	[Address(RVA = "0x10BAEE8", Offset = "0x10BAEE8", VA = "0x10BAEE8", Slot = "27")]
	public virtual void ToggleConsoleWindow()
	{
	}

	[Token(Token = "0x6007A33")]
	[Address(RVA = "0x109B280", Offset = "0x109B280", VA = "0x109B280")]
	public void ShowLoading(bool show, bool enableTimeOut = false)
	{
	}

	[Token(Token = "0x6007A34")]
	[Address(RVA = "0x10BAEEC", Offset = "0x10BAEEC", VA = "0x10BAEEC")]
	public void ShowLoading(bool show, float showLoadingTimeSec)
	{
	}

	[Token(Token = "0x6007A35")]
	[Address(RVA = "0x10BB040", Offset = "0x10BB040", VA = "0x10BB040", Slot = "28")]
	public virtual void ShowDisableInput(bool bShow)
	{
	}

	[Token(Token = "0x6007A36")]
	[Address(RVA = "0x10BB12C", Offset = "0x10BB12C", VA = "0x10BB12C", Slot = "29")]
	public virtual bool IsDisableInputVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A37")]
	[Address(RVA = "0x10BB224", Offset = "0x10BB224", VA = "0x10BB224", Slot = "30")]
	public virtual bool IsMessageBoxVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A38")]
	[Address(RVA = "0x10BB334", Offset = "0x10BB334", VA = "0x10BB334")]
	public bool BackUpdateCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A39")]
	[Address(RVA = "0x10BB378", Offset = "0x10BB378", VA = "0x10BB378")]
	public bool IsShowingPnl()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A3A")]
	[Address(RVA = "0x10BB3B4", Offset = "0x10BB3B4", VA = "0x10BB3B4")]
	public void ImmediatelyShowQuestCompleteNoti(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x6007A3B")]
	[Address(RVA = "0x10BB3E8", Offset = "0x10BB3E8", VA = "0x10BB3E8")]
	public void ImmediatelyShowTitleCompleteNoti(TitleInfo titleInfo)
	{
	}

	[Token(Token = "0x6007A3C")]
	[Address(RVA = "0x10BB41C", Offset = "0x10BB41C", VA = "0x10BB41C")]
	public void ReserveQuestCompleteNofi(QuestInfo questInfo)
	{
	}

	[Token(Token = "0x6007A3D")]
	[Address(RVA = "0x10BB450", Offset = "0x10BB450", VA = "0x10BB450")]
	public void ReserveTitleCompleteNofi(TitleInfo titleInfo)
	{
	}

	[Token(Token = "0x6007A3E")]
	[Address(RVA = "0x10AB4E4", Offset = "0x10AB4E4", VA = "0x10AB4E4")]
	public void ReserveInfoShowQuestCompleteNofi()
	{
	}

	[Token(Token = "0x6007A3F")]
	[Address(RVA = "0x10BB484", Offset = "0x10BB484", VA = "0x10BB484")]
	private void ShowNoticeBroadcast(ChatMessage message)
	{
	}

	[Token(Token = "0x6007A40")]
	[Address(RVA = "0x10BB5E4", Offset = "0x10BB5E4", VA = "0x10BB5E4")]
	private void ShowShowoffBroadcast(ChatMessage message)
	{
	}

	[Token(Token = "0x6007A41")]
	[Address(RVA = "0x10BB74C", Offset = "0x10BB74C", VA = "0x10BB74C")]
	private void ShowChatBroadcast(ChatMessage chatMsg)
	{
	}

	[Token(Token = "0x6007A42")]
	[Address(RVA = "0x10BBA4C", Offset = "0x10BBA4C", VA = "0x10BBA4C")]
	public void ShowChatMessageBroadcast(ChatMessage chatMsg)
	{
	}

	[Token(Token = "0x6007A43")]
	[Address(RVA = "0x10BBAC4", Offset = "0x10BBAC4", VA = "0x10BBAC4", Slot = "31")]
	public virtual void SetLadderChatClanWarButton(bool active)
	{
	}

	[Token(Token = "0x6007A44")]
	[Address(RVA = "0x10BBBC4", Offset = "0x10BBBC4", VA = "0x10BBBC4", Slot = "32")]
	public virtual void ChatWindowSlideIn()
	{
	}

	[Token(Token = "0x6007A45")]
	[Address(RVA = "0x10BBBF0", Offset = "0x10BBBF0", VA = "0x10BBBF0")]
	public void RegisterClanWarBtnToChat(Transform ParentTr, GameObject btnClanWar)
	{
	}

	[Token(Token = "0x6007A46")]
	[Address(RVA = "0x10BBC2C", Offset = "0x10BBC2C", VA = "0x10BBC2C")]
	public void MoveClanWarBtnToChat()
	{
	}

	[Token(Token = "0x6007A47")]
	[Address(RVA = "0x10BBC58", Offset = "0x10BBC58", VA = "0x10BBC58")]
	public void MoveClanWarBtnToClanMain()
	{
	}

	[Token(Token = "0x6007A48")]
	[Address(RVA = "0x10BBC84", Offset = "0x10BBC84", VA = "0x10BBC84")]
	public void ClanChatWindowSlideIn()
	{
	}

	[Token(Token = "0x6007A49")]
	[Address(RVA = "0x10BBA18", Offset = "0x10BBA18", VA = "0x10BBA18")]
	public bool IsChatWindowSlideIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A4A")]
	[Address(RVA = "0x10BBCB0", Offset = "0x10BBCB0", VA = "0x10BBCB0")]
	public void HideChatWindow()
	{
	}

	[Token(Token = "0x6007A4B")]
	[Address(RVA = "0x10BBCDC", Offset = "0x10BBCDC", VA = "0x10BBCDC")]
	public void OnChatReceiveMessage(ChannelState channelState)
	{
	}

	[Token(Token = "0x6007A4C")]
	[Address(RVA = "0x10BBDC8", Offset = "0x10BBDC8", VA = "0x10BBDC8")]
	public void SetClanInviteChatNew(bool isEnable)
	{
	}
}
