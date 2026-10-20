using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x200110F")]
	public delegate void NetCallback(ApiReturnCode errno, string errmsg, JObject json);
}
