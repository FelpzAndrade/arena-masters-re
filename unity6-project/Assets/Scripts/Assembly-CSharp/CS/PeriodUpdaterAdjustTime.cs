using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008AF")]
	public class PeriodUpdaterAdjustTime : PeriodUpdater
	{
		[Token(Token = "0x4002A8D")]
		[FieldOffset(Offset = "0x18")]
		protected float adjustTime;

		[Token(Token = "0x600466A")]
		[Address(RVA = "0x21AE0A8", Offset = "0x21AE0A8", VA = "0x21AE0A8")]
		public PeriodUpdaterAdjustTime(float tickTime, Action<float> action, bool runOnce = false)
		{
		}

		[Token(Token = "0x600466B")]
		[Address(RVA = "0x21AE0CC", Offset = "0x21AE0CC", VA = "0x21AE0CC", Slot = "4")]
		protected override void ResetTime()
		{
		}

		[Token(Token = "0x600466C")]
		[Address(RVA = "0x21AE0D8", Offset = "0x21AE0D8", VA = "0x21AE0D8")]
		private void ResetTime(float _adjustTime)
		{
		}

		[Token(Token = "0x600466D")]
		[Address(RVA = "0x21AE0E4", Offset = "0x21AE0E4", VA = "0x21AE0E4", Slot = "5")]
		public override void Update(float delta)
		{
		}
	}
}
