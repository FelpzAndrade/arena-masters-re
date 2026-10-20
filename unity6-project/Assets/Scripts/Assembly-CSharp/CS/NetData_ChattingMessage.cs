using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000871")]
	public class NetData_ChattingMessage
	{
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x0")]
		[JsonIgnore]
		public static readonly string Key;

		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x8")]
		public long TimeStampUtcMS;

		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x10")]
		public List<CSChattingMessage> liMsg;

		[Token(Token = "0x600459B")]
		[Address(RVA = "0x233E8D0", Offset = "0x233E8D0", VA = "0x233E8D0")]
		public NetData_ChattingMessage()
		{
		}

		[Token(Token = "0x600459C")]
		[Address(RVA = "0x233E988", Offset = "0x233E988", VA = "0x233E988")]
		public NetData_ChattingMessage(long _ts, List<CSChattingMessage> _liMsg)
		{
		}
	}
}
