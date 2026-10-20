using System;
using System.Collections.Generic;
using GoogleMobileAds.Api.Mediation;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000036")]
	public class AdRequest
	{
		[Token(Token = "0x2000037")]
		public class Builder
		{
			[Token(Token = "0x40000FA")]
			[FieldOffset(Offset = "0x8")]
			private List<string> TestDevices__BackingField;

			[Token(Token = "0x40000FB")]
			[FieldOffset(Offset = "0xC")]
			private HashSet<string> Keywords__BackingField;

			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x10")]
			private DateTime? Birthday__BackingField;

			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x28")]
			private Gender? Gender__BackingField;

			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x30")]
			private bool? ChildDirectedTreatmentTag__BackingField;

			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x34")]
			private Dictionary<string, string> Extras__BackingField;

			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x38")]
			private List<MediationExtras> MediationExtras__BackingField;

			[Token(Token = "0x1700003C")]
			internal List<string> TestDevices
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0x1F45310", Offset = "0x1F45310", VA = "0x1F45310")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000143")]
				[Address(RVA = "0x1F45640", Offset = "0x1F45640", VA = "0x1F45640")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			internal HashSet<string> Keywords
			{
				[Token(Token = "0x6000144")]
				[Address(RVA = "0x1F45320", Offset = "0x1F45320", VA = "0x1F45320")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000145")]
				[Address(RVA = "0x1F45648", Offset = "0x1F45648", VA = "0x1F45648")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003E")]
			internal DateTime? Birthday
			{
				[Token(Token = "0x6000146")]
				[Address(RVA = "0x1F45330", Offset = "0x1F45330", VA = "0x1F45330")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000147")]
				[Address(RVA = "0x1F45650", Offset = "0x1F45650", VA = "0x1F45650")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003F")]
			internal Gender? Gender
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x1F45374", Offset = "0x1F45374", VA = "0x1F45374")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000149")]
				[Address(RVA = "0x1F4567C", Offset = "0x1F4567C", VA = "0x1F4567C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000040")]
			internal bool? ChildDirectedTreatmentTag
			{
				[Token(Token = "0x600014A")]
				[Address(RVA = "0x1F45394", Offset = "0x1F45394", VA = "0x1F45394")]
				get
				{
					return null;
				}
				[Token(Token = "0x600014B")]
				[Address(RVA = "0x1F45688", Offset = "0x1F45688", VA = "0x1F45688")]
				private set
				{
				}
			}

			[Token(Token = "0x17000041")]
			internal Dictionary<string, string> Extras
			{
				[Token(Token = "0x600014C")]
				[Address(RVA = "0x1F453A4", Offset = "0x1F453A4", VA = "0x1F453A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600014D")]
				[Address(RVA = "0x1F45690", Offset = "0x1F45690", VA = "0x1F45690")]
				private set
				{
				}
			}

			[Token(Token = "0x17000042")]
			internal List<MediationExtras> MediationExtras
			{
				[Token(Token = "0x600014E")]
				[Address(RVA = "0x1F453B4", Offset = "0x1F453B4", VA = "0x1F453B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600014F")]
				[Address(RVA = "0x1F45698", Offset = "0x1F45698", VA = "0x1F45698")]
				private set
				{
				}
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1F453C4", Offset = "0x1F453C4", VA = "0x1F453C4")]
			public Builder()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1F456A0", Offset = "0x1F456A0", VA = "0x1F456A0")]
			public Builder AddKeyword(string keyword)
			{
				return null;
			}

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1F45744", Offset = "0x1F45744", VA = "0x1F45744")]
			public Builder AddTestDevice(string deviceId)
			{
				return null;
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1F457E8", Offset = "0x1F457E8", VA = "0x1F457E8")]
			public AdRequest Build()
			{
				return null;
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1F45878", Offset = "0x1F45878", VA = "0x1F45878")]
			public Builder SetBirthday(DateTime birthday)
			{
				return null;
			}

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1F45958", Offset = "0x1F45958", VA = "0x1F45958")]
			public Builder SetGender(Gender gender)
			{
				return null;
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1F45A08", Offset = "0x1F45A08", VA = "0x1F45A08")]
			public Builder AddMediationExtras(MediationExtras extras)
			{
				return null;
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1F45AAC", Offset = "0x1F45AAC", VA = "0x1F45AAC")]
			public Builder TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
			{
				return null;
			}

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1F45B54", Offset = "0x1F45B54", VA = "0x1F45B54")]
			public Builder AddExtra(string key, string value)
			{
				return null;
			}
		}

		[Token(Token = "0x40000F1")]
		public const string Version = "3.3.0";

		[Token(Token = "0x40000F2")]
		public const string TestDeviceSimulator = "SIMULATOR";

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x8")]
		private List<string> TestDevices__BackingField;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0xC")]
		private HashSet<string> Keywords__BackingField;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? Birthday__BackingField;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x28")]
		private Gender? Gender__BackingField;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		private bool? TagForChildDirectedTreatment__BackingField;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<string, string> Extras__BackingField;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x38")]
		private List<MediationExtras> MediationExtras__BackingField;

		[Token(Token = "0x17000035")]
		public List<string> TestDevices
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1F440D4", Offset = "0x1F440D4", VA = "0x1F440D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1F45318", Offset = "0x1F45318", VA = "0x1F45318")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public HashSet<string> Keywords
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1F440CC", Offset = "0x1F440CC", VA = "0x1F440CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1F45328", Offset = "0x1F45328", VA = "0x1F45328")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public DateTime? Birthday
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1F440DC", Offset = "0x1F440DC", VA = "0x1F440DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1F45348", Offset = "0x1F45348", VA = "0x1F45348")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Gender? Gender
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1F440F4", Offset = "0x1F440F4", VA = "0x1F440F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1F45388", Offset = "0x1F45388", VA = "0x1F45388")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool? TagForChildDirectedTreatment
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1F44108", Offset = "0x1F44108", VA = "0x1F44108")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1F4539C", Offset = "0x1F4539C", VA = "0x1F4539C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Dictionary<string, string> Extras
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1F44110", Offset = "0x1F44110", VA = "0x1F44110")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1F453AC", Offset = "0x1F453AC", VA = "0x1F453AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public List<MediationExtras> MediationExtras
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1F44118", Offset = "0x1F44118", VA = "0x1F44118")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1F453BC", Offset = "0x1F453BC", VA = "0x1F453BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1F4518C", Offset = "0x1F4518C", VA = "0x1F4518C")]
		private AdRequest(Builder builder)
		{
		}
	}
}
