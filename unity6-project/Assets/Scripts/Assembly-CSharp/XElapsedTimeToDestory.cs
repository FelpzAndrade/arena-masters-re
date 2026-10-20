using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000408")]
public class XElapsedTimeToDestory : MonoBehaviour
{
	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0xC")]
	public float delay;

	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x10")]
	public bool usePool;

	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x14")]
	public XPoolType poolType;

	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x18")]
	public bool autoDestroy;

	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3? m_reservedScale;

	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x2C")]
	private float elapsedTime;

	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x30")]
	private bool running;

	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x19AD674", Offset = "0x19AD674", VA = "0x19AD674")]
	public XElapsedTimeToDestory()
	{
	}

	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x19AD690", Offset = "0x19AD690", VA = "0x19AD690")]
	private void Start()
	{
	}

	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x19AD6A4", Offset = "0x19AD6A4", VA = "0x19AD6A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x19AD8F0", Offset = "0x19AD8F0", VA = "0x19AD8F0")]
	public void StartManually()
	{
	}

	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x19AD904", Offset = "0x19AD904", VA = "0x19AD904")]
	public void ForcedToDestroy()
	{
	}

	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x19AD70C", Offset = "0x19AD70C", VA = "0x19AD70C")]
	public void DoDestroy()
	{
	}

	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x19AD920", Offset = "0x19AD920", VA = "0x19AD920")]
	public void ReserveScaleOnDestroy(Vector3 scale)
	{
	}
}
