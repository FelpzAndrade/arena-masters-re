using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A81")]
	public class CSProtoInfoManager_AttendanceBook : Dictionary<int, CSAttendanceBookItem>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int NewbieIndexStart;

		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ReturnerIndexStart;

		[Token(Token = "0x40030BC")]
		[FieldOffset(Offset = "0x34")]
		private int NormalAttendanceCount__BackingField;

		[Token(Token = "0x40030BD")]
		[FieldOffset(Offset = "0x38")]
		private int ReturnerAttendanceCount__BackingField;

		[Token(Token = "0x40030BE")]
		[FieldOffset(Offset = "0x3C")]
		private int NewbieAttendanceCount__BackingField;

		[Token(Token = "0x17000B02")]
		public int NormalAttendanceCount
		{
			[Token(Token = "0x6004E00")]
			[Address(RVA = "0x1FC31F4", Offset = "0x1FC31F4", VA = "0x1FC31F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004E01")]
			[Address(RVA = "0x1FC31FC", Offset = "0x1FC31FC", VA = "0x1FC31FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B03")]
		public int ReturnerAttendanceCount
		{
			[Token(Token = "0x6004E02")]
			[Address(RVA = "0x1FC3204", Offset = "0x1FC3204", VA = "0x1FC3204")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004E03")]
			[Address(RVA = "0x1FC320C", Offset = "0x1FC320C", VA = "0x1FC320C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B04")]
		public int NewbieAttendanceCount
		{
			[Token(Token = "0x6004E04")]
			[Address(RVA = "0x1FC3214", Offset = "0x1FC3214", VA = "0x1FC3214")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004E05")]
			[Address(RVA = "0x1FC321C", Offset = "0x1FC321C", VA = "0x1FC321C")]
			private set
			{
			}
		}

		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x1FC1A88", Offset = "0x1FC1A88", VA = "0x1FC1A88")]
		public CSProtoInfoManager_AttendanceBook()
		{
		}

		[Token(Token = "0x6004E06")]
		[Address(RVA = "0x1FC3224", Offset = "0x1FC3224", VA = "0x1FC3224", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x1FC3234", Offset = "0x1FC3234", VA = "0x1FC3234", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E08")]
		[Address(RVA = "0x1FC3238", Offset = "0x1FC3238", VA = "0x1FC3238", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E09")]
		[Address(RVA = "0x1FC35BC", Offset = "0x1FC35BC", VA = "0x1FC35BC", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x1FC38D4", Offset = "0x1FC38D4", VA = "0x1FC38D4", Slot = "46")]
		public virtual void CookingList(List<CSAttendanceBookItem> list)
		{
		}
	}
}
