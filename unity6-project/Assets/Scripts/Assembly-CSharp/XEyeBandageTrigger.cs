using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010F2")]
public class XEyeBandageTrigger : MonoBehaviour
{
	[Token(Token = "0x4005CF7")]
	[FieldOffset(Offset = "0xC")]
	public SphereCollider collider;

	[Token(Token = "0x4005CF8")]
	[FieldOffset(Offset = "0x10")]
	public Transform position;

	[Token(Token = "0x4005CF9")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 offset;

	[Token(Token = "0x4005CFA")]
	[FieldOffset(Offset = "0x20")]
	public XModuleAttackInfo attackInfo;

	[Token(Token = "0x6007F99")]
	[Address(RVA = "0x19B073C", Offset = "0x19B073C", VA = "0x19B073C")]
	public XEyeBandageTrigger()
	{
	}

	[Token(Token = "0x6007F9A")]
	[Address(RVA = "0x19B0744", Offset = "0x19B0744", VA = "0x19B0744")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007F9B")]
	[Address(RVA = "0x19B0824", Offset = "0x19B0824", VA = "0x19B0824")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6007F9C")]
	[Address(RVA = "0x19B0C68", Offset = "0x19B0C68", VA = "0x19B0C68")]
	private void OnTriggerStay(Collider col)
	{
	}
}
