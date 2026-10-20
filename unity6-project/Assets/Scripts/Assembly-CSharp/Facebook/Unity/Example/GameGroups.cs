using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x200001F")]
	internal class GameGroups : MenuBase
	{
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x38")]
		private string gamerGroupName;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x3C")]
		private string gamerGroupDesc;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x40")]
		private string gamerGroupPrivacy;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x44")]
		private string gamerGroupCurrentGroup;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1E86424", Offset = "0x1E86424", VA = "0x1E86424")]
		public GameGroups()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1E86520", Offset = "0x1E86520", VA = "0x1E86520", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1E87178", Offset = "0x1E87178", VA = "0x1E87178")]
		private void GroupCreateCB(IGroupCreateResult result)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E87AA4", Offset = "0x1E87AA4", VA = "0x1E87AA4")]
		private void GetAllGroupsCB(IGraphResult result)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1E86C88", Offset = "0x1E86C88", VA = "0x1E86C88")]
		private void CallFbGetAllOwnedGroups()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1E86E08", Offset = "0x1E86E08", VA = "0x1E86E08")]
		private void CallFbGetUserGroups()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1E86A80", Offset = "0x1E86A80", VA = "0x1E86A80")]
		private void CallCreateGroupDialog()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1E86B90", Offset = "0x1E86B90", VA = "0x1E86B90")]
		private void CallJoinGroupDialog()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1E86F88", Offset = "0x1E86F88", VA = "0x1E86F88")]
		private void CallFbPostToGamerGroup()
		{
		}
	}
}
