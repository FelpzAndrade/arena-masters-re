using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006A7")]
public static class XNGUIHelper
{
	[Token(Token = "0x20006A8")]
	private sealed class _003CBuildButton_003Ec__AnonStorey12C
	{
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x8")]
		internal Action onClick;

		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x167DC08", Offset = "0x167DC08", VA = "0x167DC08")]
		public _003CBuildButton_003Ec__AnonStorey12C()
		{
		}

		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x167DC10", Offset = "0x167DC10", VA = "0x167DC10")]
		internal void _003C_003Em__18B()
		{
		}
	}

	[Token(Token = "0x60037E4")]
	[Address(RVA = "0x1EDB190", Offset = "0x1EDB190", VA = "0x1EDB190")]
	public static void ResetScrollViewPos(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x60037E5")]
	[Address(RVA = "0x1EDB2E4", Offset = "0x1EDB2E4", VA = "0x1EDB2E4")]
	public static void SetSpriteAspect(UI2DSprite ui2dSprite, Sprite sprite, bool originalSize = false, bool baseOnHeight = true)
	{
	}

	[Token(Token = "0x60037E6")]
	[Address(RVA = "0x1EDB4C0", Offset = "0x1EDB4C0", VA = "0x1EDB4C0")]
	public static void BuildButton(GameObject go, string btnName, Action onClick, bool enable = true)
	{
	}

	[Token(Token = "0x60037E7")]
	[Address(RVA = "0x1EDB9A0", Offset = "0x1EDB9A0", VA = "0x1EDB9A0")]
	public static void PlayTweeners(UITweener[] tweeners, bool bForward = true)
	{
	}

	[Token(Token = "0x60037E8")]
	[Address(RVA = "0x1EDBAC4", Offset = "0x1EDBAC4", VA = "0x1EDBAC4")]
	public static void ResetTweeners(UITweener[] tweeners)
	{
	}

	[Token(Token = "0x60037E9")]
	[Address(RVA = "0x1EDBBE0", Offset = "0x1EDBBE0", VA = "0x1EDBBE0")]
	public static void SetLocale(this UILabel label, string localeKey, params object[] param)
	{
	}

	[Token(Token = "0x60037EA")]
	[Address(RVA = "0x1EDBD98", Offset = "0x1EDBD98", VA = "0x1EDBD98")]
	public static void SetText(this UILabel label, string text)
	{
	}

	[Token(Token = "0x60037EB")]
	[Address(RVA = "0x1EDBE74", Offset = "0x1EDBE74", VA = "0x1EDBE74")]
	public static void SetKoreaJosa(this UILabel label, string text)
	{
	}

	[Token(Token = "0x60037EC")]
	[Address(RVA = "0x1EDC04C", Offset = "0x1EDC04C", VA = "0x1EDC04C")]
	public static void SortParticlSystemsInFrontOfWidget(ParticleSystem[] pss, UIWidget widget)
	{
	}

	[Token(Token = "0x60037ED")]
	[Address(RVA = "0x1EDC288", Offset = "0x1EDC288", VA = "0x1EDC288")]
	public static void ResetAndUpdateAnchors(GameObject go)
	{
	}

	[Token(Token = "0x60037EE")]
	[Address(RVA = "0x1EDC36C", Offset = "0x1EDC36C", VA = "0x1EDC36C")]
	public static void MoveToBoundary(GameObject gameObject, bool spring = true)
	{
	}

	[Token(Token = "0x60037EF")]
	[Address(RVA = "0x1EDCA50", Offset = "0x1EDCA50", VA = "0x1EDCA50")]
	public static void ScrollViewBackupAndRestore(UIScrollView targetScrollView, Action processBuildList, bool overBoundSpring = true)
	{
	}
}
