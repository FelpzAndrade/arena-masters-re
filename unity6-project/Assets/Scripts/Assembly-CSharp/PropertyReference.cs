using System;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000223")]
public class PropertyReference
{
	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private Component mTarget;

	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private string mName;

	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x10")]
	private FieldInfo mField;

	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x14")]
	private PropertyInfo mProperty;

	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x0")]
	private static int s_Hash;

	[Token(Token = "0x170002AA")]
	public Component target
	{
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x20E5B48", Offset = "0x20E5B48", VA = "0x20E5B48")]
		get
		{
			return null;
		}
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x20E5B50", Offset = "0x20E5B50", VA = "0x20E5B50")]
		set
		{
		}
	}

	[Token(Token = "0x170002AB")]
	public string name
	{
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x20E5B64", Offset = "0x20E5B64", VA = "0x20E5B64")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x20E5B6C", Offset = "0x20E5B6C", VA = "0x20E5B6C")]
		set
		{
		}
	}

	[Token(Token = "0x170002AC")]
	public bool isValid
	{
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x20E513C", Offset = "0x20E513C", VA = "0x20E513C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002AD")]
	public bool isEnabled
	{
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x20E5B80", Offset = "0x20E5B80", VA = "0x20E5B80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600125B")]
	[Address(RVA = "0x20E5A60", Offset = "0x20E5A60", VA = "0x20E5A60")]
	public PropertyReference()
	{
	}

	[Token(Token = "0x600125C")]
	[Address(RVA = "0x20E5A68", Offset = "0x20E5A68", VA = "0x20E5A68")]
	public PropertyReference(Component target, string fieldName)
	{
	}

	[Token(Token = "0x6001264")]
	[Address(RVA = "0x20E58EC", Offset = "0x20E58EC", VA = "0x20E58EC")]
	public Type GetPropertyType()
	{
		return null;
	}

	[Token(Token = "0x6001265")]
	[Address(RVA = "0x20E5E9C", Offset = "0x20E5E9C", VA = "0x20E5E9C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001266")]
	[Address(RVA = "0x20E601C", Offset = "0x20E601C", VA = "0x20E601C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001267")]
	[Address(RVA = "0x20E60CC", Offset = "0x20E60CC", VA = "0x20E60CC")]
	public void Set(Component target, string methodName)
	{
	}

	[Token(Token = "0x6001268")]
	[Address(RVA = "0x20E60D8", Offset = "0x20E60D8", VA = "0x20E60D8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001269")]
	[Address(RVA = "0x20E5130", Offset = "0x20E5130", VA = "0x20E5130")]
	public void Reset()
	{
	}

	[Token(Token = "0x600126A")]
	[Address(RVA = "0x20E60E4", Offset = "0x20E60E4", VA = "0x20E60E4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600126B")]
	[Address(RVA = "0x20E6190", Offset = "0x20E6190", VA = "0x20E6190")]
	public static string ToString(Component comp, string property)
	{
		return null;
	}

	[Token(Token = "0x600126C")]
	[Address(RVA = "0x20E524C", Offset = "0x20E524C", VA = "0x20E524C")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public object Get()
	{
		return null;
	}

	[Token(Token = "0x600126D")]
	[Address(RVA = "0x20E5374", Offset = "0x20E5374", VA = "0x20E5374")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public bool Set(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600126E")]
	[Address(RVA = "0x20E5D0C", Offset = "0x20E5D0C", VA = "0x20E5D0C")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	private bool Cache()
	{
		return default(bool);
	}

	[Token(Token = "0x600126F")]
	[Address(RVA = "0x20E63FC", Offset = "0x20E63FC", VA = "0x20E63FC")]
	private bool Convert(ref object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001270")]
	[Address(RVA = "0x20E6BE8", Offset = "0x20E6BE8", VA = "0x20E6BE8")]
	public static bool Convert(Type from, Type to)
	{
		return default(bool);
	}

	[Token(Token = "0x6001271")]
	[Address(RVA = "0x20E6CA4", Offset = "0x20E6CA4", VA = "0x20E6CA4")]
	public static bool Convert(object value, Type to)
	{
		return default(bool);
	}

	[Token(Token = "0x6001272")]
	[Address(RVA = "0x20E656C", Offset = "0x20E656C", VA = "0x20E656C")]
	public static bool Convert(ref object value, Type from, Type to)
	{
		return default(bool);
	}
}
