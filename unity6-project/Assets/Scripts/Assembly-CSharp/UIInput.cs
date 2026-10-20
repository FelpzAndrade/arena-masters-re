using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000275")]
public class UIInput : MonoBehaviour
{
	[Token(Token = "0x2000276")]
	public enum InputType
	{
		[Token(Token = "0x4000B6B")]
		Standard = 0,
		[Token(Token = "0x4000B6C")]
		AutoCorrect = 1,
		[Token(Token = "0x4000B6D")]
		Password = 2
	}

	[Token(Token = "0x2000277")]
	public enum Validation
	{
		[Token(Token = "0x4000B6F")]
		None = 0,
		[Token(Token = "0x4000B70")]
		Integer = 1,
		[Token(Token = "0x4000B71")]
		Float = 2,
		[Token(Token = "0x4000B72")]
		Alphanumeric = 3,
		[Token(Token = "0x4000B73")]
		Username = 4,
		[Token(Token = "0x4000B74")]
		Name = 5,
		[Token(Token = "0x4000B75")]
		Filename = 6
	}

	[Token(Token = "0x2000278")]
	public enum KeyboardType
	{
		[Token(Token = "0x4000B77")]
		Default = 0,
		[Token(Token = "0x4000B78")]
		ASCIICapable = 1,
		[Token(Token = "0x4000B79")]
		NumbersAndPunctuation = 2,
		[Token(Token = "0x4000B7A")]
		URL = 3,
		[Token(Token = "0x4000B7B")]
		NumberPad = 4,
		[Token(Token = "0x4000B7C")]
		PhonePad = 5,
		[Token(Token = "0x4000B7D")]
		NamePhonePad = 6,
		[Token(Token = "0x4000B7E")]
		EmailAddress = 7
	}

	[Token(Token = "0x2000279")]
	public enum OnReturnKey
	{
		[Token(Token = "0x4000B80")]
		Default = 0,
		[Token(Token = "0x4000B81")]
		Submit = 1,
		[Token(Token = "0x4000B82")]
		NewLine = 2
	}

	[Token(Token = "0x200027A")]
	public delegate char OnValidate(string text, int charIndex, char addedChar);

	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x0")]
	public static UIInput current;

	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x4")]
	public static UIInput selection;

	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0xC")]
	public UILabel label;

	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x10")]
	public InputType inputType;

	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x14")]
	public OnReturnKey onReturnKey;

	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x18")]
	public KeyboardType keyboardType;

	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x1C")]
	public bool hideInput;

