using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200081D")]
public class XNetProcess_GetEventModeFirstReward : XNetProcess_GameBase
{
	[Token(Token = "0x1700090F")]
	public override string Name
	{
		[Token(Token = "0x60040E0")]
		[Address(RVA = "0x213C994", Offset = "0x213C994", VA = "0x213C994", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040DD")]
	[Address(RVA = "0x213C7AC", Offset = "0x213C7AC", VA = "0x213C7AC")]
	public XNetProcess_GetEventModeFirstReward()
	{
	}

	[Token(Token = "0x60040DE")]
	[Address(RVA = "0x213C7B4", Offset = "0x213C7B4", VA = "0x213C7B4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040DF")]
	[Address(RVA = "0x213C870", Offset = "0x213C870", VA = "0x213C870", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040E1")]
	[Address(RVA = "0x213CA0C", Offset = "0x213CA0C", VA = "0x213CA0C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040E2")]
	[Address(RVA = "0x213CA10", Offset = "0x213CA10", VA = "0x213CA10", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
