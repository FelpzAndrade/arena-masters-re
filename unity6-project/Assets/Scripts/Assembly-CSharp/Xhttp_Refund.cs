using System.Collections.Specialized;
using Il2CppDummyDll;

[Token(Token = "0x200104C")]
public class Xhttp_Refund : XHttpRequest
{
	[Token(Token = "0x200104D")]
	public class RequestParam
	{
		[Token(Token = "0x40057E5")]
		[FieldOffset(Offset = "0x8")]
		public NameValueCollection Param;

		[Token(Token = "0x60079A5")]
		[Address(RVA = "0x1D23570", Offset = "0x1D23570", VA = "0x1D23570")]
		public RequestParam()
		{
		}
	}

	[Token(Token = "0x40057E4")]
	[FieldOffset(Offset = "0x8")]
	private RequestParam requestParam;

	[Token(Token = "0x60079A1")]
	[Address(RVA = "0x1D23208", Offset = "0x1D23208", VA = "0x1D23208")]
	public Xhttp_Refund()
	{
	}

	[Token(Token = "0x60079A2")]
	[Address(RVA = "0x1D2360C", Offset = "0x1D2360C", VA = "0x1D2360C")]
	private string GetRquestURL()
	{
		return null;
	}

	[Token(Token = "0x60079A3")]
	[Address(RVA = "0x1D23684", Offset = "0x1D23684", VA = "0x1D23684")]
	private string GetBodyData()
	{
		return null;
	}

	[Token(Token = "0x60079A4")]
	[Address(RVA = "0x1D236E8", Offset = "0x1D236E8", VA = "0x1D236E8")]
	public string GetUri()
	{
		return null;
	}
}
