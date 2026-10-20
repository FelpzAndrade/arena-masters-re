using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20004A9")]
public class ActionFriendListener
{
	[Token(Token = "0x6002801")]
	[Address(RVA = "0x20B3FF4", Offset = "0x20B3FF4", VA = "0x20B3FF4")]
	public ActionFriendListener()
	{
	}

	[Token(Token = "0x6002802")]
	public static void DoAction<T>(List<T> liListeners, Action<T> action)
	{
	}
}
