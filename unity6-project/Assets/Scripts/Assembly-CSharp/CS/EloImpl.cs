using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008FA")]
	public class EloImpl
	{
		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x8")]
		private SeasonELO Elo__BackingField;

		[Token(Token = "0x4002B68")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<RankType, SeasonELO> EloLadderList__BackingField;

		[Token(Token = "0x170009B2")]
		public SeasonELO Elo
		{
			[Token(Token = "0x60047F7")]
			[Address(RVA = "0x1CDBC50", Offset = "0x1CDBC50", VA = "0x1CDBC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047F8")]
			[Address(RVA = "0x1CDBC40", Offset = "0x1CDBC40", VA = "0x1CDBC40")]
			set
			{
			}
		}

		[Token(Token = "0x170009B3")]
		public Dictionary<RankType, SeasonELO> EloLadderList
		{
			[Token(Token = "0x60047F9")]
			[Address(RVA = "0x1CDBC58", Offset = "0x1CDBC58", VA = "0x1CDBC58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047FA")]
			[Address(RVA = "0x1CDBC48", Offset = "0x1CDBC48", VA = "0x1CDBC48")]
			set
			{
			}
		}

		[Token(Token = "0x60047F6")]
		[Address(RVA = "0x1CDBB70", Offset = "0x1CDBB70", VA = "0x1CDBB70")]
		public EloImpl()
		{
		}

		[Token(Token = "0x60047FB")]
		[Address(RVA = "0x1CDBC60", Offset = "0x1CDBC60", VA = "0x1CDBC60")]
		public SeasonELO GetNormalELO()
		{
			return null;
		}

		[Token(Token = "0x60047FC")]
		[Address(RVA = "0x1CDBC68", Offset = "0x1CDBC68", VA = "0x1CDBC68")]
		public bool TryGetValue(RankType rankType, out SeasonELO elo)
		{
			elo = default;
			return default(bool);
		}

		[Token(Token = "0x60047FD")]
		[Address(RVA = "0x1CDBD28", Offset = "0x1CDBD28", VA = "0x1CDBD28")]
		public void SetSeasonELO(RankType rankType, SeasonELO _ELO)
		{
		}

		[Token(Token = "0x60047FE")]
		[Address(RVA = "0x1CDBE5C", Offset = "0x1CDBE5C", VA = "0x1CDBE5C")]
		public void Remove(RankType rankType)
		{
		}
	}
}
