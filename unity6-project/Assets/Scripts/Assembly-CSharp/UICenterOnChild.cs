using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C9")]
public class UICenterOnChild : MonoBehaviour
{
	[Token(Token = "0x20001CA")]
	public delegate void OnCenterCallback(GameObject centeredObject);

	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0xC")]
	public float springStrength;

	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x10")]
	public float nextPageThreshold;

	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x14")]
	public SpringPanel.OnFinished onFinished;

	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x18")]
	public OnCenterCallback onCenter;

	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x1C")]
	private UIScrollView mScrollView;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x20")]
	private GameObject mCenteredObject;

	[Token(Token = "0x17000250")]
	public GameObject centeredObject
	{
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x16D81A0", Offset = "0x16D81A0", VA = "0x16D81A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x16D8190", Offset = "0x16D8190", VA = "0x16D8190")]
	public UICenterOnChild()
	{
	}

	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x16D81A8", Offset = "0x16D81A8", VA = "0x16D81A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x16D96CC", Offset = "0x16D96CC", VA = "0x16D96CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x16D97A4", Offset = "0x16D97A4", VA = "0x16D97A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x16D9878", Offset = "0x16D9878", VA = "0x16D9878")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x16D98A0", Offset = "0x16D98A0", VA = "0x16D98A0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x16D81AC", Offset = "0x16D81AC", VA = "0x16D81AC")]
	public void Recenter()
	{
	}

	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x16D9D5C", Offset = "0x16D9D5C", VA = "0x16D9D5C")]
	private void CenterOn(Transform target, Vector3 panelCenter)
	{
	}

	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x16DA158", Offset = "0x16DA158", VA = "0x16DA158")]
	public void CenterOn(Transform target)
	{
	}
}
