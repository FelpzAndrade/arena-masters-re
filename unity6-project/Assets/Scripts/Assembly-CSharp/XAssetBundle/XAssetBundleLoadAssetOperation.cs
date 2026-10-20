using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x200036C")]
	public abstract class XAssetBundleLoadAssetOperation : XAssetBundleLoadOperation
	{
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x8")]
		public string relativePath;

		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x1EF6C9C", Offset = "0x1EF6C9C", VA = "0x1EF6C9C")]
		protected XAssetBundleLoadAssetOperation()
		{
		}

		[Token(Token = "0x6001C7D")]
		public abstract T GetAsset<T>() where T : Object;

		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x1EF6CAC", Offset = "0x1EF6CAC", VA = "0x1EF6CAC", Slot = "9")]
		public override string GetName()
		{
			return null;
		}
	}
}
