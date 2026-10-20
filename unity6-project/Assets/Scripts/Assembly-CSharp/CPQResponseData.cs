using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x2000A76")]
public class CPQResponseData
{
	[Token(Token = "0x400307B")]
	[FieldOffset(Offset = "0x8")]
	public string TraceID;

	[Token(Token = "0x400307C")]
	[FieldOffset(Offset = "0xC")]
	public int ResultCode;

	[Token(Token = "0x400307D")]
	[FieldOffset(Offset = "0x10")]
	public string ResultMessage;

	[Token(Token = "0x400307E")]
	[FieldOffset(Offset = "0x14")]
	public object ResultValue;

	[Token(Token = "0x400307F")]
	[FieldOffset(Offset = "0x0")]
	[JsonIgnore]
	public static readonly string Key;

	[Token(Token = "0x6004DDB")]
	[Address(RVA = "0x23E4148", Offset = "0x23E4148", VA = "0x23E4148")]
	public CPQResponseData()
	{
	}
}
