using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000F64")]
public class XWidget_AutoEquip : XUIBaseWidget
{
	[Token(Token = "0x2000F65")]
	private sealed class _003COnClick_AutoEquip_003Ec__AnonStorey233
	{
		[Token(Token = "0x40050EE")]
		[FieldOffset(Offset = "0x8")]
		internal XItem item;

		[Token(Token = "0x40050EF")]
		[FieldOffset(Offset = "0xC")]
		internal EquipmentSlot slot;

		[Token(Token = "0x40050F0")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_AutoEquip _003C_003Ef__this;

		[Token(Token = "0x600726B")]
		[Address(RVA = "0x15BA798", Offset = "0x15BA798", VA = "0x15BA798")]
		public _003COnClick_AutoEquip_003Ec__AnonStorey233()
		{
		}

		[Token(Token = "0x600726C")]
		[Address(RVA = "0x15BA7A0", Offset = "0x15BA7A0", VA = "0x15BA7A0")]
		internal void _003C_003Em__498(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x40050E2")]
	[FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder gridOrigin;

	[Token(Token = "0x40050E3")]
	[FieldOffset(Offset = "0x20")]
	public XWiget_GridBuilder gridAutoEquip;

	[Token(Token = "0x40050E4")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridArrow;

	[Token(Token = "0x40050E5")]
	[FieldOffset(Offset = "0x28")]
	private Action m_onFinished;

	[Token(Token = "0x40050E6")]
	[FieldOffset(Offset = "0x2C")]
	private Action<EquipmentSlot> m_onEquip;

	[Token(Token = "0x40050E7")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<EquipmentSlot, string> m_autoEquipDic;

	[Token(Token = "0x40050E8")]
	[FieldOffset(Offset = "0x34")]
	private XModuleActor m_character;

	[Token(Token = "0x40050E9")]
	[FieldOffset(Offset = "0x38")]
	private int m_needEquipCount;

	[Token(Token = "0x40050EA")]
	[FieldOffset(Offset = "0x3C")]
	private int m_responseEquipCount;

	[Token(Token = "0x40050EB")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsPet;

	[Token(Token = "0x40050EC")]
	[FieldOffset(Offset = "0x41")]
	private bool m_isEquipping;

	[Token(Token = "0x40050ED")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XItem, EquipmentSlot> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x17000E9B")]
	public bool IsEquipping
	{
		[Token(Token = "0x6007262")]
		[Address(RVA = "0x193FF44", Offset = "0x193FF44", VA = "0x193FF44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007261")]
	[Address(RVA = "0x193FE98", Offset = "0x193FE98", VA = "0x193FE98")]
	public XWidget_AutoEquip()
	{
	}

	[Token(Token = "0x6007263")]
	[Address(RVA = "0x193FF5C", Offset = "0x193FF5C", VA = "0x193FF5C")]
	private void ClearAutoEquipDic()
	{
	}

	[Token(Token = "0x6007264")]
	[Address(RVA = "0x194033C", Offset = "0x194033C", VA = "0x194033C")]
	public string GetAutoEquipItemID(EquipmentSlot slot)
	{
		return null;
	}

	[Token(Token = "0x6007265")]
	[Address(RVA = "0x19403DC", Offset = "0x19403DC", VA = "0x19403DC")]
	public void SetAutoEquipItem(XModuleActor selectChar)
	{
	}

	[Token(Token = "0x6007266")]
	[Address(RVA = "0x1940F44", Offset = "0x1940F44", VA = "0x1940F44")]
	private float GetPowerTotalStat(CharStatus status, float magicalRate, float physicalRate)
	{
		return default(float);
	}

	[Token(Token = "0x6007267")]
	[Address(RVA = "0x1940FC0", Offset = "0x1940FC0", VA = "0x1940FC0")]
	public void Show(XModuleActor character, Action onFinished, Action<EquipmentSlot> onEquip)
	{
	}

	[Token(Token = "0x6007268")]
	[Address(RVA = "0x19410EC", Offset = "0x19410EC", VA = "0x19410EC")]
	private void BuildEquipmentSlot(XModuleActor character, Action onFinished, Action<EquipmentSlot> onEquip)
	{
	}

	[Token(Token = "0x6007269")]
	[Address(RVA = "0x19414A4", Offset = "0x19414A4", VA = "0x19414A4")]
	public void OnClick_AutoEquip()
	{
	}

	[Token(Token = "0x600726A")]
	[Address(RVA = "0x1941BA4", Offset = "0x1941BA4", VA = "0x1941BA4")]
	private static EquipmentSlot _003CSetAutoEquipItem_003Em__497(XItem x)
	{
		return default(EquipmentSlot);
	}
}
