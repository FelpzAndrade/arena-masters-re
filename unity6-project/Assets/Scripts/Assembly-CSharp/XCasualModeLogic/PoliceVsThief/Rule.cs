using System.Collections.Generic;
using Il2CppDummyDll;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x200053A")]
	public class Rule
	{
		[Token(Token = "0x6002CAB")]
		[Address(RVA = "0x1AAAD10", Offset = "0x1AAAD10", VA = "0x1AAAD10")]
		public Rule()
		{
		}

		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x1AB4EF4", Offset = "0x1AB4EF4", VA = "0x1AB4EF4")]
		private bool IsAllThiefsArrested(List<IThief> thiefs)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x1AACC84", Offset = "0x1AACC84", VA = "0x1AACC84")]
		public bool IsPoliceWin(List<IThief> thiefs)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x1AB5090", Offset = "0x1AB5090", VA = "0x1AB5090")]
		private bool IsAllDead(List<IPolice> police)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x1AAC608", Offset = "0x1AAC608", VA = "0x1AAC608")]
		public int AliveCount(List<IPolice> police)
		{
			return default(int);
		}

		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x1AAC468", Offset = "0x1AAC468", VA = "0x1AAC468")]
		public int GetTotalKeyCount(List<IThief> thiefs)
		{
			return default(int);
		}

		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x1AACC44", Offset = "0x1AACC44", VA = "0x1AACC44")]
		public bool IsThiefWin(List<IPolice> police, List<IThief> thiefs, int totalKeyCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x1AAC290", Offset = "0x1AAC290", VA = "0x1AAC290")]
		public bool IsGameEnd(List<IPolice> police, List<IThief> thiefs, int totalKeyCount)
		{
			return default(bool);
		}
	}
}
