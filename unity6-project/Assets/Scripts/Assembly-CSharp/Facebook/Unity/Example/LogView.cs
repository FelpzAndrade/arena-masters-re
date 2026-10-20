using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x2000018")]
	internal class LogView : ConsoleBase
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x0")]
		private static string datePatt;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x4")]
		private static IList<string> events;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1E88E9C", Offset = "0x1E88E9C", VA = "0x1E88E9C")]
		public LogView()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1E82AF0", Offset = "0x1E82AF0", VA = "0x1E82AF0")]
		public static void AddLog(string log)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1E89008", Offset = "0x1E89008", VA = "0x1E89008")]
		protected void OnGUI()
		{
		}
	}
}
