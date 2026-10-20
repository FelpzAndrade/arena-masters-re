using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x2000373")]
	public class XLoadedAssetBundle
	{
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x8")]
		public AssetBundle m_AssetBundle;

		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0xC")]
		public int m_ReferencedCount;

		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x1EF9AD4", Offset = "0x1EF9AD4", VA = "0x1EF9AD4")]
		public XLoadedAssetBundle(AssetBundle assetBundle)
		{
		}
	}
}
