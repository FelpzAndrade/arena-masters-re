using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x2000022")]
	internal sealed class MainMenu : MenuBase
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1E8955C", Offset = "0x1E8955C", VA = "0x1E8955C")]
		public MainMenu()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1E89560", Offset = "0x1E89560", VA = "0x1E89560", Slot = "7")]
		protected override bool ShowBackButton()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1E89568", Offset = "0x1E89568", VA = "0x1E89568", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1E89F78", Offset = "0x1E89F78", VA = "0x1E89F78")]
		private void CallFBLogin()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1E8A11C", Offset = "0x1E8A11C", VA = "0x1E8A11C")]
		private void CallFBLoginForPublish()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E8A288", Offset = "0x1E8A288", VA = "0x1E8A288")]
		private void CallFBLogout()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E8A328", Offset = "0x1E8A328", VA = "0x1E8A328")]
		private void OnInitComplete()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E8A408", Offset = "0x1E8A408", VA = "0x1E8A408")]
		private void OnHideUnity(bool isGameShown)
		{
		}
	}
}
