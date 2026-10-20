using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010B0")]
	public class NPOptions
	{
		[Token(Token = "0x20010B1")]
		public enum PushAgreeOption
		{
			[Token(Token = "0x4005C5A")]
			NOT_INITIALIZED = -1,
			[Token(Token = "0x4005C5B")]
			ENABLED = 0,
			[Token(Token = "0x4005C5C")]
			DISABLED = 1
		}

		[Token(Token = "0x20010B2")]
		public enum GoogleSignInInsteadOfGcidLoginOption
		{
			[Token(Token = "0x4005C5E")]
			NOT_INITIALIZED = -1,
			[Token(Token = "0x4005C5F")]
			DISABLED = 0,
			[Token(Token = "0x4005C60")]
			ENABLED = 1
		}

		[Token(Token = "0x20010B3")]
		public enum NgsmOption
		{
			[Token(Token = "0x4005C62")]
			NOT_INITIALIZED = -1,
			[Token(Token = "0x4005C63")]
			DISABLED = 0,
			[Token(Token = "0x4005C64")]
			ENABLED = 1
		}

		[Serializable]
		[Token(Token = "0x20010B4")]
		private class NPOptionSerializableWrapper
		{
			[Token(Token = "0x4005C65")]
			[FieldOffset(Offset = "0x8")]
			public List<NPLoginType> defaultLoginTypeList;

			[Token(Token = "0x4005C66")]
			[FieldOffset(Offset = "0xC")]
			public PushAgreeOption skipPushAgree;

			[Token(Token = "0x4005C67")]
			[FieldOffset(Offset = "0x10")]
			public GoogleSignInInsteadOfGcidLoginOption googleSignInInsteadOfGcidLogin;

			[Token(Token = "0x4005C68")]
			[FieldOffset(Offset = "0x14")]
			public NgsmOption useNgsm;

			[Token(Token = "0x6007DEF")]
			[Address(RVA = "0x11DDE20", Offset = "0x11DDE20", VA = "0x11DDE20")]
			public NPOptionSerializableWrapper(NPOptions options)
			{
			}

			[Token(Token = "0x6007DF0")]
			[Address(RVA = "0x11DE0F8", Offset = "0x11DE0F8", VA = "0x11DE0F8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007DF1")]
			[Address(RVA = "0x11DDE6C", Offset = "0x11DDE6C", VA = "0x11DDE6C")]
			public static NPOptions FromJson(string jsonRaw)
			{
				return null;
			}
		}

		[Token(Token = "0x4005C55")]
		[FieldOffset(Offset = "0x8")]
		private List<NPLoginType> defaultLoginTypeList;

		[Token(Token = "0x4005C56")]
		[FieldOffset(Offset = "0xC")]
		private PushAgreeOption skipPushAgree;

		[Token(Token = "0x4005C57")]
		[FieldOffset(Offset = "0x10")]
		private GoogleSignInInsteadOfGcidLoginOption googleSignInInsteadOfGcidLogin;

		[Token(Token = "0x4005C58")]
		[FieldOffset(Offset = "0x14")]
		private NgsmOption useNgsm;

		[Token(Token = "0x17000F6C")]
		public List<NPLoginType> DefaultLoginTypeList
		{
			[Token(Token = "0x6007DE5")]
			[Address(RVA = "0x11DDCF4", Offset = "0x11DDCF4", VA = "0x11DDCF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007DE6")]
			[Address(RVA = "0x11DDCFC", Offset = "0x11DDCFC", VA = "0x11DDCFC")]
			set
			{
			}
		}

		[Token(Token = "0x6007DE4")]
		[Address(RVA = "0x11D78C8", Offset = "0x11D78C8", VA = "0x11D78C8")]
		public NPOptions()
		{
		}

		[Token(Token = "0x6007DE7")]
		[Address(RVA = "0x11DDD04", Offset = "0x11DDD04", VA = "0x11DDD04")]
		public bool isSkipPushAgree()
		{
			return default(bool);
		}

		[Token(Token = "0x6007DE8")]
		[Address(RVA = "0x11DDD14", Offset = "0x11DDD14", VA = "0x11DDD14")]
		public void setSkipPushAgree(bool skip)
		{
		}

		[Token(Token = "0x6007DE9")]
		[Address(RVA = "0x11DDD1C", Offset = "0x11DDD1C", VA = "0x11DDD1C")]
		public bool isGoogleSignInInsteadOfGcidLogin()
		{
			return default(bool);
		}

		[Token(Token = "0x6007DEA")]
		[Address(RVA = "0x11DDD2C", Offset = "0x11DDD2C", VA = "0x11DDD2C")]
		public void setGoogleSignInInsteadOfGcidLogin(bool enable)
		{
		}

		[Token(Token = "0x6007DEB")]
		[Address(RVA = "0x11DDD34", Offset = "0x11DDD34", VA = "0x11DDD34")]
		public bool isNgsmEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6007DEC")]
		[Address(RVA = "0x11DDD44", Offset = "0x11DDD44", VA = "0x11DDD44")]
		public void setNgsmEnabled(bool enable)
		{
		}

		[Token(Token = "0x6007DED")]
		[Address(RVA = "0x11DDD4C", Offset = "0x11DDD4C", VA = "0x11DDD4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007DEE")]
		[Address(RVA = "0x11D78C4", Offset = "0x11D78C4", VA = "0x11D78C4")]
		internal static NPOptions FromJson(string jsonRaw)
		{
			return null;
		}
	}
}
