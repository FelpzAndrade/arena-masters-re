using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200027C")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	[Token(Token = "0x200027D")]
	public enum Effect
	{
		[Token(Token = "0x4000BB4")]
		None = 0,
		[Token(Token = "0x4000BB5")]
		Shadow = 1,
		[Token(Token = "0x4000BB6")]
		Outline = 2,
		[Token(Token = "0x4000BB7")]
		Outline8 = 3
	}

	[Token(Token = "0x200027E")]
	public enum Overflow
	{
		[Token(Token = "0x4000BB9")]
		ShrinkContent = 0,
		[Token(Token = "0x4000BBA")]
		ClampContent = 1,
		[Token(Token = "0x4000BBB")]
		ResizeFreely = 2,
		[Token(Token = "0x4000BBC")]
		ResizeHeight = 3
	}

	[Token(Token = "0x200027F")]
	public enum Crispness
	{
		[Token(Token = "0x4000BBE")]
		Never = 0,
		[Token(Token = "0x4000BBF")]
		OnDesktop = 1,
		[Token(Token = "0x4000BC0")]
		Always = 2
	}

	[Token(Token = "0x2000280")]
	public enum Modifier
	{
		[Token(Token = "0x4000BC2")]
		None = 0,
		[Token(Token = "0x4000BC3")]
		ToUppercase = 1,
		[Token(Token = "0x4000BC4")]
		ToLowercase = 2,
		[Token(Token = "0x4000BC5")]
		Custom = 255
	}

	[Token(Token = "0x2000281")]
	public delegate string ModifierFunc(string s);

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x11C")]
	public Crispness keepCrispWhenShrunk;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x120")]
	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	[HideInInspector]
	private UIFont mFont;

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x128")]
	[HideInInspector]
	[SerializeField]
	private string mText;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[HideInInspector]
	private int mFontSize;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x130")]
	[HideInInspector]
	[SerializeField]
	private FontStyle mFontStyle;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x134")]
	[HideInInspector]
	[SerializeField]
	private NGUIText.Alignment mAlignment;

	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x138")]
	[HideInInspector]
	[SerializeField]
	private bool mEncoding;

	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	[HideInInspector]
	private int mMaxLineCount;

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[HideInInspector]
	private Effect mEffectStyle;

	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x154")]
	[HideInInspector]
	[SerializeField]
	private NGUIText.SymbolStyle mSymbols;

	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[HideInInspector]
	private Vector2 mEffectDistance;

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x160")]
	[HideInInspector]
	[SerializeField]
	private Overflow mOverflow;

	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x164")]
	[HideInInspector]
	[SerializeField]
	private Material mMaterial;

	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[HideInInspector]
	private bool mApplyGradient;

	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x16C")]
	[HideInInspector]
	[SerializeField]
	private Color mGradientTop;

	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x17C")]
	[SerializeField]
	[HideInInspector]
	private Color mGradientBottom;

	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x18C")]
	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x190")]
	[HideInInspector]
	[SerializeField]
	private int mSpacingY;

	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x194")]
	[HideInInspector]
	[SerializeField]
	private bool mUseFloatSpacing;

	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x198")]
	[HideInInspector]
	[SerializeField]
	private float mFloatSpacingX;

	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x19C")]
	[HideInInspector]
	[SerializeField]
	private float mFloatSpacingY;

	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[HideInInspector]
	private bool mOverflowEllipsis;

	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x1A4")]
	[SerializeField]
	[HideInInspector]
	private int mOverflowWidth;

	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x1A8")]
	[HideInInspector]
	[SerializeField]
	private Modifier mModifier;

	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x1AC")]
	[SerializeField]
	[HideInInspector]
	private bool mShrinkToFit;

	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[HideInInspector]
	private int mMaxLineWidth;

	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x1B4")]
	[SerializeField]
	[HideInInspector]
	private int mMaxLineHeight;

	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x1B8")]
	[HideInInspector]
	[SerializeField]
	private float mLineWidth;

	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x1BC")]
	[HideInInspector]
	[SerializeField]
	private bool mMultiline;

	[NonSerialized]
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x1C0")]
	private Font mActiveTTF;

	[NonSerialized]
	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x1C4")]
	private float mDensity;

	[NonSerialized]
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x1C8")]
	private bool mShouldBeProcessed;

	[NonSerialized]
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x1CC")]
	private string mProcessedText;

	[NonSerialized]
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x1D0")]
	private bool mPremultiply;

	[NonSerialized]
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x1D4")]
	private Vector2 mCalculatedSize;

	[NonSerialized]
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x1DC")]
	private float mScale;

	[NonSerialized]
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x1E0")]
	private int mFinalFontSize;

	[NonSerialized]
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x1E4")]
	private int mLastWidth;

	[NonSerialized]
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x1E8")]
	private int mLastHeight;

	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x1EC")]
	public ModifierFunc customModifier;

	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x0")]
	private static BetterList<UILabel> mList;

	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<Font, int> mFontUsage;

	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x8")]
	private static List<UIDrawCall> mTempDrawcalls;

	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0xC")]
	private static bool mTexRebuildAdded;

	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x10")]
	private static BetterList<Vector3> mTempVerts;

	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x14")]
	private static BetterList<int> mTempIndices;

	[Token(Token = "0x1700035F")]
	public int finalFontSize
	{
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x1701E38", Offset = "0x1701E38", VA = "0x1701E38")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000360")]
	private bool shouldBeProcessed
	{
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x17020DC", Offset = "0x17020DC", VA = "0x17020DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x17020E4", Offset = "0x17020E4", VA = "0x17020E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000361")]
	public override bool isAnchoredHorizontally
	{
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x17020FC", Offset = "0x17020FC", VA = "0x17020FC", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000362")]
	public override bool isAnchoredVertically
	{
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x1702138", Offset = "0x1702138", VA = "0x1702138", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000363")]
	public override Material material
	{
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x1702174", Offset = "0x1702174", VA = "0x1702174", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x1702314", Offset = "0x1702314", VA = "0x1702314", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000364")]
	public UIFont font
	{
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x1702414", Offset = "0x1702414", VA = "0x1702414")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x170241C", Offset = "0x170241C", VA = "0x170241C")]
		set
		{
		}
	}

	[Token(Token = "0x17000365")]
	public UIFont bitmapFont
	{
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x16F1410", Offset = "0x16F1410", VA = "0x16F1410")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x16F1418", Offset = "0x16F1418", VA = "0x16F1418")]
		set
		{
		}
	}

	[Token(Token = "0x17000366")]
	public Font trueTypeFont
	{
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x1701FA4", Offset = "0x1701FA4", VA = "0x1701FA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x1702420", Offset = "0x1702420", VA = "0x1702420")]
		set
		{
		}
	}

	[Token(Token = "0x17000367")]
	public UnityEngine.Object ambigiousFont
	{
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x1702A24", Offset = "0x1702A24", VA = "0x1702A24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x1702A38", Offset = "0x1702A38", VA = "0x1702A38")]
		set
		{
		}
	}

	[Token(Token = "0x17000368")]
	public string text
	{
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x16F8488", Offset = "0x16F8488", VA = "0x16F8488")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x16F8B50", Offset = "0x16F8B50", VA = "0x16F8B50")]
		set
		{
		}
	}

	[Token(Token = "0x17000369")]
	public int defaultFontSize
	{
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x1702B98", Offset = "0x1702B98", VA = "0x1702B98")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700036A")]
	public int fontSize
	{
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x1702CD4", Offset = "0x1702CD4", VA = "0x1702CD4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x1702CDC", Offset = "0x1702CDC", VA = "0x1702CDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700036B")]
	public FontStyle fontStyle
	{
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x1702DC4", Offset = "0x1702DC4", VA = "0x1702DC4")]
		get
		{
			return default(FontStyle);
		}
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x1702DCC", Offset = "0x1702DCC", VA = "0x1702DCC")]
		set
		{
		}
	}

	[Token(Token = "0x1700036C")]
	public NGUIText.Alignment alignment
	{
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x16F84BC", Offset = "0x16F84BC", VA = "0x16F84BC")]
		get
		{
			return default(NGUIText.Alignment);
		}
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x16F84C4", Offset = "0x16F84C4", VA = "0x16F84C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700036D")]
	public bool applyGradient
	{
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x1702DEC", Offset = "0x1702DEC", VA = "0x1702DEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x1702DF4", Offset = "0x1702DF4", VA = "0x1702DF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700036E")]
	public Color gradientTop
	{
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x1702E50", Offset = "0x1702E50", VA = "0x1702E50")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x1702E60", Offset = "0x1702E60", VA = "0x1702E60")]
		set
		{
		}
	}

	[Token(Token = "0x1700036F")]
	public Color gradientBottom
	{
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x1702F10", Offset = "0x1702F10", VA = "0x1702F10")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x1702F20", Offset = "0x1702F20", VA = "0x1702F20")]
		set
		{
		}
	}

	[Token(Token = "0x17000370")]
	public int spacingX
	{
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x1702FD0", Offset = "0x1702FD0", VA = "0x1702FD0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x1702FD8", Offset = "0x1702FD8", VA = "0x1702FD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000371")]
	public int spacingY
	{
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x170302C", Offset = "0x170302C", VA = "0x170302C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x1703034", Offset = "0x1703034", VA = "0x1703034")]
		set
		{
		}
	}

	[Token(Token = "0x17000372")]
	public bool useFloatSpacing
	{
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x1703088", Offset = "0x1703088", VA = "0x1703088")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x1703090", Offset = "0x1703090", VA = "0x1703090")]
		set
		{
		}
	}

	[Token(Token = "0x17000373")]
	public float floatSpacingX
	{
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x17030B4", Offset = "0x17030B4", VA = "0x17030B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x17030BC", Offset = "0x17030BC", VA = "0x17030BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000374")]
	public float floatSpacingY
	{
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x17031C4", Offset = "0x17031C4", VA = "0x17031C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x17031CC", Offset = "0x17031CC", VA = "0x17031CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000375")]
	public float effectiveSpacingY
	{
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x17032D4", Offset = "0x17032D4", VA = "0x17032D4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000376")]
	public float effectiveSpacingX
	{
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x17032F8", Offset = "0x17032F8", VA = "0x17032F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000377")]
	public bool overflowEllipsis
	{
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x16F84B4", Offset = "0x16F84B4", VA = "0x16F84B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x16F8AF4", Offset = "0x16F8AF4", VA = "0x16F8AF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000378")]
	public int overflowWidth
	{
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x170331C", Offset = "0x170331C", VA = "0x170331C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x1703324", Offset = "0x1703324", VA = "0x1703324")]
		set
		{
		}
	}

	[Token(Token = "0x17000379")]
	private bool keepCrisp
	{
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x1703378", Offset = "0x1703378", VA = "0x1703378")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700037A")]
	public bool supportEncoding
	{
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x1703454", Offset = "0x1703454", VA = "0x1703454")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x16F8490", Offset = "0x16F8490", VA = "0x16F8490")]
		set
		{
		}
	}

	[Token(Token = "0x1700037B")]
	public NGUIText.SymbolStyle symbolStyle
	{
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x170345C", Offset = "0x170345C", VA = "0x170345C")]
		get
		{
			return default(NGUIText.SymbolStyle);
		}
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x1703464", Offset = "0x1703464", VA = "0x1703464")]
		set
		{
		}
	}

	[Token(Token = "0x1700037C")]
	public Overflow overflowMethod
	{
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x16FC01C", Offset = "0x16FC01C", VA = "0x16FC01C")]
		get
		{
			return default(Overflow);
		}
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x1703480", Offset = "0x1703480", VA = "0x1703480")]
		set
		{
		}
	}

	[Token(Token = "0x1700037D")]
	public int lineWidth
	{
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x170349C", Offset = "0x170349C", VA = "0x170349C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x17034A4", Offset = "0x17034A4", VA = "0x17034A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700037E")]
	public int lineHeight
	{
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x17034AC", Offset = "0x17034AC", VA = "0x17034AC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x17034B4", Offset = "0x17034B4", VA = "0x17034B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700037F")]
	public bool multiLine
	{
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x16F697C", Offset = "0x16F697C", VA = "0x16F697C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x17034BC", Offset = "0x17034BC", VA = "0x17034BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000380")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x17034EC", Offset = "0x17034EC", VA = "0x17034EC", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000381")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x1703530", Offset = "0x1703530", VA = "0x1703530", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000382")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x1703568", Offset = "0x1703568", VA = "0x1703568", Slot = "24")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x17000383")]
	public int maxLineCount
	{
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x16FC024", Offset = "0x16FC024", VA = "0x16FC024")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x17035A8", Offset = "0x17035A8", VA = "0x17035A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000384")]
	public Effect effectStyle
	{
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x17036B8", Offset = "0x17036B8", VA = "0x17036B8")]
		get
		{
			return default(Effect);
		}
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x17036C0", Offset = "0x17036C0", VA = "0x17036C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000385")]
	public Color effectColor
	{
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x17036DC", Offset = "0x17036DC", VA = "0x17036DC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x17036EC", Offset = "0x17036EC", VA = "0x17036EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000386")]
	public Vector2 effectDistance
	{
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x1703768", Offset = "0x1703768", VA = "0x1703768")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x170377C", Offset = "0x170377C", VA = "0x170377C")]
		set
		{
		}
	}

	[Token(Token = "0x17000387")]
	public bool shrinkToFit
	{
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x17037D8", Offset = "0x17037D8", VA = "0x17037D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x17037EC", Offset = "0x17037EC", VA = "0x17037EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000388")]
	public string processedText
	{
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x1703814", Offset = "0x1703814", VA = "0x1703814")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000389")]
	public Vector2 printedSize
	{
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x170387C", Offset = "0x170387C", VA = "0x170387C")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700038A")]
	public override Vector2 localSize
	{
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x17038B8", Offset = "0x17038B8", VA = "0x17038B8", Slot = "23")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700038B")]
	private bool isValid
	{
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x17038F8", Offset = "0x17038F8", VA = "0x17038F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700038C")]
	public Modifier modifier
	{
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x1703A00", Offset = "0x1703A00", VA = "0x1703A00")]
		get
		{
			return default(Modifier);
		}
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x1703A08", Offset = "0x1703A08", VA = "0x1703A08")]
		set
		{
		}
	}

	[Token(Token = "0x1700038D")]
	public string printedText
	{
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x1703C6C", Offset = "0x1703C6C", VA = "0x1703C6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001563")]
	[Address(RVA = "0x1701B1C", Offset = "0x1701B1C", VA = "0x1701B1C")]
	public UILabel()
	{
	}

	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x1703A5C", Offset = "0x1703A5C", VA = "0x1703A5C", Slot = "15")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x1703B68", Offset = "0x1703B68", VA = "0x1703B68", Slot = "16")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x1702580", Offset = "0x1702580", VA = "0x1702580")]
	protected void SetActiveFont(Font fnt)
	{
	}

	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x1703E40", Offset = "0x1703E40", VA = "0x1703E40")]
	private static void OnFontChanged(Font font)
	{
	}

	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x17045F0", Offset = "0x17045F0", VA = "0x17045F0", Slot = "13")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x1704630", Offset = "0x1704630", VA = "0x1704630", Slot = "32")]
	protected override void UpgradeFrom265()
	{
	}

	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x170598C", Offset = "0x170598C", VA = "0x170598C", Slot = "18")]
	protected override void OnAnchor()
	{
	}

	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x1702954", Offset = "0x1702954", VA = "0x1702954")]
	private void ProcessAndRequest()
	{
	}

	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x1705AF8", Offset = "0x1705AF8", VA = "0x1705AF8", Slot = "17")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x1705D5C", Offset = "0x1705D5C", VA = "0x1705D5C", Slot = "14")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x1705EC4", Offset = "0x1705EC4", VA = "0x1705EC4", Slot = "21")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x1706164", Offset = "0x1706164", VA = "0x1706164", Slot = "31")]
	public override void MarkAsChanged()
	{
	}

	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x1703524", Offset = "0x1703524", VA = "0x1703524")]
	public void ProcessText()
	{
	}

	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x1704854", Offset = "0x1704854", VA = "0x1704854")]
	private void ProcessText(bool legacyMode, bool full)
	{
	}

	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x1706DEC", Offset = "0x1706DEC", VA = "0x1706DEC", Slot = "33")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x17071BC", Offset = "0x17071BC", VA = "0x17071BC")]
	public void AssumeNaturalSize()
	{
	}

	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x170735C", Offset = "0x170735C", VA = "0x170735C")]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return default(int);
	}

	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x170737C", Offset = "0x170737C", VA = "0x170737C")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return default(int);
	}

	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x16FBA0C", Offset = "0x16FBA0C", VA = "0x16FBA0C")]
	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return default(int);
	}

	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x1707398", Offset = "0x1707398", VA = "0x1707398")]
	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		return default(int);
	}

	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x1707CE0", Offset = "0x1707CE0", VA = "0x1707CE0")]
	public string GetWordAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x1707F30", Offset = "0x1707F30", VA = "0x1707F30")]
	public string GetWordAtPosition(Vector2 localPos)
	{
		return null;
	}

	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x1707D14", Offset = "0x1707D14", VA = "0x1707D14")]
	public string GetWordAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x1707F5C", Offset = "0x1707F5C", VA = "0x1707F5C")]
	public string GetUrlAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x1708178", Offset = "0x1708178", VA = "0x1708178")]
	public string GetUrlAtPosition(Vector2 localPos)
	{
		return null;
	}

	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x1707F90", Offset = "0x1707F90", VA = "0x1707F90")]
	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x17081A4", Offset = "0x17081A4", VA = "0x17081A4")]
	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return default(int);
	}

	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x16FC134", Offset = "0x16FC134", VA = "0x16FC134")]
	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x170892C", Offset = "0x170892C", VA = "0x170892C", Slot = "38")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x170796C", Offset = "0x170796C", VA = "0x170796C")]
	public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x1708DF8", Offset = "0x1708DF8", VA = "0x1708DF8")]
	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols, int start, int end, float x, float y)
	{
	}

	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x16FC02C", Offset = "0x16FC02C", VA = "0x16FC02C")]
	public int CalculateOffsetToFit(string text)
	{
		return default(int);
	}

	[Token(Token = "0x60015D4")]
	[Address(RVA = "0x1709358", Offset = "0x1709358", VA = "0x1709358")]
	public void SetCurrentProgress()
	{
	}

	[Token(Token = "0x60015D5")]
	[Address(RVA = "0x17094A4", Offset = "0x17094A4", VA = "0x17094A4")]
	public void SetCurrentPercent()
	{
	}

	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x17096A4", Offset = "0x17096A4", VA = "0x17096A4")]
	public void SetCurrentSelection()
	{
	}

	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x1709958", Offset = "0x1709958", VA = "0x1709958")]
	public bool Wrap(string text, out string final)
	{
		final = default;
		return default(bool);
	}

	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x1709978", Offset = "0x1709978", VA = "0x1709978")]
	public bool Wrap(string text, out string final, int height)
	{
		final = default;
		return default(bool);
	}

	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x1706178", Offset = "0x1706178", VA = "0x1706178")]
	public void UpdateNGUIText()
	{
	}

	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x1709A98", Offset = "0x1709A98", VA = "0x1709A98")]
	private void OnApplicationPause(bool paused)
	{
	}
}
