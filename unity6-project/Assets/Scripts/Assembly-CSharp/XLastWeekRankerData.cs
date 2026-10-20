using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200062B")]
public class XLastWeekRankerData
{
	[Token(Token = "0x4001DBE")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<ConnectEnum.RegionType, LastWeekRankerInfo> rankerData;

	[Token(Token = "0x6003509")]
	[Address(RVA = "0x1D3F3F0", Offset = "0x1D3F3F0", VA = "0x1D3F3F0")]
	public XLastWeekRankerData()
	{
	}

	[Token(Token = "0x600350A")]
	[Address(RVA = "0x1D3F49C", Offset = "0x1D3F49C", VA = "0x1D3F49C")]
	public LastWeekRankerInfo GetRankerData(ConnectEnum.RegionType region, int season)
	{
		return null;
	}

	[Token(Token = "0x600350B")]
	[Address(RVA = "0x1D3F594", Offset = "0x1D3F594", VA = "0x1D3F594")]
	public void SetRankerData(ConnectEnum.RegionType region, LastWeekRankerInfo info)
	{
	}
}
