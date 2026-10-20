using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010A7")]
	public class NPNotificationData
	{
		[Token(Token = "0x4005A8A")]
		[FieldOffset(Offset = "0x8")]
		private int notificationID__BackingField;

		[Token(Token = "0x4005A8B")]
		[FieldOffset(Offset = "0xC")]
		private string message__BackingField;

		[Token(Token = "0x4005A8C")]
		[FieldOffset(Offset = "0x10")]
		private string meta__BackingField;

		[Token(Token = "0x4005A8D")]
		[FieldOffset(Offset = "0x14")]
		private NPNotificationTime time__BackingField;

		[Token(Token = "0x4005A8E")]
		[FieldOffset(Offset = "0x18")]
		private int pushType__BackingField;

		[Token(Token = "0x4005A8F")]
		[FieldOffset(Offset = "0x1C")]
		private int badgeNumber__BackingField;

		[Token(Token = "0x17000F5F")]
		public int notificationID
		{
			[Token(Token = "0x6007D28")]
			[Address(RVA = "0x11D0124", Offset = "0x11D0124", VA = "0x11D0124")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007D29")]
			[Address(RVA = "0x11DDC04", Offset = "0x11DDC04", VA = "0x11DDC04")]
			set
			{
			}
		}

		[Token(Token = "0x17000F60")]
		public string message
		{
			[Token(Token = "0x6007D2A")]
			[Address(RVA = "0x11D012C", Offset = "0x11D012C", VA = "0x11D012C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007D2B")]
			[Address(RVA = "0x11DDC0C", Offset = "0x11DDC0C", VA = "0x11DDC0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000F61")]
		public string meta
		{
			[Token(Token = "0x6007D2C")]
			[Address(RVA = "0x11D0134", Offset = "0x11D0134", VA = "0x11D0134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007D2D")]
			[Address(RVA = "0x11DDC14", Offset = "0x11DDC14", VA = "0x11DDC14")]
			set
			{
			}
		}

		[Token(Token = "0x17000F62")]
		public NPNotificationTime time
		{
			[Token(Token = "0x6007D2E")]
			[Address(RVA = "0x11D014C", Offset = "0x11D014C", VA = "0x11D014C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007D2F")]
			[Address(RVA = "0x11DDC1C", Offset = "0x11DDC1C", VA = "0x11DDC1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000F63")]
		public int pushType
		{
			[Token(Token = "0x6007D30")]
			[Address(RVA = "0x11D013C", Offset = "0x11D013C", VA = "0x11D013C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007D31")]
			[Address(RVA = "0x11DDC24", Offset = "0x11DDC24", VA = "0x11DDC24")]
			set
			{
			}
		}

		[Token(Token = "0x17000F64")]
		public int badgeNumber
		{
			[Token(Token = "0x6007D32")]
			[Address(RVA = "0x11D0144", Offset = "0x11D0144", VA = "0x11D0144")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007D33")]
			[Address(RVA = "0x11DDC2C", Offset = "0x11DDC2C", VA = "0x11DDC2C")]
			set
			{
			}
		}

		[Token(Token = "0x6007D26")]
		[Address(RVA = "0x11DDBBC", Offset = "0x11DDBBC", VA = "0x11DDBBC")]
		public NPNotificationData(int notificationID, string message, string meta, NPNotificationTime time, int pushType)
		{
		}

		[Token(Token = "0x6007D27")]
		[Address(RVA = "0x11DDC34", Offset = "0x11DDC34", VA = "0x11DDC34")]
		public NPNotificationData(int notificationID, string message, string meta, NPNotificationTime time, int pushType, int badgeNumber)
		{
		}
	}
}
