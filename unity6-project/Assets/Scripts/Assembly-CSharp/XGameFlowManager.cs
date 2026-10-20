using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000616")]
public class XGameFlowManager
{
	[Token(Token = "0x2000617")]
	private sealed class _003CEndCurrentFlow_003Ec__Iterator7A : IDisposable
	{
		[Token(Token = "0x4001D2C")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001D2E")]
		[FieldOffset(Offset = "0x10")]
		internal XGameFlowManager _003C_003Ef__this;

		[Token(Token = "0x170007B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600347E")]
			[Address(RVA = "0x13EC1F8", Offset = "0x13EC1F8", VA = "0x13EC1F8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600347F")]
			[Address(RVA = "0x13EC200", Offset = "0x13EC200", VA = "0x13EC200", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600347D")]
		[Address(RVA = "0x13EAE58", Offset = "0x13EAE58", VA = "0x13EAE58")]
		public _003CEndCurrentFlow_003Ec__Iterator7A()
		{
		}

		[Token(Token = "0x600347E")]
		[Address(RVA = "0x13EC1F8", Offset = "0x13EC1F8", VA = "0x13EC1F8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600347F")]
		[Address(RVA = "0x13EC200", Offset = "0x13EC200", VA = "0x13EC200", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003480")]
		[Address(RVA = "0x13EC208", Offset = "0x13EC208", VA = "0x13EC208", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003481")]
		[Address(RVA = "0x13EC2FC", Offset = "0x13EC2FC", VA = "0x13EC2FC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003482")]
		[Address(RVA = "0x13EC308", Offset = "0x13EC308", VA = "0x13EC308", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000618")]
	private sealed class _003CChangeToLoadingSceneCoroutine_003Ec__Iterator7B : IDisposable
	{
		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x10")]
		internal XGameFlowManager _003C_003Ef__this;

		[Token(Token = "0x170007B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003484")]
			[Address(RVA = "0x13EBF54", Offset = "0x13EBF54", VA = "0x13EBF54", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003485")]
			[Address(RVA = "0x13EBF5C", Offset = "0x13EBF5C", VA = "0x13EBF5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003483")]
		[Address(RVA = "0x13EBD80", Offset = "0x13EBD80", VA = "0x13EBD80")]
		public _003CChangeToLoadingSceneCoroutine_003Ec__Iterator7B()
		{
		}

		[Token(Token = "0x6003484")]
		[Address(RVA = "0x13EBF54", Offset = "0x13EBF54", VA = "0x13EBF54", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003485")]
		[Address(RVA = "0x13EBF5C", Offset = "0x13EBF5C", VA = "0x13EBF5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003486")]
		[Address(RVA = "0x13EBF64", Offset = "0x13EBF64", VA = "0x13EBF64", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003487")]
		[Address(RVA = "0x13EC044", Offset = "0x13EC044", VA = "0x13EC044", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003488")]
		[Address(RVA = "0x13EC050", Offset = "0x13EC050", VA = "0x13EC050", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000619")]
	private sealed class _003CDoNextFrame_003Ec__Iterator7C : IDisposable
	{
		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x8")]
		internal Action action;

		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x14")]
		internal Action _003C_0024_003Eaction;

		[Token(Token = "0x170007BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600348A")]
			[Address(RVA = "0x13EC0E4", Offset = "0x13EC0E4", VA = "0x13EC0E4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600348B")]
			[Address(RVA = "0x13EC0EC", Offset = "0x13EC0EC", VA = "0x13EC0EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003489")]
		[Address(RVA = "0x13EBE30", Offset = "0x13EBE30", VA = "0x13EBE30")]
		public _003CDoNextFrame_003Ec__Iterator7C()
		{
		}

		[Token(Token = "0x600348A")]
		[Address(RVA = "0x13EC0E4", Offset = "0x13EC0E4", VA = "0x13EC0E4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600348B")]
		[Address(RVA = "0x13EC0EC", Offset = "0x13EC0EC", VA = "0x13EC0EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600348C")]
		[Address(RVA = "0x13EC0F4", Offset = "0x13EC0F4", VA = "0x13EC0F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600348D")]
		[Address(RVA = "0x13EC158", Offset = "0x13EC158", VA = "0x13EC158", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600348E")]
		[Address(RVA = "0x13EC164", Offset = "0x13EC164", VA = "0x13EC164", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001D25")]
	[FieldOffset(Offset = "0x8")]
	private XGameFlow m_prev;

	[Token(Token = "0x4001D26")]
	[FieldOffset(Offset = "0xC")]
	private GameFlowTypes m_prevFlowType;

	[Token(Token = "0x4001D27")]
	[FieldOffset(Offset = "0x10")]
	private XGameFlow m_current;

	[Token(Token = "0x4001D28")]
	[FieldOffset(Offset = "0x14")]
	private string m_nextScene;

	[Token(Token = "0x4001D29")]
	[FieldOffset(Offset = "0x18")]
	private bool m_nextLoadSceneViaPhoton;

	[Token(Token = "0x4001D2A")]
	[FieldOffset(Offset = "0x1C")]
	public Queue<string> PauseLog;

	[Token(Token = "0x4001D2B")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map9;

	[Token(Token = "0x6003464")]
	[Address(RVA = "0x13EAA98", Offset = "0x13EAA98", VA = "0x13EAA98")]
	public XGameFlowManager()
	{
	}

	[Token(Token = "0x6003465")]
	[Address(RVA = "0x13EAB9C", Offset = "0x13EAB9C", VA = "0x13EAB9C")]
	private static XGameFlow MakeFlow(GameFlowTypes type)
	{
		return null;
	}

	[Token(Token = "0x6003466")]
	[Address(RVA = "0x13EADAC", Offset = "0x13EADAC", VA = "0x13EADAC")]
	public void SetFlow(XGameFlow flow)
	{
	}

	[Token(Token = "0x6003467")]
	[Address(RVA = "0x13EADB4", Offset = "0x13EADB4", VA = "0x13EADB4")]
	[DebuggerHidden]
	public IEnumerator EndCurrentFlow()
	{
		return null;
	}

	[Token(Token = "0x6003468")]
	[Address(RVA = "0x13E9B98", Offset = "0x13E9B98", VA = "0x13E9B98")]
	public void ChangeFlow(GameFlowTypes type)
	{
	}

	[Token(Token = "0x6003469")]
	[Address(RVA = "0x13EAE60", Offset = "0x13EAE60", VA = "0x13EAE60")]
	public GameFlowTypes GetFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x600346A")]
	[Address(RVA = "0x13EAEB4", Offset = "0x13EAEB4", VA = "0x13EAEB4")]
	public GameFlowTypes GetPrevFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x600346B")]
	[Address(RVA = "0x13EAEBC", Offset = "0x13EAEBC", VA = "0x13EAEBC")]
	public GameFlowTypes GetNextFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x600346C")]
	[Address(RVA = "0x13EB0BC", Offset = "0x13EB0BC", VA = "0x13EB0BC")]
	public void Update()
	{
	}

	[Token(Token = "0x600346D")]
	[Address(RVA = "0x13EB208", Offset = "0x13EB208", VA = "0x13EB208")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x600346E")]
	[Address(RVA = "0x13EB290", Offset = "0x13EB290", VA = "0x13EB290")]
	private void AddPauseLog(string log)
	{
	}

	[Token(Token = "0x600346F")]
	[Address(RVA = "0x13EB390", Offset = "0x13EB390", VA = "0x13EB390")]
	public string GetPauseLog()
	{
		return null;
	}

	[Token(Token = "0x6003470")]
	[Address(RVA = "0x13EB4F8", Offset = "0x13EB4F8", VA = "0x13EB4F8")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6003471")]
	[Address(RVA = "0x13EB6CC", Offset = "0x13EB6CC", VA = "0x13EB6CC")]
	public bool TryLoadSceneWithSectorId(int sectorId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003472")]
	[Address(RVA = "0x13EB808", Offset = "0x13EB808", VA = "0x13EB808")]
	public void LoadScene(string strSceneName, bool isPhotonSync = false)
	{
	}

	[Token(Token = "0x6003473")]
	[Address(RVA = "0x13EB86C", Offset = "0x13EB86C", VA = "0x13EB86C")]
	public void LoadLoadingScene()
	{
	}

	[Token(Token = "0x6003474")]
	[Address(RVA = "0x13EBC90", Offset = "0x13EBC90", VA = "0x13EBC90")]
	private void ChangeToLoadingScene()
	{
	}

	[Token(Token = "0x6003475")]
	[Address(RVA = "0x13EBCDC", Offset = "0x13EBCDC", VA = "0x13EBCDC")]
	[DebuggerHidden]
	private IEnumerator ChangeToLoadingSceneCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6003476")]
	[Address(RVA = "0x13EBD88", Offset = "0x13EBD88", VA = "0x13EBD88")]
	[DebuggerHidden]
	private IEnumerator DoNextFrame(Action action)
	{
		return null;
	}

	[Token(Token = "0x6003477")]
	[Address(RVA = "0x13E4094", Offset = "0x13E4094", VA = "0x13E4094")]
	public void ExecuteLoadScene()
	{
	}

	[Token(Token = "0x6003478")]
	[Address(RVA = "0x13E4444", Offset = "0x13E4444", VA = "0x13E4444")]
	public bool IsLoadingServerMatching()
	{
		return default(bool);
	}

	[Token(Token = "0x6003479")]
	[Address(RVA = "0x13EBE38", Offset = "0x13EBE38", VA = "0x13EBE38")]
	public bool IsTitle()
	{
		return default(bool);
	}

	[Token(Token = "0x600347A")]
	[Address(RVA = "0x13EBE50", Offset = "0x13EBE50", VA = "0x13EBE50")]
	public bool IsLobby()
	{
		return default(bool);
	}

	[Token(Token = "0x600347B")]
	[Address(RVA = "0x13EBE70", Offset = "0x13EBE70", VA = "0x13EBE70")]
	private void _003CLoadLoadingScene_003Em__172()
	{
	}

	[Token(Token = "0x600347C")]
	[Address(RVA = "0x13EBE74", Offset = "0x13EBE74", VA = "0x13EBE74")]
	private void _003CLoadLoadingScene_003Em__173()
	{
	}
}
