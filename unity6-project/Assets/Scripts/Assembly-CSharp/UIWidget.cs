using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200023B")]
[ExecuteInEditMode]
public class UIWidget : UIRect
{
	[Token(Token = "0x200023C")]
	public enum Pivot
	{
		[Token(Token = "0x40009E8")]
		TopLeft = 0,
		[Token(Token = "0x40009E9")]
		Top = 1,
		[Token(Token = "0x40009EA")]
		TopRight = 2,
		[Token(Token = "0x40009EB")]
		Left = 3,
		[Token(Token = "0x40009EC")]
		Center = 4,
		[Token(Token = "0x40009ED")]
		Right = 5,
		[Token(Token = "0x40009EE")]
		BottomLeft = 6,
		[Token(Token = "0x40009EF")]
		Bottom = 7,
		[Token(Token = "0x40009F0")]
		BottomRight = 8
	}

	[Token(Token = "0x200023D")]
	public enum AspectRatioSource
	{
		[Token(Token = "0x40009F2")]
		Free = 0,
		[Token(Token = "0x40009F3")]
		BasedOnWidth = 1,
		[Token(Token = "0x40009F4")]
		BasedOnHeight = 2
	}

	[Token(Token = "0x200023E")]
	public delegate void OnDimensionsChanged();

