using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200067E")]
public class XSystem
{
	[Token(Token = "0x4001F37")]
	[FieldOffset(Offset = "0x8")]
	private int m_nGraphicQuality;

	[Token(Token = "0x4001F38")]
	[FieldOffset(Offset = "0xC")]
	private int m_processorCount;

	[Token(Token = "0x4001F39")]
	[FieldOffset(Offset = "0x10")]
	private int m_processorFrequency;

	[Token(Token = "0x4001F3A")]
	[FieldOffset(Offset = "0x14")]
	private int m_deviceMemorySize;

	[Token(Token = "0x4001F3B")]
	[FieldOffset(Offset = "0x18")]
	private int m_deviceGraphicMemorySize;

	[Token(Token = "0x4001F3C")]
	[FieldOffset(Offset = "0x1C")]
	private string m_graphicDeviceName;

	[Token(Token = "0x4001F3D")]
	[FieldOffset(Offset = "0x20")]
	private XLocale m_Locale;

	[Token(Token = "0x4001F3E")]
	[FieldOffset(Offset = "0x0")]
	private static Func<Texture, int> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x170007EC")]
	public int GraphicQuality
	{
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x1832898", Offset = "0x1832898", VA = "0x1832898")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007ED")]
	public int ProcessorCount
	{
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x18328A0", Offset = "0x18328A0", VA = "0x18328A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007EE")]
	public int ProcessorFrequency
	{
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x18328A8", Offset = "0x18328A8", VA = "0x18328A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007EF")]
	public int DeviceMemorySize
	{
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x18328B0", Offset = "0x18328B0", VA = "0x18328B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007F0")]
	public int DeviceGraphicMemorySize
	{
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x18328B8", Offset = "0x18328B8", VA = "0x18328B8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007F1")]
	public string GraphicDeviceName
	{
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x18328C0", Offset = "0x18328C0", VA = "0x18328C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F2")]
	public XLocale Locale
	{
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x1831300", Offset = "0x1831300", VA = "0x1831300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F3")]
	public string CurrentLangString
	{
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x1833F9C", Offset = "0x1833F9C", VA = "0x1833F9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F4")]
	public static bool UseBackgroundPatch
	{
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x18346DC", Offset = "0x18346DC", VA = "0x18346DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007F5")]
	public static bool UseConsole
	{
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x18346E4", Offset = "0x18346E4", VA = "0x18346E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170007F6")]
	private static Platform Platform
	{
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x18346EC", Offset = "0x18346EC", VA = "0x18346EC")]
		get
		{
			return default(Platform);
		}
	}

	[Token(Token = "0x60036C1")]
	[Address(RVA = "0x18326A4", Offset = "0x18326A4", VA = "0x18326A4")]
	public XSystem()
	{
	}

	[Token(Token = "0x60036C2")]
	[Address(RVA = "0x183279C", Offset = "0x183279C", VA = "0x183279C")]
	public XSystem(IGetLocaleInfo localeGetter)
	{
	}

	[Token(Token = "0x60036C9")]
	[Address(RVA = "0x18328C8", Offset = "0x18328C8", VA = "0x18328C8")]
	public void Init()
	{
	}

	[Token(Token = "0x60036CA")]
	[Address(RVA = "0x1832A90", Offset = "0x1832A90", VA = "0x1832A90")]
	private void GetDeviceSystemInfo()
	{
	}

	[Token(Token = "0x60036CB")]
	[Address(RVA = "0x18333B0", Offset = "0x18333B0", VA = "0x18333B0")]
	private bool CheckHighGraphicCardsName(string deviceName, string str1, string str2)
	{
		return default(bool);
	}

	[Token(Token = "0x60036CC")]
	[Address(RVA = "0x1833448", Offset = "0x1833448", VA = "0x1833448")]
	private bool IsDefaultHighGPUSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x60036CD")]
	[Address(RVA = "0x1833990", Offset = "0x1833990", VA = "0x1833990")]
	private bool IsDefaultLowGPUSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x60036CE")]
	[Address(RVA = "0x1833160", Offset = "0x1833160", VA = "0x1833160")]
	public void SetFrameRate()
	{
	}

	[Token(Token = "0x60036CF")]
	[Address(RVA = "0x1833EF0", Offset = "0x1833EF0", VA = "0x1833EF0")]
	public void SetVsyncAll()
	{
	}

	[Token(Token = "0x60036D0")]
	[Address(RVA = "0x1833F00", Offset = "0x1833F00", VA = "0x1833F00")]
	public void DisableVsync()
	{
	}

	[Token(Token = "0x60036D1")]
	[Address(RVA = "0x1833EA8", Offset = "0x1833EA8", VA = "0x1833EA8")]
	private void SetTargetFrame(int frameRateQuality)
	{
	}

	[Token(Token = "0x60036D2")]
	[Address(RVA = "0x1833F10", Offset = "0x1833F10", VA = "0x1833F10")]
	private void SetTargetFrameByVsync(int frameRateQuality)
	{
	}

	[Token(Token = "0x60036D3")]
	[Address(RVA = "0x1832D30", Offset = "0x1832D30", VA = "0x1832D30")]
	public void SetGraphicQuality()
	{
	}

	[Token(Token = "0x60036D4")]
	[Address(RVA = "0x1832AF0", Offset = "0x1832AF0", VA = "0x1832AF0")]
	public void InitLang()
	{
	}

	[Token(Token = "0x60036D5")]
	[Address(RVA = "0x1833F44", Offset = "0x1833F44", VA = "0x1833F44")]
	public void SetLocale(string lang)
	{
	}

	[Token(Token = "0x60036D6")]
	[Address(RVA = "0x1833F70", Offset = "0x1833F70", VA = "0x1833F70")]
	public void ChangeLocale(string lang)
	{
	}

	[Token(Token = "0x60036D9")]
	[Address(RVA = "0x1833FC8", Offset = "0x1833FC8", VA = "0x1833FC8")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60036DA")]
	[Address(RVA = "0x18333A0", Offset = "0x18333A0", VA = "0x18333A0")]
	public void SetNeverSleep()
	{
	}

	[Token(Token = "0x60036DB")]
	[Address(RVA = "0x1833FD4", Offset = "0x1833FD4", VA = "0x1833FD4")]
	public void SetTimeScale(float fScale)
	{
	}

	[Token(Token = "0x60036DC")]
	[Address(RVA = "0x1833FE0", Offset = "0x1833FE0", VA = "0x1833FE0")]
	public void ResetTimeScale()
	{
	}

	[Token(Token = "0x60036DD")]
	[Address(RVA = "0x1833FF0", Offset = "0x1833FF0", VA = "0x1833FF0")]
	public void SetTimePause()
	{
	}

	[Token(Token = "0x60036DE")]
	[Address(RVA = "0x1834000", Offset = "0x1834000", VA = "0x1834000")]
	public bool IsTimePause()
	{
		return default(bool);
	}

	[Token(Token = "0x60036DF")]
	[Address(RVA = "0x1834038", Offset = "0x1834038", VA = "0x1834038")]
	public void GCCollect()
	{
	}

	[Token(Token = "0x60036E0")]
	[Address(RVA = "0x1834044", Offset = "0x1834044", VA = "0x1834044")]
	public static string GetRunTimeMemoryLog(int from = 0, int count = 999)
	{
		return null;
	}

	[Token(Token = "0x60036E4")]
	[Address(RVA = "0x18346F4", Offset = "0x18346F4", VA = "0x18346F4")]
	public static bool IsAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x60036E5")]
	[Address(RVA = "0x18346FC", Offset = "0x18346FC", VA = "0x18346FC")]
	public static bool IsiOS()
	{
		return default(bool);
	}

	[Token(Token = "0x60036E6")]
	[Address(RVA = "0x1834704", Offset = "0x1834704", VA = "0x1834704")]
	public static bool IsUnity()
	{
		return default(bool);
	}

	[Token(Token = "0x60036E7")]
	[Address(RVA = "0x183470C", Offset = "0x183470C", VA = "0x183470C")]
	public static bool IsEditor()
	{
		return default(bool);
	}

	[Token(Token = "0x60036E8")]
	[Address(RVA = "0x1834714", Offset = "0x1834714", VA = "0x1834714")]
	public static SystemLanguage GetSystemLanguage()
	{
		return default(SystemLanguage);
	}

	[Token(Token = "0x60036E9")]
	[Address(RVA = "0x1834720", Offset = "0x1834720", VA = "0x1834720")]
	private static int _003CGetRunTimeMemoryLog_003Em__187(Texture go)
	{
		return default(int);
	}
}
