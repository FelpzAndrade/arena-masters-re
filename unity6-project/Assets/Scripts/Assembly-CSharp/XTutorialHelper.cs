using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C0D")]
public class XTutorialHelper
{
	[Token(Token = "0x2000C0E")]
	private sealed class _003CButtonLink_003Ec__AnonStorey16C
	{
		[Token(Token = "0x4003CF8")]
		[FieldOffset(Offset = "0x8")]
		internal XUITutorialTarget tutoTargetData;

		[Token(Token = "0x4003CF9")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_TutorialButton widgetButton;

		[Token(Token = "0x4003CFA")]
		[FieldOffset(Offset = "0x10")]
		internal Action restoreAction;

		[Token(Token = "0x600572A")]
		[Address(RVA = "0x184D3C0", Offset = "0x184D3C0", VA = "0x184D3C0")]
		public _003CButtonLink_003Ec__AnonStorey16C()
		{
		}

		[Token(Token = "0x600572B")]
		[Address(RVA = "0x184DAD8", Offset = "0x184DAD8", VA = "0x184DAD8")]
		internal void _003C_003Em__236()
		{
		}

		[Token(Token = "0x600572C")]
		[Address(RVA = "0x184DB1C", Offset = "0x184DB1C", VA = "0x184DB1C")]
		internal void _003C_003Em__237()
		{
		}
	}

	[Token(Token = "0x6005724")]
	[Address(RVA = "0x184BFBC", Offset = "0x184BFBC", VA = "0x184BFBC")]
	public XTutorialHelper()
	{
	}

	[Token(Token = "0x6005725")]
	[Address(RVA = "0x184BFC4", Offset = "0x184BFC4", VA = "0x184BFC4")]
	public static List<Transform> GetTutorialTargetTransform(string objNames)
	{
		return null;
	}

	[Token(Token = "0x6005726")]
	[Address(RVA = "0x184C62C", Offset = "0x184C62C", VA = "0x184C62C")]
	public static List<XUITutorialTarget> GetTutorialTargetTransform(string objNames, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6005727")]
	[Address(RVA = "0x184D0EC", Offset = "0x184D0EC", VA = "0x184D0EC")]
	public static void ButtonLink(XUITutorialTarget tutoTargetData, Action nextCallBack, bool isDisableClickComponent = false, bool usePress = false)
	{
	}

	[Token(Token = "0x6005728")]
	[Address(RVA = "0x184D3C8", Offset = "0x184D3C8", VA = "0x184D3C8")]
	private static void GetPivotFactor(UIWidget widget, out int factorX, out int factorY)
	{
		factorX = default;
		factorY = default;
	}

	[Token(Token = "0x6005729")]
	[Address(RVA = "0x184D490", Offset = "0x184D490", VA = "0x184D490")]
	public static void BuildArrow(UIBasicSprite arrow, GameObject targetObj, TutoImgLocation loc, bool usePivotPos, bool immediatelyTweenPlay)
	{
	}
}
