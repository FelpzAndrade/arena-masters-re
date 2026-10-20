using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000ED9")]
public class XWidget_MultipleSellBox : XUIBaseWidget
{
	[Token(Token = "0x2000EDA")]
	private sealed class _003COnClick_SellComfirm_003Ec__AnonStorey215
	{
		[Token(Token = "0x4004E72")]
		[FieldOffset(Offset = "0x8")]
		internal List<string> iidList;

		[Token(Token = "0x4004E73")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_MultipleSellBox _003C_003Ef__this;

		[Token(Token = "0x6006EC8")]
		[Address(RVA = "0x1300F04", Offset = "0x1300F04", VA = "0x1300F04")]
		public _003COnClick_SellComfirm_003Ec__AnonStorey215()
		{
		}

		[Token(Token = "0x6006EC9")]
		[Address(RVA = "0x13011C8", Offset = "0x13011C8", VA = "0x13011C8")]
		internal void _003C_003Em__426(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004E68")]
	[FieldOffset(Offset = "0x1C")]
	private Action m_onComplete;

	[Token(Token = "0x4004E69")]
	[FieldOffset(Offset = "0x20")]
	private Action m_onClose;

	[Token(Token = "0x4004E6A")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridItem;

	[Token(Token = "0x4004E6B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblEarnGold;

	[Token(Token = "0x4004E6C")]
	[FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprCurrency;

	[Token(Token = "0x4004E6D")]
	[FieldOffset(Offset = "0x30")]
	private List<XItem> m_sellList;

	[Token(Token = "0x4004E6E")]
	[FieldOffset(Offset = "0x34")]
	private int m_earnGold;

	[Token(Token = "0x4004E6F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite sprBackground;

	[Token(Token = "0x4004E70")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_EnvelopContent envelopContent;

	[Token(Token = "0x4004E71")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isSelling;

	[Token(Token = "0x17000E1D")]
	public int SellItemCount
	{
		[Token(Token = "0x6006EC2")]
		[Address(RVA = "0x1300698", Offset = "0x1300698", VA = "0x1300698")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6006EC1")]
	[Address(RVA = "0x1300690", Offset = "0x1300690", VA = "0x1300690")]
	public XWidget_MultipleSellBox()
	{
	}

	[Token(Token = "0x6006EC3")]
	[Address(RVA = "0x130072C", Offset = "0x130072C", VA = "0x130072C")]
	public void Build(List<XItem> sellList, int totalCost, Action onComplete, Action onClose)
	{
	}

	[Token(Token = "0x6006EC4")]
	[Address(RVA = "0x13009EC", Offset = "0x13009EC", VA = "0x13009EC")]
	private void BuildCost(int totalCost)
	{
	}

	[Token(Token = "0x6006EC5")]
	[Address(RVA = "0x1300B38", Offset = "0x1300B38", VA = "0x1300B38")]
	public void OnClick_SellComfirm()
	{
	}

	[Token(Token = "0x6006EC6")]
	[Address(RVA = "0x1300F0C", Offset = "0x1300F0C", VA = "0x1300F0C")]
	public void NetCallBack_SellEquipments(int iidListCnt)
	{
	}

	[Token(Token = "0x6006EC7")]
	[Address(RVA = "0x1301190", Offset = "0x1301190", VA = "0x1301190", Slot = "12")]
	public override void Hide()
	{
	}
}
