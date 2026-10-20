using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000014")]
[ExecuteInEditMode]
public class BRDFLookupTexture : MonoBehaviour
{
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0xC")]
	public float intensity;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x10")]
	public float diffuseIntensity;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x14")]
	public Color keyColor;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x24")]
	public Color fillColor;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x34")]
	public Color backColor;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x44")]
	public float wrapAround;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x48")]
	public float metalic;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x4C")]
	public float specularIntensity;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x50")]
	public float specularShininess;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x54")]
	public float translucency;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x58")]
	public Color translucentColor;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x68")]
	public int lookupTextureWidth;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x6C")]
	public int lookupTextureHeight;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x70")]
	public bool fastPreview;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x74")]
	public Texture2D lookupTexture;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x20C1830", Offset = "0x20C1830", VA = "0x20C1830")]
	public BRDFLookupTexture()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x20C19E4", Offset = "0x20C19E4", VA = "0x20C19E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x20C1980", Offset = "0x20C1980", VA = "0x20C1980")]
	private static Color ColorRGB(int r, int g, int b)
	{
		return default(Color);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x20C1AB4", Offset = "0x20C1AB4", VA = "0x20C1AB4")]
	private void CheckConsistency()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x20C1C20", Offset = "0x20C1C20", VA = "0x20C1C20")]
	private Color PixelFunc(float ndotl, float ndoth)
	{
		return default(Color);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x20C213C", Offset = "0x20C213C", VA = "0x20C213C")]
	private void TextureFunc(Texture2D tex)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x20C22BC", Offset = "0x20C22BC", VA = "0x20C22BC")]
	private void GenerateLookupTexture(int width, int height)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x20C2534", Offset = "0x20C2534", VA = "0x20C2534")]
	public void Preview()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x20C1AA8", Offset = "0x20C1AA8", VA = "0x20C1AA8")]
	public void Bake()
	{
	}
}
