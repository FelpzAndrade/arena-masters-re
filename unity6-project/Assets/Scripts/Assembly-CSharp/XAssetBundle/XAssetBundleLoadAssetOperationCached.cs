using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x200036D")]
	public class XAssetBundleLoadAssetOperationCached : XAssetBundleLoadAssetOperation
	{
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0xC")]
		protected Type m_Type;

		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x10")]
		protected UnityEngine.Object m_obj;

		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x1EF6CB4", Offset = "0x1EF6CB4", VA = "0x1EF6CB4")]
		public XAssetBundleLoadAssetOperationCached(string path, UnityEngine.Object obj, Type type)
		{
		}

		[Token(Token = "0x6001C80")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x1EF6CE4", Offset = "0x1EF6CE4", VA = "0x1EF6CE4", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x1EF6CEC", Offset = "0x1EF6CEC", VA = "0x1EF6CEC", Slot = "8")]
		public override bool IsDone()
		{
			return default(bool);
		}
	}
}
