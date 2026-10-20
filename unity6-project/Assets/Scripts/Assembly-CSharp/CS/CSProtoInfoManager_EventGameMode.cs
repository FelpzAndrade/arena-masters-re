using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ACD")]
	public class CSProtoInfoManager_EventGameMode : Dictionary<int, EventGameModeInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<int, DateTime> GroupEndTimeDic;

		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, DateTime> GroupStartTimeDic;

		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x1FC223C", Offset = "0x1FC223C", VA = "0x1FC223C")]
		public CSProtoInfoManager_EventGameMode()
		{
		}

		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x1FCE620", Offset = "0x1FCE620", VA = "0x1FCE620")]
		private int TimeCompare(KeyValuePair<int, DateTime> firstPair, KeyValuePair<int, DateTime> nextPair)
		{
			return default(int);
		}

		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x1FCE798", Offset = "0x1FCE798", VA = "0x1FCE798", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x1FCECC0", Offset = "0x1FCECC0", VA = "0x1FCECC0", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x1FCECD0", Offset = "0x1FCECD0", VA = "0x1FCECD0", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x1FCF0E0", Offset = "0x1FCF0E0", VA = "0x1FCF0E0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004F39")]
		[Address(RVA = "0x1FCF0E4", Offset = "0x1FCF0E4", VA = "0x1FCF0E4")]
		public List<int> GetOpenEventModeGroupIDs(DateTime localTime)
		{
			return null;
		}

		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0x1FCF50C", Offset = "0x1FCF50C", VA = "0x1FCF50C")]
		public bool TryGetGroupEndTime(int groupID, out DateTime dateTime, bool showErrorLog = true)
		{
			dateTime = default;
			return default(bool);
		}

		[Token(Token = "0x6004F3B")]
		[Address(RVA = "0x1FCF768", Offset = "0x1FCF768", VA = "0x1FCF768")]
		public bool TryGetGroupStartTime(int groupID, out DateTime dateTime, bool showErrorLog = true)
		{
			dateTime = default;
			return default(bool);
		}

		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x1FCF9C4", Offset = "0x1FCF9C4", VA = "0x1FCF9C4")]
		public EventGameModeInfo GetInfo(int id)
		{
			return null;
		}

		[Token(Token = "0x6004F3D")]
		[Address(RVA = "0x1FCFA68", Offset = "0x1FCFA68", VA = "0x1FCFA68")]
		public Dictionary<int, EventGameModeInfo> GetNearOpendInfosByGroupIDs(DateTime nowTime, List<int> groupIDs)
		{
			return null;
		}

		[Token(Token = "0x6004F3E")]
		[Address(RVA = "0x1FD0074", Offset = "0x1FD0074", VA = "0x1FD0074")]
		public Dictionary<int, EventGameModeInfo> GetInfosByGroupIDs(List<int> groupIDs)
		{
			return null;
		}

		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x1FD02CC", Offset = "0x1FD02CC", VA = "0x1FD02CC")]
		public List<EventGameModeInfo> GetNowDateNearModeInfo(DateTime nowTime, int startCount, int notStartCount)
		{
			return null;
		}

		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x1FD0C10", Offset = "0x1FD0C10", VA = "0x1FD0C10")]
		public EventGameModeInfo GetGroupFirstInfo(int groupID)
		{
			return null;
		}
	}
}
