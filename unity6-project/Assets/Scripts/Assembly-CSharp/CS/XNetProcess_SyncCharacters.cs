using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20007F0")]
	public class XNetProcess_SyncCharacters : XNetProcess_GameBase
	{
		[Token(Token = "0x170008DA")]
		public override string Name
		{
			[Token(Token = "0x6003FB0")]
			[Address(RVA = "0x21EFFFC", Offset = "0x21EFFFC", VA = "0x21EFFFC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x21EFE14", Offset = "0x21EFE14", VA = "0x21EFE14")]
		public XNetProcess_SyncCharacters()
		{
		}

		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x21EFE1C", Offset = "0x21EFE1C", VA = "0x21EFE1C", Slot = "8")]
		protected override Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x21EFED8", Offset = "0x21EFED8", VA = "0x21EFED8", Slot = "9")]
		protected override CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x21F0074", Offset = "0x21F0074", VA = "0x21F0074", Slot = "12")]
		public override void Work()
		{
		}

		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x21F007C", Offset = "0x21F007C", VA = "0x21F007C", Slot = "10")]
		protected override bool HandleResponse_User()
		{
			return default(bool);
		}
	}
}
