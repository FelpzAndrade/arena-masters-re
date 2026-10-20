using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FDF")]
public class XWidget_SelectDifficult : MonoBehaviour, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x2000FE0")]
	private sealed class _003CBuild_003Ec__AnonStorey24B
	{
		[Token(Token = "0x40054AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal CSStageInfo stageInfo;

		[Token(Token = "0x40054AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_SelectDifficult _003C_003Ef__this;

		[Token(Token = "0x600766C")]
		[Address(RVA = "0x1347148", Offset = "0x1347148", VA = "0x1347148")]
		public _003CBuild_003Ec__AnonStorey24B()
		{
		}

		[Token(Token = "0x600766D")]
		[Address(RVA = "0x13473B4", Offset = "0x13473B4", VA = "0x13473B4")]
		internal void _003C_003Em__4E3()
		{
		}
	}

	[Token(Token = "0x40054AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string PATH_SPECIAL_SELECT_DIFFICULTY;

	[Token(Token = "0x40054AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblTitle;

	[Token(Token = "0x40054AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridDifficult;

	[Token(Token = "0x40054AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Action m_onClick;

	[Token(Token = "0x6007663")]
	[Address(RVA = "0x1346C64", Offset = "0x1346C64", VA = "0x1346C64")]
	public XWidget_SelectDifficult()
	{
	}

	[Token(Token = "0x6007665")]
	[Address(RVA = "0x1346CFC", Offset = "0x1346CFC", VA = "0x1346CFC")]
	public void Show(int group, [Optional] Action onClick)
	{
	}

	[Token(Token = "0x6007666")]
	[Address(RVA = "0x1346D4C", Offset = "0x1346D4C", VA = "0x1346D4C")]
	private void Build(int group)
	{
	}

	[Token(Token = "0x6007667")]
	[Address(RVA = "0x1347150", Offset = "0x1347150", VA = "0x1347150")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007668")]
	[Address(RVA = "0x1347184", Offset = "0x1347184", VA = "0x1347184")]
	public void OnClick_GoToGameReadyView(CSStageInfo stageInfo)
	{
	}

	[Token(Token = "0x6007669")]
	[Address(RVA = "0x1347278", Offset = "0x1347278", VA = "0x1347278")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x600766A")]
	[Address(RVA = "0x1347350", Offset = "0x1347350", VA = "0x1347350", Slot = "4")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600766B")]
	[Address(RVA = "0x1347380", Offset = "0x1347380", VA = "0x1347380", Slot = "5")]
	public void OnHide()
	{
	}
}
