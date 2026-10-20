using System;
using Il2CppDummyDll;

[Token(Token = "0x2001085")]
public class StringValue : Attribute
{
	[Token(Token = "0x4005915")]
	[FieldOffset(Offset = "0x8")]
	private string m_strValue;

	[Token(Token = "0x17000F5E")]
	public string Value
	{
		[Token(Token = "0x6007CC5")]
		[Address(RVA = "0x1D45558", Offset = "0x1D45558", VA = "0x1D45558")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007CC4")]
	[Address(RVA = "0x1D45560", Offset = "0x1D45560", VA = "0x1D45560")]
	public StringValue(string value)
	{
	}
}
