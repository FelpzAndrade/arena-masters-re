using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000284")]
[ExecuteInEditMode]
public class UIPanel : UIRect
{
	[Token(Token = "0x2000285")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000BF4")]
		Automatic = 0,
		[Token(Token = "0x4000BF5")]
		StartAt = 1,
		[Token(Token = "0x4000BF6")]
		Explicit = 2
	}

	[Token(Token = "0x2000286")]
	public delegate void OnGeometryUpdated();

	[Token(Token = "0x2000287")]
	public delegate void OnClippingMoved(UIPanel panel);

	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x0")]
	public static List<UIPanel> list;

	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x50")]
	public OnGeometryUpdated onGeometryUpdated;

	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x54")]
	public bool showInPanelTool;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x55")]
	public bool generateNormals;

	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x56")]
	public bool widgetsAreStatic;

	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x57")]
	public bool cullWhileDragging;

	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x58")]
	public bool alwaysOnScreen;

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x59")]
	public bool anchorOffset;

	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x5A")]
	public bool softBorderPadding;

	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x5C")]
	public RenderQueue renderQueue;

	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x60")]
	public int startingRenderQueue;

	[NonSerialized]
	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x64")]
	public List<UIWidget> widgets;

	[NonSerialized]
	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x68")]
	public List<UIDrawCall> drawCalls;

	[NonSerialized]
	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x6C")]
	public Matrix4x4 worldToLocal;

