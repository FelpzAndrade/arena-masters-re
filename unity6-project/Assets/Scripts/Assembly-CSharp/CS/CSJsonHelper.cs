using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x20008BA")]
	public static class CSJsonHelper
	{
		[Token(Token = "0x6004694")]
		[Address(RVA = "0x2236460", Offset = "0x2236460", VA = "0x2236460")]
		public static bool IsContains(JToken data, string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6004695")]
		[Address(RVA = "0x22364B8", Offset = "0x22364B8", VA = "0x22364B8")]
		public static JToken GetData(JToken data, string key)
		{
			return null;
		}

		[Token(Token = "0x6004696")]
		[Address(RVA = "0x223652C", Offset = "0x223652C", VA = "0x223652C")]
		public static string ToString(object obj)
		{
			return null;
		}

		[Token(Token = "0x6004697")]
		[Address(RVA = "0x223654C", Offset = "0x223654C", VA = "0x223654C")]
		public static string ToString(JToken obj)
		{
			return null;
		}

		[Token(Token = "0x6004698")]
		[Address(RVA = "0x2236604", Offset = "0x2236604", VA = "0x2236604")]
		public static ApiReturnCode ExtractErrorNo(string json)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x6004699")]
		public static T GetValue<T>(JObject obj, string key, T defaultValue)
		{
			return (T)default;
		}

		[Token(Token = "0x600469A")]
		public static T GetValue<T>(JObject obj, string key)
		{
			return (T)default;
		}

		[Token(Token = "0x600469B")]
		public static T FindTokenValue<T>(JObject obj, string key)
		{
			return (T)default;
		}

		[Token(Token = "0x600469C")]
		[Address(RVA = "0x22366EC", Offset = "0x22366EC", VA = "0x22366EC")]
		private static bool FindToken(JToken containerToken, string name, out JToken matche)
		{
			matche = default;
			return default(bool);
		}

		[Token(Token = "0x600469D")]
		[Address(RVA = "0x2236DAC", Offset = "0x2236DAC", VA = "0x2236DAC")]
		public static bool IsNullOrEmpty(this JToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x600469E")]
		public static T FromJson<T>(string json)
		{
			return (T)default;
		}

		[Token(Token = "0x600469F")]
		public static string ToJson<T>(T obj)
		{
			return null;
		}
	}
}
