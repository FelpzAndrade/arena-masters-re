using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DB1")]
public class XPanel_AchieveNotice : MonoBehaviour, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x400470F")]
	private const string mischaPath = "Illust/mischa";

	[Token(Token = "0x4004710")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x4004711")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblMessage;

	[Token(Token = "0x4004712")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprMischa;

	[Token(Token = "0x4004713")]
	[FieldOffset(Offset = "0x18")]
	private QuestInfo m_achieveInfo;

	[Token(Token = "0x4004714")]
	[FieldOffset(Offset = "0x1C")]
	private Action m_queue;

	[Token(Token = "0x60064A9")]
	[Address(RVA = "0x1691408", Offset = "0x1691408", VA = "0x1691408")]
	public XPanel_AchieveNotice()
	{
	}

	[Token(Token = "0x60064AA")]
	[Address(RVA = "0x1691410", Offset = "0x1691410", VA = "0x1691410")]
	public void Show(QuestInfo achieveInfo, Action queue)
	{
	}

	[Token(Token = "0x60064AB")]
	[Address(RVA = "0x1691414", Offset = "0x1691414", VA = "0x1691414")]
	public void ShowMessage(QuestInfo achieveInfo)
	{
	}

	[Token(Token = "0x60064AC")]
	[Address(RVA = "0x1691730", Offset = "0x1691730", VA = "0x1691730")]
	public void ConfirmAcheive()
	{
	}

	[Token(Token = "0x60064AD")]
	[Address(RVA = "0x1691840", Offset = "0x1691840", VA = "0x1691840")]
	public void OnClick_Open()
	{
	}

	[Token(Token = "0x60064AE")]
	[Address(RVA = "0x16919AC", Offset = "0x16919AC", VA = "0x16919AC")]
	public void OnClick_Close()
	{
	}

	[Token(Token = "0x60064AF")]
	[Address(RVA = "0x16919B0", Offset = "0x16919B0", VA = "0x16919B0", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60064B0")]
	[Address(RVA = "0x16919E0", Offset = "0x16919E0", VA = "0x16919E0", Slot = "5")]
	public void OnHide()
	{
	}
}
