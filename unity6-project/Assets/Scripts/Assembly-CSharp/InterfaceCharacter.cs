using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE9")]
public class InterfaceCharacter : MonoBehaviour
{
	[Token(Token = "0x40041C0")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x40041C1")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprTagChar;

	[Token(Token = "0x40041C2")]
	[FieldOffset(Offset = "0x14")]
	public UISprite sprTagCool;

	[Token(Token = "0x40041C3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite sprHealthBar;

	[Token(Token = "0x40041C4")]
	[FieldOffset(Offset = "0x1C")]
	public UISlider HP_Bar;

	[Token(Token = "0x40041C5")]
	[FieldOffset(Offset = "0x20")]
	public UISlider Shield_Bar;

	[Token(Token = "0x40041C6")]
	[FieldOffset(Offset = "0x24")]
	public Color allyPrbColor;

	[Token(Token = "0x40041C7")]
	[FieldOffset(Offset = "0x34")]
	public Color enemyPrbColorTop;

	[Token(Token = "0x40041C8")]
	[FieldOffset(Offset = "0x44")]
	public Color allyLabelColor;

	[Token(Token = "0x40041C9")]
	[FieldOffset(Offset = "0x54")]
	public Color enemyLabelColor;

	[Token(Token = "0x40041CA")]
	[FieldOffset(Offset = "0x64")]
	public Transform effectRoot;

	[Token(Token = "0x40041CB")]
	[FieldOffset(Offset = "0x68")]
	public TweenColor hitTween;

	[Token(Token = "0x40041CC")]
	[FieldOffset(Offset = "0x6C")]
	public XUIEmblem Emblem;

	[Token(Token = "0x40041CD")]
	[FieldOffset(Offset = "0x70")]
	public GameObject clipping;

	[Token(Token = "0x40041CE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string allyUltOnPath;

	[Token(Token = "0x40041CF")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string enemyUltOnPath;

	[Token(Token = "0x40041D0")]
	[FieldOffset(Offset = "0x74")]
	private GameObject _allyUltOn;

	[Token(Token = "0x40041D1")]
	[FieldOffset(Offset = "0x78")]
	private GameObject _enemyUltOn;

	[Token(Token = "0x40041D2")]
	[FieldOffset(Offset = "0x7C")]
	private bool allyUltOn;

	[Token(Token = "0x40041D3")]
	[FieldOffset(Offset = "0x7D")]
	private bool enemyUltOn;

	[Token(Token = "0x17000CF0")]
	protected virtual bool enableUltEffect
	{
		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0xD8D86C", Offset = "0xD8D86C", VA = "0xD8D86C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005D28")]
	[Address(RVA = "0xD8D7B8", Offset = "0xD8D7B8", VA = "0xD8D7B8")]
	public InterfaceCharacter()
	{
	}

	[Token(Token = "0x6005D2B")]
	[Address(RVA = "0xD8D874", Offset = "0xD8D874", VA = "0xD8D874")]
	public void InitUltOnGameObject()
	{
	}

	[Token(Token = "0x6005D2C")]
	[Address(RVA = "0xD8DB5C", Offset = "0xD8DB5C", VA = "0xD8DB5C")]
	public void SetEmblem(int emblemID)
	{
	}

	[Token(Token = "0x6005D2D")]
	[Address(RVA = "0xD8DC40", Offset = "0xD8DC40", VA = "0xD8DC40")]
	public void SetColor(bool isEnemy)
	{
	}

	[Token(Token = "0x6005D2E")]
	[Address(RVA = "0xD8DE68", Offset = "0xD8DE68", VA = "0xD8DE68")]
	public void PlayHittedTween()
	{
	}

	[Token(Token = "0x6005D2F")]
	[Address(RVA = "0xD8DE38", Offset = "0xD8DE38", VA = "0xD8DE38")]
	private Color GetLabelColor(bool isEnemy)
	{
		return default(Color);
	}

	[Token(Token = "0x6005D30")]
	[Address(RVA = "0xD8DE50", Offset = "0xD8DE50", VA = "0xD8DE50")]
	private Color GetColorPrb(bool isEnemy)
	{
		return default(Color);
	}

	[Token(Token = "0x6005D31")]
	[Address(RVA = "0xD8DEAC", Offset = "0xD8DEAC", VA = "0xD8DEAC")]
	public void SetCharacterName(string name)
	{
	}

	[Token(Token = "0x6005D32")]
	[Address(RVA = "0xD8DF8C", Offset = "0xD8DF8C", VA = "0xD8DF8C")]
	public void Hide(bool bHide)
	{
	}

	[Token(Token = "0x6005D33")]
	[Address(RVA = "0xD8DFC4", Offset = "0xD8DFC4", VA = "0xD8DFC4")]
	public void UpdateHealthBar(float curHp, float maxHp, float curShield)
	{
	}

	[Token(Token = "0x6005D34")]
	[Address(RVA = "0xD8E0E8", Offset = "0xD8E0E8", VA = "0xD8E0E8")]
	public void SetTagCharacterThumbnail(Sprite spr)
	{
	}

	[Token(Token = "0x6005D35")]
	[Address(RVA = "0xD8E270", Offset = "0xD8E270", VA = "0xD8E270")]
	public void SetUltOn(bool ultOn, bool isEnemy)
	{
	}

	[Token(Token = "0x6005D36")]
	[Address(RVA = "0xD8E404", Offset = "0xD8E404", VA = "0xD8E404")]
	public void UpdateUltOnEffect(bool isEnemy)
	{
	}

	[Token(Token = "0x6005D37")]
	[Address(RVA = "0xD8E630", Offset = "0xD8E630", VA = "0xD8E630")]
	public void SetTagCool(float fillAmount)
	{
	}
}
