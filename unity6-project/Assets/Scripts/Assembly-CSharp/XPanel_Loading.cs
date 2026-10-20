using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C4C")]
public class XPanel_Loading : MonoSingleton<XPanel_Loading>
{
	[Token(Token = "0x4003E53")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_goLoadingContents;

	[Token(Token = "0x4003E54")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprLoading1;

	[Token(Token = "0x4003E55")]
	[FieldOffset(Offset = "0x14")]
	public UI2DSprite sprLoading2;

	[Token(Token = "0x4003E56")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblGameMode;

	[Token(Token = "0x4003E57")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblTips;

	[Token(Token = "0x4003E58")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_FadeInOut FadeInOut;

	[Token(Token = "0x4003E59")]
	[FieldOffset(Offset = "0x24")]
	private UICamera m_camera;

	[Token(Token = "0x17000CB9")]
	public override bool WillDestroyOnLoad
	{
		[Token(Token = "0x60058FC")]
		[Address(RVA = "0xFFC8EC", Offset = "0xFFC8EC", VA = "0xFFC8EC", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60058FB")]
	[Address(RVA = "0xFFC830", Offset = "0xFFC830", VA = "0xFFC830")]
	public XPanel_Loading()
	{
	}

	[Token(Token = "0x60058FD")]
	[Address(RVA = "0xFFC8F4", Offset = "0xFFC8F4", VA = "0xFFC8F4")]
	public void Start()
	{
	}

	[Token(Token = "0x60058FE")]
	[Address(RVA = "0xFFC8F8", Offset = "0xFFC8F8", VA = "0xFFC8F8", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x60058FF")]
	[Address(RVA = "0xFFCD04", Offset = "0xFFCD04", VA = "0xFFCD04")]
	private void SetTips(bool show)
	{
	}

	[Token(Token = "0x6005900")]
	[Address(RVA = "0xFFCF1C", Offset = "0xFFCF1C", VA = "0xFFCF1C")]
	public void Show(GameFlowTypes prevGameFlowTypes, GameFlowTypes nextFlowType, CSSectorInfo sectorInfo, Action DelayNextLoadingSceneAction)
	{
	}

	[Token(Token = "0x6005901")]
	[Address(RVA = "0xFFD2FC", Offset = "0xFFD2FC", VA = "0xFFD2FC")]
	private void SetGameModeText(GameFlowTypes flow)
	{
	}

	[Token(Token = "0x6005902")]
	[Address(RVA = "0xFFD510", Offset = "0xFFD510", VA = "0xFFD510")]
	private string GetGameModeName()
	{
		return null;
	}

	[Token(Token = "0x6005903")]
	[Address(RVA = "0xFFD778", Offset = "0xFFD778", VA = "0xFFD778")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005904")]
	[Address(RVA = "0xFFD8C4", Offset = "0xFFD8C4", VA = "0xFFD8C4")]
	private void NormalLoadingHide()
	{
	}

	[Token(Token = "0x6005905")]
	[Address(RVA = "0xFFD204", Offset = "0xFFD204", VA = "0xFFD204")]
	private void SetLoadingFadeInOut(bool show, Action fadeOutFinishAction)
	{
	}

	[Token(Token = "0x6005906")]
	[Address(RVA = "0xFFD0BC", Offset = "0xFFD0BC", VA = "0xFFD0BC")]
	private void SetLoadingImage(bool show, string path)
	{
	}

	[Token(Token = "0x6005907")]
	[Address(RVA = "0xFFD9A8", Offset = "0xFFD9A8", VA = "0xFFD9A8")]
	private void UnloadSprite()
	{
	}

	[Token(Token = "0x6005908")]
	[Address(RVA = "0xFFD368", Offset = "0xFFD368", VA = "0xFFD368")]
	private bool IsShowGameModeLabel(GameFlowTypes flow)
	{
		return default(bool);
	}

	[Token(Token = "0x6005909")]
	[Address(RVA = "0xFFDCAC", Offset = "0xFFDCAC", VA = "0xFFDCAC")]
	private void _003CHide_003Em__252()
	{
	}
}
