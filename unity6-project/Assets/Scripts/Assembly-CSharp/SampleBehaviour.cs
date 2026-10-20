using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000178")]
public class SampleBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000179")]
	private sealed class _003CSaveScreenShot_003Ec__Iterator21 : IDisposable
	{
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CfilePath_003E__0;

		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0xC")]
		internal Texture2D _003Ctexture_003E__1;

		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] _003Cbytes_003E__2;

		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x1700023A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x20EEDEC", Offset = "0x20EEDEC", VA = "0x20EEDEC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700023B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x20EEDF4", Offset = "0x20EEDF4", VA = "0x20EEDF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x20EEDE4", Offset = "0x20EEDE4", VA = "0x20EEDE4")]
		public _003CSaveScreenShot_003Ec__Iterator21()
		{
		}

		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x20EEDEC", Offset = "0x20EEDEC", VA = "0x20EEDEC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x20EEDF4", Offset = "0x20EEDF4", VA = "0x20EEDF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x20EEDFC", Offset = "0x20EEDFC", VA = "0x20EEDFC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x20EF1C0", Offset = "0x20EF1C0", VA = "0x20EF1C0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x20EF1CC", Offset = "0x20EF1CC", VA = "0x20EF1CC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x20EEB48", Offset = "0x20EEB48", VA = "0x20EEB48")]
	public SampleBehaviour()
	{
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x20EEB50", Offset = "0x20EEB50", VA = "0x20EEB50")]
	public void OnClickGlinkButton()
	{
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x20EED34", Offset = "0x20EED34", VA = "0x20EED34")]
	public void OnClickScreenShotButton()
	{
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x20EED58", Offset = "0x20EED58", VA = "0x20EED58")]
	[DebuggerHidden]
	private IEnumerator SaveScreenShot()
	{
		return null;
	}
}
