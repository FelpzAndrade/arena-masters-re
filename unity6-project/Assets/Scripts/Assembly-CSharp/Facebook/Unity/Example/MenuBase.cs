using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x2000019")]
	internal abstract class MenuBase : ConsoleBase
	{
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		private static ShareDialogMode shareDialogMode;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1E825B0", Offset = "0x1E825B0", VA = "0x1E825B0")]
		protected MenuBase()
		{
		}

		[Token(Token = "0x6000095")]
		protected abstract void GetGui();

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1E8A57C", Offset = "0x1E8A57C", VA = "0x1E8A57C", Slot = "6")]
		protected virtual bool ShowDialogModeSelector()
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1E8A584", Offset = "0x1E8A584", VA = "0x1E8A584", Slot = "7")]
		protected virtual bool ShowBackButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1E87308", Offset = "0x1E87308", VA = "0x1E87308")]
		protected void HandleResult(IResult result)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1E8A58C", Offset = "0x1E8A58C", VA = "0x1E8A58C")]
		protected void OnGUI()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1E8AAD4", Offset = "0x1E8AAD4", VA = "0x1E8AAD4")]
		private void AddStatus()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1E8ACC0", Offset = "0x1E8ACC0", VA = "0x1E8ACC0")]
		private void AddBackButton()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1E8AE30", Offset = "0x1E8AE30", VA = "0x1E8AE30")]
		private void AddLogButton()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1E8AF28", Offset = "0x1E8AF28", VA = "0x1E8AF28")]
		private void AddDialogModeButtons()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1E8B2CC", Offset = "0x1E8B2CC", VA = "0x1E8B2CC")]
		private void AddDialogModeButton(ShareDialogMode mode)
		{
		}
	}
}
