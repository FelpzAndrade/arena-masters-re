using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x2001099")]
	public interface INPPlateListener : INPListenerType
	{
		[Token(Token = "0x6007D1A")]
		void OnActionPerformedResult(NPResult npResult);
	}
}
