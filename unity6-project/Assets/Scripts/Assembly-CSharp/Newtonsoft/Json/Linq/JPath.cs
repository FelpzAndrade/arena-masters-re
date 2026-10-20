using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E7")]
	internal class JPath
	{
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _expression;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0xC")]
		private int _currentIndex;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x10")]
		private List<object> Parts__BackingField;

		[Token(Token = "0x17000152")]
		public List<object> Parts
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xF95C34", Offset = "0xF95C34", VA = "0xF95C34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xF958CC", Offset = "0xF958CC", VA = "0xF958CC")]
			private set
			{
			}
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xF957F0", Offset = "0xF957F0", VA = "0xF957F0")]
		public JPath(string expression)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xF958D4", Offset = "0xF958D4", VA = "0xF958D4")]
		private void ParseMain()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xF95C3C", Offset = "0xF95C3C", VA = "0xF95C3C")]
		private void ParseIndexer(char indexerOpenChar)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xF96004", Offset = "0xF96004", VA = "0xF96004")]
		internal JToken Evaluate(JToken root, bool errorWhenNoMatch)
		{
			return null;
		}
	}
}
