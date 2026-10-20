using System.Collections.Specialized;
using System.Net;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20008ED")]
public abstract class BaseHttpRequest : IHttpRequest
{
	[Token(Token = "0x6004787")]
	[Address(RVA = "0x20BDF38", Offset = "0x20BDF38", VA = "0x20BDF38")]
	protected BaseHttpRequest()
	{
	}

	[Token(Token = "0x6004788")]
	[Address(RVA = "0x20BDF40", Offset = "0x20BDF40", VA = "0x20BDF40", Slot = "6")]
	protected virtual void AddHeaderData(WebHeaderCollection header)
	{
	}

	[Token(Token = "0x6004789")]
	[Address(RVA = "0x20BDF44", Offset = "0x20BDF44", VA = "0x20BDF44")]
	public HttpWebRequest CreateHttpWebRequest(string url, string method, string contentType, string accept = "")
	{
		return null;
	}

	[Token(Token = "0x600478A")]
	[Address(RVA = "0x20BE188", Offset = "0x20BE188", VA = "0x20BE188", Slot = "7")]
	public virtual JObject RequestGet(string url, NameValueCollection param, [Optional][DefaultParameterValue("application/x-www-form-urlencoded")] string contentType, [Optional] object state)
	{
		return null;
	}

	[Token(Token = "0x600478B")]
	[Address(RVA = "0x20BE768", Offset = "0x20BE768", VA = "0x20BE768", Slot = "8")]
	public virtual JObject RequestPost(string url, string param, [Optional][DefaultParameterValue("application/x-www-form-urlencoded")] string contentType, [Optional] object state)
	{
		return null;
	}

	[Token(Token = "0x600478C")]
	[Address(RVA = "0x20BEC30", Offset = "0x20BEC30", VA = "0x20BEC30")]
	protected byte[] GetRequestBytes(string strParam)
	{
		return null;
	}

	[Token(Token = "0x600478D")]
	protected abstract string NameValueCollectionToQueryString(NameValueCollection nvc);

	[Token(Token = "0x600478E")]
	[Address(RVA = "0x20BED74", Offset = "0x20BED74", VA = "0x20BED74")]
	protected void ContentStreamWrite(HttpWebRequest request, byte[] data)
	{
	}

	[Token(Token = "0x600478F")]
	[Address(RVA = "0x20BE624", Offset = "0x20BE624", VA = "0x20BE624")]
	private void ContentStreamWrite(HttpWebRequest request, string data)
	{
	}
}
