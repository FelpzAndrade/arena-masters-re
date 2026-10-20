using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	// Classe generica: o IL2CPP compartilha o codigo entre instanciacoes e o dump nao traz corpo proprio.
	// Implementacao de pool padrao, coerente com a interface (Reserve/Fill/New/Release/Count/Clear).
	[Token(Token = "0x20008A2")]
	public class ObjectRepository<TYPE> where TYPE : CSPoolEntry, new()
	{
		[Token(Token = "0x4002A78")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int PoolDeltaSize = 16;

		[Token(Token = "0x4002A79")]
		[FieldOffset(Offset = "0x0")]
		private static Stack<TYPE> m_pools = new Stack<TYPE>();

		[Token(Token = "0x4002A7A")]
		[FieldOffset(Offset = "0x0")]
		private static int PoolSize;

		[Token(Token = "0x60045F1")]
		public ObjectRepository()
		{
		}

		[Token(Token = "0x60045F3")]
		public static void Reserve(int count)
		{
			Fill(count - m_pools.Count);
		}

		[Token(Token = "0x60045F4")]
		private static void Fill()
		{
			Fill(PoolDeltaSize);
		}

		[Token(Token = "0x60045F5")]
		private static void Fill(int fillAmount)
		{
			for (int i = 0; i < fillAmount; i++)
			{
				m_pools.Push(new TYPE());
				PoolSize++;
			}
		}

		[Token(Token = "0x60045F6")]
		public static TYPE New()
		{
			if (m_pools.Count == 0)
			{
				Fill();
			}
			return m_pools.Pop();
		}

		[Token(Token = "0x60045F7")]
		public static void Release(TYPE item)
		{
			if (item == null)
			{
				return;
			}
			item.OnCleanupInObjectPool();
			m_pools.Push(item);
		}

		[Token(Token = "0x60045F8")]
		public static int Count()
		{
			return m_pools.Count;
		}

		[Token(Token = "0x60045F9")]
		public static void Clear()
		{
			m_pools.Clear();
			PoolSize = 0;
		}
	}
}
