using System;
using Il2CppDummyDll;

[Token(Token = "0x2000C34")]
public class XUIChatBroadcastShowoffMessage : XUIChatMessageBase
{
	[Token(Token = "0x4003DAC")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_BroadcastMsg msgUI;

	[Token(Token = "0x600583C")]
	[Address(RVA = "0x1A31A00", Offset = "0x1A31A00", VA = "0x1A31A00")]
	public XUIChatBroadcastShowoffMessage()
	{
	}

	[Token(Token = "0x600583D")]
	[Address(RVA = "0x1A31A10", Offset = "0x1A31A10", VA = "0x1A31A10", Slot = "4")]
	public override void Build(ChatMessage msg, Action<EventDelegate> infoAction)
	{
	}
}
