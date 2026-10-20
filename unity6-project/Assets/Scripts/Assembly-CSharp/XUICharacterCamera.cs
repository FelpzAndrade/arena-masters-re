using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CC7")]
public class XUICharacterCamera : MonoBehaviour
{
	[Token(Token = "0x40040F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Camera CharacterCamera;

	[Token(Token = "0x40040F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform AttachCharacterObject;

	[Token(Token = "0x40040F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private RenderTexture m_renderTexture;

	[Token(Token = "0x40040F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UITexture Drawtexture;

	[Token(Token = "0x40040F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Action m_animationEndAction;

	[Token(Token = "0x40040F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_effect_Normal;

	[Token(Token = "0x40040F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private GameObject m_effect_Epic;

	[Token(Token = "0x40040FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject m_effect_Legend_Ancient;

	[Token(Token = "0x40040FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private GameObject m_selectedEffect;

	[Token(Token = "0x40040FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<KeyValuePair<int, int>, XModuleActor> m_ActorDic;

	[Token(Token = "0x6005C15")]
	[Address(RVA = "0x1A2FC00", Offset = "0x1A2FC00", VA = "0x1A2FC00")]
	public XUICharacterCamera()
	{
	}

	[Token(Token = "0x6005C16")]
	[Address(RVA = "0x1A2FCAC", Offset = "0x1A2FCAC", VA = "0x1A2FCAC")]
	private void LoadEffect(XModuleActor.CreationDesc characterDescription, bool isLevelUp)
	{
	}

	[Token(Token = "0x6005C17")]
	[Address(RVA = "0x1A300C4", Offset = "0x1A300C4", VA = "0x1A300C4")]
	private void InstantiateEffent(ref GameObject gameObject, string path)
	{
	}

	[Token(Token = "0x6005C18")]
	[Address(RVA = "0x1A30274", Offset = "0x1A30274", VA = "0x1A30274")]
	public void Init([Optional] Action animationEndActon)
	{
	}

	[Token(Token = "0x6005C19")]
	[Address(RVA = "0x1A304E0", Offset = "0x1A304E0", VA = "0x1A304E0")]
	public void CreateResouce(XModuleActor.CreationDesc characterDescription, bool isLevelUp = false)
	{
	}

	[Token(Token = "0x6005C1A")]
	[Address(RVA = "0x1A3077C", Offset = "0x1A3077C", VA = "0x1A3077C")]
	public void ShowRenderTexture()
	{
	}

	[Token(Token = "0x6005C1B")]
	[Address(RVA = "0x1A30868", Offset = "0x1A30868", VA = "0x1A30868")]
	public void EffectShow()
	{
	}

	[Token(Token = "0x6005C1C")]
	[Address(RVA = "0x1A30954", Offset = "0x1A30954", VA = "0x1A30954")]
	public void Show()
	{
	}

	[Token(Token = "0x6005C1D")]
	[Address(RVA = "0x1A30A40", Offset = "0x1A30A40", VA = "0x1A30A40")]
	public void PlayCharacterAnimation()
	{
	}

	[Token(Token = "0x6005C1E")]
	[Address(RVA = "0x1A30C50", Offset = "0x1A30C50", VA = "0x1A30C50")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005C1F")]
	[Address(RVA = "0x1A30FC0", Offset = "0x1A30FC0", VA = "0x1A30FC0")]
	private void PushActor(ref Dictionary<KeyValuePair<int, int>, XModuleActor> dic, int charId, int skinId, XModuleActor moduleActor)
	{
	}

	[Token(Token = "0x6005C20")]
	[Address(RVA = "0x1A3050C", Offset = "0x1A3050C", VA = "0x1A3050C")]
	private void CreateModel(XModuleActor.CreationDesc creationDesc)
	{
	}

	[Token(Token = "0x6005C21")]
	[Address(RVA = "0x1A3111C", Offset = "0x1A3111C", VA = "0x1A3111C")]
	public void DestroyModel()
	{
	}
}
