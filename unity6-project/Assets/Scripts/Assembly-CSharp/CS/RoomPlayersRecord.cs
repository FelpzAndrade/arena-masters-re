using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000894")]
	public class RoomPlayersRecord
	{
		[Token(Token = "0x4002A2A")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, PlayerGameRecord> DicRecord;

		[Token(Token = "0x60045D6")]
		[Address(RVA = "0x21C3014", Offset = "0x21C3014", VA = "0x21C3014")]
		public RoomPlayersRecord(Dictionary<string, PlayerGameRecord> _dicRecord)
		{
		}
	}
}
