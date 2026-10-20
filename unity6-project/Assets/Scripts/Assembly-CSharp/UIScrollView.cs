using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F2")]
[ExecuteInEditMode]
public class UIScrollView : MonoBehaviour
{
	[Token(Token = "0x20001F3")]
	public enum Movement
	{
		[Token(Token = "0x4000823")]
		Horizontal = 0,
		[Token(Token = "0x4000824")]
		Vertical = 1,
		[Token(Token = "0x4000825")]
		Unrestricted = 2,
		[Token(Token = "0x4000826")]
		Custom = 3
	}

	[Token(Token = "0x20001F4")]
	public enum DragEffect
	{
		[Token(Token = "0x4000828")]
		None = 0,
		[Token(Token = "0x4000829")]
		Momentum = 1,
		[Token(Token = "0x400082A")]
		MomentumAndSpring = 2
	}

	[Token(Token = "0x20001F5")]
	public enum ShowCondition
	{
		[Token(Token = "0x400082C")]
		Always = 0,
		[Token(Token = "0x400082D")]
		OnlyIfNeeded = 1,
		[Token(Token = "0x400082E")]
		WhenDragging = 2
	}

	[Token(Token = "0x20001F6")]
	public delegate void OnDragNotification();

	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UIScrollView> list;

	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0xC")]
	public Movement movement;

	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x10")]
	public DragEffect dragEffect;

	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x14")]
	public bool restrictWithinPanel;

	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x15")]
	public bool disableDragIfFits;

	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x16")]
	public bool smoothDragStart;

	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x17")]
	public bool iOSDragEmulation;

	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x18")]
	public float scrollWheelFactor;

	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x1C")]
	public float momentumAmount;

	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x20")]
	public float dampenStrength;

	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x24")]
	public UIProgressBar horizontalScrollBar;

	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x28")]
	public UIProgressBar verticalScrollBar;

	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x2C")]
	public ShowCondition showScrollBars;

	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 customMovement;

	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget.Pivot contentPivot;

	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x3C")]
	public OnDragNotification onDragStarted;

	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x40")]
	public OnDragNotification onDragMoved;

	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x44")]
	public OnDragNotification onDragFinished;

	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x48")]
	public OnDragNotification onMomentumMove;

	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x4C")]
	public OnDragNotification onStoppedMoving;

	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private Vector3 scale;

	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[HideInInspector]
	private Vector2 relativePositionOnReset;

	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x64")]
	protected Transform mTrans;

	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x68")]
	protected UIPanel mPanel;

	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x6C")]
	protected Plane mPlane;

	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x7C")]
	protected Vector3 mLastPos;

	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x88")]
	protected bool mPressed;

	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x8C")]
	protected Vector3 mMomentum;

	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x98")]
	protected float mScroll;

	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x9C")]
	protected Bounds mBounds;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0xB4")]
	protected bool mCalculatedBounds;

	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0xB5")]
	protected bool mShouldMove;

	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0xB6")]
	protected bool mIgnoreCallbacks;

	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0xB8")]
	protected int mDragID;

	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0xBC")]
	protected Vector2 mDragStartOffset;

	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0xC4")]
	protected bool mDragStarted;

	[NonSerialized]
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0xC5")]
	private bool mStarted;

	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public UICenterOnChild centerOnChild;

