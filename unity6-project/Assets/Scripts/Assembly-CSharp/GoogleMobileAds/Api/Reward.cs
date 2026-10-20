using System;
using Il2CppDummyDll;

namespace GoogleMobileAds.Api
{
	[Token(Token = "0x2000042")]
	public class Reward : EventArgs
	{
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x8")]
		private string Type__BackingField;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x10")]
		private double Amount__BackingField;

		[Token(Token = "0x1700004B")]
		public string Type
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1F4BE38", Offset = "0x1F4BE38", VA = "0x1F4BE38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1F43F9C", Offset = "0x1F43F9C", VA = "0x1F43F9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public double Amount
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1F4BE40", Offset = "0x1F4BE40", VA = "0x1F4BE40")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1F43FA4", Offset = "0x1F43FA4", VA = "0x1F43FA4")]
			set
			{
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1F43EF8", Offset = "0x1F43EF8", VA = "0x1F43EF8")]
		public Reward()
		{
		}
	}
}
