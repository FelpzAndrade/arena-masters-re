using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004CC")]
public class PhotonChatMessage : ChatMessage
{
	[Token(Token = "0x4001833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string m_Sender;

	[Token(Token = "0x4001834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XChatMessageObject m_msg;

	[Token(Token = "0x4001835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ChannelState m_eChannelType;

	[Token(Token = "0x17000679")]
	public ChannelState ChannelType
	{
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x1B83EE0", Offset = "0x1B83EE0", VA = "0x1B83EE0")]
		get
		{
			return default(ChannelState);
		}
	}

	[Token(Token = "0x600292D")]
	[Address(RVA = "0x1B83D94", Offset = "0x1B83D94", VA = "0x1B83D94")]
	public PhotonChatMessage(XChatMsgType msgType, string strSender, XChatMessageObject msg, ChannelState _eChannelState, [Optional] Color? color)
	{
	}

	[Token(Token = "0x600292F")]
	public T GetChatMsgObj<T>() where T : XChatMessageObject
	{
		return null;
	}
}
