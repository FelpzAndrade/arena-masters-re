using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace CS
{
	[Token(Token = "0x20008C6")]
	public interface INetProcessor
	{
		[Token(Token = "0x60046DE")]
		void Init(CSNetworkManager networkMgr);

		[Token(Token = "0x60046DF")]
		void Clear();

		[Token(Token = "0x60046E0")]
		void ScheduleProcess<TNETPROCESS>([Optional] CSNetParameters param, [Optional] JObject postBody, [Optional] NetCallback callback) where TNETPROCESS : CSNetProcessBase, new();

		[Token(Token = "0x60046E1")]
		void ScheduleProcess(CSNetProcessBase process, [Optional] CSNetParameters param, [Optional] JObject postBody, [Optional] NetCallback callback);

		[Token(Token = "0x60046E2")]
		CSNetProcessBase GetFirstProcess();

		[Token(Token = "0x60046E3")]
		void Update(float deltaTime);

		[Token(Token = "0x60046E4")]
		int GetProcessCount();
	}
}