	[Token(Token = "0x17000275")]
	public UIPanel panel
	{
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x1780890", Offset = "0x1780890", VA = "0x1780890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000276")]
	public bool isDragging
	{
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x1780898", Offset = "0x1780898", VA = "0x1780898")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000277")]
	public virtual Bounds bounds
	{
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x17961F4", Offset = "0x17961F4", VA = "0x17961F4", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x17000278")]
	public bool canMoveHorizontally
	{
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x1796280", Offset = "0x1796280", VA = "0x1796280")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000279")]
	public bool canMoveVertically
	{
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x17962BC", Offset = "0x17962BC", VA = "0x17962BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027A")]
	public virtual bool shouldMoveHorizontally
	{
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x17962F8", Offset = "0x17962F8", VA = "0x17962F8", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027B")]
	public virtual bool shouldMoveVertically
	{
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x179646C", Offset = "0x179646C", VA = "0x179646C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027C")]
	protected virtual bool shouldMove
	{
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x17965E0", Offset = "0x17965E0", VA = "0x17965E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700027D")]
	public Vector3 currentMomentum
	{
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x1796EC4", Offset = "0x1796EC4", VA = "0x1796EC4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x1796ED8", Offset = "0x1796ED8", VA = "0x1796ED8")]
		set
		{
		}
	}

	[Token(Token = "0x600107E")]
	[Address(RVA = "0x179602C", Offset = "0x179602C", VA = "0x179602C")]
	public UIScrollView()
	{
	}

	[Token(Token = "0x600108A")]
	[Address(RVA = "0x1796EEC", Offset = "0x1796EEC", VA = "0x1796EEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600108B")]
	[Address(RVA = "0x1797148", Offset = "0x1797148", VA = "0x1797148")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600108C")]
	[Address(RVA = "0x17975C0", Offset = "0x17975C0", VA = "0x17975C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600108D")]
	[Address(RVA = "0x1797260", Offset = "0x1797260", VA = "0x1797260")]
	private void CheckScrollbars()
	{
	}

	[Token(Token = "0x600108E")]
	[Address(RVA = "0x17975F4", Offset = "0x17975F4", VA = "0x17975F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600108F")]
	[Address(RVA = "0x17976E8", Offset = "0x17976E8", VA = "0x17976E8")]
	public bool RestrictWithinBounds(bool instant)
	{
		return default(bool);
	}

	[Token(Token = "0x6001090")]
	[Address(RVA = "0x1797708", Offset = "0x1797708", VA = "0x1797708")]
	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return default(bool);
	}

	[Token(Token = "0x6001091")]
	[Address(RVA = "0x1797CE4", Offset = "0x1797CE4", VA = "0x1797CE4")]
	public void DisableSpring()
	{
	}

	[Token(Token = "0x6001092")]
	[Address(RVA = "0x1780290", Offset = "0x1780290", VA = "0x1780290")]
	public void UpdateScrollbars()
	{
	}

	[Token(Token = "0x6001093")]
	[Address(RVA = "0x1797DD8", Offset = "0x1797DD8", VA = "0x1797DD8", Slot = "8")]
	public virtual void UpdateScrollbars(bool recalculateBounds)
	{
	}

	[Token(Token = "0x6001094")]
	[Address(RVA = "0x179846C", Offset = "0x179846C", VA = "0x179846C")]
	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
	}

	[Token(Token = "0x6001095")]
	[Address(RVA = "0x1798834", Offset = "0x1798834", VA = "0x1798834", Slot = "9")]
	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	[Token(Token = "0x6001096")]
	[Address(RVA = "0x1798D04", Offset = "0x1798D04", VA = "0x1798D04")]
	public void InvalidateBounds()
	{
	}

	[Token(Token = "0x6001097")]
	[Address(RVA = "0x1798D10", Offset = "0x1798D10", VA = "0x1798D10")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6001098")]
	[Address(RVA = "0x1778CF4", Offset = "0x1778CF4", VA = "0x1778CF4")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x6001099")]
	[Address(RVA = "0x1798E74", Offset = "0x1798E74", VA = "0x1798E74")]
	public void OnScrollBar()
	{
	}

	[Token(Token = "0x600109A")]
	[Address(RVA = "0x1799028", Offset = "0x1799028", VA = "0x1799028", Slot = "10")]
	public virtual void MoveRelative(Vector3 relative)
	{
	}

	[Token(Token = "0x600109B")]
	[Address(RVA = "0x1799110", Offset = "0x1799110", VA = "0x1799110")]
	public void MoveAbsolute(Vector3 absolute)
	{
	}

	[Token(Token = "0x600109C")]
	[Address(RVA = "0x1799208", Offset = "0x1799208", VA = "0x1799208")]
	public void Press(bool pressed)
	{
	}

	[Token(Token = "0x600109D")]
	[Address(RVA = "0x1799AC4", Offset = "0x1799AC4", VA = "0x1799AC4")]
	public void Drag()
	{
	}

	[Token(Token = "0x600109E")]
	[Address(RVA = "0x179A4B0", Offset = "0x179A4B0", VA = "0x179A4B0")]
	public void Scroll(float delta)
	{
	}

	[Token(Token = "0x600109F")]
	[Address(RVA = "0x179A684", Offset = "0x179A684", VA = "0x179A684")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x179AFD8", Offset = "0x179AFD8", VA = "0x179AFD8")]
	public void OnPan(Vector2 delta)
	{
	}
}
