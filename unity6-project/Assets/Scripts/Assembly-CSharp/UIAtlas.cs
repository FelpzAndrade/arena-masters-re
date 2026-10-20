using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000259")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200025A")]
	private class Sprite
	{
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0xC")]
		public Rect outer;

		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x1C")]
		public Rect inner;

		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x2C")]
		public bool rotated;

		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x30")]
		public float paddingLeft;

		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x34")]
		public float paddingRight;

		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x38")]
		public float paddingTop;

		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x3C")]
		public float paddingBottom;

		[Token(Token = "0x17000326")]
		public bool hasPadding
		{
			[Token(Token = "0x600146A")]
			[Address(RVA = "0x1D69364", Offset = "0x1D69364", VA = "0x1D69364")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001469")]
		[Address(RVA = "0x1D69258", Offset = "0x1D69258", VA = "0x1D69258")]
		public Sprite()
		{
		}
	}

	[Token(Token = "0x200025B")]
	private enum Coordinates
	{
		[Token(Token = "0x4000A97")]
		Pixels = 0,
		[Token(Token = "0x4000A98")]
		TexCoords = 1
	}

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[HideInInspector]
	private Material material;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	private List<UISpriteData> mSprites;

	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[HideInInspector]
	private float mPixelSize;

	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private UIAtlas mReplacement;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[HideInInspector]
	private Coordinates mCoordinates;

	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites;

	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x24")]
	private int mPMA;

	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, int> mSpriteIndices;

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UISpriteData> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x17000320")]
	public Material spriteMaterial
	{
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x1D663D4", Offset = "0x1D663D4", VA = "0x1D663D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x1D664C0", Offset = "0x1D664C0", VA = "0x1D664C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000321")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x1D66A8C", Offset = "0x1D66A8C", VA = "0x1D66A8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000322")]
	public List<UISpriteData> spriteList
	{
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x1D66CB8", Offset = "0x1D66CB8", VA = "0x1D66CB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x1D67518", Offset = "0x1D67518", VA = "0x1D67518")]
		set
		{
		}
	}

	[Token(Token = "0x17000323")]
	public Texture texture
	{
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x1D67608", Offset = "0x1D67608", VA = "0x1D67608")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000324")]
	public float pixelSize
	{
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x1D67768", Offset = "0x1D67768", VA = "0x1D67768")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x1D67854", Offset = "0x1D67854", VA = "0x1D67854")]
		set
		{
		}
	}

	[Token(Token = "0x17000325")]
	public UIAtlas replacement
	{
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x1D679C0", Offset = "0x1D679C0", VA = "0x1D679C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x1D679C8", Offset = "0x1D679C8", VA = "0x1D679C8")]
		set
		{
		}
	}

	[Token(Token = "0x6001453")]
	[Address(RVA = "0x1D662B0", Offset = "0x1D662B0", VA = "0x1D662B0")]
	public UIAtlas()
	{
	}

	[Token(Token = "0x600145E")]
	[Address(RVA = "0x1D67C40", Offset = "0x1D67C40", VA = "0x1D67C40")]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[Token(Token = "0x600145F")]
	[Address(RVA = "0x1D681E4", Offset = "0x1D681E4", VA = "0x1D681E4")]
	public string GetRandomSprite(string startsWith)
	{
		return null;
	}

	[Token(Token = "0x6001460")]
	[Address(RVA = "0x1D68098", Offset = "0x1D68098", VA = "0x1D68098")]
	public void MarkSpriteListAsChanged()
	{
	}

	[Token(Token = "0x6001461")]
	[Address(RVA = "0x1D68570", Offset = "0x1D68570", VA = "0x1D68570")]
	public void SortAlphabetically()
	{
	}

	[Token(Token = "0x6001462")]
	[Address(RVA = "0x1D686AC", Offset = "0x1D686AC", VA = "0x1D686AC")]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[Token(Token = "0x6001463")]
	[Address(RVA = "0x1D68918", Offset = "0x1D68918", VA = "0x1D68918")]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[Token(Token = "0x6001464")]
	[Address(RVA = "0x1D68ED4", Offset = "0x1D68ED4", VA = "0x1D68ED4")]
	private bool References(UIAtlas atlas)
	{
		return default(bool);
	}

	[Token(Token = "0x6001465")]
	[Address(RVA = "0x1D6907C", Offset = "0x1D6907C", VA = "0x1D6907C")]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return default(bool);
	}

	[Token(Token = "0x6001466")]
	[Address(RVA = "0x1D66634", Offset = "0x1D66634", VA = "0x1D66634")]
	public void MarkAsChanged()
	{
	}

	[Token(Token = "0x6001467")]
	[Address(RVA = "0x1D66DE4", Offset = "0x1D66DE4", VA = "0x1D66DE4")]
	private bool Upgrade()
	{
		return default(bool);
	}

	[Token(Token = "0x6001468")]
	[Address(RVA = "0x1D6921C", Offset = "0x1D6921C", VA = "0x1D6921C")]
	private static int _003CSortAlphabetically_003Em__77(UISpriteData s1, UISpriteData s2)
	{
		return default(int);
	}
}
