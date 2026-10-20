using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000875")]
	public class S3Const
	{
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0x0")]
		public static string NEXON_S3_URL;

		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x4")]
		public static string MEERKAT_S3_URL;

		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0x8")]
		private static Queue<string> NEXON_CDN_URLS;

		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0xC")]
		private static Queue<string> NEXON_CDN_URLS_NO_CACHE;

		[Token(Token = "0x17000977")]
		private static string GAMEDATA_PATH
		{
			[Token(Token = "0x60045A9")]
			[Address(RVA = "0x21C3694", Offset = "0x21C3694", VA = "0x21C3694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000978")]
		private static string SETTING_PATH
		{
			[Token(Token = "0x60045AA")]
			[Address(RVA = "0x21C3790", Offset = "0x21C3790", VA = "0x21C3790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000979")]
		private static string ASSETBUNDLE_PATH
		{
			[Token(Token = "0x60045AB")]
			[Address(RVA = "0x21C388C", Offset = "0x21C388C", VA = "0x21C388C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097A")]
		private static string BASE_URL
		{
			[Token(Token = "0x60045AC")]
			[Address(RVA = "0x21C3988", Offset = "0x21C3988", VA = "0x21C3988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097B")]
		private static string BASE_URL_NO_CACHE
		{
			[Token(Token = "0x60045AD")]
			[Address(RVA = "0x21C3BC0", Offset = "0x21C3BC0", VA = "0x21C3BC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097C")]
		public static string GAMEDATA_URL
		{
			[Token(Token = "0x60045AE")]
			[Address(RVA = "0x21C3DF8", Offset = "0x21C3DF8", VA = "0x21C3DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097D")]
		public static string ASSETBUNDLE_URL
		{
			[Token(Token = "0x60045AF")]
			[Address(RVA = "0x21C3EE8", Offset = "0x21C3EE8", VA = "0x21C3EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097E")]
		public static string SETTINGS_URL
		{
			[Token(Token = "0x60045B0")]
			[Address(RVA = "0x21C3FD8", Offset = "0x21C3FD8", VA = "0x21C3FD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700097F")]
		public static string STORE_URL
		{
			[Token(Token = "0x60045B1")]
			[Address(RVA = "0x21C40C8", Offset = "0x21C40C8", VA = "0x21C40C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000980")]
		private static string BASE_S3URL
		{
			[Token(Token = "0x60045B2")]
			[Address(RVA = "0x21C4140", Offset = "0x21C4140", VA = "0x21C4140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000981")]
		public static string ASSETBUNDLE_S3URL
		{
			[Token(Token = "0x60045B3")]
			[Address(RVA = "0x21C42AC", Offset = "0x21C42AC", VA = "0x21C42AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000982")]
		public static string SETTINGS_S3URL
		{
			[Token(Token = "0x60045B4")]
			[Address(RVA = "0x21C439C", Offset = "0x21C439C", VA = "0x21C439C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000983")]
		public static string NEXON_CDN_URL
		{
			[Token(Token = "0x60045B5")]
			[Address(RVA = "0x21C3ADC", Offset = "0x21C3ADC", VA = "0x21C3ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000984")]
		public static string NEXON_CDN_URL_NO_CACHE
		{
			[Token(Token = "0x60045B6")]
			[Address(RVA = "0x21C3D14", Offset = "0x21C3D14", VA = "0x21C3D14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x21C3350", Offset = "0x21C3350", VA = "0x21C3350")]
		public S3Const()
		{
		}

		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x21C35C4", Offset = "0x21C35C4", VA = "0x21C35C4")]
		private static bool IsUseNexonS3(ConnectEnum.ServerType server)
		{
			return default(bool);
		}

		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x21C448C", Offset = "0x21C448C", VA = "0x21C448C")]
		public static bool URLFailDequeue()
		{
			return default(bool);
		}
	}
}
