using Il2CppDummyDll;

[Token(Token = "0x200080D")]
public class XNetProcess_TitleProcessEnd : XNetProcessLoginBase
{
	[Token(Token = "0x170008F9")]
	public override string Name
	{
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x1EC9B0C", Offset = "0x1EC9B0C", VA = "0x1EC9B0C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FA")]
	public override bool IsProcessed
	{
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x1EC9B84", Offset = "0x1EC9B84", VA = "0x1EC9B84", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600406E")]
	[Address(RVA = "0x1EC9B04", Offset = "0x1EC9B04", VA = "0x1EC9B04")]
	public XNetProcess_TitleProcessEnd()
	{
	}

	[Token(Token = "0x6004071")]
	[Address(RVA = "0x1EC9B8C", Offset = "0x1EC9B8C", VA = "0x1EC9B8C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004072")]
	[Address(RVA = "0x1ECA6A0", Offset = "0x1ECA6A0", VA = "0x1ECA6A0", Slot = "17")]
	public override void Update(float delta)
	{
	}

	[Token(Token = "0x6004073")]
	[Address(RVA = "0x1ECA6BC", Offset = "0x1ECA6BC", VA = "0x1ECA6BC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
