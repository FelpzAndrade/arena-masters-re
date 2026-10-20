using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200088F")]
	public class receipt
	{
		[Token(Token = "0x4002A06")]
		[FieldOffset(Offset = "0x8")]
		public string orderId;

		[Token(Token = "0x4002A07")]
		[FieldOffset(Offset = "0xC")]
		public string packageName;

		[Token(Token = "0x4002A08")]
		[FieldOffset(Offset = "0x10")]
		public string productId;

		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x18")]
		public long purchaseTime;

		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0x20")]
		public int purchaseState;

		[Token(Token = "0x4002A0B")]
		[FieldOffset(Offset = "0x24")]
		public string developerPayload;

		[Token(Token = "0x4002A0C")]
		[FieldOffset(Offset = "0x28")]
		public string purchaseToken;

		[Token(Token = "0x60045D0")]
		[Address(RVA = "0x21C0958", Offset = "0x21C0958", VA = "0x21C0958")]
		public receipt()
		{
		}

		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x21C0960", Offset = "0x21C0960", VA = "0x21C0960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
