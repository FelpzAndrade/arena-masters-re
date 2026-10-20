using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010E8")]
[IntegrationTest.SucceedWithAssertions]
public class ShopTest : MonoBehaviour
{
	[Token(Token = "0x20010E9")]
	private sealed class _003CBuyPopupHideInSec_003Ec__IteratorBC : IDisposable
	{
		[Token(Token = "0x4005CE1")]
		[FieldOffset(Offset = "0x8")]
		internal float sec;

		[Token(Token = "0x4005CE2")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4005CE3")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4005CE4")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Esec;

		[Token(Token = "0x4005CE5")]
		[FieldOffset(Offset = "0x18")]
		internal ShopTest _003C_003Ef__this;

		[Token(Token = "0x17000FA0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007F75")]
			[Address(RVA = "0x20F8300", Offset = "0x20F8300", VA = "0x20F8300", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000FA1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007F76")]
			[Address(RVA = "0x20F8308", Offset = "0x20F8308", VA = "0x20F8308", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6007F74")]
		[Address(RVA = "0x20F7FF0", Offset = "0x20F7FF0", VA = "0x20F7FF0")]
		public _003CBuyPopupHideInSec_003Ec__IteratorBC()
		{
		}

		[Token(Token = "0x6007F75")]
		[Address(RVA = "0x20F8300", Offset = "0x20F8300", VA = "0x20F8300", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007F76")]
		[Address(RVA = "0x20F8308", Offset = "0x20F8308", VA = "0x20F8308", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007F77")]
		[Address(RVA = "0x20F8310", Offset = "0x20F8310", VA = "0x20F8310", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007F78")]
		[Address(RVA = "0x20F842C", Offset = "0x20F842C", VA = "0x20F842C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007F79")]
		[Address(RVA = "0x20F8438", Offset = "0x20F8438", VA = "0x20F8438", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20010EA")]
	private sealed class _003CBuyConfirmPopupHideInSec_003Ec__IteratorBD : IDisposable
	{
		[Token(Token = "0x4005CE6")]
		[FieldOffset(Offset = "0x8")]
		internal float sec;

		[Token(Token = "0x4005CE7")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4005CE8")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4005CE9")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003Esec;

		[Token(Token = "0x4005CEA")]
		[FieldOffset(Offset = "0x18")]
		internal ShopTest _003C_003Ef__this;

		[Token(Token = "0x17000FA2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007F7B")]
			[Address(RVA = "0x20F8154", Offset = "0x20F8154", VA = "0x20F8154", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000FA3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007F7C")]
			[Address(RVA = "0x20F815C", Offset = "0x20F815C", VA = "0x20F815C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6007F7A")]
		[Address(RVA = "0x20F7FF8", Offset = "0x20F7FF8", VA = "0x20F7FF8")]
		public _003CBuyConfirmPopupHideInSec_003Ec__IteratorBD()
		{
		}

		[Token(Token = "0x6007F7B")]
		[Address(RVA = "0x20F8154", Offset = "0x20F8154", VA = "0x20F8154", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007F7C")]
		[Address(RVA = "0x20F815C", Offset = "0x20F815C", VA = "0x20F815C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007F7D")]
		[Address(RVA = "0x20F8164", Offset = "0x20F8164", VA = "0x20F8164", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007F7E")]
		[Address(RVA = "0x20F8260", Offset = "0x20F8260", VA = "0x20F8260", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007F7F")]
		[Address(RVA = "0x20F826C", Offset = "0x20F826C", VA = "0x20F826C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005CDB")]
	[FieldOffset(Offset = "0xC")]
	public XPanel_NormalShop gachaShop;

	[Token(Token = "0x4005CDC")]
	[FieldOffset(Offset = "0x10")]
	public XPanel_ShopBuy gachaShopBuy;

	[Token(Token = "0x4005CDD")]
	[FieldOffset(Offset = "0x14")]
	public XPanel_BuyConfirm gachaConfirm;

	[Token(Token = "0x4005CDE")]
	[FieldOffset(Offset = "0x18")]
	public XPanel_TopBanner topBanner;

	[Token(Token = "0x4005CDF")]
	[FieldOffset(Offset = "0x1C")]
	public Rect windowRect;

	[Token(Token = "0x4005CE0")]
	[FieldOffset(Offset = "0x2C")]
	private ShopItemCategory curCategory;

	[Token(Token = "0x6007F69")]
	[Address(RVA = "0x20F5D00", Offset = "0x20F5D00", VA = "0x20F5D00")]
	public ShopTest()
	{
	}

	[Token(Token = "0x6007F6A")]
	[Address(RVA = "0x20F5D78", Offset = "0x20F5D78", VA = "0x20F5D78")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007F6B")]
	[Address(RVA = "0x20F6AB0", Offset = "0x20F6AB0", VA = "0x20F6AB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6007F6C")]
	[Address(RVA = "0x20F6B28", Offset = "0x20F6B28", VA = "0x20F6B28")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6007F6D")]
	[Address(RVA = "0x20F6C78", Offset = "0x20F6C78", VA = "0x20F6C78")]
	private void ShopTestGUIFunc(int windowID)
	{
	}

	[Token(Token = "0x6007F6E")]
	[Address(RVA = "0x20F7E50", Offset = "0x20F7E50", VA = "0x20F7E50")]
	private void ShopShow()
	{
	}

	[Token(Token = "0x6007F6F")]
	[Address(RVA = "0x20F7E88", Offset = "0x20F7E88", VA = "0x20F7E88")]
	[DebuggerHidden]
	private IEnumerator BuyPopupHideInSec(float sec)
	{
		return null;
	}

	[Token(Token = "0x6007F70")]
	[Address(RVA = "0x20F7F3C", Offset = "0x20F7F3C", VA = "0x20F7F3C")]
	[DebuggerHidden]
	private IEnumerator BuyConfirmPopupHideInSec(float sec)
	{
		return null;
	}

	[Token(Token = "0x6007F71")]
	[Address(RVA = "0x20F5D7C", Offset = "0x20F5D7C", VA = "0x20F5D7C")]
	private void Init()
	{
	}

	[Token(Token = "0x6007F72")]
	[Address(RVA = "0x20F7994", Offset = "0x20F7994", VA = "0x20F7994")]
	private void RefreshStallList()
	{
	}

	[Token(Token = "0x6007F73")]
	[Address(RVA = "0x20F8000", Offset = "0x20F8000", VA = "0x20F8000")]
	private Netdata_StallItem CreateStallItem(int id, StallType stallType)
	{
		return null;
	}
}
