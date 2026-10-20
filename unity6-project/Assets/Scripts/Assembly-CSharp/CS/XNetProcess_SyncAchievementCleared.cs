using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20007F1")]
	public class XNetProcess_SyncAchievementCleared : XNetProcess_GameBase
	{
		[Token(Token = "0x170008DB")]
		public override string Name
		{
			[Token(Token = "0x6003FB6")]
			[Address(RVA = "0x21EF76C", Offset = "0x21EF76C", VA = "0x21EF76C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x21EF584", Offset = "0x21EF584", VA = "0x21EF584")]
		public XNetProcess_SyncAchievementCleared()
		{
		}

		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x21EF58C", Offset = "0x21EF58C", VA = "0x21EF58C", Slot = "8")]
		protected override Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x21EF648", Offset = "0x21EF648", VA = "0x21EF648", Slot = "9")]
		protected override CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x21EF7E4", Offset = "0x21EF7E4", VA = "0x21EF7E4", Slot = "12")]
		public override void Work()
		{
		}

		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x21EF7EC", Offset = "0x21EF7EC", VA = "0x21EF7EC", Slot = "10")]
		protected override bool HandleResponse_User()
		{
			return default(bool);
		}
	}
}
