using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace SharpRaven.Logging.Filters
{
	[Token(Token = "0x200035B")]
	public class CreditCardFilter : IFilter
	{
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x20F2598", Offset = "0x20F2598", VA = "0x20F2598")]
		public CreditCardFilter()
		{
		}

		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x20F25A0", Offset = "0x20F25A0", VA = "0x20F25A0", Slot = "4")]
		public string Filter(string input)
		{
			return null;
		}

		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x20F26AC", Offset = "0x20F26AC", VA = "0x20F26AC")]
		private bool IsValidCreditCardNumber(string number)
		{
			return default(bool);
		}

		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x20F28D0", Offset = "0x20F28D0", VA = "0x20F28D0")]
		private string _003CFilter_003Em__8C(Match m)
		{
			return null;
		}
	}
}
