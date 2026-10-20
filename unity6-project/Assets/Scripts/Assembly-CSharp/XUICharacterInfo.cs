using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D74")]
public class XUICharacterInfo : MonoBehaviour, XModuleInterface.IModuleInterfaceEventReciever
{
	[Token(Token = "0x4004560")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_CharacterInfo mainCharInfo;

	[Token(Token = "0x4004561")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_CharacterInfo tagCharInfo;

	[Token(Token = "0x4004562")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition userInfo;

	[Token(Token = "0x4004563")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition tagUserInfo;

	[Token(Token = "0x4004564")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha userInfoAlpha;

	[Token(Token = "0x4004565")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite portraitFrame;

	[Token(Token = "0x4004566")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite tagPortraitFrame;

	[Token(Token = "0x4004567")]
	[FieldOffset(Offset = "0x28")]
	private UIPanel userInfoPanel;

	[Token(Token = "0x4004568")]
	[FieldOffset(Offset = "0x2C")]
	private UIPanel tagUserInfoPanel;

	[Token(Token = "0x4004569")]
	[FieldOffset(Offset = "0x30")]
	private bool tweenState;

	[Token(Token = "0x60062C0")]
	[Address(RVA = "0x1A31340", Offset = "0x1A31340", VA = "0x1A31340")]
	public XUICharacterInfo()
	{
	}

	[Token(Token = "0x60062C1")]
	[Address(RVA = "0x1A31348", Offset = "0x1A31348", VA = "0x1A31348")]
	public void Build(XModuleActor actor)
	{
	}

	[Token(Token = "0x60062C2")]
	[Address(RVA = "0x1A314F4", Offset = "0x1A314F4", VA = "0x1A314F4")]
	public void SetUserInfoDepth(int addValue)
	{
	}

	[Token(Token = "0x60062C3")]
	[Address(RVA = "0x1A3162C", Offset = "0x1A3162C", VA = "0x1A3162C")]
	public void SetTagUserInfoDepth(int addValue)
	{
	}

	[Token(Token = "0x60062C4")]
	[Address(RVA = "0x1A31764", Offset = "0x1A31764", VA = "0x1A31764")]
	public void SwitchTweenCharacterImage()
	{
	}

	[Token(Token = "0x60062C5")]
	[Address(RVA = "0x1A31888", Offset = "0x1A31888", VA = "0x1A31888")]
	public void TweenAlphaUserInfo()
	{
	}

	[Token(Token = "0x60062C6")]
	[Address(RVA = "0x1A318EC", Offset = "0x1A318EC", VA = "0x1A318EC")]
	private void FinishTweenAlphaUserInfo()
	{
	}

	[Token(Token = "0x60062C7")]
	[Address(RVA = "0x1A31918", Offset = "0x1A31918", VA = "0x1A31918", Slot = "4")]
	public void OnActorTag()
	{
	}

	[Token(Token = "0x60062C8")]
	[Address(RVA = "0x1A3191C", Offset = "0x1A3191C", VA = "0x1A3191C")]
	public void ClearResource()
	{
	}
}
