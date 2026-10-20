using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000942")]
	public class PandoraBoxLogic
	{
		[Token(Token = "0x6004971")]
		[Address(RVA = "0x21AD904", Offset = "0x21AD904", VA = "0x21AD904")]
		public PandoraBoxLogic()
		{
		}

		[Token(Token = "0x6004972")]
		[Address(RVA = "0x21AD90C", Offset = "0x21AD90C", VA = "0x21AD90C")]
		public static bool IsLastPandoraRecieved(UserDataBase userData, CSProtoInfoManager_PandoraBox protoPandorabox)
		{
			return default(bool);
		}

		[Token(Token = "0x6004973")]
		[Address(RVA = "0x21AD980", Offset = "0x21AD980", VA = "0x21AD980")]
		public static CSPandoraBoxData GetLastReviceData(UserDataBase userData, CSProtoInfoManager_PandoraBox protoPandorabox)
		{
			return null;
		}

		[Token(Token = "0x6004974")]
		[Address(RVA = "0x21AD9CC", Offset = "0x21AD9CC", VA = "0x21AD9CC")]
		public static int GetRecivePandoraID(UserDataBase userData, DateTime localTime, CSProtoInfoManager_PandoraBox protoPandorabox)
		{
			return default(int);
		}

		[Token(Token = "0x6004975")]
		[Address(RVA = "0x21ADAA4", Offset = "0x21ADAA4", VA = "0x21ADAA4")]
		public static bool IsRecieved(UserDataBase userData, int pandoraID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004976")]
		[Address(RVA = "0x21ADAF0", Offset = "0x21ADAF0", VA = "0x21ADAF0")]
		public static int GetRemainCoolTime_Sec(UserDataBase userData, DateTime localTime, CSProtoInfoManager_PandoraBox protoPandorabox, int spareSec = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6004977")]
		[Address(RVA = "0x21ADB50", Offset = "0x21ADB50", VA = "0x21ADB50")]
		public static int GetRemainCoolTime_Sec(UserDataBase userData, int pandoraID, DateTime localTime, CSProtoInfoManager_PandoraBox protoPandorabox, int spareSec = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6004978")]
		[Address(RVA = "0x21ADC7C", Offset = "0x21ADC7C", VA = "0x21ADC7C")]
		public static bool IsClearedPandoraTriggerTutorial(List<int> tutoClearList, CSProtoInfoManager_GameConst gameConst)
		{
			return default(bool);
		}
	}
}
