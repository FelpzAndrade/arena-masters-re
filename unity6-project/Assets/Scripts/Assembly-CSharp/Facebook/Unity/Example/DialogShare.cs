using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x200001E")]
	internal class DialogShare : MenuBase
	{
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x38")]
		private string shareLink;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x3C")]
		private string shareTitle;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x40")]
		private string shareDescription;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x44")]
		private string shareImage;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x48")]
		private string feedTo;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x4C")]
		private string feedLink;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x50")]
		private string feedTitle;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x54")]
		private string feedCaption;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x58")]
		private string feedDescription;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x5C")]
		private string feedImage;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x60")]
		private string feedMediaSource;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1E8598C", Offset = "0x1E8598C", VA = "0x1E8598C")]
		public DialogShare()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1E85B18", Offset = "0x1E85B18", VA = "0x1E85B18", Slot = "6")]
		protected override bool ShowDialogModeSelector()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1E85B20", Offset = "0x1E85B20", VA = "0x1E85B20", Slot = "5")]
		protected override void GetGui()
		{
		}
	}
}
