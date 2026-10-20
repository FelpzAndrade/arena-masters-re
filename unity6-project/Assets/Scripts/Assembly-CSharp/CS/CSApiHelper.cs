using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x200086A")]
	public static class CSApiHelper
	{
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x23EE0C4", Offset = "0x23EE0C4", VA = "0x23EE0C4")]
		public static JObject ReturnError(ApiReturnCode code)
		{
			return null;
		}

		[Token(Token = "0x6004580")]
		[Address(RVA = "0x23EE23C", Offset = "0x23EE23C", VA = "0x23EE23C")]
		public static JObject ReturnOk()
		{
			return null;
		}

		[Token(Token = "0x6004581")]
		[Address(RVA = "0x23EE2C8", Offset = "0x23EE2C8", VA = "0x23EE2C8")]
		public static string RemoveStringFormat(string text)
		{
			return null;
		}

		[Token(Token = "0x6004582")]
		[Address(RVA = "0x23EE504", Offset = "0x23EE504", VA = "0x23EE504")]
		public static string DumpCallStack()
		{
			return null;
		}
	}
}
