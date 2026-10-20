using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000124")]
	public interface IContractResolver
	{
		[Token(Token = "0x6000B19")]
		JsonContract ResolveContract(Type type);
	}
}
