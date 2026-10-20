using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

namespace NPA
{
	[Token(Token = "0x20010AB")]
	public class NPAccount
	{
		[Token(Token = "0x20010AC")]
		private class Nested
		{
			[Token(Token = "0x4005ABB")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly NPAccount instance;

			[Token(Token = "0x6007DD0")]
			[Address(RVA = "0x11DA6B0", Offset = "0x11DA6B0", VA = "0x11DA6B0")]
			public Nested()
			{
			}

			[Token(Token = "0x6007DD1")]
			[Address(RVA = "0x11DA6B8", Offset = "0x11DA6B8", VA = "0x11DA6B8")]
			static Nested()
			{
			}
		}

		[Token(Token = "0x4005AAF")]
		private const bool isDebug = true;

		[Token(Token = "0x4005AB0")]
		[FieldOffset(Offset = "0x0")]
		public static string FRIEND_FILTER_TYPE_FRIENDS;

		[Token(Token = "0x4005AB1")]
		[FieldOffset(Offset = "0x4")]
		public static string FRIEND_FILTER_TYPE_INVITES;

		[Token(Token = "0x4005AB2")]
		[FieldOffset(Offset = "0x8")]
		public static string FRIEND_FILTER_TYPE_ALL;

		[Token(Token = "0x4005AB3")]
		[FieldOffset(Offset = "0xC")]
		public static int LOCAL_PUSH_TYPE_ON;

		[Token(Token = "0x4005AB4")]
		[FieldOffset(Offset = "0x10")]
		public static int LOCAL_PUSH_TYPE_AFTER;

		[Token(Token = "0x4005AB5")]
		[FieldOffset(Offset = "0x14")]
		public static int LOCAL_PUSH_TYPE_NOW;

		[Token(Token = "0x4005AB6")]
		[FieldOffset(Offset = "0x8")]
		public string GAMEOBJECT_NAME;

		[Token(Token = "0x4005AB7")]
		[FieldOffset(Offset = "0xC")]
		public GameObject mGameObject;

		[Token(Token = "0x4005AB8")]
		[FieldOffset(Offset = "0x18")]
		public static string serviceID;

