using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NPAJson
{
	[Token(Token = "0x200108B")]
	public class JSONObject : Dictionary<string, object>
	{
		[Token(Token = "0x200108C")]
		private class JSONNull
		{
			[Token(Token = "0x6007CE4")]
			[Address(RVA = "0x11E109C", Offset = "0x11E109C", VA = "0x11E109C")]
			public JSONNull()
			{
			}

			[Token(Token = "0x6007CE5")]
			[Address(RVA = "0x11E2A88", Offset = "0x11E2A88", VA = "0x11E2A88", Slot = "0")]
			public override bool Equals(object o)
			{
				return default(bool);
			}

			[Token(Token = "0x6007CE6")]
			[Address(RVA = "0x11E2AA8", Offset = "0x11E2AA8", VA = "0x11E2AA8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007CE7")]
			[Address(RVA = "0x11E2B20", Offset = "0x11E2B20", VA = "0x11E2B20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x4005940")]
		[FieldOffset(Offset = "0x0")]
		public static readonly object NULLOBJ;

		[Token(Token = "0x6007CD0")]
		[Address(RVA = "0x11E0B50", Offset = "0x11E0B50", VA = "0x11E0B50")]
		public JSONObject()
		{
		}

		[Token(Token = "0x6007CD1")]
		[Address(RVA = "0x11E0BD4", Offset = "0x11E0BD4", VA = "0x11E0BD4")]
		public JSONObject(Dictionary<string, object> temp)
		{
		}

		[Token(Token = "0x6007CD2")]
		[Address(RVA = "0x11E0C60", Offset = "0x11E0C60", VA = "0x11E0C60")]
		private JSONObject(JSONTokener readFrom)
		{
		}

		[Token(Token = "0x6007CD3")]
		[Address(RVA = "0x11D5E44", Offset = "0x11D5E44", VA = "0x11D5E44")]
		public JSONObject(string json)
		{
		}

		[Token(Token = "0x6007CD5")]
		[Address(RVA = "0x11E10A4", Offset = "0x11E10A4", VA = "0x11E10A4")]
		public object put(string key, object neoValue)
		{
			return null;
		}

		[Token(Token = "0x6007CD6")]
		[Address(RVA = "0x11E11B8", Offset = "0x11E11B8", VA = "0x11E11B8")]
		public string getString(string key)
		{
			return null;
		}

		[Token(Token = "0x6007CD7")]
		[Address(RVA = "0x11E12C8", Offset = "0x11E12C8", VA = "0x11E12C8")]
		public float getFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6007CD8")]
		[Address(RVA = "0x11E14D8", Offset = "0x11E14D8", VA = "0x11E14D8")]
		public int getInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6007CD9")]
		[Address(RVA = "0x11E16DC", Offset = "0x11E16DC", VA = "0x11E16DC")]
		public double getDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x6007CDA")]
		[Address(RVA = "0x11E18E0", Offset = "0x11E18E0", VA = "0x11E18E0")]
		public bool getBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6007CDB")]
		[Address(RVA = "0x11E1AE4", Offset = "0x11E1AE4", VA = "0x11E1AE4")]
		public JSONObject getJSONObject(string key)
		{
			return null;
		}

		[Token(Token = "0x6007CDC")]
		[Address(RVA = "0x11E1D08", Offset = "0x11E1D08", VA = "0x11E1D08")]
		public JSONArray getJSONArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6007CDD")]
		[Address(RVA = "0x11E1F2C", Offset = "0x11E1F2C", VA = "0x11E1F2C")]
		public ArrayList getKeySet()
		{
			return null;
		}

		[Token(Token = "0x6007CDE")]
		[Address(RVA = "0x11E1FDC", Offset = "0x11E1FDC", VA = "0x11E1FDC")]
		public bool has(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6007CDF")]
		[Address(RVA = "0x11E2068", Offset = "0x11E2068", VA = "0x11E2068")]
		public int getCount()
		{
			return default(int);
		}

		[Token(Token = "0x6007CE0")]
		[Address(RVA = "0x11E20EC", Offset = "0x11E20EC", VA = "0x11E20EC")]
		public bool isNull(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6007CE1")]
		[Address(RVA = "0x11E21C0", Offset = "0x11E21C0", VA = "0x11E21C0")]
		public string convertToString()
		{
			return null;
		}

		[Token(Token = "0x6007CE2")]
		[Address(RVA = "0x11E2A84", Offset = "0x11E2A84", VA = "0x11E2A84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6007CE3")]
		[Address(RVA = "0x11DE7D0", Offset = "0x11DE7D0", VA = "0x11DE7D0")]
		public static string convertToString(Dictionary<string, string> dic)
		{
			return null;
		}
	}
}
