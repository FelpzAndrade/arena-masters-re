using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using NPA;
using SimpleJSON;

[Token(Token = "0x2000BF4")]
public class XNexonToyManager : INPListenerType, INPListener, INPRecvNotificationListener, INPGCMListener, INPBannerListener, INPEndingBannerListener, INPOnCloseListener, INPPlateListener, INPRuntimePermissionListener
{
	[Token(Token = "0x4003C62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private NPAccount account;

	[Token(Token = "0x4003C63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string SENDER_ID;

	[Token(Token = "0x4003C64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string m_npaCode;

	[Token(Token = "0x4003C65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private string m_npsn;

	[Token(Token = "0x4003C66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string m_loginID;

	[Token(Token = "0x4003C67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private string m_loginToken;

	[Token(Token = "0x4003C68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string m_country;

	[Token(Token = "0x4003C69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public string ARCHIEVEMENT_GET_CHAR_10;

	[Token(Token = "0x4003C6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string ARCHIEVEMENT_KILL_100;

	[Token(Token = "0x4003C6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public string ARCHIEVEMENT_DEATH_100;

	[Token(Token = "0x4003C6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string ARCHIEVEMENT_ASSIST_100;

	[Token(Token = "0x4003C6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public string ARCHIEVEMENT_WIN_100;

	[Token(Token = "0x4003C6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string ARCHIEVEMENT_SKYTOWER_100;

	[Token(Token = "0x4003C6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public string ARCHIEVEMENT_PROMOTION_10;

	[Token(Token = "0x4003C70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string ARCHIEVEMENT_FUSION_10;

	[Token(Token = "0x4003C71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public string ARCHIEVEMENT_GET_EPIC_50;

	[Token(Token = "0x4003C72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string ARCHIEVEMENT_GET_LEGEND_50;

	[Token(Token = "0x4003C73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public string ARCHIEVEMENT_GET_ANCIENT_50;

	[Token(Token = "0x4003C74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string m_shopProductId;

	[Token(Token = "0x4003C75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private NetCallback m_shopCallback;

	[Token(Token = "0x4003C76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_isUnregister;

	[Token(Token = "0x4003C77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Action m_hideNoticeAction;

	[Token(Token = "0x4003C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_isGetCountryFromServerResponse;

	[Token(Token = "0x4003C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool m_isGetUserInfoSuccess;

	[Token(Token = "0x4003C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public string msg;

	[Token(Token = "0x4003C7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool m_isLinkAccount;

	[Token(Token = "0x4003C7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool m_isLinkAccountCancel;

	[Token(Token = "0x4003C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Action m_connectCompleteAction;

	[Token(Token = "0x4003C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action m_disconnectCompleteAction;

	[Token(Token = "0x4003C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Action m_logoutCompleteAction;

	[Token(Token = "0x4003C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool m_isShowArchievementReserve;

	[Token(Token = "0x4003C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private XNexonCPQSystem CPQ__BackingField;

	[Token(Token = "0x17000C98")]
	public ToyManagerProcessState ProcesseState
	{
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x1ED5018", Offset = "0x1ED5018", VA = "0x1ED5018")]
		get
		{
			return default(ToyManagerProcessState);
		}
	}

	[Token(Token = "0x17000C99")]
	public XNexonCPQSystem CPQ
	{
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x1ED3FD4", Offset = "0x1ED3FD4", VA = "0x1ED3FD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005637")]
		[Address(RVA = "0x1ED5010", Offset = "0x1ED5010", VA = "0x1ED5010")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C9A")]
	public bool IsGetCountryFromServerResponse
	{
		[Token(Token = "0x6005638")]
		[Address(RVA = "0x1EBEED0", Offset = "0x1EBEED0", VA = "0x1EBEED0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000C9B")]
	public bool IsGetUserInfoSuccess
	{
		[Token(Token = "0x6005639")]
		[Address(RVA = "0x1EBE154", Offset = "0x1EBE154", VA = "0x1EBE154")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005634")]
	[Address(RVA = "0x1ED4D98", Offset = "0x1ED4D98", VA = "0x1ED4D98")]
	public XNexonToyManager()
	{
	}

	[Token(Token = "0x600563A")]
	[Address(RVA = "0x1ED50C8", Offset = "0x1ED50C8", VA = "0x1ED50C8")]
	public bool IsMobileDevice()
	{
		return default(bool);
	}

	[Token(Token = "0x600563B")]
	[Address(RVA = "0x1EB664C", Offset = "0x1EB664C", VA = "0x1EB664C")]
	public bool IsMobileAndroidDevice()
	{
		return default(bool);
	}

	[Token(Token = "0x600563C")]
	[Address(RVA = "0x1EB6684", Offset = "0x1EB6684", VA = "0x1EB6684")]
	public bool IsMobileIOSDevice()
	{
		return default(bool);
	}

	[Token(Token = "0x600563D")]
	[Address(RVA = "0x1EBE5A0", Offset = "0x1EBE5A0", VA = "0x1EBE5A0")]
	public void Reset()
	{
	}

	[Token(Token = "0x600563E")]
	[Address(RVA = "0x1EBEFC0", Offset = "0x1EBEFC0", VA = "0x1EBEFC0")]
	public void Init()
	{
	}

	[Token(Token = "0x600563F")]
	[Address(RVA = "0x1ED553C", Offset = "0x1ED553C", VA = "0x1ED553C")]
	public void Update(float delta)
	{
	}

	[Token(Token = "0x6005640")]
	[Address(RVA = "0x1ED50D0", Offset = "0x1ED50D0", VA = "0x1ED50D0")]
	private NPLocale GetInGameLocale()
	{
		return default(NPLocale);
	}

	[Token(Token = "0x6005641")]
	[Address(RVA = "0x1ED5564", Offset = "0x1ED5564", VA = "0x1ED5564")]
	private NPLocale GetNPLocale()
	{
		return default(NPLocale);
	}

	[Token(Token = "0x6005642")]
	[Address(RVA = "0x1ED5590", Offset = "0x1ED5590", VA = "0x1ED5590")]
	public bool IsFacebookLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x6005643")]
	[Address(RVA = "0x1EBEA5C", Offset = "0x1EBEA5C", VA = "0x1EBEA5C")]
	public NPLoginType GetLoginType()
	{
		return default(NPLoginType);
	}

	[Token(Token = "0x6005644")]
	[Address(RVA = "0x1EBACA4", Offset = "0x1EBACA4", VA = "0x1EBACA4")]
	public string GetNPSN()
	{
		return null;
	}

	[Token(Token = "0x6005645")]
	[Address(RVA = "0x1EBB134", Offset = "0x1EBB134", VA = "0x1EBB134")]
	public string GetNPACode()
	{
		return null;
	}

	[Token(Token = "0x6005646")]
	[Address(RVA = "0x1ED55B0", Offset = "0x1ED55B0", VA = "0x1ED55B0")]
	public string GetLoginID()
	{
		return null;
	}

	[Token(Token = "0x6005647")]
	[Address(RVA = "0x1EBAEEC", Offset = "0x1EBAEEC", VA = "0x1EBAEEC")]
	public string GetLoginToken()
	{
		return null;
	}

	[Token(Token = "0x6005648")]
	[Address(RVA = "0x1EB6584", Offset = "0x1EB6584", VA = "0x1EB6584")]
	public bool IsJapan()
	{
		return default(bool);
	}

	[Token(Token = "0x6005649")]
	[Address(RVA = "0x1ED55B8", Offset = "0x1ED55B8", VA = "0x1ED55B8")]
	public bool IsKorea()
	{
		return default(bool);
	}

	[Token(Token = "0x600564A")]
	[Address(RVA = "0x1ED5680", Offset = "0x1ED5680", VA = "0x1ED5680")]
	public bool IsTaiwan()
	{
		return default(bool);
	}

	[Token(Token = "0x600564B")]
	[Address(RVA = "0x1EBABB0", Offset = "0x1EBABB0", VA = "0x1EBABB0")]
	public string GetCountry()
	{
		return null;
	}

	[Token(Token = "0x600564C")]
	[Address(RVA = "0x1ED5880", Offset = "0x1ED5880", VA = "0x1ED5880")]
	public void SetCountryConsoleCommand(string country)
	{
	}

	[Token(Token = "0x600564D")]
	[Address(RVA = "0x1ED5748", Offset = "0x1ED5748", VA = "0x1ED5748")]
	public string GetCountryFromType()
	{
		return null;
	}

	[Token(Token = "0x600564E")]
	[Address(RVA = "0x1ED5998", Offset = "0x1ED5998", VA = "0x1ED5998")]
	internal bool IsNXComLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x600564F")]
	[Address(RVA = "0x1EBB644", Offset = "0x1EBB644", VA = "0x1EBB644")]
	public bool IsLogined()
	{
		return default(bool);
	}

	[Token(Token = "0x6005650")]
	[Address(RVA = "0x1ED59B0", Offset = "0x1ED59B0", VA = "0x1ED59B0")]
	public bool IsAccountLogined()
	{
		return default(bool);
	}

	[Token(Token = "0x6005651")]
	[Address(RVA = "0x1ED59F4", Offset = "0x1ED59F4", VA = "0x1ED59F4")]
	public bool IsLinkAccountCancel()
	{
		return default(bool);
	}

	[Token(Token = "0x6005652")]
	[Address(RVA = "0x1ED59FC", Offset = "0x1ED59FC", VA = "0x1ED59FC")]
	public void ShowSettlementFund(string itemName, string itemPrice, string shopProductId, NetCallback shopCallback)
	{
	}

	[Token(Token = "0x6005653")]
	[Address(RVA = "0x1ED5BB0", Offset = "0x1ED5BB0", VA = "0x1ED5BB0")]
	public void GetCountryFromServer()
	{
	}

	[Token(Token = "0x6005654")]
	[Address(RVA = "0x1ED5BE0", Offset = "0x1ED5BE0", VA = "0x1ED5BE0")]
	public void Login()
	{
	}

	[Token(Token = "0x6005655")]
	[Address(RVA = "0x1ED5CA8", Offset = "0x1ED5CA8", VA = "0x1ED5CA8")]
	public void ShowAccountMenu()
	{
	}

	[Token(Token = "0x6005656")]
	[Address(RVA = "0x1ED5D78", Offset = "0x1ED5D78", VA = "0x1ED5D78")]
	public void GuestLogin()
	{
	}

	[Token(Token = "0x6005657")]
	[Address(RVA = "0x1EBB664", Offset = "0x1EBB664", VA = "0x1EBB664")]
	public void Logout()
	{
	}

	[Token(Token = "0x6005658")]
	[Address(RVA = "0x1EBE15C", Offset = "0x1EBE15C", VA = "0x1EBE15C")]
	public void GetUserInfo()
	{
	}

	[Token(Token = "0x6005659")]
	[Address(RVA = "0x1ED5E44", Offset = "0x1ED5E44", VA = "0x1ED5E44")]
	public void ShowNotice(Action hideNoticeAction)
	{
	}

	[Token(Token = "0x600565A")]
	[Address(RVA = "0x1EB6654", Offset = "0x1EB6654", VA = "0x1EB6654")]
	public void ShowBanner(string groupID)
	{
	}

	[Token(Token = "0x600565B")]
	[Address(RVA = "0x1ED5E48", Offset = "0x1ED5E48", VA = "0x1ED5E48")]
	public bool IsEnableGamePlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x600565C")]
	[Address(RVA = "0x1EBF654", Offset = "0x1EBF654", VA = "0x1EBF654")]
	public void ConnectGamePlatform([Optional] Action connectCompleteAction)
	{
	}

	[Token(Token = "0x600565D")]
	[Address(RVA = "0x1ED5E74", Offset = "0x1ED5E74", VA = "0x1ED5E74")]
	public void DisconnectGamePlatform([Optional] Action disConnectCompleteAction)
	{
	}

	[Token(Token = "0x600565E")]
	[Address(RVA = "0x1ED5EAC", Offset = "0x1ED5EAC", VA = "0x1ED5EAC")]
	public void LogoutGamePlatform([Optional] Action logoutCompleteAction)
	{
	}

	[Token(Token = "0x600565F")]
	[Address(RVA = "0x1ED5EE4", Offset = "0x1ED5EE4", VA = "0x1ED5EE4")]
	public void ShowArchievement()
	{
	}

	[Token(Token = "0x6005660")]
	[Address(RVA = "0x1ED5F44", Offset = "0x1ED5F44", VA = "0x1ED5F44")]
	public void UnlockAchievement(string achievementID)
	{
	}

	[Token(Token = "0x6005661")]
	[Address(RVA = "0x1ED5F88", Offset = "0x1ED5F88", VA = "0x1ED5F88")]
	public void ShowPlate()
	{
	}

	[Token(Token = "0x6005662")]
	[Address(RVA = "0x1ED6380", Offset = "0x1ED6380", VA = "0x1ED6380")]
	public void ShowWebView(string title, string url)
	{
	}

	[Token(Token = "0x6005663")]
	[Address(RVA = "0x1ED63AC", Offset = "0x1ED63AC", VA = "0x1ED63AC")]
	public void ShowEndingBanner()
	{
	}

	[Token(Token = "0x6005664")]
	[Address(RVA = "0x1ED63C4", Offset = "0x1ED63C4", VA = "0x1ED63C4")]
	public void SetPushAgreement(bool isAgreement)
	{
	}

	[Token(Token = "0x6005665")]
	[Address(RVA = "0x1ED6558", Offset = "0x1ED6558", VA = "0x1ED6558")]
	public void UnregisterToyService()
	{
	}

	[Token(Token = "0x6005666")]
	[Address(RVA = "0x1ED6590", Offset = "0x1ED6590", VA = "0x1ED6590")]
	public void RecoverUser()
	{
	}

	[Token(Token = "0x6005667")]
	[Address(RVA = "0x1ED65C0", Offset = "0x1ED65C0", VA = "0x1ED65C0")]
	public void LocalPushTest()
	{
	}

	[Token(Token = "0x6005668")]
	[Address(RVA = "0x1ED6738", Offset = "0x1ED6738", VA = "0x1ED6738")]
	public void ResisterLocalPush(int id, int year, int month, int day, int hour, int minute, int sec, string title, string desc)
	{
	}

	[Token(Token = "0x6005669")]
	[Address(RVA = "0x1ED6A68", Offset = "0x1ED6A68", VA = "0x1ED6A68")]
	public void RequestPermissions()
	{
	}

	[Token(Token = "0x600566A")]
	[Address(RVA = "0x1ED6B94", Offset = "0x1ED6B94", VA = "0x1ED6B94")]
	public void CancelLocalPush(int id)
	{
	}

	[Token(Token = "0x600566B")]
	[Address(RVA = "0x1EBAC78", Offset = "0x1EBAC78", VA = "0x1EBAC78")]
	public NPLocale GetLocaleType()
	{
		return default(NPLocale);
	}

	[Token(Token = "0x600566C")]
	[Address(RVA = "0x1ED5980", Offset = "0x1ED5980", VA = "0x1ED5980")]
	private NPCountry GetCountryType()
	{
		return default(NPCountry);
	}

	[Token(Token = "0x600566D")]
	[Address(RVA = "0x1ED6BC0", Offset = "0x1ED6BC0", VA = "0x1ED6BC0", Slot = "4")]
	public void OnResult(NPResult npResult)
	{
	}

	[Token(Token = "0x600566E")]
	[Address(RVA = "0x1ED9A3C", Offset = "0x1ED9A3C", VA = "0x1ED9A3C")]
	private void OnResult_RecoverUser(int errorCode)
	{
	}

	[Token(Token = "0x600566F")]
	[Address(RVA = "0x1ED9650", Offset = "0x1ED9650", VA = "0x1ED9650")]
	private void OnResult_Unregister(int errorCode)
	{
	}

	[Token(Token = "0x6005670")]
	[Address(RVA = "0x1ED9EA8", Offset = "0x1ED9EA8", VA = "0x1ED9EA8")]
	private void OnResult_GetCountry(NPResult npResult, int errorCode)
	{
	}

	[Token(Token = "0x6005671")]
	[Address(RVA = "0x1ED9E88", Offset = "0x1ED9E88", VA = "0x1ED9E88")]
	private void OnResult_LogoutGamePlatform(int errorCode)
	{
	}

	[Token(Token = "0x6005672")]
	[Address(RVA = "0x1ED9D3C", Offset = "0x1ED9D3C", VA = "0x1ED9D3C")]
	private void OnResult_ConnectGamePlatform(int errorCode)
	{
	}

	[Token(Token = "0x6005673")]
	[Address(RVA = "0x1ED9270", Offset = "0x1ED9270", VA = "0x1ED9270")]
	private void OnResult_Logout(int errorCode, string tmpJson)
	{
	}

	[Token(Token = "0x6005674")]
	[Address(RVA = "0x1EDA310", Offset = "0x1EDA310", VA = "0x1EDA310")]
	private void SetToyPushAgreementCohort(NPResult npResult)
	{
	}

	[Token(Token = "0x6005675")]
	[Address(RVA = "0x1ED8078", Offset = "0x1ED8078", VA = "0x1ED8078")]
	private void OnResult_GetUser(NPResult npResult, int errorCode, string tmpJson)
	{
	}

	[Token(Token = "0x6005676")]
	[Address(RVA = "0x1ED729C", Offset = "0x1ED729C", VA = "0x1ED729C")]
	private void OnResult_Enter(int errorCode)
	{
	}

	[Token(Token = "0x6005677")]
	[Address(RVA = "0x1ED7998", Offset = "0x1ED7998", VA = "0x1ED7998")]
	private void OnResult_Login(int errorCode, string tmpJson)
	{
	}

	[Token(Token = "0x6005678")]
	[Address(RVA = "0x1ED7DB0", Offset = "0x1ED7DB0", VA = "0x1ED7DB0")]
	private void OnResult_LinkAccount(int errorCode, string tmpJson)
	{
	}

	[Token(Token = "0x6005679")]
	[Address(RVA = "0x1EDA000", Offset = "0x1EDA000", VA = "0x1EDA000")]
	private void OnResult_GetPolicy(int errorCode)
	{
	}

	[Token(Token = "0x600567A")]
	[Address(RVA = "0x1ED9584", Offset = "0x1ED9584", VA = "0x1ED9584")]
	private void LoadTitleScene()
	{
	}

	[Token(Token = "0x600567B")]
	[Address(RVA = "0x1EDA514", Offset = "0x1EDA514", VA = "0x1EDA514", Slot = "5")]
	public void OnRecvNotification(JSONNode recvNotification)
	{
	}

	[Token(Token = "0x600567C")]
	[Address(RVA = "0x1EDA5F8", Offset = "0x1EDA5F8", VA = "0x1EDA5F8", Slot = "10")]
	public void OnEndingBannerClick(string landInfo)
	{
	}

	[Token(Token = "0x600567D")]
	[Address(RVA = "0x1EDA6E4", Offset = "0x1EDA6E4", VA = "0x1EDA6E4", Slot = "11")]
	public void OnEndingBannerFailed(NPResult npResult)
	{
	}

	[Token(Token = "0x600567E")]
	[Address(RVA = "0x1EDA6E8", Offset = "0x1EDA6E8", VA = "0x1EDA6E8", Slot = "12")]
	public void OnEndingBannerDismiss()
	{
	}

	[Token(Token = "0x600567F")]
	[Address(RVA = "0x1EDA6EC", Offset = "0x1EDA6EC", VA = "0x1EDA6EC", Slot = "13")]
	public void OnEndingBannerExit()
	{
	}

	[Token(Token = "0x6005680")]
	[Address(RVA = "0x1EDA6F8", Offset = "0x1EDA6F8", VA = "0x1EDA6F8", Slot = "7")]
	public void OnBannerClick(string landInfo)
	{
	}

	[Token(Token = "0x6005681")]
	[Address(RVA = "0x1EDA7C4", Offset = "0x1EDA7C4", VA = "0x1EDA7C4", Slot = "8")]
	public void OnBannerFailed(NPResult npResult)
	{
	}

	[Token(Token = "0x6005682")]
	[Address(RVA = "0x1EDA820", Offset = "0x1EDA820", VA = "0x1EDA820", Slot = "9")]
	public void OnBannerDismiss()
	{
	}

	[Token(Token = "0x6005683")]
	[Address(RVA = "0x1EDA8A0", Offset = "0x1EDA8A0", VA = "0x1EDA8A0", Slot = "14")]
	public void OnClose(NPCloseResult closeResult)
	{
	}

	[Token(Token = "0x6005684")]
	[Address(RVA = "0x1EDA9C0", Offset = "0x1EDA9C0", VA = "0x1EDA9C0", Slot = "15")]
	public void OnActionPerformedResult(NPResult npResult)
	{
	}

	[Token(Token = "0x6005685")]
	[Address(RVA = "0x1EDAB90", Offset = "0x1EDAB90", VA = "0x1EDAB90", Slot = "6")]
	public void OnGCMResult(int errorCode)
	{
	}

	[Token(Token = "0x6005686")]
	[Address(RVA = "0x1EDAC84", Offset = "0x1EDAC84", VA = "0x1EDAC84", Slot = "16")]
	public void OnRequestPermissionsResult(int requestCode, string[] permissions, int[] grantResults)
	{
	}
}
