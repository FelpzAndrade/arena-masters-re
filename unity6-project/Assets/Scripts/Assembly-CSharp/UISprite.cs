using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200028B")]
[ExecuteInEditMode]
public class UISprite : UIBasicSprite
{
	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x18C")]
	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x190")]
	[HideInInspector]
	[SerializeField]
	private bool mFillCenter;

	[NonSerialized]
	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x194")]
	protected UISpriteData mSprite;

	[NonSerialized]
	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x198")]
	private bool mSpriteSet;

	[Token(Token = "0x170003AC")]
	public override Material material
	{
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x179CDFC", Offset = "0x179CDFC", VA = "0x179CDFC", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AD")]
	public UIAtlas atlas
	{
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x179CEDC", Offset = "0x179CEDC", VA = "0x179CEDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x179CEE4", Offset = "0x179CEE4", VA = "0x179CEE4")]
		set
		{
		}
	}

	[Token(Token = "0x170003AE")]
	public string spriteName
	{
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x179D598", Offset = "0x179D598", VA = "0x179D598")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x179D3D4", Offset = "0x179D3D4", VA = "0x179D3D4")]
		set
		{
		}
	}

	[Token(Token = "0x170003AF")]
	public bool isValid
	{
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x179D5A0", Offset = "0x179D5A0", VA = "0x179D5A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003B0")]
	public bool fillCenter
	{
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x179D8AC", Offset = "0x179D8AC", VA = "0x179D8AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x179D8BC", Offset = "0x179D8BC", VA = "0x179D8BC")]
		set
		{
		}
	}

	[Token(Token = "0x170003B1")]
	public bool applyGradient
	{
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x179D918", Offset = "0x179D918", VA = "0x179D918")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x179D920", Offset = "0x179D920", VA = "0x179D920")]
		set
		{
		}
	}

	[Token(Token = "0x170003B2")]
	public Color gradientTop
	{
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x179D97C", Offset = "0x179D97C", VA = "0x179D97C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x179D98C", Offset = "0x179D98C", VA = "0x179D98C")]
		set
		{
		}
	}

	[Token(Token = "0x170003B3")]
	public Color gradientBottom
	{
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x179DA3C", Offset = "0x179DA3C", VA = "0x179DA3C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x179DA4C", Offset = "0x179DA4C", VA = "0x179DA4C")]
		set
		{
		}
	}

	[Token(Token = "0x170003B4")]
	public override Vector4 border
	{
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x179DAFC", Offset = "0x179DAFC", VA = "0x179DAFC", Slot = "36")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170003B5")]
	public override float pixelSize
	{
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x179DB9C", Offset = "0x179DB9C", VA = "0x179DB9C", Slot = "42")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003B6")]
	public override int minWidth
	{
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x179DC7C", Offset = "0x179DC7C", VA = "0x179DC7C", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003B7")]
	public override int minHeight
	{
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x179DF4C", Offset = "0x179DF4C", VA = "0x179DF4C", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003B8")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x179E21C", Offset = "0x179E21C", VA = "0x179E21C", Slot = "24")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170003B9")]
	public override bool premultipliedAlpha
	{
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x179E738", Offset = "0x179E738", VA = "0x179E738", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600164D")]
	[Address(RVA = "0x179CD50", Offset = "0x179CD50", VA = "0x179CD50")]
	public UISprite()
	{
	}

	[Token(Token = "0x6001662")]
	[Address(RVA = "0x179D5B8", Offset = "0x179D5B8", VA = "0x179D5B8")]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[Token(Token = "0x6001663")]
	[Address(RVA = "0x179D2D8", Offset = "0x179D2D8", VA = "0x179D2D8")]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[Token(Token = "0x6001664")]
	[Address(RVA = "0x179E81C", Offset = "0x179E81C", VA = "0x179E81C", Slot = "33")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6001665")]
	[Address(RVA = "0x179EE9C", Offset = "0x179EE9C", VA = "0x179EE9C", Slot = "15")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6001666")]
	[Address(RVA = "0x179EEE8", Offset = "0x179EEE8", VA = "0x179EEE8", Slot = "22")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6001667")]
	[Address(RVA = "0x179EFE8", Offset = "0x179EFE8", VA = "0x179EFE8", Slot = "38")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
