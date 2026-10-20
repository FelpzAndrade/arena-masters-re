using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A7A")]
	public interface CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004DDD")]
		bool IsFrom(ProtoInfoFrom from);

		[Token(Token = "0x6004DDE")]
		bool Cooking(CSProtoInfoManagers protos);

		[Token(Token = "0x6004DDF")]
		void RemoveNotTagedContents(CSProtoInfoManagers protos);

		[Token(Token = "0x6004DE0")]
		bool LoadFromLocalFile(CSFileLoaderBase loader);
	}
}
