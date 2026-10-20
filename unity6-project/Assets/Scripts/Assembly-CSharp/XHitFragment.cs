using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000411")]
public class XHitFragment : MonoBehaviour
{
	[Token(Token = "0x2000412")]
	private sealed class _003CStartExplode_003Ec__Iterator35 : IDisposable
	{
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003Cpos_003E__0;

		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0x14")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x18")]
		internal Rigidbody _003Ceach_003E__2;

		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x1C")]
		internal float forceMultiflier;

		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x28")]
		internal float _003C_0024_003EforceMultiflier;

		[Token(Token = "0x4001433")]
		[FieldOffset(Offset = "0x2C")]
		internal XHitFragment _003C_003Ef__this;

		[Token(Token = "0x1700058E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x1D22E54", Offset = "0x1D22E54", VA = "0x1D22E54", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700058F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002138")]
			[Address(RVA = "0x1D22E5C", Offset = "0x1D22E5C", VA = "0x1D22E5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002136")]
		[Address(RVA = "0x1D22E44", Offset = "0x1D22E44", VA = "0x1D22E44")]
		public _003CStartExplode_003Ec__Iterator35()
		{
		}

		[Token(Token = "0x6002137")]
		[Address(RVA = "0x1D22E54", Offset = "0x1D22E54", VA = "0x1D22E54", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002138")]
		[Address(RVA = "0x1D22E5C", Offset = "0x1D22E5C", VA = "0x1D22E5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002139")]
		[Address(RVA = "0x1D22E64", Offset = "0x1D22E64", VA = "0x1D22E64", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600213A")]
		[Address(RVA = "0x1D2313C", Offset = "0x1D2313C", VA = "0x1D2313C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600213B")]
		[Address(RVA = "0x1D23148", Offset = "0x1D23148", VA = "0x1D23148", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001424")]
	[FieldOffset(Offset = "0xC")]
	private Rigidbody[] m_rgbs;

	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0x10")]
	private Collider[] m_cols;

	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x14")]
	private Vector3[] m_initPos;

	[Token(Token = "0x4001427")]
	[FieldOffset(Offset = "0x18")]
	private Quaternion[] m_initRot;

	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x1C")]
	private MeshRenderer[] m_meshes;

	[Token(Token = "0x4001429")]
	[FieldOffset(Offset = "0x20")]
	private Transform explosionPos;

	[Token(Token = "0x400142A")]
	[FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x400142B")]
	[FieldOffset(Offset = "0x28")]
	public float lifeTime;

	[Token(Token = "0x600212F")]
	[Address(RVA = "0x1D227AC", Offset = "0x1D227AC", VA = "0x1D227AC")]
	public XHitFragment()
	{
	}

	[Token(Token = "0x6002130")]
	[Address(RVA = "0x1D227C8", Offset = "0x1D227C8", VA = "0x1D227C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002131")]
	[Address(RVA = "0x1D22A7C", Offset = "0x1D22A7C", VA = "0x1D22A7C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002132")]
	[Address(RVA = "0x1D22D6C", Offset = "0x1D22D6C", VA = "0x1D22D6C")]
	public void Explode(float forceMultiflier = 1f)
	{
	}

	[Token(Token = "0x6002133")]
	[Address(RVA = "0x1D22D90", Offset = "0x1D22D90", VA = "0x1D22D90")]
	[DebuggerHidden]
	private IEnumerator StartExplode(float forceMultiflier)
	{
		return null;
	}

	[Token(Token = "0x6002134")]
	[Address(RVA = "0x1D22E4C", Offset = "0x1D22E4C", VA = "0x1D22E4C")]
	public void Use()
	{
	}

	[Token(Token = "0x6002135")]
	[Address(RVA = "0x1D22E50", Offset = "0x1D22E50", VA = "0x1D22E50")]
	public void Grab()
	{
	}
}
