using System.Collections.Generic;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api.Mediation
{
	[Token(Token = "0x2000040")]
	public abstract class MediationExtras
	{
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, string> Extras__BackingField;

		[Token(Token = "0x17000048")]
		public Dictionary<string, string> Extras
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1F44120", Offset = "0x1F44120", VA = "0x1F44120")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1F49F90", Offset = "0x1F49F90", VA = "0x1F49F90")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public abstract string AndroidMediationExtraBuilderClassName
		{
			[Token(Token = "0x6000197")]
			get;
		}

		[Token(Token = "0x1700004A")]
		public abstract string IOSMediationExtraBuilderClassName
		{
			[Token(Token = "0x6000198")]
			get;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1F49F88", Offset = "0x1F49F88", VA = "0x1F49F88")]
		protected MediationExtras()
		{
		}
	}
}
