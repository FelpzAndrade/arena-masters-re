using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000855")]
public static class XRoomHelper
{
	[Token(Token = "0x6004512")]
	[Address(RVA = "0x1CA60F8", Offset = "0x1CA60F8", VA = "0x1CA60F8")]
	internal static RoomType GetRoomType(Room room)
	{
		return default(RoomType);
	}

	[Token(Token = "0x6004513")]
	[Address(RVA = "0x1CA6210", Offset = "0x1CA6210", VA = "0x1CA6210")]
	internal static RoomType GetRoomType(RoomInfo room)
	{
		return default(RoomType);
	}

	[Token(Token = "0x6004514")]
	[Address(RVA = "0x1CA6328", Offset = "0x1CA6328", VA = "0x1CA6328")]
	public static bool IsFullPlayer(this RoomInfo roomInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6004515")]
	[Address(RVA = "0x1CA6378", Offset = "0x1CA6378", VA = "0x1CA6378")]
	public static bool IsFriendPartyGame(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004516")]
	[Address(RVA = "0x1CA6494", Offset = "0x1CA6494", VA = "0x1CA6494")]
	public static bool IsFriendlyGame(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004517")]
	[Address(RVA = "0x1CA65B4", Offset = "0x1CA65B4", VA = "0x1CA65B4")]
	public static bool IsCustomRoom(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x6004518")]
	public static bool TryGetRoomProperty<T>(this RoomInfo roomInfo, string key, out T value)
	{
		value = default;
		return default(bool);
	}

	[Token(Token = "0x6004519")]
	[Address(RVA = "0x1CA66D4", Offset = "0x1CA66D4", VA = "0x1CA66D4")]
	internal static string[] GetRoomPropertiesForLobby()
	{
		return null;
	}

	[Token(Token = "0x600451A")]
	[Address(RVA = "0x1CA67B8", Offset = "0x1CA67B8", VA = "0x1CA67B8")]
	internal static string MakeRoomInfoString(Room room, XGameData gameData, XGameManager gameManager)
	{
		return null;
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0x1CA6C58", Offset = "0x1CA6C58", VA = "0x1CA6C58")]
	internal static bool IsPrivateRoom(Room room)
	{
		return default(bool);
	}

	[Token(Token = "0x600451C")]
	[Address(RVA = "0x1CA6DC4", Offset = "0x1CA6DC4", VA = "0x1CA6DC4")]
	public static bool IsCombatPowerCorrection(int costomBitSet)
	{
		return default(bool);
	}
}
