using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000062")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x17000057")]
		public static CoroutineManager pInstance
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1F54F5C", Offset = "0x1F54F5C", VA = "0x1F54F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1F54F54", Offset = "0x1F54F54", VA = "0x1F54F54")]
		public CoroutineManager()
		{
		}
	}
}
