using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.Chat;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E7")]
public class XPhotonChatManager : IChatClientListener
{
	[Token(Token = "0x20003E8")]
	private sealed class _003CSubscribeOnConnected_003Ec__Iterator34 : IDisposable
	{
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x8")]
		internal float fDelay;

		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40013AF")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40013B0")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003EfDelay;

		[Token(Token = "0x40013B1")]
		[FieldOffset(Offset = "0x18")]
		internal XPhotonChatManager _003C_003Ef__this;

		[Token(Token = "0x1700056F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600201D")]
			[Address(RVA = "0xAE8194", Offset = "0xAE8194", VA = "0xAE8194", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000570")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600201E")]
			[Address(RVA = "0xAE819C", Offset = "0xAE819C", VA = "0xAE819C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600201C")]
		[Address(RVA = "0xAE3248", Offset = "0xAE3248", VA = "0xAE3248")]
		public _003CSubscribeOnConnected_003Ec__Iterator34()
		{
		}

		[Token(Token = "0x600201D")]
		[Address(RVA = "0xAE8194", Offset = "0xAE8194", VA = "0xAE8194", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600201E")]
		[Address(RVA = "0xAE819C", Offset = "0xAE819C", VA = "0xAE819C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600201F")]
		[Address(RVA = "0xAE81A4", Offset = "0xAE81A4", VA = "0xAE81A4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002020")]
		[Address(RVA = "0xAE8290", Offset = "0xAE8290", VA = "0xAE8290", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002021")]
		[Address(RVA = "0xAE829C", Offset = "0xAE829C", VA = "0xAE829C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20003E9")]
	private sealed class _003CInsertServerLoadChatMsg_003Ec__AnonStoreyEE
	{
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x8")]
		internal long firstSendTick;

		[Token(Token = "0x6002022")]
		[Address(RVA = "0xAE608C", Offset = "0xAE608C", VA = "0xAE608C")]
		public _003CInsertServerLoadChatMsg_003Ec__AnonStoreyEE()
		{
		}

		[Token(Token = "0x6002023")]
		[Address(RVA = "0xAE7F70", Offset = "0xAE7F70", VA = "0xAE7F70")]
		internal bool _003C_003Em__A6(ChatMessage x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003EA")]
	private sealed class _003COnSubscribedNormalChannel_003Ec__AnonStoreyEF
	{
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x8")]
		internal List<XPhotonChatDelayMsgCommand> liSendMsg;

		[Token(Token = "0x6002024")]
		[Address(RVA = "0xAE7000", Offset = "0xAE7000", VA = "0xAE7000")]
		public _003COnSubscribedNormalChannel_003Ec__AnonStoreyEF()
		{
		}

		[Token(Token = "0x6002025")]
		[Address(RVA = "0xAE80F4", Offset = "0xAE80F4", VA = "0xAE80F4")]
		internal bool _003C_003Em__A8(XPhotonChatDelayMsgCommand item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003EB")]
	private sealed class _003COnSubscribedClanChannel_003Ec__AnonStoreyF0
	{
		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0x8")]
		internal List<XPhotonChatDelayMsgCommand> liSendMsg;

		[Token(Token = "0x6002026")]
		[Address(RVA = "0xAE73BC", Offset = "0xAE73BC", VA = "0xAE73BC")]
		public _003COnSubscribedClanChannel_003Ec__AnonStoreyF0()
		{
		}

		[Token(Token = "0x6002027")]
		[Address(RVA = "0xAE7FB4", Offset = "0xAE7FB4", VA = "0xAE7FB4")]
		internal bool _003C_003Em__AA(XPhotonChatDelayMsgCommand item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003EC")]
	private sealed class _003COnSubscribedClanInviteChannel_003Ec__AnonStoreyF1
	{
		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x8")]
		internal List<XPhotonChatDelayMsgCommand> liSendMsg;

		[Token(Token = "0x6002028")]
		[Address(RVA = "0xAE7674", Offset = "0xAE7674", VA = "0xAE7674")]
		public _003COnSubscribedClanInviteChannel_003Ec__AnonStoreyF1()
		{
		}

		[Token(Token = "0x6002029")]
		[Address(RVA = "0xAE8054", Offset = "0xAE8054", VA = "0xAE8054")]
		internal bool _003C_003Em__AC(XPhotonChatDelayMsgCommand item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001396")]
	[FieldOffset(Offset = "0x8")]
	private ChatClient m_ChatClient;

	[Token(Token = "0x4001397")]
	[FieldOffset(Offset = "0xC")]
	private XPhotonChatChannelManager m_ChannelManager;

	[Token(Token = "0x4001398")]
	[FieldOffset(Offset = "0x10")]
	private Regulator m_ConnectionUpdater;

	[Token(Token = "0x4001399")]
	[FieldOffset(Offset = "0x14")]
	public List<ChatMessage> m_NormalMessages;

	[Token(Token = "0x400139A")]
	[FieldOffset(Offset = "0x18")]
	public List<ChatMessage> m_ClanMessages;

	[Token(Token = "0x400139B")]
	[FieldOffset(Offset = "0x1C")]
	public List<ChatMessage> m_WhisperMessages;

	[Token(Token = "0x400139C")]
	[FieldOffset(Offset = "0x20")]
	public List<ChatMessage> m_IngameMessages;

	[Token(Token = "0x400139D")]
	[FieldOffset(Offset = "0x24")]
	public List<XPhotonChatDelayMsgCommand> m_liDelayMsgCommand;

	[Token(Token = "0x400139E")]
	[FieldOffset(Offset = "0x28")]
	private ChannelState m_CurrentChannelState;

	[Token(Token = "0x400139F")]
	[FieldOffset(Offset = "0x2C")]
	private Action changingChannelAction;

	[Token(Token = "0x40013A0")]
	[FieldOffset(Offset = "0x30")]
	private int m_CurrentChannelID;

	[Token(Token = "0x40013A1")]
	[FieldOffset(Offset = "0x34")]
	private string m_CurrentLanguage;

	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0x38")]
	private string m_CurrentNormalChannelName;

	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CurrentClanChannelName;

	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x40")]
	private string m_CurrentClanInviteChannelName;

	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x44")]
	private GameFlowTypes m_CurrentGameFlowType;

	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x48")]
	private XChatExtraService m_ChatExtraService;

	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x4C")]
	private List<ChatMessage> m_clanServerMsg;

	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x50")]
	private bool m_resetClanFlag;

	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<long, List<ChatMessage>> m_clientClanInviteChatMessages;

	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XPhotonChatDelayMsgCommand, bool> _003C_003Ef__am_0024cache14;

	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XPhotonChatDelayMsgCommand, bool> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XPhotonChatDelayMsgCommand, bool> _003C_003Ef__am_0024cache16;

	[Token(Token = "0x17000568")]
	public int CurrentChannelID
	{
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0xAE16B0", Offset = "0xAE16B0", VA = "0xAE16B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000569")]
	public string CurrentLanguage
	{
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0xAE16B8", Offset = "0xAE16B8", VA = "0xAE16B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056A")]
	public ChatState ChatState
	{
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0xAE16C0", Offset = "0xAE16C0", VA = "0xAE16C0")]
		get
		{
			return default(ChatState);
		}
	}

	[Token(Token = "0x1700056B")]
	public string CurrentNormalChannel
	{
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0xAE16EC", Offset = "0xAE16EC", VA = "0xAE16EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056C")]
	public string CurrentClanChannel
	{
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0xAE16F4", Offset = "0xAE16F4", VA = "0xAE16F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056D")]
	public string CurrentClanInviteChannel
	{
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0xAE16FC", Offset = "0xAE16FC", VA = "0xAE16FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056E")]
	public Dictionary<long, List<ChatMessage>> ClientClanInviteChatMessages
	{
		[Token(Token = "0x600200B")]
		[Address(RVA = "0xAE6108", Offset = "0xAE6108", VA = "0xAE6108")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0xAE13FC", Offset = "0xAE13FC", VA = "0xAE13FC")]
	public XPhotonChatManager()
	{
	}

	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0xAE1704", Offset = "0xAE1704", VA = "0xAE1704")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0xAE1818", Offset = "0xAE1818", VA = "0xAE1818")]
	public void ClearIngameMessage()
	{
	}

	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0xAE18B0", Offset = "0xAE18B0", VA = "0xAE18B0")]
	public void Init()
	{
	}

	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0xAE18B4", Offset = "0xAE18B4", VA = "0xAE18B4")]
	private void UpdateKeepConnection()
	{
	}

	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0xAE1920", Offset = "0xAE1920", VA = "0xAE1920")]
	private void Reconnect()
	{
	}

	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0xAE1CE0", Offset = "0xAE1CE0", VA = "0xAE1CE0")]
	public void Update()
	{
	}

	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0xAE1D14", Offset = "0xAE1D14", VA = "0xAE1D14")]
	public void OnChangeFlow(GameFlowTypes type)
	{
	}

	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0xAE1D80", Offset = "0xAE1D80", VA = "0xAE1D80")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0xAE1D24", Offset = "0xAE1D24", VA = "0xAE1D24")]
	private void DisconnectOnTitle()
	{
	}

	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0xAE1DE4", Offset = "0xAE1DE4", VA = "0xAE1DE4")]
	protected string GetRegionToken(ConnectEnum.RegionType regionType)
	{
		return null;
	}

	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0xAE1AD4", Offset = "0xAE1AD4", VA = "0xAE1AD4")]
	public void Connect(string strUserName, ConnectEnum.RegionType regionType)
	{
	}

	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0xAE1E8C", Offset = "0xAE1E8C", VA = "0xAE1E8C")]
	protected string GetAppID(ConnectEnum.RegionType regionType, ConnectEnum.ServerType serverType)
	{
		return null;
	}

	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0xAE1DB8", Offset = "0xAE1DB8", VA = "0xAE1DB8")]
	public void Disconnect()
	{
	}

	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0xAE20B4", Offset = "0xAE20B4", VA = "0xAE20B4")]
	private void Subscribe(string channelName, int msgFromHistory = 0)
	{
	}

	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0xAE21B4", Offset = "0xAE21B4", VA = "0xAE21B4")]
	private void Subscribe(string[] channels, int msgFromHistory = 0)
	{
	}

	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0xAE21E0", Offset = "0xAE21E0", VA = "0xAE21E0")]
	private void Unsubscribe(string channelName)
	{
	}

	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0xAE22D8", Offset = "0xAE22D8", VA = "0xAE22D8")]
	private bool Unsubscribe(string[] channels)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0xAE2304", Offset = "0xAE2304", VA = "0xAE2304")]
	public void SubscribeClanChannel()
	{
	}

	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0xAE2494", Offset = "0xAE2494", VA = "0xAE2494")]
	private void SubscribeClanChannel(string clanId)
	{
	}

	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0xAE2498", Offset = "0xAE2498", VA = "0xAE2498")]
	private void ReqServerClanMsg(string clanId)
	{
	}

	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0xAE26BC", Offset = "0xAE26BC", VA = "0xAE26BC")]
	private void LoadFromServer(List<CSChattingMessage> liMsg)
	{
	}

	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0xAE2800", Offset = "0xAE2800", VA = "0xAE2800")]
	private void SubScribeClan()
	{
	}

	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0xAE2A74", Offset = "0xAE2A74", VA = "0xAE2A74")]
	private void ConvertToClanMsg(List<CSChattingMessage> liMsg)
	{
	}

	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0xAE2FA8", Offset = "0xAE2FA8", VA = "0xAE2FA8")]
	private void AddLoadToClanMsg(PhotonChatMessage msg)
	{
	}

	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0xAE307C", Offset = "0xAE307C", VA = "0xAE307C")]
	public void UnsubscribeClanChannel()
	{
	}

	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0xAE3194", Offset = "0xAE3194", VA = "0xAE3194")]
	[DebuggerHidden]
	private IEnumerator SubscribeOnConnected(float fDelay)
	{
		return null;
	}

	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0xAE3250", Offset = "0xAE3250", VA = "0xAE3250")]
	private void SubscribeNormalChannel(string changeLang, int changeChannelID)
	{
	}

	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0xAE34F4", Offset = "0xAE34F4", VA = "0xAE34F4")]
	private void SubscribeDefaultChannels()
	{
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0xAE23C8", Offset = "0xAE23C8", VA = "0xAE23C8")]
	private string GetMyClanId()
	{
		return null;
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0xAE35EC", Offset = "0xAE35EC", VA = "0xAE35EC")]
	public void SendPrivateMessage(string target, string strMessage, object chatObject)
	{
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0xAE37AC", Offset = "0xAE37AC", VA = "0xAE37AC")]
	private XChatMessageObject DeserializeChatObj(XChatObject chatObj, out XChatMsgType msgType)
	{
		msgType = default;
		return null;
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0xAE390C", Offset = "0xAE390C", VA = "0xAE390C")]
	private XChatMessageObject MakeIgnoreClientChatMessageObject(ref XChatMsgType msgType)
	{
		return null;
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0xAE39D8", Offset = "0xAE39D8", VA = "0xAE39D8")]
	private string MakeChatMessageHeader(XChatMsgType msgType)
	{
		return null;
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0xAE3A6C", Offset = "0xAE3A6C", VA = "0xAE3A6C")]
	private void _SendMessage(XChatMsgType msgType, string strMessage, string strOriginMessage, object chatParams, ChannelState _ChannelState)
	{
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0xAE40D4", Offset = "0xAE40D4", VA = "0xAE40D4")]
	public void SendMessage(XChatMsgType msgType, string strMessage, string strOriginMessage, object chatParams)
	{
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0xAE40FC", Offset = "0xAE40FC", VA = "0xAE40FC")]
	public void SendMessage(XChatMsgType msgType, string strMessage, string strOriginMessage, object chatParams, ChannelState _channelState)
	{
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0xAE4240", Offset = "0xAE4240", VA = "0xAE4240")]
	public void AddChatMessage(PhotonChatMessage msg)
	{
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0xAE4504", Offset = "0xAE4504", VA = "0xAE4504")]
	public void SendInviteMessage(string sender, string receiver, string message)
	{
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0xAE4604", Offset = "0xAE4604", VA = "0xAE4604")]
	private InviteMessageCommand CreateInviteMessageCommand(string sender, string receiver, string message)
	{
		return null;
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0xAE46B8", Offset = "0xAE46B8", VA = "0xAE46B8")]
	private ChannelState GetChannelState(string channelName)
	{
		return default(ChannelState);
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0xAE46E0", Offset = "0xAE46E0", VA = "0xAE46E0")]
	public void ChangeChannelState(ChannelState channelState)
	{
	}

	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0xAE46F0", Offset = "0xAE46F0", VA = "0xAE46F0")]
	internal void ChangeNormalChannel(string changeLang, int changeChannelID, Action changingChannel)
	{
	}

	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0xAE47F8", Offset = "0xAE47F8", VA = "0xAE47F8")]
	private bool IsEqualLangChannel(string changeLang, int changeChannelID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0xAE33B4", Offset = "0xAE33B4", VA = "0xAE33B4")]
	private void SwitchNormalChannel(string channelName)
	{
	}

	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0xAE48D0", Offset = "0xAE48D0", VA = "0xAE48D0")]
	public bool IsCurrentChannel(string changeLang, int changeChannelID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0xAE4A7C", Offset = "0xAE4A7C", VA = "0xAE4A7C")]
	internal void ClanLeave()
	{
	}

	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0xAE4B1C", Offset = "0xAE4B1C", VA = "0xAE4B1C")]
	public void CreateClanChannel()
	{
	}

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0xAE3F9C", Offset = "0xAE3F9C", VA = "0xAE3F9C")]
	private void WriteToServer(string _CurrentClanChannelName, XChatObject chatObj)
	{
	}

	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0xAE4C48", Offset = "0xAE4C48", VA = "0xAE4C48", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x6002000")]
	[Address(RVA = "0xAE4E38", Offset = "0xAE4E38", VA = "0xAE4E38", Slot = "5")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x6002001")]
	[Address(RVA = "0xAE4EF4", Offset = "0xAE4EF4", VA = "0xAE4EF4", Slot = "6")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x6002002")]
	[Address(RVA = "0xAE4FF8", Offset = "0xAE4FF8", VA = "0xAE4FF8", Slot = "7")]
	public void OnChatStateChange(ChatState state)
	{
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0xAE4FFC", Offset = "0xAE4FFC", VA = "0xAE4FFC", Slot = "8")]
	public void OnGetMessages(string channelName, string[] senders, object[] messages)
	{
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0xAE5950", Offset = "0xAE5950", VA = "0xAE5950")]
	private bool CheckClanChatAble()
	{
		return default(bool);
	}

	[Token(Token = "0x6002005")]
	[Address(RVA = "0xAE5CC8", Offset = "0xAE5CC8", VA = "0xAE5CC8")]
	private void InsertServerLoadChatMsg()
	{
	}

	[Token(Token = "0x6002006")]
	[Address(RVA = "0xAE6094", Offset = "0xAE6094", VA = "0xAE6094")]
	private static bool FindFirstClanChatMsg(ChatMessage msg)
	{
		return default(bool);
	}

	[Token(Token = "0x6002007")]
	[Address(RVA = "0xAE60C8", Offset = "0xAE60C8", VA = "0xAE60C8")]
	private static bool RemoveServerClanChatMsg(ChatMessage msg, long firstSendTick)
	{
		return default(bool);
	}

	[Token(Token = "0x6002008")]
	[Address(RVA = "0xAD2CE0", Offset = "0xAD2CE0", VA = "0xAD2CE0")]
	public int GetClanWarPartyMsgCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002009")]
	[Address(RVA = "0xAE5F50", Offset = "0xAE5F50", VA = "0xAE5F50")]
	private void SetMsgNew(PhotonChatMessage msg)
	{
	}

	[Token(Token = "0x600200A")]
	[Address(RVA = "0xAE6110", Offset = "0xAE6110", VA = "0xAE6110")]
	public void AddBroadcastMessage(XChatMsgType msgType, string strMsg, Color color)
	{
	}

	[Token(Token = "0x600200C")]
	[Address(RVA = "0xAE2CFC", Offset = "0xAE2CFC", VA = "0xAE2CFC")]
	private void AddChatMessageForClanMsg(ChannelState eChannelState, string sender, XChatObject chatObj, bool loadToServer = false)
	{
	}

	[Token(Token = "0x600200D")]
	[Address(RVA = "0xAE631C", Offset = "0xAE631C", VA = "0xAE631C")]
	private string GetAbuseFiltering(string val)
	{
		return null;
	}

	[Token(Token = "0x600200E")]
	[Address(RVA = "0xAE6424", Offset = "0xAE6424", VA = "0xAE6424")]
	private void FilterClanInviteMsgToDic(PhotonChatMessage msg)
	{
	}

	[Token(Token = "0x600200F")]
	[Address(RVA = "0xAE5A1C", Offset = "0xAE5A1C", VA = "0xAE5A1C")]
	private void CheckClanInviteMsgNewCheckAll()
	{
	}

	[Token(Token = "0x6002010")]
	[Address(RVA = "0xAE6810", Offset = "0xAE6810", VA = "0xAE6810", Slot = "9")]
	public void OnPrivateMessage(string sender, object message, string channelName)
	{
	}

	[Token(Token = "0x6002011")]
	[Address(RVA = "0xAE6BFC", Offset = "0xAE6BFC", VA = "0xAE6BFC")]
	private void OnSubscribedNormalChannel(string channelName)
	{
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0xAE70EC", Offset = "0xAE70EC", VA = "0xAE70EC")]
	private void OnSubscribedClanChannel(string channelName)
	{
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0xAE73C4", Offset = "0xAE73C4", VA = "0xAE73C4")]
	private void OnSubscribedClanInviteChannel(string channelName)
	{
	}

	[Token(Token = "0x6002014")]
	[Address(RVA = "0xAE7008", Offset = "0xAE7008", VA = "0xAE7008")]
	private void SendDelayMessage(List<XPhotonChatDelayMsgCommand> liSendMsg)
	{
	}

	[Token(Token = "0x6002015")]
	[Address(RVA = "0xAE767C", Offset = "0xAE767C", VA = "0xAE767C")]
	private void SendMessage(XPhotonChatDelayMsgCommand delayMsgCommand)
	{
	}

	[Token(Token = "0x6002016")]
	[Address(RVA = "0xAE76C4", Offset = "0xAE76C4", VA = "0xAE76C4", Slot = "10")]
	public void OnSubscribed(string[] channels, bool[] results)
	{
	}

	[Token(Token = "0x6002017")]
	[Address(RVA = "0xAE7A34", Offset = "0xAE7A34", VA = "0xAE7A34", Slot = "11")]
	public void OnUnsubscribed(string[] channels)
	{
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0xAE7EBC", Offset = "0xAE7EBC", VA = "0xAE7EBC", Slot = "12")]
	public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0xAE7EC0", Offset = "0xAE7EC0", VA = "0xAE7EC0")]
	private static bool _003COnSubscribedNormalChannel_003Em__A7(XPhotonChatDelayMsgCommand item)
	{
		return default(bool);
	}

	[Token(Token = "0x600201A")]
	[Address(RVA = "0xAE7EF0", Offset = "0xAE7EF0", VA = "0xAE7EF0")]
	private static bool _003COnSubscribedClanChannel_003Em__A9(XPhotonChatDelayMsgCommand item)
	{
		return default(bool);
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0xAE7F30", Offset = "0xAE7F30", VA = "0xAE7F30")]
	private static bool _003COnSubscribedClanInviteChannel_003Em__AB(XPhotonChatDelayMsgCommand item)
	{
		return default(bool);
	}
}
