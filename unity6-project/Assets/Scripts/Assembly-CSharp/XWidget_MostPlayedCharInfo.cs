using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EFA")]
public class XWidget_MostPlayedCharInfo : MonoBehaviour
{
	[Token(Token = "0x4004F5F")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite spr1stChar;

	[Token(Token = "0x4004F60")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite spr2stChar;

	[Token(Token = "0x4004F61")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite spr3stChar;

	[Token(Token = "0x4004F62")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<KeyValuePair<int, int>> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x6006FDC")]
	[Address(RVA = "0x12FFD3C", Offset = "0x12FFD3C", VA = "0x12FFD3C")]
	public XWidget_MostPlayedCharInfo()
	{
	}

	[Token(Token = "0x6006FDD")]
	[Address(RVA = "0x12FFD44", Offset = "0x12FFD44", VA = "0x12FFD44")]
	public void BuildMyInfo(CSProtoInfoManager_Character protoChar, XMyInfo myinfo)
	{
	}

	[Token(Token = "0x6006FDE")]
	[Address(RVA = "0x12FFF84", Offset = "0x12FFF84", VA = "0x12FFF84")]
	public void Build(CSProtoInfoManager_Character protoChar, List<int> charIDs)
	{
	}

	[Token(Token = "0x6006FDF")]
	[Address(RVA = "0x12FFDE4", Offset = "0x12FFDE4", VA = "0x12FFDE4")]
	private void BuildCharIcon(UI2DSprite spr, List<int> charIDs, int index, CSProtoInfoManager_Character protoChar)
	{
	}

	[Token(Token = "0x6006FE0")]
	[Address(RVA = "0x12FFFDC", Offset = "0x12FFFDC", VA = "0x12FFFDC")]
	private List<KeyValuePair<int, int>> GetPlayedCountDictionary(CSProtoInfoManager_Character protoChar, XMyInfo myinfo)
	{
		return null;
	}

	[Token(Token = "0x6006FE1")]
	[Address(RVA = "0x130057C", Offset = "0x130057C", VA = "0x130057C")]
	private static int _003CGetPlayedCountDictionary_003Em__456(KeyValuePair<int, int> firstPair, KeyValuePair<int, int> nextPair)
	{
		return default(int);
	}
}
