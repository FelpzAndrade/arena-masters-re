using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XUIEnum;

[Token(Token = "0x2000D7E")]
public class XUIHUDText : MonoBehaviour
{
	[Token(Token = "0x2000D7F")]
	protected class Entry
	{
		[Token(Token = "0x40045D4")]
		[FieldOffset(Offset = "0x8")]
		public float time;

		[Token(Token = "0x40045D5")]
		[FieldOffset(Offset = "0xC")]
		public float val;

		[Token(Token = "0x40045D6")]
		[FieldOffset(Offset = "0x10")]
		public UILabel label;

		[Token(Token = "0x40045D7")]
		[FieldOffset(Offset = "0x14")]
		public Color initColor;

		[Token(Token = "0x40045D8")]
		[FieldOffset(Offset = "0x24")]
		public bool critical;

		[Token(Token = "0x40045D9")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 pos;

		[Token(Token = "0x40045DA")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 direction;

		[Token(Token = "0x40045DB")]
		[FieldOffset(Offset = "0x40")]
		public bool heal;

		[Token(Token = "0x6006328")]
		[Address(RVA = "0x108EFF0", Offset = "0x108EFF0", VA = "0x108EFF0")]
		public Entry()
		{
		}
	}

	[Token(Token = "0x40045A6")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[HideInInspector]
	private UIFont font;

	[Token(Token = "0x40045A7")]
	[FieldOffset(Offset = "0x10")]
	public UIFont bitmapFont;

	[Token(Token = "0x40045A8")]
	[FieldOffset(Offset = "0x14")]
	public Font trueTypeFont;

	[Token(Token = "0x40045A9")]
	[FieldOffset(Offset = "0x18")]
	public int fontSize;

	[Token(Token = "0x40045AA")]
	[FieldOffset(Offset = "0x1C")]
	public FontStyle fontStyle;

	[Token(Token = "0x40045AB")]
	[FieldOffset(Offset = "0x20")]
	public bool applyGradient;

	[Token(Token = "0x40045AC")]
	[FieldOffset(Offset = "0x24")]
	public Color gradientTop;

	[Token(Token = "0x40045AD")]
	[FieldOffset(Offset = "0x34")]
	public Color gradienBottom;

	[Token(Token = "0x40045AE")]
	[FieldOffset(Offset = "0x44")]
	public UILabel.Effect effect;

	[Token(Token = "0x40045AF")]
	[FieldOffset(Offset = "0x48")]
	public Color effectColor;

	[Token(Token = "0x40045B0")]
	[FieldOffset(Offset = "0x58")]
	public int spacingX;

	[Token(Token = "0x40045B1")]
	[FieldOffset(Offset = "0x5C")]
	public int spacingY;

	[Token(Token = "0x40045B2")]
	[FieldOffset(Offset = "0x60")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x40045B3")]
	[FieldOffset(Offset = "0x64")]
	public AnimationCurve offsetCurveY;

	[Token(Token = "0x40045B4")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve offsetCurveZ;

	[Token(Token = "0x40045B5")]
	[FieldOffset(Offset = "0x6C")]
	public AnimationCurve alphaCurve;

	[Token(Token = "0x40045B6")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve scaleCurve;

	[Token(Token = "0x40045B7")]
	[FieldOffset(Offset = "0x74")]
	public AnimationCurve scaleCurveForCritical;

	[Token(Token = "0x40045B8")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve flashCurve;

	[Token(Token = "0x40045B9")]
	[FieldOffset(Offset = "0x7C")]
	public AnimationCurve offsetCurveYHeal;

	[Token(Token = "0x40045BA")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve offsetCurveZHeal;

	[Token(Token = "0x40045BB")]
	[FieldOffset(Offset = "0x84")]
	public AnimationCurve alphaCurveHeal;

	[Token(Token = "0x40045BC")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve scaleCurveHeal;

	[Token(Token = "0x40045BD")]
	[FieldOffset(Offset = "0x8C")]
	public AnimationCurve flashCurveHeal;

	[Token(Token = "0x40045BE")]
	[FieldOffset(Offset = "0x90")]
	public Color normal;

	[Token(Token = "0x40045BF")]
	[FieldOffset(Offset = "0xA0")]
	public Color hitted;

	[Token(Token = "0x40045C0")]
	[FieldOffset(Offset = "0xB0")]
	public Color critical;

	[Token(Token = "0x40045C1")]
	[FieldOffset(Offset = "0xC0")]
	public Color dodge;

	[Token(Token = "0x40045C2")]
	[FieldOffset(Offset = "0xD0")]
	public Color heal;

	[Token(Token = "0x40045C3")]
	[FieldOffset(Offset = "0xE0")]
	public Color heal_critical;

	[Token(Token = "0x40045C4")]
	[FieldOffset(Offset = "0xF0")]
	public int reserveCount;

	[Token(Token = "0x40045C5")]
	[FieldOffset(Offset = "0xF4")]
	private Camera m_gameCamera;

	[Token(Token = "0x40045C6")]
	[FieldOffset(Offset = "0xF8")]
	private Camera m_uiCamera;

	[Token(Token = "0x40045C7")]
	[FieldOffset(Offset = "0xFC")]
	private List<Entry> mList;

	[Token(Token = "0x40045C8")]
	[FieldOffset(Offset = "0x100")]
	private List<Entry> mUnused;

	[Token(Token = "0x40045C9")]
	[FieldOffset(Offset = "0x104")]
	private int counter;

	[Token(Token = "0x40045CA")]
	[FieldOffset(Offset = "0x108")]
	private float accum;

	[Token(Token = "0x40045CB")]
	[FieldOffset(Offset = "0x10C")]
	public float accumStep;

	[Token(Token = "0x40045CC")]
	[FieldOffset(Offset = "0x110")]
	private float m_lastAddedTime;

	[Token(Token = "0x40045CD")]
	[FieldOffset(Offset = "0x114")]
	public float delayCondition;

	[Token(Token = "0x40045CE")]
	[FieldOffset(Offset = "0x118")]
	private float m_lastTime;

	[Token(Token = "0x40045CF")]
	[FieldOffset(Offset = "0x11C")]
	private int m_depth;

	[Token(Token = "0x40045D0")]
	[FieldOffset(Offset = "0x120")]
	private int m_depthCritical;

	[Token(Token = "0x40045D1")]
	[FieldOffset(Offset = "0x124")]
	private bool mUseDynamicFont;

	[Token(Token = "0x40045D2")]
	[FieldOffset(Offset = "0x128")]
	private float totalEnd;

	[Token(Token = "0x40045D3")]
	[FieldOffset(Offset = "0x12C")]
	private float totalEndHeal;

	[Token(Token = "0x17000D33")]
	private Camera gameCamera
	{
		[Token(Token = "0x6006316")]
		[Address(RVA = "0x108E314", Offset = "0x108E314", VA = "0x108E314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D34")]
	private Camera uiCamera
	{
		[Token(Token = "0x6006317")]
		[Address(RVA = "0x108E3E4", Offset = "0x108E3E4", VA = "0x108E3E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D35")]
	public bool isVisible
	{
		[Token(Token = "0x6006319")]
		[Address(RVA = "0x108E580", Offset = "0x108E580", VA = "0x108E580")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000D36")]
	public Object ambigiousFont
	{
		[Token(Token = "0x600631A")]
		[Address(RVA = "0x108E620", Offset = "0x108E620", VA = "0x108E620")]
		get
		{
			return null;
		}
		[Token(Token = "0x600631B")]
		[Address(RVA = "0x108E73C", Offset = "0x108E73C", VA = "0x108E73C")]
		set
		{
		}
	}

	[Token(Token = "0x6006314")]
	[Address(RVA = "0x108D824", Offset = "0x108D824", VA = "0x108D824")]
	public XUIHUDText()
	{
	}

	[Token(Token = "0x6006315")]
	[Address(RVA = "0x108E2D0", Offset = "0x108E2D0", VA = "0x108E2D0")]
	private static int Comparison(Entry a, Entry b)
	{
		return default(int);
	}

	[Token(Token = "0x6006318")]
	[Address(RVA = "0x108E518", Offset = "0x108E518", VA = "0x108E518")]
	public Color GetColor(DamageType type)
	{
		return default(Color);
	}

	[Token(Token = "0x600631C")]
	[Address(RVA = "0x108E830", Offset = "0x108E830", VA = "0x108E830")]
	public void Reserve()
	{
	}

	[Token(Token = "0x600631D")]
	[Address(RVA = "0x108EBFC", Offset = "0x108EBFC", VA = "0x108EBFC")]
	private Entry GetEntry()
	{
		return null;
	}

	[Token(Token = "0x600631E")]
	[Address(RVA = "0x108E870", Offset = "0x108E870", VA = "0x108E870")]
	private Entry Create()
	{
		return null;
	}

	[Token(Token = "0x600631F")]
	[Address(RVA = "0x108EFF8", Offset = "0x108EFF8", VA = "0x108EFF8")]
	private void Delete(Entry ent)
	{
	}

	[Token(Token = "0x6006320")]
	[Address(RVA = "0x108F130", Offset = "0x108F130", VA = "0x108F130")]
	public void Add(string str, DamageType type, Vector3 pos, Vector3 dir, int fontsize)
	{
	}

	[Token(Token = "0x6006321")]
	[Address(RVA = "0x108F414", Offset = "0x108F414", VA = "0x108F414")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006322")]
	[Address(RVA = "0x108F594", Offset = "0x108F594", VA = "0x108F594")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6006323")]
	[Address(RVA = "0x108F77C", Offset = "0x108F77C", VA = "0x108F77C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6006324")]
	[Address(RVA = "0x108E968", Offset = "0x108E968", VA = "0x108E968")]
	public void Reset()
	{
	}

	[Token(Token = "0x6006325")]
	[Address(RVA = "0x108F920", Offset = "0x108F920", VA = "0x108F920")]
	private void Start()
	{
	}

	[Token(Token = "0x6006326")]
	[Address(RVA = "0x108F924", Offset = "0x108F924", VA = "0x108F924")]
	private void InitTotalEnd()
	{
	}

	[Token(Token = "0x6006327")]
	[Address(RVA = "0x108FE74", Offset = "0x108FE74", VA = "0x108FE74")]
	private void Update()
	{
	}
}
