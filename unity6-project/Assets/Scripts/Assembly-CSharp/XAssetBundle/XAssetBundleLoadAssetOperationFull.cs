using System;
using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x2000370")]
	public class XAssetBundleLoadAssetOperationFull : XAssetBundleLoadAssetOperation
	{
		protected XAssetBundleLoadAssetOperationFull()
		{
		}

		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0xC")]
		protected string m_AssetBundleName;

		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x10")]
		protected string m_AssetName;

		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x14")]
		protected string m_fileReadingError;

		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x18")]
		protected Type m_Type;

		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x1C")]
		protected XAssetBundleManager.AssetBundleRequestReserve m_Request;

		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x20")]
		protected bool m_allDone;

		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x1EF6CF4", Offset = "0x1EF6CF4", VA = "0x1EF6CF4")]
		public XAssetBundleLoadAssetOperationFull(string bundleName, string assetName, Type type)
		{
		}

		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0x1EF6D24", Offset = "0x1EF6D24", VA = "0x1EF6D24")]
		public XAssetBundleLoadAssetOperationFull(string relativePath, string bundleName, string assetName, Type type)
		{
		}

		[Token(Token = "0x6001C8D")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x1EF6D5C", Offset = "0x1EF6D5C", VA = "0x1EF6D5C", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x1EF780C", Offset = "0x1EF780C", VA = "0x1EF780C", Slot = "8")]
		public override bool IsDone()
		{
			return default(bool);
		}
	}
}
