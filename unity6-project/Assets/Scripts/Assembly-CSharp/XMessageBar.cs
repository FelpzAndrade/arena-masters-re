using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000CED")]
public class XMessageBar
{
	[Token(Token = "0x40041E9")]
	[FieldOffset(Offset = "0x8")]
	public List<XMessageBarNode> m_StringArrayList;

	[Token(Token = "0x40041EA")]
	[FieldOffset(Offset = "0xC")]
	private float m_fElapsedTime;

	[Token(Token = "0x40041EB")]
	[FieldOffset(Offset = "0x10")]
	private float m_fMessageTime;

	[Token(Token = "0x40041EC")]
	[FieldOffset(Offset = "0x14")]
	public int maxStringArrayCount;

	[Token(Token = "0x6005D52")]
	[Address(RVA = "0x1E30D70", Offset = "0x1E30D70", VA = "0x1E30D70")]
	public XMessageBar()
	{
	}

	[Token(Token = "0x6005D53")]
	[Address(RVA = "0x1E30E30", Offset = "0x1E30E30", VA = "0x1E30E30")]
	public void SetMaxStringArrayCount(int maxStringArrayCount)
	{
	}

	[Token(Token = "0x6005D54")]
	[Address(RVA = "0x1E30E38", Offset = "0x1E30E38", VA = "0x1E30E38")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D55")]
	[Address(RVA = "0x1E30FF4", Offset = "0x1E30FF4", VA = "0x1E30FF4")]
	public void PushMessage(XChatMsgType msgType, string strName, string strText, bool bMyKill = false)
	{
	}

	[Token(Token = "0x6005D56")]
	[Address(RVA = "0x1E31360", Offset = "0x1E31360", VA = "0x1E31360")]
	public string GetTopMessage()
	{
		return null;
	}

	[Token(Token = "0x6005D57")]
	[Address(RVA = "0x1E30F1C", Offset = "0x1E30F1C", VA = "0x1E30F1C")]
	private void PopMessage()
	{
	}
}
