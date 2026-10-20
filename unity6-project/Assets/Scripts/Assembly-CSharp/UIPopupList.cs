using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E6")]
[ExecuteInEditMode]
public class UIPopupList : UIWidgetContainer
{
	[Token(Token = "0x20001E7")]
	public enum Position
	{
		[Token(Token = "0x40007CF")]
		Auto = 0,
		[Token(Token = "0x40007D0")]
		Above = 1,
		[Token(Token = "0x40007D1")]
		Below = 2
	}

	[Token(Token = "0x20001E8")]
	public enum OpenOn
	{
		[Token(Token = "0x40007D3")]
		ClickOrTap = 0,
		[Token(Token = "0x40007D4")]
		RightClick = 1,
		[Token(Token = "0x40007D5")]
		DoubleClick = 2,
		[Token(Token = "0x40007D6")]
		Manual = 3
	}

	[Token(Token = "0x20001E9")]
	public delegate void LegacyEvent(string val);

	[Token(Token = "0x20001EA")]
	private sealed class _003CUpdateTweenPosition_003Ec__Iterator23 : IDisposable
	{
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x8")]
		internal TweenPosition _003Ctp_003E__0;

		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x14")]
		internal UIPopupList _003C_003Ef__this;

		[Token(Token = "0x17000265")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6001044")]
			[Address(RVA = "0x178E144", Offset = "0x178E144", VA = "0x178E144", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000266")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001045")]
			[Address(RVA = "0x178E14C", Offset = "0x178E14C", VA = "0x178E14C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001043")]
		[Address(RVA = "0x17895C0", Offset = "0x17895C0", VA = "0x17895C0")]
		public _003CUpdateTweenPosition_003Ec__Iterator23()
		{
		}

		[Token(Token = "0x6001044")]
		[Address(RVA = "0x178E144", Offset = "0x178E144", VA = "0x178E144", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001045")]
		[Address(RVA = "0x178E14C", Offset = "0x178E14C", VA = "0x178E14C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001046")]
		[Address(RVA = "0x178E154", Offset = "0x178E154", VA = "0x178E154", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001047")]
		[Address(RVA = "0x178E3DC", Offset = "0x178E3DC", VA = "0x178E3DC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001048")]
		[Address(RVA = "0x178E3E8", Offset = "0x178E3E8", VA = "0x178E3E8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20001EB")]
	private sealed class _003CCloseIfUnselected_003Ec__Iterator24 : IDisposable
	{
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x10")]
		internal UIPopupList _003C_003Ef__this;

		[Token(Token = "0x17000267")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600104A")]
			[Address(RVA = "0x178DF04", Offset = "0x178DF04", VA = "0x178DF04", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000268")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600104B")]
			[Address(RVA = "0x178DF0C", Offset = "0x178DF0C", VA = "0x178DF0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001049")]
		[Address(RVA = "0x178AEF8", Offset = "0x178AEF8", VA = "0x178AEF8")]
		public _003CCloseIfUnselected_003Ec__Iterator24()
		{
		}

		[Token(Token = "0x600104A")]
		[Address(RVA = "0x178DF04", Offset = "0x178DF04", VA = "0x178DF04", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600104B")]
		[Address(RVA = "0x178DF0C", Offset = "0x178DF0C", VA = "0x178DF0C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600104C")]
		[Address(RVA = "0x178DF14", Offset = "0x178DF14", VA = "0x178DF14", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600104D")]
		[Address(RVA = "0x178E0A4", Offset = "0x178E0A4", VA = "0x178E0A4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600104E")]
		[Address(RVA = "0x178E0B0", Offset = "0x178E0B0", VA = "0x178E0B0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400079F")]
	private const float animSpeed = 0.15f;

	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x0")]
	public static UIPopupList current;

	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x4")]
	private static GameObject mChild;

	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x8")]
	private static float mFadeOutComplete;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0xC")]
	public UIAtlas atlas;

	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x10")]
	public UIFont bitmapFont;

	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x14")]
	public Font trueTypeFont;

	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x18")]
	public int fontSize;

	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x1C")]
	public FontStyle fontStyle;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x20")]
	public string backgroundSprite;

	[Token(Token = "0x40007A9")]
	[FieldOffset(Offset = "0x24")]
	public string highlightSprite;

	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0x28")]
	public Sprite background2DSprite;

	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite highlight2DSprite;

	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x30")]
	public Position position;

	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x34")]
	public NGUIText.Alignment alignment;

	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x38")]
	public List<string> items;

	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x3C")]
	public List<object> itemData;

	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 padding;

	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x48")]
	public Color textColor;

	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x58")]
	public Color backgroundColor;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x68")]
	public Color highlightColor;

	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x78")]
	public bool isAnimated;

	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x79")]
	public bool isLocalized;

	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x7A")]
	public bool separatePanel;

	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x7C")]
	public OpenOn openOn;

	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x80")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[HideInInspector]
	protected string mSelectedItem;

	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[HideInInspector]
	protected UIPanel mPanel;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite mBackground;

	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x90")]
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite mHighlight;

	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x94")]
	[HideInInspector]
	[SerializeField]
	protected UILabel mHighlightedLabel;

	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[HideInInspector]
	protected List<UILabel> mLabelList;

	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x9C")]
	[HideInInspector]
	[SerializeField]
	protected float mBgBorder;

	[NonSerialized]
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0xA0")]
	protected GameObject mSelection;

	[NonSerialized]
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0xA4")]
	protected int mOpenFrame;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	[SerializeField]
	private string functionName;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	[SerializeField]
	private float textScale;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[HideInInspector]
	private UIFont font;

	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	[SerializeField]
	private UILabel textLabel;

	[NonSerialized]
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0xBC")]
	public Vector3 startingPosition;

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0xC8")]
	private LegacyEvent mLegacyEvent;

	[NonSerialized]
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0xCC")]
	protected bool mExecuting;

	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0xCD")]
	protected bool mUseDynamicFont;

	[NonSerialized]
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0xCE")]
	protected bool mStarted;

	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0xCF")]
	protected bool mTweening;

	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject source;

	[Token(Token = "0x1700025B")]
	public UnityEngine.Object ambigiousFont
	{
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x1787610", Offset = "0x1787610", VA = "0x1787610")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x178772C", Offset = "0x178772C", VA = "0x178772C")]
		set
		{
		}
	}

	[Token(Token = "0x1700025C")]
	public LegacyEvent onSelectionChange
	{
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x1787824", Offset = "0x1787824", VA = "0x1787824")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x178782C", Offset = "0x178782C", VA = "0x178782C")]
		set
		{
		}
	}

	[Token(Token = "0x1700025D")]
	public static bool isOpen
	{
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x1787834", Offset = "0x1787834", VA = "0x1787834")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700025E")]
	public virtual string value
	{
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x1787A50", Offset = "0x1787A50", VA = "0x1787A50", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x1787A58", Offset = "0x1787A58", VA = "0x1787A58", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700025F")]
	public virtual object data
	{
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x1787B40", Offset = "0x1787B40", VA = "0x1787B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000260")]
	public bool isColliderEnabled
	{
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x1787C54", Offset = "0x1787C54", VA = "0x1787C54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000261")]
	public string selection
	{
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x1787DD0", Offset = "0x1787DD0", VA = "0x1787DD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x1787E14", Offset = "0x1787E14", VA = "0x1787E14")]
		set
		{
		}
	}

	[Token(Token = "0x17000262")]
	private bool isValid
	{
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x1787E60", Offset = "0x1787E60", VA = "0x1787E60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000263")]
	private int activeFontSize
	{
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x1787F68", Offset = "0x1787F68", VA = "0x1787F68")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000264")]
	private float activeFontScale
	{
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x1788098", Offset = "0x1788098", VA = "0x1788098")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001010")]
	[Address(RVA = "0x17873B4", Offset = "0x17873B4", VA = "0x17873B4")]
	public UIPopupList()
	{
	}

	[Token(Token = "0x6001020")]
	[Address(RVA = "0x1787A60", Offset = "0x1787A60", VA = "0x1787A60")]
	public void Set(string value, bool notify = true)
	{
	}

	[Token(Token = "0x6001021")]
	[Address(RVA = "0x178849C", Offset = "0x178849C", VA = "0x178849C", Slot = "7")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6001022")]
	[Address(RVA = "0x1788560", Offset = "0x1788560", VA = "0x1788560", Slot = "8")]
	public virtual void AddItem(string text)
	{
	}

	[Token(Token = "0x6001023")]
	[Address(RVA = "0x1788630", Offset = "0x1788630", VA = "0x1788630", Slot = "9")]
	public virtual void AddItem(string text, object data)
	{
	}

	[Token(Token = "0x6001024")]
	[Address(RVA = "0x1788704", Offset = "0x1788704", VA = "0x1788704", Slot = "10")]
	public virtual void RemoveItem(string text)
	{
	}

	[Token(Token = "0x6001025")]
	[Address(RVA = "0x1788810", Offset = "0x1788810", VA = "0x1788810", Slot = "11")]
	public virtual void RemoveItemByData(object data)
	{
	}

	[Token(Token = "0x6001026")]
	[Address(RVA = "0x17881E4", Offset = "0x17881E4", VA = "0x17881E4")]
	protected void TriggerCallbacks()
	{
	}

	[Token(Token = "0x6001027")]
	[Address(RVA = "0x17889B4", Offset = "0x17889B4", VA = "0x17889B4", Slot = "12")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6001028")]
	[Address(RVA = "0x1788D60", Offset = "0x1788D60", VA = "0x1788D60", Slot = "13")]
	protected virtual void OnValidate()
	{
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0x1788F48", Offset = "0x1788F48", VA = "0x1788F48", Slot = "14")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600102A")]
	[Address(RVA = "0x17890B0", Offset = "0x17890B0", VA = "0x17890B0", Slot = "15")]
	protected virtual void OnLocalize()
	{
	}

	[Token(Token = "0x600102B")]
	[Address(RVA = "0x17890C0", Offset = "0x17890C0", VA = "0x17890C0", Slot = "16")]
	protected virtual void Highlight(UILabel lbl, bool instant)
	{
	}

	[Token(Token = "0x600102C")]
	[Address(RVA = "0x17892A0", Offset = "0x17892A0", VA = "0x17892A0", Slot = "17")]
	protected virtual Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600102D")]
	[Address(RVA = "0x178951C", Offset = "0x178951C", VA = "0x178951C", Slot = "18")]
	[DebuggerHidden]
	protected virtual IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	[Token(Token = "0x600102E")]
	[Address(RVA = "0x17895C8", Offset = "0x17895C8", VA = "0x17895C8", Slot = "19")]
	protected virtual void OnItemHover(GameObject go, bool isOver)
	{
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0x17896B0", Offset = "0x17896B0", VA = "0x17896B0", Slot = "20")]
	protected virtual void OnItemPress(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0x1789930", Offset = "0x1789930", VA = "0x1789930")]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[Token(Token = "0x6001031")]
	[Address(RVA = "0x1789984", Offset = "0x1789984", VA = "0x1789984", Slot = "21")]
	protected virtual void OnNavigate(KeyCode key)
	{
	}

	[Token(Token = "0x6001032")]
	[Address(RVA = "0x1789BB0", Offset = "0x1789BB0", VA = "0x1789BB0", Slot = "22")]
	protected virtual void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x6001033")]
	[Address(RVA = "0x1789DCC", Offset = "0x1789DCC", VA = "0x1789DCC", Slot = "23")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6001034")]
	[Address(RVA = "0x1789E10", Offset = "0x1789E10", VA = "0x1789E10", Slot = "24")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6001035")]
	[Address(RVA = "0x1789E5C", Offset = "0x1789E5C", VA = "0x1789E5C")]
	public static void Close()
	{
	}

	[Token(Token = "0x6001036")]
	[Address(RVA = "0x178A00C", Offset = "0x178A00C", VA = "0x178A00C", Slot = "25")]
	public virtual void CloseSelf()
	{
	}

	[Token(Token = "0x6001037")]
	[Address(RVA = "0x178A690", Offset = "0x178A690", VA = "0x178A690", Slot = "26")]
	protected virtual void AnimateColor(UIWidget widget)
	{
	}

	[Token(Token = "0x6001038")]
	[Address(RVA = "0x178A800", Offset = "0x178A800", VA = "0x178A800", Slot = "27")]
	protected virtual void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x6001039")]
	[Address(RVA = "0x178A928", Offset = "0x178A928", VA = "0x178A928", Slot = "28")]
	protected virtual void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x600103A")]
	[Address(RVA = "0x178AAF8", Offset = "0x178AAF8", VA = "0x178AAF8")]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x600103B")]
	[Address(RVA = "0x178AB84", Offset = "0x178AB84", VA = "0x178AB84", Slot = "29")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x600103C")]
	[Address(RVA = "0x178AE04", Offset = "0x178AE04", VA = "0x178AE04", Slot = "30")]
	protected virtual void OnDoubleClick()
	{
	}

	[Token(Token = "0x600103D")]
	[Address(RVA = "0x178AE54", Offset = "0x178AE54", VA = "0x178AE54")]
	[DebuggerHidden]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0x178AF00", Offset = "0x178AF00", VA = "0x178AF00", Slot = "31")]
	public virtual void Show()
	{
	}
}
