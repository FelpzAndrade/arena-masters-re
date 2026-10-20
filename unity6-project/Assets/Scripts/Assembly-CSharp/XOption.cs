using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x2001087")]
public class XOption
{
	[Token(Token = "0x4005916")]
	[FieldOffset(Offset = "0x8")]
	public bool PlayPushAlarm;

	[Token(Token = "0x4005917")]
	[FieldOffset(Offset = "0x9")]
	public bool PlayVibration;

	[Token(Token = "0x4005918")]
	[FieldOffset(Offset = "0xA")]
	public bool ConnectToGoogle;

	[Token(Token = "0x4005919")]
	[FieldOffset(Offset = "0xB")]
	public bool VirtualPadStaticMode;

	[Token(Token = "0x400591A")]
	[FieldOffset(Offset = "0xC")]
	public bool IngamePlayRecord;

	[Token(Token = "0x400591B")]
	[FieldOffset(Offset = "0x10")]
	public int GraphicsQuality;

	[Token(Token = "0x400591C")]
	[FieldOffset(Offset = "0x14")]
	public int FrameRateQuality;

	[Token(Token = "0x400591D")]
	[FieldOffset(Offset = "0x18")]
	public float BGM_Vol;

	[Token(Token = "0x400591E")]
	[FieldOffset(Offset = "0x1C")]
	public float SFX_Vol;

	[Token(Token = "0x400591F")]
	[FieldOffset(Offset = "0x20")]
	public bool AutomaticCombat;

	[Token(Token = "0x4005920")]
	[FieldOffset(Offset = "0x24")]
	public string Language;

	[Token(Token = "0x4005921")]
	[FieldOffset(Offset = "0x28")]
	public bool ShowCharId;

	[Token(Token = "0x4005922")]
	[FieldOffset(Offset = "0x29")]
	public bool ShowCharinterface;

	[Token(Token = "0x4005923")]
	[FieldOffset(Offset = "0x2A")]
	public bool ShowFPS;

	[Token(Token = "0x4005924")]
	[FieldOffset(Offset = "0x2B")]
	public bool HideMessage;

	[Token(Token = "0x4005925")]
	[FieldOffset(Offset = "0x2C")]
	public bool ShowName;

	[Token(Token = "0x4005926")]
	[FieldOffset(Offset = "0x2D")]
	public bool UseLocalData;

	[Token(Token = "0x4005927")]
	[FieldOffset(Offset = "0x30")]
	public string billing_token;

	[Token(Token = "0x4005928")]
	[FieldOffset(Offset = "0x34")]
	public bool ShowDummyLoc;

	[Token(Token = "0x4005929")]
	[FieldOffset(Offset = "0x35")]
	public bool isTouchEffect;

	[Token(Token = "0x400592A")]
	[FieldOffset(Offset = "0x36")]
	public bool debug;

	[Token(Token = "0x400592B")]
	[FieldOffset(Offset = "0x37")]
	public bool debuggconsole;

	[Token(Token = "0x400592C")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<string, int> AchievementsDictionary;

	[Token(Token = "0x400592D")]
	[FieldOffset(Offset = "0x3C")]
	[JsonIgnore]
	public bool DeveloperMode;

	[Token(Token = "0x400592E")]
	[FieldOffset(Offset = "0x3D")]
	[JsonIgnore]
	public bool ForMovie;

	[Token(Token = "0x400592F")]
	[FieldOffset(Offset = "0x3E")]
	[JsonIgnore]
	public bool God;

	[Token(Token = "0x4005930")]
	[FieldOffset(Offset = "0x3F")]
	public bool InputID;

	[Token(Token = "0x4005931")]
	[FieldOffset(Offset = "0x40")]
	[JsonIgnore]
	public bool DisableUltDirection;

	[Token(Token = "0x4005932")]
	[FieldOffset(Offset = "0x41")]
	[JsonIgnore]
	public bool LogFPS;

	[Token(Token = "0x4005933")]
	[FieldOffset(Offset = "0x42")]
	[JsonIgnore]
	public bool ShowELO;

	[Token(Token = "0x4005934")]
	[FieldOffset(Offset = "0x43")]
	[JsonIgnore]
	public bool ShowPing;

	[Token(Token = "0x4005935")]
	[FieldOffset(Offset = "0x44")]
	[JsonIgnore]
	public bool ShowLagSim;

	[Token(Token = "0x4005936")]
	[FieldOffset(Offset = "0x45")]
	[JsonIgnore]
	public bool PhotonStats;

	[Token(Token = "0x4005937")]
	[FieldOffset(Offset = "0x46")]
	[JsonIgnore]
	public bool ShowStat;

	[Token(Token = "0x4005938")]
	[FieldOffset(Offset = "0x48")]
	[JsonIgnore]
	public float PostPingFrequency;

	[Token(Token = "0x4005939")]
	[FieldOffset(Offset = "0x4C")]
	[JsonIgnore]
	public float PostPollingPingFrequency;

	[Token(Token = "0x400593A")]
	[FieldOffset(Offset = "0x50")]
	[JsonIgnore]
	public bool SpectatorMode;

	[Token(Token = "0x400593B")]
	[FieldOffset(Offset = "0x51")]
	[JsonIgnore]
	public bool FakeStorageFull;

	[Token(Token = "0x400593C")]
	[FieldOffset(Offset = "0x52")]
	[JsonIgnore]
	public bool DevLoginMode;

	[Token(Token = "0x400593D")]
	[FieldOffset(Offset = "0x53")]
	[JsonIgnore]
	public bool KofEffect;

	[Token(Token = "0x400593E")]
	[FieldOffset(Offset = "0x54")]
	[JsonIgnore]
	public bool IsUsdPrice;

	[Token(Token = "0x6007CC7")]
	[Address(RVA = "0x168F8C0", Offset = "0x168F8C0", VA = "0x168F8C0")]
	public XOption()
	{
	}

	[Token(Token = "0x6007CC8")]
	[Address(RVA = "0x168FA10", Offset = "0x168FA10", VA = "0x168FA10")]
	public void Reset()
	{
	}

	[Token(Token = "0x6007CC9")]
	[Address(RVA = "0x168FAE4", Offset = "0x168FAE4", VA = "0x168FAE4")]
	public void ResetDebug()
	{
	}
}
