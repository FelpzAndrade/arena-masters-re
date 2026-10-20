using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004A3")]
public class XSyncLoadOperator : XCharacterLoadOperator
{
	[Token(Token = "0x20004A4")]
	private enum LoadState
	{
		[Token(Token = "0x400173E")]
		CreateAniMesh = 0,
		[Token(Token = "0x400173F")]
		Effect = 1,
		[Token(Token = "0x4001740")]
		Complete = 2,
		[Token(Token = "0x4001741")]
		End = 3
	}

	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x18")]
	private LoadState m_loadState;

	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x1831B74", Offset = "0x1831B74", VA = "0x1831B74")]
	public XSyncLoadOperator(List<XModuleActor.CreationDesc> descList)
	{
	}

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x1831CA0", Offset = "0x1831CA0", VA = "0x1831CA0")]
	public XSyncLoadOperator(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x1831DCC", Offset = "0x1831DCC", VA = "0x1831DCC", Slot = "6")]
	protected override void Init()
	{
	}

	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x1831EE8", Offset = "0x1831EE8", VA = "0x1831EE8", Slot = "4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x1831F10", Offset = "0x1831F10", VA = "0x1831F10", Slot = "5")]
	public override bool LoadDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x1831F24", Offset = "0x1831F24", VA = "0x1831F24", Slot = "7")]
	protected override void SkipOperatorDone()
	{
	}

	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x1831F30", Offset = "0x1831F30", VA = "0x1831F30", Slot = "8")]
	protected override void LoadAnimationClip(string aniKey, string path, ref List<KeyValuePair<string, XAniClipLoadOperation>> aniReqList)
	{
	}

	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x18320C4", Offset = "0x18320C4", VA = "0x18320C4", Slot = "9")]
	protected override bool CheckLoadEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x18320CC", Offset = "0x18320CC", VA = "0x18320CC", Slot = "10")]
	protected override void PreloadCharacterEffects(CSCharacterInfo characterInfo, int skinId)
	{
	}

	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x18320D4", Offset = "0x18320D4", VA = "0x18320D4", Slot = "11")]
	protected override void PreloadRelicEffects(int relicSkillId)
	{
	}

	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x18320DC", Offset = "0x18320DC", VA = "0x18320DC", Slot = "12")]
	protected override void loadEffect(string resName)
	{
	}

	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x18320E0", Offset = "0x18320E0", VA = "0x18320E0", Slot = "13")]
	protected override void loadSkill(string resName)
	{
	}

	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x18321C4", Offset = "0x18321C4", VA = "0x18321C4")]
	private void PushAsset(XPoolType type, string resName)
	{
	}

	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x18325C8", Offset = "0x18325C8", VA = "0x18325C8")]
	public void CooldownEffect(XPoolType type, GameObject obj)
	{
	}
}
