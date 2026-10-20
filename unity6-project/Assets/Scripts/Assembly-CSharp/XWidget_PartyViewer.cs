using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FC7")]
public class XWidget_PartyViewer : MonoBehaviour
{
	[Token(Token = "0x40053E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PREFAB_PATH;

	[Token(Token = "0x40053E5")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_CharacterDropArea[] dropAreas;

	[Token(Token = "0x40053E6")]
	[FieldOffset(Offset = "0x10")]
	public XUIModelPreviewDragZone modelPreviewDragZone;

	[Token(Token = "0x40053E7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel[] m_lblMemberNames;

	[Token(Token = "0x40053E8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel[] m_lblMemberLvs;

	[Token(Token = "0x40053E9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel[] m_lblMemberTitles;

	[Token(Token = "0x40053EA")]
	[FieldOffset(Offset = "0x20")]
	public Action tabChangeCallback;

	[Token(Token = "0x40053EB")]
	[FieldOffset(Offset = "0x24")]
	protected float m_scaleFactor;

	[Token(Token = "0x40053EC")]
	[FieldOffset(Offset = "0x28")]
	private List<XModuleActor> PartyActors__BackingField;

	[Token(Token = "0x40053ED")]
	[FieldOffset(Offset = "0x2C")]
	private CharPartyId CurPartyId__BackingField;

	[Token(Token = "0x17000EDE")]
	public List<XModuleActor> PartyActors
	{
		[Token(Token = "0x600758E")]
		[Address(RVA = "0x1316258", Offset = "0x1316258", VA = "0x1316258")]
		get
		{
			return null;
		}
		[Token(Token = "0x600758F")]
		[Address(RVA = "0x1316260", Offset = "0x1316260", VA = "0x1316260")]
		private set
		{
		}
	}

	[Token(Token = "0x17000EDF")]
	public CharPartyId CurPartyId
	{
		[Token(Token = "0x6007591")]
		[Address(RVA = "0x131626C", Offset = "0x131626C", VA = "0x131626C")]
		get
		{
			return default(CharPartyId);
		}
		[Token(Token = "0x6007592")]
		[Address(RVA = "0x1316274", Offset = "0x1316274", VA = "0x1316274")]
		private set
		{
		}
	}

	[Token(Token = "0x600758B")]
	[Address(RVA = "0x1316014", Offset = "0x1316014", VA = "0x1316014")]
	public XWidget_PartyViewer()
	{
	}

	[Token(Token = "0x600758D")]
	[Address(RVA = "0x13160B8", Offset = "0x13160B8", VA = "0x13160B8")]
	public static XWidget_PartyViewer Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6007590")]
	[Address(RVA = "0x1316268", Offset = "0x1316268", VA = "0x1316268", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6007593")]
	[Address(RVA = "0x131627C", Offset = "0x131627C", VA = "0x131627C", Slot = "5")]
	public virtual void BuildParty(CharPartyId partyId)
	{
	}

	[Token(Token = "0x6007594")]
	[Address(RVA = "0x13169C0", Offset = "0x13169C0", VA = "0x13169C0")]
	private List<XModuleActor> GetPartyActors(CharPartyId partyId)
	{
		return null;
	}

	[Token(Token = "0x6007595")]
	[Address(RVA = "0x1316828", Offset = "0x1316828", VA = "0x1316828")]
	protected void RefreshModelPreview()
	{
	}

	[Token(Token = "0x6007596")]
	[Address(RVA = "0x1316BB8", Offset = "0x1316BB8", VA = "0x1316BB8")]
	public void ShowRepresentParty()
	{
	}

	[Token(Token = "0x6007597")]
	[Address(RVA = "0x1316C20", Offset = "0x1316C20", VA = "0x1316C20")]
	public void ShowFirstParty()
	{
	}

	[Token(Token = "0x6007598")]
	[Address(RVA = "0x1316C74", Offset = "0x1316C74", VA = "0x1316C74")]
	public void ShowSecondParty()
	{
	}

	[Token(Token = "0x6007599")]
	[Address(RVA = "0x1316CC8", Offset = "0x1316CC8", VA = "0x1316CC8")]
	public void Hide()
	{
	}

	[Token(Token = "0x600759A")]
	[Address(RVA = "0x1316CF4", Offset = "0x1316CF4", VA = "0x1316CF4")]
	public void OnClickCharManage()
	{
	}

	[Token(Token = "0x600759B")]
	[Address(RVA = "0x1316C0C", Offset = "0x1316C0C", VA = "0x1316C0C")]
	private void TabChange()
	{
	}
}
