using System;
using BestHTTP.Logger;
using Il2CppDummyDll;

[Token(Token = "0x2000825")]
public class XHttpLogger : ILogger
{
	[Token(Token = "0x4002333")]
	[FieldOffset(Offset = "0x8")]
	private Loglevels Level__BackingField;

	[Token(Token = "0x4002334")]
	[FieldOffset(Offset = "0xC")]
	private string FormatVerbose__BackingField;

	[Token(Token = "0x4002335")]
	[FieldOffset(Offset = "0x10")]
	private string FormatInfo__BackingField;

	[Token(Token = "0x4002336")]
	[FieldOffset(Offset = "0x14")]
	private string FormatWarn__BackingField;

	[Token(Token = "0x4002337")]
	[FieldOffset(Offset = "0x18")]
	private string FormatErr__BackingField;

	[Token(Token = "0x4002338")]
	[FieldOffset(Offset = "0x1C")]
	private string FormatEx__BackingField;

	[Token(Token = "0x4002339")]
	[FieldOffset(Offset = "0x20")]
	private string FormatExReport__BackingField;

	[Token(Token = "0x17000917")]
	public Loglevels Level
	{
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x1D23984", Offset = "0x1D23984", VA = "0x1D23984", Slot = "4")]
		get
		{
			return default(Loglevels);
		}
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x1D2397C", Offset = "0x1D2397C", VA = "0x1D2397C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000918")]
	public string FormatVerbose
	{
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x1D2398C", Offset = "0x1D2398C", VA = "0x1D2398C", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x1D2394C", Offset = "0x1D2394C", VA = "0x1D2394C", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000919")]
	public string FormatInfo
	{
		[Token(Token = "0x600410F")]
		[Address(RVA = "0x1D23994", Offset = "0x1D23994", VA = "0x1D23994", Slot = "8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004110")]
		[Address(RVA = "0x1D23954", Offset = "0x1D23954", VA = "0x1D23954", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700091A")]
	public string FormatWarn
	{
		[Token(Token = "0x6004111")]
		[Address(RVA = "0x1D2399C", Offset = "0x1D2399C", VA = "0x1D2399C", Slot = "10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x1D2395C", Offset = "0x1D2395C", VA = "0x1D2395C", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x1700091B")]
	public string FormatErr
	{
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x1D239A4", Offset = "0x1D239A4", VA = "0x1D239A4", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004114")]
		[Address(RVA = "0x1D23964", Offset = "0x1D23964", VA = "0x1D23964", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x1700091C")]
	public string FormatEx
	{
		[Token(Token = "0x6004115")]
		[Address(RVA = "0x1D239AC", Offset = "0x1D239AC", VA = "0x1D239AC", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004116")]
		[Address(RVA = "0x1D2396C", Offset = "0x1D2396C", VA = "0x1D2396C", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x1700091D")]
	public string FormatExReport
	{
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x1D239B4", Offset = "0x1D239B4", VA = "0x1D239B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x1D23974", Offset = "0x1D23974", VA = "0x1D23974")]
		set
		{
		}
	}

	[Token(Token = "0x600410A")]
	[Address(RVA = "0x1D23820", Offset = "0x1D23820", VA = "0x1D23820")]
	public XHttpLogger()
	{
	}

	[Token(Token = "0x6004119")]
	[Address(RVA = "0x1D239BC", Offset = "0x1D239BC", VA = "0x1D239BC", Slot = "16")]
	public void Verbose(string division, string verb)
	{
	}

	[Token(Token = "0x600411A")]
	[Address(RVA = "0x1D23B7C", Offset = "0x1D23B7C", VA = "0x1D23B7C", Slot = "17")]
	public void Information(string division, string info)
	{
	}

	[Token(Token = "0x600411B")]
	[Address(RVA = "0x1D23D3C", Offset = "0x1D23D3C", VA = "0x1D23D3C", Slot = "18")]
	public void Warning(string division, string warn)
	{
	}

	[Token(Token = "0x600411C")]
	[Address(RVA = "0x1D23EFC", Offset = "0x1D23EFC", VA = "0x1D23EFC", Slot = "19")]
	public void Error(string division, string err)
	{
	}

	[Token(Token = "0x600411D")]
	[Address(RVA = "0x1D240BC", Offset = "0x1D240BC", VA = "0x1D240BC", Slot = "20")]
	public void Exception(string division, string msg, Exception ex)
	{
	}
}
