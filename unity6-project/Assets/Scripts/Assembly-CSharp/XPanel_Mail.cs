using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000DF4")]
public class XPanel_Mail : MonoBehaviour
{
	[Token(Token = "0x2000DF5")]
	private sealed class _003CPartialRecvMail_003Ec__AnonStorey1D3
	{
		[Token(Token = "0x4004908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal List<string> buffer;

		[Token(Token = "0x4004909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Queue<string> TargetMails;

		[Token(Token = "0x400490A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int BufferSize;

		[Token(Token = "0x400490B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XPanel_Mail _003C_003Ef__this;

		[Token(Token = "0x6006767")]
		[Address(RVA = "0x1000084", Offset = "0x1000084", VA = "0x1000084")]
		public _003CPartialRecvMail_003Ec__AnonStorey1D3()
		{
		}

		[Token(Token = "0x6006768")]
		[Address(RVA = "0x1000160", Offset = "0x1000160", VA = "0x1000160")]
		internal void _003C_003Em__38B(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x40048F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public XUIMailList m_MailList;

	[Token(Token = "0x40048F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private MailType m_MailType;

	[Token(Token = "0x40048F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public UILabel lblMailTotalCount;

	[Token(Token = "0x40048F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblMailNormal;

	[Token(Token = "0x40048F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblMailShop;

	[Token(Token = "0x40048FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblMailCooperation;

	[Token(Token = "0x40048FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblMailPresent;

	[Token(Token = "0x40048FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblMailCash;

	[Token(Token = "0x40048FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UILabel lblHasNoMail;

	[Token(Token = "0x40048FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XWidget_ToggleTab[] tabArray;

	[Token(Token = "0x40048FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GameObject newBadgeNormal;

	[Token(Token = "0x4004900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject newBadgeShop;

	[Token(Token = "0x4004901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public GameObject newBadgeCooperation;

	[Token(Token = "0x4004902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject newBadgePresent;

	[Token(Token = "0x4004903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public GameObject newBadgeCash;

	[Token(Token = "0x4004904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject BtnReceiveAll;

	[Token(Token = "0x4004905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GameObject BtnReceiveAllDisable;

	[Token(Token = "0x4004906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action onChangedMailType;

	[Token(Token = "0x4004907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool m_poping;

	[Token(Token = "0x17000D70")]
	public MailType MailType
	{
		[Token(Token = "0x6006757")]
		[Address(RVA = "0xFFE140", Offset = "0xFFE140", VA = "0xFFE140")]
		get
		{
			return default(MailType);
		}
	}

	[Token(Token = "0x6006756")]
	[Address(RVA = "0xFFE138", Offset = "0xFFE138", VA = "0xFFE138")]
	public XPanel_Mail()
	{
	}

	[Token(Token = "0x6006758")]
	[Address(RVA = "0xFFE148", Offset = "0xFFE148", VA = "0xFFE148")]
	public void Show(bool bShow, [Optional] Action OnChangedMailType)
	{
	}

	[Token(Token = "0x6006759")]
	[Address(RVA = "0xFFE33C", Offset = "0xFFE33C", VA = "0xFFE33C")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600675A")]
	[Address(RVA = "0xFFE340", Offset = "0xFFE340", VA = "0xFFE340")]
	public void Build()
	{
	}

	[Token(Token = "0x600675B")]
	[Address(RVA = "0xFFE338", Offset = "0xFFE338", VA = "0xFFE338")]
	public void Clear()
	{
	}

	[Token(Token = "0x600675C")]
	[Address(RVA = "0xFFF5C4", Offset = "0xFFF5C4", VA = "0xFFF5C4")]
	private void ChangeMailType(MailType mailType)
	{
	}

	[Token(Token = "0x600675D")]
	[Address(RVA = "0xFFF628", Offset = "0xFFF628", VA = "0xFFF628")]
	private void SetReceiveAllButton(MailType mailType)
	{
	}

	[Token(Token = "0x600675E")]
	[Address(RVA = "0xFFF458", Offset = "0xFFF458", VA = "0xFFF458")]
	private void SetlblHasNoMail(MailType mailType)
	{
	}

	[Token(Token = "0x600675F")]
	[Address(RVA = "0xFFE330", Offset = "0xFFE330", VA = "0xFFE330")]
	public void OnClick_NormalType()
	{
	}

	[Token(Token = "0x6006760")]
	[Address(RVA = "0xFFF68C", Offset = "0xFFF68C", VA = "0xFFF68C")]
	public void OnClick_ShopType()
	{
	}

	[Token(Token = "0x6006761")]
	[Address(RVA = "0xFFF694", Offset = "0xFFF694", VA = "0xFFF694")]
	public void OnClick_CooperationType()
	{
	}

	[Token(Token = "0x6006762")]
	[Address(RVA = "0xFFF69C", Offset = "0xFFF69C", VA = "0xFFF69C")]
	public void OnClick_PresentType()
	{
	}

	[Token(Token = "0x6006763")]
	[Address(RVA = "0xFFF6A4", Offset = "0xFFF6A4", VA = "0xFFF6A4")]
	public void OnClick_CashType()
	{
	}

	[Token(Token = "0x6006764")]
	[Address(RVA = "0xFFF6AC", Offset = "0xFFF6AC", VA = "0xFFF6AC")]
	public void OnClickPopMailAllButton()
	{
	}

	[Token(Token = "0x6006765")]
	[Address(RVA = "0xFFFCCC", Offset = "0xFFFCCC", VA = "0xFFFCCC")]
	public void PartialRecvMail(Queue<string> TargetMails, int BufferSize)
	{
	}

	[Token(Token = "0x6006766")]
	[Address(RVA = "0x100008C", Offset = "0x100008C", VA = "0x100008C")]
	public void OnButtonClick_CloseWindow()
	{
	}
}
