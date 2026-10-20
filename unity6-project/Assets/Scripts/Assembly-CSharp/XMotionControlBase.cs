using System;
using CS;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000495")]
public abstract class XMotionControlBase : IDisposable, CSPoolEntry
{
	[Token(Token = "0x4001706")]
	[FieldOffset(Offset = "0x8")]
	protected XModuleEntity me;

	[Token(Token = "0x4001707")]
	[FieldOffset(Offset = "0xC")]
	protected MotionControlDirection directionType;

	[Token(Token = "0x4001708")]
	[FieldOffset(Offset = "0x10")]
	protected Sequence m_doTweenSeq;

	[Token(Token = "0x4001709")]
	[FieldOffset(Offset = "0x14")]
	private float ElapsedTime__BackingField;

	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x18")]
	private float TotalTime__BackingField;

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 SourcePosition__BackingField;

	[Token(Token = "0x400170C")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 Direction__BackingField;

	[Token(Token = "0x400170D")]
	[FieldOffset(Offset = "0x34")]
	private float Distance__BackingField;

	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x38")]
	private float Distance2__BackingField;

	[Token(Token = "0x1700063A")]
	public float ElapsedTime
	{
		[Token(Token = "0x6002770")]
		[Address(RVA = "0xB9B310", Offset = "0xB9B310", VA = "0xB9B310")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6002771")]
		[Address(RVA = "0xB9DDFC", Offset = "0xB9DDFC", VA = "0xB9DDFC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063B")]
	public float TotalTime
	{
		[Token(Token = "0x6002772")]
		[Address(RVA = "0xB4CADC", Offset = "0xB4CADC", VA = "0xB4CADC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6002773")]
		[Address(RVA = "0xB9C050", Offset = "0xB9C050", VA = "0xB9C050")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063C")]
	public Vector3 SourcePosition
	{
		[Token(Token = "0x6002774")]
		[Address(RVA = "0xB9CD08", Offset = "0xB9CD08", VA = "0xB9CD08")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6002775")]
		[Address(RVA = "0xB9DE04", Offset = "0xB9DE04", VA = "0xB9DE04")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063D")]
	public Vector3 Direction
	{
		[Token(Token = "0x6002776")]
		[Address(RVA = "0xB9ABB8", Offset = "0xB9ABB8", VA = "0xB9ABB8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6002777")]
		[Address(RVA = "0xB9ABCC", Offset = "0xB9ABCC", VA = "0xB9ABCC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063E")]
	public float Distance
	{
		[Token(Token = "0x6002778")]
		[Address(RVA = "0xB9B170", Offset = "0xB9B170", VA = "0xB9B170")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6002779")]
		[Address(RVA = "0xB9DE10", Offset = "0xB9DE10", VA = "0xB9DE10")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063F")]
	public float Distance2
	{
		[Token(Token = "0x600277A")]
		[Address(RVA = "0xB9C28C", Offset = "0xB9C28C", VA = "0xB9C28C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600277B")]
		[Address(RVA = "0xB9DE18", Offset = "0xB9DE18", VA = "0xB9DE18")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000640")]
	public abstract string AnimationName
	{
		[Token(Token = "0x600277C")]
		get;
	}

	[Token(Token = "0x17000641")]
	public virtual float? AnimationLenthModifier
	{
		[Token(Token = "0x600277D")]
		[Address(RVA = "0xB9DE20", Offset = "0xB9DE20", VA = "0xB9DE20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000642")]
	public virtual float AnimationStartFadeTime
	{
		[Token(Token = "0x600277E")]
		[Address(RVA = "0xB9DEE0", Offset = "0xB9DEE0", VA = "0xB9DEE0", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000643")]
	public virtual float AnimationEndFadeTime
	{
		[Token(Token = "0x600277F")]
		[Address(RVA = "0xB9DEEC", Offset = "0xB9DEEC", VA = "0xB9DEEC", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000644")]
	public abstract MotionControlType Type
	{
		[Token(Token = "0x6002780")]
		get;
	}

	[Token(Token = "0x600276F")]
	[Address(RVA = "0xB9A748", Offset = "0xB9A748", VA = "0xB9A748")]
	protected XMotionControlBase()
	{
	}

	[Token(Token = "0x6002781")]
	[Address(RVA = "0xB33CC4", Offset = "0xB33CC4", VA = "0xB33CC4")]
	public bool IsExpired()
	{
		return default(bool);
	}

	[Token(Token = "0x6002782")]
	[Address(RVA = "0xB9DEF8", Offset = "0xB9DEF8", VA = "0xB9DEF8", Slot = "11")]
	public virtual void Start(XModuleEntity me, float totalTime, Vector3 pos, Vector3 dir, float distance, float distance2, MotionControlDirection directionType)
	{
	}

	[Token(Token = "0x6002783")]
	[Address(RVA = "0xB9B2D0", Offset = "0xB9B2D0", VA = "0xB9B2D0", Slot = "12")]
	public virtual bool Update(float timeDelta)
	{
		return default(bool);
	}

	[Token(Token = "0x6002784")]
	[Address(RVA = "0xB9AAF8", Offset = "0xB9AAF8", VA = "0xB9AAF8", Slot = "13")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x6002785")]
	[Address(RVA = "0xB9ACA0", Offset = "0xB9ACA0", VA = "0xB9ACA0", Slot = "14")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0xB9DFD4", Offset = "0xB9DFD4", VA = "0xB9DFD4")]
	private bool IsMoveMotionType(MotionControlType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6002787")]
	[Address(RVA = "0xB9E034", Offset = "0xB9E034", VA = "0xB9E034", Slot = "15")]
	public virtual void StopDoTween()
	{
	}

	[Token(Token = "0x6002788")]
	[Address(RVA = "0xB332F4", Offset = "0xB332F4", VA = "0xB332F4")]
	public static XMotionControlBase NewMotionControl(MotionControlType type)
	{
		return null;
	}

	[Token(Token = "0x6002789")]
	[Address(RVA = "0xB9E050", Offset = "0xB9E050", VA = "0xB9E050", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600278A")]
	[Address(RVA = "0xB9E094", Offset = "0xB9E094", VA = "0xB9E094", Slot = "5")]
	public void OnCleanupInObjectPool()
	{
	}

	[Token(Token = "0x600278B")]
	[Address(RVA = "0xB9E0D8", Offset = "0xB9E0D8", VA = "0xB9E0D8", Slot = "16")]
	protected virtual void Clear()
	{
	}
}
