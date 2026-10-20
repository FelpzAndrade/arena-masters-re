using Il2CppDummyDll;

namespace ExitGames.Client.DemoParticle
{
	[Token(Token = "0x2000323")]
	public class TimeKeeper
	{
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x8")]
		private int lastExecutionTime;

		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0xC")]
		private bool shouldExecute;

		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x10")]
		private int Interval__BackingField;

		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0x14")]
		private bool IsEnabled__BackingField;

		[Token(Token = "0x17000490")]
		public int Interval
		{
			[Token(Token = "0x6001ACE")]
			[Address(RVA = "0x1E763C8", Offset = "0x1E763C8", VA = "0x1E763C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001ACF")]
			[Address(RVA = "0x1E763C0", Offset = "0x1E763C0", VA = "0x1E763C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000491")]
		public bool IsEnabled
		{
			[Token(Token = "0x6001AD0")]
			[Address(RVA = "0x1E763D0", Offset = "0x1E763D0", VA = "0x1E763D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AD1")]
			[Address(RVA = "0x1E763B8", Offset = "0x1E763B8", VA = "0x1E763B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000492")]
		public bool ShouldExecute
		{
			[Token(Token = "0x6001AD2")]
			[Address(RVA = "0x1E763D8", Offset = "0x1E763D8", VA = "0x1E763D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AD3")]
			[Address(RVA = "0x1E76430", Offset = "0x1E76430", VA = "0x1E76430")]
			set
			{
			}
		}

		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x1E7637C", Offset = "0x1E7637C", VA = "0x1E7637C")]
		public TimeKeeper(int interval)
		{
		}

		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x1E76438", Offset = "0x1E76438", VA = "0x1E76438")]
		public void Reset()
		{
		}
	}
}
