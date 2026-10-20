using Il2CppDummyDll;

namespace TapjoyUnity
{
	[Token(Token = "0x20010D3")]
	public class TapjoyCallbacksSample : TapjoyRuntimeCallbacks
	{
		[Token(Token = "0x6007F12")]
		[Address(RVA = "0x1D4B7A8", Offset = "0x1D4B7A8", VA = "0x1D4B7A8")]
		public TapjoyCallbacksSample()
		{
		}

		[Token(Token = "0x6007F13")]
		[Address(RVA = "0x1D4B7B0", Offset = "0x1D4B7B0", VA = "0x1D4B7B0", Slot = "4")]
		public override string GetFyberUserId()
		{
			return null;
		}
	}
}
