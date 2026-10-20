using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x2000023")]
	internal class Pay : MenuBase
	{
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x38")]
		private string payProduct;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1E8B4EC", Offset = "0x1E8B4EC", VA = "0x1E8B4EC")]
		public Pay()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1E8B5AC", Offset = "0x1E8B5AC", VA = "0x1E8B5AC", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1E8B66C", Offset = "0x1E8B66C", VA = "0x1E8B66C")]
		private void CallFBPay()
		{
		}
	}
}
