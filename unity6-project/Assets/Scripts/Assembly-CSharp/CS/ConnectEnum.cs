using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008DD")]
	public class ConnectEnum
	{
		[Token(Token = "0x20008DE")]
		public enum ServerType
		{
			[Token(Token = "0x4002AF8")]
			None = 0,
			[Token(Token = "0x4002AF9")]
			Local = 1,
			[Token(Token = "0x4002AFA")]
			Development = 2,
			[Token(Token = "0x4002AFB")]
			Stage = 3,
			[Token(Token = "0x4002AFC")]
			Live = 4,
			[Token(Token = "0x4002AFD")]
			iOS = 5,
			[Token(Token = "0x4002AFE")]
			Nineyou_Dev = 6,
			[Token(Token = "0x4002AFF")]
			Nineyou_Stage = 7,
			[Token(Token = "0x4002B00")]
			Nineyou_Live = 8,
			[Token(Token = "0x4002B01")]
			China = 10,
			[Token(Token = "0x4002B02")]
			StageS01 = 11
		}

		[Token(Token = "0x20008DF")]
		public enum RegionType
		{
			[Token(Token = "0x4002B04")]
			None = 0,
			[Token(Token = "0x4002B05")]
			Asia = 1,
			[Token(Token = "0x4002B06")]
			Global = 2,
			[Token(Token = "0x4002B07")]
			US = 3,
			[Token(Token = "0x4002B08")]
			Korea = 4
		}

		[Token(Token = "0x4002AF6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<RegionType> AllowRegionList = new List<RegionType> { RegionType.Asia, RegionType.US, RegionType.Korea };

		[Token(Token = "0x6004746")]
		[Address(RVA = "0x23ECC74", Offset = "0x23ECC74", VA = "0x23ECC74")]
		public ConnectEnum()
		{
		}
	}
}
