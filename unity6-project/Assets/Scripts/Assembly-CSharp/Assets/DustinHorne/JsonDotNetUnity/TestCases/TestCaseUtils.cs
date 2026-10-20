using System;
using Assets.DustinHorne.JsonDotNetUnity.TestCases.TestModels;
using Il2CppDummyDll;

namespace Assets.DustinHorne.JsonDotNetUnity.TestCases
{
	[Token(Token = "0x2000094")]
	public static class TestCaseUtils
	{
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x0")]
		private static Random _rnd;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x20BCB6C", Offset = "0x20BCB6C", VA = "0x20BCB6C")]
		public static SampleBase GetSampleBase()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x20BCE70", Offset = "0x20BCE70", VA = "0x20BCE70")]
		public static SampleChild GetSampleChid()
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x20BD2C8", Offset = "0x20BD2C8", VA = "0x20BD2C8")]
		public static SimpleClassObject GetSimpleClassObject()
		{
			return null;
		}
	}
}
