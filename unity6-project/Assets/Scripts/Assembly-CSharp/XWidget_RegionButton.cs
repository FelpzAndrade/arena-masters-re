using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000C43")]
public class XWidget_RegionButton : MonoBehaviour
{
	[Token(Token = "0x2000C44")]
	private sealed class _003CWWWDownload_003Ec__Iterator99 : IDisposable
	{
		[Token(Token = "0x4003E26")]
		[FieldOffset(Offset = "0x8")]
		internal string url;

		[Token(Token = "0x4003E27")]
		[FieldOffset(Offset = "0xC")]
		internal WWW _003Cwww_003E__0;

		[Token(Token = "0x4003E28")]
		[FieldOffset(Offset = "0x10")]
		internal bool _003CisError_003E__1;

		[Token(Token = "0x4003E29")]
		[FieldOffset(Offset = "0x14")]
		internal string _003CerrorText_003E__2;

		[Token(Token = "0x4003E2A")]
		[FieldOffset(Offset = "0x18")]
		internal string _003Ctext_003E__3;

		[Token(Token = "0x4003E2B")]
		[FieldOffset(Offset = "0x1C")]
		internal Exception _003Ce_003E__4;

		[Token(Token = "0x4003E2C")]
		[FieldOffset(Offset = "0x20")]
		internal Action<string> errorCallback;

		[Token(Token = "0x4003E2D")]
		[FieldOffset(Offset = "0x24")]
		internal Action<string> completeCallBack;

