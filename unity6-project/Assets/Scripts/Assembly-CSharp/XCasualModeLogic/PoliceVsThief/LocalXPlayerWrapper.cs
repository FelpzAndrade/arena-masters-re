using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

namespace XCasualModeLogic.PoliceVsThief
{
	[Token(Token = "0x200052A")]
	public class LocalXPlayerWrapper : XPlayerWrapper
	{
		[Token(Token = "0x200052B")]
		private sealed class _003CRespawn_003Ec__Iterator4F : IDisposable
		{
			[Token(Token = "0x4001A0A")]
			[FieldOffset(Offset = "0x8")]
			internal Vector3 pos;

			[Token(Token = "0x4001A0B")]
			[FieldOffset(Offset = "0x14")]
			internal int _0024PC;

			[Token(Token = "0x4001A0C")]
			[FieldOffset(Offset = "0x18")]
			internal object _0024current;

			[Token(Token = "0x4001A0D")]
			[FieldOffset(Offset = "0x1C")]
			internal Vector3 _003C_0024_003Epos;

			[Token(Token = "0x4001A0E")]
			[FieldOffset(Offset = "0x28")]
			internal LocalXPlayerWrapper _003C_003Ef__this;

			[Token(Token = "0x170006E1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6002C37")]
				[Address(RVA = "0x1AB0534", Offset = "0x1AB0534", VA = "0x1AB0534", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170006E2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002C38")]
				[Address(RVA = "0x1AB053C", Offset = "0x1AB053C", VA = "0x1AB053C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6002C36")]
			[Address(RVA = "0x1AAF5E8", Offset = "0x1AAF5E8", VA = "0x1AAF5E8")]
			public _003CRespawn_003Ec__Iterator4F()
			{
			}

			[Token(Token = "0x6002C37")]
			[Address(RVA = "0x1AB0534", Offset = "0x1AB0534", VA = "0x1AB0534", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6002C38")]
			[Address(RVA = "0x1AB053C", Offset = "0x1AB053C", VA = "0x1AB053C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6002C39")]
			[Address(RVA = "0x1AB0544", Offset = "0x1AB0544", VA = "0x1AB0544", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002C3A")]
			[Address(RVA = "0x1AB0758", Offset = "0x1AB0758", VA = "0x1AB0758", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6002C3B")]
			[Address(RVA = "0x1AB0764", Offset = "0x1AB0764", VA = "0x1AB0764", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x10")]
		private XModuleEntity me;

		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x14")]
		private IEnumerator _respawn;

		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x1AAED84", Offset = "0x1AAED84", VA = "0x1AAED84")]
		public LocalXPlayerWrapper(XPlayer photonPlayer, XModuleEntity me)
		{
		}

		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x1AAEF94", Offset = "0x1AAEF94", VA = "0x1AAEF94", Slot = "19")]
		public override void ChangeRoll(PoliceVsThiefRole role, int buffID)
		{
		}

		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x1AAF520", Offset = "0x1AAF520", VA = "0x1AAF520")]
		[DebuggerHidden]
		private IEnumerator Respawn(Vector3 pos)
		{
			return null;
		}

		[Token(Token = "0x6002C33")]
		[Address(RVA = "0x1AAF5F0", Offset = "0x1AAF5F0", VA = "0x1AAF5F0")]
		public void OnDieComplete()
		{
		}

		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x1AAFB9C", Offset = "0x1AAFB9C", VA = "0x1AAFB9C")]
		public void OnRejoin()
		{
		}

		[Token(Token = "0x6002C35")]
		[Address(RVA = "0x1AB04BC", Offset = "0x1AB04BC", VA = "0x1AB04BC", Slot = "20")]
		public override void OnStrongBoxOpened()
		{
		}
	}
}
