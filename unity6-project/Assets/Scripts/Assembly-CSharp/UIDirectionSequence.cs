using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000CE6")]
public class UIDirectionSequence : Queue<UIDirectionElement>, UIDirectionElement
{
	[Token(Token = "0x40041BA")]
	[FieldOffset(Offset = "0x1C")]
	private UIDirectionElement curElement;

	[Token(Token = "0x40041BB")]
	[FieldOffset(Offset = "0x20")]
	private bool isFinished;

	[Token(Token = "0x40041BC")]
	[FieldOffset(Offset = "0x21")]
	private bool main;

	[Token(Token = "0x6005D1A")]
	[Address(RVA = "0x16DDA34", Offset = "0x16DDA34", VA = "0x16DDA34")]
	public UIDirectionSequence(bool main = false)
	{
	}

	[Token(Token = "0x6005D1B")]
	[Address(RVA = "0x16DDAC0", Offset = "0x16DDAC0", VA = "0x16DDAC0", Slot = "10")]
	public void Start()
	{
	}

	[Token(Token = "0x6005D1C")]
	[Address(RVA = "0x16DDAC4", Offset = "0x16DDAC4", VA = "0x16DDAC4")]
	private void Pop()
	{
	}

	[Token(Token = "0x6005D1D")]
	[Address(RVA = "0x16DDC24", Offset = "0x16DDC24", VA = "0x16DDC24", Slot = "11")]
	public void Update()
	{
	}

	[Token(Token = "0x6005D1E")]
	[Address(RVA = "0x16DDE08", Offset = "0x16DDE08", VA = "0x16DDE08", Slot = "13")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005D1F")]
	[Address(RVA = "0x16DE000", Offset = "0x16DE000", VA = "0x16DE000", Slot = "12")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
