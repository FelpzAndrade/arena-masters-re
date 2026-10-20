using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000126")]
	public interface IValueProvider
	{
		[Token(Token = "0x6000B1E")]
		void SetValue(object target, object value);

		[Token(Token = "0x6000B1F")]
		object GetValue(object target);
	}
}
