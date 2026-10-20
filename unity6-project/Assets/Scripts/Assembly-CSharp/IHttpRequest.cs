using System.Collections.Specialized;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20008EB")]
public interface IHttpRequest
{
	[Token(Token = "0x6004785")]
	JObject RequestGet(string url, NameValueCollection param, string contentType, object state);

	[Token(Token = "0x6004786")]
	JObject RequestPost(string url, string param, string contentType, object state);
}
