using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x20008C3")]
	public abstract class CSNetProcessBase
	{
		[Token(Token = "0x20008C4")]
		private sealed class _003CMakeNetCommand_003Ec__AnonStoreyEB
		{
			[Token(Token = "0x4002ACC")]
			[FieldOffset(Offset = "0x8")]
			internal CSNetParameters param;

			[Token(Token = "0x60046DB")]
			[Address(RVA = "0x1FBDD98", Offset = "0x1FBDD98", VA = "0x1FBDD98")]
			public _003CMakeNetCommand_003Ec__AnonStoreyEB()
			{
			}

			[Token(Token = "0x60046DC")]
			[Address(RVA = "0x1FBEA78", Offset = "0x1FBEA78", VA = "0x1FBEA78")]
			internal void _003C_003Em__95(KeyValuePair<string, object> each)
			{
			}
		}

		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x8")]
		protected ApiReturnCode m_nLastErrorCode;

		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0xC")]
		protected string m_strErrorMsg;

		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_isProcessed;

		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x14")]
		private CSNetParameters m_parameters;

		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0x18")]
		protected NetCallback m_callbackResponseUser;

		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x1C")]
		private NetCallback m_callbackResponse;

		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x20")]
		protected PeriodUpdater updaterTimeout;

		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x24")]
		protected CSNetProcessor m_processor;

		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x28")]
		protected JObject m_ResponseData;

		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x2C")]
		protected JObject m_RequestPostBody;

		[Token(Token = "0x1700098C")]
		public virtual float TimeoutSeconds
		{
			[Token(Token = "0x60046BF")]
			[Address(RVA = "0x1FBD890", Offset = "0x1FBD890", VA = "0x1FBD890", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700098D")]
		public virtual bool IsError
		{
			[Token(Token = "0x60046C0")]
			[Address(RVA = "0x1FBD89C", Offset = "0x1FBD89C", VA = "0x1FBD89C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700098E")]
		public virtual bool IsProcessed
		{
			[Token(Token = "0x60046C1")]
			[Address(RVA = "0x1FBD8B4", Offset = "0x1FBD8B4", VA = "0x1FBD8B4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700098F")]
		public virtual string Name
		{
			[Token(Token = "0x60046C2")]
			[Address(RVA = "0x1FBD8BC", Offset = "0x1FBD8BC", VA = "0x1FBD8BC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x1FBD798", Offset = "0x1FBD798", VA = "0x1FBD798")]
		protected CSNetProcessBase()
		{
		}

		[Token(Token = "0x60046C3")]
		[Address(RVA = "0x1FBD934", Offset = "0x1FBD934", VA = "0x1FBD934")]
		protected bool IsSuccessResponse()
		{
			return default(bool);
		}

		[Token(Token = "0x60046C4")]
		[Address(RVA = "0x1FBD990", Offset = "0x1FBD990", VA = "0x1FBD990")]
		public void SetNetProcessor(CSNetProcessor processor)
		{
		}

		[Token(Token = "0x60046C5")]
		[Address(RVA = "0x1FBD998", Offset = "0x1FBD998", VA = "0x1FBD998")]
		public void SetParams(CSNetParameters param)
		{
		}

		[Token(Token = "0x60046C6")]
		[Address(RVA = "0x1FBD9A0", Offset = "0x1FBD9A0", VA = "0x1FBD9A0")]
		public void SetPostBody(JObject postBody)
		{
		}

		[Token(Token = "0x60046C7")]
		[Address(RVA = "0x1FBD9A8", Offset = "0x1FBD9A8", VA = "0x1FBD9A8")]
		public void ChangeValueParam(string key, object obj)
		{
		}

		[Token(Token = "0x60046C8")]
		[Address(RVA = "0x1FBDAB8", Offset = "0x1FBDAB8", VA = "0x1FBDAB8")]
		public void SetUserCallback(NetCallback callback)
		{
		}

		[Token(Token = "0x60046C9")]
		[Address(RVA = "0x1FBDAC0", Offset = "0x1FBDAC0", VA = "0x1FBDAC0")]
		protected void SetResponseError(ApiReturnCode nErrorCode, string strErrorMsg)
		{
		}

		[Token(Token = "0x60046CA")]
		[Address(RVA = "0x1FBDACC", Offset = "0x1FBDACC", VA = "0x1FBDACC")]
		protected void SetResponseData(JObject responseData)
		{
		}

		[Token(Token = "0x60046CB")]
		[Address(RVA = "0x1FBDAD4", Offset = "0x1FBDAD4", VA = "0x1FBDAD4", Slot = "8")]
		protected virtual Type MakeNetCommandType()
		{
			return null;
		}

		[Token(Token = "0x60046CC")]
		[Address(RVA = "0x1FBDADC", Offset = "0x1FBDADC", VA = "0x1FBDADC", Slot = "9")]
		protected virtual CSNetParameters MakeNetParameters()
		{
			return null;
		}

		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x1FBDAE4", Offset = "0x1FBDAE4", VA = "0x1FBDAE4")]
		public CSNetCommand MakeNetCommand()
		{
			return null;
		}

		[Token(Token = "0x60046CE")]
		[Address(RVA = "0x1FBDDA0", Offset = "0x1FBDDA0", VA = "0x1FBDDA0")]
		public void HandleResponse()
		{
		}

		[Token(Token = "0x60046CF")]
		protected abstract bool HandleResponse_User();

		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x1FBDE18", Offset = "0x1FBDE18", VA = "0x1FBDE18", Slot = "11")]
		protected virtual void HandleResponse_Default()
		{
		}

		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x1FBDE1C", Offset = "0x1FBDE1C", VA = "0x1FBDE1C", Slot = "12")]
		public virtual void Work()
		{
		}

		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x1FBDEC4", Offset = "0x1FBDEC4", VA = "0x1FBDEC4", Slot = "13")]
		protected virtual PeriodUpdater CreatePeriodUpdater()
		{
			return null;
		}

		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x1FBDFE8", Offset = "0x1FBDFE8", VA = "0x1FBDFE8", Slot = "14")]
		public virtual void OnWorkFinish()
		{
		}

		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x1FBDFEC", Offset = "0x1FBDFEC", VA = "0x1FBDFEC", Slot = "15")]
		protected virtual void OnTimeout()
		{
		}

		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x1FBE234", Offset = "0x1FBE234", VA = "0x1FBE234", Slot = "16")]
		protected virtual void RetryProcess()
		{
		}

		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x1FBE3B0", Offset = "0x1FBE3B0", VA = "0x1FBE3B0")]
		protected void ResetTimeoutTimer()
		{
		}

		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x1FBE3C4", Offset = "0x1FBE3C4", VA = "0x1FBE3C4", Slot = "17")]
		public virtual void Update(float delta)
		{
		}

		[Token(Token = "0x60046D8")]
		[Address(RVA = "0x1FBE418", Offset = "0x1FBE418", VA = "0x1FBE418")]
		public bool CompareSameParams(CSNetParameters param)
		{
			return default(bool);
		}

		[Token(Token = "0x60046D9")]
		[Address(RVA = "0x1FBE7CC", Offset = "0x1FBE7CC", VA = "0x1FBE7CC")]
		private void _003CWork_003Em__96(ApiReturnCode nErrorCode, string strErrorMsg, JObject json)
		{
		}

		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x1FBEA34", Offset = "0x1FBEA34", VA = "0x1FBEA34")]
		private void _003CCreatePeriodUpdater_003Em__97(float deltaTime)
		{
		}
	}
}
