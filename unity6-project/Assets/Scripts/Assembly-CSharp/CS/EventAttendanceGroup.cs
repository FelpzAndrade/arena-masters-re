using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AC9")]
	public class EventAttendanceGroup
	{
		[Token(Token = "0x4003296")]
		[FieldOffset(Offset = "0x8")]
		private int GroupId__BackingField;

		[Token(Token = "0x4003297")]
		[FieldOffset(Offset = "0xC")]
		private string Title__BackingField;

		[Token(Token = "0x4003298")]
		[FieldOffset(Offset = "0x10")]
		private DateTime StartTime__BackingField;

		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x20")]
		private DateTime EndTime__BackingField;

		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, CSEventAttendanceBookItem> RewardList__BackingField;

		[Token(Token = "0x17000B31")]
		public int GroupId
		{
			[Token(Token = "0x6004F1D")]
			[Address(RVA = "0x1CDC5FC", Offset = "0x1CDC5FC", VA = "0x1CDC5FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004F1E")]
			[Address(RVA = "0x1CDC604", Offset = "0x1CDC604", VA = "0x1CDC604")]
			set
			{
			}
		}

		[Token(Token = "0x17000B32")]
		public string Title
		{
			[Token(Token = "0x6004F1F")]
			[Address(RVA = "0x1CDC60C", Offset = "0x1CDC60C", VA = "0x1CDC60C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F20")]
			[Address(RVA = "0x1CDC614", Offset = "0x1CDC614", VA = "0x1CDC614")]
			set
			{
			}
		}

		[Token(Token = "0x17000B33")]
		public DateTime StartTime
		{
			[Token(Token = "0x6004F21")]
			[Address(RVA = "0x1CDC61C", Offset = "0x1CDC61C", VA = "0x1CDC61C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004F22")]
			[Address(RVA = "0x1CDC62C", Offset = "0x1CDC62C", VA = "0x1CDC62C")]
			set
			{
			}
		}

		[Token(Token = "0x17000B34")]
		public DateTime EndTime
		{
			[Token(Token = "0x6004F23")]
			[Address(RVA = "0x1CDC644", Offset = "0x1CDC644", VA = "0x1CDC644")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004F24")]
			[Address(RVA = "0x1CDC654", Offset = "0x1CDC654", VA = "0x1CDC654")]
			set
			{
			}
		}

		[Token(Token = "0x17000B35")]
		public Dictionary<int, CSEventAttendanceBookItem> RewardList
		{
			[Token(Token = "0x6004F25")]
			[Address(RVA = "0x1CDC66C", Offset = "0x1CDC66C", VA = "0x1CDC66C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F26")]
			[Address(RVA = "0x1CDC674", Offset = "0x1CDC674", VA = "0x1CDC674")]
			set
			{
			}
		}

		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x1CDC5F4", Offset = "0x1CDC5F4", VA = "0x1CDC5F4")]
		public EventAttendanceGroup()
		{
		}
	}
}
