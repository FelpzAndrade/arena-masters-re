using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XJsonHelper
{
	[Serializable]
	[Token(Token = "0x20006C4")]
	public class Serialization<T>
	{
		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> m_target;

		[Token(Token = "0x6003855")]
		public Serialization(List<T> target)
		{
		}

		[Token(Token = "0x6003856")]
		public Serialization(HashSet<T> target)
		{
		}

		[Token(Token = "0x6003857")]
		public List<T> ToList()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20006C5")]
	public class Serialization<TKey, TValue> : ISerializationCallbackReceiver
	{
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> m_target;

		[Token(Token = "0x6003858")]
		public Serialization(Dictionary<TKey, TValue> target)
		{
		}

		[Token(Token = "0x6003859")]
		public Dictionary<TKey, TValue> ToDictionary()
		{
			return null;
		}

		[Token(Token = "0x600385A")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600385B")]
		public void OnAfterDeserialize()
		{
		}
	}
}
