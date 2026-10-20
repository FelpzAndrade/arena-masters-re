using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000614")]
public class XGameFlow_Loading : XGameFlow
{
	[Token(Token = "0x2000615")]
	private sealed class _003COnEnd_003Ec__Iterator79 : IDisposable
	{
		[Token(Token = "0x4001D23")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001D24")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x170007B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600345F")]
			[Address(RVA = "0x13E46A4", Offset = "0x13E46A4", VA = "0x13E46A4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003460")]
			[Address(RVA = "0x13E46AC", Offset = "0x13E46AC", VA = "0x13E46AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600345E")]
		[Address(RVA = "0x13E469C", Offset = "0x13E469C", VA = "0x13E469C")]
		public _003COnEnd_003Ec__Iterator79()
		{
		}

		[Token(Token = "0x600345F")]
		[Address(RVA = "0x13E46A4", Offset = "0x13E46A4", VA = "0x13E46A4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003460")]
		[Address(RVA = "0x13E46AC", Offset = "0x13E46AC", VA = "0x13E46AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003461")]
		[Address(RVA = "0x13E46B4", Offset = "0x13E46B4", VA = "0x13E46B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003462")]
		[Address(RVA = "0x13E48D0", Offset = "0x13E48D0", VA = "0x13E48D0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003463")]
		[Address(RVA = "0x13E48DC", Offset = "0x13E48DC", VA = "0x13E48DC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001D22")]
	[FieldOffset(Offset = "0x8")]
	private bool complete;

	[Token(Token = "0x6003457")]
	[Address(RVA = "0x13E3CEC", Offset = "0x13E3CEC", VA = "0x13E3CEC")]
	public XGameFlow_Loading()
	{
	}

	[Token(Token = "0x6003458")]
	[Address(RVA = "0x13E3CF4", Offset = "0x13E3CF4", VA = "0x13E3CF4", Slot = "4")]
	public override GameFlowTypes GetFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x6003459")]
	[Address(RVA = "0x13E3CFC", Offset = "0x13E3CFC", VA = "0x13E3CFC", Slot = "5")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x600345A")]
	[Address(RVA = "0x13E3E3C", Offset = "0x13E3E3C", VA = "0x13E3E3C")]
	private void UnloadNGUIAtlas(GameFlowTypes prevType)
	{
	}

	[Token(Token = "0x600345B")]
	[Address(RVA = "0x13E3FB4", Offset = "0x13E3FB4", VA = "0x13E3FB4", Slot = "7")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600345C")]
	[Address(RVA = "0x13E4298", Offset = "0x13E4298", VA = "0x13E4298", Slot = "9")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x600345D")]
	[Address(RVA = "0x13E4610", Offset = "0x13E4610", VA = "0x13E4610", Slot = "6")]
	[DebuggerHidden]
	public override IEnumerator OnEnd()
	{
		return null;
	}
}
