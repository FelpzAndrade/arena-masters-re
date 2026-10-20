using System.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200091E")]
	public class CharStatus : IDisposable, CSPoolEntry
	{
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x8")]
		[StatDesc]
		public CharStatusAttr PhysicalDamage;

		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0xC")]
		[StatDesc]
		public CharStatusAttr MagicalDamage;

		[Token(Token = "0x4002D16")]
		[FieldOffset(Offset = "0x10")]
		[StatDesc]
		public CharStatusAttr MaxHP;

		[Token(Token = "0x4002D17")]
		[FieldOffset(Offset = "0x14")]
		[StatDesc]
		public CharStatusAttr MaxHPPerLevel;

		[Token(Token = "0x4002D18")]
		[FieldOffset(Offset = "0x18")]
		[StatDesc]
		public CharStatusAttr MaxShield;

		[Token(Token = "0x4002D19")]
		[FieldOffset(Offset = "0x1C")]
		[StatDesc]
		public CharStatusAttr MaxShieldPerMaxDamage;

		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x20")]
		[StatDesc]
		public CharStatusAttr MaxShieldPerMaxHP;

		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x24")]
		[StatDesc]
		public CharStatusAttr PhysicalDefense_Fix;

		[Token(Token = "0x4002D1C")]
		[FieldOffset(Offset = "0x28")]
		[StatDesc]
		public CharStatusAttr MagicalDefense_Fix;

		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x2C")]
		[StatDesc]
		public CharStatusAttr PhysicalDefense;

		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x30")]
		[StatDesc]
		public CharStatusAttr MagicalDefense;

		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x34")]
		[StatDesc]
		public CharStatusAttr PhysicalDamageAmp;

		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x38")]
		[StatDesc]
		public CharStatusAttr MagicalDamageAmp;

		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x3C")]
		[StatDesc]
		public CharStatusAttr PhysicalPenetration;

		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x40")]
		[StatDesc]
		public CharStatusAttr MagicalPenetration;

		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x44")]
		[StatDesc]
		public CharStatusAttr PhysicalDrain;

		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x48")]
		[StatDesc]
		public CharStatusAttr MagicalDrain;

		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x4C")]
		[StatDesc]
		public CharStatusAttr AmplyDamageOnDeathsDoor;

		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x50")]
		[StatDesc]
		public CharStatusAttr AmplyDefenseOnDeathsDoor;

		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x54")]
		[StatDesc]
		public CharStatusAttr DrainOnDeathsDoor;

		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x58")]
		[StatDesc]
		public CharStatusAttr RegenHP;

		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0x5C")]
		[StatDesc]
		public CharStatusAttr Critical;

		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x60")]
		[StatDesc]
		public CharStatusAttr Flexibility;

		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x64")]
		[StatDesc]
		public CharStatusAttr CriticalDamage;

		[Token(Token = "0x4002D2C")]
		[FieldOffset(Offset = "0x68")]
		[StatDesc]
		public CharStatusAttr CriticalDamageDefense;

		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x6C")]
		[StatDesc]
		public CharStatusAttr Accuracy;

		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x70")]
		[StatDesc]
		public CharStatusAttr Agility;

		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x74")]
		[StatDesc]
		public CharStatusAttr RoamingSpeed;

		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x78")]
		[StatDesc]
		public CharStatusAttr Toughness;

		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x7C")]
		[StatDesc]
		public CharStatusAttr MovingSpeed;

		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x80")]
		[StatDesc]
		public CharStatusAttr SlowResist;

		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x84")]
		[StatDesc]
		public CharStatusAttr Weight;

		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x88")]
		[StatDesc]
		public CharStatusAttr CostMP;

		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x8C")]
		[StatDesc]
		public CharStatusAttr CoolTime;

		[Token(Token = "0x4002D36")]
		[FieldOffset(Offset = "0x90")]
		[StatDesc]
		public CharStatusAttr Duration;

		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x94")]
		[StatDesc]
		public CharStatusAttr InvokeRatio;

		[Token(Token = "0x4002D38")]
		[FieldOffset(Offset = "0x98")]
		[StatDesc]
		public CharStatusAttr UltimateMaxCharge;

		[Token(Token = "0x4002D39")]
		[FieldOffset(Offset = "0x9C")]
		[StatDesc]
		public CharStatusAttr TagCooltimeReduction;

		[Token(Token = "0x4002D3A")]
		[FieldOffset(Offset = "0xA0")]
		[StatDesc]
		public CharStatusAttr SkillCoolTimeReduction;

		[Token(Token = "0x4002D3B")]
		[FieldOffset(Offset = "0xA4")]
		[StatDesc]
		public CharStatusAttr DodgeSkillCoolTimeReduction;

		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0xA8")]
		[StatDesc]
		public CharStatusAttr RelicSkillCoolTimeReduction;

		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0xAC")]
		private Dictionary<int, CharStatusAttr> m_attrs;

		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x0")]
		private static List<FieldInfo> m_charStatusAttrfields;

		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x4")]
		public static Dictionary<int, StatDesc> StatDesc;

		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<int, string> HashCodeToString;

		[Token(Token = "0x170009C6")]
		[XmlIgnore]
		public Dictionary<int, CharStatusAttr> Attibutes
		{
			[Token(Token = "0x60048DA")]
			[Address(RVA = "0x23E915C", Offset = "0x23E915C", VA = "0x23E915C")]
			get
			{
				return m_attrs;
			}
		}

		[Token(Token = "0x60048D8")]
		[Address(RVA = "0x23E87F8", Offset = "0x23E87F8", VA = "0x23E87F8")]
		public CharStatus()
		{
			// cada campo CharStatusAttr e criado por reflexao e indexado pelo hash do nome
			m_attrs = new Dictionary<int, CharStatusAttr>();
			foreach (FieldInfo field in m_charStatusAttrfields)
			{
				CharStatusAttr attr = (CharStatusAttr)Activator.CreateInstance(field.FieldType);
				field.SetValue(this, attr);
				m_attrs.Add(field.Name.GetHashCode(), attr);
			}
		}

		[Token(Token = "0x60048D9")]
		[Address(RVA = "0x23E8AF0", Offset = "0x23E8AF0", VA = "0x23E8AF0")]
		static CharStatus()
		{
			StatDesc = new Dictionary<int, StatDesc>();
			HashCodeToString = new Dictionary<int, string>();
			m_charStatusAttrfields = new List<FieldInfo>();
			foreach (FieldInfo field in typeof(CharStatus).GetFields())
			{
				if (field.FieldType != typeof(CharStatusAttr))
				{
					continue;
				}
				m_charStatusAttrfields.Add(field);
				HashCodeToString[field.Name.GetHashCode()] = field.Name;
				// StatDesc vem de atributos customizados nos campos, que o IL2CPP nao preserva com argumentos
			}
		}

		[Token(Token = "0x60048DB")]
		[Address(RVA = "0x23E9164", Offset = "0x23E9164", VA = "0x23E9164")]
		public CharStatusAttr GetAttr(int hashcode)
		{
			return m_attrs[hashcode];
		}

		[Token(Token = "0x60048DC")]
		[Address(RVA = "0x23E9204", Offset = "0x23E9204", VA = "0x23E9204", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x23E96F0", Offset = "0x23E96F0", VA = "0x23E96F0")]
		public void Clear()
		{
			foreach (KeyValuePair<int, CharStatusAttr> pair in m_attrs)
			{
				pair.Value.Clear();
			}
		}

		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x23E9880", Offset = "0x23E9880", VA = "0x23E9880")]
		public bool Empty()
		{
			foreach (KeyValuePair<int, CharStatusAttr> pair in m_attrs)
			{
				if (!pair.Value.IsEmpty())
				{
					return false;
				}
			}
			return true;
		}

		[Token(Token = "0x60048DF")]
		[Address(RVA = "0x23E9A58", Offset = "0x23E9A58", VA = "0x23E9A58")]
		public void Merge(CharStatus rhs, float multiply = 1f)
		{
			// o original mescla os 40 campos em sequencia; a ordem nao altera o resultado
			if (rhs == null)
			{
				return;
			}
			foreach (FieldInfo field in m_charStatusAttrfields)
			{
				((CharStatusAttr)field.GetValue(this)).Merge((CharStatusAttr)field.GetValue(rhs), multiply);
			}
		}

		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x23E9EC0", Offset = "0x23E9EC0", VA = "0x23E9EC0")]
		public void Copy(CharStatus rhs)
		{
			foreach (KeyValuePair<int, CharStatusAttr> pair in m_attrs)
			{
				pair.Value.Set(rhs.GetAttr(pair.Key));
			}
		}

		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x23EA098", Offset = "0x23EA098", VA = "0x23EA098", Slot = "5")]
		public void OnCleanupInObjectPool()
		{
			Clear();
		}

		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x23EA09C", Offset = "0x23EA09C", VA = "0x23EA09C", Slot = "6")]
		public virtual void Dispose()
		{
			ObjectRepository<CharStatus>.Release(this);
		}

		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x23EA15C", Offset = "0x23EA15C", VA = "0x23EA15C")]
		public static CharStatus New()
		{
			return ObjectRepository<CharStatus>.New();
		}

		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x23EA214", Offset = "0x23EA214", VA = "0x23EA214")]
		public static void Release(CharStatus status)
		{
			ObjectRepository<CharStatus>.Release(status);
		}
	}
}
