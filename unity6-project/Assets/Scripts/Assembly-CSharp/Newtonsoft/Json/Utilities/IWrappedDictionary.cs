using System.Collections;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000153")]
	internal interface IWrappedDictionary : IEnumerable, ICollection, IDictionary
	{
		[Token(Token = "0x17000220")]
		object UnderlyingDictionary
		{
			[Token(Token = "0x6000CBA")]
			get;
		}
	}
}
