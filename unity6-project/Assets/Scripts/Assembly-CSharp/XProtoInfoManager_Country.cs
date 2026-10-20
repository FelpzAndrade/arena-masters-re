using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000656")]
public class XProtoInfoManager_Country : Dictionary<string, XCountryInfo>, CSProtoInfoManagerBase
{
	[Token(Token = "0x2000657")]
	private sealed class _003CGetCountryInfobyCountryCode_003Ec__AnonStorey128
	{
		[Token(Token = "0x4001E60")]
		[FieldOffset(Offset = "0x8")]
		internal string strCountryCode;

		[Token(Token = "0x6003625")]
		[Address(RVA = "0x1C8A2BC", Offset = "0x1C8A2BC", VA = "0x1C8A2BC")]
		public _003CGetCountryInfobyCountryCode_003Ec__AnonStorey128()
		{
		}

		[Token(Token = "0x6003626")]
		[Address(RVA = "0x1C8A7B0", Offset = "0x1C8A7B0", VA = "0x1C8A7B0")]
		internal bool _003C_003Em__17E(XCountryInfo CountryInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600361A")]
	[Address(RVA = "0x1C86324", Offset = "0x1C86324", VA = "0x1C86324")]
	public XProtoInfoManager_Country()
	{
	}

	[Token(Token = "0x600361B")]
	[Address(RVA = "0x1C89870", Offset = "0x1C89870", VA = "0x1C89870", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return from == ProtoInfoFrom.Client;
	}

	[Token(Token = "0x600361C")]
	[Address(RVA = "0x1C89880", Offset = "0x1C89880", VA = "0x1C89880", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x600361D")]
	[Address(RVA = "0x1C89884", Offset = "0x1C89884", VA = "0x1C89884", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		foreach (KeyValuePair<string, XCountryInfo> pair in this)
		{
			pair.Value.Cooking();
		}
		return true;
	}

	[Token(Token = "0x600361E")]
	[Address(RVA = "0x1C89B00", Offset = "0x1C89B00", VA = "0x1C89B00", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		Clear();
		XCountryInfoXML xml = CSXMLSerialization.Deserialize<XCountryInfoXML>(loader, Encoding.UTF8);
		if (xml == null)
		{
			if (loader != null)
			{
				CSLog.Error("Load failed : " + loader.Filename);
			}
			return false;
		}
		if (xml.dataList != null)
		{
			foreach (XCountryInfo info in xml.dataList)
			{
				string key = info.countryCode.ToUpper();
				if (!ContainsKey(key))
				{
					Add(key, info);
				}
			}
		}
		if (loader != null)
		{
			CSLog.Info("Load complete : " + loader.Filename);
		}
		return true;
	}

	[Token(Token = "0x600361F")]
	[Address(RVA = "0x1C8A034", Offset = "0x1C8A034", VA = "0x1C8A034")]
	public XCountryInfo GetCountryInfo(string strCountryCode, bool getDefaultEN = true)
	{
		XCountryInfo info = null;
		if (!string.IsNullOrEmpty(strCountryCode))
		{
			info = GetCountryInfobyCountryCode(strCountryCode);
		}
		if (info != null || !getDefaultEN)
		{
			return info;
		}
		return GetDefaultCountry();
	}

	[Token(Token = "0x6003620")]
	[Address(RVA = "0x1C8A238", Offset = "0x1C8A238", VA = "0x1C8A238")]
	public XCountryInfo GetDefaultCountry()
	{
		return GetCountryInfobyCountryCode("US");
	}

	[Token(Token = "0x6003621")]
	[Address(RVA = "0x1C8A11C", Offset = "0x1C8A11C", VA = "0x1C8A11C")]
	private XCountryInfo GetCountryInfobyCountryCode(string strCountryCode)
	{
		string code = strCountryCode.ToUpper();
		return FindCountryInfo(countryInfo => countryInfo.countryCode == code);
	}

	[Token(Token = "0x6003622")]
	[Address(RVA = "0x1C8A48C", Offset = "0x1C8A48C", VA = "0x1C8A48C")]
	public string GetFlagIconbyCountryCode(string strCountryCode)
	{
		XCountryInfo info = GetCountryInfo(strCountryCode) ?? GetDefaultCountry();
		return info.flagIcon;
	}

	[Token(Token = "0x6003623")]
	[Address(RVA = "0x1C8A2C4", Offset = "0x1C8A2C4", VA = "0x1C8A2C4")]
	private XCountryInfo FindCountryInfo(Func<XCountryInfo, bool> searchAction)
	{
		foreach (KeyValuePair<string, XCountryInfo> pair in this)
		{
			if (pair.Value == null)
			{
				return null;
			}
			if (searchAction(pair.Value))
			{
				return pair.Value;
			}
		}
		return null;
	}

	[Token(Token = "0x6003624")]
	[Address(RVA = "0x1C8A4CC", Offset = "0x1C8A4CC", VA = "0x1C8A4CC")]
	public ConnectEnum.RegionType RecommendRegion(string strCountryCode)
	{
		if (string.IsNullOrEmpty(strCountryCode))
		{
			return ConnectEnum.RegionType.Asia;
		}
		XCountryInfo info = GetCountryInfo(strCountryCode);
		if (info == null)
		{
			return ConnectEnum.RegionType.Asia;
		}
		foreach (ConnectEnum.RegionType region in ConnectEnum.AllowRegionList)
		{
			if (region.ToString().ToLower() == info.regionServerKey)
			{
				return region;
			}
		}
		return ConnectEnum.RegionType.Asia;
	}
}
