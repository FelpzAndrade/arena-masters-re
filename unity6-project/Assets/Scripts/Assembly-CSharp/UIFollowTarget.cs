using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005F")]
public class UIFollowTarget : MonoBehaviour
{
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0xC")]
	public Transform target;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x10")]
	public Camera gameCamera;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x14")]
	public Camera uiCamera;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x18")]
	public bool disableIfInvisible;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x1C")]
	private Transform mTrans;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x20")]
	private bool mIsVisible;

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x16ED35C", Offset = "0x16ED35C", VA = "0x16ED35C")]
	public UIFollowTarget()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x16ED36C", Offset = "0x16ED36C", VA = "0x16ED36C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x16ED388", Offset = "0x16ED388", VA = "0x16ED388")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x16ED64C", Offset = "0x16ED64C", VA = "0x16ED64C")]
	private void SetVisible(bool val)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x16ED768", Offset = "0x16ED768", VA = "0x16ED768")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x16EDADC", Offset = "0x16EDADC", VA = "0x16EDADC", Slot = "4")]
	protected virtual void OnUpdate(bool isVisible)
	{
	}
}
