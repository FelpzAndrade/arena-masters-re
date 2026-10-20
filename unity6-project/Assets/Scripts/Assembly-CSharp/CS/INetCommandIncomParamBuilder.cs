using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000986")]
	public interface INetCommandIncomParamBuilder
	{
		[Token(Token = "0x6004CBC")]
		void Build(CSNetCommand cmd, string rawURL);

		[Token(Token = "0x6004CBD")]
		void Build(CSNetCommand cmd, string rawURL, JObject postBody);
	}
}
