using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000227")]
public abstract class UIBasicSprite : UIWidget
{
	[Token(Token = "0x2000228")]
	public enum Type
	{
		[Token(Token = "0x4000954")]
		Simple = 0,
		[Token(Token = "0x4000955")]
		Sliced = 1,
		[Token(Token = "0x4000956")]
		Tiled = 2,
		[Token(Token = "0x4000957")]
		Filled = 3,
		[Token(Token = "0x4000958")]
		Advanced = 4
	}

	[Token(Token = "0x2000229")]
	public enum FillDirection
	{
		[Token(Token = "0x400095A")]
		Horizontal = 0,
		[Token(Token = "0x400095B")]
		Vertical = 1,
		[Token(Token = "0x400095C")]
		Radial90 = 2,
		[Token(Token = "0x400095D")]
		Radial180 = 3,
		[Token(Token = "0x400095E")]
		Radial360 = 4
	}

	[Token(Token = "0x200022A")]
	public enum AdvancedType
	{
		[Token(Token = "0x4000960")]
		Invisible = 0,
		[Token(Token = "0x4000961")]
		Sliced = 1,
		[Token(Token = "0x4000962")]
		Tiled = 2
	}

	[Token(Token = "0x200022B")]
	public enum Flip
	{
		[Token(Token = "0x4000964")]
		Nothing = 0,
		[Token(Token = "0x4000965")]
		Horizontally = 1,
		[Token(Token = "0x4000966")]
		Vertically = 2,
		[Token(Token = "0x4000967")]
		Both = 3
	}

	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x11C")]
	[HideInInspector]
	[SerializeField]
	protected Type mType;

	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[HideInInspector]
	protected FillDirection mFillDirection;

	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x124")]
	[HideInInspector]
	[SerializeField]
	protected float mFillAmount;

	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[HideInInspector]
	protected bool mInvert;

	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x12C")]
	[HideInInspector]
	[SerializeField]
	protected Flip mFlip;

	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[HideInInspector]
	protected bool mApplyGradient;

	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	[HideInInspector]
	protected Color mGradientTop;

	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	[HideInInspector]
	protected Color mGradientBottom;

	[NonSerialized]
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x154")]
	private Rect mInnerUV;

	[NonSerialized]
	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x164")]
	private Rect mOuterUV;

	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x174")]
	public AdvancedType centerType;

	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x178")]
	public AdvancedType leftType;

	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x17C")]
	public AdvancedType rightType;

	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x180")]
	public AdvancedType bottomType;

	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x184")]
	public AdvancedType topType;

	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x0")]
	protected static Vector2[] mTempPos;

	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x4")]
	protected static Vector2[] mTempUVs;

	[Token(Token = "0x170002B0")]
	public virtual Type type
	{
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x1D69698", Offset = "0x1D69698", VA = "0x1D69698", Slot = "39")]
		get
		{
			return default(Type);
		}
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x1D696A0", Offset = "0x1D696A0", VA = "0x1D696A0", Slot = "40")]
		set
		{
		}
	}

	[Token(Token = "0x170002B1")]
	public Flip flip
	{
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x1D696F4", Offset = "0x1D696F4", VA = "0x1D696F4")]
		get
		{
			return default(Flip);
		}
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x1D696FC", Offset = "0x1D696FC", VA = "0x1D696FC")]
		set
		{
		}
	}

	[Token(Token = "0x170002B2")]
	public FillDirection fillDirection
	{
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x1D69750", Offset = "0x1D69750", VA = "0x1D69750")]
		get
		{
			return default(FillDirection);
		}
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x1D69758", Offset = "0x1D69758", VA = "0x1D69758")]
		set
		{
		}
	}

	[Token(Token = "0x170002B3")]
	public float fillAmount
	{
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x1D5D980", Offset = "0x1D5D980", VA = "0x1D5D980")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x1D5DA78", Offset = "0x1D5DA78", VA = "0x1D5DA78")]
		set
		{
		}
	}

	[Token(Token = "0x170002B4")]
	public override int minWidth
	{
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x1D69770", Offset = "0x1D69770", VA = "0x1D69770", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002B5")]
	public override int minHeight
	{
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x1D6999C", Offset = "0x1D6999C", VA = "0x1D6999C", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002B6")]
	public bool invert
	{
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x1D69BC8", Offset = "0x1D69BC8", VA = "0x1D69BC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x1D69BD0", Offset = "0x1D69BD0", VA = "0x1D69BD0")]
		set
		{
		}
	}

	[Token(Token = "0x170002B7")]
	public bool hasBorder
	{
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x1D63C14", Offset = "0x1D63C14", VA = "0x1D63C14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002B8")]
	public virtual bool premultipliedAlpha
	{
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x1D69BF0", Offset = "0x1D69BF0", VA = "0x1D69BF0", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002B9")]
	public virtual float pixelSize
	{
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x1D69BF8", Offset = "0x1D69BF8", VA = "0x1D69BF8", Slot = "42")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002BA")]
	private Vector4 drawingUVs
	{
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x1D69C00", Offset = "0x1D69C00", VA = "0x1D69C00")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170002BB")]
	protected Color drawingColor
	{
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x1D69D38", Offset = "0x1D69D38", VA = "0x1D69D38")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x600127F")]
	[Address(RVA = "0x1D62414", Offset = "0x1D62414", VA = "0x1D62414")]
	protected UIBasicSprite()
	{
	}

	[Token(Token = "0x6001292")]
	[Address(RVA = "0x1D64204", Offset = "0x1D64204", VA = "0x1D64204")]
	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols, Rect outer, Rect inner)
	{
	}

	[Token(Token = "0x6001293")]
	[Address(RVA = "0x1D69E70", Offset = "0x1D69E70", VA = "0x1D69E70")]
	private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x6001294")]
	[Address(RVA = "0x1D6A330", Offset = "0x1D6A330", VA = "0x1D6A330")]
	private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x6001295")]
	[Address(RVA = "0x1D70A48", Offset = "0x1D70A48", VA = "0x1D70A48")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	private void AddVertexColours(BetterList<Color> cols, ref Color color, int x, int y)
	{
	}

	[Token(Token = "0x6001296")]
	[Address(RVA = "0x1D6D924", Offset = "0x1D6D924", VA = "0x1D6D924")]
	private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x6001297")]
	[Address(RVA = "0x1D6B950", Offset = "0x1D6B950", VA = "0x1D6B950")]
	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x6001298")]
	[Address(RVA = "0x1D6E17C", Offset = "0x1D6E17C", VA = "0x1D6E17C")]
	private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	[Token(Token = "0x6001299")]
	[Address(RVA = "0x1D70C60", Offset = "0x1D70C60", VA = "0x1D70C60")]
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return default(bool);
	}

	[Token(Token = "0x600129A")]
	[Address(RVA = "0x1D711BC", Offset = "0x1D711BC", VA = "0x1D711BC")]
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	[Token(Token = "0x600129B")]
	[Address(RVA = "0x1D70E54", Offset = "0x1D70E54", VA = "0x1D70E54")]
	private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}
}
