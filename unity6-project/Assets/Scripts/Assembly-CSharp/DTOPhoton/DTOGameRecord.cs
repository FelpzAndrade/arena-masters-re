using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

namespace DTOPhoton
{
	[Token(Token = "0x2000839")]
	public class DTOGameRecord
	{
		[Token(Token = "0x200083A")]
		private sealed class _003CCleanGarbageRecord_003Ec__AnonStorey143
		{
			[Token(Token = "0x40023A5")]
			[FieldOffset(Offset = "0x8")]
			internal List<string> allPlayer;

			[Token(Token = "0x60041E7")]
			[Address(RVA = "0x1E65EF8", Offset = "0x1E65EF8", VA = "0x1E65EF8")]
			public _003CCleanGarbageRecord_003Ec__AnonStorey143()
			{
			}

			[Token(Token = "0x60041E8")]
			[Address(RVA = "0x1E65F00", Offset = "0x1E65F00", VA = "0x1E65F00")]
			internal bool _003C_003Em__1D9(string item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, PlayerGameRecord> Records__BackingField;

		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, XTeamEnum> RoundResult__BackingField;

		[Token(Token = "0x17000932")]
		public Dictionary<string, PlayerGameRecord> Records
		{
			[Token(Token = "0x60041E1")]
			[Address(RVA = "0x1E65B0C", Offset = "0x1E65B0C", VA = "0x1E65B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041E2")]
			[Address(RVA = "0x1E65AD4", Offset = "0x1E65AD4", VA = "0x1E65AD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000933")]
		public Dictionary<int, XTeamEnum> RoundResult
		{
			[Token(Token = "0x60041E3")]
			[Address(RVA = "0x1E65B14", Offset = "0x1E65B14", VA = "0x1E65B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041E4")]
			[Address(RVA = "0x1E65ADC", Offset = "0x1E65ADC", VA = "0x1E65ADC")]
			private set
			{
			}
		}

		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x1E659F4", Offset = "0x1E659F4", VA = "0x1E659F4")]
		public DTOGameRecord()
		{
		}

		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x1E65AE4", Offset = "0x1E65AE4", VA = "0x1E65AE4")]
		public DTOGameRecord(Dictionary<string, PlayerGameRecord> dicRecord, Dictionary<int, XTeamEnum> roundResult)
		{
		}

		[Token(Token = "0x60041E5")]
		[Address(RVA = "0x1E65B1C", Offset = "0x1E65B1C", VA = "0x1E65B1C")]
		public void BuildEmptyRecord(List<string> players)
		{
		}

		[Token(Token = "0x60041E6")]
		[Address(RVA = "0x1E65CC8", Offset = "0x1E65CC8", VA = "0x1E65CC8")]
		public void CleanGarbageRecord(List<string> allPlayer)
		{
		}
	}
}
