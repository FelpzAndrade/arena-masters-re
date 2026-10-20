using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006EA")]
public class XUIModelPreviewDragZone : MonoBehaviour
{
	[Token(Token = "0x400212C")]
	[FieldOffset(Offset = "0xC")]
	public UITexture texture;

	[Token(Token = "0x1700081E")]
	private XUIModelPreview m_ModelPreview
	{
		[Token(Token = "0x60039F0")]
		[Address(RVA = "0x10D50D8", Offset = "0x10D50D8", VA = "0x10D50D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60039EF")]
	[Address(RVA = "0x10D50D0", Offset = "0x10D50D0", VA = "0x10D50D0")]
	public XUIModelPreviewDragZone()
	{
	}

	[Token(Token = "0x60039F1")]
	[Address(RVA = "0x10D51A8", Offset = "0x10D51A8", VA = "0x10D51A8")]
	public void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60039F2")]
	[Address(RVA = "0x10D51E4", Offset = "0x10D51E4", VA = "0x10D51E4")]
	public void ShowModelPreview()
	{
	}

	[Token(Token = "0x60039F3")]
	[Address(RVA = "0x10D5294", Offset = "0x10D5294", VA = "0x10D5294")]
	public void ShowModelPreview(List<XModuleActor> list, bool bCenter = false)
	{
	}

	[Token(Token = "0x60039F4")]
	[Address(RVA = "0x10D52F0", Offset = "0x10D52F0", VA = "0x10D52F0")]
	public void ShowModelPreview(XModuleActor actor, bool bCenter = false)
	{
	}

	[Token(Token = "0x60039F5")]
	[Address(RVA = "0x10D5410", Offset = "0x10D5410", VA = "0x10D5410")]
	public void ShowSkinModelPreview(XModuleActor actor, int skinId, bool bCenter = false)
	{
	}

	[Token(Token = "0x60039F6")]
	[Address(RVA = "0x10D5224", Offset = "0x10D5224", VA = "0x10D5224")]
	private void InitRenderTexture()
	{
	}

	[Token(Token = "0x60039F7")]
	[Address(RVA = "0x10D54A8", Offset = "0x10D54A8", VA = "0x10D54A8")]
	private void ReleaseRenderTexture()
	{
	}

	[Token(Token = "0x60039F8")]
	[Address(RVA = "0x10D55CC", Offset = "0x10D55CC", VA = "0x10D55CC")]
	public void ResetRotate()
	{
	}

	[Token(Token = "0x60039F9")]
	[Address(RVA = "0x10D55F4", Offset = "0x10D55F4", VA = "0x10D55F4")]
	public void SetDragActor(int charID)
	{
	}

	[Token(Token = "0x60039FA")]
	[Address(RVA = "0x10D5624", Offset = "0x10D5624", VA = "0x10D5624")]
	public void HideModelPreview()
	{
	}

	[Token(Token = "0x60039FB")]
	[Address(RVA = "0x10D565C", Offset = "0x10D565C", VA = "0x10D565C")]
	public void SetScaleFactor(float scaleFactor)
	{
	}
}
