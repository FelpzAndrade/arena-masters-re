using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B3")]
public class XSingleUseList
{
	[Token(Token = "0x4002046")]
	[FieldOffset(Offset = "0x0")]
	private static List<int> _int;

	[Token(Token = "0x4002047")]
	[FieldOffset(Offset = "0x4")]
	private static List<GameObject> _gameObject;

	[Token(Token = "0x4002048")]
	[FieldOffset(Offset = "0x8")]
	private static List<string> _string;

	[Token(Token = "0x4002049")]
	[FieldOffset(Offset = "0xC")]
	private static List<XPlayer> _xplayer;

	[Token(Token = "0x1700080F")]
	public static List<int> Int
	{
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x181CB78", Offset = "0x181CB78", VA = "0x181CB78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000810")]
	public static List<GameObject> GameObject
	{
		[Token(Token = "0x600381F")]
		[Address(RVA = "0x181CC6C", Offset = "0x181CC6C", VA = "0x181CC6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000811")]
	public static List<string> String
	{
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x181CD60", Offset = "0x181CD60", VA = "0x181CD60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000812")]
	public static List<XPlayer> XPlayer
	{
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x181CE54", Offset = "0x181CE54", VA = "0x181CE54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600381C")]
	[Address(RVA = "0x181CA0C", Offset = "0x181CA0C", VA = "0x181CA0C")]
	public XSingleUseList()
	{
	}
}
