using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CDE")]
public class GameobjectDirectionElement : DelayDirectionElement
{
	[Token(Token = "0x4004198")]
	[FieldOffset(Offset = "0x14")]
	private GameObject go;

	[Token(Token = "0x6005CED")]
	[Address(RVA = "0x1F2DE40", Offset = "0x1F2DE40", VA = "0x1F2DE40")]
	public GameobjectDirectionElement(GameObject go, float duration)
	{
	}

	[Token(Token = "0x6005CEE")]
	[Address(RVA = "0x1F2DE64", Offset = "0x1F2DE64", VA = "0x1F2DE64", Slot = "8")]
	public override void Start()
	{
	}

	[Token(Token = "0x6005CEF")]
	[Address(RVA = "0x1F2DEA0", Offset = "0x1F2DEA0", VA = "0x1F2DEA0", Slot = "9")]
	public override void Update()
	{
	}

	[Token(Token = "0x6005CF0")]
	[Address(RVA = "0x1F2DEF0", Offset = "0x1F2DEF0", VA = "0x1F2DEF0", Slot = "10")]
	public override void Skip()
	{
	}

	[Token(Token = "0x6005CF1")]
	[Address(RVA = "0x1F2DF2C", Offset = "0x1F2DF2C", VA = "0x1F2DF2C", Slot = "11")]
	public override bool IsFinished()
	{
		return default(bool);
	}
}
