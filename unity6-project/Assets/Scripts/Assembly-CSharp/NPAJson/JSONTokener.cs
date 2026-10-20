using Il2CppDummyDll;

namespace NPAJson
{
	[Token(Token = "0x200108D")]
	public class JSONTokener
	{
		[Token(Token = "0x4005941")]
		[FieldOffset(Offset = "0x8")]
		private string inputStr;

		[Token(Token = "0x4005942")]
		[FieldOffset(Offset = "0xC")]
		private int pos;

		[Token(Token = "0x6007CE8")]
		[Address(RVA = "0x11DF404", Offset = "0x11DF404", VA = "0x11DF404")]
		public JSONTokener(string inputStr)
		{
		}

		[Token(Token = "0x6007CE9")]
		[Address(RVA = "0x11DF25C", Offset = "0x11DF25C", VA = "0x11DF25C")]
		public object nextValue()
		{
			return null;
		}

		[Token(Token = "0x6007CEA")]
		[Address(RVA = "0x11E2B28", Offset = "0x11E2B28", VA = "0x11E2B28")]
		private int nextCleanInternal()
		{
			return default(int);
		}

		[Token(Token = "0x6007CEB")]
		[Address(RVA = "0x11E3EDC", Offset = "0x11E3EDC", VA = "0x11E3EDC")]
		private void skipToEndOfLine()
		{
		}

		[Token(Token = "0x6007CEC")]
		[Address(RVA = "0x11E35E0", Offset = "0x11E35E0", VA = "0x11E35E0")]
		public string nextString(char quote)
		{
			return null;
		}

		[Token(Token = "0x6007CED")]
		[Address(RVA = "0x11E3F60", Offset = "0x11E3F60", VA = "0x11E3F60")]
		private char readEscapeCharacter()
		{
			return default(char);
		}

		[Token(Token = "0x6007CEE")]
		[Address(RVA = "0x11E3860", Offset = "0x11E3860", VA = "0x11E3860")]
		private object readLiteral()
		{
			return null;
		}

		[Token(Token = "0x6007CEF")]
		[Address(RVA = "0x11E4244", Offset = "0x11E4244", VA = "0x11E4244")]
		private string nextToInternal(string excluded)
		{
			return null;
		}

		[Token(Token = "0x6007CF0")]
		[Address(RVA = "0x11E2DE0", Offset = "0x11E2DE0", VA = "0x11E2DE0")]
		private JSONObject readObject()
		{
			return null;
		}

		[Token(Token = "0x6007CF1")]
		[Address(RVA = "0x11E33D8", Offset = "0x11E33D8", VA = "0x11E33D8")]
		private JSONArray readArray()
		{
			return null;
		}

		[Token(Token = "0x6007CF2")]
		[Address(RVA = "0x11E2CF8", Offset = "0x11E2CF8", VA = "0x11E2CF8")]
		public JSONException syntaxError(string message)
		{
			return null;
		}

		[Token(Token = "0x6007CF3")]
		[Address(RVA = "0x11E4328", Offset = "0x11E4328", VA = "0x11E4328", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007CF4")]
		[Address(RVA = "0x11E45A8", Offset = "0x11E45A8", VA = "0x11E45A8")]
		public bool more()
		{
			return default(bool);
		}

		[Token(Token = "0x6007CF5")]
		[Address(RVA = "0x11E45EC", Offset = "0x11E45EC", VA = "0x11E45EC")]
		public char next()
		{
			return default(char);
		}

		[Token(Token = "0x6007CF6")]
		[Address(RVA = "0x11E4654", Offset = "0x11E4654", VA = "0x11E4654")]
		public char next(char c)
		{
			return default(char);
		}

		[Token(Token = "0x6007CF7")]
		[Address(RVA = "0x11E4914", Offset = "0x11E4914", VA = "0x11E4914")]
		public char nextClean()
		{
			return default(char);
		}

		[Token(Token = "0x6007CF8")]
		[Address(RVA = "0x11E4930", Offset = "0x11E4930", VA = "0x11E4930")]
		public string next(int length)
		{
			return null;
		}

		[Token(Token = "0x6007CF9")]
		[Address(RVA = "0x11E4A90", Offset = "0x11E4A90", VA = "0x11E4A90")]
		public string nextTo(string excluded)
		{
			return null;
		}

		[Token(Token = "0x6007CFA")]
		[Address(RVA = "0x11E4B74", Offset = "0x11E4B74", VA = "0x11E4B74")]
		public string nextTo(char excluded)
		{
			return null;
		}

		[Token(Token = "0x6007CFB")]
		[Address(RVA = "0x11E4C48", Offset = "0x11E4C48", VA = "0x11E4C48")]
		public void skipPast(string thru)
		{
		}

		[Token(Token = "0x6007CFC")]
		[Address(RVA = "0x11E4CC4", Offset = "0x11E4CC4", VA = "0x11E4CC4")]
		public char skipTo(char to)
		{
			return default(char);
		}

		[Token(Token = "0x6007CFD")]
		[Address(RVA = "0x11E4D14", Offset = "0x11E4D14", VA = "0x11E4D14")]
		public void back()
		{
		}

		[Token(Token = "0x6007CFE")]
		[Address(RVA = "0x11E4D28", Offset = "0x11E4D28", VA = "0x11E4D28")]
		public static int dehexchar(char hex)
		{
			return default(int);
		}
	}
}
