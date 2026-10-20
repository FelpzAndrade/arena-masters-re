using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace SharpRaven.Data
{
	[Token(Token = "0x200035A")]
	public class SentryStacktrace
	{
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x8")]
		public List<ExceptionFrame> Frames;

		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x0")]
		private static Func<StackFrame, ExceptionFrame> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x20F152C", Offset = "0x20F152C", VA = "0x20F152C")]
		public SentryStacktrace(Exception e)
		{
		}

		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x20F1B1C", Offset = "0x20F1B1C", VA = "0x20F1B1C")]
		private static ExceptionFrame _003CSentryStacktrace_003Em__8B(StackFrame frame)
		{
			return null;
		}
	}
}
