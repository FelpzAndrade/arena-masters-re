using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20007EF")]
	public class XNetProcess_SyncItems : XNetProcess_GameBase
	{
		[Token(Token = "0x170008D9")]
		public override string Name
		{
			[Token(Token = "0x6003FAA")]
			[Address(RVA = "0x21F0444", Offset = "0x21F0444", VA = "0x21F0444", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x21F025C", Offset = "0x21F025C", VA = "0x21F025C")]
		public XNetProcess_SyncItems()
		{
		}

		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x21F0264", Offset = "0x21F0264", VA = "0x21F0264", Slot = "8")]
		protected override Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x21F0320", Offset = "0x21F0320", VA = "0x21F0320", Slot = "9")]
		protected override CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x21F04BC", Offset = "0x21F04BC", VA = "0x21F04BC", Slot = "12")]
		public override void Work()
		{
		}

		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x21F04C4", Offset = "0x21F04C4", VA = "0x21F04C4", Slot = "10")]
		protected override bool HandleResponse_User()
		{
			return default(bool);
		}
	}
}
