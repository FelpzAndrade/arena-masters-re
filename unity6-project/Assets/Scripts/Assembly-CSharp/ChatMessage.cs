using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004CA")]
public class ChatMessage
{
	[Token(Token = "0x20004CB")]
	public enum SenderType
	{
		[Token(Token = "0x4001830")]
		System = 0,
		[Token(Token = "0x4001831")]
		BroadCast = 1,
		[Token(Token = "0x4001832")]
		Normal = 2
	}

	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x8")]
	protected XChatMsgType m_msgType;

	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0xC")]
	protected SenderType m_SenderType;

	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x10")]
	protected int m_profileIconId;

	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0x14")]
	protected int m_titleId;

	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0x18")]
	protected string m_sender;

	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0x1C")]
	protected string m_message;

	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0x20")]
	protected Color m_msgColor;

	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0x30")]
	public long SendTimeTick;

	[Token(Token = "0x17000670")]
	public virtual string Sender
	{
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x20C549C", Offset = "0x20C549C", VA = "0x20C549C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000671")]
	public virtual string Message
	{
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x20C54A4", Offset = "0x20C54A4", VA = "0x20C54A4", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000672")]
	public virtual int ProfileIconId
	{
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x20C54AC", Offset = "0x20C54AC", VA = "0x20C54AC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000673")]
	public virtual int TitleId
	{
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x20C54B4", Offset = "0x20C54B4", VA = "0x20C54B4", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000674")]
	public bool IsMine
	{
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x20C54BC", Offset = "0x20C54BC", VA = "0x20C54BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000675")]
	public bool FromSystem
	{
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x20C55F0", Offset = "0x20C55F0", VA = "0x20C55F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000676")]
	public XChatMsgType ChatMessageType
	{
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x20C5604", Offset = "0x20C5604", VA = "0x20C5604")]
		get
		{
			return default(XChatMsgType);
		}
	}

	[Token(Token = "0x17000677")]
	public Color MessageColor
	{
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x20C560C", Offset = "0x20C560C", VA = "0x20C560C")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000678")]
	public XUIChatGround.XUIChatMessageType UIChatMessageType
	{
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x20C561C", Offset = "0x20C561C", VA = "0x20C561C")]
		get
		{
			return default(XUIChatGround.XUIChatMessageType);
		}
	}

	[Token(Token = "0x6002921")]
	[Address(RVA = "0x20C53C4", Offset = "0x20C53C4", VA = "0x20C53C4")]
	public ChatMessage()
	{
	}

	[Token(Token = "0x6002922")]
	[Address(RVA = "0x20C541C", Offset = "0x20C541C", VA = "0x20C541C")]
	public ChatMessage(XChatMsgType msgType, int profileIconId, int titleId, string sender, string message)
	{
	}

	[Token(Token = "0x600292C")]
	[Address(RVA = "0x20C564C", Offset = "0x20C564C", VA = "0x20C564C")]
	public void IgnoreChatInClient()
	{
	}
}
