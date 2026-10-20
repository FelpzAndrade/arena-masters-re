using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F52")]
public class XUIRankingList : XUIListView
{
	[Token(Token = "0x2000F53")]
	public class RankerData
	{
		[Token(Token = "0x4005064")]
		[FieldOffset(Offset = "0x8")]
		public RankerMetaData rankerMetaData;

		[Token(Token = "0x4005065")]
		[FieldOffset(Offset = "0xC")]
		public int rank;

		[Token(Token = "0x60071C7")]
		[Address(RVA = "0x191517C", Offset = "0x191517C", VA = "0x191517C")]
		public RankerData()
		{
		}
	}

	[Token(Token = "0x4005060")]
	[FieldOffset(Offset = "0x78")]
	private RankingList data;

	[Token(Token = "0x4005061")]
	[FieldOffset(Offset = "0x7C")]
	private List<RankerData> m_list;

	[Token(Token = "0x4005062")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<RankerData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4005063")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<RankerData> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17000E86")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60071C0")]
		[Address(RVA = "0x1914AD4", Offset = "0x1914AD4", VA = "0x1914AD4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E87")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60071C1")]
		[Address(RVA = "0x1914B4C", Offset = "0x1914B4C", VA = "0x1914B4C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E88")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60071C2")]
		[Address(RVA = "0x1914B54", Offset = "0x1914B54", VA = "0x1914B54", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60071BF")]
	[Address(RVA = "0x19149FC", Offset = "0x19149FC", VA = "0x19149FC")]
	public XUIRankingList()
	{
	}

	[Token(Token = "0x60071C3")]
	[Address(RVA = "0x1914BEC", Offset = "0x1914BEC", VA = "0x1914BEC", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60071C4")]
	[Address(RVA = "0x1914CD0", Offset = "0x1914CD0", VA = "0x1914CD0")]
	public void Build(RankingList data)
	{
	}

	[Token(Token = "0x60071C5")]
	[Address(RVA = "0x1915184", Offset = "0x1915184", VA = "0x1915184")]
	private static int _003CBuild_003Em__48C(RankerData a, RankerData b)
	{
		return default(int);
	}

	[Token(Token = "0x60071C6")]
	[Address(RVA = "0x19151F4", Offset = "0x19151F4", VA = "0x19151F4")]
	private static int _003CBuild_003Em__48D(RankerData a, RankerData b)
	{
		return default(int);
	}
}
