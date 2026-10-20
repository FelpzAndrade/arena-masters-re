using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005D")]
[ExecuteInEditMode]
public class HUDText : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	protected class Entry
	{
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x8")]
		public float time;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xC")]
		public float stay;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x10")]
		public float offset;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x14")]
		public float val;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x18")]
		public UILabel label;

		[Token(Token = "0x17000056")]
		public float movementStart
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x1F533C0", Offset = "0x1F533C0", VA = "0x1F533C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1F53B3C", Offset = "0x1F53B3C", VA = "0x1F53B3C")]
		public Entry()
		{
		}
	}

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	[SerializeField]
	private UIFont font;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x10")]
	public UIFont bitmapFont;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x14")]
	public Font trueTypeFont;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x18")]
	public int fontSize;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x1C")]
	public FontStyle fontStyle;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x20")]
	public bool applyGradient;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x24")]
	public Color gradientTop;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x34")]
	public Color gradienBottom;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x44")]
	public UILabel.Effect effect;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x48")]
	public Color effectColor;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve offsetCurve;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x5C")]
	public AnimationCurve alphaCurve;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve scaleCurve;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x64")]
	private List<Entry> mList;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x68")]
	private List<Entry> mUnused;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x6C")]
	private int counter;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x70")]
	private bool mUseDynamicFont;

	[Token(Token = "0x17000054")]
	public bool isVisible
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1F533D4", Offset = "0x1F533D4", VA = "0x1F533D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000055")]
	public Object ambigiousFont
	{
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1F53474", Offset = "0x1F53474", VA = "0x1F53474")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1F53590", Offset = "0x1F53590", VA = "0x1F53590")]
		set
		{
		}
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1F52F80", Offset = "0x1F52F80", VA = "0x1F52F80")]
	public HUDText()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1F5336C", Offset = "0x1F5336C", VA = "0x1F5336C")]
	private static int Comparison(Entry a, Entry b)
	{
		return default(int);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1F53684", Offset = "0x1F53684", VA = "0x1F53684")]
	private Entry Create()
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1F53B44", Offset = "0x1F53B44", VA = "0x1F53B44")]
	private void Delete(Entry ent)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x1F53C7C", Offset = "0x1F53C7C", VA = "0x1F53C7C")]
	public void Add(object obj, Color c, float stayDuration)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1F54268", Offset = "0x1F54268", VA = "0x1F54268")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1F543E8", Offset = "0x1F543E8", VA = "0x1F543E8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1F545D0", Offset = "0x1F545D0", VA = "0x1F545D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x1F54774", Offset = "0x1F54774", VA = "0x1F54774")]
	private void Update()
	{
	}
}
