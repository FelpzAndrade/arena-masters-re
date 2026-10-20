using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200039C")]
public class XBroadcastManager
{
	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0x8")]
	private Queue<CSBroadcastMessage> m_Message;

	[Token(Token = "0x40012C9")]
	[FieldOffset(Offset = "0xC")]
	private PeriodUpdater updaterPost;

	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0x10")]
	private PeriodUpdater updaterPostMaintenance;

	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0x14")]
	private PeriodUpdaterPuase updaterNotify;

	[Token(Token = "0x40012CC")]
	[FieldOffset(Offset = "0x18")]
	private long GetLastUTCTimeMS__BackingField;

	[Token(Token = "0x170004F9")]
	public long GetLastUTCTimeMS
	{
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x1A949B0", Offset = "0x1A949B0", VA = "0x1A949B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x1A949B8", Offset = "0x1A949B8", VA = "0x1A949B8")]
		set
		{
		}
	}

	[Token(Token = "0x6001D9C")]
	[Address(RVA = "0x1A946E4", Offset = "0x1A946E4", VA = "0x1A946E4")]
	public XBroadcastManager()
	{
	}

	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x1A949C8", Offset = "0x1A949C8", VA = "0x1A949C8")]
	internal void Update(float delta)
	{
	}

	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x1A94C38", Offset = "0x1A94C38", VA = "0x1A94C38")]
	public void PostBroadcastProcess()
	{
	}

	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x1A94E88", Offset = "0x1A94E88", VA = "0x1A94E88")]
	private void PostMaintenanceProcess()
	{
	}

	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x1A95074", Offset = "0x1A95074", VA = "0x1A95074")]
	private void UpdateBroadcastMessage()
	{
	}

	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x1A951C0", Offset = "0x1A951C0", VA = "0x1A951C0")]
	private void OnBroadcastMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x1A95278", Offset = "0x1A95278", VA = "0x1A95278")]
	private void OnNotifyMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x1A97438", Offset = "0x1A97438", VA = "0x1A97438")]
	private void ShowNotifyMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x1A9746C", Offset = "0x1A9746C", VA = "0x1A9746C")]
	private void ShowNotifyMessage(CSBroadcastMessage message, string param1)
	{
	}

	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x1A97558", Offset = "0x1A97558", VA = "0x1A97558")]
	private void ShowNotifyMessage(CSBroadcastMessage message, string param1, string param2)
	{
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x1A97658", Offset = "0x1A97658", VA = "0x1A97658")]
	private void ShowNotifyMessage(CSBroadcastMessage message, string param1, string param2, string param3)
	{
	}

	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x1A9623C", Offset = "0x1A9623C", VA = "0x1A9623C")]
	private void OnMaintenanceMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x1A97864", Offset = "0x1A97864", VA = "0x1A97864")]
	private void ShowMaintenanceMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x1A97898", Offset = "0x1A97898", VA = "0x1A97898")]
	private void ShowMaintenanceMessage(CSBroadcastMessage message, string param1)
	{
	}

	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0x1A97984", Offset = "0x1A97984", VA = "0x1A97984")]
	private void ShowMaintenanceMessage(CSBroadcastMessage message, string param1, string param2)
	{
	}

	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0x1A97A84", Offset = "0x1A97A84", VA = "0x1A97A84")]
	private void ShowMaintenanceMessage(CSBroadcastMessage message, string param1, string param2, string param3)
	{
	}

	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0x1A95A68", Offset = "0x1A95A68", VA = "0x1A95A68")]
	private void OnSystemMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x1A97B8C", Offset = "0x1A97B8C", VA = "0x1A97B8C")]
	private void ShowSystemMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x1A97760", Offset = "0x1A97760", VA = "0x1A97760")]
	private void AddNoticeMsgToPhotonChat(string msg)
	{
	}

	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x1A97EB4", Offset = "0x1A97EB4", VA = "0x1A97EB4")]
	private void AddShowoffToPhotonChat(string msg, int count)
	{
	}

	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x1A97BC0", Offset = "0x1A97BC0", VA = "0x1A97BC0")]
	private void ShowSystemMessage(CSBroadcastMessage message, string param1)
	{
	}

	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x1A97CAC", Offset = "0x1A97CAC", VA = "0x1A97CAC")]
	private void ShowSystemMessage(CSBroadcastMessage message, string param1, string param2)
	{
	}

	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x1A97DAC", Offset = "0x1A97DAC", VA = "0x1A97DAC")]
	private void ShowSystemMessage(CSBroadcastMessage message, string param1, string param2, string param3)
	{
	}

	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x1A96A10", Offset = "0x1A96A10", VA = "0x1A96A10")]
	private void OnUserWinStreakMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x1A96D58", Offset = "0x1A96D58", VA = "0x1A96D58")]
	private void OnUserWinStopMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x1A97128", Offset = "0x1A97128", VA = "0x1A97128")]
	private void OnClanWinStreakMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0x1A98074", Offset = "0x1A98074", VA = "0x1A98074")]
	public void PushMessage(CSBroadcastMessage message)
	{
	}

	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x1A9811C", Offset = "0x1A9811C", VA = "0x1A9811C")]
	public void PushMessageList(List<CSBroadcastMessage> liMessage)
	{
	}

	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x1A950DC", Offset = "0x1A950DC", VA = "0x1A950DC")]
	public bool TryPopMessage(out CSBroadcastMessage message)
	{
		message = default;
		return default(bool);
	}

	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x1A98230", Offset = "0x1A98230", VA = "0x1A98230")]
	public int MessageCount()
	{
		return default(int);
	}

	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x1A982C8", Offset = "0x1A982C8", VA = "0x1A982C8")]
	private void _003CXBroadcastManager_003Em__9B(float deltaTime)
	{
	}

	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x1A982CC", Offset = "0x1A982CC", VA = "0x1A982CC")]
	private void _003CXBroadcastManager_003Em__9C(float deltaTime)
	{
	}

	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x1A982D0", Offset = "0x1A982D0", VA = "0x1A982D0")]
	private void _003CXBroadcastManager_003Em__9D(float deltaTime)
	{
	}

	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x1A982D4", Offset = "0x1A982D4", VA = "0x1A982D4")]
	private void _003CPostBroadcastProcess_003Em__9E(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x1A984C4", Offset = "0x1A984C4", VA = "0x1A984C4")]
	private void _003CPostMaintenanceProcess_003Em__9F(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
