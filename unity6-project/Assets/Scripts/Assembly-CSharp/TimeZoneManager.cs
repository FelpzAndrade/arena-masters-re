using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000BA0")]
public class TimeZoneManager
{
	[Token(Token = "0x4003B32")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, string> DicTimeZoneID;

	[Token(Token = "0x4003B33")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ConnectEnum.RegionType, int> DicRegionZoneID;

	[Token(Token = "0x600542B")]
	[Address(RVA = "0x1D4DC8C", Offset = "0x1D4DC8C", VA = "0x1D4DC8C")]
	public TimeZoneManager()
	{
	}

	[Token(Token = "0x600542C")]
	[Address(RVA = "0x1D4F38C", Offset = "0x1D4F38C", VA = "0x1D4F38C")]
	public DateTime ConvertTimeByRegionType(DateTime dateTime, ConnectEnum.RegionType region)
	{
		return default(DateTime);
	}

	[Token(Token = "0x600542D")]
	[Address(RVA = "0x1D4F4F4", Offset = "0x1D4F4F4", VA = "0x1D4F4F4")]
	public bool GetTimeZoneById(int zoneID, out string zoneString)
	{
		zoneString = default;
		return default(bool);
	}

	[Token(Token = "0x600542E")]
	[Address(RVA = "0x1D4F5F4", Offset = "0x1D4F5F4", VA = "0x1D4F5F4")]
	public bool GetTimeZoneIDByRegion(ConnectEnum.RegionType region, out int zoneID)
	{
		zoneID = default;
		return default(bool);
	}
}
