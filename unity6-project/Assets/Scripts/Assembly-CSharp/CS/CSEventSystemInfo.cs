using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AD5")]
	public class CSEventSystemInfo
	{
		[Token(Token = "0x40032D6")]
		[FieldOffset(Offset = "0x8")]
		public int ID;

		[Token(Token = "0x40032D7")]
		[FieldOffset(Offset = "0xC")]
		public HottimeEventType EventType;

		[Token(Token = "0x40032D8")]
		[FieldOffset(Offset = "0x10")]
		public DateTime startDateTime;

		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x20")]
		public DateTime endDateTime;

		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x30")]
		public int StartHour;

		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x34")]
		public int StartMin;

		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x38")]
		public int EndHour;

		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x3C")]
		public int EndMin;

		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x40")]
		public List<DayOfWeek> DayOfWeeks;

		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x48")]
		[JsonIgnore]
		public TimeSpan eventStartTimeSpan;

		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0x50")]
		[JsonIgnore]
		public TimeSpan eventEndTimeSpan;

		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0x58")]
		public string eventName;

		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0x5C")]
		public string eventDescription;

		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x60")]
		public string iconPath;

		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x64")]
		private int eventMagnify__BackingField;

		[Token(Token = "0x17000B3A")]
		public int eventMagnify
		{
			[Token(Token = "0x6004F5B")]
			[Address(RVA = "0x222E8F8", Offset = "0x222E8F8", VA = "0x222E8F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F5C")]
			[Address(RVA = "0x222E900", Offset = "0x222E900", VA = "0x222E900")]
			set
			{
			}
		}

		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x222E7D0", Offset = "0x222E7D0", VA = "0x222E7D0")]
		public CSEventSystemInfo()
		{
		}

		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x222E908", Offset = "0x222E908", VA = "0x222E908")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
