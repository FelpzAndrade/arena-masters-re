using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000CE3")]
public class XProgressBarWithTableDirectionElement : UIDirectionElement
{
	[Token(Token = "0x40041AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private XWidget_ProgressBarWithTable prb;

	[Token(Token = "0x40041AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private int targetValue;

	[Token(Token = "0x6005D09")]
	[Address(RVA = "0x1C858F8", Offset = "0x1C858F8", VA = "0x1C858F8")]
	public XProgressBarWithTableDirectionElement(XWidget_ProgressBarWithTable prb, int targetVal, [Optional] Action action)
	{
	}

	[Token(Token = "0x6005D0A")]
	[Address(RVA = "0x1C85948", Offset = "0x1C85948", VA = "0x1C85948", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x6005D0B")]
	[Address(RVA = "0x1C85980", Offset = "0x1C85980", VA = "0x1C85980", Slot = "5")]
	public void Update()
	{
	}

	[Token(Token = "0x6005D0C")]
	[Address(RVA = "0x1C859B0", Offset = "0x1C859B0", VA = "0x1C859B0", Slot = "7")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005D0D")]
	[Address(RVA = "0x1C85984", Offset = "0x1C85984", VA = "0x1C85984", Slot = "6")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
