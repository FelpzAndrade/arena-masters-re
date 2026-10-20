using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B20")]
	public class CSProtoInfoManager_PandoraBox : Dictionary<int, CSPandoraBoxData>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000B21")]
		private sealed class _003CCookingSeasonStartInfo_003Ec__AnonStorey157
		{
			[Token(Token = "0x40036DC")]
			[FieldOffset(Offset = "0x8")]
			internal List<int> nextIDList;

			[Token(Token = "0x40036DD")]
			[FieldOffset(Offset = "0xC")]
			internal int startID;

			[Token(Token = "0x60051E9")]
			[Address(RVA = "0x1CB92E8", Offset = "0x1CB92E8", VA = "0x1CB92E8")]
			public _003CCookingSeasonStartInfo_003Ec__AnonStorey157()
			{
			}

			[Token(Token = "0x60051EA")]
			[Address(RVA = "0x1CBA02C", Offset = "0x1CBA02C", VA = "0x1CBA02C")]
			internal void _003C_003Em__20A(int id)
			{
			}
		}

		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<int, List<int>> seasonDictionary;

		[Token(Token = "0x40036DA")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> seasonStartIDDictionary;

		[Token(Token = "0x40036DB")]
		[FieldOffset(Offset = "0x3C")]
		protected string DATE_FORMAT;

		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x1CB8968", Offset = "0x1CB8968", VA = "0x1CB8968")]
		public CSProtoInfoManager_PandoraBox()
		{
		}

		[Token(Token = "0x60051DB")]
		[Address(RVA = "0x1CB8A68", Offset = "0x1CB8A68", VA = "0x1CB8A68", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x1CB8A78", Offset = "0x1CB8A78", VA = "0x1CB8A78", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x1CB8A7C", Offset = "0x1CB8A7C", VA = "0x1CB8A7C", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x1CB8ED0", Offset = "0x1CB8ED0", VA = "0x1CB8ED0")]
		private void CookingSeasonStartInfo()
		{
		}

		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x1CB92F0", Offset = "0x1CB92F0", VA = "0x1CB92F0", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x1CB95C8", Offset = "0x1CB95C8", VA = "0x1CB95C8")]
		public void CookingList(List<CSPandoraBoxData> dataList)
		{
		}

		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x1CB96F8", Offset = "0x1CB96F8", VA = "0x1CB96F8")]
		public CSPandoraBoxData GetStartPandoraData(int season)
		{
			return null;
		}

		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x1CB97E4", Offset = "0x1CB97E4", VA = "0x1CB97E4")]
		public CSPandoraBoxData GetPandoraData(int id)
		{
			return null;
		}

		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x1CB9888", Offset = "0x1CB9888", VA = "0x1CB9888")]
		public int GetSeasonPandoraDataCount(int season)
		{
			return default(int);
		}

		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x1CB9990", Offset = "0x1CB9990", VA = "0x1CB9990")]
		public bool TryGetPandoraOrder(int curID, out int curOrder)
		{
			curOrder = default;
			return default(bool);
		}

		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x1CB9AD0", Offset = "0x1CB9AD0", VA = "0x1CB9AD0")]
		public List<int> GetSeasonLists()
		{
			return null;
		}

		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x1CB9D00", Offset = "0x1CB9D00", VA = "0x1CB9D00")]
		public bool TryGetCurrentSeason(DateTime currentLocalTime, out int season)
		{
			season = default;
			return default(bool);
		}

		[Token(Token = "0x60051E7")]
		[Address(RVA = "0x1CB9FF4", Offset = "0x1CB9FF4", VA = "0x1CB9FF4")]
		public bool IsActivePandoraBoxPeriod(DateTime localTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60051E8")]
		[Address(RVA = "0x1CB9E40", Offset = "0x1CB9E40", VA = "0x1CB9E40")]
		public bool IsSeasonActivePandoraBoxPeriod(int season, DateTime localTime)
		{
			return default(bool);
		}
	}
}
