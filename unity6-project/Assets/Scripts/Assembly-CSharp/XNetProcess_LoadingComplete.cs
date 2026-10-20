using Il2CppDummyDll;

[Token(Token = "0x2000810")]
public class XNetProcess_LoadingComplete : XNetProcessLoginBase
{
	[Token(Token = "0x170008FF")]
	public override string Name
	{
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x1EBA178", Offset = "0x1EBA178", VA = "0x1EBA178", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004089")]
	[Address(RVA = "0x1EBA170", Offset = "0x1EBA170", VA = "0x1EBA170")]
	public XNetProcess_LoadingComplete()
	{
	}

	[Token(Token = "0x600408B")]
	[Address(RVA = "0x1EBA1F0", Offset = "0x1EBA1F0", VA = "0x1EBA1F0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x600408C")]
	[Address(RVA = "0x1EBA328", Offset = "0x1EBA328", VA = "0x1EBA328", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
