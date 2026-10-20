using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073A")]
public class XLevelBreakableObject : XLevelObjectEventReciever
{
	[Token(Token = "0x200073B")]
	private sealed class _003CFlash_003Ec__Iterator83 : IDisposable
	{
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x10")]
		internal XLevelBreakableObject _003C_003Ef__this;

		[Token(Token = "0x17000830")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003B39")]
			[Address(RVA = "0x2035A24", Offset = "0x2035A24", VA = "0x2035A24", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000831")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B3A")]
			[Address(RVA = "0x2035A2C", Offset = "0x2035A2C", VA = "0x2035A2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x2035510", Offset = "0x2035510", VA = "0x2035510")]
		public _003CFlash_003Ec__Iterator83()
		{
		}

		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x2035A24", Offset = "0x2035A24", VA = "0x2035A24", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x2035A2C", Offset = "0x2035A2C", VA = "0x2035A2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x2035A34", Offset = "0x2035A34", VA = "0x2035A34", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x2035B68", Offset = "0x2035B68", VA = "0x2035B68", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x2035B74", Offset = "0x2035B74", VA = "0x2035B74", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400222A")]
	[FieldOffset(Offset = "0xC")]
	public bool inited;

	[Token(Token = "0x400222B")]
	[FieldOffset(Offset = "0x10")]
	public int _ColorHashKey;

	[Token(Token = "0x400222C")]
	[FieldOffset(Offset = "0x14")]
	public float minForce;

	[Token(Token = "0x400222D")]
	[FieldOffset(Offset = "0x18")]
	public float maxForce;

	[Token(Token = "0x400222E")]
	[FieldOffset(Offset = "0x1C")]
	public Rigidbody[] m_rgbs;

	[Token(Token = "0x400222F")]
	[FieldOffset(Offset = "0x20")]
	public Collider[] m_cols;

	[Token(Token = "0x4002230")]
	[FieldOffset(Offset = "0x24")]
	public Vector3[] m_initPos;

	[Token(Token = "0x4002231")]
	[FieldOffset(Offset = "0x28")]
	public Quaternion[] m_initRot;

	[Token(Token = "0x4002232")]
	[FieldOffset(Offset = "0x2C")]
	public MeshRenderer[] m_meshes;

	[Token(Token = "0x4002233")]
	[FieldOffset(Offset = "0x30")]
	public Color m_defaultColor;

	[Token(Token = "0x6003B2F")]
	[Address(RVA = "0x20348AC", Offset = "0x20348AC", VA = "0x20348AC")]
	public XLevelBreakableObject()
	{
	}

	[Token(Token = "0x6003B30")]
	[Address(RVA = "0x20348D4", Offset = "0x20348D4", VA = "0x20348D4", Slot = "4")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6003B31")]
	[Address(RVA = "0x2034F78", Offset = "0x2034F78", VA = "0x2034F78", Slot = "5")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6003B32")]
	[Address(RVA = "0x2035444", Offset = "0x2035444", VA = "0x2035444", Slot = "6")]
	public override void OnDespawn(XModuleLevelObject lvo)
	{
	}

	[Token(Token = "0x6003B33")]
	[Address(RVA = "0x2035448", Offset = "0x2035448", VA = "0x2035448", Slot = "7")]
	public override void OnHitMe(XModuleLevelObject lvo, ModuleEventArgument_Hit hit)
	{
	}

	[Token(Token = "0x6003B34")]
	[Address(RVA = "0x203546C", Offset = "0x203546C", VA = "0x203546C")]
	[DebuggerHidden]
	private IEnumerator Flash()
	{
		return null;
	}

	[Token(Token = "0x6003B35")]
	[Address(RVA = "0x203534C", Offset = "0x203534C", VA = "0x203534C")]
	private void ChangeMeshColor(Color color)
	{
	}

	[Token(Token = "0x6003B36")]
	[Address(RVA = "0x2034EE4", Offset = "0x2034EE4", VA = "0x2034EE4")]
	private Color GetMeshColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6003B37")]
	[Address(RVA = "0x2035518", Offset = "0x2035518", VA = "0x2035518", Slot = "8")]
	public override void OnDie(XModuleLevelObject lvo, ModuleEventArgument_Hit hit)
	{
	}
}
