using System;
using Il2CppDummyDll;

[Token(Token = "0x2000366")]
public class XAdvertisingAdColony : XAdvertisingBase
{
	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x24")]
	private string m_adColonyVersion;

	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x28")]
	private bool m_isReady;

	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x17B968C", Offset = "0x17B968C", VA = "0x17B968C")]
	public XAdvertisingAdColony()
	{
	}

	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x17B9750", Offset = "0x17B9750", VA = "0x17B9750", Slot = "5")]
	public override void OnInit(bool isDev, Action showFinishedAction)
	{
	}

	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x17B9C30", Offset = "0x17B9C30", VA = "0x17B9C30", Slot = "6")]
	public override bool OnIsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x17B9CDC", Offset = "0x17B9CDC", VA = "0x17B9CDC", Slot = "7")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x17B9D88", Offset = "0x17B9D88", VA = "0x17B9D88", Slot = "8")]
	public override void OnFinished()
	{
	}

	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x17B9D9C", Offset = "0x17B9D9C", VA = "0x17B9D9C")]
	private void OnVideoStarted()
	{
	}

	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x17B9DA0", Offset = "0x17B9DA0", VA = "0x17B9DA0")]
	private void OnVideoFinished(bool adWasShown)
	{
	}
}
