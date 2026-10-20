using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000958")]
	public class ExpireNode
	{
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x8")]
		private ExpireType Type__BackingField;

		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0xC")]
		private int Id__BackingField;

		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0x10")]
		private int Value__BackingField;

		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x18")]
		private long ExpireTick__BackingField;

		[Token(Token = "0x17000A7A")]
		public ExpireType Type
		{
			[Token(Token = "0x6004B2F")]
			[Address(RVA = "0x1CE0A48", Offset = "0x1CE0A48", VA = "0x1CE0A48")]
			get
			{
				return default(ExpireType);
			}
			[Token(Token = "0x6004B30")]
			[Address(RVA = "0x1CE1124", Offset = "0x1CE1124", VA = "0x1CE1124")]
			set
			{
			}
		}

		[Token(Token = "0x17000A7B")]
		public int Id
		{
			[Token(Token = "0x6004B31")]
			[Address(RVA = "0x1CE0FCC", Offset = "0x1CE0FCC", VA = "0x1CE0FCC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B32")]
			[Address(RVA = "0x1CE112C", Offset = "0x1CE112C", VA = "0x1CE112C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A7C")]
		public int Value
		{
			[Token(Token = "0x6004B33")]
			[Address(RVA = "0x1CE1178", Offset = "0x1CE1178", VA = "0x1CE1178")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B34")]
			[Address(RVA = "0x1CE1134", Offset = "0x1CE1134", VA = "0x1CE1134")]
			set
			{
			}
		}

		[Token(Token = "0x17000A7D")]
		public long ExpireTick
		{
			[Token(Token = "0x6004B35")]
			[Address(RVA = "0x1CE1200", Offset = "0x1CE1200", VA = "0x1CE1200")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004B36")]
			[Address(RVA = "0x1CE1208", Offset = "0x1CE1208", VA = "0x1CE1208")]
			set
			{
			}
		}

		[Token(Token = "0x17000A7E")]
		[JsonIgnore]
		public DateTime ExpireAt
		{
			[Token(Token = "0x6004B37")]
			[Address(RVA = "0x1CE0A50", Offset = "0x1CE0A50", VA = "0x1CE0A50")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004B38")]
			[Address(RVA = "0x1CE113C", Offset = "0x1CE113C", VA = "0x1CE113C")]
			set
			{
			}
		}

		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x1CE111C", Offset = "0x1CE111C", VA = "0x1CE111C")]
		public ExpireNode()
		{
		}
	}
}
