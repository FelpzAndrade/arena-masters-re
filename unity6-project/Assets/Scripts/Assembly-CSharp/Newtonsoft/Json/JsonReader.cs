using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000CC")]
	public abstract class JsonReader
	{
		[Token(Token = "0x20000CD")]
		protected enum State
		{
			[Token(Token = "0x4000327")]
			Start = 0,
			[Token(Token = "0x4000328")]
			Complete = 1,
			[Token(Token = "0x4000329")]
			Property = 2,
			[Token(Token = "0x400032A")]
			ObjectStart = 3,
			[Token(Token = "0x400032B")]
			Object = 4,
			[Token(Token = "0x400032C")]
			ArrayStart = 5,
			[Token(Token = "0x400032D")]
			Array = 6,
			[Token(Token = "0x400032E")]
			Closed = 7,
			[Token(Token = "0x400032F")]
			PostValue = 8,
			[Token(Token = "0x4000330")]
			ConstructorStart = 9,
			[Token(Token = "0x4000331")]
			Constructor = 10,
			[Token(Token = "0x4000332")]
			Error = 11,
			[Token(Token = "0x4000333")]
			Finished = 12
		}

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x8")]
		private JsonToken _token;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0xC")]
		private object _value;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x10")]
		private Type _valueType;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x14")]
		private char _quoteChar;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x18")]
		private State _currentState;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x1C")]
		private JTokenType _currentTypeContext;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x20")]
		private int _top;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x24")]
		private readonly List<JTokenType> _stack;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x28")]
		private bool CloseInput__BackingField;

		[Token(Token = "0x170000ED")]
		protected State CurrentState
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0xF6CC54", Offset = "0xF6CC54", VA = "0xF6CC54")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x170000EE")]
		public bool CloseInput
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0xF6CC5C", Offset = "0xF6CC5C", VA = "0xF6CC5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0xF6CB54", Offset = "0xF6CB54", VA = "0xF6CB54")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public virtual char QuoteChar
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0xF6CC64", Offset = "0xF6CC64", VA = "0xF6CC64", Slot = "5")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xF6CC6C", Offset = "0xF6CC6C", VA = "0xF6CC6C", Slot = "6")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public virtual JsonToken TokenType
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xF6CC74", Offset = "0xF6CC74", VA = "0xF6CC74", Slot = "7")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x170000F1")]
		public virtual object Value
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xF6CC7C", Offset = "0xF6CC7C", VA = "0xF6CC7C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public virtual Type ValueType
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xF6CC84", Offset = "0xF6CC84", VA = "0xF6CC84", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		public virtual int Depth
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0xF6CC8C", Offset = "0xF6CC8C", VA = "0xF6CC8C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xF6CA8C", Offset = "0xF6CA8C", VA = "0xF6CA8C")]
		protected JsonReader()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xF6CC0C", Offset = "0xF6CC0C", VA = "0xF6CC0C", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xF6CB5C", Offset = "0xF6CB5C", VA = "0xF6CB5C")]
		private void Push(JTokenType value)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xF6CDC8", Offset = "0xF6CDC8", VA = "0xF6CDC8")]
		private JTokenType Pop()
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xF6CEC8", Offset = "0xF6CEC8", VA = "0xF6CEC8")]
		private JTokenType Peek()
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000686")]
		public abstract bool Read();

		[Token(Token = "0x6000687")]
		public abstract byte[] ReadAsBytes();

		[Token(Token = "0x6000688")]
		public abstract decimal? ReadAsDecimal();

		[Token(Token = "0x6000689")]
		public abstract DateTimeOffset? ReadAsDateTimeOffset();

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xF6CED0", Offset = "0xF6CED0", VA = "0xF6CED0")]
		public void Skip()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xF6CFB4", Offset = "0xF6CFB4", VA = "0xF6CFB4")]
		protected void SetToken(JsonToken newToken)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xF6D004", Offset = "0xF6D004", VA = "0xF6D004", Slot = "15")]
		protected virtual void SetToken(JsonToken newToken, object value)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xF6D140", Offset = "0xF6D140", VA = "0xF6D140")]
		private void ValidateEnd(JsonToken endToken)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xF6D564", Offset = "0xF6D564", VA = "0xF6D564")]
		protected void SetStateBasedOnCurrent()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xF6D774", Offset = "0xF6D774", VA = "0xF6D774")]
		internal static bool IsPrimitiveToken(JsonToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xF6CCE4", Offset = "0xF6CCE4", VA = "0xF6CCE4")]
		internal static bool IsStartToken(JsonToken token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xF6D38C", Offset = "0xF6D38C", VA = "0xF6D38C")]
		private JTokenType GetTypeForCloseToken(JsonToken token)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xF6D798", Offset = "0xF6D798", VA = "0xF6D798", Slot = "16")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xF6D7F4", Offset = "0xF6D7F4", VA = "0xF6D7F4", Slot = "17")]
		public virtual void Close()
		{
		}
	}
}
