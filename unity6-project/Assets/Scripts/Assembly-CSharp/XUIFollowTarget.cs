using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D77")]
public class XUIFollowTarget : MonoBehaviour
{
	[Token(Token = "0x4004574")]
	[FieldOffset(Offset = "0xC")]
	public Transform target;

	[Token(Token = "0x4004575")]
	[FieldOffset(Offset = "0x10")]
	public float yWorldOffset;

	[Token(Token = "0x4004576")]
	[FieldOffset(Offset = "0x14")]
	public float xUIOffset;

	[Token(Token = "0x4004577")]
	[FieldOffset(Offset = "0x18")]
	public float yUIOffset;

	[Token(Token = "0x4004578")]
	[FieldOffset(Offset = "0x1C")]
	public Camera gameCamera;

	[Token(Token = "0x4004579")]
	[FieldOffset(Offset = "0x20")]
	public Camera uiCamera;

	[Token(Token = "0x400457A")]
	[FieldOffset(Offset = "0x24")]
	public bool disableIfInvisible;

	[Token(Token = "0x400457B")]
	[FieldOffset(Offset = "0x28")]
	private Transform mTrans;

	[Token(Token = "0x400457C")]
	[FieldOffset(Offset = "0x2C")]
	private bool mIsVisible;

	[Token(Token = "0x17000D32")]
	public bool IsVisible
	{
		[Token(Token = "0x60062DF")]
		[Address(RVA = "0x1A45888", Offset = "0x1A45888", VA = "0x1A45888")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60062D7")]
	[Address(RVA = "0x1A45144", Offset = "0x1A45144", VA = "0x1A45144")]
	public XUIFollowTarget()
	{
	}

	[Token(Token = "0x60062D8")]
	[Address(RVA = "0x1A45154", Offset = "0x1A45154", VA = "0x1A45154")]
	private void Awake()
	{
	}

	[Token(Token = "0x60062D9")]
	[Address(RVA = "0x1A45170", Offset = "0x1A45170", VA = "0x1A45170")]
	private void Start()
	{
	}

	[Token(Token = "0x60062DA")]
	[Address(RVA = "0x1A45178", Offset = "0x1A45178", VA = "0x1A45178")]
	public void Init(GameObject goTarget, float yWorldOffset)
	{
	}

	[Token(Token = "0x60062DB")]
	[Address(RVA = "0x1A455B4", Offset = "0x1A455B4", VA = "0x1A455B4")]
	public void Init(GameObject goTarget, float xUIOffset, float yUIOffset)
	{
	}

	[Token(Token = "0x60062DC")]
	[Address(RVA = "0x1A45174", Offset = "0x1A45174", VA = "0x1A45174")]
	public void Use()
	{
	}

	[Token(Token = "0x60062DD")]
	[Address(RVA = "0x1A45874", Offset = "0x1A45874", VA = "0x1A45874")]
	public void Grab()
	{
	}

	[Token(Token = "0x60062DE")]
	[Address(RVA = "0x1A4542C", Offset = "0x1A4542C", VA = "0x1A4542C")]
	private void SetVisible(bool val)
	{
	}

	[Token(Token = "0x60062E0")]
	[Address(RVA = "0x1A45890", Offset = "0x1A45890", VA = "0x1A45890")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60062E1")]
	[Address(RVA = "0x1A45D3C", Offset = "0x1A45D3C", VA = "0x1A45D3C", Slot = "4")]
	protected virtual void OnUpdate(bool isVisible)
	{
	}
}
