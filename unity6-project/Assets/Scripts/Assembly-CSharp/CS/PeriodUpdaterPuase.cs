using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008B0")]
	public class PeriodUpdaterPuase : PeriodUpdater
	{
		[Token(Token = "0x4002A8E")]
		[FieldOffset(Offset = "0x16")]
		private bool pause__BackingField;

		[Token(Token = "0x1700098A")]
		protected bool pause
		{
			[Token(Token = "0x600466F")]
			[Address(RVA = "0x21AE208", Offset = "0x21AE208", VA = "0x21AE208")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004670")]
			[Address(RVA = "0x21AE200", Offset = "0x21AE200", VA = "0x21AE200")]
			set
			{
			}
		}

		[Token(Token = "0x600466E")]
		[Address(RVA = "0x21AE1DC", Offset = "0x21AE1DC", VA = "0x21AE1DC")]
		public PeriodUpdaterPuase(float tickTime, Action<float> action, bool runOnce = false)
		{
		}

		[Token(Token = "0x6004671")]
		[Address(RVA = "0x21AE210", Offset = "0x21AE210", VA = "0x21AE210")]
		public void Restart()
		{
		}

		[Token(Token = "0x6004672")]
		[Address(RVA = "0x21AE21C", Offset = "0x21AE21C", VA = "0x21AE21C")]
		public void Pause()
		{
		}

		[Token(Token = "0x6004673")]
		[Address(RVA = "0x21AE228", Offset = "0x21AE228", VA = "0x21AE228")]
		public void SetTickTime(float tickTime)
		{
		}

		[Token(Token = "0x6004674")]
		[Address(RVA = "0x21AE230", Offset = "0x21AE230", VA = "0x21AE230", Slot = "5")]
		public override void Update(float delta)
		{
		}
	}
}
