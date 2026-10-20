using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A61")]
	public class LoginFailReason
	{
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x8")]
		private string Reason__BackingField;

		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x10")]
		private long RemainSec__BackingField;

		[Token(Token = "0x17000AFD")]
		public string Reason
		{
			[Token(Token = "0x6004DC3")]
			[Address(RVA = "0x233B0F8", Offset = "0x233B0F8", VA = "0x233B0F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DC4")]
			[Address(RVA = "0x233B100", Offset = "0x233B100", VA = "0x233B100")]
			set
			{
			}
		}

		[Token(Token = "0x17000AFE")]
		public long RemainSec
		{
			[Token(Token = "0x6004DC5")]
			[Address(RVA = "0x233B108", Offset = "0x233B108", VA = "0x233B108")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004DC6")]
			[Address(RVA = "0x233B110", Offset = "0x233B110", VA = "0x233B110")]
			set
			{
			}
		}

		[Token(Token = "0x6004DC2")]
		[Address(RVA = "0x233B0F0", Offset = "0x233B0F0", VA = "0x233B0F0")]
		public LoginFailReason()
		{
		}
	}
}
