using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008AD")]
	public static class CSContentHelper
	{
		[Token(Token = "0x4002A87")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map11;

		[Token(Token = "0x6004659")]
		[Address(RVA = "0x222A188", Offset = "0x222A188", VA = "0x222A188")]
		public static string ToGlossaryString(CSContentType type)
		{
			return null;
		}

		[Token(Token = "0x600465A")]
		[Address(RVA = "0x222A254", Offset = "0x222A254", VA = "0x222A254")]
		public static string GetContentTypeString(CSContentType type)
		{
			return null;
		}

		[Token(Token = "0x600465B")]
		[Address(RVA = "0x222A324", Offset = "0x222A324", VA = "0x222A324")]
		public static string GetCountString(int count)
		{
			return null;
		}

		[Token(Token = "0x600465C")]
		[Address(RVA = "0x222A410", Offset = "0x222A410", VA = "0x222A410")]
		public static string GetNameIncludeCount(string name, int count)
		{
			return null;
		}

		[Token(Token = "0x600465D")]
		[Address(RVA = "0x222A5BC", Offset = "0x222A5BC", VA = "0x222A5BC")]
		public static string GetNameIncludeCount1(string name, int count)
		{
			return null;
		}

		[Token(Token = "0x600465E")]
		[Address(RVA = "0x222A768", Offset = "0x222A768", VA = "0x222A768")]
		public static bool IncludeGacha(CSContent[] contents)
		{
			return default(bool);
		}

		[Token(Token = "0x600465F")]
		[Address(RVA = "0x222A7DC", Offset = "0x222A7DC", VA = "0x222A7DC")]
		public static bool IsIncludePackageItem(CSContent[] contents, int productID)
		{
			return default(bool);
		}

		[Token(Token = "0x6004660")]
		[Address(RVA = "0x222A85C", Offset = "0x222A85C", VA = "0x222A85C")]
		public static bool IncludePackageItem(CSContent[] contents)
		{
			return default(bool);
		}

		[Token(Token = "0x6004661")]
		[Address(RVA = "0x222A8CC", Offset = "0x222A8CC", VA = "0x222A8CC")]
		private static CSContent newContentFromReward(string strContentType, int nValue)
		{
			return null;
		}

		[Token(Token = "0x6004662")]
		[Address(RVA = "0x222B3C8", Offset = "0x222B3C8", VA = "0x222B3C8")]
		public static CSContent ParseReward(string strReward)
		{
			return null;
		}

		[Token(Token = "0x6004663")]
		[Address(RVA = "0x222B528", Offset = "0x222B528", VA = "0x222B528")]
		public static List<CSContent> ParseRewards(string strRewards)
		{
			return null;
		}

		[Token(Token = "0x6004664")]
		[Address(RVA = "0x222B6A4", Offset = "0x222B6A4", VA = "0x222B6A4")]
		public static CSContent CharacterToSoulStone(CSContent content, CSProtoInfoManager_Item protoInfoManager_Item, CSProtoInfoManager_GameConst protoInfoManager_GameConst)
		{
			return null;
		}

		[Token(Token = "0x6004665")]
		[Address(RVA = "0x222B7B0", Offset = "0x222B7B0", VA = "0x222B7B0")]
		public static CSContent PetToSoulDust(CSContent content, CSProtoInfoManager_Item protoInfoManager_Item, CSProtoInfoManager_GameConst protoInfoManager_GameConst)
		{
			return null;
		}
	}
}
