using Il2CppDummyDll;

[Token(Token = "0x20003DB")]
public class InviteMessageCommand
{
	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x8")]
	private string ReciverName__BackingField;

	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0xC")]
	private string ReciverID__BackingField;

	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x10")]
	private string InviteKey__BackingField;

	[Token(Token = "0x17000550")]
	public string ReciverName
	{
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0xD92554", Offset = "0xD92554", VA = "0xD92554")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0xD9253C", Offset = "0xD9253C", VA = "0xD9253C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000551")]
	public string ReciverID
	{
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0xD9255C", Offset = "0xD9255C", VA = "0xD9255C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0xD92544", Offset = "0xD92544", VA = "0xD92544")]
		private set
		{
		}
	}

	[Token(Token = "0x17000552")]
	public string InviteKey
	{
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0xD92564", Offset = "0xD92564", VA = "0xD92564")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0xD9254C", Offset = "0xD9254C", VA = "0xD9254C")]
		private set
		{
		}
	}

	[Token(Token = "0x6001F79")]
	[Address(RVA = "0xD9250C", Offset = "0xD9250C", VA = "0xD9250C")]
	public InviteMessageCommand(string _ReciverID, string _ReciverName, string _InviteKey)
	{
	}
}
