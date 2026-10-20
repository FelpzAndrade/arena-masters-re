using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000959")]
	public class ExpireList
	{
		[Token(Token = "0x200095A")]
		private sealed class _003CClearType_003Ec__AnonStorey150
		{
			[Token(Token = "0x4002E53")]
			[FieldOffset(Offset = "0x8")]
			internal ExpireType TargetType;

			[Token(Token = "0x6004B43")]
			[Address(RVA = "0x1CE05DC", Offset = "0x1CE05DC", VA = "0x1CE05DC")]
			public _003CClearType_003Ec__AnonStorey150()
			{
			}

			[Token(Token = "0x6004B44")]
			[Address(RVA = "0x1CE1180", Offset = "0x1CE1180", VA = "0x1CE1180")]
			internal bool _003C_003Em__1F7(ExpireNode x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200095B")]
		private sealed class _003CRemove_003Ec__AnonStorey151
		{
			[Token(Token = "0x4002E54")]
			[FieldOffset(Offset = "0x8")]
			internal ExpireType TargetType;

			[Token(Token = "0x4002E55")]
			[FieldOffset(Offset = "0xC")]
			internal int Id;

			[Token(Token = "0x6004B45")]
			[Address(RVA = "0x1CE071C", Offset = "0x1CE071C", VA = "0x1CE071C")]
			public _003CRemove_003Ec__AnonStorey151()
			{
			}

			[Token(Token = "0x6004B46")]
			[Address(RVA = "0x1CE11B4", Offset = "0x1CE11B4", VA = "0x1CE11B4")]
			internal bool _003C_003Em__1F8(ExpireNode x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0x8")]
		public List<ExpireNode> AllList;

		[Token(Token = "0x17000A7F")]
		public int Count
		{
			[Token(Token = "0x6004B3E")]
			[Address(RVA = "0x1CE0A80", Offset = "0x1CE0A80", VA = "0x1CE0A80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x1CE0400", Offset = "0x1CE0400", VA = "0x1CE0400")]
		public ExpireList()
		{
		}

		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x1CE04AC", Offset = "0x1CE04AC", VA = "0x1CE04AC")]
		public void ClearType(ExpireType TargetType)
		{
		}

		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x1CE05E4", Offset = "0x1CE05E4", VA = "0x1CE05E4")]
		public void Remove(ExpireType TargetType, int Id)
		{
		}

		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x1CE0724", Offset = "0x1CE0724", VA = "0x1CE0724")]
		public List<ExpireNode> GetList(ExpireType Type)
		{
			return null;
		}

		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x1CE07F8", Offset = "0x1CE07F8", VA = "0x1CE07F8")]
		public List<ExpireNode> GetList(ExpireType Type, DateTime UtcNow)
		{
			return null;
		}

		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x1CE0B18", Offset = "0x1CE0B18", VA = "0x1CE0B18")]
		public void CleanUp(DateTime UtcNow)
		{
		}

		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x1CE0CFC", Offset = "0x1CE0CFC", VA = "0x1CE0CFC")]
		public ExpireNode Get(ExpireType Type, int Id, bool CleanUp = false)
		{
			return null;
		}

		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x1CE0DD4", Offset = "0x1CE0DD4", VA = "0x1CE0DD4")]
		public ExpireNode Get(ExpireType Type, int Id, DateTime utcnow, bool CleanUp = false)
		{
			return null;
		}

		[Token(Token = "0x6004B42")]
		[Address(RVA = "0x1CE0FD4", Offset = "0x1CE0FD4", VA = "0x1CE0FD4")]
		public int Increase(ExpireType Type, int Id, DateTime ExpireAt, int Amount = 1)
		{
			return default(int);
		}
	}
}
