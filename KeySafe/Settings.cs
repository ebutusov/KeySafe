using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace KeySafe
{

	[Serializable]
	public class Settings : ISerializable
	{
		public int VERSION = 1;
		public string Filename = null;

		public Settings() { }

		public Settings(SerializationInfo info, StreamingContext ctx)
		{
			int ver = (int)info.GetValue("VERSION", typeof(int));
			Filename = (string)info.GetValue("Filename", typeof(string));
		}

		public static void WriteSettings(Settings s, Stream stream)
		{
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(stream, s);
		}

		public static Settings ReadSettings(Stream stream)
		{
			BinaryFormatter bf = new BinaryFormatter();
			Settings s = (Settings)bf.Deserialize(stream);
			return s;
		}

		#region ISerializable Members

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("VERSION", VERSION);
			info.AddValue("Filename", Filename);
		}

		#endregion
	}
}
