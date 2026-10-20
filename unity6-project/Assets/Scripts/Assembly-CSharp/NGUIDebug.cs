using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000218")]
public class NGUIDebug : MonoBehaviour
{
	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x0")]
	private static bool mRayDebug;

	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x4")]
	private static List<string> mLines;

	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x8")]
	private static NGUIDebug mInstance;

	[Token(Token = "0x170002A5")]
	public static bool debugRaycast
	{
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x11A5760", Offset = "0x11A5760", VA = "0x11A5760")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x11A5810", Offset = "0x11A5810", VA = "0x11A5810")]
		set
		{
		}
	}

	[Token(Token = "0x600118B")]
	[Address(RVA = "0x11A568C", Offset = "0x11A568C", VA = "0x11A568C")]
	public NGUIDebug()
	{
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0x11A5918", Offset = "0x11A5918", VA = "0x11A5918")]
	public static void CreateInstance()
	{
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0x11A5B18", Offset = "0x11A5B18", VA = "0x11A5B18")]
	private static void LogString(string text)
	{
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x11A5D5C", Offset = "0x11A5D5C", VA = "0x11A5D5C")]
	public static void Log(params object[] objs)
	{
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0x11A5FFC", Offset = "0x11A5FFC", VA = "0x11A5FFC")]
	public static void Log(string s)
	{
	}

	[Token(Token = "0x6001193")]
	[Address(RVA = "0x11A61A4", Offset = "0x11A61A4", VA = "0x11A61A4")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6001194")]
	[Address(RVA = "0x11A6288", Offset = "0x11A6288", VA = "0x11A6288")]
	public static void DrawBounds(Bounds b)
	{
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0x11A6680", Offset = "0x11A6680", VA = "0x11A6680")]
	private void OnGUI()
	{
	}
}
