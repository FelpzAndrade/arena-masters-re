using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA6")]
public class XWidget_ClanSetupInfo : MonoBehaviour
{
	[Token(Token = "0x4004CF6")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblClanMaster;

	[Token(Token = "0x4004CF7")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblClanMemberCnt;

	[Token(Token = "0x4004CF8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblClanRank;

	[Token(Token = "0x4004CF9")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_QuantityInputBox lvInputBox;

	[Token(Token = "0x4004CFA")]
	[FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder joinConditionBuilder;

	[Token(Token = "0x4004CFB")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_Selectable_Label[] joinConditions;

	[Token(Token = "0x4004CFC")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_Selectable_Label selectCondition;

	[Token(Token = "0x4004CFD")]
	[FieldOffset(Offset = "0x28")]
	public UIInput inputClanNoti;

	[Token(Token = "0x4004CFE")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput inputClanIntroduce;

	[Token(Token = "0x4004CFF")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_OnPress pressInputNoti;

	[Token(Token = "0x4004D00")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x6006D48")]
	[Address(RVA = "0x15E7FB0", Offset = "0x15E7FB0", VA = "0x15E7FB0")]
	public XWidget_ClanSetupInfo()
	{
	}

	[Token(Token = "0x6006D49")]
	[Address(RVA = "0x15E7738", Offset = "0x15E7738", VA = "0x15E7738")]
	public string GetInstroduction()
	{
		return null;
	}

	[Token(Token = "0x6006D4A")]
	[Address(RVA = "0x15E785C", Offset = "0x15E785C", VA = "0x15E785C")]
	public string GetNotification()
	{
		return null;
	}

	[Token(Token = "0x6006D4B")]
	[Address(RVA = "0x15E7980", Offset = "0x15E7980", VA = "0x15E7980")]
	public ClanJoinType GetJoinType()
	{
		return default(ClanJoinType);
	}

	[Token(Token = "0x6006D4C")]
	[Address(RVA = "0x15E79AC", Offset = "0x15E79AC", VA = "0x15E79AC")]
	public int GetNeedLv()
	{
		return default(int);
	}

	[Token(Token = "0x6006D4D")]
	[Address(RVA = "0x15E66BC", Offset = "0x15E66BC", VA = "0x15E66BC")]
	public void Build(ClanMemberGrade grade, Netdata_Clan clanNetdata, int rank)
	{
	}

	[Token(Token = "0x6006D4E")]
	[Address(RVA = "0x15E7FEC", Offset = "0x15E7FEC", VA = "0x15E7FEC")]
	private void BuildJoinCondition(ClanJoinType selectType)
	{
	}

	[Token(Token = "0x6006D4F")]
	[Address(RVA = "0x15E8354", Offset = "0x15E8354", VA = "0x15E8354")]
	private void ToggleJoinCondition(bool toggle, int condition)
	{
	}

	[Token(Token = "0x6006D50")]
	[Address(RVA = "0x15E7190", Offset = "0x15E7190", VA = "0x15E7190")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006D51")]
	[Address(RVA = "0x15E7FB8", Offset = "0x15E7FB8", VA = "0x15E7FB8")]
	public void Show()
	{
	}

	[Token(Token = "0x6006D52")]
	[Address(RVA = "0x15E8498", Offset = "0x15E8498", VA = "0x15E8498")]
	private void _003CBuild_003Em__403()
	{
	}

	[Token(Token = "0x6006D53")]
	[Address(RVA = "0x15E85F4", Offset = "0x15E85F4", VA = "0x15E85F4")]
	private static void _003CBuild_003Em__404()
	{
	}
}
