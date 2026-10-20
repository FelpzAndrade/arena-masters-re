using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A0B")]
	public class CSMailData
	{
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x8")]
		public CSContent[] Contents;

		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0xC")]
		public string UID;

		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0x10")]
		public string SenderAID;

		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x14")]
		public string SenderName;

		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0x1C")]
		public string Count;

		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;

		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x28")]
		public long SendTime;

		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x30")]
		public long ExpiredTime;

		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x38")]
		public MailType Type;

		[Token(Token = "0x6004D4E")]
		[Address(RVA = "0x2238BA0", Offset = "0x2238BA0", VA = "0x2238BA0")]
		public CSMailData()
		{
		}

		[Token(Token = "0x6004D4F")]
		[Address(RVA = "0x2238BA8", Offset = "0x2238BA8", VA = "0x2238BA8")]
		public bool IsUnlimited()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x2238BBC", Offset = "0x2238BBC", VA = "0x2238BBC")]
		public bool IsEnablePopMailAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x2238BD0", Offset = "0x2238BD0", VA = "0x2238BD0")]
		public bool IsNotiMail()
		{
			return default(bool);
		}

		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x2238BE4", Offset = "0x2238BE4", VA = "0x2238BE4")]
		public bool IsExpired(long utcNow)
		{
			return default(bool);
		}
	}
}
