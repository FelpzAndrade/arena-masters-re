using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x200109A")]
	public interface INPRuntimePermissionListener : INPListenerType
	{
		[Token(Token = "0x6007D1B")]
		void OnRequestPermissionsResult(int requestCode, string[] permissions, int[] grantResults);
	}
}
