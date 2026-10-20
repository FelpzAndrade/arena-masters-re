using System;
using Il2CppDummyDll;

[Token(Token = "0x2000BF3")]
public class NPState
{
	[Token(Token = "0x4003C60")]
	[FieldOffset(Offset = "0x0")]
	public static ToyManagerProcessState state;

	[Token(Token = "0x4003C61")]
	[FieldOffset(Offset = "0x4")]
	public static Action DidDoneNotification;

	[Token(Token = "0x600562F")]
	[Address(RVA = "0x11E4D64", Offset = "0x11E4D64", VA = "0x11E4D64")]
	public NPState()
	{
	}

	[Token(Token = "0x6005631")]
	[Address(RVA = "0x11E4D70", Offset = "0x11E4D70", VA = "0x11E4D70")]
	public static void Processing()
	{
	}

	[Token(Token = "0x6005632")]
	[Address(RVA = "0x11E4E24", Offset = "0x11E4E24", VA = "0x11E4E24")]
	public static void Done()
	{
	}

	[Token(Token = "0x6005633")]
	[Address(RVA = "0x11E4F74", Offset = "0x11E4F74", VA = "0x11E4F74")]
	public static bool IsProcessing()
	{
		return default(bool);
	}
}
