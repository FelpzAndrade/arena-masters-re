using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000BD8")]
public class ToyRequestPool
{
	[Token(Token = "0x2000BD9")]
	private sealed class _003CNextExecute_003Ec__Iterator91 : IDisposable
	{
		[Token(Token = "0x4003C24")]
		[FieldOffset(Offset = "0x8")]
		internal ToyCommand _003Ccmd_003E__0;

		[Token(Token = "0x4003C25")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4003C26")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4003C27")]
		[FieldOffset(Offset = "0x14")]
		internal ToyRequestPool _003C_003Ef__this;

		[Token(Token = "0x17000C8B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60055BD")]
			[Address(RVA = "0x1D576B0", Offset = "0x1D576B0", VA = "0x1D576B0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000C8C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60055BE")]
			[Address(RVA = "0x1D576B8", Offset = "0x1D576B8", VA = "0x1D576B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60055BC")]
		[Address(RVA = "0x1D575AC", Offset = "0x1D575AC", VA = "0x1D575AC")]
		public _003CNextExecute_003Ec__Iterator91()
		{
		}

		[Token(Token = "0x60055BD")]
		[Address(RVA = "0x1D576B0", Offset = "0x1D576B0", VA = "0x1D576B0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60055BE")]
		[Address(RVA = "0x1D576B8", Offset = "0x1D576B8", VA = "0x1D576B8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60055BF")]
		[Address(RVA = "0x1D576C0", Offset = "0x1D576C0", VA = "0x1D576C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60055C0")]
		[Address(RVA = "0x1D5787C", Offset = "0x1D5787C", VA = "0x1D5787C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60055C1")]
		[Address(RVA = "0x1D57888", Offset = "0x1D57888", VA = "0x1D57888", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003C21")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly ToyRequestPool Instance;

	[Token(Token = "0x4003C22")]
	[FieldOffset(Offset = "0x8")]
	private Queue<ToyCommand> Commands;

	[Token(Token = "0x4003C23")]
	[FieldOffset(Offset = "0xC")]
	private bool IsRunning__BackingField;

	[Token(Token = "0x17000C8A")]
	private bool IsRunning
	{
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x1D57498", Offset = "0x1D57498", VA = "0x1D57498")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055B6")]
		[Address(RVA = "0x1D574A0", Offset = "0x1D574A0", VA = "0x1D574A0")]
		set
		{
		}
	}

	[Token(Token = "0x60055B3")]
	[Address(RVA = "0x1D5735C", Offset = "0x1D5735C", VA = "0x1D5735C")]
	public ToyRequestPool()
	{
	}

	[Token(Token = "0x60055B7")]
	[Address(RVA = "0x1D54C60", Offset = "0x1D54C60", VA = "0x1D54C60")]
	public void Execute(ToyCommand cmd)
	{
	}

	[Token(Token = "0x60055B8")]
	[Address(RVA = "0x1D574A8", Offset = "0x1D574A8", VA = "0x1D574A8")]
	private void NextExecuteByCoroutine()
	{
	}

	[Token(Token = "0x60055B9")]
	[Address(RVA = "0x1D57508", Offset = "0x1D57508", VA = "0x1D57508")]
	[DebuggerHidden]
	private IEnumerator NextExecute()
	{
		return null;
	}

	[Token(Token = "0x60055BA")]
	[Address(RVA = "0x1D575B4", Offset = "0x1D575B4", VA = "0x1D575B4")]
	private void NPStateDidDone()
	{
	}

	[Token(Token = "0x60055BB")]
	[Address(RVA = "0x1D575C0", Offset = "0x1D575C0", VA = "0x1D575C0")]
	private bool CanExecute()
	{
		return default(bool);
	}
}
