using System.Collections;
using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x200036A")]
	public abstract class XAssetBundleLoadOperation : IEnumerator
	{
		[Token(Token = "0x170004CB")]
		public object Current
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x1EF7FC0", Offset = "0x1EF7FC0", VA = "0x1EF7FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x1EF6CA4", Offset = "0x1EF6CA4", VA = "0x1EF6CA4")]
		protected XAssetBundleLoadOperation()
		{
		}

		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x1EF7FC8", Offset = "0x1EF7FC8", VA = "0x1EF7FC8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x1EF8008", Offset = "0x1EF8008", VA = "0x1EF8008", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x6001C76")]
		public abstract bool Update();

		[Token(Token = "0x6001C77")]
		public abstract bool IsDone();

		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x1EF800C", Offset = "0x1EF800C", VA = "0x1EF800C", Slot = "9")]
		public virtual string GetName()
		{
			return null;
		}
	}
}
