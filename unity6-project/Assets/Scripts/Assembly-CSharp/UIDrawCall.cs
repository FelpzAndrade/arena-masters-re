using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022C")]
[ExecuteInEditMode]
public class UIDrawCall : MonoBehaviour
{
	[Token(Token = "0x200022D")]
	public enum Clipping
	{
		[Token(Token = "0x400098C")]
		None = 0,
		[Token(Token = "0x400098D")]
		TextureMask = 1,
		[Token(Token = "0x400098E")]
		SoftClip = 3,
		[Token(Token = "0x400098F")]
		ConstrainButDontClip = 4
	}

	[Token(Token = "0x200022E")]
	public delegate void OnRenderCallback(Material mat);

	[Token(Token = "0x4000968")]
	private const int maxIndexBufferCache = 10;

	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x0")]
	private static BetterList<UIDrawCall> mActiveList;

	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x4")]
	private static BetterList<UIDrawCall> mInactiveList;

	[NonSerialized]
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public int widgetCount;

	[NonSerialized]
	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public int depthStart;

	[NonSerialized]
	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public int depthEnd;

	[NonSerialized]
	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public UIPanel manager;

	[NonSerialized]
	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public UIPanel panel;

	[NonSerialized]
	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Texture2D clipTexture;

	[NonSerialized]
	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool alwaysOnScreen;

	[NonSerialized]
	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public BetterList<Vector3> verts;

	[NonSerialized]
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public BetterList<Vector3> norms;

	[NonSerialized]
	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public BetterList<Vector4> tans;

	[NonSerialized]
	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public BetterList<Vector2> uvs;

