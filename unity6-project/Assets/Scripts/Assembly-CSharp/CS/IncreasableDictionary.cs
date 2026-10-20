using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x20008E2")]
	public class IncreasableDictionary<T> : Dictionary<T, int>
	{
		[Token(Token = "0x17000996")]
		[JsonIgnore]
		public int TotalValue
		{
			[Token(Token = "0x6004750")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600474A")]
		public IncreasableDictionary()
		{
		}

		[Token(Token = "0x600474B")]
		private int GetDefault(T Key)
		{
			return default(int);
		}

		[Token(Token = "0x600474C")]
		public Dictionary<T, int> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x600474D")]
		public int Increase(T Key, int Value = 1)
		{
			return default(int);
		}

		[Token(Token = "0x600474E")]
		public void Set(T Key, int Value)
		{
		}

		[Token(Token = "0x600474F")]
		public int Get(T Key, bool SetDefaultIfNotExists = true)
		{
			return default(int);
		}
	}
}
