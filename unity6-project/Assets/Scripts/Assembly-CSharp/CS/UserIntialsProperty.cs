using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B8E")]
	public class UserIntialsProperty
	{
		[Token(Token = "0x4003A76")]
		[FieldOffset(Offset = "0x8")]
		private string keyField;

		[Token(Token = "0x4003A77")]
		[FieldOffset(Offset = "0xC")]
		private string valueField;

		[Token(Token = "0x17000C2C")]
		public string key
		{
			[Token(Token = "0x600538D")]
			[Address(RVA = "0x21EE634", Offset = "0x21EE634", VA = "0x21EE634")]
			get
			{
				return null;
			}
			[Token(Token = "0x600538E")]
			[Address(RVA = "0x21EE63C", Offset = "0x21EE63C", VA = "0x21EE63C")]
			set
			{
			}
		}

		[Token(Token = "0x17000C2D")]
		public string value
		{
			[Token(Token = "0x600538F")]
			[Address(RVA = "0x21EE644", Offset = "0x21EE644", VA = "0x21EE644")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005390")]
			[Address(RVA = "0x21EE64C", Offset = "0x21EE64C", VA = "0x21EE64C")]
			set
			{
			}
		}

		[Token(Token = "0x600538C")]
		[Address(RVA = "0x21EE62C", Offset = "0x21EE62C", VA = "0x21EE62C")]
		public UserIntialsProperty()
		{
		}

		[Token(Token = "0x6005391")]
		[Address(RVA = "0x21EE654", Offset = "0x21EE654", VA = "0x21EE654")]
		public int ToInt()
		{
			return default(int);
		}
	}
}
