using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x20008C7")]
	public class CSNetProcessor : INetProcessor
	{
		[Token(Token = "0x20008C8")]
		private sealed class _003CCheckContainSameProcess_003Ec__AnonStorey140
		{
			[Token(Token = "0x4002AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Type addProcessType;

			[Token(Token = "0x60046F0")]
			[Address(RVA = "0x1FBF768", Offset = "0x1FBF768", VA = "0x1FBF768")]
			public _003CCheckContainSameProcess_003Ec__AnonStorey140()
			{
			}

			[Token(Token = "0x60046F1")]
			[Address(RVA = "0x1FBF770", Offset = "0x1FBF770", VA = "0x1FBF770")]
			internal bool _003C_003Em__1CC(CSNetProcessBase x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4002ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private CSNetworkManager m_networkMgr;

		[Token(Token = "0x4002ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private CSNetProcessBase m_current;

		[Token(Token = "0x4002ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<CSNetProcessBase> m_processes;

		[Token(Token = "0x60046E5")]
		[Address(RVA = "0x1FBEB6C", Offset = "0x1FBEB6C", VA = "0x1FBEB6C")]
		public CSNetProcessor()
		{
		}

		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x1FBEC18", Offset = "0x1FBEC18", VA = "0x1FBEC18", Slot = "4")]
		public void Init(CSNetworkManager networkMgr)
		{
		}

		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x1FBEC28", Offset = "0x1FBEC28", VA = "0x1FBEC28", Slot = "5")]
		public void Clear()
		{
		}

		[Token(Token = "0x60046E8")]
		public void ScheduleProcess<TNETPROCESS>([Optional] CSNetParameters param, [Optional] JObject postBody, [Optional] NetCallback callback) where TNETPROCESS : CSNetProcessBase, new()
		{
		}

		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x1FBECC8", Offset = "0x1FBECC8", VA = "0x1FBECC8", Slot = "11")]
		protected virtual void OnAddProcess(CSNetProcessBase process)
		{
		}

		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x1FBECCC", Offset = "0x1FBECCC", VA = "0x1FBECCC", Slot = "7")]
		public void ScheduleProcess(CSNetProcessBase process, [Optional] CSNetParameters param, [Optional] JObject postBody, [Optional] NetCallback callback)
		{
		}

		[Token(Token = "0x60046EB")]
		[Address(RVA = "0x1FBF200", Offset = "0x1FBF200", VA = "0x1FBF200", Slot = "8")]
		public CSNetProcessBase GetFirstProcess()
		{
			return null;
		}

		[Token(Token = "0x60046EC")]
		[Address(RVA = "0x1FBF288", Offset = "0x1FBF288", VA = "0x1FBF288")]
		private void RunProcess(CSNetProcessBase process)
		{
		}

		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x1FBF4F0", Offset = "0x1FBF4F0", VA = "0x1FBF4F0", Slot = "9")]
		public void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x1FBF6D0", Offset = "0x1FBF6D0", VA = "0x1FBF6D0", Slot = "10")]
		public int GetProcessCount()
		{
			return default(int);
		}

		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x1FBF034", Offset = "0x1FBF034", VA = "0x1FBF034")]
		private bool CheckContainSameProcess(Type addProcessType, CSNetParameters param)
		{
			return default(bool);
		}
	}
}
