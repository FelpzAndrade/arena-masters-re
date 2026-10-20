using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000081")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000082")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x4")]
		private static string mLanguageCode;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x8")]
		public static bool IsRight2Left;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0xC")]
		public static List<LanguageSource> Sources;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x10")]
		public static string[] GlobalSources;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x14")]
		public static bool isShowKey;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x18")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x1C")]
		private static OnLocalizeCallback m_OnLocalizeEvent;

		[Token(Token = "0x17000087")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xD6EF3C", Offset = "0xD6EF3C", VA = "0xD6EF3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xD716EC", Offset = "0xD716EC", VA = "0xD716EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xD72298", Offset = "0xD72298", VA = "0xD72298")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xD7234C", Offset = "0xD7234C", VA = "0xD7234C")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public static string CurrentRegion
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xD727E0", Offset = "0xD727E0", VA = "0xD727E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xD729E4", Offset = "0xD729E4", VA = "0xD729E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xD72CA4", Offset = "0xD72CA4", VA = "0xD72CA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xD72E00", Offset = "0xD72E00", VA = "0xD72E00")]
			set
			{
			}
		}

		[Token(Token = "0x14000053")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xD711EC", Offset = "0xD711EC", VA = "0xD711EC")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xD713D0", Offset = "0xD713D0", VA = "0xD713D0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD715B4", Offset = "0xD715B4", VA = "0xD715B4")]
		private static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD72018", Offset = "0xD72018", VA = "0xD72018")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD730B0", Offset = "0xD730B0", VA = "0xD730B0")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD73ABC", Offset = "0xD73ABC", VA = "0xD73ABC")]
		public static string GetTermTranslation(string Term)
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD73C90", Offset = "0xD73C90", VA = "0xD73C90")]
		public static string GetTermTranslation(string Term, bool FixForRTL)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD73B6C", Offset = "0xD73B6C", VA = "0xD73B6C")]
		public static string GetTermTranslation(string Term, bool FixForRTL, int maxLineLengthForRTL)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD74014", Offset = "0xD74014", VA = "0xD74014")]
		public static bool TryGetTermTranslation(string Term, out string Translation)
		{
			Translation = default;
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD740D0", Offset = "0xD740D0", VA = "0xD740D0")]
		public static bool TryGetTermTranslation(string Term, out string Translation, bool FixForRTL)
		{
			Translation = default;
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD73D44", Offset = "0xD73D44", VA = "0xD73D44")]
		public static bool TryGetTermTranslation(string Term, out string Translation, bool FixForRTL, int maxLineLengthForRTL)
		{
			Translation = default;
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD744E8", Offset = "0xD744E8", VA = "0xD744E8")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xD74190", Offset = "0xD74190", VA = "0xD74190")]
		public static string ApplyRTLfix(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xD7458C", Offset = "0xD7458C", VA = "0xD7458C")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xD704C4", Offset = "0xD704C4", VA = "0xD704C4")]
		internal static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xD72FB4", Offset = "0xD72FB4", VA = "0xD72FB4")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xD75570", Offset = "0xD75570", VA = "0xD75570")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xD75B90", Offset = "0xD75B90", VA = "0xD75B90")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xD757CC", Offset = "0xD757CC", VA = "0xD757CC")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xD6D2C8", Offset = "0xD6D2C8", VA = "0xD6D2C8")]
		public static void AddSource(LanguageSource Source)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xD75AA4", Offset = "0xD75AA4", VA = "0xD75AA4")]
		internal static void RemoveSource(LanguageSource Source)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xD75DB0", Offset = "0xD75DB0", VA = "0xD75DB0")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xD73770", Offset = "0xD73770", VA = "0xD73770")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xD718D0", Offset = "0xD718D0", VA = "0xD718D0")]
		public static string GetSupportedLanguage(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xD71D5C", Offset = "0xD71D5C", VA = "0xD71D5C")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xD72528", Offset = "0xD72528", VA = "0xD72528")]
		public static string GetLanguageFromCode(string Code)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD75E9C", Offset = "0xD75E9C", VA = "0xD75E9C")]
		public static List<string> GetAllLanguages()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD762A4", Offset = "0xD762A4", VA = "0xD762A4")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD76464", Offset = "0xD76464", VA = "0xD76464")]
		public static List<string> GetTermsList()
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xD76838", Offset = "0xD76838", VA = "0xD76838")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xD769DC", Offset = "0xD769DC", VA = "0xD769DC")]
		public static LanguageSource GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xD76D50", Offset = "0xD76D50", VA = "0xD76D50")]
		public static Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD76F50", Offset = "0xD76F50", VA = "0xD76F50")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD6CA24", Offset = "0xD6CA24", VA = "0xD6CA24")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xD73684", Offset = "0xD73684", VA = "0xD73684")]
		private static bool IsRTL(string Code)
		{
			return default(bool);
		}
	}
}
