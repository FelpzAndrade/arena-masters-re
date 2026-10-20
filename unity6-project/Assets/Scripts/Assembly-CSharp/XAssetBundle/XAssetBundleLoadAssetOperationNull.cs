using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x200036E")]
	public class XAssetBundleLoadAssetOperationNull : XAssetBundleLoadAssetOperation
	{
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x1EF7B44", Offset = "0x1EF7B44", VA = "0x1EF7B44")]
		public XAssetBundleLoadAssetOperationNull()
		{
		}

		[Token(Token = "0x6001C84")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x1EF7B64", Offset = "0x1EF7B64", VA = "0x1EF7B64", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x1EF7B6C", Offset = "0x1EF7B6C", VA = "0x1EF7B6C", Slot = "8")]
		public override bool IsDone()
		{
			return default(bool);
		}
	}
}
