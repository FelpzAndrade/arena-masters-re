using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000BEA")]
public class XIntegrityManager
{
	[Token(Token = "0x2000BEB")]
	private sealed class _003CGetClassesDex_003Ec__Iterator92 : IDisposable
	{
		[Token(Token = "0x4003C48")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4003C49")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000C95")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005619")]
			[Address(RVA = "0x1D2ED10", Offset = "0x1D2ED10", VA = "0x1D2ED10", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000C96")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600561A")]
			[Address(RVA = "0x1D2ED18", Offset = "0x1D2ED18", VA = "0x1D2ED18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6005618")]
		[Address(RVA = "0x1D2ED08", Offset = "0x1D2ED08", VA = "0x1D2ED08")]
		public _003CGetClassesDex_003Ec__Iterator92()
		{
		}

		[Token(Token = "0x6005619")]
		[Address(RVA = "0x1D2ED10", Offset = "0x1D2ED10", VA = "0x1D2ED10", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600561A")]
		[Address(RVA = "0x1D2ED18", Offset = "0x1D2ED18", VA = "0x1D2ED18", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600561B")]
		[Address(RVA = "0x1D2ED20", Offset = "0x1D2ED20", VA = "0x1D2ED20", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x1D2ED30", Offset = "0x1D2ED30", VA = "0x1D2ED30", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600561D")]
		[Address(RVA = "0x1D2ED3C", Offset = "0x1D2ED3C", VA = "0x1D2ED3C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003C45")]
	[FieldOffset(Offset = "0x8")]
	private string dexFileHash;

	[Token(Token = "0x4003C46")]
	[FieldOffset(Offset = "0xC")]
	private List<string> soFileHashList;

	[Token(Token = "0x4003C47")]
	[FieldOffset(Offset = "0x10")]
	private bool isReadyToHashKey;

	[Token(Token = "0x6005612")]
	[Address(RVA = "0x1D2E8BC", Offset = "0x1D2E8BC", VA = "0x1D2E8BC")]
	public XIntegrityManager()
	{
	}

	[Token(Token = "0x6005613")]
	[Address(RVA = "0x1D2E9C0", Offset = "0x1D2E9C0", VA = "0x1D2E9C0")]
	public bool IsReadyToHash()
	{
		return default(bool);
	}

	[Token(Token = "0x6005614")]
	[Address(RVA = "0x1D2E9C8", Offset = "0x1D2E9C8", VA = "0x1D2E9C8")]
	public void Init()
	{
	}

	[Token(Token = "0x6005615")]
	[Address(RVA = "0x1D2ED00", Offset = "0x1D2ED00", VA = "0x1D2ED00")]
	public string MakeHashKey(string strOptToken)
	{
		return null;
	}

	[Token(Token = "0x6005616")]
	[Address(RVA = "0x1D2EBC4", Offset = "0x1D2EBC4", VA = "0x1D2EBC4")]
	[DebuggerHidden]
	private IEnumerator GetClassesDex()
	{
		return null;
	}

	[Token(Token = "0x6005617")]
	[Address(RVA = "0x1D2EC50", Offset = "0x1D2EC50", VA = "0x1D2EC50")]
	private string GetLibFileHash(string fileName)
	{
		return null;
	}
}
