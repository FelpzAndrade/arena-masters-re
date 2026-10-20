using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000CE7")]
public class UIDirectionPararell : List<UIDirectionElement>, UIDirectionElement
{
	[Token(Token = "0x40041BD")]
	[FieldOffset(Offset = "0x14")]
	private bool isStarted;

	[Token(Token = "0x40041BE")]
	[FieldOffset(Offset = "0x18")]
	private List<UIDirectionElement> removeList;

	[Token(Token = "0x17000CEF")]
	public bool IsStarted
	{
		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x16DD7F8", Offset = "0x16DD7F8", VA = "0x16DD7F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005D20")]
	[Address(RVA = "0x16DD194", Offset = "0x16DD194", VA = "0x16DD194")]
	public UIDirectionPararell()
	{
	}

	[Token(Token = "0x6005D21")]
	[Address(RVA = "0x16DD270", Offset = "0x16DD270", VA = "0x16DD270", Slot = "33")]
	public void Start()
	{
	}

	[Token(Token = "0x6005D22")]
	[Address(RVA = "0x16DD418", Offset = "0x16DD418", VA = "0x16DD418")]
	public void Reset()
	{
	}

	[Token(Token = "0x6005D23")]
	[Address(RVA = "0x16DD4A4", Offset = "0x16DD4A4", VA = "0x16DD4A4", Slot = "34")]
	public void Update()
	{
	}

	[Token(Token = "0x6005D24")]
	[Address(RVA = "0x16DD800", Offset = "0x16DD800", VA = "0x16DD800", Slot = "36")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005D26")]
	[Address(RVA = "0x16DD9A0", Offset = "0x16DD9A0", VA = "0x16DD9A0", Slot = "35")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
