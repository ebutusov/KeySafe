using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KeySafe;
using System.IO;

namespace Tests
{
	[TestClass]
	public class SettingsTest
	{
		[TestMethod]
		public void TestSerialization()
		{
			string fn = "myfile";

			Settings settings = new Settings();
			settings.Filename = fn;

			MemoryStream ms = new MemoryStream();
			Settings.WriteSettings(settings, ms);

			ms.Seek(0, SeekOrigin.Begin);

			Settings settings2 = Settings.ReadSettings(ms);
			Assert.AreEqual(settings.Filename, settings2.Filename);
			ms.Close();
		}
	}
}
