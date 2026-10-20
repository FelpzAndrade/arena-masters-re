using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using SharpRaven;
using SharpRaven.Data;
using UnityEngine;

[Token(Token = "0x2000BD2")]
public class ErrorReporter : MonoSingleton<ErrorReporter>
{
	[Token(Token = "0x4003BFE")]
	private const int m_maxReport = 3;

	[Token(Token = "0x4003BFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public string dsnUrl;

	[Token(Token = "0x4003C00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private RavenClient ravenClient;

	[Token(Token = "0x4003C01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public LogType logLevel;

	[Token(Token = "0x4003C02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_initialized;

	[Token(Token = "0x4003C03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int m_reportedCount;

	[Token(Token = "0x600555F")]
	[Address(RVA = "0x1E6B230", Offset = "0x1E6B230", VA = "0x1E6B230")]
	public ErrorReporter()
	{
	}

	[Token(Token = "0x6005560")]
	[Address(RVA = "0x1E6B308", Offset = "0x1E6B308", VA = "0x1E6B308", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6005561")]
	[Address(RVA = "0x1E6B38C", Offset = "0x1E6B38C", VA = "0x1E6B38C")]
	public bool Initialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6005562")]
	[Address(RVA = "0x1E6B394", Offset = "0x1E6B394", VA = "0x1E6B394")]
	public void Initialize(string url)
	{
	}

	[Token(Token = "0x6005563")]
	[Address(RVA = "0x1E6B450", Offset = "0x1E6B450", VA = "0x1E6B450")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6005564")]
	[Address(RVA = "0x1E6B65C", Offset = "0x1E6B65C", VA = "0x1E6B65C")]
	private bool CanReport()
	{
		return default(bool);
	}

	[Token(Token = "0x6005565")]
	[Address(RVA = "0x1E6B54C", Offset = "0x1E6B54C", VA = "0x1E6B54C")]
	private void setup()
	{
	}

	[Token(Token = "0x6005566")]
	[Address(RVA = "0x1E6B684", Offset = "0x1E6B684", VA = "0x1E6B684")]
	public void HandleLog(string log, string stack, LogType type)
	{
	}

	[Token(Token = "0x6005567")]
	[Address(RVA = "0x1E6B828", Offset = "0x1E6B828", VA = "0x1E6B828")]
	public void SpeedHackDataLog(string log, LogType type, SpeedHackLogData logData)
	{
	}

	[Token(Token = "0x6005568")]
	[Address(RVA = "0x1E6B9A0", Offset = "0x1E6B9A0", VA = "0x1E6B9A0")]
	public void InvalidRoomInfo(string log, string roomInfo)
	{
	}

	[Token(Token = "0x6005569")]
	[Address(RVA = "0x1E6BB10", Offset = "0x1E6BB10", VA = "0x1E6BB10")]
	public void HttpRequestFail(string log)
	{
	}

	[Token(Token = "0x600556A")]
	[Address(RVA = "0x1E6BC30", Offset = "0x1E6BC30", VA = "0x1E6BC30")]
	public void HttpRequestFail(string log, string detailLog)
	{
	}

	[Token(Token = "0x600556B")]
	[Address(RVA = "0x1E6BDA0", Offset = "0x1E6BDA0", VA = "0x1E6BDA0")]
	public void DisconnectedInGameFromPhoton(string log, string cause = "")
	{
	}

	[Token(Token = "0x600556C")]
	[Address(RVA = "0x1E6BED4", Offset = "0x1E6BED4", VA = "0x1E6BED4")]
	public void CaptureHackDetected()
	{
	}

	[Token(Token = "0x600556D")]
	[Address(RVA = "0x1E6C1FC", Offset = "0x1E6C1FC", VA = "0x1E6C1FC")]
	public void CapturePrefabLoadFail(string assetName)
	{
	}

	[Token(Token = "0x600556E")]
	[Address(RVA = "0x1E6C414", Offset = "0x1E6C414", VA = "0x1E6C414")]
	public void CaptureMessage(string log, ErrorLevel level)
	{
	}

	[Token(Token = "0x600556F")]
	[Address(RVA = "0x1E6C328", Offset = "0x1E6C328", VA = "0x1E6C328")]
	public void CaptureMessage(string log, ErrorLevel level, Dictionary<string, string> extra)
	{
	}

	[Token(Token = "0x6005570")]
	[Address(RVA = "0x1E6C0D8", Offset = "0x1E6C0D8", VA = "0x1E6C0D8")]
	private void AddDefaultInfo(Dictionary<string, string> dic, ErrorLevel level)
	{
	}

	[Token(Token = "0x6005571")]
	[Address(RVA = "0x1E6B7B4", Offset = "0x1E6B7B4", VA = "0x1E6B7B4")]
	private void AddDefaultInfo(Dictionary<string, string> dic)
	{
	}

	[Token(Token = "0x6005572")]
	[Address(RVA = "0x1E6B7BC", Offset = "0x1E6B7BC", VA = "0x1E6B7BC")]
	private void AddGameDataInfo(Dictionary<string, string> dic)
	{
	}

	[Token(Token = "0x6005573")]
	[Address(RVA = "0x1E6B7C0", Offset = "0x1E6B7C0", VA = "0x1E6B7C0")]
	private void AddGamePlayerInfo(Dictionary<string, string> dicExtra)
	{
	}

	[Token(Token = "0x6005574")]
	[Address(RVA = "0x1E6B950", Offset = "0x1E6B950", VA = "0x1E6B950")]
	private void AddSpeedHackLogData(SpeedHackLogData logData, Dictionary<string, string> dicExtra)
	{
	}

	[Token(Token = "0x6005575")]
	[Address(RVA = "0x1E6B7C4", Offset = "0x1E6B7C4", VA = "0x1E6B7C4")]
	private void AddHttpCommandInfo(Dictionary<string, string> dic)
	{
	}

	[Token(Token = "0x6005576")]
	[Address(RVA = "0x1E6B7C8", Offset = "0x1E6B7C8", VA = "0x1E6B7C8")]
	private void AddApplicationPause(Dictionary<string, string> dic)
	{
	}

	[Token(Token = "0x6005577")]
	[Address(RVA = "0x1E6B7CC", Offset = "0x1E6B7CC", VA = "0x1E6B7CC")]
	private void AddHttpRequestTimeOutInfo(Dictionary<string, string> dicExtra)
	{
	}

	[Token(Token = "0x6005578")]
	[Address(RVA = "0x1E6BED0", Offset = "0x1E6BED0", VA = "0x1E6BED0")]
	private void AddPhotonDisconnectState(Dictionary<string, string> dicExtra, string cause)
	{
	}

	[Token(Token = "0x6005579")]
	[Address(RVA = "0x1E6F2D8", Offset = "0x1E6F2D8", VA = "0x1E6F2D8")]
	public void CaptureInfo(string message, Dictionary<string, string> info)
	{
	}

	[Token(Token = "0x600557A")]
	[Address(RVA = "0x1E6B954", Offset = "0x1E6B954", VA = "0x1E6B954")]
	private void CaptureMessage(string message, ErrorLevel level, Dictionary<string, string> tags, object extra)
	{
	}

	[Token(Token = "0x600557B")]
	[Address(RVA = "0x1E6B7D0", Offset = "0x1E6B7D0", VA = "0x1E6B7D0")]
	private void CaptureUntiyLog(string log, string stack, LogType logType, [Optional] Dictionary<string, string> tags, [Optional] object extra)
	{
	}
}
