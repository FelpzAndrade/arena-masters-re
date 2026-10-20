using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x200043F")]
public class XAsyncLoadOperator : XCharacterLoadOperator
{
	[Token(Token = "0x2000440")]
	private enum LoadState
	{
		[Token(Token = "0x40014C1")]
		Mesh = 0,
		[Token(Token = "0x40014C2")]
		Ani = 1,
		[Token(Token = "0x40014C3")]
		AniMesh = 2,
		[Token(Token = "0x40014C4")]
		Effect = 3,
		[Token(Token = "0x40014C5")]
		Skill = 4,
		[Token(Token = "0x40014C6")]
		Complete = 5,
		[Token(Token = "0x40014C7")]
		End = 6
	}

	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x18")]
	private bool m_loadEffect;

	[Token(Token = "0x40014BD")]
	[FieldOffset(Offset = "0x1C")]
	private LoadState m_loadState;

	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<LoadState, List<XAssetBundleLoadAssetOperation>> m_resDic;

	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x24")]
	private List<Action> m_completeFuncList;

	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x1EFB858", Offset = "0x1EFB858", VA = "0x1EFB858")]
	public XAsyncLoadOperator(List<XModuleActor.CreationDesc> descList, bool loadEffect, bool loadChangeChar)
	{
	}

	[Token(Token = "0x6002200")]
	[Address(RVA = "0x1EFBA00", Offset = "0x1EFBA00", VA = "0x1EFBA00")]
	public XAsyncLoadOperator(XModuleActor.CreationDesc desc, bool loadEffect, bool loadChangeChar)
	{
	}

	[Token(Token = "0x6002201")]
	[Address(RVA = "0x1EFBBA8", Offset = "0x1EFBBA8", VA = "0x1EFBBA8", Slot = "6")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6002202")]
	[Address(RVA = "0x1EFC214", Offset = "0x1EFC214", VA = "0x1EFC214", Slot = "4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6002203")]
	[Address(RVA = "0x1EFC5C8", Offset = "0x1EFC5C8", VA = "0x1EFC5C8")]
	private void PushObjectPool(LoadState state, XPoolType type)
	{
	}

	[Token(Token = "0x6002204")]
	[Address(RVA = "0x1EFCB54", Offset = "0x1EFCB54", VA = "0x1EFCB54")]
	public void CooldownEffect(XPoolType type, GameObject obj)
	{
	}

	[Token(Token = "0x6002205")]
	[Address(RVA = "0x1EFCC30", Offset = "0x1EFCC30", VA = "0x1EFCC30")]
	public void AddCompleteFunc(Action complete)
	{
	}

	[Token(Token = "0x6002206")]
	[Address(RVA = "0x1EFCCD0", Offset = "0x1EFCCD0", VA = "0x1EFCCD0")]
	public void ClearCompleteFunc()
	{
	}

	[Token(Token = "0x6002207")]
	[Address(RVA = "0x1EFCD68", Offset = "0x1EFCD68", VA = "0x1EFCD68", Slot = "5")]
	public override bool LoadDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6002208")]
	[Address(RVA = "0x1EFCD7C", Offset = "0x1EFCD7C", VA = "0x1EFCD7C", Slot = "7")]
	protected override void SkipOperatorDone()
	{
	}

	[Token(Token = "0x6002209")]
	[Address(RVA = "0x1EFBC9C", Offset = "0x1EFBC9C", VA = "0x1EFBC9C")]
	private void PreloadMesh()
	{
	}

	[Token(Token = "0x600220A")]
	[Address(RVA = "0x1EFCEC0", Offset = "0x1EFCEC0", VA = "0x1EFCEC0", Slot = "8")]
	protected override void LoadAnimationClip(string aniKey, string path, ref List<KeyValuePair<string, XAniClipLoadOperation>> aniReqList)
	{
	}

	[Token(Token = "0x600220B")]
	[Address(RVA = "0x1EFCD88", Offset = "0x1EFCD88", VA = "0x1EFCD88")]
	private List<XAssetBundleLoadAssetOperation> GetReqDic(LoadState state)
	{
		return null;
	}

	[Token(Token = "0x600220C")]
	[Address(RVA = "0x1EFC428", Offset = "0x1EFC428", VA = "0x1EFC428")]
	private void CheckLoadDone(LoadState state, Action complete)
	{
	}

	[Token(Token = "0x600220D")]
	[Address(RVA = "0x1EFD034", Offset = "0x1EFD034", VA = "0x1EFD034", Slot = "9")]
	protected override bool CheckLoadEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600220E")]
	[Address(RVA = "0x1EFD03C", Offset = "0x1EFD03C", VA = "0x1EFD03C", Slot = "10")]
	protected override void PreloadCharacterEffects(CSCharacterInfo characterInfo, int skinId)
	{
	}

	[Token(Token = "0x600220F")]
	[Address(RVA = "0x1EFD044", Offset = "0x1EFD044", VA = "0x1EFD044", Slot = "11")]
	protected override void PreloadRelicEffects(int relicSkillId)
	{
	}

	[Token(Token = "0x6002210")]
	[Address(RVA = "0x1EFD04C", Offset = "0x1EFD04C", VA = "0x1EFD04C", Slot = "12")]
	protected override void loadEffect(string resName)
	{
	}

	[Token(Token = "0x6002211")]
	[Address(RVA = "0x1EFD050", Offset = "0x1EFD050", VA = "0x1EFD050", Slot = "13")]
	protected override void loadSkill(string resName)
	{
	}

	[Token(Token = "0x6002212")]
	[Address(RVA = "0x1EFD1A0", Offset = "0x1EFD1A0", VA = "0x1EFD1A0")]
	private void _003COnUpdate_003Em__CF()
	{
	}

	[Token(Token = "0x6002213")]
	[Address(RVA = "0x1EFD1C0", Offset = "0x1EFD1C0", VA = "0x1EFD1C0")]
	private void _003COnUpdate_003Em__D0()
	{
	}

	[Token(Token = "0x6002214")]
	[Address(RVA = "0x1EFD1E0", Offset = "0x1EFD1E0", VA = "0x1EFD1E0")]
	private void _003COnUpdate_003Em__D1()
	{
	}

	[Token(Token = "0x6002215")]
	[Address(RVA = "0x1EFD20C", Offset = "0x1EFD20C", VA = "0x1EFD20C")]
	private void _003COnUpdate_003Em__D2()
	{
	}

	[Token(Token = "0x6002216")]
	[Address(RVA = "0x1EFD230", Offset = "0x1EFD230", VA = "0x1EFD230")]
	private void _003COnUpdate_003Em__D3()
	{
	}
}
