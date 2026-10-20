using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20007ED")]
	public class XNetProcess_SyncUserData : XNetProcess_GameBase
	{
		[Token(Token = "0x170008D7")]
		public override string Name
		{
			[Token(Token = "0x6003F9E")]
			[Address(RVA = "0x21F088C", Offset = "0x21F088C", VA = "0x21F088C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x21F06A4", Offset = "0x21F06A4", VA = "0x21F06A4")]
		public XNetProcess_SyncUserData()
		{
		}

		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x21F06AC", Offset = "0x21F06AC", VA = "0x21F06AC", Slot = "8")]
		protected override Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x21F0768", Offset = "0x21F0768", VA = "0x21F0768", Slot = "9")]
		protected override CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x21F0904", Offset = "0x21F0904", VA = "0x21F0904", Slot = "12")]
		public override void Work()
		{
		}

		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x21F090C", Offset = "0x21F090C", VA = "0x21F090C", Slot = "10")]
		protected override bool HandleResponse_User()
		{
			return default(bool);
		}
	}
}
