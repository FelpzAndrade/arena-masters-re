using Il2CppDummyDll;
using UnityEngine;

namespace WindowsInput
{
	[Token(Token = "0x2000BE7")]
	public class WinInput
	{
		[Token(Token = "0x6005602")]
		[Address(RVA = "0x17B4068", Offset = "0x17B4068", VA = "0x17B4068")]
		public WinInput()
		{
		}

		[Token(Token = "0x6005603")]
		[Address(RVA = "0x17B4070", Offset = "0x17B4070", VA = "0x17B4070")]
		public static bool GetKey(KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6005604")]
		[Address(RVA = "0x17B4118", Offset = "0x17B4118", VA = "0x17B4118")]
		public static bool GetKeyDown(KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6005605")]
		[Address(RVA = "0x17B41C0", Offset = "0x17B41C0", VA = "0x17B41C0")]
		public static bool GetKeyFullCover(KeyCode key)
		{
			return default(bool);
		}
	}
}
