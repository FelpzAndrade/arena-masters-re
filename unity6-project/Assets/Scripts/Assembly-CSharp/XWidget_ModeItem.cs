using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CD9")]
public class XWidget_ModeItem : MonoBehaviour
{
	[Token(Token = "0x4004187")]
	[FieldOffset(Offset = "0xC")]
	public XWidget_Mark modeMark;

	[Token(Token = "0x4004188")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprSel;

	[Token(Token = "0x4004189")]
	[FieldOffset(Offset = "0x14")]
	public UIBasicSprite sprLock;

	[Token(Token = "0x400418A")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprDisable;

	[Token(Token = "0x400418B")]
	[FieldOffset(Offset = "0x1C")]
	private int m_Index;

	[Token(Token = "0x400418C")]
	[FieldOffset(Offset = "0x20")]
	private GameModeInstanceInfo m_gameModeInstInfo;

	[Token(Token = "0x400418D")]
	[FieldOffset(Offset = "0x24")]
	private Action<int> onClick;

	[Token(Token = "0x6005CD5")]
	[Address(RVA = "0x146A690", Offset = "0x146A690", VA = "0x146A690")]
	public XWidget_ModeItem()
	{
	}

	[Token(Token = "0x6005CD6")]
	[Address(RVA = "0x146A698", Offset = "0x146A698", VA = "0x146A698")]
	public void Build(int index, GameModeInstanceInfo modeInstanceInfo, string modeName, Action<int> acClickCallback)
	{
	}

	[Token(Token = "0x6005CD7")]
	[Address(RVA = "0x146A6BC", Offset = "0x146A6BC", VA = "0x146A6BC")]
	private void BuildModeMark()
	{
	}

	[Token(Token = "0x6005CD8")]
	[Address(RVA = "0x146A8A8", Offset = "0x146A8A8", VA = "0x146A8A8")]
	public void SetPrivateAble(bool isAble)
	{
	}

	[Token(Token = "0x6005CD9")]
	[Address(RVA = "0x146A988", Offset = "0x146A988", VA = "0x146A988")]
	public void SelectedItem(bool isSelected)
	{
	}

	[Token(Token = "0x6005CDA")]
	[Address(RVA = "0x146A9CC", Offset = "0x146A9CC", VA = "0x146A9CC")]
	public void OnClick()
	{
	}
}
