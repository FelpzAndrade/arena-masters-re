using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200091A")]
	public class UnlockFeatureLogic
	{
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x21EA8B4", Offset = "0x21EA8B4", VA = "0x21EA8B4")]
		public UnlockFeatureLogic()
		{
		}

		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x21EA8BC", Offset = "0x21EA8BC", VA = "0x21EA8BC")]
		public static List<string> GetUnlockFeatures(CSProtoInfoManagers proto, int level, [Optional] Func<XGameModeType, string> GetGameModeString, [Optional] Func<FeatureType, string> GetFeatureTypeString)
		{
			return null;
		}

		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x21EB208", Offset = "0x21EB208", VA = "0x21EB208")]
		public static int GetUnlockFeatureNeedLevel(CSProtoInfoManager_GameConst gameConst, FeatureType featureType)
		{
			return default(int);
		}
	}
}
