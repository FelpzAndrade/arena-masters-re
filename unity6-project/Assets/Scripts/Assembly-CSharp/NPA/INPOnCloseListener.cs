using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x2001098")]
	public interface INPOnCloseListener : INPListenerType
	{
		[Token(Token = "0x6007D19")]
		void OnClose(NPCloseResult npResult);
	}
}
