using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AD6")]
	public class CSHotTimeEventList
	{
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<int, CSEventSystemInfo> List;

		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0xC")]
		private int LastIncreasedId__BackingField;

		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x10")]
		private long LastTick__BackingField;

		[Token(Token = "0x17000B3B")]
		public int LastIncreasedId
		{
			[Token(Token = "0x6004F5F")]
			[Address(RVA = "0x2234D34", Offset = "0x2234D34", VA = "0x2234D34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F60")]
			[Address(RVA = "0x2234D3C", Offset = "0x2234D3C", VA = "0x2234D3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000B3C")]
		public long LastTick
		{
			[Token(Token = "0x6004F61")]
			[Address(RVA = "0x2234D44", Offset = "0x2234D44", VA = "0x2234D44")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004F62")]
			[Address(RVA = "0x2234D4C", Offset = "0x2234D4C", VA = "0x2234D4C")]
			set
			{
			}
		}

		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x2234C88", Offset = "0x2234C88", VA = "0x2234C88")]
		public CSHotTimeEventList()
		{
		}

		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x2234D5C", Offset = "0x2234D5C", VA = "0x2234D5C")]
		public bool CookingAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F64")]
		[Address(RVA = "0x2234EC0", Offset = "0x2234EC0", VA = "0x2234EC0")]
		public bool TryGetHotTimeEventInfo(DateTime serverNowLocalTime, out CSEventSystemInfo eventSystemInfo, HottimeEventType Type = HottimeEventType.None)
		{
			eventSystemInfo = default;
			return default(bool);
		}

		[Token(Token = "0x6004F65")]
		[Address(RVA = "0x22355B8", Offset = "0x22355B8", VA = "0x22355B8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004F66")]
		[Address(RVA = "0x223564C", Offset = "0x223564C", VA = "0x223564C")]
		public void Reset()
		{
		}
	}
}
