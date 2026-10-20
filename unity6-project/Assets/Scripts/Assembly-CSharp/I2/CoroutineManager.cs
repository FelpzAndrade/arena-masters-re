using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace I2
{
	[Token(Token = "0x2000060")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1F54D58", Offset = "0x1F54D58", VA = "0x1F54D58")]
		public CoroutineManager()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1F54D60", Offset = "0x1F54D60", VA = "0x1F54D60")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}
	}
}
