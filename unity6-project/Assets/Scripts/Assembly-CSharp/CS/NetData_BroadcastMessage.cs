using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x200086E")]
	public class NetData_BroadcastMessage
	{
		[Token(Token = "0x40026B2")]
		[FieldOffset(Offset = "0x0")]
		[JsonIgnore]
		public static readonly string Key;

		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0x8")]
		public long LastUtcTimeMS;

		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x10")]
		public List<CSBroadcastMessage> liBCMsg;

		[Token(Token = "0x6004592")]
		[Address(RVA = "0x233E528", Offset = "0x233E528", VA = "0x233E528")]
		public NetData_BroadcastMessage()
		{
		}

		[Token(Token = "0x6004593")]
		[Address(RVA = "0x233E5E0", Offset = "0x233E5E0", VA = "0x233E5E0")]
		public NetData_BroadcastMessage(long lastUtcTimeMS, List<CSBroadcastMessage> _liBCMsg)
		{
		}
	}
}
