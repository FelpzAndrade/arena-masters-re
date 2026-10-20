using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008CB")]
	public class CSRoomHelper
	{
		[Token(Token = "0x4002AE7")]
		[FieldOffset(Offset = "0x0")]
		public static List<string> roomProperties;

		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x1CD05C4", Offset = "0x1CD05C4", VA = "0x1CD05C4")]
		public CSRoomHelper()
		{
		}

		[Token(Token = "0x60046FE")]
		public static bool TryGetRoomProperty<T>(Dictionary<string, object> CustomProperties, string key, out T value)
		{
			value = default;
			return default(bool);
		}

		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x1CD08B8", Offset = "0x1CD08B8", VA = "0x1CD08B8")]
		public static bool TryGetRoomType(Dictionary<string, object> CustomProperties, out RoomType roomType)
		{
			roomType = default;
			return default(bool);
		}

		[Token(Token = "0x6004700")]
		[Address(RVA = "0x1CD0A44", Offset = "0x1CD0A44", VA = "0x1CD0A44")]
		public static bool IsCustomRoom(Dictionary<string, object> CustomProperties)
		{
			return default(bool);
		}
	}
}