		[Token(Token = "0x4003E2E")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x4003E2F")]
		[FieldOffset(Offset = "0x2C")]
		internal object _0024current;

		[Token(Token = "0x4003E30")]
		[FieldOffset(Offset = "0x30")]
		internal string _003C_0024_003Eurl;

		[Token(Token = "0x4003E31")]
		[FieldOffset(Offset = "0x34")]
		internal Action<string> _003C_0024_003EerrorCallback;

		[Token(Token = "0x4003E32")]
		[FieldOffset(Offset = "0x38")]
		internal Action<string> _003C_0024_003EcompleteCallBack;

		[Token(Token = "0x17000CB3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60058CB")]
			[Address(RVA = "0x133A6E4", Offset = "0x133A6E4", VA = "0x133A6E4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000CB4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60058CC")]
			[Address(RVA = "0x133A6EC", Offset = "0x133A6EC", VA = "0x133A6EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x133A118", Offset = "0x133A118", VA = "0x133A118")]
		public _003CWWWDownload_003Ec__Iterator99()
		{
		}

		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x133A6E4", Offset = "0x133A6E4", VA = "0x133A6E4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x133A6EC", Offset = "0x133A6EC", VA = "0x133A6EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x133A6F4", Offset = "0x133A6F4", VA = "0x133A6F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x133ABD4", Offset = "0x133ABD4", VA = "0x133ABD4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x133ACE4", Offset = "0x133ACE4", VA = "0x133ACE4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000C45")]
	private sealed class _003CCheckChangeRegion_003Ec__AnonStorey17A
	{
		[Token(Token = "0x4003E33")]
		[FieldOffset(Offset = "0x8")]
		internal Prefs prefs;

		[Token(Token = "0x4003E34")]
		[FieldOffset(Offset = "0xC")]
		internal ConnectEnum.RegionType type;

		[Token(Token = "0x4003E35")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_RegionButton _003C_003Ef__this;

		[Token(Token = "0x60058D0")]
		[Address(RVA = "0x13398C8", Offset = "0x13398C8", VA = "0x13398C8")]
		public _003CCheckChangeRegion_003Ec__AnonStorey17A()
		{
		}

		[Token(Token = "0x60058D1")]
		[Address(RVA = "0x133A244", Offset = "0x133A244", VA = "0x133A244")]
		internal void _003C_003Em__24E(string text)
		{
		}

		[Token(Token = "0x60058D2")]
		[Address(RVA = "0x133A5CC", Offset = "0x133A5CC", VA = "0x133A5CC")]
		internal void _003C_003Em__24F(string errorText)
		{
		}
	}

	[Token(Token = "0x4003E1B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH;

	[Token(Token = "0x4003E1C")]
	[FieldOffset(Offset = "0xC")]
	private Action<ICommonBackableUI> m_RegisterPopup;

	[Token(Token = "0x4003E1D")]
	[FieldOffset(Offset = "0x10")]
	private Action<ICommonBackableUI> m_ReleasePopup;

	[Token(Token = "0x4003E1E")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget widget;

	[Token(Token = "0x4003E1F")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Button regionBtn;

	[Token(Token = "0x4003E20")]
	[FieldOffset(Offset = "0x1C")]
	public BoxCollider colider;

	[Token(Token = "0x4003E21")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_ServerRegion pnlServerRegionPopup;

	[Token(Token = "0x4003E22")]
	[FieldOffset(Offset = "0x24")]
	private ConnectEnum.RegionType selectRegion;

	[Token(Token = "0x4003E23")]
	[FieldOffset(Offset = "0x28")]
	private bool isTitleScene;

	[Token(Token = "0x4003E24")]
	[FieldOffset(Offset = "0x29")]
	private bool Enable__BackingField;

	[Token(Token = "0x4003E25")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x17000CB2")]
	public bool Enable
	{
		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x1338E78", Offset = "0x1338E78", VA = "0x1338E78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x1338E80", Offset = "0x1338E80", VA = "0x1338E80")]
		private set
		{
		}
	}

	[Token(Token = "0x60058B6")]
	[Address(RVA = "0x1338DE0", Offset = "0x1338DE0", VA = "0x1338DE0")]
	public XWidget_RegionButton()
	{
	}

	[Token(Token = "0x60058B8")]
	[Address(RVA = "0x130AFC0", Offset = "0x130AFC0", VA = "0x130AFC0")]
	public static XWidget_RegionButton Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60058B9")]
	[Address(RVA = "0x130B160", Offset = "0x130B160", VA = "0x130B160")]
	public void SetBackRegisterFunc(Action<ICommonBackableUI> registerPopup, Action<ICommonBackableUI> releasePopup)
	{
	}

	[Token(Token = "0x60058BC")]
	[Address(RVA = "0x1338E88", Offset = "0x1338E88", VA = "0x1338E88")]
	private void Awake()
	{
	}

	[Token(Token = "0x60058BD")]
	[Address(RVA = "0x1338E90", Offset = "0x1338E90", VA = "0x1338E90")]
	public void SetEnable(bool enable)
	{
	}

	[Token(Token = "0x60058BE")]
	[Address(RVA = "0x130B224", Offset = "0x130B224", VA = "0x130B224")]
	public void Init(ConnectEnum.RegionType curRegion, bool _isTitleScene = false)
	{
	}

	[Token(Token = "0x60058BF")]
	[Address(RVA = "0x130B16C", Offset = "0x130B16C", VA = "0x130B16C")]
	public void ChangeWidgetSize(int width, int height)
	{
	}

	[Token(Token = "0x60058C0")]
	[Address(RVA = "0x13390DC", Offset = "0x13390DC", VA = "0x13390DC")]
	public void ShowRegionPopup(bool isBackable = true)
	{
	}

	[Token(Token = "0x60058C1")]
	[Address(RVA = "0x13392E8", Offset = "0x13392E8", VA = "0x13392E8")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60058C2")]
	[Address(RVA = "0x13392FC", Offset = "0x13392FC", VA = "0x13392FC")]
	public void CheckChangeRegion(ConnectEnum.RegionType type)
	{
	}

	[Token(Token = "0x60058C3")]
	[Address(RVA = "0x1339990", Offset = "0x1339990", VA = "0x1339990")]
	private void ShowErrorPopup(string errorText = "")
	{
	}

	[Token(Token = "0x60058C4")]
	[Address(RVA = "0x1339B98", Offset = "0x1339B98", VA = "0x1339B98")]
	private void ApplyChangeRegion(ConnectEnum.RegionType type)
	{
	}

	[Token(Token = "0x60058C5")]
	[Address(RVA = "0x1339F00", Offset = "0x1339F00", VA = "0x1339F00")]
	private void ShowRegionReadyPopup()
	{
	}

	[Token(Token = "0x60058C6")]
	[Address(RVA = "0x1338FA4", Offset = "0x1338FA4", VA = "0x1338FA4")]
	private string GetRegionText(ConnectEnum.RegionType region, bool isTitleScene)
	{
		return null;
	}

	[Token(Token = "0x60058C7")]
	[Address(RVA = "0x133A0D8", Offset = "0x133A0D8", VA = "0x133A0D8")]
	public void RefreshButtonText()
	{
	}

	[Token(Token = "0x60058C8")]
	[Address(RVA = "0x13398D0", Offset = "0x13398D0", VA = "0x13398D0")]
	[DebuggerHidden]
	protected IEnumerator WWWDownload(string url, Action<string> completeCallBack, Action<string> errorCallback)
	{
		return null;
	}

	[Token(Token = "0x60058C9")]
	[Address(RVA = "0x133A120", Offset = "0x133A120", VA = "0x133A120")]
	private static void _003CApplyChangeRegion_003Em__250()
	{
	}
}