	[NonSerialized]
	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x1D")]
	public bool selectAllTextOnFocus;

	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x20")]
	public Validation validation;

	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x24")]
	public int characterLimit;

	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x28")]
	public string savedAs;

	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	[SerializeField]
	private GameObject selectOnTab;

	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x30")]
	public Color activeTextColor;

	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x40")]
	public Color caretColor;

	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x50")]
	public Color selectionColor;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x60")]
	public List<EventDelegate> onSubmit;

	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x64")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x68")]
	public OnValidate onValidate;

	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[HideInInspector]
	protected string mValue;

	[NonSerialized]
	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x70")]
	protected string mDefaultText;

	[NonSerialized]
	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x74")]
	protected Color mDefaultColor;

	[NonSerialized]
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x84")]
	protected float mPosition;

	[NonSerialized]
	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x88")]
	protected bool mDoInit;

	[NonSerialized]
	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x8C")]
	protected NGUIText.Alignment mAlignment;

	[NonSerialized]
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x90")]
	protected bool mLoadSavedValue;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x8")]
	protected static int mDrawStart;

	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0xC")]
	protected static string mLastIME;

	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x10")]
	protected static TouchScreenKeyboard mKeyboard;

	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x14")]
	private static bool mWaitForKeyboard;

	[NonSerialized]
	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x94")]
	protected int mSelectionStart;

	[NonSerialized]
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x98")]
	protected int mSelectionEnd;

	[NonSerialized]
	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x9C")]
	protected UITexture mHighlight;

	[NonSerialized]
	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0xA0")]
	protected UITexture mCaret;

	[NonSerialized]
	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0xA4")]
	protected Texture2D mBlankTex;

	[NonSerialized]
	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0xA8")]
	protected float mNextBlink;

	[NonSerialized]
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0xAC")]
	protected float mLastAlpha;

	[NonSerialized]
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0xB0")]
	protected string mCached;

	[NonSerialized]
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0xB4")]
	protected int mSelectMe;

	[NonSerialized]
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0xB8")]
	protected int mSelectTime;

	[NonSerialized]
	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0xBC")]
	protected bool mStarted;

	[NonSerialized]
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0xC0")]
	private UICamera mCam;

	[NonSerialized]
	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0xC4")]
	private bool mEllipsis;

	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x18")]
	private static int mIgnoreKey;

	[Token(Token = "0x17000354")]
	public string defaultText
	{
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x16F511C", Offset = "0x16F511C", VA = "0x16F511C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x16F535C", Offset = "0x16F535C", VA = "0x16F535C")]
		set
		{
		}
	}

	[Token(Token = "0x17000355")]
	public Color defaultColor
	{
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x16F66D0", Offset = "0x16F66D0", VA = "0x16F66D0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x16F6700", Offset = "0x16F6700", VA = "0x16F6700")]
		set
		{
		}
	}

	[Token(Token = "0x17000356")]
	public bool inputShouldBeHidden
	{
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x16F6878", Offset = "0x16F6878", VA = "0x16F6878")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000357")]
	public string text
	{
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x16F6990", Offset = "0x16F6990", VA = "0x16F6990")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x16F69D8", Offset = "0x16F69D8", VA = "0x16F69D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000358")]
	public string value
	{
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x16F69B4", Offset = "0x16F69B4", VA = "0x16F69B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x16F69E0", Offset = "0x16F69E0", VA = "0x16F69E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000359")]
	public bool selected
	{
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x16F73AC", Offset = "0x16F73AC", VA = "0x16F73AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x16F73B0", Offset = "0x16F73B0", VA = "0x16F73B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700035A")]
	public bool isSelected
	{
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x16F6778", Offset = "0x16F6778", VA = "0x16F6778")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x16F73B4", Offset = "0x16F73B4", VA = "0x16F73B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700035B")]
	public int cursorPosition
	{
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x16F74BC", Offset = "0x16F74BC", VA = "0x16F74BC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x16F75D0", Offset = "0x16F75D0", VA = "0x16F75D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700035C")]
	public int selectionStart
	{
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x16F76C0", Offset = "0x16F76C0", VA = "0x16F76C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x16F77DC", Offset = "0x16F77DC", VA = "0x16F77DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700035D")]
	public int selectionEnd
	{
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x16F78CC", Offset = "0x16F78CC", VA = "0x16F78CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x16F79E0", Offset = "0x16F79E0", VA = "0x16F79E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700035E")]
	public UITexture caret
	{
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x16F7AD0", Offset = "0x16F7AD0", VA = "0x16F7AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600152D")]
	[Address(RVA = "0x16F4E30", Offset = "0x16F4E30", VA = "0x16F4E30")]
	public UIInput()
	{
	}

	[Token(Token = "0x6001538")]
	[Address(RVA = "0x16F69E8", Offset = "0x16F69E8", VA = "0x16F69E8")]
	public void Set(string value, bool notify = true)
	{
	}

	[Token(Token = "0x6001544")]
	[Address(RVA = "0x16F6DD0", Offset = "0x16F6DD0", VA = "0x16F6DD0")]
	public string Validate(string val)
	{
		return null;
	}

	[Token(Token = "0x6001545")]
	[Address(RVA = "0x16F8074", Offset = "0x16F8074", VA = "0x16F8074")]
	public void Start()
	{
	}

	[Token(Token = "0x6001546")]
	[Address(RVA = "0x16F5140", Offset = "0x16F5140", VA = "0x16F5140")]
	protected void Init()
	{
	}

	[Token(Token = "0x6001547")]
	[Address(RVA = "0x16F707C", Offset = "0x16F707C", VA = "0x16F707C")]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[Token(Token = "0x6001548")]
	[Address(RVA = "0x16F84E4", Offset = "0x16F84E4", VA = "0x16F84E4", Slot = "4")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6001549")]
	[Address(RVA = "0x16F84F4", Offset = "0x16F84F4", VA = "0x16F84F4")]
	protected void OnSelectEvent()
	{
	}

	[Token(Token = "0x600154A")]
	[Address(RVA = "0x16F86F8", Offset = "0x16F86F8", VA = "0x16F86F8")]
	protected void OnDeselectEvent()
	{
	}

	[Token(Token = "0x600154B")]
	[Address(RVA = "0x16F8D8C", Offset = "0x16F8D8C", VA = "0x16F8D8C", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600154C")]
	[Address(RVA = "0x16FAC94", Offset = "0x16FAC94", VA = "0x16FAC94")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600154D")]
	[Address(RVA = "0x16FA90C", Offset = "0x16FA90C", VA = "0x16FA90C")]
	protected void DoBackspace()
	{
	}

	[Token(Token = "0x600154E")]
	[Address(RVA = "0x16FAF50", Offset = "0x16FAF50", VA = "0x16FAF50", Slot = "6")]
	protected virtual void Insert(string text)
	{
	}

	[Token(Token = "0x600154F")]
	[Address(RVA = "0x16FB2D4", Offset = "0x16FB2D4", VA = "0x16FB2D4")]
	protected string GetLeftText()
	{
		return null;
	}

	[Token(Token = "0x6001550")]
	[Address(RVA = "0x16FB460", Offset = "0x16FB460", VA = "0x16FB460")]
	protected string GetRightText()
	{
		return null;
	}

	[Token(Token = "0x6001551")]
	[Address(RVA = "0x16FB5FC", Offset = "0x16FB5FC", VA = "0x16FB5FC")]
	protected string GetSelection()
	{
		return null;
	}

	[Token(Token = "0x6001552")]
	[Address(RVA = "0x16FB7A0", Offset = "0x16FB7A0", VA = "0x16FB7A0")]
	protected int GetCharUnderMouse()
	{
		return default(int);
	}

	[Token(Token = "0x6001553")]
	[Address(RVA = "0x16FBA9C", Offset = "0x16FBA9C", VA = "0x16FBA9C", Slot = "7")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6001554")]
	[Address(RVA = "0x16FBCAC", Offset = "0x16FBCAC", VA = "0x16FBCAC", Slot = "8")]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6001555")]
	[Address(RVA = "0x16FBDFC", Offset = "0x16FBDFC", VA = "0x16FBDFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001556")]
	[Address(RVA = "0x16FBE40", Offset = "0x16FBE40", VA = "0x16FBE40", Slot = "9")]
	protected virtual void Cleanup()
	{
	}

	[Token(Token = "0x6001557")]
	[Address(RVA = "0x16FAA68", Offset = "0x16FAA68", VA = "0x16FAA68")]
	public void Submit()
	{
	}

	[Token(Token = "0x6001558")]
	[Address(RVA = "0x16F538C", Offset = "0x16F538C", VA = "0x16F538C")]
	public void UpdateLabel()
	{
	}

	[Token(Token = "0x6001559")]
	[Address(RVA = "0x16F7BAC", Offset = "0x16F7BAC", VA = "0x16F7BAC")]
	protected char Validate(string text, int pos, char ch)
	{
		return default(char);
	}

	[Token(Token = "0x600155A")]
	[Address(RVA = "0x16F71A0", Offset = "0x16F71A0", VA = "0x16F71A0")]
	protected void ExecuteOnChange()
	{
	}

	[Token(Token = "0x600155B")]
	[Address(RVA = "0x16FC598", Offset = "0x16FC598", VA = "0x16FC598")]
	public void RemoveFocus()
	{
	}

	[Token(Token = "0x600155C")]
	[Address(RVA = "0x16FC5A0", Offset = "0x16FC5A0", VA = "0x16FC5A0")]
	public void SaveValue()
	{
	}

	[Token(Token = "0x600155D")]
	[Address(RVA = "0x16F8304", Offset = "0x16F8304", VA = "0x16F8304")]
	public void LoadValue()
	{
	}
}
