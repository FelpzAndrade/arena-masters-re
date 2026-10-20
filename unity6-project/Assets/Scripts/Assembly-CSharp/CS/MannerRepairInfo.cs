using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000968")]
	public class MannerRepairInfo
	{
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x8")]
		private long LastTimeTick__BackingField;

		[Token(Token = "0x4002E89")]
		[FieldOffset(Offset = "0x10")]
		private int LastSeason__BackingField;

		[Token(Token = "0x17000AB5")]
		public long LastTimeTick
		{
			[Token(Token = "0x6004BC6")]
			[Address(RVA = "0x233B65C", Offset = "0x233B65C", VA = "0x233B65C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004BC7")]
			[Address(RVA = "0x233B664", Offset = "0x233B664", VA = "0x233B664")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AB6")]
		public int LastSeason
		{
			[Token(Token = "0x6004BC8")]
			[Address(RVA = "0x233B674", Offset = "0x233B674", VA = "0x233B674")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BC9")]
			[Address(RVA = "0x233B67C", Offset = "0x233B67C", VA = "0x233B67C")]
			private set
			{
			}
		}

		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x233B654", Offset = "0x233B654", VA = "0x233B654")]
		public MannerRepairInfo()
		{
		}

		[Token(Token = "0x6004BCA")]
		[Address(RVA = "0x233B684", Offset = "0x233B684", VA = "0x233B684")]
		public void Update(int season, DateTime localTime)
		{
		}
	}
}
