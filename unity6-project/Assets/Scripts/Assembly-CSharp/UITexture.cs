using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000293")]
[ExecuteInEditMode]
public class UITexture : UIBasicSprite
{
	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[HideInInspector]
	private Rect mRect;

	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x198")]
	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x19C")]
	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x1A4")]
	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder;

	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x1B4")]
	[HideInInspector]
	[SerializeField]
	private bool mFixedAspect;

	[NonSerialized]
	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x1B8")]
	private int mPMA;

	[Token(Token = "0x170003C6")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x17A4BE8", Offset = "0x17A4BE8", VA = "0x17A4BE8", Slot = "27")]
		get
		{
			return null;
		}
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x17A4D24", Offset = "0x17A4D24", VA = "0x17A4D24", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x170003C7")]
	public override Material material
	{
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x17A4F0C", Offset = "0x17A4F0C", VA = "0x17A4F0C", Slot = "25")]
		get
		{
			return null;
		}
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x17A4F14", Offset = "0x17A4F14", VA = "0x17A4F14", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x170003C8")]
	public override Shader shader
	{
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x17A5020", Offset = "0x17A5020", VA = "0x17A5020", Slot = "29")]
		get
		{
			return null;
		}
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x17A5180", Offset = "0x17A5180", VA = "0x17A5180", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x170003C9")]
	public override bool premultipliedAlpha
	{
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x17A5370", Offset = "0x17A5370", VA = "0x17A5370", Slot = "41")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003CA")]
	public override Vector4 border
	{
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x17A5544", Offset = "0x17A5544", VA = "0x17A5544", Slot = "36")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x17A5554", Offset = "0x17A5554", VA = "0x17A5554", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x170003CB")]
	public Rect uvRect
	{
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x17A55F8", Offset = "0x17A55F8", VA = "0x17A55F8")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x17A5608", Offset = "0x17A5608", VA = "0x17A5608")]
		set
		{
		}
	}

	[Token(Token = "0x170003CC")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x17A56AC", Offset = "0x17A56AC", VA = "0x17A56AC", Slot = "24")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170003CD")]
	public bool fixedAspect
	{
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x17A5A3C", Offset = "0x17A5A3C", VA = "0x17A5A3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x17A5A44", Offset = "0x17A5A44", VA = "0x17A5A44")]
		set
		{
		}
	}

	[Token(Token = "0x6001698")]
	[Address(RVA = "0x17A4AD4", Offset = "0x17A4AD4", VA = "0x17A4AD4")]
	public UITexture()
	{
	}

	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x17A5AE0", Offset = "0x17A5AE0", VA = "0x17A5AE0", Slot = "33")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x17A5CE0", Offset = "0x17A5CE0", VA = "0x17A5CE0", Slot = "22")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x17A5F40", Offset = "0x17A5F40", VA = "0x17A5F40", Slot = "38")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
