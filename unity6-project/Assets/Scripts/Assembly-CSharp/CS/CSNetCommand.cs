using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CS.ranking;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x2000982")]
	public class CSNetCommand
	{
		[Token(Token = "0x2000983")]
		public class Response
		{
			[Token(Token = "0x4002F01")]
			[FieldOffset(Offset = "0x8")]
			public ApiReturnCode returnCode;

			[Token(Token = "0x4002F02")]
			[FieldOffset(Offset = "0xC")]
			public CSNetParameters param;

			[Token(Token = "0x4002F03")]
			[FieldOffset(Offset = "0x10")]
			public CSNetParameters paramResult;

			[Token(Token = "0x4002F04")]
			[FieldOffset(Offset = "0x14")]
			public NetData_UserResource netdataResource;

			[Token(Token = "0x4002F05")]
			[FieldOffset(Offset = "0x18")]
			public NetData_Userdata netdataUser;

			[Token(Token = "0x4002F06")]
			[FieldOffset(Offset = "0x1C")]
			public List<Netdata_Char> netdataCharacters;

			[Token(Token = "0x4002F07")]
			[FieldOffset(Offset = "0x20")]
			public List<Netdata_Pet> netdataPets;

			[Token(Token = "0x4002F08")]
			[FieldOffset(Offset = "0x24")]
			public List<Netdata_Item> netdataItems;

			[Token(Token = "0x4002F09")]
			[FieldOffset(Offset = "0x28")]
			public Netdata_Char netdataCharacter;

			[Token(Token = "0x4002F0A")]
			[FieldOffset(Offset = "0x2C")]
			public Netdata_Pet netdataPet;

			[Token(Token = "0x4002F0B")]
			[FieldOffset(Offset = "0x30")]
			public data netdataRanking;

			[Token(Token = "0x4002F0C")]
			[FieldOffset(Offset = "0x34")]
			public record netdataUserRanking;

			[Token(Token = "0x4002F0D")]
			[FieldOffset(Offset = "0x38")]
			public List<Netdata_StallItem> netdataStallItemList;

			[Token(Token = "0x4002F0E")]
			[FieldOffset(Offset = "0x3C")]
			public NetData_Achievement_Clear_List netdataAchievementClearedList;

			[Token(Token = "0x4002F0F")]
			[FieldOffset(Offset = "0x40")]
			public CSHotTimeEventList netdataHottimeEventList;

			[Token(Token = "0x4002F10")]
			[FieldOffset(Offset = "0x44")]
			public string netdataResourceByDiff;

			[Token(Token = "0x4002F11")]
			[FieldOffset(Offset = "0x48")]
			public string netdataUserByDiff;

			[Token(Token = "0x4002F12")]
			[FieldOffset(Offset = "0x4C")]
			public string netdataCharactersByDiff;

			[Token(Token = "0x4002F13")]
			[FieldOffset(Offset = "0x50")]
			public string netdataPetsByDiff;

			[Token(Token = "0x4002F14")]
			[FieldOffset(Offset = "0x54")]
			public string netdataItemsByDiff;

			[Token(Token = "0x4002F15")]
			[FieldOffset(Offset = "0x58")]
			public string netdataCharacterByDiff;

			[Token(Token = "0x4002F16")]
			[FieldOffset(Offset = "0x5C")]
			public string netdataPetByDiff;

			[Token(Token = "0x4002F17")]
			[FieldOffset(Offset = "0x60")]
			public string netdataRankingByDiff;

			[Token(Token = "0x4002F18")]
			[FieldOffset(Offset = "0x64")]
			public string netdataUserRankingByDiff;

			[Token(Token = "0x4002F19")]
			[FieldOffset(Offset = "0x68")]
			public string netdataStallItemListByDiff;

			[Token(Token = "0x4002F1A")]
			[FieldOffset(Offset = "0x6C")]
			public string netdataAchievementClearedListByDiff;

			[Token(Token = "0x6004CB4")]
			[Address(RVA = "0x2239B28", Offset = "0x2239B28", VA = "0x2239B28")]
			public Response()
			{
			}
		}

		[Token(Token = "0x2000984")]
		public class RewardResponseGeneralizer
		{
			[Token(Token = "0x4002F1B")]
			[FieldOffset(Offset = "0x8")]
			public List<CSContent> contentsGeneralized;

			[Token(Token = "0x6004CB5")]
			[Address(RVA = "0x223C6DC", Offset = "0x223C6DC", VA = "0x223C6DC")]
			public RewardResponseGeneralizer()
			{
			}

			[Token(Token = "0x6004CB6")]
			[Address(RVA = "0x223C788", Offset = "0x223C788", VA = "0x223C788")]
			public void Push(CSContent content)
			{
			}

			[Token(Token = "0x6004CB7")]
			[Address(RVA = "0x223C828", Offset = "0x223C828", VA = "0x223C828")]
			public void Push(CSContentReward content)
			{
			}

			[Token(Token = "0x6004CB8")]
			[Address(RVA = "0x223C8D0", Offset = "0x223C8D0", VA = "0x223C8D0")]
			public void Push(List<CSContent> contents)
			{
			}

			[Token(Token = "0x6004CB9")]
			[Address(RVA = "0x223C970", Offset = "0x223C970", VA = "0x223C970")]
			public void Push(List<CSContentReward> contents)
			{
			}
		}

		[Token(Token = "0x2000985")]
		private sealed class _003CAddParam_003Ec__AnonStorey152
		{
			[Token(Token = "0x4002F1C")]
			[FieldOffset(Offset = "0x8")]
			internal string k;

			[Token(Token = "0x4002F1D")]
			[FieldOffset(Offset = "0xC")]
			internal CSNetCommand _003C_003Ef__this;

			[Token(Token = "0x6004CBA")]
			[Address(RVA = "0x223ADEC", Offset = "0x223ADEC", VA = "0x223ADEC")]
			public _003CAddParam_003Ec__AnonStorey152()
			{
			}

			[Token(Token = "0x6004CBB")]
			[Address(RVA = "0x223C6A0", Offset = "0x223C6A0", VA = "0x223C6A0")]
			internal void _003C_003Em__1FA(string e)
			{
			}
		}

		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x8")]
		protected Dictionary<string, List<string>> m_paramIncome;

		[Token(Token = "0x4002EFA")]
		[FieldOffset(Offset = "0xC")]
		public Response response;

		[Token(Token = "0x4002EFB")]
		[FieldOffset(Offset = "0x10")]
		private NetCallback m_m_callbacks;

		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x14")]
		private JObject PostBody__BackingField;

		[Token(Token = "0x4002EFD")]
		[FieldOffset(Offset = "0x18")]
		private float TimeoutSec__BackingField;

		[Token(Token = "0x4002EFE")]
		[FieldOffset(Offset = "0x0")]
		private static NetCallback _003C_003Ef__am_0024cache5;

		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x4")]
		private static Func<CSContentReward, CSContent> _003C_003Ef__am_0024cache6;

		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x8")]
		private static Func<CSContentReward, CSContent> _003C_003Ef__am_0024cache7;

		[Token(Token = "0x17000AF0")]
		public JObject PostBody
		{
			[Token(Token = "0x6004C65")]
			[Address(RVA = "0x2239A50", Offset = "0x2239A50", VA = "0x2239A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C66")]
			[Address(RVA = "0x2239A58", Offset = "0x2239A58", VA = "0x2239A58")]
			set
			{
			}
		}

		[Token(Token = "0x17000AF1")]
		public float TimeoutSec
		{
			[Token(Token = "0x6004C67")]
			[Address(RVA = "0x2239A60", Offset = "0x2239A60", VA = "0x2239A60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6004C68")]
			[Address(RVA = "0x2239A68", Offset = "0x2239A68", VA = "0x2239A68")]
			set
			{
			}
		}

		[Token(Token = "0x1400005F")]
		protected event NetCallback m_callbacks
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6004C63")]
			[Address(RVA = "0x2239738", Offset = "0x2239738", VA = "0x2239738")]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[Token(Token = "0x6004C64")]
			[Address(RVA = "0x22398C4", Offset = "0x22398C4", VA = "0x22398C4")]
			remove
			{
			}
		}

		[Token(Token = "0x6004C61")]
		[Address(RVA = "0x22394B8", Offset = "0x22394B8", VA = "0x22394B8")]
		public CSNetCommand()
		{
		}

		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x22395F8", Offset = "0x22395F8", VA = "0x22395F8")]
		public CSNetCommand(string s)
		{
		}

		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x2239A70", Offset = "0x2239A70", VA = "0x2239A70")]
		public void Reset()
		{
		}

		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x2239BDC", Offset = "0x2239BDC", VA = "0x2239BDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x2239CC8", Offset = "0x2239CC8", VA = "0x2239CC8")]
		public string GetUrl()
		{
			return null;
		}

		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x2239FA4", Offset = "0x2239FA4", VA = "0x2239FA4")]
		public void AddCallback(NetCallback cb)
		{
		}

		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x223A130", Offset = "0x223A130", VA = "0x223A130")]
		public ApiReturnCode GetReturnCode()
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x223A154", Offset = "0x223A154", VA = "0x223A154")]
		public Dictionary<string, List<string>> GetParamsIncome()
		{
			return null;
		}

		[Token(Token = "0x6004C6F")]
		[Address(RVA = "0x223A15C", Offset = "0x223A15C", VA = "0x223A15C", Slot = "4")]
		public virtual void OnResponse(ApiReturnCode errno, string errmsg, JObject data)
		{
		}

		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x223A194", Offset = "0x223A194", VA = "0x223A194")]
		public void OnResponseError(string errmsg)
		{
		}

		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x223A2AC", Offset = "0x223A2AC", VA = "0x223A2AC")]
		internal void OnResponseError(ApiReturnCode errorCode, double timeout, string msg)
		{
		}

		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x223A3C8", Offset = "0x223A3C8", VA = "0x223A3C8")]
		protected void SetResponseError(ApiReturnCode code)
		{
		}

		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x223A3EC", Offset = "0x223A3EC", VA = "0x223A3EC")]
		protected bool IsError(ApiReturnCode code)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x223A428", Offset = "0x223A428", VA = "0x223A428")]
		protected bool IsFalse(bool Flag, ApiReturnCode NullErrorCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x223A464", Offset = "0x223A464", VA = "0x223A464")]
		protected bool IsNull(object Target, ApiReturnCode NullErrorCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x223A4A0", Offset = "0x223A4A0", VA = "0x223A4A0", Slot = "5")]
		public virtual void Process()
		{
		}

		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x223A4A4", Offset = "0x223A4A4", VA = "0x223A4A4", Slot = "6")]
		public virtual bool SystemProcess()
		{
			return default(bool);
		}

		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x223A4AC", Offset = "0x223A4AC", VA = "0x223A4AC", Slot = "7")]
		public virtual string MethodType()
		{
			return null;
		}

		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x223A524", Offset = "0x223A524", VA = "0x223A524")]
		public void AddIncomeParam(string strKey, string strValue)
		{
		}

		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x223A6A0", Offset = "0x223A6A0", VA = "0x223A6A0")]
		public void AddIncomeParam(string strKey, object Value)
		{
		}

		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0x223A858", Offset = "0x223A858", VA = "0x223A858")]
		public void AddIncomeParam(string strKey, string[] strValue)
		{
		}

		[Token(Token = "0x6004C7C")]
		[Address(RVA = "0x223A8C0", Offset = "0x223A8C0", VA = "0x223A8C0")]
		private string ConvertToString(object o)
		{
			return null;
		}

		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0x223AA4C", Offset = "0x223AA4C", VA = "0x223AA4C")]
		public void AddParam(CSNetParameters param)
		{
		}

		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x223ADF4", Offset = "0x223ADF4", VA = "0x223ADF4")]
		protected void AddParam_SessionId()
		{
		}

		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x223AF04", Offset = "0x223AF04", VA = "0x223AF04")]
		private bool NeedConvertStringParam(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x223AFE4", Offset = "0x223AFE4", VA = "0x223AFE4")]
		public void AddParamResult(string k, object v)
		{
		}

		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x223B114", Offset = "0x223B114", VA = "0x223B114")]
		public void AddParamResultRaw(string k, object v)
		{
		}

		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x223B244", Offset = "0x223B244", VA = "0x223B244")]
		public void AddParamOut(NetData_UserResource data)
		{
		}

		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x223B268", Offset = "0x223B268", VA = "0x223B268")]
		public void AddParamOut(NetData_Userdata data)
		{
		}

		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x223B28C", Offset = "0x223B28C", VA = "0x223B28C")]
		protected void AddParamOut(List<Netdata_Char> data)
		{
		}

		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x223B2B0", Offset = "0x223B2B0", VA = "0x223B2B0")]
		protected void AddParamOut(List<Netdata_Pet> data)
		{
		}

		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x223B2D4", Offset = "0x223B2D4", VA = "0x223B2D4")]
		protected void AddParamOut(List<Netdata_Item> data)
		{
		}

		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x223B2F8", Offset = "0x223B2F8", VA = "0x223B2F8")]
		protected void AddParamOut(Netdata_Char data)
		{
		}

		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x223B31C", Offset = "0x223B31C", VA = "0x223B31C")]
		protected void AddParamOut(Netdata_Pet data)
		{
		}

		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x223B340", Offset = "0x223B340", VA = "0x223B340")]
		protected void AddParamOut(data data)
		{
		}

		[Token(Token = "0x6004C8A")]
		[Address(RVA = "0x223B364", Offset = "0x223B364", VA = "0x223B364")]
		protected void AddParamOut(record data)
		{
		}

		[Token(Token = "0x6004C8B")]
		[Address(RVA = "0x223B388", Offset = "0x223B388", VA = "0x223B388")]
		protected void AddParamOut(List<Netdata_StallItem> data)
		{
		}

		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0x223B3AC", Offset = "0x223B3AC", VA = "0x223B3AC")]
		protected void AddParmaOut(NetData_Achievement_Clear_List data)
		{
		}

		[Token(Token = "0x6004C8D")]
		[Address(RVA = "0x223B3DC", Offset = "0x223B3DC", VA = "0x223B3DC")]
		protected void DecideOutParam(List<CSContentReward> rewards, ref bool exportCharList, ref bool exportItemList)
		{
		}

		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x223B544", Offset = "0x223B544", VA = "0x223B544")]
		protected void DecideOutParam(List<CSContent> rewards, ref bool exportCharList, ref bool exportItemList)
		{
		}

		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x223B648", Offset = "0x223B648", VA = "0x223B648")]
		protected void AddParamOut(ApiReturnCode code)
		{
		}

		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x223B66C", Offset = "0x223B66C", VA = "0x223B66C")]
		protected void AddParamOut(NetData_Userdata snapshotUserData, NetData_Userdata newestUserData)
		{
		}

		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x223B72C", Offset = "0x223B72C", VA = "0x223B72C")]
		protected void AddParamOutNetDataUser_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x223B750", Offset = "0x223B750", VA = "0x223B750")]
		protected void AddParamOut(NetData_UserResource snapshotUserResource, NetData_UserResource newestUserResource)
		{
		}

		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x223B7FC", Offset = "0x223B7FC", VA = "0x223B7FC")]
		protected void AddParamOutNetDataResource_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x223B820", Offset = "0x223B820", VA = "0x223B820")]
		protected void AddParamOut(NetData_Char_List snapshotCharList, NetData_Char_List newestCharList)
		{
		}

		[Token(Token = "0x6004C95")]
		[Address(RVA = "0x223B8CC", Offset = "0x223B8CC", VA = "0x223B8CC")]
		protected void AddParamOutNetDataCharacters_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C96")]
		[Address(RVA = "0x223B8F0", Offset = "0x223B8F0", VA = "0x223B8F0")]
		protected void AddParamOut(NetData_Pet_List snapshotCharList, NetData_Pet_List newestCharList)
		{
		}

		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x223B99C", Offset = "0x223B99C", VA = "0x223B99C")]
		protected void AddParamOutNetDataPets_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C98")]
		[Address(RVA = "0x223B9C0", Offset = "0x223B9C0", VA = "0x223B9C0")]
		protected void AddParamOut(Netdata_Item_List snapshotItemList, Netdata_Item_List newestItemList)
		{
		}

		[Token(Token = "0x6004C99")]
		[Address(RVA = "0x223BA6C", Offset = "0x223BA6C", VA = "0x223BA6C")]
		protected void AddParamOutNetDataItems_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C9A")]
		[Address(RVA = "0x223BA90", Offset = "0x223BA90", VA = "0x223BA90")]
		protected void AddParamOutNetDataCharacter_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C9B")]
		[Address(RVA = "0x223BAB4", Offset = "0x223BAB4", VA = "0x223BAB4")]
		protected void AddParamOutNetDataPet_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x223BAD8", Offset = "0x223BAD8", VA = "0x223BAD8")]
		protected void AddParamOutNetDataRanking_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x223BAFC", Offset = "0x223BAFC", VA = "0x223BAFC")]
		protected void AddParamOutNetDataUserRanking_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x223BB20", Offset = "0x223BB20", VA = "0x223BB20")]
		protected void AddParamOutNetDataStallItemList_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x223BB44", Offset = "0x223BB44", VA = "0x223BB44")]
		protected void AddParamOut(NetData_Achievement_Clear_List snapShotAchiveData, NetData_Achievement_Clear_List newestAchiveData)
		{
		}

		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x223BBF0", Offset = "0x223BBF0", VA = "0x223BBF0")]
		protected void AddParamOutNetDataAchievementClearedList_ByDiff(string data)
		{
		}

		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x223BC14", Offset = "0x223BC14", VA = "0x223BC14")]
		protected void AddParamOutHotTimeEvent(CSHotTimeEventList data)
		{
		}

		[Token(Token = "0x6004CA2")]
		protected void AddParamOutByDiff<T>(ref T param, T data)
		{
		}

		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x223BC38", Offset = "0x223BC38", VA = "0x223BC38")]
		private void DecideOutParam_ByDiff(CSContent contentReward, ref bool exportCharList, ref bool exportItemList)
		{
		}

		[Token(Token = "0x6004CA4")]
		[Address(RVA = "0x223BC6C", Offset = "0x223BC6C", VA = "0x223BC6C")]
		protected void DecideOutParam_ByDiff(List<CSContentReward> rewards, ref bool exportCharList, ref bool exportItemList)
		{
		}

		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x223BDE0", Offset = "0x223BDE0", VA = "0x223BDE0")]
		protected void DecideOutParam_ByDiff(List<CSContent> rewards, ref bool exportCharList, ref bool exportItemList)
		{
		}

		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x223BE8C", Offset = "0x223BE8C", VA = "0x223BE8C")]
		protected void DecideOutParam_ByDiff(CSContent[] rewards, ref bool exportCharList, ref bool exportItemList)
		{
		}

		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x223BF04", Offset = "0x223BF04", VA = "0x223BF04")]
		protected void AddParamOut_ByDiff(ApiReturnCode code)
		{
		}

		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x223BF28", Offset = "0x223BF28", VA = "0x223BF28")]
		public int GetParamCount()
		{
			return default(int);
		}

		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x223BFC0", Offset = "0x223BFC0", VA = "0x223BFC0")]
		public List<string> GetParamList(string strKey)
		{
			return null;
		}

		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x223C0A0", Offset = "0x223C0A0", VA = "0x223C0A0")]
		public string GetParam(string strKey)
		{
			return null;
		}

		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x223C1FC", Offset = "0x223C1FC", VA = "0x223C1FC")]
		public int GetParamToInt(string strKey)
		{
			return default(int);
		}

		[Token(Token = "0x6004CAC")]
		[Address(RVA = "0x223C2D8", Offset = "0x223C2D8", VA = "0x223C2D8")]
		public long GetParamToInt64(string strKey)
		{
			return default(long);
		}

		[Token(Token = "0x6004CAD")]
		[Address(RVA = "0x223C3B8", Offset = "0x223C3B8", VA = "0x223C3B8")]
		public float GetParamToFloat(string strKey)
		{
			return default(float);
		}

		[Token(Token = "0x6004CAE")]
		[Address(RVA = "0x223C494", Offset = "0x223C494", VA = "0x223C494")]
		public bool GetParamToBool(string strKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6004CAF")]
		[Address(RVA = "0x2239EE0", Offset = "0x2239EE0", VA = "0x2239EE0")]
		public string GetParamText()
		{
			return null;
		}

		[Token(Token = "0x6004CB0")]
		[Address(RVA = "0x223C5AC", Offset = "0x223C5AC", VA = "0x223C5AC", Slot = "8")]
		public virtual string GetOutSideRequestResponse()
		{
			return null;
		}

		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x223C65C", Offset = "0x223C65C", VA = "0x223C65C")]
		private static void _003Cm_callbacks_003Em__1F9(ApiReturnCode P_0, string P_1, JObject P_2)
		{
		}

		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x223C660", Offset = "0x223C660", VA = "0x223C660")]
		private static CSContent _003CDecideOutParam_003Em__1FB(CSContentReward reward)
		{
			return null;
		}

		[Token(Token = "0x6004CB3")]
		[Address(RVA = "0x223C680", Offset = "0x223C680", VA = "0x223C680")]
		private static CSContent _003CDecideOutParam_ByDiff_003Em__1FC(CSContentReward reward)
		{
			return null;
		}
	}
}
