using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200091C")]
	public class CharPartyData
	{
		[Token(Token = "0x4002D0D")]
		[FieldOffset(Offset = "0x8")]
		private List<string> Party1__BackingField;

		[Token(Token = "0x4002D0E")]
		[FieldOffset(Offset = "0xC")]
		private List<string> Party2__BackingField;

		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x10")]
		private List<string> Party3__BackingField;

		[Token(Token = "0x170009C3")]
		public List<string> Party1
		{
			[Token(Token = "0x60048CF")]
			[Address(RVA = "0x23E86A0", Offset = "0x23E86A0", VA = "0x23E86A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60048D0")]
			[Address(RVA = "0x23E8688", Offset = "0x23E8688", VA = "0x23E8688")]
			set
			{
			}
		}

		[Token(Token = "0x170009C4")]
		public List<string> Party2
		{
			[Token(Token = "0x60048D1")]
			[Address(RVA = "0x23E86A8", Offset = "0x23E86A8", VA = "0x23E86A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60048D2")]
			[Address(RVA = "0x23E8690", Offset = "0x23E8690", VA = "0x23E8690")]
			set
			{
			}
		}

		[Token(Token = "0x170009C5")]
		public List<string> Party3
		{
			[Token(Token = "0x60048D3")]
			[Address(RVA = "0x23E86B0", Offset = "0x23E86B0", VA = "0x23E86B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60048D4")]
			[Address(RVA = "0x23E8698", Offset = "0x23E8698", VA = "0x23E8698")]
			set
			{
			}
		}

		[Token(Token = "0x60048CE")]
		[Address(RVA = "0x23E85AC", Offset = "0x23E85AC", VA = "0x23E85AC")]
		public CharPartyData()
		{
		}

		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x23E86B8", Offset = "0x23E86B8", VA = "0x23E86B8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x23E8798", Offset = "0x23E8798", VA = "0x23E8798")]
		public void SetParty(CharPartyId charPartyId, List<string> cids)
		{
		}

		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x23E87C4", Offset = "0x23E87C4", VA = "0x23E87C4")]
		public List<string> GetParty(CharPartyId charPartyId)
		{
			return null;
		}
	}
}
