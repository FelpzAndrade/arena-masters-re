using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200021A")]
public static class NGUIText
{
	[Token(Token = "0x200021B")]
	public enum Alignment
	{
		[Token(Token = "0x400090A")]
		Automatic = 0,
		[Token(Token = "0x400090B")]
		Left = 1,
		[Token(Token = "0x400090C")]
		Center = 2,
		[Token(Token = "0x400090D")]
		Right = 3,
		[Token(Token = "0x400090E")]
		Justified = 4
	}

	[Token(Token = "0x200021C")]
	public enum SymbolStyle
	{
		[Token(Token = "0x4000910")]
		None = 0,
		[Token(Token = "0x4000911")]
		Normal = 1,
		[Token(Token = "0x4000912")]
		Colored = 2
	}

	[Token(Token = "0x200021D")]
	public class GlyphInfo
	{
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 v0;

		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 v1;

		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 u0;

		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 u1;

		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 u2;

		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 u3;

		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x38")]
		public float advance;

		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x3C")]
		public int channel;

		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x11ACEB0", Offset = "0x11ACEB0", VA = "0x11ACEB0")]
		public GlyphInfo()
		{
		}
	}

	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x0")]
	public static UIFont bitmapFont;

	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x4")]
	public static Font dynamicFont;

	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x8")]
	public static GlyphInfo glyph;

	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0xC")]
	public static int fontSize;

	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x10")]
	public static float fontScale;

	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x14")]
	public static float pixelDensity;

	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x18")]
	public static FontStyle fontStyle;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x1C")]
	public static Alignment alignment;

	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x20")]
	public static Color tint;

	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x30")]
	public static int rectWidth;

	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x34")]
	public static int rectHeight;

	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x38")]
	public static int regionWidth;

	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x3C")]
	public static int regionHeight;

	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x40")]
	public static int maxLines;

	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x44")]
	public static bool gradient;

	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x48")]
	public static Color gradientBottom;

	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x58")]
	public static Color gradientTop;

	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x68")]
	public static bool encoding;

	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x6C")]
	public static float spacingX;

	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x70")]
	public static float spacingY;

	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x74")]
	public static bool premultiply;

	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x78")]
	public static SymbolStyle symbolStyle;

	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x7C")]
	public static int finalSize;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x80")]
	public static float finalSpacingX;

	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x84")]
	public static float finalLineHeight;

	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x88")]
	public static float baseline;

	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x8C")]
	public static bool useSymbols;

	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x90")]
	private static Color mInvisible;

	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0xA0")]
	private static BetterList<Color> mColors;

	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0xA4")]
	private static float mAlpha;

	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0xA8")]
	private static CharacterInfo mTempChar;

	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0xDC")]
	private static BetterList<float> mSizes;

	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0xE0")]
	private static Color s_c0;

	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0xF0")]
	private static Color s_c1;

	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x100")]
	private static float[] mBoldOffset;

	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x104")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map4;

	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x108")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map5;

	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x10C")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map6;

	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x110")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map7;

	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x11ACEB8", Offset = "0x11ACEB8", VA = "0x11ACEB8")]
	public static void Update()
	{
	}

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x11ACF54", Offset = "0x11ACF54", VA = "0x11ACF54")]
	public static void Update(bool request)
	{
	}

	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x11AD678", Offset = "0x11AD678", VA = "0x11AD678")]
	public static void Prepare(string text)
	{
	}

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x11AD800", Offset = "0x11AD800", VA = "0x11AD800")]
	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return null;
	}

	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x11AD99C", Offset = "0x11AD99C", VA = "0x11AD99C")]
	public static float GetGlyphWidth(int ch, int prev)
	{
		return default(float);
	}

	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x11ADD90", Offset = "0x11ADD90", VA = "0x11ADD90")]
	public static GlyphInfo GetGlyph(int ch, int prev)
	{
		return null;
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x11AECB0", Offset = "0x11AECB0", VA = "0x11AECB0")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float ParseAlpha(string text, int index)
	{
		return default(float);
	}

	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x11AEE44", Offset = "0x11AEE44", VA = "0x11AEE44")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color ParseColor(string text, int offset = 0)
	{
		return default(Color);
	}

	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x11AEEFC", Offset = "0x11AEEFC", VA = "0x11AEEFC")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color ParseColor24(string text, int offset = 0)
	{
		return default(Color);
	}

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x11AF1BC", Offset = "0x11AF1BC", VA = "0x11AF1BC")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color ParseColor32(string text, int offset)
	{
		return default(Color);
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x11AF568", Offset = "0x11AF568", VA = "0x11AF568")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x11AF658", Offset = "0x11AF658", VA = "0x11AF658")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string EncodeColor(string text, Color c)
	{
		return null;
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x11AF970", Offset = "0x11AF970", VA = "0x11AF970")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string EncodeAlpha(float a)
	{
		return null;
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x11AF630", Offset = "0x11AF630", VA = "0x11AF630")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string EncodeColor24(Color c)
	{
		return null;
	}

	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x11AFA5C", Offset = "0x11AFA5C", VA = "0x11AFA5C")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string EncodeColor32(Color c)
	{
		return null;
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x11AFA84", Offset = "0x11AFA84", VA = "0x11AFA84")]
	public static bool ParseSymbol(string text, ref int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x11B0F24", Offset = "0x11B0F24", VA = "0x11B0F24")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static bool IsHex(char ch)
	{
		return default(bool);
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x11AFB88", Offset = "0x11AFB88", VA = "0x11AFB88")]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		return default(bool);
	}

	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x11B0F60", Offset = "0x11B0F60", VA = "0x11B0F60")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x11B113C", Offset = "0x11B113C", VA = "0x11B113C")]
	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth, int elements = 4)
	{
	}

	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x11B19DC", Offset = "0x11B19DC", VA = "0x11B19DC")]
	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x11B1BC0", Offset = "0x11B1BC0", VA = "0x11B1BC0")]
	public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return default(int);
	}

	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x11B1DB0", Offset = "0x11B1DB0", VA = "0x11B1DB0")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static bool IsSpace(int ch)
	{
		return default(bool);
	}

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x11B1DD0", Offset = "0x11B1DD0", VA = "0x11B1DD0")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x11B1F04", Offset = "0x11B1F04", VA = "0x11B1F04")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
	}

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x11B2020", Offset = "0x11B2020", VA = "0x11B2020")]
	public static Vector2 CalculatePrintedSize(string text)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x11B27B4", Offset = "0x11B27B4", VA = "0x11B27B4")]
	public static int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x11B2E24", Offset = "0x11B2E24", VA = "0x11B2E24")]
	public static string GetEndOfLineThatFits(string text)
	{
		return null;
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x11B2EFC", Offset = "0x11B2EFC", VA = "0x11B2EFC")]
	public static bool WrapText(string text, out string finalText, bool wrapLineColors = false)
	{
		finalText = default;
		return default(bool);
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x11B2FC0", Offset = "0x11B2FC0", VA = "0x11B2FC0")]
	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis = false)
	{
		finalText = default;
		return default(bool);
	}

	[Token(Token = "0x60011E9")]
	[Address(RVA = "0x11B5240", Offset = "0x11B5240", VA = "0x11B5240")]
	public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x11B8B64", Offset = "0x11B8B64", VA = "0x11B8B64")]
	public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x11B976C", Offset = "0x11B976C", VA = "0x11B976C")]
	public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x11BA368", Offset = "0x11BA368", VA = "0x11BA368")]
	public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
	}

	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x11BB9EC", Offset = "0x11BB9EC", VA = "0x11BB9EC")]
	public static bool ReplaceLink(ref string text, ref int index, string prefix)
	{
		return default(bool);
	}

	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x11BBEF4", Offset = "0x11BBEF4", VA = "0x11BBEF4")]
	public static bool InsertHyperlink(ref string text, ref int index, string keyword, string link)
	{
		return default(bool);
	}

	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x11BC120", Offset = "0x11BC120", VA = "0x11BC120")]
	public static void ReplaceLinks(ref string text)
	{
	}
}
