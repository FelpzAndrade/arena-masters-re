using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20007EE")]
	public class XNetProcess_SyncUserResource : XNetProcess_GameBase
	{
		[Token(Token = "0x170008D8")]
		public override string Name
		{
			[Token(Token = "0x6003FA4")]
			[Address(RVA = "0x21F0CD4", Offset = "0x21F0CD4", VA = "0x21F0CD4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x21F0AEC", Offset = "0x21F0AEC", VA = "0x21F0AEC")]
		public XNetProcess_SyncUserResource()
		{
		}

		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x21F0AF4", Offset = "0x21F0AF4", VA = "0x21F0AF4", Slot = "8")]
		protected override Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x6003FA3")]
		[Address(RVA = "0x21F0BB0", Offset = "0x21F0BB0", VA = "0x21F0BB0", Slot = "9")]
		protected override CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x21F0D4C", Offset = "0x21F0D4C", VA = "0x21F0D4C", Slot = "12")]
		public override void Work()
		{
		}

		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x21F0D54", Offset = "0x21F0D54", VA = "0x21F0D54", Slot = "10")]
		protected override bool HandleResponse_User()
		{
			return default(bool);
		}
	}
}
