using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000987")]
	public class NetCommandIncomParamBuilder : INetCommandIncomParamBuilder
	{
		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x233DDD4", Offset = "0x233DDD4", VA = "0x233DDD4")]
		public NetCommandIncomParamBuilder()
		{
		}

		[Token(Token = "0x6004CBF")]
		[Address(RVA = "0x233DDDC", Offset = "0x233DDDC", VA = "0x233DDDC", Slot = "4")]
		public void Build(CSNetCommand cmd, string rawURL)
		{
		}

		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x233E2B8", Offset = "0x233E2B8", VA = "0x233E2B8", Slot = "5")]
		public void Build(CSNetCommand cmd, string rawURL, JObject postBody)
		{
		}
	}
}
