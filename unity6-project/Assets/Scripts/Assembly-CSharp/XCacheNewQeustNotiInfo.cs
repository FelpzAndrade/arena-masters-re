using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2001079")]
public class XCacheNewQeustNotiInfo
{
	[Token(Token = "0x40058CB")]
	[FieldOffset(Offset = "0x8")]
	private List<int> IronsList;

	[Token(Token = "0x40058CC")]
	[FieldOffset(Offset = "0xC")]
	private List<int> QuestList;

	[Token(Token = "0x40058CD")]
	[FieldOffset(Offset = "0x10")]
	private List<int> ClearedNexonCPQList;

	[Token(Token = "0x40058CE")]
	[FieldOffset(Offset = "0x18")]
	private DateTime LastInitLocalTime__BackingField;

	[Token(Token = "0x17000F58")]
	public DateTime LastInitLocalTime
	{
		[Token(Token = "0x6007C48")]
		[Address(RVA = "0x1A9AAB8", Offset = "0x1A9AAB8", VA = "0x1A9AAB8")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6007C49")]
		[Address(RVA = "0x1A9AAC8", Offset = "0x1A9AAC8", VA = "0x1A9AAC8")]
		set
		{
		}
	}

	[Token(Token = "0x6007C47")]
	[Address(RVA = "0x1A9A9DC", Offset = "0x1A9A9DC", VA = "0x1A9A9DC")]
	public XCacheNewQeustNotiInfo()
	{
	}

	[Token(Token = "0x6007C4A")]
	[Address(RVA = "0x1A9AAE0", Offset = "0x1A9AAE0", VA = "0x1A9AAE0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6007C4B")]
	[Address(RVA = "0x1A9ABD0", Offset = "0x1A9ABD0", VA = "0x1A9ABD0")]
	public List<int> GetQuestNewList(List<int> nowCompletedList)
	{
		return null;
	}

	[Token(Token = "0x6007C4C")]
	[Address(RVA = "0x1A9AC88", Offset = "0x1A9AC88", VA = "0x1A9AC88")]
	public List<int> GetIronsNewList(List<int> nowCompletedList)
	{
		return null;
	}

	[Token(Token = "0x6007C4D")]
	[Address(RVA = "0x1A9AC94", Offset = "0x1A9AC94", VA = "0x1A9AC94")]
	public List<int> GetNexonCPQNewList(List<int> nowCompletedList)
	{
		return null;
	}

	[Token(Token = "0x6007C4E")]
	[Address(RVA = "0x1A9ABDC", Offset = "0x1A9ABDC", VA = "0x1A9ABDC")]
	private List<int> GetNewList(List<int> cacheList, List<int> nowCompletedList)
	{
		return null;
	}

	[Token(Token = "0x6007C4F")]
	[Address(RVA = "0x1A9ACA0", Offset = "0x1A9ACA0", VA = "0x1A9ACA0")]
	public void SetQuestList(List<int> nowCompletedList)
	{
	}

	[Token(Token = "0x6007C50")]
	[Address(RVA = "0x1A9ACA8", Offset = "0x1A9ACA8", VA = "0x1A9ACA8")]
	public void SetIronsList(List<int> nowCompletedList)
	{
	}

	[Token(Token = "0x6007C51")]
	[Address(RVA = "0x1A9ACB0", Offset = "0x1A9ACB0", VA = "0x1A9ACB0")]
	public void SetNexonCPQList(List<int> nowCompletedList)
	{
	}
}
