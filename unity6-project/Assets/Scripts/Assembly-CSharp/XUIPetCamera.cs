using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CC8")]
public class XUIPetCamera : MonoBehaviour
{
	[Token(Token = "0x40040FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Camera PetCamera;

	[Token(Token = "0x40040FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform AttachPetObject;

	[Token(Token = "0x40040FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private RenderTexture m_renderTexture;

	[Token(Token = "0x4004100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UITexture Drawtexture;

	[Token(Token = "0x4004101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Action m_animationEndAction;

	[Token(Token = "0x4004102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_effect_Normal;

	[Token(Token = "0x4004103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private GameObject m_effect_Epic;

	[Token(Token = "0x4004104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject m_effect_Legend_Ancient;

	[Token(Token = "0x4004105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private GameObject m_selectedEffect;

	[Token(Token = "0x4004106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<KeyValuePair<int, int>, XModuleActor> m_ActorDic;

	[Token(Token = "0x6005C22")]
	[Address(RVA = "0x190D290", Offset = "0x190D290", VA = "0x190D290")]
	public XUIPetCamera()
	{
	}

	[Token(Token = "0x6005C23")]
	[Address(RVA = "0x190D33C", Offset = "0x190D33C", VA = "0x190D33C")]
	private void LoadEffect(XModuleActor.CreationDesc petDescription, bool isLevelUp)
	{
	}

	[Token(Token = "0x6005C24")]
	[Address(RVA = "0x190D74C", Offset = "0x190D74C", VA = "0x190D74C")]
	private void InstantiateEffent(ref GameObject gameObject, string path)
	{
	}

	[Token(Token = "0x6005C25")]
	[Address(RVA = "0x190D8F4", Offset = "0x190D8F4", VA = "0x190D8F4")]
	public void Init([Optional] Action animationEndActon)
	{
	}

	[Token(Token = "0x6005C26")]
	[Address(RVA = "0x190DB60", Offset = "0x190DB60", VA = "0x190DB60")]
	public void CreateResouce(XModuleActor.CreationDesc petDescription, bool isLevelUp = false)
	{
	}

	[Token(Token = "0x6005C27")]
	[Address(RVA = "0x190DE14", Offset = "0x190DE14", VA = "0x190DE14")]
	public void ShowRenderTexture()
	{
	}

	[Token(Token = "0x6005C28")]
	[Address(RVA = "0x190DF00", Offset = "0x190DF00", VA = "0x190DF00")]
	public void EffectShow()
	{
	}

	[Token(Token = "0x6005C29")]
	[Address(RVA = "0x190DFEC", Offset = "0x190DFEC", VA = "0x190DFEC")]
	public void Show()
	{
	}

	[Token(Token = "0x6005C2A")]
	[Address(RVA = "0x190E0D8", Offset = "0x190E0D8", VA = "0x190E0D8")]
	public void PlayPetAnimation()
	{
	}

	[Token(Token = "0x6005C2B")]
	[Address(RVA = "0x190E2E8", Offset = "0x190E2E8", VA = "0x190E2E8")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005C2C")]
	[Address(RVA = "0x190E658", Offset = "0x190E658", VA = "0x190E658")]
	private void PushActor(ref Dictionary<KeyValuePair<int, int>, XModuleActor> dic, int charId, int skinId, XModuleActor moduleActor)
	{
	}

	[Token(Token = "0x6005C2D")]
	[Address(RVA = "0x190DB8C", Offset = "0x190DB8C", VA = "0x190DB8C")]
	private void CreateModel(XModuleActor.CreationDesc creationDesc)
	{
	}

	[Token(Token = "0x6005C2E")]
	[Address(RVA = "0x190E7B4", Offset = "0x190E7B4", VA = "0x190E7B4")]
	public void DestroyModel()
	{
	}
}
