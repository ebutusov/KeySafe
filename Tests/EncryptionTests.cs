using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KeySafe;

namespace Tests
{
	[TestClass]
	public class EncryptionTests
	{
		[TestMethod]
		public void TestSymmetricEncDec()
		{
			const string password = "pass";
			const string secret = "Secret message";
			byte[] input = Encoding.UTF8.GetBytes(secret);
			Coder coder = new Coder();

			byte[] encoded = coder.Encrypt(input, password, true);
			Assert.IsNotNull(encoded);
			Assert.IsTrue(encoded.Length > 0);
			string decoded = coder.Decrypt(encoded, password);
			Assert.AreEqual(decoded, secret);
		}
	}
}
