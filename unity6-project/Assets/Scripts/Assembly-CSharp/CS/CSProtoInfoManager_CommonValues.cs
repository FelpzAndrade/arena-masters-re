using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AB7")]
	public class CSProtoInfoManager_CommonValues : Dictionary<string, string>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x400323A")]
		[FieldOffset(Offset = "0x34")]
		private bool m_loaded;

		[Token(Token = "0x400323B")]
		[FieldOffset(Offset = "0x38")]
		private int AniToller__BackingField;

		[Token(Token = "0x400323C")]
		[FieldOffset(Offset = "0x3C")]
		private float Diff_ani_via_elapse__BackingField;

		[Token(Token = "0x400323D")]
		[FieldOffset(Offset = "0x40")]
		private bool appstore_download_ready__BackingField;

		[Token(Token = "0x400323E")]
		[FieldOffset(Offset = "0x44")]
		private string appstore_download_url__BackingField;

		[Token(Token = "0x400323F")]
		[FieldOffset(Offset = "0x48")]
		private string playstore_download_url__BackingField;

		[Token(Token = "0x17000B27")]
		public int AniToller
		{
			[Token(Token = "0x6004EC8")]
			[Address(RVA = "0x1FCBA64", Offset = "0x1FCBA64", VA = "0x1FCBA64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004EC9")]
			[Address(RVA = "0x1FCB37C", Offset = "0x1FCB37C", VA = "0x1FCB37C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B28")]
		public float Diff_ani_via_elapse
		{
			[Token(Token = "0x6004ECA")]
			[Address(RVA = "0x1FCBA6C", Offset = "0x1FCBA6C", VA = "0x1FCBA6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6004ECB")]
			[Address(RVA = "0x1FCB498", Offset = "0x1FCB498", VA = "0x1FCB498")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B29")]
		public bool appstore_download_ready
		{
			[Token(Token = "0x6004ECC")]
			[Address(RVA = "0x1FCBA74", Offset = "0x1FCBA74", VA = "0x1FCBA74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004ECD")]
			[Address(RVA = "0x1FCB5F0", Offset = "0x1FCB5F0", VA = "0x1FCB5F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B2A")]
		public string appstore_download_url
		{
			[Token(Token = "0x6004ECE")]
			[Address(RVA = "0x1FCBA7C", Offset = "0x1FCBA7C", VA = "0x1FCBA7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ECF")]
			[Address(RVA = "0x1FCB6EC", Offset = "0x1FCB6EC", VA = "0x1FCB6EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B2B")]
		public string playstore_download_url
		{
			[Token(Token = "0x6004ED0")]
			[Address(RVA = "0x1FCBA84", Offset = "0x1FCBA84", VA = "0x1FCBA84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED1")]
			[Address(RVA = "0x1FCB6F4", Offset = "0x1FCB6F4", VA = "0x1FCB6F4")]
			private set
			{
			}
		}

		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x1FC243C", Offset = "0x1FC243C", VA = "0x1FC243C")]
		public CSProtoInfoManager_CommonValues()
		{
		}

		[Token(Token = "0x6004EC0")]
		[Address(RVA = "0x1FCB130", Offset = "0x1FCB130", VA = "0x1FCB130", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EC1")]
		[Address(RVA = "0x1FCB140", Offset = "0x1FCB140", VA = "0x1FCB140", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x1FCB144", Offset = "0x1FCB144", VA = "0x1FCB144", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0x1FCB6FC", Offset = "0x1FCB6FC", VA = "0x1FCB6FC", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0x1FCB270", Offset = "0x1FCB270", VA = "0x1FCB270")]
		private int ConvertIntToStr(string strKey, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x1FCB384", Offset = "0x1FCB384", VA = "0x1FCB384")]
		private float ConvertFloatToStr(string strKey, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x1FCB4A0", Offset = "0x1FCB4A0", VA = "0x1FCB4A0")]
		private bool ConvertBoolToStr(string strKey, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x1FCB5F8", Offset = "0x1FCB5F8", VA = "0x1FCB5F8")]
		private string SetStrData(string strKey, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x1FCBA8C", Offset = "0x1FCBA8C", VA = "0x1FCBA8C")]
		private void _003CLoadFromLocalFile_003Em__1FE(CSCommonValues e)
		{
		}
	}
}
