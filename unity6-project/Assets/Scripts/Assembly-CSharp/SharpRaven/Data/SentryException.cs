using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SharpRaven.Data
{
	[Token(Token = "0x2000359")]
	public class SentryException
	{
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x8")]
		public string Type;

		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0xC")]
		public string Value;

		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x10")]
		public string Module;

		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x20F145C", Offset = "0x20F145C", VA = "0x20F145C")]
		public SentryException(Exception e)
		{
		}

		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x20F18E4", Offset = "0x20F18E4", VA = "0x20F18E4")]
		public SentryException(string log, string stack, LogType logType)
		{
		}
	}
}
