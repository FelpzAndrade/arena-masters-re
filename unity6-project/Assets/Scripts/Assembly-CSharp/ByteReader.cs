using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000211")]
public class ByteReader
{
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x8")]
	private byte[] mBuffer;

	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0xC")]
	private int mOffset;

	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x0")]
	private static BetterList<string> mTemp;

	[Token(Token = "0x17000299")]
	public bool canRead
	{
		[Token(Token = "0x6001139")]
		[Address(RVA = "0x20C28A8", Offset = "0x20C28A8", VA = "0x20C28A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001135")]
	[Address(RVA = "0x20C2540", Offset = "0x20C2540", VA = "0x20C2540")]
	public ByteReader(byte[] bytes)
	{
	}

	[Token(Token = "0x6001136")]
	[Address(RVA = "0x20C2560", Offset = "0x20C2560", VA = "0x20C2560")]
	public ByteReader(TextAsset asset)
	{
	}

	[Token(Token = "0x6001138")]
	[Address(RVA = "0x20C2650", Offset = "0x20C2650", VA = "0x20C2650")]
	public static ByteReader Open(string path)
	{
		return null;
	}

	[Token(Token = "0x600113A")]
	[Address(RVA = "0x20C28D4", Offset = "0x20C28D4", VA = "0x20C28D4")]
	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return null;
	}

	[Token(Token = "0x600113B")]
	[Address(RVA = "0x20C29D8", Offset = "0x20C29D8", VA = "0x20C29D8")]
	public string ReadLine()
	{
		return null;
	}

	[Token(Token = "0x600113C")]
	[Address(RVA = "0x20C29E0", Offset = "0x20C29E0", VA = "0x20C29E0")]
	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	[Token(Token = "0x600113D")]
	[Address(RVA = "0x20C2B84", Offset = "0x20C2B84", VA = "0x20C2B84")]
	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	[Token(Token = "0x600113E")]
	[Address(RVA = "0x20C2DEC", Offset = "0x20C2DEC", VA = "0x20C2DEC")]
	public BetterList<string> ReadCSV()
	{
		return null;
	}
}
