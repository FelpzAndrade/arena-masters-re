using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200066D")]
public class XLobbyButtonInfo
{
	[Token(Token = "0x200066E")]
	public struct DetailSettingData
	{
		[Token(Token = "0x4001ED9")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 textPosition;

		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0xC")]
		public NGUIText.Alignment textAlign;
	}

	[Token(Token = "0x4001EBE")]
	[FieldOffset(Offset = "0x8")]
	public int order;

	[Token(Token = "0x4001EBF")]
	[FieldOffset(Offset = "0xC")]
	public XLobbyButtonType lobbyButtonType;

	[Token(Token = "0x4001EC0")]
	[FieldOffset(Offset = "0x10")]
	public XLobbyButtonSubType lobbyButtonSubType;

	[Token(Token = "0x4001EC1")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x4001EC2")]
	[FieldOffset(Offset = "0x18")]
	public string iconPath;

	[Token(Token = "0x4001EC3")]
	[FieldOffset(Offset = "0x1C")]
	public string imagePath;

	[Token(Token = "0x4001EC4")]
	[FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x4001EC5")]
	[FieldOffset(Offset = "0x24")]
	public string description;

	[Token(Token = "0x4001EC6")]
	[FieldOffset(Offset = "0x28")]
	public string subDescription;

	[Token(Token = "0x4001EC7")]
	[FieldOffset(Offset = "0x2C")]
	public int showOrder;

	[Token(Token = "0x4001EC8")]
	[FieldOffset(Offset = "0x30")]
	public XLobbyButtonPlatformType platformType;

	[Token(Token = "0x4001EC9")]
	[FieldOffset(Offset = "0x34")]
	public string country;

	[Token(Token = "0x4001ECA")]
	[FieldOffset(Offset = "0x38")]
	public string lang;

	[Token(Token = "0x4001ECB")]
	[FieldOffset(Offset = "0x3C")]
	public string strStartDate;

	[Token(Token = "0x4001ECC")]
	[FieldOffset(Offset = "0x40")]
	public DateTime startDate;

	[Token(Token = "0x4001ECD")]
	[FieldOffset(Offset = "0x50")]
	public string strEndDate;

	[Token(Token = "0x4001ECE")]
	[FieldOffset(Offset = "0x58")]
	public DateTime endDate;

	[Token(Token = "0x4001ECF")]
	[FieldOffset(Offset = "0x68")]
	public string link;

	[Token(Token = "0x4001ED0")]
	[FieldOffset(Offset = "0x6C")]
	public XLobbyButtonActionType actionType;

	[Token(Token = "0x4001ED1")]
	[FieldOffset(Offset = "0x70")]
	public string strDetailSetting;

	[Token(Token = "0x4001ED2")]
	[FieldOffset(Offset = "0x74")]
	public bool isDetailSetting;

	[Token(Token = "0x4001ED3")]
	[FieldOffset(Offset = "0x78")]
	public string strMainTextSetting;

	[Token(Token = "0x4001ED4")]
	[FieldOffset(Offset = "0x7C")]
	public string strSubTextSetting;

	[Token(Token = "0x4001ED5")]
	[FieldOffset(Offset = "0x80")]
	public DetailSettingData[] SettingData;

	[Token(Token = "0x4001ED6")]
	[FieldOffset(Offset = "0x84")]
	private Action click__BackingField;

	[Token(Token = "0x4001ED7")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapA;

	[Token(Token = "0x4001ED8")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapB;

	[Token(Token = "0x170007E4")]
	[XmlIgnore]
	public Action click
	{
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x1E17880", Offset = "0x1E17880", VA = "0x1E17880")]
		get
		{
			return null;
		}
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x1E17888", Offset = "0x1E17888", VA = "0x1E17888")]
		set
		{
		}
	}

	[Token(Token = "0x600366A")]
	[Address(RVA = "0x1E17564", Offset = "0x1E17564", VA = "0x1E17564")]
	public XLobbyButtonInfo()
	{
	}

	[Token(Token = "0x600366D")]
	[Address(RVA = "0x1E17890", Offset = "0x1E17890", VA = "0x1E17890")]
	public bool Cooking()
	{
		return default(bool);
	}

	[Token(Token = "0x600366E")]
	[Address(RVA = "0x1E17F90", Offset = "0x1E17F90", VA = "0x1E17F90")]
	private void SetTextAlignSetting(int index, string strAlignData)
	{
	}

	[Token(Token = "0x600366F")]
	[Address(RVA = "0x1E181FC", Offset = "0x1E181FC", VA = "0x1E181FC")]
	private void SetTextPosSetting(int index, string strPosData)
	{
	}

	[Token(Token = "0x6003670")]
	[Address(RVA = "0x1E1845C", Offset = "0x1E1845C", VA = "0x1E1845C")]
	public bool CheckCountry(string country)
	{
		return default(bool);
	}
}
