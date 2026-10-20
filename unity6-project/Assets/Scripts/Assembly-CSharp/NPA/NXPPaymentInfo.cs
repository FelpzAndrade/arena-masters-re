using System.Collections.Generic;
using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010B6")]
	public class NXPPaymentInfo
	{
		[Token(Token = "0x4005C6D")]
		[FieldOffset(Offset = "0x8")]
		private string productId;

		[Token(Token = "0x4005C6E")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, string> meta;

		[Token(Token = "0x4005C6F")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> servicePayload;

		[Token(Token = "0x4005C70")]
		[FieldOffset(Offset = "0x14")]
		private string itemId;

		[Token(Token = "0x4005C71")]
		[FieldOffset(Offset = "0x18")]
		private string characterId;

		[Token(Token = "0x17000F6D")]
		public string ProductId
		{
			[Token(Token = "0x6007DFC")]
			[Address(RVA = "0x11DECB0", Offset = "0x11DECB0", VA = "0x11DECB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007DFD")]
			[Address(RVA = "0x11DECB8", Offset = "0x11DECB8", VA = "0x11DECB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000F6E")]
		public Dictionary<string, string> Meta
		{
			[Token(Token = "0x6007DFE")]
			[Address(RVA = "0x11DECC0", Offset = "0x11DECC0", VA = "0x11DECC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007DFF")]
			[Address(RVA = "0x11D4660", Offset = "0x11D4660", VA = "0x11D4660")]
			set
			{
			}
		}

		[Token(Token = "0x17000F6F")]
		public Dictionary<string, string> ServicePayload
		{
			[Token(Token = "0x6007E00")]
			[Address(RVA = "0x11DECC8", Offset = "0x11DECC8", VA = "0x11DECC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007E01")]
			[Address(RVA = "0x11D4960", Offset = "0x11D4960", VA = "0x11D4960")]
			set
			{
			}
		}

		[Token(Token = "0x17000F70")]
		public string ItemId
		{
			[Token(Token = "0x6007E02")]
			[Address(RVA = "0x11DECD0", Offset = "0x11DECD0", VA = "0x11DECD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007E03")]
			[Address(RVA = "0x11DECD8", Offset = "0x11DECD8", VA = "0x11DECD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000F71")]
		public string CharacterId
		{
			[Token(Token = "0x6007E04")]
			[Address(RVA = "0x11DECE0", Offset = "0x11DECE0", VA = "0x11DECE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007E05")]
			[Address(RVA = "0x11DECE8", Offset = "0x11DECE8", VA = "0x11DECE8")]
			set
			{
			}
		}

		[Token(Token = "0x6007DFB")]
		[Address(RVA = "0x11D4640", Offset = "0x11D4640", VA = "0x11D4640")]
		public NXPPaymentInfo(string productId)
		{
		}

		[Token(Token = "0x6007E06")]
		[Address(RVA = "0x11DECF0", Offset = "0x11DECF0", VA = "0x11DECF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
