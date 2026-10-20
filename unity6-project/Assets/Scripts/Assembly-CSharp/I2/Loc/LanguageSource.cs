using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x200006A")]
	public class LanguageSource : MonoBehaviour
	{
		[Token(Token = "0x200006B")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x40001DA")]
			Always = 0,
			[Token(Token = "0x40001DB")]
			Never = 1,
			[Token(Token = "0x40001DC")]
			Daily = 2,
			[Token(Token = "0x40001DD")]
			Weekly = 3,
			[Token(Token = "0x40001DE")]
			Monthly = 4
		}

		[Token(Token = "0x200006C")]
		public enum eInputSpecialization
		{
			[Token(Token = "0x40001E0")]
			PC = 0,
			[Token(Token = "0x40001E1")]
			Touch = 1,
			[Token(Token = "0x40001E2")]
			Controller = 2
		}

		[Token(Token = "0x200006D")]
		private sealed class _003CImport_Google_Coroutine_003Ec__Iterator13 : IDisposable
		{
			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal WWW _003Cwww_003E__0;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string _003CerrorMsg_003E__1;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int _0024PC;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object _0024current;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal LanguageSource _003C_003Ef__this;

			[Token(Token = "0x1700005C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0xD700E0", Offset = "0xD700E0", VA = "0xD700E0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700005D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0xD700E8", Offset = "0xD700E8", VA = "0xD700E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0xD6C5F8", Offset = "0xD6C5F8", VA = "0xD6C5F8")]
			public _003CImport_Google_Coroutine_003Ec__Iterator13()
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0xD700E0", Offset = "0xD700E0", VA = "0xD700E0", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0xD700E8", Offset = "0xD700E8", VA = "0xD700E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0xD700F0", Offset = "0xD700F0", VA = "0xD700F0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0xD706C8", Offset = "0xD706C8", VA = "0xD706C8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0xD706D4", Offset = "0xD706D4", VA = "0xD706D4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static char[] CategorySeparators;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public List<TermData> mTerms;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool NeverDestroy;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Action<LanguageSource> m_Event_OnSourceUpdateFromGoogle;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Func<TermData, string> _003C_003Ef__am_0024cache11;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Func<string, bool> _003C_003Ef__am_0024cache12;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Func<string, bool> _003C_003Ef__am_0024cache13;

		[Token(Token = "0x14000052")]
		public event Action<LanguageSource> Event_OnSourceUpdateFromGoogle
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000322")]
			[Address(RVA = "0xD6633C", Offset = "0xD6633C", VA = "0xD6633C")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6000323")]
			[Address(RVA = "0xD664C8", Offset = "0xD664C8", VA = "0xD664C8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xD660E8", Offset = "0xD660E8", VA = "0xD660E8")]
		public LanguageSource()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD66654", Offset = "0xD66654", VA = "0xD66654")]
		public string Export_I2CSV(string Category, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xD67038", Offset = "0xD67038", VA = "0xD67038")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, string postfix, string[] aLanguages, string[] aSecLanguages, char Separator, byte FlagBitMask, byte SecFlagBitMask)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xD6762C", Offset = "0xD6762C", VA = "0xD6762C")]
		public string Export_CSV(string Category, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD683D0", Offset = "0xD683D0", VA = "0xD683D0")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string prefix, string[] aLanguages, string[] aSecLanguages, char Separator, byte FlagBitMask, byte SecFlagBitMask)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xD68198", Offset = "0xD68198", VA = "0xD68198")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xD68860", Offset = "0xD68860", VA = "0xD68860")]
		public WWW Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xD68A40", Offset = "0xD68A40", VA = "0xD68A40")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xD690E0", Offset = "0xD690E0", VA = "0xD690E0")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xD6A608", Offset = "0xD6A608", VA = "0xD6A608")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xD69254", Offset = "0xD69254", VA = "0xD69254")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xD6A8C4", Offset = "0xD6A8C4", VA = "0xD6A8C4")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xD6B614", Offset = "0xD6B614", VA = "0xD6B614")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xD6B764", Offset = "0xD6B764", VA = "0xD6B764")]
		public void Delayed_Import_Google()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xD6BAD0", Offset = "0xD6BAD0", VA = "0xD6BAD0")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xD6B76C", Offset = "0xD6B76C", VA = "0xD6B76C")]
		public void Import_Google(bool ForceUpdate = false)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD6BE54", Offset = "0xD6BE54", VA = "0xD6BE54")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xD6C554", Offset = "0xD6C554", VA = "0xD6C554")]
		[DebuggerHidden]
		private IEnumerator Import_Google_Coroutine()
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xD6C600", Offset = "0xD6C600", VA = "0xD6C600")]
		public WWW Import_Google_CreateWWWcall(bool ForceUpdate = false)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xD6C920", Offset = "0xD6C920", VA = "0xD6C920")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xD6C008", Offset = "0xD6C008", VA = "0xD6C008")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xD68D74", Offset = "0xD68D74", VA = "0xD68D74")]
		public List<string> GetCategories([Optional][DefaultParameterValue(false)] bool OnlyMainCategory, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xD6CBCC", Offset = "0xD6CBCC", VA = "0xD6CBCC")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xD6CA2C", Offset = "0xD6CA2C", VA = "0xD6CA2C")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xD6CD20", Offset = "0xD6CD20", VA = "0xD6CD20")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
			Category = default;
			Key = default;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD6CEEC", Offset = "0xD6CEEC", VA = "0xD6CEEC")]
		public static eInputSpecialization GetCurrentInputType()
		{
			return default(eInputSpecialization);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xD6CEF4", Offset = "0xD6CEF4", VA = "0xD6CEF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xD6D4D4", Offset = "0xD6D4D4", VA = "0xD6D4D4")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xD6DBE8", Offset = "0xD6DBE8", VA = "0xD6DBE8")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xD6ABB4", Offset = "0xD6ABB4", VA = "0xD6ABB4")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xD6AA48", Offset = "0xD6AA48", VA = "0xD6AA48")]
		public int GetLanguageIndexFromCode(string Code)
		{
			return default(int);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xD6DD90", Offset = "0xD6DD90", VA = "0xD6DD90")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xD6E2CC", Offset = "0xD6E2CC", VA = "0xD6E2CC")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xD6E3E8", Offset = "0xD6E3E8", VA = "0xD6E3E8")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xD6E4C8", Offset = "0xD6E4C8", VA = "0xD6E4C8")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xD6E764", Offset = "0xD6E764", VA = "0xD6E764")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xD6EC6C", Offset = "0xD6EC6C", VA = "0xD6EC6C")]
		public List<string> GetLanguages()
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xD6EDC4", Offset = "0xD6EDC4", VA = "0xD6EDC4")]
		public string GetTermTranslation(string term)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xD6F100", Offset = "0xD6F100", VA = "0xD6F100")]
		public bool TryGetTermTranslation(string term, out string Translation)
		{
			Translation = default;
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD6F248", Offset = "0xD6F248", VA = "0xD6F248")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD6B0A0", Offset = "0xD6B0A0", VA = "0xD6B0A0")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xD6F664", Offset = "0xD6F664", VA = "0xD6F664")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xD6F680", Offset = "0xD6F680", VA = "0xD6F680")]
		public List<string> GetTermsList()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD6F268", Offset = "0xD6F268", VA = "0xD6F268")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD6F7C4", Offset = "0xD6F7C4", VA = "0xD6F7C4")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD6AE18", Offset = "0xD6AE18", VA = "0xD6AE18")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD6F980", Offset = "0xD6F980", VA = "0xD6F980")]
		public bool IsEqualTo(LanguageSource Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD6D070", Offset = "0xD6D070", VA = "0xD6D070")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD6A958", Offset = "0xD6A958", VA = "0xD6A958")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD6FBEC", Offset = "0xD6FBEC", VA = "0xD6FBEC")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD6FDC8", Offset = "0xD6FDC8", VA = "0xD6FDC8")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xD6FE68", Offset = "0xD6FE68", VA = "0xD6FE68")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xD6FF68", Offset = "0xD6FF68", VA = "0xD6FF68")]
		private static string _003CExport_CSV_003Em__28(TermData x)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xD6FF88", Offset = "0xD6FF88", VA = "0xD6FF88")]
		private static bool _003CGetCommonWordInLanguageNames_003Em__29(string x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xD70034", Offset = "0xD70034", VA = "0xD70034")]
		private static bool _003CGetCommonWordInLanguageNames_003Em__2A(string x)
		{
			return default(bool);
		}
	}
}
