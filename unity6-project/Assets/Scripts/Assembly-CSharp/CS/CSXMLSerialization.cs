using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008D5")]
	public static class CSXMLSerialization
	{
		[Token(Token = "0x600472B")]
		public static void Serialize<T>(string filename, T data, Encoding encoding)
		{
		}

		// Metodos genericos nao tem corpo proprio no IL2CPP (codigo compartilhado); implementacao padrao com XmlSerializer.
		[Token(Token = "0x600472C")]
		public static T Deserialize<T>(CSFileLoaderBase loader, Encoding encoding)
		{
			if (loader == null)
			{
				return default(T);
			}
			string text = loader.Load();
			if (string.IsNullOrEmpty(text))
			{
				return default(T);
			}
			return DeserializeFromXmlString<T>(text);
		}

		[Token(Token = "0x600472D")]
		public static T DeserializeFromXmlString<T>(string xmlString)
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				using (StringReader reader = new StringReader(xmlString))
				{
					return (T)serializer.Deserialize(reader);
				}
			}
			catch (Exception e)
			{
				CSLog.Error("XML deserialize failed ({0}): {1}", typeof(T).Name, e.Message);
				return default(T);
			}
		}
	}
}
