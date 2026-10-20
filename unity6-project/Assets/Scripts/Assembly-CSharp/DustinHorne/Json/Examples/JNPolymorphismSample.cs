using System;
using Il2CppDummyDll;

namespace DustinHorne.Json.Examples
{
	[Token(Token = "0x200008E")]
	public class JNPolymorphismSample
	{
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x8")]
		private Random _rnd;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1E68950", Offset = "0x1E68950", VA = "0x1E68950")]
		public JNPolymorphismSample()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1E689EC", Offset = "0x1E689EC", VA = "0x1E689EC")]
		public void Sample()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1E68D6C", Offset = "0x1E68D6C", VA = "0x1E68D6C")]
		private JNSimpleObjectModel GetBaseModel()
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1E69064", Offset = "0x1E69064", VA = "0x1E69064")]
		private JNSubClassModel GetSubClassModel()
		{
			return null;
		}
	}
}
