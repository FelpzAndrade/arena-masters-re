using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000892")]
	public class PlayerGameRecord : IDisposable, CSPoolEntry
	{
		[Token(Token = "0x4002A19")]
		[FieldOffset(Offset = "0x8")]
		public short hit;

		[Token(Token = "0x4002A1A")]
		[FieldOffset(Offset = "0xA")]
		public short kill;

		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0xC")]
		public short death;

		[Token(Token = "0x4002A1C")]
		[FieldOffset(Offset = "0xE")]
		public short assist;

		[Token(Token = "0x4002A1D")]
		[FieldOffset(Offset = "0x10")]
		public short box;

		[Token(Token = "0x4002A1E")]
		[FieldOffset(Offset = "0x12")]
		public short killZombieCount;

		[Token(Token = "0x4002A1F")]
		[FieldOffset(Offset = "0x14")]
		public short tagZombieToHumanCount;

		[Token(Token = "0x4002A20")]
		[FieldOffset(Offset = "0x16")]
		public short zombieInfectCnt;

		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x18")]
		public short survivePoint;

		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x1C")]
		public CSPlayerState lastState;

		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x20")]
		public bool IsEscape;

		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x22")]
		public short hpRatio;

		[Token(Token = "0x4002A25")]
		[FieldOffset(Offset = "0x24")]
		public bool IsExitDuringTheGame;

		[Token(Token = "0x60045D2")]
		[Address(RVA = "0x21AE2FC", Offset = "0x21AE2FC", VA = "0x21AE2FC")]
		public PlayerGameRecord()
		{
		}

		[Token(Token = "0x60045D3")]
		[Address(RVA = "0x21AE30C", Offset = "0x21AE30C", VA = "0x21AE30C", Slot = "5")]
		public void OnCleanupInObjectPool()
		{
		}

		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x21AE338", Offset = "0x21AE338", VA = "0x21AE338", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
