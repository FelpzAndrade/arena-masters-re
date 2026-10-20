using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C56")]
public class XUIAcquisitionDirection : MonoBehaviour
{
	[Token(Token = "0x4003E81")]
	[FieldOffset(Offset = "0xC")]
	public Transform directionParentTransform;

	[Token(Token = "0x4003E82")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_GachaItemCardDirection gachaItemCardDirection;

	[Token(Token = "0x4003E83")]
	[FieldOffset(Offset = "0x14")]
	private readonly string Path_MultiContents;

	[Token(Token = "0x4003E84")]
	[FieldOffset(Offset = "0x18")]
	private readonly string Path_SingleGacha_m;

	[Token(Token = "0x4003E85")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject _frameForMulti;

	[Token(Token = "0x4003E86")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_GachaCardBox _singleContentIcon_Multi;

	[Token(Token = "0x17000CBA")]
	public GameObject frameForMulti
	{
		[Token(Token = "0x6005937")]
		[Address(RVA = "0x185A58C", Offset = "0x185A58C", VA = "0x185A58C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CBB")]
	public XWidget_GachaCardBox singleContentIcon_Multi
	{
		[Token(Token = "0x6005938")]
		[Address(RVA = "0x185A73C", Offset = "0x185A73C", VA = "0x185A73C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005936")]
	[Address(RVA = "0x185A4EC", Offset = "0x185A4EC", VA = "0x185A4EC")]
	public XUIAcquisitionDirection()
	{
	}

	[Token(Token = "0x6005939")]
	[Address(RVA = "0x185A8F4", Offset = "0x185A8F4", VA = "0x185A8F4")]
	public int GetRestoreGoldCount(List<CSContent> contents)
	{
		return default(int);
	}

	[Token(Token = "0x600593A")]
	[Address(RVA = "0x185AAC0", Offset = "0x185AAC0", VA = "0x185AAC0")]
	private bool IsBonusGold(CSContent content)
	{
		return default(bool);
	}

	[Token(Token = "0x600593B")]
	[Address(RVA = "0x185AB10", Offset = "0x185AB10", VA = "0x185AB10")]
	private void BuildMultiContent(List<CSContent> contents, List<CSContent> originContents, int restoreGoldCount, bool toMail, Action EndDirection)
	{
	}

	[Token(Token = "0x600593C")]
	[Address(RVA = "0x185ADA4", Offset = "0x185ADA4", VA = "0x185ADA4")]
	public void Build(Netdata_Acquisitions acqusition, List<CSContent> originContents, Action EndDirection)
	{
	}
}
