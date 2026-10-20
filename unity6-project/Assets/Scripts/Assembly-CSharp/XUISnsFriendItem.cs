using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200103E")]
public class XUISnsFriendItem : UIBase
{
	[Token(Token = "0x200103F")]
	private sealed class _003CSetPictureByCoroutine_003Ec__IteratorB2 : IDisposable
	{
		[Token(Token = "0x4005780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Texture2D _003Ctexture_003E__0;

		[Token(Token = "0x4005781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal WWW _003Cwww_003E__1;

		[Token(Token = "0x4005782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4005783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4005784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal XUISnsFriendItem _003C_003Ef__this;

		[Token(Token = "0x17000F05")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600794C")]
			[Address(RVA = "0x1930AE4", Offset = "0x1930AE4", VA = "0x1930AE4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000F06")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600794D")]
			[Address(RVA = "0x1930AEC", Offset = "0x1930AEC", VA = "0x1930AEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600794B")]
		[Address(RVA = "0x193002C", Offset = "0x193002C", VA = "0x193002C")]
		public _003CSetPictureByCoroutine_003Ec__IteratorB2()
		{
		}

		[Token(Token = "0x600794C")]
		[Address(RVA = "0x1930AE4", Offset = "0x1930AE4", VA = "0x1930AE4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600794D")]
		[Address(RVA = "0x1930AEC", Offset = "0x1930AEC", VA = "0x1930AEC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600794E")]
		[Address(RVA = "0x1930AF4", Offset = "0x1930AF4", VA = "0x1930AF4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600794F")]
		[Address(RVA = "0x1930FE0", Offset = "0x1930FE0", VA = "0x1930FE0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007950")]
		[Address(RVA = "0x1930FEC", Offset = "0x1930FEC", VA = "0x1930FEC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string prefabName;

	[Token(Token = "0x4005777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite sprPicture;

	[Token(Token = "0x4005778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject goGameDataGroup;

	[Token(Token = "0x4005779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UI2DSprite sprProfileIcon;

	[Token(Token = "0x400577A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UI2DSprite sprTitleIcon;

	[Token(Token = "0x400577B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprCountryFlag;

	[Token(Token = "0x400577C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblLevel;

	[Token(Token = "0x400577D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblNickname;

	[Token(Token = "0x400577E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblLastConnectTime;

	[Token(Token = "0x400577F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private FacebookFriend Friend__BackingField;

	[Token(Token = "0x17000F04")]
	public FacebookFriend Friend
	{
		[Token(Token = "0x600793C")]
		[Address(RVA = "0x192FC10", Offset = "0x192FC10", VA = "0x192FC10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600793D")]
		[Address(RVA = "0x192FC18", Offset = "0x192FC18", VA = "0x192FC18")]
		set
		{
		}
	}

	[Token(Token = "0x600793A")]
	[Address(RVA = "0x192FB78", Offset = "0x192FB78", VA = "0x192FB78")]
	public XUISnsFriendItem()
	{
	}

	[Token(Token = "0x600793E")]
	[Address(RVA = "0x192EE98", Offset = "0x192EE98", VA = "0x192EE98")]
	public static XUISnsFriendItem Create(FacebookFriend friend)
	{
		return null;
	}

	[Token(Token = "0x600793F")]
	[Address(RVA = "0x192FC20", Offset = "0x192FC20", VA = "0x192FC20")]
	public void Build()
	{
	}

	[Token(Token = "0x6007940")]
	[Address(RVA = "0x192FC24", Offset = "0x192FC24", VA = "0x192FC24", Slot = "12")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x6007941")]
	[Address(RVA = "0x192FC54", Offset = "0x192FC54", VA = "0x192FC54")]
	private void SetPicture()
	{
	}

	[Token(Token = "0x6007942")]
	[Address(RVA = "0x192FF88", Offset = "0x192FF88", VA = "0x192FF88")]
	[DebuggerHidden]
	private IEnumerator SetPictureByCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6007943")]
	[Address(RVA = "0x192FE64", Offset = "0x192FE64", VA = "0x192FE64")]
	private void SetGameDataGroup()
	{
	}

	[Token(Token = "0x6007944")]
	[Address(RVA = "0x1930034", Offset = "0x1930034", VA = "0x1930034")]
	private bool HasGameData()
	{
		return default(bool);
	}

	[Token(Token = "0x6007945")]
	[Address(RVA = "0x192FD44", Offset = "0x192FD44", VA = "0x192FD44")]
	private void SetName()
	{
	}

	[Token(Token = "0x6007946")]
	[Address(RVA = "0x193010C", Offset = "0x193010C", VA = "0x193010C")]
	private void SetProfileAndTitleIcon()
	{
	}

	[Token(Token = "0x6007947")]
	[Address(RVA = "0x193033C", Offset = "0x193033C", VA = "0x193033C")]
	private void SetCountryFlag()
	{
	}

	[Token(Token = "0x6007948")]
	[Address(RVA = "0x19304F8", Offset = "0x19304F8", VA = "0x19304F8")]
	private void SetLevel()
	{
	}

	[Token(Token = "0x6007949")]
	[Address(RVA = "0x19306C0", Offset = "0x19306C0", VA = "0x19306C0")]
	private void SetLastConnectTime()
	{
	}

	[Token(Token = "0x600794A")]
	[Address(RVA = "0x1930990", Offset = "0x1930990", VA = "0x1930990")]
	public void OnClick_Detail()
	{
	}
}
