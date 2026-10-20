using CS;
using Il2CppDummyDll;
using UnityEngine;

// Reconstruido a partir do pseudo-C (Ghidra) de libil2cpp.so.
[Token(Token = "0x20010F3")]
public class XFileLoader_UnityResource : CSFileLoaderBase
{
	[Token(Token = "0x6007F9D")]
	[Address(RVA = "0x198D500", Offset = "0x198D500", VA = "0x198D500")]
	public XFileLoader_UnityResource(string filename) : base(filename)
	{
	}

	[Token(Token = "0x6007F9E")]
	[Address(RVA = "0x19B1A3C", Offset = "0x19B1A3C", VA = "0x19B1A3C", Slot = "4")]
	public override string Load()
	{
		// O original passa por XAssetBundle.ResourceLoader (bundle ou Resources); aqui so Resources.
		TextAsset asset = Resources.Load<TextAsset>(Filename);
		if (asset == null)
		{
			CSLog.Error("Resource not found : " + Filename);
			return string.Empty;
		}
		return asset.text;
	}
}
