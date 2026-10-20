using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EC")]
[ExecuteInEditMode]
public class UIProgressBar : UIWidgetContainer
{
	[Token(Token = "0x20001ED")]
	public enum FillDirection
	{
		[Token(Token = "0x40007ED")]
		LeftToRight = 0,
		[Token(Token = "0x40007EE")]
		RightToLeft = 1,
		[Token(Token = "0x40007EF")]
		BottomToTop = 2,
		[Token(Token = "0x40007F0")]
		TopToBottom = 3
	}

	[Token(Token = "0x20001EE")]
	public delegate void OnDragFinished();

	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x0")]
	public static UIProgressBar current;

	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0xC")]
	public OnDragFinished onDragFinished;

	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x10")]
	public Transform thumb;

	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	[SerializeField]
	protected UIWidget mBG;

	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	protected UIWidget mFG;

	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[SerializeField]
	protected float mValue;

	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	protected FillDirection mFill;

	[NonSerialized]
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x24")]
	protected bool mStarted;

	[NonSerialized]
	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0x28")]
	protected Transform mTrans;

	[NonSerialized]
	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x2C")]
	protected bool mIsDirty;

	[NonSerialized]
	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0x30")]
	protected Camera mCam;

	[NonSerialized]
	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0x34")]
	protected float mOffset;

	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x38")]
	public int numberOfSteps;

	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x3C")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x17000269")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x178E5A8", Offset = "0x178E5A8", VA = "0x178E5A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026A")]
	public Camera cachedCamera
	{
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x178E678", Offset = "0x178E678", VA = "0x178E678")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026B")]
	public UIWidget foregroundWidget
	{
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x178E7B0", Offset = "0x178E7B0", VA = "0x178E7B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x178E7B8", Offset = "0x178E7B8", VA = "0x178E7B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700026C")]
	public UIWidget backgroundWidget
	{
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x178E87C", Offset = "0x178E87C", VA = "0x178E87C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x178E884", Offset = "0x178E884", VA = "0x178E884")]
		set
		{
		}
	}

	[Token(Token = "0x1700026D")]
	public FillDirection fillDirection
	{
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x178E948", Offset = "0x178E948", VA = "0x178E948")]
		get
		{
			return default(FillDirection);
		}
		[Token(Token = "0x6001057")]
		[Address(RVA = "0x178E950", Offset = "0x178E950", VA = "0x178E950")]
		set
		{
		}
	}

	[Token(Token = "0x1700026E")]
	public float value
	{
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x178E9B4", Offset = "0x178E9B4", VA = "0x178E9B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x178EB3C", Offset = "0x178EB3C", VA = "0x178EB3C")]
		set
		{
		}
	}

	[Token(Token = "0x1700026F")]
	public float alpha
	{
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x178ED98", Offset = "0x178ED98", VA = "0x178ED98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x178EEFC", Offset = "0x178EEFC", VA = "0x178EEFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000270")]
	protected bool isHorizontal
	{
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x178F73C", Offset = "0x178F73C", VA = "0x178F73C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000271")]
	protected bool isInverted
	{
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x178F750", Offset = "0x178F750", VA = "0x178F750")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600104F")]
	[Address(RVA = "0x178E4F4", Offset = "0x178E4F4", VA = "0x178E4F4")]
	public UIProgressBar()
	{
	}

	[Token(Token = "0x600105E")]
	[Address(RVA = "0x178EB44", Offset = "0x178EB44", VA = "0x178EB44")]
	public void Set(float val, bool notify = true)
	{
	}

	[Token(Token = "0x600105F")]
	[Address(RVA = "0x178F764", Offset = "0x178F764", VA = "0x178F764")]
	public void Start()
	{
	}

	[Token(Token = "0x6001060")]
	[Address(RVA = "0x178F9DC", Offset = "0x178F9DC", VA = "0x178F9DC", Slot = "4")]
	protected virtual void Upgrade()
	{
	}

	[Token(Token = "0x6001061")]
	[Address(RVA = "0x178F9E0", Offset = "0x178F9E0", VA = "0x178F9E0", Slot = "5")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x6001062")]
	[Address(RVA = "0x178F9E4", Offset = "0x178F9E4", VA = "0x178F9E4")]
	protected void Update()
	{
	}

	[Token(Token = "0x6001063")]
	[Address(RVA = "0x178FA34", Offset = "0x178FA34", VA = "0x178FA34")]
	protected void OnValidate()
	{
	}

	[Token(Token = "0x6001064")]
	[Address(RVA = "0x178FC60", Offset = "0x178FC60", VA = "0x178FC60")]
	protected float ScreenToValue(Vector2 screenPos)
	{
		return default(float);
	}

	[Token(Token = "0x6001065")]
	[Address(RVA = "0x178FE88", Offset = "0x178FE88", VA = "0x178FE88", Slot = "6")]
	protected virtual float LocalToValue(Vector2 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x6001066")]
	[Address(RVA = "0x1790088", Offset = "0x1790088", VA = "0x1790088", Slot = "7")]
	public virtual void ForceUpdate()
	{
	}

	[Token(Token = "0x6001067")]
	[Address(RVA = "0x1790D00", Offset = "0x1790D00", VA = "0x1790D00")]
	protected void SetThumbPosition(Vector3 worldPos)
	{
	}

	[Token(Token = "0x6001068")]
	[Address(RVA = "0x17910A0", Offset = "0x17910A0", VA = "0x17910A0", Slot = "8")]
	public virtual void OnPan(Vector2 delta)
	{
	}
}
