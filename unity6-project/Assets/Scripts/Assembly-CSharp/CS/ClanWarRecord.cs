using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000960")]
	public class ClanWarRecord : IncreasableDictionary<ClanWarRecordType>
	{
		[Token(Token = "0x17000A86")]
		[JsonIgnore]
		public int Win
		{
			[Token(Token = "0x6004B5D")]
			[Address(RVA = "0x23EC0B8", Offset = "0x23EC0B8", VA = "0x23EC0B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A87")]
		[JsonIgnore]
		public int Lose
		{
			[Token(Token = "0x6004B5E")]
			[Address(RVA = "0x23EC144", Offset = "0x23EC144", VA = "0x23EC144")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A88")]
		[JsonIgnore]
		public int Draw
		{
			[Token(Token = "0x6004B5F")]
			[Address(RVA = "0x23EC1D0", Offset = "0x23EC1D0", VA = "0x23EC1D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A89")]
		[JsonIgnore]
		public int CurrentConsecutiveWin
		{
			[Token(Token = "0x6004B60")]
			[Address(RVA = "0x23EC25C", Offset = "0x23EC25C", VA = "0x23EC25C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A8A")]
		[JsonIgnore]
		public int CurrentConsecutiveLose
		{
			[Token(Token = "0x6004B61")]
			[Address(RVA = "0x23EC2E8", Offset = "0x23EC2E8", VA = "0x23EC2E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A8B")]
		[JsonIgnore]
		public int WinRate
		{
			[Token(Token = "0x6004B62")]
			[Address(RVA = "0x23EC374", Offset = "0x23EC374", VA = "0x23EC374")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000A8C")]
		[JsonIgnore]
		public int TotalWarCount
		{
			[Token(Token = "0x6004B63")]
			[Address(RVA = "0x23EC400", Offset = "0x23EC400", VA = "0x23EC400")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x23EBE88", Offset = "0x23EBE88", VA = "0x23EBE88")]
		public ClanWarRecord()
		{
		}

		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x23EC4C0", Offset = "0x23EC4C0", VA = "0x23EC4C0")]
		public void Copy(ClanWarRecord record)
		{
		}
	}
}
