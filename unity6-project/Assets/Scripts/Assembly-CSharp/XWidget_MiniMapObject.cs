using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D3B")]
public class XWidget_MiniMapObject : MonoBehaviour
{
	[Token(Token = "0x40043CF")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public Transform MyTransform;

	[Token(Token = "0x40043D0")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprIcon;

	[Token(Token = "0x6006115")]
	[Address(RVA = "0x1465814", Offset = "0x1465814", VA = "0x1465814")]
	public XWidget_MiniMapObject()
	{
	}

	[Token(Token = "0x6006116")]
	[Address(RVA = "0x146581C", Offset = "0x146581C", VA = "0x146581C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006117")]
	[Address(RVA = "0x146500C", Offset = "0x146500C", VA = "0x146500C")]
	public void Show()
	{
	}

	[Token(Token = "0x6006118")]
	[Address(RVA = "0x14638B4", Offset = "0x14638B4", VA = "0x14638B4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6006119")]
	[Address(RVA = "0x146560C", Offset = "0x146560C", VA = "0x146560C")]
	public void ChangeColor(Color color)
	{
	}
}
