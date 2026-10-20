using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x20008F7")]
	public class UserMetaData2
	{
		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x8")]
		private string Name__BackingField;

		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0xC")]
		private int Level__BackingField;

		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x10")]
		private int CombatPower__BackingField;

		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x14")]
		private int ProfileIconID__BackingField;

		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x18")]
		private int TitleId__BackingField;

		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x20")]
		private DateTime LastLoginTime__BackingField;

		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x30")]
		private DateTime LastLogoutTime__BackingField;

		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x40")]
		private string npacode__BackingField;

		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x44")]
		private string Country__BackingField;

		[Token(Token = "0x170009A2")]
		public string Name
		{
			[Token(Token = "0x60047D6")]
			[Address(RVA = "0x21EE8DC", Offset = "0x21EE8DC", VA = "0x21EE8DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D7")]
			[Address(RVA = "0x21EE8E4", Offset = "0x21EE8E4", VA = "0x21EE8E4")]
			set
			{
			}
		}

		[Token(Token = "0x170009A3")]
		public int Level
		{
			[Token(Token = "0x60047D8")]
			[Address(RVA = "0x21EE8EC", Offset = "0x21EE8EC", VA = "0x21EE8EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60047D9")]
			[Address(RVA = "0x21EE8F4", Offset = "0x21EE8F4", VA = "0x21EE8F4")]
			set
			{
			}
		}

		[Token(Token = "0x170009A4")]
		public int CombatPower
		{
			[Token(Token = "0x60047DA")]
			[Address(RVA = "0x21EE8FC", Offset = "0x21EE8FC", VA = "0x21EE8FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60047DB")]
			[Address(RVA = "0x21EE904", Offset = "0x21EE904", VA = "0x21EE904")]
			set
			{
			}
		}

		[Token(Token = "0x170009A5")]
		public int ProfileIconID
		{
			[Token(Token = "0x60047DC")]
			[Address(RVA = "0x21EE90C", Offset = "0x21EE90C", VA = "0x21EE90C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60047DD")]
			[Address(RVA = "0x21EE914", Offset = "0x21EE914", VA = "0x21EE914")]
			set
			{
			}
		}

		[Token(Token = "0x170009A6")]
		public int TitleId
		{
			[Token(Token = "0x60047DE")]
			[Address(RVA = "0x21EE91C", Offset = "0x21EE91C", VA = "0x21EE91C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60047DF")]
			[Address(RVA = "0x21EE924", Offset = "0x21EE924", VA = "0x21EE924")]
			set
			{
			}
		}

		[Token(Token = "0x170009A7")]
		public DateTime LastLoginTime
		{
			[Token(Token = "0x60047E0")]
			[Address(RVA = "0x21EE92C", Offset = "0x21EE92C", VA = "0x21EE92C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60047E1")]
			[Address(RVA = "0x21EE93C", Offset = "0x21EE93C", VA = "0x21EE93C")]
			set
			{
			}
		}

		[Token(Token = "0x170009A8")]
		public DateTime LastLogoutTime
		{
			[Token(Token = "0x60047E2")]
			[Address(RVA = "0x21EE954", Offset = "0x21EE954", VA = "0x21EE954")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60047E3")]
			[Address(RVA = "0x21EE964", Offset = "0x21EE964", VA = "0x21EE964")]
			set
			{
			}
		}

		[Token(Token = "0x170009A9")]
		public string npacode
		{
			[Token(Token = "0x60047E4")]
			[Address(RVA = "0x21EE97C", Offset = "0x21EE97C", VA = "0x21EE97C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x21EE984", Offset = "0x21EE984", VA = "0x21EE984")]
			set
			{
			}
		}

		[Token(Token = "0x170009AA")]
		[JsonIgnore]
		public virtual bool IsLogin
		{
			[Token(Token = "0x60047E6")]
			[Address(RVA = "0x21EE98C", Offset = "0x21EE98C", VA = "0x21EE98C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009AB")]
		public string Country
		{
			[Token(Token = "0x60047E7")]
			[Address(RVA = "0x21EEAB8", Offset = "0x21EEAB8", VA = "0x21EEAB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047E8")]
			[Address(RVA = "0x21EEAC0", Offset = "0x21EEAC0", VA = "0x21EEAC0")]
			set
			{
			}
		}

		[Token(Token = "0x60047D5")]
		[Address(RVA = "0x21EE8D4", Offset = "0x21EE8D4", VA = "0x21EE8D4")]
		public UserMetaData2()
		{
		}
	}
}
