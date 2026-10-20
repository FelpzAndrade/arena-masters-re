using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200095F")]
	public class SimpleGameRecord : IncreasableDictionary<GameRecordType>
	{
		[Token(Token = "0x17000A85")]
		public int PlayTotalCount
		{
			[Token(Token = "0x6004B5B")]
			[Address(RVA = "0x21E15C8", Offset = "0x21E15C8", VA = "0x21E15C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x21E13EC", Offset = "0x21E13EC", VA = "0x21E13EC")]
		public SimpleGameRecord()
		{
		}

		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x21E1470", Offset = "0x21E1470", VA = "0x21E1470")]
		public SimpleGameRecord(GameRecord _gameGecord)
		{
		}

		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x21E1504", Offset = "0x21E1504", VA = "0x21E1504")]
		public void Update(GameRecord _gameGecord)
		{
		}
	}
}
