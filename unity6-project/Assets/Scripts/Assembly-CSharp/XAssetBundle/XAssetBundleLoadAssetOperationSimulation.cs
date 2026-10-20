using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x200036F")]
	public class XAssetBundleLoadAssetOperationSimulation : XAssetBundleLoadAssetOperation
	{
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0xC")]
		private Object m_SimulatedObject;

		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x1EF7B74", Offset = "0x1EF7B74", VA = "0x1EF7B74")]
		public XAssetBundleLoadAssetOperationSimulation(Object simulatedObject)
		{
		}

		[Token(Token = "0x6001C88")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x1EF7B94", Offset = "0x1EF7B94", VA = "0x1EF7B94", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x1EF7B9C", Offset = "0x1EF7B9C", VA = "0x1EF7B9C", Slot = "8")]
		public override bool IsDone()
		{
			return default(bool);
		}
	}
}
