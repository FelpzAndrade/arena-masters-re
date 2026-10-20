using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x2000371")]
	public class XResourceLoadOperationFull : XAssetBundleLoadAssetOperation
	{
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0xC")]
		protected Type m_Type;

		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x10")]
		protected ResourceRequest m_Request;

		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x1EFB7F8", Offset = "0x1EFB7F8", VA = "0x1EFB7F8")]
		public XResourceLoadOperationFull(string path, ResourceRequest request, Type type)
		{
		}

		[Token(Token = "0x6001C91")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x1EFB828", Offset = "0x1EFB828", VA = "0x1EFB828", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x1EFB830", Offset = "0x1EFB830", VA = "0x1EFB830", Slot = "8")]
		public override bool IsDone()
		{
			return default(bool);
		}
	}
}
