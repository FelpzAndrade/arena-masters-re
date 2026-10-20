using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000255")]
[ExecuteInEditMode]
public class UI2DSprite : UIBasicSprite
{
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x188")]
	[HideInInspector]
	[SerializeField]
	private Sprite mSprite;

	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x18C")]
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x190")]
	[HideInInspector]
	[SerializeField]
	private Shader mShader;

	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x194")]
	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder;

	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x1A4")]
	[SerializeField]
	[HideInInspector]
	private bool mFixedAspect;

	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x1A8")]
	[HideInInspector]
	[SerializeField]
	private float mPixelSize;

	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x1AC")]
	public Sprite nextSprite;

	[NonSerialized]
	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x1B0")]
	private int mPMA;

	[Token(Token = "0x17000316")]
	public Sprite sprite2D
	{
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x1D625C4", Offset = "0x1D625C4", VA = "0x1D625C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x1D625CC", Offset = "0x1D625CC", VA = "0x1D625CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000317")]
	public override Material material
	{
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x1D626AC", Offset = "0x1D626AC", VA = "0x1D626AC", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x1D626B4", Offset = "0x1D626B4", VA = "0x1D626B4", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000318")]
	public override Shader shader
	{
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x1D627BC", Offset = "0x1D627BC", VA = "0x1D627BC", Slot = "29")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x1D6291C", Offset = "0x1D6291C", VA = "0x1D6291C", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x17000319")]
	public override Texture mainTexture
	{
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x1D62A78", Offset = "0x1D62A78", VA = "0x1D62A78", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700031A")]
	public override bool premultipliedAlpha
	{
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x1D62BC8", Offset = "0x1D62BC8", VA = "0x1D62BC8", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700031B")]
	public override float pixelSize
	{
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x1D62D30", Offset = "0x1D62D30", VA = "0x1D62D30", Slot = "42")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700031C")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x1D62D38", Offset = "0x1D62D38", VA = "0x1D62D38", Slot = "24")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700031D")]
	public override Vector4 border
	{
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x1D633AC", Offset = "0x1D633AC", VA = "0x1D633AC", Slot = "36")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x1D633BC", Offset = "0x1D633BC", VA = "0x1D633BC", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x6001433")]
	[Address(RVA = "0x1D62338", Offset = "0x1D62338", VA = "0x1D62338")]
	public UI2DSprite()
	{
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0x1D63460", Offset = "0x1D63460", VA = "0x1D63460", Slot = "22")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0x1D639C4", Offset = "0x1D639C4", VA = "0x1D639C4", Slot = "33")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0x1D63CA0", Offset = "0x1D63CA0", VA = "0x1D63CA0", Slot = "38")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
