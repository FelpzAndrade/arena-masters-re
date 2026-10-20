using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010B5")]
	public class NXPJSONStringBuilder
	{
		[Token(Token = "0x4005C69")]
		private const string OPEN_BRACKET = "{";

		[Token(Token = "0x4005C6A")]
		private const string CLOSE_BRACKET = "}";

		[Token(Token = "0x4005C6B")]
		[FieldOffset(Offset = "0x8")]
		private StringBuilder builder;

		[Token(Token = "0x4005C6C")]
		[FieldOffset(Offset = "0xC")]
		private bool isSetCloseBracket;

		[Token(Token = "0x6007DF2")]
		[Address(RVA = "0x11DE10C", Offset = "0x11DE10C", VA = "0x11DE10C")]
		public NXPJSONStringBuilder()
		{
		}

		[Token(Token = "0x6007DF3")]
		[Address(RVA = "0x11DE1EC", Offset = "0x11DE1EC", VA = "0x11DE1EC")]
		public NXPJSONStringBuilder append(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6007DF4")]
		[Address(RVA = "0x11DE564", Offset = "0x11DE564", VA = "0x11DE564")]
		public NXPJSONStringBuilder append(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6007DF5")]
		[Address(RVA = "0x11DE674", Offset = "0x11DE674", VA = "0x11DE674")]
		public NXPJSONStringBuilder append(string key, Dictionary<string, string> value)
		{
			return null;
		}

		[Token(Token = "0x6007DF6")]
		[Address(RVA = "0x11DEBEC", Offset = "0x11DEBEC", VA = "0x11DEBEC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007DF7")]
		[Address(RVA = "0x11DE484", Offset = "0x11DE484", VA = "0x11DE484")]
		private void appendKey(string key)
		{
		}

		[Token(Token = "0x6007DF8")]
		[Address(RVA = "0x11DE39C", Offset = "0x11DE39C", VA = "0x11DE39C")]
		private void appendCommmaIfNotFirstElement()
		{
		}

		[Token(Token = "0x6007DF9")]
		[Address(RVA = "0x11DE354", Offset = "0x11DE354", VA = "0x11DE354")]
		private bool isNullOrEmpty(string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6007DFA")]
		[Address(RVA = "0x11DE38C", Offset = "0x11DE38C", VA = "0x11DE38C")]
		private bool isNull(object obj)
		{
			return default(bool);
		}
	}
}