	[NonSerialized]
	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0xAC")]
	public Vector4 drawCallClipRange;

	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0xBC")]
	public OnClippingMoved onClipMove;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[HideInInspector]
	private Texture2D mClipTexture;

	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	[HideInInspector]
	private float mAlpha;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	[SerializeField]
	private UIDrawCall.Clipping mClipping;

	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange;

	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness;

	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	[HideInInspector]
	private int mDepth;

	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0xE8")]
	[HideInInspector]
	[SerializeField]
	private int mSortingOrder;

	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0xEC")]
	[HideInInspector]
	[SerializeField]
	private string mSortingLayerName;

	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0xF0")]
	private bool mRebuild;

	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0xF1")]
	private bool mResized;

	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	private Vector2 mClipOffset;

	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0xFC")]
	private int mMatrixFrame;

	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x100")]
	private int mAlphaFrameID;

	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x104")]
	private int mLayer;

	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x4")]
	private static float[] mTemp;

	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x108")]
	private Vector2 mMin;

	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x110")]
	private Vector2 mMax;

	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x118")]
	private bool mHalfPixelOffset;

	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x119")]
	private bool mSortWidgets;

	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x11A")]
	private bool mUpdateScroll;

	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x11C")]
	private UIPanel mParentPanel;

	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] mCorners;

	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0xC")]
	private static int mUpdateFrame;

	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x120")]
	private UIDrawCall.OnRenderCallback mOnRender;

	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x124")]
	private bool mForced;

	[Token(Token = "0x1700038F")]
	public string sortingLayerName
	{
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x1776D38", Offset = "0x1776D38", VA = "0x1776D38")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x1776D40", Offset = "0x1776D40", VA = "0x1776D40")]
		set
		{
		}
	}

	[Token(Token = "0x17000390")]
	public static int nextUnusedDepth
	{
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x177731C", Offset = "0x177731C", VA = "0x177731C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000391")]
	public override bool canBeAnchored
	{
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x177751C", Offset = "0x177751C", VA = "0x177751C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000392")]
	public override float alpha
	{
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x177752C", Offset = "0x177752C", VA = "0x177752C", Slot = "7")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x1777534", Offset = "0x1777534", VA = "0x1777534", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000393")]
	public int depth
	{
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x1777514", Offset = "0x1777514", VA = "0x1777514")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x177770C", Offset = "0x177770C", VA = "0x177770C")]
		set
		{
		}
	}

	[Token(Token = "0x17000394")]
	public int sortingOrder
	{
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x1777864", Offset = "0x1777864", VA = "0x1777864")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x177786C", Offset = "0x177786C", VA = "0x177786C")]
		set
		{
		}
	}

	[Token(Token = "0x17000395")]
	public float width
	{
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x1777A3C", Offset = "0x1777A3C", VA = "0x1777A3C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000396")]
	public float height
	{
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x1777B50", Offset = "0x1777B50", VA = "0x1777B50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000397")]
	public bool halfPixelOffset
	{
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x1777B74", Offset = "0x1777B74", VA = "0x1777B74")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000398")]
	public bool usedForUI
	{
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x1777B7C", Offset = "0x1777B7C", VA = "0x1777B7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000399")]
	public Vector3 drawCallOffset
	{
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x1777C9C", Offset = "0x1777C9C", VA = "0x1777C9C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700039A")]
	public UIDrawCall.Clipping clipping
	{
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x17783B8", Offset = "0x17783B8", VA = "0x17783B8")]
		get
		{
			return default(UIDrawCall.Clipping);
		}
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x17783C0", Offset = "0x17783C0", VA = "0x17783C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700039B")]
	public UIPanel parentPanel
	{
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x17783E4", Offset = "0x17783E4", VA = "0x17783E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700039C")]
	public int clipCount
	{
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x17783EC", Offset = "0x17783EC", VA = "0x17783EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700039D")]
	public bool hasClipping
	{
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x17784D4", Offset = "0x17784D4", VA = "0x17784D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700039E")]
	public bool hasCumulativeClipping
	{
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x17784E8", Offset = "0x17784E8", VA = "0x17784E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700039F")]
	public bool clipsChildren
	{
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x1778500", Offset = "0x1778500", VA = "0x1778500")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003A0")]
	public Vector2 clipOffset
	{
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x1778518", Offset = "0x1778518", VA = "0x1778518")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x177852C", Offset = "0x177852C", VA = "0x177852C")]
		set
		{
		}
	}

	[Token(Token = "0x170003A1")]
	public Texture2D clipTexture
	{
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x1778960", Offset = "0x1778960", VA = "0x1778960")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x1778968", Offset = "0x1778968", VA = "0x1778968")]
		set
		{
		}
	}

	[Token(Token = "0x170003A2")]
	public Vector4 clipRange
	{
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x1778A24", Offset = "0x1778A24", VA = "0x1778A24")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x1778A44", Offset = "0x1778A44", VA = "0x1778A44")]
		set
		{
		}
	}

	[Token(Token = "0x170003A3")]
	public Vector4 baseClipRegion
	{
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x1778A34", Offset = "0x1778A34", VA = "0x1778A34")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x1778A64", Offset = "0x1778A64", VA = "0x1778A64")]
		set
		{
		}
	}

	[Token(Token = "0x170003A4")]
	public Vector4 finalClipRegion
	{
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x1778F94", Offset = "0x1778F94", VA = "0x1778F94")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170003A5")]
	public Vector2 clipSoftness
	{
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x1779024", Offset = "0x1779024", VA = "0x1779024")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x1779038", Offset = "0x1779038", VA = "0x1779038")]
		set
		{
		}
	}

	[Token(Token = "0x170003A6")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x1779084", Offset = "0x1779084", VA = "0x1779084", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A7")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x17794F0", Offset = "0x17794F0", VA = "0x17794F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x177684C", Offset = "0x177684C", VA = "0x177684C")]
	public UIPanel()
	{
	}

	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x1777880", Offset = "0x1777880", VA = "0x1777880")]
	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		return default(int);
	}

	[Token(Token = "0x6001602")]
	[Address(RVA = "0x1778674", Offset = "0x1778674", VA = "0x1778674")]
	private void InvalidateClipping()
	{
	}

	[Token(Token = "0x600160E")]
	[Address(RVA = "0x177A024", Offset = "0x177A024", VA = "0x177A024", Slot = "13")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x600160F")]
	[Address(RVA = "0x177AAE4", Offset = "0x177AAE4", VA = "0x177AAE4", Slot = "12")]
	public override void Invalidate(bool includeChildren)
	{
	}

	[Token(Token = "0x6001610")]
	[Address(RVA = "0x177ABA8", Offset = "0x177ABA8", VA = "0x177ABA8", Slot = "9")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return default(float);
	}

	[Token(Token = "0x6001611")]
	[Address(RVA = "0x177ADF4", Offset = "0x177ADF4", VA = "0x177ADF4", Slot = "19")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6001612")]
	[Address(RVA = "0x177B918", Offset = "0x177B918", VA = "0x177B918")]
	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return default(bool);
	}

	[Token(Token = "0x6001613")]
	[Address(RVA = "0x177BEC4", Offset = "0x177BEC4", VA = "0x177BEC4")]
	public bool IsVisible(Vector3 worldPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6001614")]
	[Address(RVA = "0x177BF90", Offset = "0x177BF90", VA = "0x177BF90")]
	public bool IsVisible(UIWidget w)
	{
		return default(bool);
	}

	[Token(Token = "0x6001615")]
	[Address(RVA = "0x177C1B8", Offset = "0x177C1B8", VA = "0x177C1B8")]
	public bool Affects(UIWidget w)
	{
		return default(bool);
	}

	[Token(Token = "0x6001616")]
	[Address(RVA = "0x177C3A4", Offset = "0x177C3A4", VA = "0x177C3A4")]
	public void RebuildAllDrawCalls()
	{
	}

	[Token(Token = "0x6001617")]
	[Address(RVA = "0x177C3B0", Offset = "0x177C3B0", VA = "0x177C3B0")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6001618")]
	[Address(RVA = "0x177C4DC", Offset = "0x177C4DC", VA = "0x177C4DC", Slot = "17")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001619")]
	[Address(RVA = "0x177C65C", Offset = "0x177C65C", VA = "0x177C65C")]
	private void FindParent()
	{
	}

	[Token(Token = "0x600161A")]
	[Address(RVA = "0x177C7C0", Offset = "0x177C7C0", VA = "0x177C7C0", Slot = "20")]
	public override void ParentHasChanged()
	{
	}

	[Token(Token = "0x600161B")]
	[Address(RVA = "0x177CA2C", Offset = "0x177CA2C", VA = "0x177CA2C", Slot = "21")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600161C")]
	[Address(RVA = "0x177CB30", Offset = "0x177CB30", VA = "0x177CB30", Slot = "14")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600161D")]
	[Address(RVA = "0x177CC00", Offset = "0x177CC00", VA = "0x177CC00", Slot = "15")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600161E")]
	[Address(RVA = "0x177D144", Offset = "0x177D144", VA = "0x177D144", Slot = "16")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600161F")]
	[Address(RVA = "0x177BD78", Offset = "0x177BD78", VA = "0x177BD78")]
	private void UpdateTransformMatrix()
	{
	}

	[Token(Token = "0x6001620")]
	[Address(RVA = "0x177D550", Offset = "0x177D550", VA = "0x177D550", Slot = "18")]
	protected override void OnAnchor()
	{
	}

	[Token(Token = "0x6001621")]
	[Address(RVA = "0x177E608", Offset = "0x177E608", VA = "0x177E608")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001622")]
	[Address(RVA = "0x177EAC4", Offset = "0x177EAC4", VA = "0x177EAC4")]
	private void UpdateSelf()
	{
	}

	[Token(Token = "0x6001623")]
	[Address(RVA = "0x17802D8", Offset = "0x17802D8", VA = "0x17802D8")]
	public void SortWidgets()
	{
	}

	[Token(Token = "0x6001624")]
	[Address(RVA = "0x177F500", Offset = "0x177F500", VA = "0x177F500")]
	private void FillAllDrawCalls()
	{
	}

	[Token(Token = "0x6001625")]
	[Address(RVA = "0x177FE28", Offset = "0x177FE28", VA = "0x177FE28")]
	public bool FillDrawCall(UIDrawCall dc)
	{
		return default(bool);
	}

	[Token(Token = "0x6001626")]
	[Address(RVA = "0x1776E08", Offset = "0x1776E08", VA = "0x1776E08")]
	private void UpdateDrawCalls()
	{
	}

	[Token(Token = "0x6001627")]
	[Address(RVA = "0x177ED38", Offset = "0x177ED38", VA = "0x177ED38")]
	private void UpdateLayers()
	{
	}

	[Token(Token = "0x6001628")]
	[Address(RVA = "0x177EFD4", Offset = "0x177EFD4", VA = "0x177EFD4")]
	private void UpdateWidgets()
	{
	}

	[Token(Token = "0x6001629")]
	[Address(RVA = "0x1781798", Offset = "0x1781798", VA = "0x1781798")]
	public UIDrawCall FindDrawCall(UIWidget w)
	{
		return null;
	}

	[Token(Token = "0x600162A")]
	[Address(RVA = "0x1781B7C", Offset = "0x1781B7C", VA = "0x1781B7C")]
	public void AddWidget(UIWidget w)
	{
	}

	[Token(Token = "0x600162B")]
	[Address(RVA = "0x1781FD8", Offset = "0x1781FD8", VA = "0x1781FD8")]
	public void RemoveWidget(UIWidget w)
	{
	}

	[Token(Token = "0x600162C")]
	[Address(RVA = "0x1782128", Offset = "0x1782128", VA = "0x1782128")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600162D")]
	[Address(RVA = "0x17822C4", Offset = "0x17822C4", VA = "0x17822C4", Slot = "23")]
	public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600162E")]
	[Address(RVA = "0x1782440", Offset = "0x1782440", VA = "0x1782440")]
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return default(bool);
	}

	[Token(Token = "0x600162F")]
	[Address(RVA = "0x1782918", Offset = "0x1782918", VA = "0x1782918")]
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return default(bool);
	}

	[Token(Token = "0x6001630")]
	[Address(RVA = "0x1782994", Offset = "0x1782994", VA = "0x1782994")]
	public static UIPanel Find(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x6001631")]
	[Address(RVA = "0x1782C4C", Offset = "0x1782C4C", VA = "0x1782C4C")]
	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x6001632")]
	[Address(RVA = "0x1782A44", Offset = "0x1782A44", VA = "0x1782A44")]
	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		return null;
	}

	[Token(Token = "0x6001633")]
	[Address(RVA = "0x1777F64", Offset = "0x1777F64", VA = "0x1777F64")]
	public Vector2 GetWindowSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001634")]
	[Address(RVA = "0x1777A60", Offset = "0x1777A60", VA = "0x1777A60")]
	public Vector2 GetViewSize()
	{
		return default(Vector2);
	}
}
