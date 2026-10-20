using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XLevel;

[Token(Token = "0x20005B6")]
public class XMissionState_GetReady : XMissionState
{
	[Token(Token = "0x20005B7")]
	private sealed class _003CShowPanelDelayed_003Ec__Iterator63 : IDisposable
	{
		[Token(Token = "0x4001B9D")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001B9F")]
		[FieldOffset(Offset = "0x10")]
		internal XMissionState_GetReady _003C_003Ef__this;

		[Token(Token = "0x1700076B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60030D3")]
			[Address(RVA = "0xB328E8", Offset = "0xB328E8", VA = "0xB328E8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700076C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030D4")]
			[Address(RVA = "0xB328F0", Offset = "0xB328F0", VA = "0xB328F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60030D2")]
		[Address(RVA = "0xB31E7C", Offset = "0xB31E7C", VA = "0xB31E7C")]
		public _003CShowPanelDelayed_003Ec__Iterator63()
		{
		}

		[Token(Token = "0x60030D3")]
		[Address(RVA = "0xB328E8", Offset = "0xB328E8", VA = "0xB328E8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60030D4")]
		[Address(RVA = "0xB328F0", Offset = "0xB328F0", VA = "0xB328F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60030D5")]
		[Address(RVA = "0xB328F8", Offset = "0xB328F8", VA = "0xB328F8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60030D6")]
		[Address(RVA = "0xB32A30", Offset = "0xB32A30", VA = "0xB32A30", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60030D7")]
		[Address(RVA = "0xB32A3C", Offset = "0xB32A3C", VA = "0xB32A3C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001B99")]
	[FieldOffset(Offset = "0x18")]
	private XLevelLoader m_levelLoader;

	[Token(Token = "0x4001B9A")]
	[FieldOffset(Offset = "0x1C")]
	private XModuleMyControl m_player;

	[Token(Token = "0x4001B9B")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_startPos;

	[Token(Token = "0x4001B9C")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_endArea;

	[Token(Token = "0x60030C8")]
	[Address(RVA = "0xB31388", Offset = "0xB31388", VA = "0xB31388")]
	public XMissionState_GetReady()
	{
	}

	[Token(Token = "0x60030C9")]
	[Address(RVA = "0xB31390", Offset = "0xB31390", VA = "0xB31390", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60030CA")]
	[Address(RVA = "0xB31BCC", Offset = "0xB31BCC", VA = "0xB31BCC")]
	private void HoldCamera(Vector3 pos)
	{
	}

	[Token(Token = "0x60030CB")]
	[Address(RVA = "0xB31B28", Offset = "0xB31B28", VA = "0xB31B28")]
	[DebuggerHidden]
	private IEnumerator ShowPanelDelayed()
	{
		return null;
	}

	[Token(Token = "0x60030CC")]
	[Address(RVA = "0xB31E84", Offset = "0xB31E84", VA = "0xB31E84")]
	private void ShowPanel()
	{
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0xB32054", Offset = "0xB32054", VA = "0xB32054", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0xB32738", Offset = "0xB32738", VA = "0xB32738", Slot = "8")]
	public override void FixedUpdate()
	{
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0xB32784", Offset = "0xB32784", VA = "0xB32784", Slot = "19")]
	protected override XGameModeState GetState(MissionPlayPattern type)
	{
		return null;
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0xB328D0", Offset = "0xB328D0", VA = "0xB328D0")]
	private void _003CEnter_003Em__12F()
	{
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0xB328DC", Offset = "0xB328DC", VA = "0xB328DC")]
	private void _003CEnter_003Em__130()
	{
	}
}
