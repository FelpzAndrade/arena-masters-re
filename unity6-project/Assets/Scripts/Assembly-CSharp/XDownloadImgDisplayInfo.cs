using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200065A")]
public class XDownloadImgDisplayInfo
{
	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 TextSpace;

	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Position;

	[Token(Token = "0x4001E78")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 Size;

	[Token(Token = "0x4001E79")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 Rotation;

	[Token(Token = "0x4001E7A")]
	[FieldOffset(Offset = "0x2C")]
	public int FontSize;

	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0x30")]
	public string Text;

	[Token(Token = "0x4001E7C")]
	[FieldOffset(Offset = "0x34")]
	public string ImgPath;

	[Token(Token = "0x4001E7D")]
	[FieldOffset(Offset = "0x38")]
	public float OutlineSize;

	[Token(Token = "0x4001E7E")]
	[FieldOffset(Offset = "0x3C")]
	public Color OutlineColor;

	[Token(Token = "0x600362E")]
	[Address(RVA = "0x19A8FA0", Offset = "0x19A8FA0", VA = "0x19A8FA0")]
	public XDownloadImgDisplayInfo()
	{
	}

	[Token(Token = "0x600362F")]
	[Address(RVA = "0x19A8FA8", Offset = "0x19A8FA8", VA = "0x19A8FA8")]
	public bool IsImgDisplay()
	{
		return !string.IsNullOrEmpty(ImgPath);
	}

	[Token(Token = "0x6003630")]
	[Address(RVA = "0x19A9058", Offset = "0x19A9058", VA = "0x19A9058")]
	public bool IsTextDisplay()
	{
		if (IsImgDisplay())
		{
			return false;
		}
		return !string.IsNullOrEmpty(Text);
	}
}
