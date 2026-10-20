using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x2001093")]
	public interface INPListener : INPListenerType
	{
		[Token(Token = "0x6007D0F")]
		void OnResult(NPResult npResult);
	}
}