	[Token(Token = "0x200023F")]
	public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols);

	[Token(Token = "0x2000240")]
	public delegate bool HitCheck(Vector3 worldPos);

	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	protected Color mColor;

	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[SerializeField]
	protected Pivot mPivot;

	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[HideInInspector]
	protected int mWidth;

	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[HideInInspector]
	protected int mHeight;

	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	[SerializeField]
	protected int mDepth;

	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x70")]
	public OnDimensionsChanged onChange;

	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x74")]
	public OnPostFillCallback onPostFill;

	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x78")]
	public UIDrawCall.OnRenderCallback mOnRender;

	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x7C")]
	public bool autoResizeBoxCollider;

	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x7D")]
	public bool hideIfOffScreen;

	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x80")]
	public AspectRatioSource keepAspectRatio;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x84")]
	public float aspectRatio;

	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x88")]
	public HitCheck hitCheck;

	[NonSerialized]
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x8C")]
	public UIPanel panel;

	[NonSerialized]
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x90")]
	public UIGeometry geometry;

	[NonSerialized]
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x94")]
	public bool fillGeometry;

	[NonSerialized]
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x95")]
	protected bool mPlayMode;

	[NonSerialized]
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x98")]
	protected Vector4 mDrawRegion;

	[NonSerialized]
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0xA8")]
	private Matrix4x4 mLocalToPanel;

	[NonSerialized]
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0xE8")]
	private bool mIsVisibleByAlpha;

	[NonSerialized]
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0xE9")]
	private bool mIsVisibleByPanel;

	[NonSerialized]
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0xEA")]
	private bool mIsInFront;

	[NonSerialized]
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0xEC")]
	private float mLastAlpha;

	[NonSerialized]
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0xF0")]
	private bool mMoved;

	[NonSerialized]
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0xF4")]
	public UIDrawCall drawCall;

	[NonSerialized]
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0xF8")]
	protected Vector3[] mCorners;

	[NonSerialized]
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0xFC")]
	private int mAlphaFrameID;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x100")]
	private int mMatrixFrame;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x104")]
	private Vector3 mOldV0;

	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x110")]
	private Vector3 mOldV1;

	[Token(Token = "0x170002DB")]
	public UIDrawCall.OnRenderCallback onRender
	{
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x17AB624", Offset = "0x17AB624", VA = "0x17AB624")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x17AB62C", Offset = "0x17AB62C", VA = "0x17AB62C")]
		set
		{
		}
	}

	[Token(Token = "0x170002DC")]
	public Vector4 drawRegion
	{
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x17AB9C0", Offset = "0x17AB9C0", VA = "0x17AB9C0")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x1790C4C", Offset = "0x1790C4C", VA = "0x1790C4C")]
		set
		{
		}
	}

	[Token(Token = "0x170002DD")]
	public Vector2 pivotOffset
	{
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x178D86C", Offset = "0x178D86C", VA = "0x178D86C")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170002DE")]
	public int width
	{
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x178DEFC", Offset = "0x178DEFC", VA = "0x178DEFC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x178D888", Offset = "0x178D888", VA = "0x178D888")]
		set
		{
		}
	}

	[Token(Token = "0x170002DF")]
	public int height
	{
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x178AAF0", Offset = "0x178AAF0", VA = "0x178AAF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x178DBC8", Offset = "0x178DBC8", VA = "0x178DBC8")]
		set
		{
		}
	}

	[Token(Token = "0x170002E0")]
	public Color color
	{
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x178A680", Offset = "0x178A680", VA = "0x178A680")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x178A738", Offset = "0x178A738", VA = "0x178A738")]
		set
		{
		}
	}

	[Token(Token = "0x170002E1")]
	public override float alpha
	{
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x17ABCA8", Offset = "0x17ABCA8", VA = "0x17ABCA8", Slot = "7")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x17ABCB0", Offset = "0x17ABCB0", VA = "0x17ABCB0", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x170002E2")]
	public bool isVisible
	{
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x17803D4", Offset = "0x17803D4", VA = "0x17803D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002E3")]
	public bool hasVertices
	{
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x17804B8", Offset = "0x17804B8", VA = "0x17804B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002E4")]
	public Pivot rawPivot
	{
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x17ABD10", Offset = "0x17ABD10", VA = "0x17ABD10")]
		get
		{
			return default(Pivot);
		}
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x17ABD18", Offset = "0x17ABD18", VA = "0x17ABD18")]
		set
		{
		}
	}

	[Token(Token = "0x170002E5")]
	public Pivot pivot
	{
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x17ABAD0", Offset = "0x17ABAD0", VA = "0x17ABAD0")]
		get
		{
			return default(Pivot);
		}
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x178D4D8", Offset = "0x178D4D8", VA = "0x178D4D8")]
		set
		{
		}
	}

	[Token(Token = "0x170002E6")]
	public int depth
	{
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x17804E0", Offset = "0x17804E0", VA = "0x17804E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x17ABD7C", Offset = "0x17ABD7C", VA = "0x17ABD7C")]
		set
		{
		}
	}

	[Token(Token = "0x170002E7")]
	public int raycastDepth
	{
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x17ABF04", Offset = "0x17ABF04", VA = "0x17ABF04")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002E8")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x17AC2A4", Offset = "0x17AC2A4", VA = "0x17AC2A4", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E9")]
	public virtual Vector2 localSize
	{
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x17AC478", Offset = "0x17AC478", VA = "0x17AC478", Slot = "23")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170002EA")]
	public Vector3 localCenter
	{
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x17AC54C", Offset = "0x17AC54C", VA = "0x17AC54C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002EB")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x17AC610", Offset = "0x17AC610", VA = "0x17AC610", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EC")]
	public Vector3 worldCenter
	{
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x17AC7E8", Offset = "0x17AC7E8", VA = "0x17AC7E8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002ED")]
	public virtual Vector4 drawingDimensions
	{
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x17AC850", Offset = "0x17AC850", VA = "0x17AC850", Slot = "24")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170002EE")]
	public virtual Material material
	{
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x17ACAD0", Offset = "0x17ACAD0", VA = "0x17ACAD0", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x17ACAD8", Offset = "0x17ACAD8", VA = "0x17ACAD8", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x170002EF")]
	public virtual Texture mainTexture
	{
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x17ACBE0", Offset = "0x17ACBE0", VA = "0x17ACBE0", Slot = "27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x17ACCEC", Offset = "0x17ACCEC", VA = "0x17ACCEC", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x170002F0")]
	public virtual Shader shader
	{
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x17ACDF4", Offset = "0x17ACDF4", VA = "0x17ACDF4", Slot = "29")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x17ACF00", Offset = "0x17ACF00", VA = "0x17ACF00", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x170002F1")]
	public Vector2 relativeSize
	{
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x17AD008", Offset = "0x17AD008", VA = "0x17AD008")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170002F2")]
	public bool hasBoxCollider
	{
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x17AD020", Offset = "0x17AD020", VA = "0x17AD020")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002F3")]
	public virtual int minWidth
	{
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x17AF578", Offset = "0x17AF578", VA = "0x17AF578", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002F4")]
	public virtual int minHeight
	{
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x17AF580", Offset = "0x17AF580", VA = "0x17AF580", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002F5")]
	public virtual Vector4 border
	{
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x179DB84", Offset = "0x179DB84", VA = "0x179DB84", Slot = "36")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x17AF588", Offset = "0x17AF588", VA = "0x17AF588", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x6001330")]
	[Address(RVA = "0x17AB494", Offset = "0x17AB494", VA = "0x17AB494")]
	public UIWidget()
	{
	}

	[Token(Token = "0x6001355")]
	[Address(RVA = "0x17ABAD8", Offset = "0x17ABAD8", VA = "0x17ABAD8")]
	public void SetDimensions(int w, int h)
	{
	}

	[Token(Token = "0x6001356")]
	[Address(RVA = "0x17AD198", Offset = "0x17AD198", VA = "0x17AD198", Slot = "13")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6001357")]
	[Address(RVA = "0x17AD4D0", Offset = "0x17AD4D0", VA = "0x17AD4D0", Slot = "9")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return default(float);
	}

	[Token(Token = "0x6001358")]
	[Address(RVA = "0x17AD4FC", Offset = "0x17AD4FC", VA = "0x17AD4FC")]
	protected void UpdateFinalAlpha(int frameID)
	{
	}

	[Token(Token = "0x6001359")]
	[Address(RVA = "0x17AD63C", Offset = "0x17AD63C", VA = "0x17AD63C", Slot = "12")]
	public override void Invalidate(bool includeChildren)
	{
	}

	[Token(Token = "0x600135A")]
	[Address(RVA = "0x1780C84", Offset = "0x1780C84", VA = "0x1780C84")]
	public float CalculateCumulativeAlpha(int frameID)
	{
		return default(float);
	}

	[Token(Token = "0x600135B")]
	[Address(RVA = "0x17AD800", Offset = "0x17AD800", VA = "0x17AD800", Slot = "19")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600135C")]
	[Address(RVA = "0x17AB9D0", Offset = "0x17AB9D0", VA = "0x17AB9D0")]
	public void ResizeCollider()
	{
	}

	[Token(Token = "0x600135D")]
	[Address(RVA = "0x17ADD14", Offset = "0x17ADD14", VA = "0x17ADD14")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[Token(Token = "0x600135E")]
	[Address(RVA = "0x1781DAC", Offset = "0x1781DAC", VA = "0x1781DAC")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[Token(Token = "0x600135F")]
	[Address(RVA = "0x17ADDF0", Offset = "0x17ADDF0", VA = "0x17ADDF0")]
	public Bounds CalculateBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x6001360")]
	[Address(RVA = "0x17A199C", Offset = "0x17A199C", VA = "0x17A199C")]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6001361")]
	[Address(RVA = "0x17ADE04", Offset = "0x17ADE04", VA = "0x17ADE04")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6001362")]
	[Address(RVA = "0x179D1F0", Offset = "0x179D1F0", VA = "0x179D1F0")]
	public void RemoveFromPanel()
	{
	}

	[Token(Token = "0x6001363")]
	[Address(RVA = "0x17ADF14", Offset = "0x17ADF14", VA = "0x17ADF14", Slot = "31")]
	public virtual void MarkAsChanged()
	{
	}

	[Token(Token = "0x6001364")]
	[Address(RVA = "0x17AC03C", Offset = "0x17AC03C", VA = "0x17AC03C")]
	public UIPanel CreatePanel()
	{
		return null;
	}

	[Token(Token = "0x6001365")]
	[Address(RVA = "0x17AE0AC", Offset = "0x17AE0AC", VA = "0x17AE0AC")]
	public void CheckLayer()
	{
	}

	[Token(Token = "0x6001366")]
	[Address(RVA = "0x17AE270", Offset = "0x17AE270", VA = "0x17AE270", Slot = "20")]
	public override void ParentHasChanged()
	{
	}

	[Token(Token = "0x6001367")]
	[Address(RVA = "0x17AE420", Offset = "0x17AE420", VA = "0x17AE420", Slot = "17")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001368")]
	[Address(RVA = "0x179EEBC", Offset = "0x179EEBC", VA = "0x179EEBC", Slot = "15")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6001369")]
	[Address(RVA = "0x17AE468", Offset = "0x17AE468", VA = "0x17AE468", Slot = "32")]
	protected virtual void UpgradeFrom265()
	{
	}

	[Token(Token = "0x600136A")]
	[Address(RVA = "0x17AE5E8", Offset = "0x17AE5E8", VA = "0x17AE5E8", Slot = "21")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600136B")]
	[Address(RVA = "0x17AE5EC", Offset = "0x17AE5EC", VA = "0x17AE5EC", Slot = "18")]
	protected override void OnAnchor()
	{
	}

	[Token(Token = "0x600136C")]
	[Address(RVA = "0x179EF28", Offset = "0x179EF28", VA = "0x179EF28", Slot = "22")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600136D")]
	[Address(RVA = "0x17AF47C", Offset = "0x17AF47C", VA = "0x17AF47C")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600136E")]
	[Address(RVA = "0x17AF4C8", Offset = "0x17AF4C8", VA = "0x17AF4C8", Slot = "16")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600136F")]
	[Address(RVA = "0x17AF4E4", Offset = "0x17AF4E4", VA = "0x17AF4E4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x1780DA4", Offset = "0x1780DA4", VA = "0x1780DA4")]
	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		return default(bool);
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0x17808BC", Offset = "0x17808BC", VA = "0x17808BC")]
	public bool UpdateTransform(int frame)
	{
		return default(bool);
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0x1780DE8", Offset = "0x1780DE8", VA = "0x1780DE8")]
	public bool UpdateGeometry(int frame)
	{
		return default(bool);
	}

	[Token(Token = "0x6001373")]
	[Address(RVA = "0x17804E8", Offset = "0x17804E8", VA = "0x17804E8")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0x179EAE0", Offset = "0x179EAE0", VA = "0x179EAE0", Slot = "33")]
	public virtual void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6001379")]
	[Address(RVA = "0x17AF58C", Offset = "0x17AF58C", VA = "0x17AF58C", Slot = "38")]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
