using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3A")]
public class XUIChatMessageBase : MonoBehaviour
{
	[Token(Token = "0x4003DCD")]
	[FieldOffset(Offset = "0xC")]
	private int m_height;

	[Token(Token = "0x4003DCE")]
	[FieldOffset(Offset = "0x10")]
	private UIWidget m_widget;

	[Token(Token = "0x4003DCF")]
	[FieldOffset(Offset = "0x14")]
	protected ChatMessage m_chatMessage;

	[Token(Token = "0x17000CAF")]
	public int Height
	{
		[Token(Token = "0x600585C")]
		[Address(RVA = "0x1A33ECC", Offset = "0x1A33ECC", VA = "0x1A33ECC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600585B")]
	[Address(RVA = "0x1A31978", Offset = "0x1A31978", VA = "0x1A31978")]
	public XUIChatMessageBase()
	{
	}

	[Token(Token = "0x600585D")]
	[Address(RVA = "0x1A33FDC", Offset = "0x1A33FDC", VA = "0x1A33FDC")]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600585E")]
	[Address(RVA = "0x1A319C4", Offset = "0x1A319C4", VA = "0x1A319C4", Slot = "4")]
	public virtual void Build(ChatMessage msg, Action<EventDelegate> infoAction)
	{
	}

	[Token(Token = "0x600585F")]
	[Address(RVA = "0x1A34E5C", Offset = "0x1A34E5C", VA = "0x1A34E5C", Slot = "5")]
	public virtual void RefreshUI()
	{
	}

	[Token(Token = "0x6005860")]
	[Address(RVA = "0x1A34E60", Offset = "0x1A34E60", VA = "0x1A34E60", Slot = "6")]
	public virtual void InitBuilder()
	{
	}
}
