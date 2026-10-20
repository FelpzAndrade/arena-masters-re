using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A35")]
	public class Netdata_Acquisitions
	{
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x8")]
		public List<CSContent> contents;

		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0xC")]
		public bool toMail;

		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0x10")]
		public int characterToSoulstone;

		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0x14")]
		public int skinToArenacoin;

		[Token(Token = "0x6004D89")]
		[Address(RVA = "0x233E3DC", Offset = "0x233E3DC", VA = "0x233E3DC")]
		public Netdata_Acquisitions()
		{
		}
	}
}