		[Token(Token = "0x4005AB9")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject account;

		[Token(Token = "0x4005ABA")]
		[FieldOffset(Offset = "0x1C")]
		private static int incrementCallIdValue;

		[Token(Token = "0x17000F6B")]
		public static NPAccount Instance
		{
			[Token(Token = "0x6007D45")]
			[Address(RVA = "0x11C8CE8", Offset = "0x11C8CE8", VA = "0x11C8CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007D43")]
		[Address(RVA = "0x11C83C0", Offset = "0x11C83C0", VA = "0x11C83C0")]
		private NPAccount()
		{
		}

		[Token(Token = "0x6007D46")]
		[Address(RVA = "0x11C8D98", Offset = "0x11C8D98", VA = "0x11C8D98")]
		private void setPushListener(INPRecvNotificationListener listener)
		{
		}

		[Token(Token = "0x6007D47")]
		[Address(RVA = "0x11C8E3C", Offset = "0x11C8E3C", VA = "0x11C8E3C")]
		private void setGCMListener(INPGCMListener listener)
		{
		}

		[Token(Token = "0x6007D48")]
		[Address(RVA = "0x11C8EE0", Offset = "0x11C8EE0", VA = "0x11C8EE0")]
		private void setListener(INPListenerType listener, string callId)
		{
		}

		[Token(Token = "0x6007D49")]
		[Address(RVA = "0x11C9044", Offset = "0x11C9044", VA = "0x11C9044")]
		public void callJavaMethod(string method, string args, string callId)
		{
		}

		[Token(Token = "0x6007D4A")]
		[Address(RVA = "0x11C94B8", Offset = "0x11C94B8", VA = "0x11C94B8")]
		public void callIOSMethod(string method, string args, string callId)
		{
		}

		[Token(Token = "0x6007D4B")]
		[Address(RVA = "0x11C94BC", Offset = "0x11C94BC", VA = "0x11C94BC")]
		public bool isAuthCrashError(int errorCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6007D4C")]
		[Address(RVA = "0x11C95DC", Offset = "0x11C95DC", VA = "0x11C95DC")]
		public void pushInit(INPRecvNotificationListener pushListener, string senderID = "")
		{
		}

		[Token(Token = "0x6007D4D")]
		[Address(RVA = "0x11C9600", Offset = "0x11C9600", VA = "0x11C9600")]
		public void pushInit(INPRecvNotificationListener pushListener, INPGCMListener gcmListener, bool isSkip, string senderID = "")
		{
		}

		[Token(Token = "0x6007D4E")]
		[Address(RVA = "0x11C9878", Offset = "0x11C9878", VA = "0x11C9878")]
		public void RegisterPush(INPListener listener)
		{
		}

		[Token(Token = "0x6007D4F")]
		[Address(RVA = "0x11C9AC0", Offset = "0x11C9AC0", VA = "0x11C9AC0")]
		public void UnregisterPush(INPListener listener)
		{
		}

		[Token(Token = "0x6007D50")]
		[Address(RVA = "0x11C9BC0", Offset = "0x11C9BC0", VA = "0x11C9BC0")]
		public void Login(INPListener listener)
		{
		}

		[Token(Token = "0x6007D51")]
		[Address(RVA = "0x11C9CC0", Offset = "0x11C9CC0", VA = "0x11C9CC0")]
		public void Login(NPLoginType loginType, INPListener listener)
		{
		}

		[Token(Token = "0x6007D52")]
		[Address(RVA = "0x11C9E90", Offset = "0x11C9E90", VA = "0x11C9E90")]
		public void LoginForKakao(string kakaoID, string accessToken, INPListener listener)
		{
		}

		[Token(Token = "0x6007D53")]
		[Address(RVA = "0x11CA088", Offset = "0x11CA088", VA = "0x11CA088")]
		public void UnregisterService(INPListener listener)
		{
		}

		[Token(Token = "0x6007D54")]
		[Address(RVA = "0x11CA188", Offset = "0x11CA188", VA = "0x11CA188")]
		public void RecoverUser(INPListener listener)
		{
		}

		[Token(Token = "0x6007D55")]
		[Address(RVA = "0x11CA288", Offset = "0x11CA288", VA = "0x11CA288")]
		public void Logout(INPListener listener)
		{
		}

		[Token(Token = "0x6007D56")]
		[Address(RVA = "0x11CA388", Offset = "0x11CA388", VA = "0x11CA388")]
		public void GetUserInfo(INPListener listener)
		{
		}

		[Token(Token = "0x6007D57")]
		[Address(RVA = "0x11CA488", Offset = "0x11CA488", VA = "0x11CA488")]
		private bool isSnsType(NPLoginType loginType)
		{
			return default(bool);
		}

		[Token(Token = "0x6007D58")]
		[Address(RVA = "0x11CA49C", Offset = "0x11CA49C", VA = "0x11CA49C")]
		public void GetFriends(int next, string filterType, INPListener listener)
		{
		}

		[Token(Token = "0x6007D59")]
		[Address(RVA = "0x11CA9DC", Offset = "0x11CA9DC", VA = "0x11CA9DC")]
		public void GetFriends(NPSnsType snsType, int next, string filterType, INPListener listener)
		{
		}

		[Token(Token = "0x6007D5A")]
		[Address(RVA = "0x11CAC6C", Offset = "0x11CAC6C", VA = "0x11CAC6C")]
		public void Share(string title, string content, string url)
		{
		}

		[Token(Token = "0x6007D5B")]
		[Address(RVA = "0x11CAEE4", Offset = "0x11CAEE4", VA = "0x11CAEE4")]
		public void ShowBanner(string groupCode, INPBannerListener bannerListener)
		{
		}

		[Token(Token = "0x6007D5C")]
		[Address(RVA = "0x11CB090", Offset = "0x11CB090", VA = "0x11CB090")]
		public void GetBanners(string groupCode, INPListener listener)
		{
		}

		[Token(Token = "0x6007D5D")]
		[Address(RVA = "0x11CB23C", Offset = "0x11CB23C", VA = "0x11CB23C")]
		public void NXLogin(string id, string pw, INPListener listener)
		{
		}

		[Token(Token = "0x6007D5E")]
		[Address(RVA = "0x11CB434", Offset = "0x11CB434", VA = "0x11CB434")]
		public void Post(string msg, string description, string link, INPListener listener)
		{
		}

		[Token(Token = "0x6007D5F")]
		[Address(RVA = "0x11CB67C", Offset = "0x11CB67C", VA = "0x11CB67C")]
		public void PostImage(string msg, string imageURL, INPListener listener)
		{
		}

		[Token(Token = "0x6007D60")]
		[Address(RVA = "0x11CB874", Offset = "0x11CB874", VA = "0x11CB874")]
		public void DismissEndingBanner()
		{
		}

		[Token(Token = "0x6007D61")]
		[Address(RVA = "0x11CB958", Offset = "0x11CB958", VA = "0x11CB958")]
		public void GetNexonSN(INPListener listener)
		{
		}

		[Token(Token = "0x6007D62")]
		[Address(RVA = "0x11CA77C", Offset = "0x11CA77C", VA = "0x11CA77C")]
		public NPLoginType GetLoginType()
		{
			return default(NPLoginType);
		}

		[Token(Token = "0x6007D63")]
		[Address(RVA = "0x11CBA58", Offset = "0x11CBA58", VA = "0x11CBA58")]
		public void GetLoginType(INPListener listener)
		{
		}

		[Token(Token = "0x6007D64")]
		[Address(RVA = "0x11CBB58", Offset = "0x11CBB58", VA = "0x11CBB58")]
		public void ShowNotice()
		{
		}

		[Token(Token = "0x6007D65")]
		[Address(RVA = "0x11CBC3C", Offset = "0x11CBC3C", VA = "0x11CBC3C")]
		public void ShowNotice(INPOnCloseListener closeListener)
		{
		}

		[Token(Token = "0x6007D66")]
		[Address(RVA = "0x11CBCF8", Offset = "0x11CBCF8", VA = "0x11CBCF8")]
		public void ShowFAQ()
		{
		}

		[Token(Token = "0x6007D67")]
		[Address(RVA = "0x11CBDDC", Offset = "0x11CBDDC", VA = "0x11CBDDC")]
		public void ShowWeb(string title, string url)
		{
		}

		[Token(Token = "0x6007D68")]
		[Address(RVA = "0x11CC008", Offset = "0x11CC008", VA = "0x11CC008")]
		public void ShowWeb(string title, string url, string postData)
		{
		}

		[Token(Token = "0x6007D69")]
		[Address(RVA = "0x11CC2E0", Offset = "0x11CC2E0", VA = "0x11CC2E0")]
		public void ShowEventWeb(string url)
		{
		}

		[Token(Token = "0x6007D6A")]
		[Address(RVA = "0x11CC4C0", Offset = "0x11CC4C0", VA = "0x11CC4C0")]
		public void ShowEndingBanner(INPEndingBannerListener endingBannerListener)
		{
		}

		[Token(Token = "0x6007D6B")]
		[Address(RVA = "0x11CC5C0", Offset = "0x11CC5C0", VA = "0x11CC5C0")]
		public void ShowInputCoupon(INPListener listener)
		{
		}

		[Token(Token = "0x6007D6C")]
		[Address(RVA = "0x11CC6C0", Offset = "0x11CC6C0", VA = "0x11CC6C0")]
		public void ShowCustomerService(NPCSInfo param)
		{
		}

		[Token(Token = "0x6007D6D")]
		[Address(RVA = "0x11CCE6C", Offset = "0x11CCE6C", VA = "0x11CCE6C")]
		public void ShowCustomerService(NPCSInfo param, INPPlateListener plateListener)
		{
		}

		[Token(Token = "0x6007D6E")]
		[Address(RVA = "0x11CD6A0", Offset = "0x11CD6A0", VA = "0x11CD6A0")]
		public void ShowHelpCenter(NPCSInfo param)
		{
		}

		[Token(Token = "0x6007D6F")]
		[Address(RVA = "0x11CDE4C", Offset = "0x11CDE4C", VA = "0x11CDE4C")]
		public void SendEvent(string category, string action, string label, string value)
		{
		}

		[Token(Token = "0x6007D70")]
		[Address(RVA = "0x11CE110", Offset = "0x11CE110", VA = "0x11CE110")]
		public void SendScreen(string screenName)
		{
		}

		[Token(Token = "0x6007D71")]
		[Address(RVA = "0x11CE2F0", Offset = "0x11CE2F0", VA = "0x11CE2F0")]
		public void SendEcommerceTransaction(string transactionID, string affiliation, double revenue, double tax, double shipping, string currencyCode)
		{
		}

		[Token(Token = "0x6007D72")]
		[Address(RVA = "0x11CE6C0", Offset = "0x11CE6C0", VA = "0x11CE6C0")]
		public void SendEcommerceItem(string transactionID, string name, string sku, string category, double price, long quantity, string currencyCode)
		{
		}

		[Token(Token = "0x6007D73")]
		[Address(RVA = "0x11CEAC0", Offset = "0x11CEAC0", VA = "0x11CEAC0")]
		public void StartSession()
		{
		}

		[Token(Token = "0x6007D74")]
		[Address(RVA = "0x11CEBA4", Offset = "0x11CEBA4", VA = "0x11CEBA4")]
		public void EndSession()
		{
		}

		[Token(Token = "0x6007D75")]
		[Address(RVA = "0x11CEC88", Offset = "0x11CEC88", VA = "0x11CEC88")]
		public void setCountry(NPCountry country)
		{
		}

		[Token(Token = "0x6007D76")]
		[Address(RVA = "0x11CEE8C", Offset = "0x11CEE8C", VA = "0x11CEE8C")]
		public NPCountry getCountry()
		{
			return default(NPCountry);
		}

		[Token(Token = "0x6007D77")]
		[Address(RVA = "0x11CF0EC", Offset = "0x11CF0EC", VA = "0x11CF0EC")]
		public string GetCountryLetterCode()
		{
			return null;
		}

		[Token(Token = "0x6007D78")]
		[Address(RVA = "0x11CF364", Offset = "0x11CF364", VA = "0x11CF364")]
		public void setLocale(NPLocale locale)
		{
		}

		[Token(Token = "0x6007D79")]
		[Address(RVA = "0x11CF568", Offset = "0x11CF568", VA = "0x11CF568")]
		public NPLocale getLocale()
		{
			return default(NPLocale);
		}

		[Token(Token = "0x6007D7A")]
		[Address(RVA = "0x11CF920", Offset = "0x11CF920", VA = "0x11CF920")]
		public void dispatchLocalPush(NPNotificationData data)
		{
		}

		[Token(Token = "0x6007D7B")]
		[Address(RVA = "0x11D0184", Offset = "0x11D0184", VA = "0x11D0184")]
		public void cancelLocalPush(int notificationID)
		{
		}

		[Token(Token = "0x6007D7C")]
		[Address(RVA = "0x11D0388", Offset = "0x11D0388", VA = "0x11D0388")]
		public void cancelAllLocalPush()
		{
		}

		[Token(Token = "0x6007D7D")]
		[Address(RVA = "0x11D046C", Offset = "0x11D046C", VA = "0x11D046C")]
		public void showAchievement(INPListener gameServiceCloseListener)
		{
		}

		[Token(Token = "0x6007D7E")]
		[Address(RVA = "0x11D056C", Offset = "0x11D056C", VA = "0x11D056C")]
		public void setStepsAchievement(string achievementID, int steps)
		{
		}

		[Token(Token = "0x6007D7F")]
		[Address(RVA = "0x11D07BC", Offset = "0x11D07BC", VA = "0x11D07BC")]
		public void setStepsAchievementImmediate(string achievementID, int steps, INPListener listener)
		{
		}

		[Token(Token = "0x6007D80")]
		[Address(RVA = "0x11D09D8", Offset = "0x11D09D8", VA = "0x11D09D8")]
		public void unlockAchievement(string achievementID)
		{
		}

		[Token(Token = "0x6007D81")]
		[Address(RVA = "0x11D0BB8", Offset = "0x11D0BB8", VA = "0x11D0BB8")]
		public void unlockAchievementImmediate(string achievementID, INPListener listener)
		{
		}

		[Token(Token = "0x6007D82")]
		[Address(RVA = "0x11D0D64", Offset = "0x11D0D64", VA = "0x11D0D64")]
		public void incrementAchievement(string achievementID, int increment)
		{
		}

		[Token(Token = "0x6007D83")]
		[Address(RVA = "0x11D0FB4", Offset = "0x11D0FB4", VA = "0x11D0FB4")]
		public void incrementAchievementImmediate(string achievementID, int increment, INPListener listener)
		{
		}

		[Token(Token = "0x6007D84")]
		[Address(RVA = "0x11D11D0", Offset = "0x11D11D0", VA = "0x11D11D0")]
		public void loadAchievementData(bool forceReload, INPListener listener)
		{
		}

		[Token(Token = "0x6007D85")]
		[Address(RVA = "0x11D13A0", Offset = "0x11D13A0", VA = "0x11D13A0")]
		public void showAllLeaderBoard(INPListener gameServiceCloseListener)
		{
		}

		[Token(Token = "0x6007D86")]
		[Address(RVA = "0x11D14A0", Offset = "0x11D14A0", VA = "0x11D14A0")]
		public void showLeaderBoard(string leaderBoardID, INPListener gameServiceCloseListener)
		{
		}

		[Token(Token = "0x6007D87")]
		[Address(RVA = "0x11D164C", Offset = "0x11D164C", VA = "0x11D164C")]
		public void submitScore(string leaderBoardID, long score)
		{
		}

		[Token(Token = "0x6007D88")]
		[Address(RVA = "0x11D1888", Offset = "0x11D1888", VA = "0x11D1888")]
		public void submitScoreImmediate(string leaderBoardID, long score, INPListener listener)
		{
		}

		[Token(Token = "0x6007D89")]
		[Address(RVA = "0x11D1A90", Offset = "0x11D1A90", VA = "0x11D1A90")]
		public void loadCurrentPlayerLeaderboardScore(string leaderBoardID, int span, int leaderboardCollection, INPListener listener)
		{
		}

		[Token(Token = "0x6007D8A")]
		[Address(RVA = "0x11D1D24", Offset = "0x11D1D24", VA = "0x11D1D24")]
		public void ConnectGamePlatform(INPListener listener)
		{
		}

		[Token(Token = "0x6007D8B")]
		[Address(RVA = "0x11D1E24", Offset = "0x11D1E24", VA = "0x11D1E24")]
		public void DisconnectGamePlatform(INPListener listener)
		{
		}

		[Token(Token = "0x6007D8C")]
		[Address(RVA = "0x11D1F24", Offset = "0x11D1F24", VA = "0x11D1F24")]
		public void LogoutGamePlatform(INPListener listener)
		{
		}

		[Token(Token = "0x6007D8D")]
		[Address(RVA = "0x11D2024", Offset = "0x11D2024", VA = "0x11D2024")]
		public bool IsEnableGamePlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6007D8E")]
		[Address(RVA = "0x11D2400", Offset = "0x11D2400", VA = "0x11D2400")]
		public void ScreenCapture(INPListener listener)
		{
		}

		[Token(Token = "0x6007D8F")]
		[Address(RVA = "0x11D2500", Offset = "0x11D2500", VA = "0x11D2500")]
		public void GetPlayerStats(bool forceReload, INPListener listener)
		{
		}

		[Token(Token = "0x6007D90")]
		[Address(RVA = "0x11D26D0", Offset = "0x11D26D0", VA = "0x11D26D0")]
		public void ShowPlate(NPCSInfo param)
		{
		}

		[Token(Token = "0x6007D91")]
		[Address(RVA = "0x11D26F4", Offset = "0x11D26F4", VA = "0x11D26F4")]
		public void ShowPlate(int group, NPCSInfo param)
		{
		}

		[Token(Token = "0x6007D92")]
		[Address(RVA = "0x11CCE90", Offset = "0x11CCE90", VA = "0x11CCE90")]
		public void ShowPlate(int group, NPCSInfo param, INPPlateListener plateListener)
		{
		}

		[Token(Token = "0x6007D93")]
		[Address(RVA = "0x11D2710", Offset = "0x11D2710", VA = "0x11D2710")]
		public void ShowTermsOfAgree(INPListener listener)
		{
		}

		[Token(Token = "0x6007D94")]
		[Address(RVA = "0x11D2810", Offset = "0x11D2810", VA = "0x11D2810")]
		public void snsConnect(NPSnsType snsType, INPListener listener)
		{
		}

		[Token(Token = "0x6007D95")]
		[Address(RVA = "0x11D29E0", Offset = "0x11D29E0", VA = "0x11D29E0")]
		public void snsDisconnect(NPSnsType snsType, INPListener listener)
		{
		}

		[Token(Token = "0x6007D96")]
		[Address(RVA = "0x11D2BB0", Offset = "0x11D2BB0", VA = "0x11D2BB0")]
		public void getSnsConnectionStatus(INPListener listener)
		{
		}

		[Token(Token = "0x6007D97")]
		[Address(RVA = "0x11D2CB0", Offset = "0x11D2CB0", VA = "0x11D2CB0")]
		public void getSnsUserInfo(NPSnsType snsType, INPListener listener)
		{
		}

		[Token(Token = "0x6007D98")]
		[Address(RVA = "0x11D2E80", Offset = "0x11D2E80", VA = "0x11D2E80")]
		public void getSnsTokenList(INPListener listener)
		{
		}

		[Token(Token = "0x6007D99")]
		[Address(RVA = "0x11D2F80", Offset = "0x11D2F80", VA = "0x11D2F80")]
		public void GetCountryFromServer(INPListener listener)
		{
		}

		[Token(Token = "0x6007D9A")]
		[Address(RVA = "0x11D3080", Offset = "0x11D3080", VA = "0x11D3080")]
		public void LoadLocatedCountry(INPListener listener)
		{
		}

		[Token(Token = "0x6007D9B")]
		[Address(RVA = "0x11D3180", Offset = "0x11D3180", VA = "0x11D3180")]
		public string getUUID()
		{
			return null;
		}

		[Token(Token = "0x6007D9C")]
		[Address(RVA = "0x11D3588", Offset = "0x11D3588", VA = "0x11D3588")]
		public void ShowDataBackup(INPListener listener)
		{
		}

		[Token(Token = "0x6007D9D")]
		[Address(RVA = "0x11D364C", Offset = "0x11D364C", VA = "0x11D364C")]
		public void ShowDataBackup(string title, INPListener listener)
		{
		}

		[Token(Token = "0x6007D9E")]
		[Address(RVA = "0x11D37F8", Offset = "0x11D37F8", VA = "0x11D37F8")]
		public void ShowDataRestore(INPListener listener)
		{
		}

		[Token(Token = "0x6007D9F")]
		[Address(RVA = "0x11D38BC", Offset = "0x11D38BC", VA = "0x11D38BC")]
		public void ShowDataRestore(string title, INPListener listener)
		{
		}

		[Token(Token = "0x6007DA0")]
		[Address(RVA = "0x11D3A68", Offset = "0x11D3A68", VA = "0x11D3A68")]
		public void SetDisableLoginTypes(int[] loginTypes)
		{
		}

		[Token(Token = "0x6007DA1")]
		[Address(RVA = "0x11D3C4C", Offset = "0x11D3C4C", VA = "0x11D3C4C")]
		public void ResolveAlreadyLoginedUser(INPListener listener)
		{
		}

		[Token(Token = "0x6007DA2")]
		[Address(RVA = "0x11D3D4C", Offset = "0x11D3D4C", VA = "0x11D3D4C")]
		public void EnterToy(INPListener listener)
		{
		}

		[Token(Token = "0x6007DA3")]
		[Address(RVA = "0x11D3E4C", Offset = "0x11D3E4C", VA = "0x11D3E4C")]
		public void ShowSettlementFund(string itemName, string itemPrice, INPListener listener)
		{
		}

		[Token(Token = "0x6007DA4")]
		[Address(RVA = "0x11D4044", Offset = "0x11D4044", VA = "0x11D4044")]
		public void ShowPushNSms(INPListener listener)
		{
		}

		[Token(Token = "0x6007DA5")]
		[Address(RVA = "0x11D4144", Offset = "0x11D4144", VA = "0x11D4144")]
		public void GetServiceInfo(INPListener listener)
		{
		}

		[Token(Token = "0x6007DA6")]
		[Address(RVA = "0x11D4244", Offset = "0x11D4244", VA = "0x11D4244")]
		public void GetAdvertisingId(INPListener listener)
		{
		}

		[Token(Token = "0x6007DA7")]
		[Address(RVA = "0x11D4344", Offset = "0x11D4344", VA = "0x11D4344")]
		public void BillingRequestProducts(List<string> productIds, INPListener listener)
		{
		}

		[Token(Token = "0x6007DA8")]
		[Address(RVA = "0x11D457C", Offset = "0x11D457C", VA = "0x11D457C")]
		public void BillingPayment(string productId, Dictionary<string, string> meta, INPListener listener)
		{
		}

		[Token(Token = "0x6007DA9")]
		[Address(RVA = "0x11D4898", Offset = "0x11D4898", VA = "0x11D4898")]
		public void BillingPayment(string productId, Dictionary<string, string> meta, Dictionary<string, string> servicePayload, INPListener listener)
		{
		}

		[Token(Token = "0x6007DAA")]
		[Address(RVA = "0x11D4668", Offset = "0x11D4668", VA = "0x11D4668")]
		public void BillingPayment(NXPPaymentInfo paymentInfo, INPListener listener)
		{
		}

		[Token(Token = "0x6007DAB")]
		[Address(RVA = "0x11D4968", Offset = "0x11D4968", VA = "0x11D4968")]
		public void BillingRestore(INPListener listener)
		{
		}

		[Token(Token = "0x6007DAC")]
		[Address(RVA = "0x11D4A68", Offset = "0x11D4A68", VA = "0x11D4A68")]
		public void BillingFinish(string stampToken, INPListener listener)
		{
		}

		[Token(Token = "0x6007DAD")]
		[Address(RVA = "0x11D4C80", Offset = "0x11D4C80", VA = "0x11D4C80")]
		public void SetMapFieldDefaultValues(Dictionary<string, object> values)
		{
		}

		[Token(Token = "0x6007DAE")]
		[Address(RVA = "0x11D5BBC", Offset = "0x11D5BBC", VA = "0x11D5BBC")]
		public Dictionary<string, object> GetMapFieldDefaultValues()
		{
			return null;
		}

		[Token(Token = "0x6007DAF")]
		[Address(RVA = "0x11D5EE4", Offset = "0x11D5EE4", VA = "0x11D5EE4")]
		public void SetMapOptions(bool consoleLoggingEnabled, string logLevel)
		{
		}

		[Token(Token = "0x6007DB0")]
		[Address(RVA = "0x11D6194", Offset = "0x11D6194", VA = "0x11D6194")]
		public void ReportMapCustomEvent(string eventType, Dictionary<string, object> fields)
		{
		}

		[Token(Token = "0x6007DB1")]
		[Address(RVA = "0x11D6494", Offset = "0x11D6494", VA = "0x11D6494")]
		public void ReportMapRevenueEvent(string productId, string displayedPrice, string priceLocale, string receiptId, string storeId, string paymentType, Dictionary<string, object> additionalFields)
		{
		}

		[Token(Token = "0x6007DB2")]
		[Address(RVA = "0x11D6A3C", Offset = "0x11D6A3C", VA = "0x11D6A3C")]
		public string GetMapNexonDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6007DB3")]
		[Address(RVA = "0x11D6E44", Offset = "0x11D6E44", VA = "0x11D6E44")]
		public string GetMapJsonClientMetadata()
		{
			return null;
		}

		[Token(Token = "0x6007DB4")]
		[Address(RVA = "0x11D724C", Offset = "0x11D724C", VA = "0x11D724C")]
		public void SetOptions(NPOptions options)
		{
		}

		[Token(Token = "0x6007DB5")]
		[Address(RVA = "0x11D74BC", Offset = "0x11D74BC", VA = "0x11D74BC")]
		public NPOptions GetOptions()
		{
			return null;
		}

		[Token(Token = "0x6007DB6")]
		[Address(RVA = "0x11D78F8", Offset = "0x11D78F8", VA = "0x11D78F8")]
		private JSONClass dicToJSON(Dictionary<string, string> dic)
		{
			return null;
		}

		[Token(Token = "0x6007DB7")]
		[Address(RVA = "0x11D4EEC", Offset = "0x11D4EEC", VA = "0x11D4EEC")]
		private string dicToString(Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x6007DB8")]
		[Address(RVA = "0x11D7D3C", Offset = "0x11D7D3C", VA = "0x11D7D3C")]
		public void FBLogPurchase(double purchaseAmount, string currency, Dictionary<string, string> param)
		{
		}

		[Token(Token = "0x6007DB9")]
		[Address(RVA = "0x11D8038", Offset = "0x11D8038", VA = "0x11D8038")]
		public void FBLogEvent(string eventName)
		{
		}

		[Token(Token = "0x6007DBA")]
		[Address(RVA = "0x11D8218", Offset = "0x11D8218", VA = "0x11D8218")]
		public void FBLogEvent(string eventName, Dictionary<string, string> param)
		{
		}

		[Token(Token = "0x6007DBB")]
		[Address(RVA = "0x11D84B8", Offset = "0x11D84B8", VA = "0x11D84B8")]
		public void FBLogEvent(string eventName, double valueToSum)
		{
		}

		[Token(Token = "0x6007DBC")]
		[Address(RVA = "0x11D86F4", Offset = "0x11D86F4", VA = "0x11D86F4")]
		public void FBLogEvent(string eventName, double valueToSum, Dictionary<string, string> param)
		{
		}

		[Token(Token = "0x6007DBD")]
		[Address(RVA = "0x11D89F0", Offset = "0x11D89F0", VA = "0x11D89F0")]
		public void FBActivateApp()
		{
		}

		[Token(Token = "0x6007DBE")]
		[Address(RVA = "0x11D8AD4", Offset = "0x11D8AD4", VA = "0x11D8AD4")]
		public void FBDeactivateApp()
		{
		}

		[Token(Token = "0x6007DBF")]
		[Address(RVA = "0x11D8BB8", Offset = "0x11D8BB8", VA = "0x11D8BB8")]
		public void FBFetchDeferredAppLink(INPListener listener)
		{
		}

		[Token(Token = "0x6007DC0")]
		[Address(RVA = "0x11D8CB8", Offset = "0x11D8CB8", VA = "0x11D8CB8")]
		public void FBAppInvite(string appLinkUrl, string previewImageUrl, INPListener listener)
		{
		}

		[Token(Token = "0x6007DC1")]
		[Address(RVA = "0x11D8E6C", Offset = "0x11D8E6C", VA = "0x11D8E6C")]
		public void FBShare(string title, string description, string contentUrl, string imageUrl, INPListener listener)
		{
		}

		[Token(Token = "0x6007DC2")]
		[Address(RVA = "0x11D918C", Offset = "0x11D918C", VA = "0x11D918C")]
		public void FBGetFriends(int nextPage, INPListener listener)
		{
		}

		[Token(Token = "0x6007DC3")]
		[Address(RVA = "0x11D9318", Offset = "0x11D9318", VA = "0x11D9318")]
		public void FBSetIsDebugEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6007DC4")]
		[Address(RVA = "0x11D94DC", Offset = "0x11D94DC", VA = "0x11D94DC")]
		public void ResetBadgeCount(int count)
		{
		}

		[Token(Token = "0x6007DC5")]
		[Address(RVA = "0x11D94E0", Offset = "0x11D94E0", VA = "0x11D94E0")]
		public void SetPushAgreement(NPPushAgreementType agreeStatus, INPListener listener)
		{
		}

		[Token(Token = "0x6007DC6")]
		[Address(RVA = "0x11D96B0", Offset = "0x11D96B0", VA = "0x11D96B0")]
		public void RequestPermissions(List<string> permissions, int requestCode, string rationaleMsg, INPRuntimePermissionListener listener)
		{
		}

		[Token(Token = "0x6007DC7")]
		[Address(RVA = "0x11D99FC", Offset = "0x11D99FC", VA = "0x11D99FC")]
		public void GetPromotion(string placementId, INPListener listener)
		{
		}

		[Token(Token = "0x6007DC8")]
		[Address(RVA = "0x11D9BA8", Offset = "0x11D9BA8", VA = "0x11D9BA8")]
		public void ShowPromotion(string placementId, INPListener listener)
		{
		}

		[Token(Token = "0x6007DC9")]
		[Address(RVA = "0x11D9D54", Offset = "0x11D9D54", VA = "0x11D9D54")]
		public void ShowAccountMenu(INPListener listener)
		{
		}

		[Token(Token = "0x6007DCA")]
		[Address(RVA = "0x11D9E54", Offset = "0x11D9E54", VA = "0x11D9E54")]
		public void ShowToday(int groupCode)
		{
		}

		[Token(Token = "0x6007DCB")]
		[Address(RVA = "0x11DA018", Offset = "0x11DA018", VA = "0x11DA018")]
		public void WebShop(int storeId, INPListener listener)
		{
		}

		[Token(Token = "0x6007DCC")]
		[Address(RVA = "0x11DA204", Offset = "0x11DA204", VA = "0x11DA204")]
		public void FbAddPermission(ArrayList perms, int type, INPListener listener)
		{
		}

		[Token(Token = "0x6007DCD")]
		[Address(RVA = "0x11DA4EC", Offset = "0x11DA4EC", VA = "0x11DA4EC")]
		public void SetAdOptout(bool value)
		{
		}

		[Token(Token = "0x6007DCE")]
		[Address(RVA = "0x11C9978", Offset = "0x11C9978", VA = "0x11C9978")]
		private string generateCallId()
		{
			return null;
		}

		[Token(Token = "0x6007DCF")]
		[Address(RVA = "0x11C8AA8", Offset = "0x11C8AA8", VA = "0x11C8AA8")]
		public static void ToyDebugLog(string text)
		{
		}
	}
}