	[NonSerialized]
	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public BetterList<Color> cols;

	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x3C")]
	private Material mMaterial;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x40")]
	private Texture mTexture;

	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x44")]
	private Shader mShader;

	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x48")]
	private int mClipCount;

	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x4C")]
	private Transform mTrans;

	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x50")]
	private Mesh mMesh;

	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x54")]
	private MeshFilter mFilter;

	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x58")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x5C")]
	private Material mDynamicMat;

	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x60")]
	private int[] mIndices;

	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x64")]
	private bool mRebuildMat;

	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x65")]
	private bool mLegacyShader;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x68")]
	private int mRenderQueue;

	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x6C")]
	private int mTriangles;

	[NonSerialized]
	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x70")]
	public bool isDirty;

	[NonSerialized]
	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0x71")]
	private bool mTextureClip;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x74")]
	public OnRenderCallback onRender;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x8")]
	private static List<int[]> mCache;

	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0xC")]
	private static int[] ClipRange;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x10")]
	private static int[] ClipArgs;

	[Token(Token = "0x170002BC")]
	public static BetterList<UIDrawCall> list
	{
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x16E5B50", Offset = "0x16E5B50", VA = "0x16E5B50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BD")]
	public static BetterList<UIDrawCall> activeList
	{
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x16E5C00", Offset = "0x16E5C00", VA = "0x16E5C00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BE")]
	public static BetterList<UIDrawCall> inactiveList
	{
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x16E5CB0", Offset = "0x16E5CB0", VA = "0x16E5CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BF")]
	public int renderQueue
	{
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x16E5D60", Offset = "0x16E5D60", VA = "0x16E5D60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x16E5D68", Offset = "0x16E5D68", VA = "0x16E5D68")]
		set
		{
		}
	}

	[Token(Token = "0x170002C0")]
	public int sortingOrder
	{
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x16E5E5C", Offset = "0x16E5E5C", VA = "0x16E5E5C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x16E5F3C", Offset = "0x16E5F3C", VA = "0x16E5F3C")]
		set
		{
		}
	}

	[Token(Token = "0x170002C1")]
	public string sortingLayerName
	{
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x16E603C", Offset = "0x16E603C", VA = "0x16E603C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x16E611C", Offset = "0x16E611C", VA = "0x16E611C")]
		set
		{
		}
	}

	[Token(Token = "0x170002C2")]
	public int finalRenderQueue
	{
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x16E626C", Offset = "0x16E626C", VA = "0x16E626C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002C3")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x16E634C", Offset = "0x16E634C", VA = "0x16E634C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C4")]
	public Material baseMaterial
	{
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x16E641C", Offset = "0x16E641C", VA = "0x16E641C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x16E6424", Offset = "0x16E6424", VA = "0x16E6424")]
		set
		{
		}
	}

	[Token(Token = "0x170002C5")]
	public Material dynamicMaterial
	{
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x16E64E8", Offset = "0x16E64E8", VA = "0x16E64E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C6")]
	public Texture mainTexture
	{
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x16E64F0", Offset = "0x16E64F0", VA = "0x16E64F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x16E64F8", Offset = "0x16E64F8", VA = "0x16E64F8")]
		set
		{
		}
	}

	[Token(Token = "0x170002C7")]
	public Shader shader
	{
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x16E65DC", Offset = "0x16E65DC", VA = "0x16E65DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x16E65E4", Offset = "0x16E65E4", VA = "0x16E65E4")]
		set
		{
		}
	}

	[Token(Token = "0x170002C8")]
	public int triangles
	{
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x16E66A8", Offset = "0x16E66A8", VA = "0x16E66A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002C9")]
	public bool isClipped
	{
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x16E6768", Offset = "0x16E6768", VA = "0x16E6768")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600129C")]
	[Address(RVA = "0x16E58A4", Offset = "0x16E58A4", VA = "0x16E58A4")]
	public UIDrawCall()
	{
	}

	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x16E6778", Offset = "0x16E6778", VA = "0x16E6778")]
	private void CreateMaterial()
	{
	}

	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x16E75C0", Offset = "0x16E75C0", VA = "0x16E75C0")]
	private Material RebuildMaterial()
	{
		return null;
	}

	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x16E77F8", Offset = "0x16E77F8", VA = "0x16E77F8")]
	private void UpdateMaterials()
	{
	}

	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x16E7A80", Offset = "0x16E7A80", VA = "0x16E7A80")]
	public void UpdateGeometry(int widgetCount)
	{
	}

	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x16E8808", Offset = "0x16E8808", VA = "0x16E8808")]
	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		return null;
	}

	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x16E8C3C", Offset = "0x16E8C3C", VA = "0x16E8C3C")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x16E955C", Offset = "0x16E955C", VA = "0x16E955C")]
	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
	}

	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x16E98D8", Offset = "0x16E98D8", VA = "0x16E98D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x16E9D04", Offset = "0x16E9D04", VA = "0x16E9D04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x16E9D10", Offset = "0x16E9D10", VA = "0x16E9D10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x16E9E9C", Offset = "0x16E9E9C", VA = "0x16E9E9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x16E9F50", Offset = "0x16E9F50", VA = "0x16E9F50")]
	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x16EA010", Offset = "0x16EA010", VA = "0x16EA010")]
	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x16EA174", Offset = "0x16EA174", VA = "0x16EA174")]
	private static UIDrawCall Create(string name)
	{
		return null;
	}

	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x16EA500", Offset = "0x16EA500", VA = "0x16EA500")]
	public static void ClearAll()
	{
	}

	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x16EA7C8", Offset = "0x16EA7C8", VA = "0x16EA7C8")]
	public static void ReleaseAll()
	{
	}

	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x16EA864", Offset = "0x16EA864", VA = "0x16EA864")]
	public static void ReleaseInactive()
	{
	}

	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x16EAAD4", Offset = "0x16EAAD4", VA = "0x16EAAD4")]
	public static int Count(UIPanel panel)
	{
		return default(int);
	}

	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x16EACA4", Offset = "0x16EACA4", VA = "0x16EACA4")]
	public static void Destroy(UIDrawCall dc)
	{
	}
}
