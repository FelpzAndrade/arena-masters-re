using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000471")]
public class XMaterialChanger
{
	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, Material[]> defaultMaterialDictionary;

	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, Material[]> inGameMaterialDictionary;

	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Material[]> lobbyMaterialDictionary;

	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, Material[]> dissolveMaterialDictionary;

	[Token(Token = "0x600256C")]
	[Address(RVA = "0x1E2E334", Offset = "0x1E2E334", VA = "0x1E2E334")]
	public XMaterialChanger()
	{
	}

	[Token(Token = "0x600256D")]
	[Address(RVA = "0x1E2E428", Offset = "0x1E2E428", VA = "0x1E2E428")]
	public void Clear()
	{
	}

	[Token(Token = "0x600256E")]
	[Address(RVA = "0x1E2E564", Offset = "0x1E2E564", VA = "0x1E2E564")]
	private void DictionaryClear(Dictionary<string, Material[]> dic)
	{
	}

	[Token(Token = "0x600256F")]
	[Address(RVA = "0x1E2E770", Offset = "0x1E2E770", VA = "0x1E2E770")]
	public void CachingMaterials(SkinnedMeshRenderer[] skinnedMeshRenderers)
	{
	}

	[Token(Token = "0x6002570")]
	[Address(RVA = "0x1E2F66C", Offset = "0x1E2F66C", VA = "0x1E2F66C")]
	private Material MaterialLoad(Material baseMaterial, string defaultPath, string doublePath)
	{
		return null;
	}

	[Token(Token = "0x6002571")]
	[Address(RVA = "0x1E2ED24", Offset = "0x1E2ED24", VA = "0x1E2ED24")]
	private void CachingDefaultMaterial(SkinnedMeshRenderer mesh, int j)
	{
	}

	[Token(Token = "0x6002572")]
	[Address(RVA = "0x1E2EE64", Offset = "0x1E2EE64", VA = "0x1E2EE64")]
	private void CachingInGameMaterial(SkinnedMeshRenderer mesh, int j)
	{
	}

	[Token(Token = "0x6002573")]
	[Address(RVA = "0x1E2F488", Offset = "0x1E2F488", VA = "0x1E2F488")]
	private void CachingDissolveMaterial(SkinnedMeshRenderer mesh, int j)
	{
	}

	[Token(Token = "0x6002574")]
	[Address(RVA = "0x1E2F2A4", Offset = "0x1E2F2A4", VA = "0x1E2F2A4")]
	private void CachingLobbyMaterial(SkinnedMeshRenderer mesh, int j)
	{
	}

	[Token(Token = "0x6002575")]
	[Address(RVA = "0x1E2F8B4", Offset = "0x1E2F8B4", VA = "0x1E2F8B4")]
	private void TextureCopy(Material baseMaterial, Material targetMaterial)
	{
	}

	[Token(Token = "0x6002576")]
	[Address(RVA = "0x1E2FA18", Offset = "0x1E2FA18", VA = "0x1E2FA18")]
	public void SetDefaultMaterials(SkinnedMeshRenderer[] skinnedMeshRenderers)
	{
	}

	[Token(Token = "0x6002577")]
	[Address(RVA = "0x1E2FC44", Offset = "0x1E2FC44", VA = "0x1E2FC44")]
	public void SetInGameMaterials(SkinnedMeshRenderer[] skinnedMeshRenderers)
	{
	}

	[Token(Token = "0x6002578")]
	[Address(RVA = "0x1E2FC4C", Offset = "0x1E2FC4C", VA = "0x1E2FC4C")]
	public void SetLobbyMaterials(SkinnedMeshRenderer[] skinnedMeshRenderers)
	{
	}

	[Token(Token = "0x6002579")]
	[Address(RVA = "0x1E2FC54", Offset = "0x1E2FC54", VA = "0x1E2FC54")]
	public void SetDissolveMaterials(SkinnedMeshRenderer[] skinnedMeshRenderers)
	{
	}

	[Token(Token = "0x600257A")]
	[Address(RVA = "0x1E2FA20", Offset = "0x1E2FA20", VA = "0x1E2FA20")]
	private void SetMaterials(SkinnedMeshRenderer[] skinnedMeshRenderers, Dictionary<string, Material[]> materialDictionary)
	{
	}
}
