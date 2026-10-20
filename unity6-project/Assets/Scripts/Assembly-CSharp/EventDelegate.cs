using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000212")]
public class EventDelegate
{
	[Serializable]
	[Token(Token = "0x2000213")]
	public class Parameter
	{
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x8")]
		public UnityEngine.Object obj;

		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0xC")]
		public string field;

		[NonSerialized]
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x10")]
		private object mValue;

		[NonSerialized]
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x14")]
		public Type expectedType;

		[NonSerialized]
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x18")]
		public bool cached;

		[NonSerialized]
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x1C")]
		public PropertyInfo propInfo;

		[NonSerialized]
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x20")]
		public FieldInfo fieldInfo;

		[Token(Token = "0x1700029F")]
		public object value
		{
			[Token(Token = "0x6001161")]
			[Address(RVA = "0x1E742AC", Offset = "0x1E742AC", VA = "0x1E742AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001162")]
			[Address(RVA = "0x1E74700", Offset = "0x1E74700", VA = "0x1E74700")]
			set
			{
			}
		}

		[Token(Token = "0x170002A0")]
		public Type type
		{
			[Token(Token = "0x6001163")]
			[Address(RVA = "0x1E745B8", Offset = "0x1E745B8", VA = "0x1E745B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600115E")]
		[Address(RVA = "0x1E7356C", Offset = "0x1E7356C", VA = "0x1E7356C")]
		public Parameter()
		{
		}

		[Token(Token = "0x600115F")]
		[Address(RVA = "0x1E75A44", Offset = "0x1E75A44", VA = "0x1E75A44")]
		public Parameter(UnityEngine.Object obj, string field)
		{
		}

		[Token(Token = "0x6001160")]
		[Address(RVA = "0x1E75B24", Offset = "0x1E75B24", VA = "0x1E75B24")]
		public Parameter(object val)
		{
		}
	}

	[Token(Token = "0x2000214")]
	public delegate void Callback();

	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private MonoBehaviour mTarget;

	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private string mMethodName;

	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Parameter[] mParameters;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x14")]
	public bool oneShot;

	[NonSerialized]
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x18")]
	private Callback mCachedCallback;

	[NonSerialized]
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x1C")]
	private bool mRawDelegate;

	[NonSerialized]
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x1D")]
	private bool mCached;

	[NonSerialized]
	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x20")]
	private MethodInfo mMethod;

	[NonSerialized]
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x24")]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x28")]
	private object[] mArgs;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x0")]
	private static int s_Hash;

	[Token(Token = "0x1700029A")]
	public MonoBehaviour target
	{
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x1E72194", Offset = "0x1E72194", VA = "0x1E72194")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x1E7219C", Offset = "0x1E7219C", VA = "0x1E7219C")]
		set
		{
		}
	}

	[Token(Token = "0x1700029B")]
	public string methodName
	{
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x1E721C0", Offset = "0x1E721C0", VA = "0x1E721C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x1E721C8", Offset = "0x1E721C8", VA = "0x1E721C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700029C")]
	public Parameter[] parameters
	{
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x1E721EC", Offset = "0x1E721EC", VA = "0x1E721EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029D")]
	public bool isValid
	{
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x1E72E78", Offset = "0x1E72E78", VA = "0x1E72E78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700029E")]
	public bool isEnabled
	{
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x1E72FB8", Offset = "0x1E72FB8", VA = "0x1E72FB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600113F")]
	[Address(RVA = "0x1E71E44", Offset = "0x1E71E44", VA = "0x1E71E44")]
	public EventDelegate()
	{
	}

	[Token(Token = "0x6001140")]
	[Address(RVA = "0x1E71E4C", Offset = "0x1E71E4C", VA = "0x1E71E4C")]
	public EventDelegate(Callback call)
	{
	}

	[Token(Token = "0x6001141")]
	[Address(RVA = "0x1E72068", Offset = "0x1E72068", VA = "0x1E72068")]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[Token(Token = "0x600114A")]
	[Address(RVA = "0x1E73120", Offset = "0x1E73120", VA = "0x1E73120")]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[Token(Token = "0x600114B")]
	[Address(RVA = "0x1E7318C", Offset = "0x1E7318C", VA = "0x1E7318C")]
	private static bool IsValid(Callback callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600114C")]
	[Address(RVA = "0x1E731B8", Offset = "0x1E731B8", VA = "0x1E731B8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600114D")]
	[Address(RVA = "0x1E73490", Offset = "0x1E73490", VA = "0x1E73490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600114E")]
	[Address(RVA = "0x1E71E74", Offset = "0x1E71E74", VA = "0x1E71E74")]
	private void Set(Callback call)
	{
	}

	[Token(Token = "0x600114F")]
	[Address(RVA = "0x1E720B0", Offset = "0x1E720B0", VA = "0x1E720B0")]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[Token(Token = "0x6001150")]
	[Address(RVA = "0x1E72214", Offset = "0x1E72214", VA = "0x1E72214")]
	private void Cache()
	{
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0x1E7363C", Offset = "0x1E7363C", VA = "0x1E7363C")]
	public bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0x1E73540", Offset = "0x1E73540", VA = "0x1E73540")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001153")]
	[Address(RVA = "0x1E74708", Offset = "0x1E74708", VA = "0x1E74708", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001154")]
	[Address(RVA = "0x1E749A8", Offset = "0x1E749A8", VA = "0x1E749A8")]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[Token(Token = "0x6001155")]
	[Address(RVA = "0x1E74CF8", Offset = "0x1E74CF8", VA = "0x1E74CF8")]
	public static bool IsValid(List<EventDelegate> list)
	{
		return default(bool);
	}

	[Token(Token = "0x6001156")]
	[Address(RVA = "0x1E74DEC", Offset = "0x1E74DEC", VA = "0x1E74DEC")]
	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6001157")]
	[Address(RVA = "0x1E74ECC", Offset = "0x1E74ECC", VA = "0x1E74ECC")]
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	[Token(Token = "0x6001158")]
	[Address(RVA = "0x1E74F78", Offset = "0x1E74F78", VA = "0x1E74F78")]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6001159")]
	[Address(RVA = "0x1E7502C", Offset = "0x1E7502C", VA = "0x1E7502C")]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		return null;
	}

	[Token(Token = "0x600115A")]
	[Address(RVA = "0x1E7523C", Offset = "0x1E7523C", VA = "0x1E7523C")]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[Token(Token = "0x600115B")]
	[Address(RVA = "0x1E75310", Offset = "0x1E75310", VA = "0x1E75310")]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[Token(Token = "0x600115C")]
	[Address(RVA = "0x1E7573C", Offset = "0x1E7573C", VA = "0x1E7573C")]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600115D")]
	[Address(RVA = "0x1E75894", Offset = "0x1E75894", VA = "0x1E75894")]
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return default(bool);
	}
}
