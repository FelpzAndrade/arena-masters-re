using System.Collections.Generic;
using Il2CppDummyDll;

namespace NPAJson
{
	[Token(Token = "0x200108E")]
	public class JSONArray : List<object>
	{
		[Token(Token = "0x6007CFF")]
		[Address(RVA = "0x11DEE98", Offset = "0x11DEE98", VA = "0x11DEE98")]
		private JSONArray(JSONTokener readFrom)
		{
		}

		[Token(Token = "0x6007D00")]
		[Address(RVA = "0x11DF364", Offset = "0x11DF364", VA = "0x11DF364")]
		public JSONArray(string json)
		{
		}

		[Token(Token = "0x6007D01")]
		[Address(RVA = "0x11DF424", Offset = "0x11DF424", VA = "0x11DF424")]
		public JSONArray()
		{
		}

		[Token(Token = "0x6007D02")]
		[Address(RVA = "0x11DF4E0", Offset = "0x11DF4E0", VA = "0x11DF4E0")]
		public void addValue(object neoValue)
		{
		}

		[Token(Token = "0x6007D03")]
		[Address(RVA = "0x11DF56C", Offset = "0x11DF56C", VA = "0x11DF56C")]
		public void clear()
		{
		}

		[Token(Token = "0x6007D04")]
		[Address(RVA = "0x11DF5F0", Offset = "0x11DF5F0", VA = "0x11DF5F0")]
		public int length()
		{
			return default(int);
		}

		[Token(Token = "0x6007D05")]
		[Address(RVA = "0x11DF674", Offset = "0x11DF674", VA = "0x11DF674")]
		public string getString(int index)
		{
			return null;
		}

		[Token(Token = "0x6007D06")]
		[Address(RVA = "0x11DF780", Offset = "0x11DF780", VA = "0x11DF780")]
		public float getFloat(int index)
		{
			return default(float);
		}

		[Token(Token = "0x6007D07")]
		[Address(RVA = "0x11DF9AC", Offset = "0x11DF9AC", VA = "0x11DF9AC")]
		public int getInt(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6007D08")]
		[Address(RVA = "0x11DFBCC", Offset = "0x11DFBCC", VA = "0x11DFBCC")]
		public JSONObject getJSONObject(int index)
		{
			return null;
		}

		[Token(Token = "0x6007D09")]
		[Address(RVA = "0x11E0088", Offset = "0x11E0088", VA = "0x11E0088")]
		public JSONArray getJSONArray(int index)
		{
			return null;
		}

		[Token(Token = "0x6007D0A")]
		[Address(RVA = "0x11E0334", Offset = "0x11E0334", VA = "0x11E0334")]
		public int getCount()
		{
			return default(int);
		}

		[Token(Token = "0x6007D0B")]
		[Address(RVA = "0x11E03B8", Offset = "0x11E03B8", VA = "0x11E03B8")]
		public bool isNull(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6007D0C")]
		[Address(RVA = "0x11E0488", Offset = "0x11E0488", VA = "0x11E0488")]
		public string convertToString()
		{
			return null;
		}

		[Token(Token = "0x6007D0D")]
		[Address(RVA = "0x11E0B44", Offset = "0x11E0B44", VA = "0x11E0B44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
