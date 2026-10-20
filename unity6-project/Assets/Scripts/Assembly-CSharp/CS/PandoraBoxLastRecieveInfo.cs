using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200096E")]
	public class PandoraBoxLastRecieveInfo
	{
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x8")]
		public long LastLocalTimeStamp;

		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x10")]
		public int LastRecieveID;

		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x14")]
		private int LastSeason__BackingField;

		[Token(Token = "0x17000AD0")]
		public int LastSeason
		{
			[Token(Token = "0x6004C04")]
			[Address(RVA = "0x21AD854", Offset = "0x21AD854", VA = "0x21AD854")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C05")]
			[Address(RVA = "0x21AD85C", Offset = "0x21AD85C", VA = "0x21AD85C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x21AD844", Offset = "0x21AD844", VA = "0x21AD844")]
		public PandoraBoxLastRecieveInfo()
		{
		}

		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x21AD864", Offset = "0x21AD864", VA = "0x21AD864")]
		public bool IsRecieved(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x21AD878", Offset = "0x21AD878", VA = "0x21AD878")]
		public void Record(int id, DateTime localTime)
		{
		}

		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x21AD8BC", Offset = "0x21AD8BC", VA = "0x21AD8BC")]
		public void Reset(int Season, DateTime localTime)
		{
		}
	}
}
