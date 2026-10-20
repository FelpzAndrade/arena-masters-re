using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x200038A")]
	public class EmptyPatchListener : IPatchListener
	{
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x1EF3424", Offset = "0x1EF3424", VA = "0x1EF3424")]
		public EmptyPatchListener()
		{
		}

		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x1EF4180", Offset = "0x1EF4180", VA = "0x1EF4180", Slot = "4")]
		public void OnProgress(int write, int total, int totalWrite)
		{
		}

		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x1EF4184", Offset = "0x1EF4184", VA = "0x1EF4184", Slot = "5")]
		public void OnFinish()
		{
		}

		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x1EF4188", Offset = "0x1EF4188", VA = "0x1EF4188", Slot = "6")]
		public void OnError()
		{
		}
	}
}
