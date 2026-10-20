using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000244")]
public class SpringPosition : MonoBehaviour
{
	[Token(Token = "0x2000245")]
	public delegate void OnFinished();

	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x0")]
	public static SpringPosition current;

	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 target;

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x1C")]
	public bool worldSpace;

	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x1D")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x1E")]
	public bool updateScrollView;

	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x20")]
	public OnFinished onFinished;

	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	public string callWhenFinished;

	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x2C")]
	private Transform mTrans;

	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x30")]
	private float mThreshold;

	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x34")]
	private UIScrollView mSv;

	[Token(Token = "0x600138F")]
	[Address(RVA = "0x1D43EA0", Offset = "0x1D43EA0", VA = "0x1D43EA0")]
	public SpringPosition()
	{
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0x1D43EE8", Offset = "0x1D43EE8", VA = "0x1D43EE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x1D43FD8", Offset = "0x1D43FD8", VA = "0x1D43FD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0x1D44490", Offset = "0x1D44490", VA = "0x1D44490")]
	private void NotifyListeners()
	{
	}

	[Token(Token = "0x6001393")]
	[Address(RVA = "0x1D446B8", Offset = "0x1D446B8", VA = "0x1D446B8")]
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}
}
