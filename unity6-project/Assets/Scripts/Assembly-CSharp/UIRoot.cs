using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000288")]
[ExecuteInEditMode]
public class UIRoot : MonoBehaviour
{
	[Token(Token = "0x2000289")]
	public enum Scaling
	{
		[Token(Token = "0x4000C03")]
		Flexible = 0,
		[Token(Token = "0x4000C04")]
		Constrained = 1,
		[Token(Token = "0x4000C05")]
		ConstrainedOnMobiles = 2
	}

	[Token(Token = "0x200028A")]
	public enum Constraint
	{
		[Token(Token = "0x4000C07")]
		Fit = 0,
		[Token(Token = "0x4000C08")]
		Fill = 1,
		[Token(Token = "0x4000C09")]
		FitWidth = 2,
		[Token(Token = "0x4000C0A")]
		FitHeight = 3
	}

	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x0")]
	public static List<UIRoot> list;

	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0xC")]
	public Scaling scalingStyle;

	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x10")]
	public int manualWidth;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x14")]
	public int manualHeight;

	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x18")]
	public int minimumHeight;

	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x1C")]
	public int maximumHeight;

	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x20")]
	public bool fitWidth;

	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x21")]
	public bool fitHeight;

	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x22")]
	public bool adjustByDPI;

	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x23")]
	public bool shrinkPortraitUI;

	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x24")]
	private Transform mTrans;

	[Token(Token = "0x170003A8")]
	public Constraint constraint
	{
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x1792B3C", Offset = "0x1792B3C", VA = "0x1792B3C")]
		get
		{
			return default(Constraint);
		}
	}

	[Token(Token = "0x170003A9")]
	public Scaling activeScaling
	{
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x1792B6C", Offset = "0x1792B6C", VA = "0x1792B6C")]
		get
		{
			return default(Scaling);
		}
	}

	[Token(Token = "0x170003AA")]
	public int activeHeight
	{
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x1792B7C", Offset = "0x1792B7C", VA = "0x1792B7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003AB")]
	public float pixelSizeAdjustment
	{
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x1778290", Offset = "0x1778290", VA = "0x1778290")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600163D")]
	[Address(RVA = "0x1792A5C", Offset = "0x1792A5C", VA = "0x1792A5C")]
	public UIRoot()
	{
	}

	[Token(Token = "0x6001643")]
	[Address(RVA = "0x1792E58", Offset = "0x1792E58", VA = "0x1792E58")]
	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return default(float);
	}

	[Token(Token = "0x6001644")]
	[Address(RVA = "0x1782D00", Offset = "0x1782D00", VA = "0x1782D00")]
	public float GetPixelSizeAdjustment(int height)
	{
		return default(float);
	}

	[Token(Token = "0x6001645")]
	[Address(RVA = "0x1792F88", Offset = "0x1792F88", VA = "0x1792F88", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6001646")]
	[Address(RVA = "0x1792FA4", Offset = "0x1792FA4", VA = "0x1792FA4", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6001647")]
	[Address(RVA = "0x1793090", Offset = "0x1793090", VA = "0x1793090", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6001648")]
	[Address(RVA = "0x179317C", Offset = "0x179317C", VA = "0x179317C", Slot = "7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6001649")]
	[Address(RVA = "0x17935E4", Offset = "0x17935E4", VA = "0x17935E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600164A")]
	[Address(RVA = "0x1793374", Offset = "0x1793374", VA = "0x1793374")]
	public void UpdateScale(bool updateAnchors = true)
	{
	}

	[Token(Token = "0x600164B")]
	[Address(RVA = "0x17935EC", Offset = "0x17935EC", VA = "0x17935EC")]
	public static void Broadcast(string funcName)
	{
	}

	[Token(Token = "0x600164C")]
	[Address(RVA = "0x17937E0", Offset = "0x17937E0", VA = "0x17937E0")]
	public static void Broadcast(string funcName, object param)
	{
	}
}
