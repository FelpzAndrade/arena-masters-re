using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200074E")]
	public class XWall : XLevelObject
	{
		[Token(Token = "0x200074F")]
		private sealed class _003CDisappear_003Ec__Iterator85 : IDisposable
		{
			[Token(Token = "0x4002296")]
			[FieldOffset(Offset = "0x8")]
			internal float _003Cheight_003E__0;

			[Token(Token = "0x4002297")]
			[FieldOffset(Offset = "0xC")]
			internal float _003Cduration_003E__1;

			[Token(Token = "0x4002298")]
			[FieldOffset(Offset = "0x10")]
			internal float _003CstepPerSec_003E__2;

			[Token(Token = "0x4002299")]
			[FieldOffset(Offset = "0x14")]
			internal float _003Caccum_003E__3;

			[Token(Token = "0x400229A")]
			[FieldOffset(Offset = "0x18")]
			internal float _003Cstep_003E__4;

			[Token(Token = "0x400229B")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x400229C")]
			[FieldOffset(Offset = "0x20")]
			internal object _0024current;

			[Token(Token = "0x400229D")]
			[FieldOffset(Offset = "0x24")]
			internal XWall _003C_003Ef__this;

			[Token(Token = "0x1700083B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6003BC0")]
				[Address(RVA = "0x2033768", Offset = "0x2033768", VA = "0x2033768", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700083C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003BC1")]
				[Address(RVA = "0x2033770", Offset = "0x2033770", VA = "0x2033770", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6003BBF")]
			[Address(RVA = "0x2033760", Offset = "0x2033760", VA = "0x2033760")]
			public _003CDisappear_003Ec__Iterator85()
			{
			}

			[Token(Token = "0x6003BC0")]
			[Address(RVA = "0x2033768", Offset = "0x2033768", VA = "0x2033768", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0x2033770", Offset = "0x2033770", VA = "0x2033770", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6003BC2")]
			[Address(RVA = "0x2033778", Offset = "0x2033778", VA = "0x2033778", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6003BC3")]
			[Address(RVA = "0x20338D4", Offset = "0x20338D4", VA = "0x20338D4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x20338E0", Offset = "0x20338E0", VA = "0x20338E0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x2033628", Offset = "0x2033628", VA = "0x2033628")]
		public XWall()
		{
		}

		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x2033630", Offset = "0x2033630", VA = "0x2033630", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x20336B8", Offset = "0x20336B8", VA = "0x20336B8", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}

		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x2028AB4", Offset = "0x2028AB4", VA = "0x2028AB4")]
		public void DestroyWall()
		{
		}

		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x20336BC", Offset = "0x20336BC", VA = "0x20336BC")]
		[DebuggerHidden]
		private IEnumerator Disappear()
		{
			return null;
		}
	}
}
