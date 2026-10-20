using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B9F")]
	public class SystemTime : ISystemTime
	{
		[Token(Token = "0x17000C70")]
		public DateTime Now
		{
			[Token(Token = "0x6005427")]
			[Address(RVA = "0x21E5B48", Offset = "0x21E5B48", VA = "0x21E5B48", Slot = "4")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6005428")]
			[Address(RVA = "0x21E5BF0", Offset = "0x21E5BF0", VA = "0x21E5BF0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000C71")]
		public DateTime UtcNow
		{
			[Token(Token = "0x6005429")]
			[Address(RVA = "0x21E5BF4", Offset = "0x21E5BF4", VA = "0x21E5BF4", Slot = "6")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600542A")]
			[Address(RVA = "0x21E5C9C", Offset = "0x21E5C9C", VA = "0x21E5C9C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x6005426")]
		[Address(RVA = "0x21E5B40", Offset = "0x21E5B40", VA = "0x21E5B40")]
		public SystemTime()
		{
		}
	}
}
