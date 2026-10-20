using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x2001095")]
	public interface INPGCMListener : INPListenerType
	{
		[Token(Token = "0x6007D11")]
		void OnGCMResult(int errorCode);
	}
}
