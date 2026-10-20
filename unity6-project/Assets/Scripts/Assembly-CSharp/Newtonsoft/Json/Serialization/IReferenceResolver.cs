using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000125")]
	public interface IReferenceResolver
	{
		[Token(Token = "0x6000B1A")]
		object ResolveReference(object context, string reference);

		[Token(Token = "0x6000B1B")]
		string GetReference(object context, object value);

		[Token(Token = "0x6000B1C")]
		bool IsReferenced(object context, object value);

		[Token(Token = "0x6000B1D")]
		void AddReference(object context, string reference, object value);
	}
}
