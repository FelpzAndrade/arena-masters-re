using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C70")]
public class XWidget_CharacterDropArea : UIDropArea
{
	[Token(Token = "0x4003F0B")]
	[FieldOffset(Offset = "0xC")]
	private XUIModelPreviewDragZone m_previewDragZone;

	[Token(Token = "0x4003F0C")]
	[FieldOffset(Offset = "0x10")]
	public Action<string, string> DropChangeDelegate;

	[Token(Token = "0x4003F0D")]
	[FieldOffset(Offset = "0x14")]
	public Action DropFailDelegate;

	[Token(Token = "0x4003F0E")]
	[FieldOffset(Offset = "0x18")]
	public XModuleActor m_actor;

	[Token(Token = "0x4003F0F")]
	[FieldOffset(Offset = "0x1C")]
	public BoxCollider colider;

	[Token(Token = "0x17000CBC")]
	public string CharUID
	{
		[Token(Token = "0x60059BD")]
		[Address(RVA = "0x15CB79C", Offset = "0x15CB79C", VA = "0x15CB79C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CBD")]
	public int CharID
	{
		[Token(Token = "0x60059BE")]
		[Address(RVA = "0x15CB7B4", Offset = "0x15CB7B4", VA = "0x15CB7B4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60059BC")]
	[Address(RVA = "0x15CB794", Offset = "0x15CB794", VA = "0x15CB794")]
	public XWidget_CharacterDropArea()
	{
	}

	[Token(Token = "0x60059BF")]
	[Address(RVA = "0x15CB7CC", Offset = "0x15CB7CC", VA = "0x15CB7CC")]
	public void Build(XUIModelPreviewDragZone previewDragZone, XModuleActor actor)
	{
	}

	[Token(Token = "0x60059C0")]
	[Address(RVA = "0x15CB7D8", Offset = "0x15CB7D8", VA = "0x15CB7D8", Slot = "4")]
	public override void DragDropChange(GameObject dragOBJ)
	{
	}

	[Token(Token = "0x60059C1")]
	[Address(RVA = "0x15CBAA8", Offset = "0x15CBAA8", VA = "0x15CBAA8")]
	private string GetPartyCharID(XWidget_CharacterCard card)
	{
		return null;
	}

	[Token(Token = "0x60059C2")]
	[Address(RVA = "0x15CBA10", Offset = "0x15CBA10", VA = "0x15CBA10")]
	private string GetPartyCharID(XWidget_CharacterDropArea dropArea)
	{
		return null;
	}

	[Token(Token = "0x60059C3")]
	[Address(RVA = "0x15CB9FC", Offset = "0x15CB9FC", VA = "0x15CB9FC")]
	private void CallDropFailDelegate()
	{
	}

	[Token(Token = "0x60059C4")]
	[Address(RVA = "0x15CBB34", Offset = "0x15CBB34", VA = "0x15CBB34")]
	public void DropCardPartyLeave()
	{
	}

	[Token(Token = "0x60059C5")]
	[Address(RVA = "0x15CBBF0", Offset = "0x15CBBF0", VA = "0x15CBBF0")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x60059C6")]
	[Address(RVA = "0x15CBCE8", Offset = "0x15CBCE8", VA = "0x15CBCE8")]
	private void OnDrag(Vector2 delta)
	{
	}
}
