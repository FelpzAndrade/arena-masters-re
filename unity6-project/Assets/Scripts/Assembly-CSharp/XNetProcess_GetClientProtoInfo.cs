using Il2CppDummyDll;

[Token(Token = "0x20007FE")]
public class XNetProcess_GetClientProtoInfo : XNetProcessLoginBase
{
	[Token(Token = "0x170008E8")]
	public override string Name
	{
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x213BF44", Offset = "0x213BF44", VA = "0x213BF44", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004001")]
	[Address(RVA = "0x213BF3C", Offset = "0x213BF3C", VA = "0x213BF3C")]
	public XNetProcess_GetClientProtoInfo()
	{
	}

	[Token(Token = "0x6004003")]
	[Address(RVA = "0x213BFBC", Offset = "0x213BFBC", VA = "0x213BFBC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004004")]
	[Address(RVA = "0x213C23C", Offset = "0x213C23C", VA = "0x213C23C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
