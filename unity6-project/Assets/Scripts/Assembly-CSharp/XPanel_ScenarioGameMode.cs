using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D1B")]
public class XPanel_ScenarioGameMode : XPanel_GameBase
{
	[Token(Token = "0x400430F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject root;

	[Token(Token = "0x4004310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_NGUITween bossDescRoot;

	[Token(Token = "0x4004311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblBossDescTop;

	[Token(Token = "0x4004312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblBossDescBot;

	[Token(Token = "0x4004313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public XWidget_CharacterInfo bossInfo;

	[Token(Token = "0x4004314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XUINavigation m_navi;

	[Token(Token = "0x4004315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public TweenPosition bossHitPosTween;

	[Token(Token = "0x4004316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TweenColor bossHitColorTween_Left;

	[Token(Token = "0x4004317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public TweenColor bossHitColorTween_Right;

	[Token(Token = "0x4004318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 m_initTweenPos;

	[Token(Token = "0x6006000")]
	[Address(RVA = "0xAB9230", Offset = "0xAB9230", VA = "0xAB9230")]
	public XPanel_ScenarioGameMode()
	{
	}

	[Token(Token = "0x6006001")]
	[Address(RVA = "0xAB92CC", Offset = "0xAB92CC", VA = "0xAB92CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006002")]
	[Address(RVA = "0xAB933C", Offset = "0xAB933C", VA = "0xAB933C")]
	public void ShowBossDesc(Action onComplete, string descTop, string descBot)
	{
	}

	[Token(Token = "0x6006003")]
	[Address(RVA = "0xAB93F4", Offset = "0xAB93F4", VA = "0xAB93F4")]
	public void HideBossDesc()
	{
	}

	[Token(Token = "0x6006004")]
	[Address(RVA = "0xAB9460", Offset = "0xAB9460", VA = "0xAB9460")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006005")]
	[Address(RVA = "0xAB9494", Offset = "0xAB9494", VA = "0xAB9494")]
	public void Build(CSStageInfo info, bool showAuto)
	{
	}

	[Token(Token = "0x6006006")]
	[Address(RVA = "0xAB95CC", Offset = "0xAB95CC", VA = "0xAB95CC")]
	public void ShowBossHP(bool bShow, [Optional] XModuleActor boss)
	{
	}

	[Token(Token = "0x6006007")]
	[Address(RVA = "0xAB971C", Offset = "0xAB971C", VA = "0xAB971C")]
	public void BossHitEffect(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6006008")]
	[Address(RVA = "0xAB9884", Offset = "0xAB9884", VA = "0xAB9884")]
	private void Update()
	{
	}

	[Token(Token = "0x6006009")]
	[Address(RVA = "0xAB98F4", Offset = "0xAB98F4", VA = "0xAB98F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600600A")]
	[Address(RVA = "0xAB98F8", Offset = "0xAB98F8", VA = "0xAB98F8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600600B")]
	[Address(RVA = "0xAB9A64", Offset = "0xAB9A64", VA = "0xAB9A64")]
	public void SetVisibleTime(bool isActive)
	{
	}
}
