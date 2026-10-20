using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x200001D")]
	internal class AppRequests : MenuBase
	{
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x38")]
		private string requestMessage;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x3C")]
		private string requestTo;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x40")]
		private string requestFilter;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x44")]
		private string requestExcludes;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x48")]
		private string requestMax;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x4C")]
		private string requestData;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x50")]
		private string requestTitle;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x54")]
		private string requestObjectID;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x58")]
		private int selectedAction;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x5C")]
		private string[] actionTypeStrings;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1E83268", Offset = "0x1E83268", VA = "0x1E83268")]
		public AppRequests()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1E8363C", Offset = "0x1E8363C", VA = "0x1E8363C", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1E84B3C", Offset = "0x1E84B3C", VA = "0x1E84B3C")]
		private OGActionType? GetSelectedOGActionType()
		{
			return null;
		}
	}
}
