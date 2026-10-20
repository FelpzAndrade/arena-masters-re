using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000237")]
public abstract class UIRect : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000238")]
	public class AnchorPoint
	{
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x8")]
		public Transform target;

		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0xC")]
		public float relative;

		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x10")]
		public int absolute;

		[NonSerialized]
		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0x14")]
		public UIRect rect;

		[NonSerialized]
		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x18")]
		public Camera targetCam;

		[Token(Token = "0x6001325")]
		[Address(RVA = "0x1791330", Offset = "0x1791330", VA = "0x1791330")]
		public AnchorPoint()
		{
		}

		[Token(Token = "0x6001326")]
		[Address(RVA = "0x1791338", Offset = "0x1791338", VA = "0x1791338")]
		public AnchorPoint(float relative)
		{
		}

		[Token(Token = "0x6001327")]
		[Address(RVA = "0x1792778", Offset = "0x1792778", VA = "0x1792778")]
		public void Set(float relative, float absolute)
		{
		}

		[Token(Token = "0x6001328")]
		[Address(RVA = "0x1792844", Offset = "0x1792844", VA = "0x1792844")]
		public void Set(Transform target, float relative, float absolute)
		{
		}

		[Token(Token = "0x6001329")]
		[Address(RVA = "0x1792918", Offset = "0x1792918", VA = "0x1792918")]
		public void SetToNearest(float abs0, float abs1, float abs2)
		{
		}

		[Token(Token = "0x600132A")]
		[Address(RVA = "0x1792940", Offset = "0x1792940", VA = "0x1792940")]
		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
		{
		}

		[Token(Token = "0x600132B")]
		[Address(RVA = "0x177B3A8", Offset = "0x177B3A8", VA = "0x177B3A8")]
		public void SetHorizontal(Transform parent, float localPos)
		{
		}

		[Token(Token = "0x600132C")]
		[Address(RVA = "0x177B65C", Offset = "0x177B65C", VA = "0x177B65C")]
		public void SetVertical(Transform parent, float localPos)
		{
		}

		[Token(Token = "0x600132D")]
		[Address(RVA = "0x177E014", Offset = "0x177E014", VA = "0x177E014")]
		public Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}
	}

	[Token(Token = "0x2000239")]
	public enum AnchorUpdate
	{
		[Token(Token = "0x40009C0")]
		OnEnable = 0,
		[Token(Token = "0x40009C1")]
		OnUpdate = 1,
		[Token(Token = "0x40009C2")]
		OnStart = 2
	}

	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0xC")]
	public AnchorPoint leftAnchor;

	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x10")]
	public AnchorPoint rightAnchor;

	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x14")]
	public AnchorPoint bottomAnchor;

	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x18")]
	public AnchorPoint topAnchor;

	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x1C")]
	public AnchorUpdate updateAnchors;

	[NonSerialized]
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x20")]
	protected GameObject mGo;

	[NonSerialized]
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x24")]
	protected Transform mTrans;

	[NonSerialized]
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x28")]
	protected BetterList<UIRect> mChildren;

	[NonSerialized]
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x2C")]
	protected bool mChanged;

	[NonSerialized]
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x2D")]
	protected bool mParentFound;

	[NonSerialized]
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x2E")]
	private bool mUpdateAnchors;

	[NonSerialized]
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x30")]
	private int mUpdateFrame;

	[NonSerialized]
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x34")]
	private bool mAnchorsCached;

	[NonSerialized]
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x38")]
	private UIRoot mRoot;

	[NonSerialized]
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x3C")]
	private UIRect mParent;

	[NonSerialized]
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x40")]
	private bool mRootSet;

	[NonSerialized]
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x44")]
	protected Camera mCam;

	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x48")]
	protected bool mStarted;

	[NonSerialized]
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x4C")]
	public float finalAlpha;

	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x0")]
	protected static Vector3[] mSides;

	[Token(Token = "0x170002CD")]
	public GameObject cachedGameObject
	{
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x177CA60", Offset = "0x177CA60", VA = "0x177CA60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CE")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x1779420", Offset = "0x1779420", VA = "0x1779420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002CF")]
	public Camera anchorCamera
	{
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x1777C74", Offset = "0x1777C74", VA = "0x1777C74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D0")]
	public bool isFullyAnchored
	{
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x17913FC", Offset = "0x17913FC", VA = "0x17913FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D1")]
	public virtual bool isAnchoredHorizontally
	{
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x17915DC", Offset = "0x17915DC", VA = "0x17915DC", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D2")]
	public virtual bool isAnchoredVertically
	{
		[Token(Token = "0x6001300")]
		[Address(RVA = "0x1791700", Offset = "0x1791700", VA = "0x1791700", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D3")]
	public virtual bool canBeAnchored
	{
		[Token(Token = "0x6001301")]
		[Address(RVA = "0x1791824", Offset = "0x1791824", VA = "0x1791824", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D4")]
	public UIRect parent
	{
		[Token(Token = "0x6001302")]
		[Address(RVA = "0x177ACF0", Offset = "0x177ACF0", VA = "0x177ACF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D5")]
	public UIRoot root
	{
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x1778114", Offset = "0x1778114", VA = "0x1778114")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D6")]
	public bool isAnchored
	{
		[Token(Token = "0x6001304")]
		[Address(RVA = "0x177B19C", Offset = "0x177B19C", VA = "0x177B19C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002D7")]
	public abstract float alpha
	{
		[Token(Token = "0x6001305")]
		get;
		[Token(Token = "0x6001306")]
		set;
	}

	[Token(Token = "0x170002D8")]
	public abstract Vector3[] localCorners
	{
		[Token(Token = "0x6001308")]
		get;
	}

	[Token(Token = "0x170002D9")]
	public abstract Vector3[] worldCorners
	{
		[Token(Token = "0x6001309")]
		get;
	}

	[Token(Token = "0x170002DA")]
	protected float cameraRayDistance
	{
		[Token(Token = "0x600130A")]
		[Address(RVA = "0x1779CD8", Offset = "0x1779CD8", VA = "0x1779CD8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x1776AD8", Offset = "0x1776AD8", VA = "0x1776AD8")]
	protected UIRect()
	{
	}

	[Token(Token = "0x6001307")]
	public abstract float CalculateFinalAlpha(int frameID);

	[Token(Token = "0x600130B")]
	[Address(RVA = "0x177AAF0", Offset = "0x177AAF0", VA = "0x177AAF0", Slot = "12")]
	public virtual void Invalidate(bool includeChildren)
	{
	}

	[Token(Token = "0x600130C")]
	[Address(RVA = "0x177A700", Offset = "0x177A700", VA = "0x177A700", Slot = "13")]
	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x600130D")]
	[Address(RVA = "0x177E254", Offset = "0x177E254", VA = "0x177E254")]
	protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0x177CB8C", Offset = "0x177CB8C", VA = "0x177CB8C", Slot = "14")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600130F")]
	[Address(RVA = "0x177D030", Offset = "0x177D030", VA = "0x177D030", Slot = "15")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x6001310")]
	[Address(RVA = "0x177D444", Offset = "0x177D444", VA = "0x177D444", Slot = "16")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6001311")]
	[Address(RVA = "0x177C624", Offset = "0x177C624", VA = "0x177C624", Slot = "17")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6001312")]
	[Address(RVA = "0x179182C", Offset = "0x179182C", VA = "0x179182C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6001313")]
	[Address(RVA = "0x17918A4", Offset = "0x17918A4", VA = "0x17918A4")]
	public void Update()
	{
	}

	[Token(Token = "0x6001314")]
	[Address(RVA = "0x1791938", Offset = "0x1791938", VA = "0x1791938")]
	protected void UpdateAnchorsInternal(int frame)
	{
	}

	[Token(Token = "0x6001315")]
	[Address(RVA = "0x1791D60", Offset = "0x1791D60", VA = "0x1791D60")]
	public void UpdateAnchors()
	{
	}

	[Token(Token = "0x6001316")]
	protected abstract void OnAnchor();

	[Token(Token = "0x6001317")]
	[Address(RVA = "0x1791DA4", Offset = "0x1791DA4", VA = "0x1791DA4")]
	public void SetAnchor(Transform t)
	{
	}

	[Token(Token = "0x6001318")]
	[Address(RVA = "0x1791E08", Offset = "0x1791E08", VA = "0x1791E08")]
	public void SetAnchor(GameObject go)
	{
	}

	[Token(Token = "0x6001319")]
	[Address(RVA = "0x1791F30", Offset = "0x1791F30", VA = "0x1791F30")]
	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x600131A")]
	[Address(RVA = "0x17920E8", Offset = "0x17920E8", VA = "0x17920E8")]
	public void SetAnchor(GameObject go, float left, float bottom, float right, float top)
	{
	}

	[Token(Token = "0x600131B")]
	[Address(RVA = "0x17922A0", Offset = "0x17922A0", VA = "0x17922A0")]
	public void SetAnchor(GameObject go, float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
	{
	}

	[Token(Token = "0x600131C")]
	[Address(RVA = "0x179245C", Offset = "0x179245C", VA = "0x179245C")]
	public void SetAnchor(float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
	{
	}

	[Token(Token = "0x600131D")]
	[Address(RVA = "0x179256C", Offset = "0x179256C", VA = "0x179256C")]
	public void SetScreenRect(int left, int top, int width, int height)
	{
	}

	[Token(Token = "0x600131E")]
	[Address(RVA = "0x1780530", Offset = "0x1780530", VA = "0x1780530")]
	public void ResetAnchors()
	{
	}

	[Token(Token = "0x600131F")]
	[Address(RVA = "0x1792758", Offset = "0x1792758", VA = "0x1792758")]
	public void ResetAndUpdateAnchors()
	{
	}

	[Token(Token = "0x6001320")]
	public abstract void SetRect(float x, float y, float width, float height);

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x17925BC", Offset = "0x17925BC", VA = "0x17925BC")]
	private void FindCameraFor(AnchorPoint ap)
	{
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0x177C7DC", Offset = "0x177C7DC", VA = "0x177C7DC", Slot = "20")]
	public virtual void ParentHasChanged()
	{
	}

	[Token(Token = "0x6001323")]
	protected abstract void OnStart();

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x1792774", Offset = "0x1792774", VA = "0x1792774", Slot = "22")]
	protected virtual void OnUpdate()
	{
	}
}
