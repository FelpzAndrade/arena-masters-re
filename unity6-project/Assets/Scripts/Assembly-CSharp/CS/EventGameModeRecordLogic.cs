using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000929")]
	public class EventGameModeRecordLogic
	{
		[Token(Token = "0x4002D61")]
		[FieldOffset(Offset = "0x8")]
		protected EventGameModeClearRecord record;

		[Token(Token = "0x6004916")]
		[Address(RVA = "0x1CDF344", Offset = "0x1CDF344", VA = "0x1CDF344")]
		public EventGameModeRecordLogic(EventGameModeClearRecord record)
		{
		}

		[Token(Token = "0x6004917")]
		[Address(RVA = "0x1CDF364", Offset = "0x1CDF364", VA = "0x1CDF364")]
		public bool IsFirstEnter(EventGameModeInfo modeInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6004918")]
		[Address(RVA = "0x1CDF3B4", Offset = "0x1CDF3B4", VA = "0x1CDF3B4")]
		public bool IsPayed(EventGameModeInfo modeInfo)
		{
			return default(bool);
		}
	}
}
