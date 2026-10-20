using System.Collections;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000162")]
	internal interface IWrappedList : IEnumerable, IList, ICollection
	{
		[Token(Token = "0x17000234")]
		object UnderlyingList
		{
			[Token(Token = "0x6000D13")]
			get;
		}
	}
}
