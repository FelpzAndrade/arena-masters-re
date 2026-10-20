using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000290")]
public class UITextList : MonoBehaviour
{
	[Token(Token = "0x2000291")]
	public enum Style
	{
		[Token(Token = "0x4000C4A")]
		Text = 0,
		[Token(Token = "0x4000C4B")]
		Chat = 1
	}

	[Token(Token = "0x2000292")]
	protected class Paragraph
	{
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x8")]
		public string text;

		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0xC")]
		public string[] lines;

		[Token(Token = "0x6001697")]
		[Address(RVA = "0x17A4ACC", Offset = "0x17A4ACC", VA = "0x17A4ACC")]
		public Paragraph()
		{
		}
	}

	[Token(Token = "0x4000C3E")]
	[FieldOffset(Offset = "0xC")]
	public UILabel textLabel;

	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x10")]
	public UIProgressBar scrollBar;

	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x14")]
	public Style style;

	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x18")]
	public int paragraphHistory;

	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x1C")]
	protected char[] mSeparator;

	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x20")]
	protected float mScroll;

	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x24")]
	protected int mTotalLines;

	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x28")]
	protected int mLastWidth;

	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x2C")]
	protected int mLastHeight;

	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x30")]
	private BetterList<Paragraph> mParagraphs;

	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, BetterList<Paragraph>> mHistory;

	[Token(Token = "0x170003C1")]
	protected BetterList<Paragraph> paragraphs
	{
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x17A3640", Offset = "0x17A3640", VA = "0x17A3640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C2")]
	public bool isValid
	{
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x17A381C", Offset = "0x17A381C", VA = "0x17A381C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003C3")]
	public float scrollValue
	{
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x17A3948", Offset = "0x17A3948", VA = "0x17A3948")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x17A3950", Offset = "0x17A3950", VA = "0x17A3950")]
		set
		{
		}
	}

	[Token(Token = "0x170003C4")]
	protected float lineHeight
	{
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x17A3E44", Offset = "0x17A3E44", VA = "0x17A3E44")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003C5")]
	protected int scrollHeight
	{
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x17A3F50", Offset = "0x17A3F50", VA = "0x17A3F50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001685")]
	[Address(RVA = "0x17A34B4", Offset = "0x17A34B4", VA = "0x17A34B4")]
	public UITextList()
	{
	}

	[Token(Token = "0x600168D")]
	[Address(RVA = "0x17A406C", Offset = "0x17A406C", VA = "0x17A406C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600168E")]
	[Address(RVA = "0x17A4110", Offset = "0x17A4110", VA = "0x17A4110")]
	private void Start()
	{
	}

	[Token(Token = "0x600168F")]
	[Address(RVA = "0x17A433C", Offset = "0x17A433C", VA = "0x17A433C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001690")]
	[Address(RVA = "0x17A47F8", Offset = "0x17A47F8", VA = "0x17A47F8")]
	public void OnScroll(float val)
	{
	}

	[Token(Token = "0x6001691")]
	[Address(RVA = "0x17A4860", Offset = "0x17A4860", VA = "0x17A4860")]
	public void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6001692")]
	[Address(RVA = "0x17A48B8", Offset = "0x17A48B8", VA = "0x17A48B8")]
	private void OnScrollBar()
	{
	}

	[Token(Token = "0x6001693")]
	[Address(RVA = "0x17A4960", Offset = "0x17A4960", VA = "0x17A4960")]
	public void Add(string text)
	{
	}

	[Token(Token = "0x6001694")]
	[Address(RVA = "0x17A4968", Offset = "0x17A4968", VA = "0x17A4968")]
	protected void Add(string text, bool updateVisible)
	{
	}

	[Token(Token = "0x6001695")]
	[Address(RVA = "0x17A439C", Offset = "0x17A439C", VA = "0x17A439C")]
	protected void Rebuild()
	{
	}

	[Token(Token = "0x6001696")]
	[Address(RVA = "0x17A3AC4", Offset = "0x17A3AC4", VA = "0x17A3AC4")]
	protected void UpdateVisibleText()
	{
	}
}
