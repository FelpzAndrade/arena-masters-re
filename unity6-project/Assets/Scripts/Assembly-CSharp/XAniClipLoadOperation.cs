using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000600")]
public abstract class XAniClipLoadOperation : IEnumerator
{
	[Token(Token = "0x170007A2")]
	public object Current
	{
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x1EE2E84", Offset = "0x1EE2E84", VA = "0x1EE2E84", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003352")]
	[Address(RVA = "0x1EE2E7C", Offset = "0x1EE2E7C", VA = "0x1EE2E7C")]
	protected XAniClipLoadOperation()
	{
	}

	[Token(Token = "0x6003354")]
	[Address(RVA = "0x1EE2E8C", Offset = "0x1EE2E8C", VA = "0x1EE2E8C", Slot = "5")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6003355")]
	[Address(RVA = "0x1EE2ECC", Offset = "0x1EE2ECC", VA = "0x1EE2ECC", Slot = "6")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003356")]
	public abstract bool IsDone();

	[Token(Token = "0x6003357")]
	public abstract AnimationClip GetAsset();
}
