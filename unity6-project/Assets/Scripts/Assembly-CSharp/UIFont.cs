using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000274")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private UIFont mReplacement;

	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private Font mDynamicFont;

	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[HideInInspector]
	private int mDynamicFontSize;

	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle;

	[NonSerialized]
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x3C")]
	private UISpriteData mSprite;

	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x40")]
	private int mPMA;

	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x44")]
	private int mPacked;

	[Token(Token = "0x1700033E")]
	public BMFont bmFont
	{
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x16EDC0C", Offset = "0x16EDC0C", VA = "0x16EDC0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x16EDCF8", Offset = "0x16EDCF8", VA = "0x16EDCF8")]
		set
		{
		}
	}

	[Token(Token = "0x1700033F")]
	public int texWidth
	{
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x16EDDE8", Offset = "0x16EDDE8", VA = "0x16EDDE8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x16EDEF0", Offset = "0x16EDEF0", VA = "0x16EDEF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000340")]
	public int texHeight
	{
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x16EDFF8", Offset = "0x16EDFF8", VA = "0x16EDFF8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x16EE100", Offset = "0x16EE100", VA = "0x16EE100")]
		set
		{
		}
	}

	[Token(Token = "0x17000341")]
	public bool hasSymbols
	{
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x16EE208", Offset = "0x16EE208", VA = "0x16EE208")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000342")]
	public List<BMSymbol> symbols
	{
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x16EE324", Offset = "0x16EE324", VA = "0x16EE324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000343")]
	public UIAtlas atlas
	{
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x16EE410", Offset = "0x16EE410", VA = "0x16EE410")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x16EE4FC", Offset = "0x16EE4FC", VA = "0x16EE4FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000344")]
	public Material material
	{
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x16EEE1C", Offset = "0x16EEE1C", VA = "0x16EEE1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600150B")]
		[Address(RVA = "0x16EF130", Offset = "0x16EF130", VA = "0x16EF130")]
		set
		{
		}
	}

	[Token(Token = "0x17000345")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x600150C")]
		[Address(RVA = "0x16EF28C", Offset = "0x16EF28C", VA = "0x16EF28C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000346")]
	public bool premultipliedAlphaShader
	{
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x16EF290", Offset = "0x16EF290", VA = "0x16EF290")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000347")]
	public bool packedFontShader
	{
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x16EF524", Offset = "0x16EF524", VA = "0x16EF524")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000348")]
	public Texture2D texture
	{
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x16EF7A4", Offset = "0x16EF7A4", VA = "0x16EF7A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000349")]
	public Rect uvRect
	{
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x16EE9BC", Offset = "0x16EE9BC", VA = "0x16EE9BC")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x16EF940", Offset = "0x16EF940", VA = "0x16EF940")]
		set
		{
		}
	}

	[Token(Token = "0x1700034A")]
	public string spriteName
	{
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x16EFAB8", Offset = "0x16EFAB8", VA = "0x16EFAB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x16EFBB8", Offset = "0x16EFBB8", VA = "0x16EFBB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700034B")]
	public bool isValid
	{
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x16EFD3C", Offset = "0x16EFD3C", VA = "0x16EFD3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700034C")]
	public int size
	{
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x16EFE1C", Offset = "0x16EFE1C", VA = "0x16EFE1C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x16EFF38", Offset = "0x16EFF38", VA = "0x16EFF38")]
		set
		{
		}
	}

	[Token(Token = "0x1700034D")]
	public int defaultSize
	{
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x16EFE20", Offset = "0x16EFE20", VA = "0x16EFE20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x16EFF3C", Offset = "0x16EFF3C", VA = "0x16EFF3C")]
		set
		{
		}
	}

	[Token(Token = "0x1700034E")]
	public UISpriteData sprite
	{
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x16EE6E4", Offset = "0x16EE6E4", VA = "0x16EE6E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700034F")]
	public UIFont replacement
	{
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x16F03F8", Offset = "0x16F03F8", VA = "0x16F03F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x16F0400", Offset = "0x16F0400", VA = "0x16F0400")]
		set
		{
		}
	}

	[Token(Token = "0x17000350")]
	public bool isDynamic
	{
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x16F002C", Offset = "0x16F002C", VA = "0x16F002C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000351")]
	public Font dynamicFont
	{
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x16F068C", Offset = "0x16F068C", VA = "0x16F068C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x16F0778", Offset = "0x16F0778", VA = "0x16F0778")]
		set
		{
		}
	}

	[Token(Token = "0x17000352")]
	public FontStyle dynamicFontStyle
	{
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x16F0928", Offset = "0x16F0928", VA = "0x16F0928")]
		get
		{
			return default(FontStyle);
		}
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x16F0A14", Offset = "0x16F0A14", VA = "0x16F0A14")]
		set
		{
		}
	}

	[Token(Token = "0x17000353")]
	private Texture dynamicTexture
	{
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x16F12E8", Offset = "0x16F12E8", VA = "0x16F12E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x16EDAE0", Offset = "0x16EDAE0", VA = "0x16EDAE0")]
	public UIFont()
	{
	}

	[Token(Token = "0x6001521")]
	[Address(RVA = "0x16F0B20", Offset = "0x16F0B20", VA = "0x16F0B20")]
	private void Trim()
	{
	}

	[Token(Token = "0x6001522")]
	[Address(RVA = "0x16F0EA8", Offset = "0x16F0EA8", VA = "0x16F0EA8")]
	private bool References(UIFont font)
	{
		return default(bool);
	}

	[Token(Token = "0x6001523")]
	[Address(RVA = "0x16F1050", Offset = "0x16F1050", VA = "0x16F1050")]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return default(bool);
	}

	[Token(Token = "0x6001525")]
	[Address(RVA = "0x16EEB5C", Offset = "0x16EEB5C", VA = "0x16EEB5C")]
	public void MarkAsChanged()
	{
	}

	[Token(Token = "0x6001526")]
	[Address(RVA = "0x16F0160", Offset = "0x16F0160", VA = "0x16F0160")]
	public void UpdateUVRect()
	{
	}

	[Token(Token = "0x6001527")]
	[Address(RVA = "0x16F1520", Offset = "0x16F1520", VA = "0x16F1520")]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x6001528")]
	[Address(RVA = "0x16F16F4", Offset = "0x16F16F4", VA = "0x16F16F4")]
	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Token(Token = "0x6001529")]
	[Address(RVA = "0x16F18C0", Offset = "0x16F18C0", VA = "0x16F18C0")]
	public void AddSymbol(string sequence, string spriteName)
	{
	}

	[Token(Token = "0x600152A")]
	[Address(RVA = "0x16F18FC", Offset = "0x16F18FC", VA = "0x16F18FC")]
	public void RemoveSymbol(string sequence)
	{
	}

	[Token(Token = "0x600152B")]
	[Address(RVA = "0x16F19C4", Offset = "0x16F19C4", VA = "0x16F19C4")]
	public void RenameSymbol(string before, string after)
	{
	}

	[Token(Token = "0x600152C")]
	[Address(RVA = "0x16F19F0", Offset = "0x16F19F0", VA = "0x16F19F0")]
	public bool UsesSprite(string s)
	{
		return default(bool);
	}
}
