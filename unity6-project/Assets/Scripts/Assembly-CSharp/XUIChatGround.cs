using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C37")]
public class XUIChatGround : MonoBehaviour
{
	[Token(Token = "0x2000C38")]
	public enum XUIChatMessageType
	{
		[Token(Token = "0x4003DC8")]
		Normal = 0,
		[Token(Token = "0x4003DC9")]
		ClanInvite = 1,
		[Token(Token = "0x4003DCA")]
		Showoff = 2,
		[Token(Token = "0x4003DCB")]
		Notify = 3
	}

	[Token(Token = "0x2000C39")]
	private sealed class _003CRefreshClanInViteMsg_003Ec__AnonStorey179
	{
		[Token(Token = "0x4003DCC")]
		[FieldOffset(Offset = "0x8")]
		internal long partyID;

		[Token(Token = "0x6005859")]
		[Address(RVA = "0x1A33A24", Offset = "0x1A33A24", VA = "0x1A33A24")]
		public _003CRefreshClanInViteMsg_003Ec__AnonStorey179()
		{
		}

		[Token(Token = "0x600585A")]
		[Address(RVA = "0x1A341C0", Offset = "0x1A341C0", VA = "0x1A341C0")]
		internal bool _003C_003Em__24B(XUIChatMessageBase uiObj)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003DB9")]
	private const int m_messageMax = 100;

	[Token(Token = "0x4003DBA")]
	[FieldOffset(Offset = "0xC")]
	private List<string> pathList;

	[Token(Token = "0x4003DBB")]
	[FieldOffset(Offset = "0x10")]
	private List<GameObject> m_cloneSrcList;

	[Token(Token = "0x4003DBC")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel clippedView;

	[Token(Token = "0x4003DBD")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView scrollView;

	[Token(Token = "0x4003DBE")]
	[FieldOffset(Offset = "0x1C")]
	public Transform pool;

	[Token(Token = "0x4003DBF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblNoChatting;

	[Token(Token = "0x4003DC0")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<XUIChatMessageType, List<XUIChatMessageBase>> used;

	[Token(Token = "0x4003DC1")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<XUIChatMessageType, List<XUIChatMessageBase>> unused;

	[Token(Token = "0x4003DC2")]
	[FieldOffset(Offset = "0x2C")]
	private float m_addPosY;

	[Token(Token = "0x4003DC3")]
	[FieldOffset(Offset = "0x30")]
	private List<ChatMessage> m_messages;

	[Token(Token = "0x4003DC4")]
	[FieldOffset(Offset = "0x34")]
	private Action<EventDelegate> m_infoAction;

	[Token(Token = "0x4003DC5")]
	[FieldOffset(Offset = "0x38")]
	private XUIChatMessageBase m_lastUIMsg;

	[Token(Token = "0x4003DC6")]
	[FieldOffset(Offset = "0x3C")]
	private XUIChatMessageBase m_newUIMsg;

	[Token(Token = "0x6005847")]
	[Address(RVA = "0x1A32170", Offset = "0x1A32170", VA = "0x1A32170")]
	public XUIChatGround()
	{
	}

	[Token(Token = "0x6005848")]
	[Address(RVA = "0x1A3236C", Offset = "0x1A3236C", VA = "0x1A3236C")]
	public void Build(List<ChatMessage> messages, Action<EventDelegate> infoAction)
	{
	}

	[Token(Token = "0x6005849")]
	[Address(RVA = "0x1A3256C", Offset = "0x1A3256C", VA = "0x1A3256C")]
	public void RefreshMessages(List<ChatMessage> messages)
	{
	}

	[Token(Token = "0x600584A")]
	[Address(RVA = "0x1A32640", Offset = "0x1A32640", VA = "0x1A32640")]
	public void RefreshUIChatMsg(XUIChatMessageType type)
	{
	}

	[Token(Token = "0x600584B")]
	[Address(RVA = "0x1A32458", Offset = "0x1A32458", VA = "0x1A32458")]
	private void Build()
	{
	}

	[Token(Token = "0x600584C")]
	[Address(RVA = "0x1A32820", Offset = "0x1A32820", VA = "0x1A32820")]
	private void CreatePrefabs()
	{
	}

	[Token(Token = "0x600584D")]
	[Address(RVA = "0x1A33164", Offset = "0x1A33164", VA = "0x1A33164")]
	public void MoveToBoundary(bool spring)
	{
	}

	[Token(Token = "0x600584E")]
	[Address(RVA = "0x1A33284", Offset = "0x1A33284", VA = "0x1A33284")]
	public void AddMessage(ChatMessage msg)
	{
	}

	[Token(Token = "0x600584F")]
	[Address(RVA = "0x1A32FAC", Offset = "0x1A32FAC", VA = "0x1A32FAC")]
	private void ParserMsgBuilder(ChatMessage msg)
	{
	}

	[Token(Token = "0x6005850")]
	[Address(RVA = "0x1A337A0", Offset = "0x1A337A0", VA = "0x1A337A0")]
	private bool RefreshClanInViteMsg(ChatMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6005851")]
	[Address(RVA = "0x1A33B50", Offset = "0x1A33B50", VA = "0x1A33B50")]
	private static bool ComparePartyID(XUIChatMessageBase ui, long partyID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005852")]
	[Address(RVA = "0x1A336B4", Offset = "0x1A336B4", VA = "0x1A336B4")]
	private void BuildMessage(ChatMessage msg)
	{
	}

	[Token(Token = "0x6005853")]
	[Address(RVA = "0x1A3302C", Offset = "0x1A3302C", VA = "0x1A3302C")]
	private void SetNoChattingLabel()
	{
	}

	[Token(Token = "0x6005854")]
	[Address(RVA = "0x1A33490", Offset = "0x1A33490", VA = "0x1A33490")]
	private bool IsLastMessageOutOfPanel()
	{
		return default(bool);
	}

	[Token(Token = "0x6005855")]
	[Address(RVA = "0x1A32B78", Offset = "0x1A32B78", VA = "0x1A32B78")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005856")]
	[Address(RVA = "0x1A33C28", Offset = "0x1A33C28", VA = "0x1A33C28")]
	private XUIChatMessageBase GetClone(XUIChatMessageType type)
	{
		return null;
	}

	[Token(Token = "0x6005857")]
	[Address(RVA = "0x1A33458", Offset = "0x1A33458", VA = "0x1A33458")]
	private void GetDicList(XUIChatMessageType type, ref List<XUIChatMessageBase> unusedList, ref List<XUIChatMessageBase> usedList)
	{
	}

	[Token(Token = "0x6005858")]
	[Address(RVA = "0x1A33A2C", Offset = "0x1A33A2C", VA = "0x1A33A2C")]
	private List<XUIChatMessageBase> GetListFromDictionary(XUIChatMessageType type, Dictionary<XUIChatMessageType, List<XUIChatMessageBase>> dic)
	{
		return null;
	}
}
