using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D80")]
public class XUIHitCombo : MonoBehaviour
{
	[Token(Token = "0x2000D81")]
	protected class Entry
	{
		[Token(Token = "0x4004601")]
		[FieldOffset(Offset = "0x8")]
		public float time;

		[Token(Token = "0x4004602")]
		[FieldOffset(Offset = "0xC")]
		public float outingTime;

		[Token(Token = "0x4004603")]
		[FieldOffset(Offset = "0x10")]
		public float offsetX;

		[Token(Token = "0x4004604")]
		[FieldOffset(Offset = "0x14")]
		public float offsetY;

		[Token(Token = "0x4004605")]
		[FieldOffset(Offset = "0x18")]
		public UILabel label;

		[Token(Token = "0x4004606")]
		[FieldOffset(Offset = "0x1C")]
		public Color initColor;

		[Token(Token = "0x4004607")]
		[FieldOffset(Offset = "0x2C")]
		public bool outing;

		[Token(Token = "0x600633A")]
		[Address(RVA = "0x108C27C", Offset = "0x108C27C", VA = "0x108C27C")]
		public Entry()
		{
		}
	}

	[Token(Token = "0x40045DC")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	[SerializeField]
	private UIFont font;

	[Token(Token = "0x40045DD")]
	[FieldOffset(Offset = "0x10")]
	public UIFont bitmapFont;

	[Token(Token = "0x40045DE")]
	[FieldOffset(Offset = "0x14")]
	public Font trueTypeFont;

	[Token(Token = "0x40045DF")]
	[FieldOffset(Offset = "0x18")]
	public int fontSize;

	[Token(Token = "0x40045E0")]
	[FieldOffset(Offset = "0x1C")]
	public FontStyle fontStyle;

	[Token(Token = "0x40045E1")]
	[FieldOffset(Offset = "0x20")]
	public bool applyGradient;

	[Token(Token = "0x40045E2")]
	[FieldOffset(Offset = "0x24")]
	public Color gradientTop;

	[Token(Token = "0x40045E3")]
	[FieldOffset(Offset = "0x34")]
	public Color gradienBottom;

	[Token(Token = "0x40045E4")]
	[FieldOffset(Offset = "0x44")]
	public Color hitGradientTop;

	[Token(Token = "0x40045E5")]
	[FieldOffset(Offset = "0x54")]
	public Color hitGradienBottom;

	[Token(Token = "0x40045E6")]
	[FieldOffset(Offset = "0x64")]
	public UILabel.Effect effect;

	[Token(Token = "0x40045E7")]
	[FieldOffset(Offset = "0x68")]
	public Color effectColor;

	[Token(Token = "0x40045E8")]
	[FieldOffset(Offset = "0x78")]
	public int effectX;

	[Token(Token = "0x40045E9")]
	[FieldOffset(Offset = "0x7C")]
	public int effectY;

	[Token(Token = "0x40045EA")]
	[FieldOffset(Offset = "0x80")]
	public int spacingX;

	[Token(Token = "0x40045EB")]
	[FieldOffset(Offset = "0x84")]
	public int spacingY;

	[Token(Token = "0x40045EC")]
	[FieldOffset(Offset = "0x88")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x40045ED")]
	[FieldOffset(Offset = "0x8C")]
	public AnimationCurve offsetCurveX;

	[Token(Token = "0x40045EE")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve offsetCurveY;

	[Token(Token = "0x40045EF")]
	[FieldOffset(Offset = "0x94")]
	public AnimationCurve outOffsetCurveX;

	[Token(Token = "0x40045F0")]
	[FieldOffset(Offset = "0x98")]
	public AnimationCurve outOffsetCurveY;

	[Token(Token = "0x40045F1")]
	[FieldOffset(Offset = "0x9C")]
	public AnimationCurve alphaCurve;

	[Token(Token = "0x40045F2")]
	[FieldOffset(Offset = "0xA0")]
	public AnimationCurve scaleCurve;

	[Token(Token = "0x40045F3")]
	[FieldOffset(Offset = "0xA4")]
	public AnimationCurve flashCurve;

	[Token(Token = "0x40045F4")]
	[FieldOffset(Offset = "0xA8")]
	public AnimationCurve hitScaleCurve;

	[Token(Token = "0x40045F5")]
	[FieldOffset(Offset = "0xAC")]
	public Transform lblHitTransform;

	[Token(Token = "0x40045F6")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel lblHit;

	[Token(Token = "0x40045F7")]
	[FieldOffset(Offset = "0xB4")]
	public Color lblHitColor;

	[Token(Token = "0x40045F8")]
	[FieldOffset(Offset = "0xC4")]
	public float timeScale;

	[Token(Token = "0x40045F9")]
	[FieldOffset(Offset = "0xC8")]
	public float offsetScale;

	[Token(Token = "0x40045FA")]
	[FieldOffset(Offset = "0xCC")]
	public int MaxLabel;

	[Token(Token = "0x40045FB")]
	[FieldOffset(Offset = "0xD0")]
	public float stayTime;

	[Token(Token = "0x40045FC")]
	[FieldOffset(Offset = "0xD4")]
	public float firstMoveTime;

	[Token(Token = "0x40045FD")]
	[FieldOffset(Offset = "0xD8")]
	private List<Entry> mList;

	[Token(Token = "0x40045FE")]
	[FieldOffset(Offset = "0xDC")]
	private List<Entry> mUnused;

	[Token(Token = "0x40045FF")]
	[FieldOffset(Offset = "0xE0")]
	private int counter;

	[Token(Token = "0x4004600")]
	[FieldOffset(Offset = "0xE4")]
	private bool mUseDynamicFont;

	[Token(Token = "0x17000D37")]
	public bool isVisible
	{
		[Token(Token = "0x600632D")]
		[Address(RVA = "0x108B6B4", Offset = "0x108B6B4", VA = "0x108B6B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000D38")]
	public Object ambigiousFont
	{
		[Token(Token = "0x600632E")]
		[Address(RVA = "0x108B754", Offset = "0x108B754", VA = "0x108B754")]
		get
		{
			return null;
		}
		[Token(Token = "0x600632F")]
		[Address(RVA = "0x108B870", Offset = "0x108B870", VA = "0x108B870")]
		set
		{
		}
	}

	[Token(Token = "0x6006329")]
	[Address(RVA = "0x108AC64", Offset = "0x108AC64", VA = "0x108AC64")]
	public XUIHitCombo()
	{
	}

	[Token(Token = "0x600632A")]
	[Address(RVA = "0x108B4EC", Offset = "0x108B4EC", VA = "0x108B4EC")]
	private static int Comparison(Entry a, Entry b)
	{
		return default(int);
	}

	[Token(Token = "0x600632B")]
	[Address(RVA = "0x108B530", Offset = "0x108B530", VA = "0x108B530")]
	public void Awake()
	{
	}

	[Token(Token = "0x600632C")]
	[Address(RVA = "0x108B638", Offset = "0x108B638", VA = "0x108B638")]
	public void CalcStayTime(float comboTime)
	{
	}

	[Token(Token = "0x6006330")]
	[Address(RVA = "0x108B964", Offset = "0x108B964", VA = "0x108B964")]
	public void Reserve()
	{
	}

	[Token(Token = "0x6006331")]
	[Address(RVA = "0x108BD7C", Offset = "0x108BD7C", VA = "0x108BD7C")]
	private Entry GetEntry()
	{
		return null;
	}

	[Token(Token = "0x6006332")]
	[Address(RVA = "0x108B9A4", Offset = "0x108B9A4", VA = "0x108B9A4")]
	private Entry Create()
	{
		return null;
	}

	[Token(Token = "0x6006333")]
	[Address(RVA = "0x108C284", Offset = "0x108C284", VA = "0x108C284")]
	private void Delete(Entry ent)
	{
	}

	[Token(Token = "0x6006334")]
	[Address(RVA = "0x108C3BC", Offset = "0x108C3BC", VA = "0x108C3BC")]
	public void Add(string str, Color c)
	{
	}

	[Token(Token = "0x6006335")]
	[Address(RVA = "0x108C6B4", Offset = "0x108C6B4", VA = "0x108C6B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006336")]
	[Address(RVA = "0x108C834", Offset = "0x108C834", VA = "0x108C834")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6006337")]
	[Address(RVA = "0x108CA1C", Offset = "0x108CA1C", VA = "0x108CA1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6006338")]
	[Address(RVA = "0x108BAE8", Offset = "0x108BAE8", VA = "0x108BAE8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6006339")]
	[Address(RVA = "0x108CBC0", Offset = "0x108CBC0", VA = "0x108CBC0")]
	private void Update()
	{
	}
}
