using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x2000389")]
	public interface IPatchListener
	{
		[Token(Token = "0x6001D28")]
		void OnProgress(int write, int total, int totalWrite);

		[Token(Token = "0x6001D29")]
		void OnFinish();

		[Token(Token = "0x6001D2A")]
		void OnError();
	}
}
