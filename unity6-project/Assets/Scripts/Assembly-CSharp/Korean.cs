using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

[Token(Token = "0x2001074")]
public class Korean
{
	[Token(Token = "0x2001075")]
	public class XJosa
	{
		[Token(Token = "0x2001076")]
		private class JosaPair
		{
			[Token(Token = "0x40058C8")]
			[FieldOffset(Offset = "0x8")]
			private string josa1__BackingField;

			[Token(Token = "0x40058C9")]
			[FieldOffset(Offset = "0xC")]
			private string josa2__BackingField;

			[Token(Token = "0x17000F56")]
			public string josa1
			{
				[Token(Token = "0x6007C34")]
				[Address(RVA = "0xDD4218", Offset = "0xDD4218", VA = "0xDD4218")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007C35")]
				[Address(RVA = "0xDD4228", Offset = "0xDD4228", VA = "0xDD4228")]
				private set
				{
				}
			}

			[Token(Token = "0x17000F57")]
			public string josa2
			{
				[Token(Token = "0x6007C36")]
				[Address(RVA = "0xDD4220", Offset = "0xDD4220", VA = "0xDD4220")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007C37")]
				[Address(RVA = "0xDD4230", Offset = "0xDD4230", VA = "0xDD4230")]
				private set
				{
				}
			}

			[Token(Token = "0x6007C33")]
			[Address(RVA = "0xDD4160", Offset = "0xDD4160", VA = "0xDD4160")]
			public JosaPair(string josa1, string josa2)
			{
			}
		}

		[Token(Token = "0x40058C6")]
		[FieldOffset(Offset = "0x8")]
		private Regex _josaRegex;

		[Token(Token = "0x40058C7")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, JosaPair> _josaPatternPaird;

		[Token(Token = "0x6007C2F")]
		[Address(RVA = "0xDD35E4", Offset = "0xDD35E4", VA = "0xDD35E4")]
		public XJosa()
		{
		}

		[Token(Token = "0x6007C30")]
		[Address(RVA = "0xDD3AE8", Offset = "0xDD3AE8", VA = "0xDD3AE8")]
		public string Replace(string src)
		{
			return null;
		}

		[Token(Token = "0x6007C31")]
		[Address(RVA = "0xDD4188", Offset = "0xDD4188", VA = "0xDD4188")]
		private static bool HasJong(char inChar)
		{
			return default(bool);
		}

		[Token(Token = "0x6007C32")]
		[Address(RVA = "0xDD41D0", Offset = "0xDD41D0", VA = "0xDD41D0")]
		private static bool HasJongExceptRieul(char inChar)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40058C5")]
	[FieldOffset(Offset = "0x0")]
	private static XJosa _josa;

	[Token(Token = "0x6007C2C")]
	[Address(RVA = "0xDD3540", Offset = "0xDD3540", VA = "0xDD3540")]
	public Korean()
	{
	}

	[Token(Token = "0x6007C2E")]
	[Address(RVA = "0xDD3A18", Offset = "0xDD3A18", VA = "0xDD3A18")]
	public static string ReplaceJosa(string src)
	{
		return null;
	}
}
