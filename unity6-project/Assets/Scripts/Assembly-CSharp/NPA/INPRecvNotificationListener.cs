using Il2CppDummyDll;
using SimpleJSON;

namespace NPA
{
	[Token(Token = "0x2001094")]
	public interface INPRecvNotificationListener : INPListenerType
	{
		[Token(Token = "0x6007D10")]
		void OnRecvNotification(JSONNode recvNotification);
	}
}
