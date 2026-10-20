using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001025")]
public class XUIIronsMissionItem : UIBase
{
	[Token(Token = "0x40056AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string prefabName;

	[Token(Token = "0x40056AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblNumber;

	[Token(Token = "0x40056AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x40056B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Transform iconParent;

	[Token(Token = "0x40056B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XWidget_ContentIcon ItemIcon;

	[Token(Token = "0x40056B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblName;

	[Token(Token = "0x40056B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblCount;

	[Token(Token = "0x40056B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UIProgressBar Progressbar;

	[Token(Token = "0x40056B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblProgressRate;

	[Token(Token = "0x40056B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UIButton btnClose;

	[Token(Token = "0x40056B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UIButton btnStart;

	[Token(Token = "0x40056B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UIButton btnReward;

	[Token(Token = "0x40056B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goSelect;

	[Token(Token = "0x40056BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public GameObject goComplete;

	[Token(Token = "0x40056BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IronsMission Mission__BackingField;

	[Token(Token = "0x40056BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Action OnDataChanged__BackingField;

	[Token(Token = "0x17000EFB")]
	public IronsMission Mission
	{
		[Token(Token = "0x6007870")]
		[Address(RVA = "0x1094F24", Offset = "0x1094F24", VA = "0x1094F24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007871")]
		[Address(RVA = "0x1094F2C", Offset = "0x1094F2C", VA = "0x1094F2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000EFC")]
	public Action OnDataChanged
	{
		[Token(Token = "0x6007872")]
		[Address(RVA = "0x1094F34", Offset = "0x1094F34", VA = "0x1094F34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007873")]
		[Address(RVA = "0x1094F3C", Offset = "0x1094F3C", VA = "0x1094F3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000EFD")]
	public IronsMissionState MissionState
	{
		[Token(Token = "0x6007874")]
		[Address(RVA = "0x1094F44", Offset = "0x1094F44", VA = "0x1094F44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600786E")]
	[Address(RVA = "0x1094E8C", Offset = "0x1094E8C", VA = "0x1094E8C")]
	public XUIIronsMissionItem()
	{
	}

	[Token(Token = "0x6007875")]
	[Address(RVA = "0x1095060", Offset = "0x1095060", VA = "0x1095060")]
	public static XUIIronsMissionItem Create(IronsMission mission, Action onDataChanged)
	{
		return null;
	}

	[Token(Token = "0x6007876")]
	[Address(RVA = "0x10952A0", Offset = "0x10952A0", VA = "0x10952A0")]
	public void Build()
	{
	}

	[Token(Token = "0x6007877")]
	[Address(RVA = "0x10952C4", Offset = "0x10952C4", VA = "0x10952C4", Slot = "12")]
	public override void Refresh([Optional] UIEvent type, [Optional] object data)
	{
	}

	[Token(Token = "0x6007878")]
	[Address(RVA = "0x109531C", Offset = "0x109531C", VA = "0x109531C")]
	private void SetNumber()
	{
	}

	[Token(Token = "0x6007879")]
	[Address(RVA = "0x1095410", Offset = "0x1095410", VA = "0x1095410")]
	private void SetTitle()
	{
	}

	[Token(Token = "0x600787A")]
	[Address(RVA = "0x10954F0", Offset = "0x10954F0", VA = "0x10954F0")]
	private void SetItemIcon()
	{
	}

	[Token(Token = "0x600787B")]
	[Address(RVA = "0x10955E4", Offset = "0x10955E4", VA = "0x10955E4")]
	private void SetItemName()
	{
	}

	[Token(Token = "0x600787C")]
	[Address(RVA = "0x10957E0", Offset = "0x10957E0", VA = "0x10957E0")]
	private void SetProgressBar()
	{
	}

	[Token(Token = "0x600787D")]
	[Address(RVA = "0x1095A64", Offset = "0x1095A64", VA = "0x1095A64")]
	private void SetButton()
	{
	}

	[Token(Token = "0x600787E")]
	[Address(RVA = "0x1095CE0", Offset = "0x1095CE0", VA = "0x1095CE0")]
	private void SetTouchCover()
	{
	}

	[Token(Token = "0x600787F")]
	[Address(RVA = "0x1095E84", Offset = "0x1095E84", VA = "0x1095E84")]
	public void OnClick_Start()
	{
	}

	[Token(Token = "0x6007880")]
	[Address(RVA = "0x1096034", Offset = "0x1096034", VA = "0x1096034")]
	public void OnClick_GetReward()
	{
	}

	[Token(Token = "0x6007881")]
	[Address(RVA = "0x10962B8", Offset = "0x10962B8", VA = "0x10962B8")]
	private bool TryResponseError(ApiReturnCode errno, string errmsg, JObject json)
	{
		return default(bool);
	}

	[Token(Token = "0x6007882")]
	[Address(RVA = "0x1096484", Offset = "0x1096484", VA = "0x1096484")]
	private void TryGetStringByApiReturnCode(ApiReturnCode errno, out string title, out string message)
	{
		message = default;
		title = default;
	}

	[Token(Token = "0x6007883")]
	[Address(RVA = "0x1096624", Offset = "0x1096624", VA = "0x1096624")]
	private void _003COnClick_GetReward_003Em__505(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
