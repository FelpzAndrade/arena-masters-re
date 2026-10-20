using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	[Token(Token = "0x200013F")]
	public sealed class DataMemberAttribute : Attribute
	{
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x8")]
		private bool is_required;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x9")]
		private bool emit_default;

		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0xC")]
		private string name;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x10")]
		private int order;

		[Token(Token = "0x17000211")]
		public bool EmitDefaultValue
		{
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x1D4953C", Offset = "0x1D4953C", VA = "0x1D4953C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x1D49544", Offset = "0x1D49544", VA = "0x1D49544")]
			set
			{
			}
		}

		[Token(Token = "0x17000212")]
		public bool IsRequired
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x1D4954C", Offset = "0x1D4954C", VA = "0x1D4954C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x1D49554", Offset = "0x1D49554", VA = "0x1D49554")]
			set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public string Name
		{
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x1D4955C", Offset = "0x1D4955C", VA = "0x1D4955C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x1D49564", Offset = "0x1D49564", VA = "0x1D49564")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		public int Order
		{
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x1D4956C", Offset = "0x1D4956C", VA = "0x1D4956C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x1D49574", Offset = "0x1D49574", VA = "0x1D49574")]
			set
			{
			}
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x1D49524", Offset = "0x1D49524", VA = "0x1D49524")]
		public DataMemberAttribute()
		{
		}
	}
}
