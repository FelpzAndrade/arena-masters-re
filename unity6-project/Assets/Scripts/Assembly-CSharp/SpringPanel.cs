using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000225")]
public class SpringPanel : MonoBehaviour
{
	[Token(Token = "0x2000226")]
	public delegate void OnFinished();

	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x0")]
	public static SpringPanel current;

	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 target;

	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x1C")]
	public OnFinished onFinished;

	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x20")]
	private UIPanel mPanel;

	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x24")]
	private Transform mTrans;

	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x28")]
	private UIScrollView mDrag;

	[Token(Token = "0x6001276")]
	[Address(RVA = "0x1D437E0", Offset = "0x1D437E0", VA = "0x1D437E0")]
	public SpringPanel()
	{
	}

	[Token(Token = "0x6001277")]
	[Address(RVA = "0x1D43828", Offset = "0x1D43828", VA = "0x1D43828")]
	private void Start()
	{
	}

	[Token(Token = "0x6001278")]
	[Address(RVA = "0x1D438DC", Offset = "0x1D438DC", VA = "0x1D438DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001279")]
	[Address(RVA = "0x1D43920", Offset = "0x1D43920", VA = "0x1D43920", Slot = "4")]
	protected virtual void AdvanceTowardsPosition()
	{
	}

	[Token(Token = "0x600127A")]
	[Address(RVA = "0x1D43CF8", Offset = "0x1D43CF8", VA = "0x1D43CF8")]
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}
}
