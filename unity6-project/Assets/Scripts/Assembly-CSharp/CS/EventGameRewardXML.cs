using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AD2")]
	public sealed class EventGameRewardXML
	{
		[Token(Token = "0x40032CF")]
		[FieldOffset(Offset = "0x8")]
		public List<EventGameRewardInfo> dataList;

		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x1CE02B4", Offset = "0x1CE02B4", VA = "0x1CE02B4")]
		public EventGameRewardXML()
		{
		}

		[Token(Token = "0x6004F54")]
		[Address(RVA = "0x1CE0360", Offset = "0x1CE0360", VA = "0x1CE0360")]
		public void Add(EventGameRewardInfo i)
		{
		}
	}
}
