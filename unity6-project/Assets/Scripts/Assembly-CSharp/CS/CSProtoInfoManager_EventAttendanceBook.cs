using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ACA")]
	public class CSProtoInfoManager_EventAttendanceBook : Dictionary<int, EventAttendanceGroup>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004F27")]
		[Address(RVA = "0x1FC1B0C", Offset = "0x1FC1B0C", VA = "0x1FC1B0C")]
		public CSProtoInfoManager_EventAttendanceBook()
		{
		}

		[Token(Token = "0x6004F28")]
		[Address(RVA = "0x1FCD624", Offset = "0x1FCD624", VA = "0x1FCD624", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F29")]
		[Address(RVA = "0x1FCD634", Offset = "0x1FCD634", VA = "0x1FCD634", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004F2A")]
		[Address(RVA = "0x1FCD638", Offset = "0x1FCD638", VA = "0x1FCD638", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F2B")]
		[Address(RVA = "0x1FCD640", Offset = "0x1FCD640", VA = "0x1FCD640", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F2C")]
		[Address(RVA = "0x1FCDC58", Offset = "0x1FCDC58", VA = "0x1FCDC58", Slot = "46")]
		public virtual void CookingList(List<CSEventAttendanceBookItem> list)
		{
		}

		[Token(Token = "0x6004F2D")]
		[Address(RVA = "0x1FCE0FC", Offset = "0x1FCE0FC", VA = "0x1FCE0FC")]
		public EventAttendanceGroup GetNowProgressEventAttendGroup(DateTime nowDateLocalTime)
		{
			return null;
		}
	}
}
