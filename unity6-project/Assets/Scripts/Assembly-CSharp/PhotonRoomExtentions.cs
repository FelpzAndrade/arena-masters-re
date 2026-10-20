using Il2CppDummyDll;

[Token(Token = "0x2000853")]
public static class PhotonRoomExtentions
{
	[Token(Token = "0x600450D")]
	public static void SetCustomProperty<T>(this Room room, string k, T v)
	{
	}

	[Token(Token = "0x600450E")]
	public static T GetCustomProperty<T>(this Room room, string k)
	{
		return (T)default;
	}

	[Token(Token = "0x600450F")]
	[Address(RVA = "0x1B9C218", Offset = "0x1B9C218", VA = "0x1B9C218")]
	public static void IncreaseCustomProperty(this Room pp, string k)
	{
	}
}
