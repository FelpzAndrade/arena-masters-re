using ExitGames.Client.Photon;
using Il2CppDummyDll;

[Token(Token = "0x2000296")]
internal static class CustomTypes
{
	[Token(Token = "0x4000C68")]
	[FieldOffset(Offset = "0x0")]
	public static readonly byte[] memVector3;

	[Token(Token = "0x4000C69")]
	[FieldOffset(Offset = "0x4")]
	public static readonly byte[] memVector2;

	[Token(Token = "0x4000C6A")]
	[FieldOffset(Offset = "0x8")]
	public static readonly byte[] memQuarternion;

	[Token(Token = "0x4000C6B")]
	[FieldOffset(Offset = "0xC")]
	public static readonly byte[] memPlayer;

	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x1E614CC", Offset = "0x1E614CC", VA = "0x1E614CC")]
	internal static void Register()
	{
	}

	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x1E6182C", Offset = "0x1E6182C", VA = "0x1E6182C")]
	private static short SerializeVector3(StreamBuffer outStream, object customobject)
	{
		return default(short);
	}

	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x1E61AA8", Offset = "0x1E61AA8", VA = "0x1E61AA8")]
	private static object DeserializeVector3(StreamBuffer inStream, short length)
	{
		return null;
	}

	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x1E61DB4", Offset = "0x1E61DB4", VA = "0x1E61DB4")]
	private static short SerializeVector2(StreamBuffer outStream, object customobject)
	{
		return default(short);
	}

	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x1E62018", Offset = "0x1E62018", VA = "0x1E62018")]
	private static object DeserializeVector2(StreamBuffer inStream, short length)
	{
		return null;
	}

	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x1E622EC", Offset = "0x1E622EC", VA = "0x1E622EC")]
	private static short SerializeQuaternion(StreamBuffer outStream, object customobject)
	{
		return default(short);
	}

	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x1E6258C", Offset = "0x1E6258C", VA = "0x1E6258C")]
	private static object DeserializeQuaternion(StreamBuffer inStream, short length)
	{
		return null;
	}

	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x1E628C8", Offset = "0x1E628C8", VA = "0x1E628C8")]
	private static short SerializePhotonPlayer(StreamBuffer outStream, object customobject)
	{
		return default(short);
	}

	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x1E62B44", Offset = "0x1E62B44", VA = "0x1E62B44")]
	private static object DeserializePhotonPlayer(StreamBuffer inStream, short length)
	{
		return null;
	}
}
