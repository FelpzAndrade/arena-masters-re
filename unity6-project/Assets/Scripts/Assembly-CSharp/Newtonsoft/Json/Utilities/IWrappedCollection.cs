using System.Collections;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000149")]
	internal interface IWrappedCollection : IEnumerable, IList, ICollection
	{
		[Token(Token = "0x17000216")]
		object UnderlyingCollection
		{
			[Token(Token = "0x6000C7A")]
			get;
		}
	}
}
