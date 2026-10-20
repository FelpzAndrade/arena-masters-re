using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000D73")]
public class XProtoInfoManager_KillStreak : Dictionary<int, XKillStreakInfo>, CSProtoInfoManagerBase
{
	[Token(Token = "0x400455F")]
	[FieldOffset(Offset = "0x34")]
	private XKillStreakInfo m_shutDownInfo;

	[Token(Token = "0x60062B8")]
	[Address(RVA = "0x1C86800", Offset = "0x1C86800", VA = "0x1C86800")]
	public XProtoInfoManager_KillStreak()
	{
	}

	[Token(Token = "0x60062B9")]
	[Address(RVA = "0x1C8C5D4", Offset = "0x1C8C5D4", VA = "0x1C8C5D4", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x60062BA")]
	[Address(RVA = "0x1C8C5E4", Offset = "0x1C8C5E4", VA = "0x1C8C5E4", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x60062BB")]
	[Address(RVA = "0x1C8C5E8", Offset = "0x1C8C5E8", VA = "0x1C8C5E8", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x60062BC")]
	[Address(RVA = "0x1C8C89C", Offset = "0x1C8C89C", VA = "0x1C8C89C")]
	public void LoadFromServer(JToken source)
	{
	}

	[Token(Token = "0x60062BD")]
	[Address(RVA = "0x1C8C930", Offset = "0x1C8C930", VA = "0x1C8C930", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x60062BE")]
	[Address(RVA = "0x1C8CE08", Offset = "0x1C8CE08", VA = "0x1C8CE08")]
	public XKillStreakInfo GetStreakKillInfo(int killCount)
	{
		return null;
	}

	[Token(Token = "0x60062BF")]
	[Address(RVA = "0x1C8CF80", Offset = "0x1C8CF80", VA = "0x1C8CF80")]
	public XKillStreakInfo GetShutDownInfo()
	{
		return null;
	}
}
