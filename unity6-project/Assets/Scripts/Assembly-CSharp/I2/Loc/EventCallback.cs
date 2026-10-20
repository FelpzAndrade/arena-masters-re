using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000063")]
	public class EventCallback
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MonoBehaviour Target;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string MethodName;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xD5BA48", Offset = "0xD5BA48", VA = "0xD5BA48")]
		public EventCallback()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xD5BB04", Offset = "0xD5BB04", VA = "0xD5BB04")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}
	}
}
