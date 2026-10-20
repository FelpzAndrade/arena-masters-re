using System;
using Il2CppDummyDll;

namespace PigeonCoopToolkit.Generic
{
	[Serializable]
	[Token(Token = "0x2000340")]
	public class VersionInformation
	{
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0xC")]
		public int Major;

		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x10")]
		public int Minor;

		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x14")]
		public int Patch;

		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x1BB2D0C", Offset = "0x1BB2D0C", VA = "0x1BB2D0C")]
		public VersionInformation(string name, int major, int minor, int patch)
		{
		}

		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x1BB2D50", Offset = "0x1BB2D50", VA = "0x1BB2D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x1BB2FE8", Offset = "0x1BB2FE8", VA = "0x1BB2FE8")]
		public bool Match(VersionInformation other, bool looseMatch)
		{
			return default(bool);
		}
	}
}
