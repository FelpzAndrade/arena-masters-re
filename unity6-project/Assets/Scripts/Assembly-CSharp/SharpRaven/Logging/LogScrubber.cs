using System.Collections.Generic;
using Il2CppDummyDll;

namespace SharpRaven.Logging
{
	[Token(Token = "0x2000360")]
	public class LogScrubber : IScrubber
	{
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x8")]
		private List<IFilter> Filters__BackingField;

		[Token(Token = "0x170004C6")]
		public List<IFilter> Filters
		{
			[Token(Token = "0x6001C34")]
			[Address(RVA = "0x20F2DCC", Offset = "0x20F2DCC", VA = "0x20F2DCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C35")]
			[Address(RVA = "0x20F2DC4", Offset = "0x20F2DC4", VA = "0x20F2DC4")]
			private set
			{
			}
		}

		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x20F2B74", Offset = "0x20F2B74", VA = "0x20F2B74")]
		public LogScrubber()
		{
		}

		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x20F2DD4", Offset = "0x20F2DD4", VA = "0x20F2DD4", Slot = "4")]
		public string Scrub(string input)
		{
			return null;
		}
	}
}
