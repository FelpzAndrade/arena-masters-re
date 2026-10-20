using Il2CppDummyDll;

[Token(Token = "0x20002BA")]
public class AuthenticationValues
{
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x8")]
	private CustomAuthenticationType authType;

	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0xC")]
	private string AuthGetParameters__BackingField;

	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x10")]
	private object AuthPostData__BackingField;

	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x14")]
	private string Token__BackingField;

	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x18")]
	private string UserId__BackingField;

	[Token(Token = "0x170003E4")]
	public CustomAuthenticationType AuthType
	{
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x20BD9D8", Offset = "0x20BD9D8", VA = "0x20BD9D8")]
		get
		{
			return default(CustomAuthenticationType);
		}
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x20BD9E0", Offset = "0x20BD9E0", VA = "0x20BD9E0")]
		set
		{
		}
	}

	[Token(Token = "0x170003E5")]
	public string AuthGetParameters
	{
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x20BD9E8", Offset = "0x20BD9E8", VA = "0x20BD9E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x20BD9F0", Offset = "0x20BD9F0", VA = "0x20BD9F0")]
		set
		{
		}
	}

	[Token(Token = "0x170003E6")]
	public object AuthPostData
	{
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x20BD9F8", Offset = "0x20BD9F8", VA = "0x20BD9F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x20BDA00", Offset = "0x20BDA00", VA = "0x20BDA00")]
		private set
		{
		}
	}

	[Token(Token = "0x170003E7")]
	public string Token
	{
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x20BDA08", Offset = "0x20BDA08", VA = "0x20BDA08")]
		get
		{
			return null;
		}
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x20BDA10", Offset = "0x20BDA10", VA = "0x20BDA10")]
		set
		{
		}
	}

	[Token(Token = "0x170003E8")]
	public string UserId
	{
		[Token(Token = "0x600173E")]
		[Address(RVA = "0x20BDA18", Offset = "0x20BDA18", VA = "0x20BDA18")]
		get
		{
			return null;
		}
		[Token(Token = "0x600173F")]
		[Address(RVA = "0x20BD9D0", Offset = "0x20BD9D0", VA = "0x20BD9D0")]
		set
		{
		}
	}

	[Token(Token = "0x6001734")]
	[Address(RVA = "0x20BD994", Offset = "0x20BD994", VA = "0x20BD994")]
	public AuthenticationValues()
	{
	}

	[Token(Token = "0x6001735")]
	[Address(RVA = "0x20BD9A4", Offset = "0x20BD9A4", VA = "0x20BD9A4")]
	public AuthenticationValues(string userId)
	{
	}

	[Token(Token = "0x6001740")]
	[Address(RVA = "0x20BDA20", Offset = "0x20BDA20", VA = "0x20BDA20", Slot = "4")]
	public virtual void SetAuthPostData(string stringData)
	{
	}

	[Token(Token = "0x6001741")]
	[Address(RVA = "0x20BDAEC", Offset = "0x20BDAEC", VA = "0x20BDAEC", Slot = "5")]
	public virtual void SetAuthPostData(byte[] byteData)
	{
	}

	[Token(Token = "0x6001742")]
	[Address(RVA = "0x20BDAF4", Offset = "0x20BDAF4", VA = "0x20BDAF4", Slot = "6")]
	public virtual void AddAuthParameter(string key, string value)
	{
	}

	[Token(Token = "0x6001743")]
	[Address(RVA = "0x20BDE2C", Offset = "0x20BDE2C", VA = "0x20BDE2C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
