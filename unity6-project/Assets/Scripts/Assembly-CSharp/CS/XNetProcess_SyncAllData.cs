using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20007EC")]
	public class XNetProcess_SyncAllData : XNetProcess_GameBase
	{
		[Token(Token = "0x170008D6")]
		public override string Name
		{
			[Token(Token = "0x6003F98")]
			[Address(RVA = "0x21EFBB4", Offset = "0x21EFBB4", VA = "0x21EFBB4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x21EF9CC", Offset = "0x21EF9CC", VA = "0x21EF9CC")]
		public XNetProcess_SyncAllData()
		{
		}

		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x21EF9D4", Offset = "0x21EF9D4", VA = "0x21EF9D4", Slot = "8")]
		protected override Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x21EFA90", Offset = "0x21EFA90", VA = "0x21EFA90", Slot = "9")]
		protected override CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x21EFC2C", Offset = "0x21EFC2C", VA = "0x21EFC2C", Slot = "12")]
		public override void Work()
		{
		}

		[Token(Token = "0x6003F9A")]
		[Address(RVA = "0x21EFC34", Offset = "0x21EFC34", VA = "0x21EFC34", Slot = "10")]
		protected override bool HandleResponse_User()
		{
			return default(bool);
		}
	}
}
