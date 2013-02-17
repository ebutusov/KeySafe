using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace KeySafe
{
	public class Coder
	{
		const int MD5_HASH_SIZE_BITS = 128;
		byte[] SALT_HEADER = Encoding.UTF8.GetBytes("Salted__");
		const int mKeyBits = 256,
							mBlockSize = 128;
		RijndaelManaged mAES = null;

		public Coder()
		{
			InitAES();
		}

		void InitAES()
		{
			mAES = new RijndaelManaged();
			mAES.Mode = CipherMode.CBC;
			mAES.Padding = PaddingMode.PKCS7;
			mAES.BlockSize = mBlockSize;
			mAES.KeySize = mKeyBits;
		}

		#region Clearing

		void ClearBuffer(byte[] buffer)
		{
			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
				rng.GetNonZeroBytes(buffer);
		}

		public void Clear()
		{
			ClearSensitiveData();
		}

		void ClearSensitiveData()
		{
			byte[][] data = new byte[2][] { mAES.IV, mAES.Key };
			foreach (var d in data)
			{
				if (d != null && d.Length > 0)
					ClearBuffer(d);
			}
		}

		#endregion Clearing

		#region Encryption

		void DeriveKeyAndIV(string password, byte[] salt)
		{
			// hash0 = ''
			// hash1 = md5(hash0 + password + salt)
			// hash2 = md2(hash1 + password + salt)
		
			byte[] pass = Encoding.UTF8.GetBytes(password);

			if (salt == null)
				salt = new byte[0];

			MD5 md5 = MD5.Create();
			int count = (mKeyBits + mBlockSize) / MD5_HASH_SIZE_BITS;

			List<byte[]> hashes = new List<byte[]>();
			for (int i=0;i<=count;i++)
				hashes.Add(new byte[0]);

			for (int i = 1; i <= count; i++)
			{
				int offset = 0;
				byte[] buff = new byte[hashes[i - 1].Length + pass.Length + salt.Length];
				Buffer.BlockCopy(hashes[i - 1], 0, buff, offset, hashes[i - 1].Length);
				offset += hashes[i-1].Length;
				Buffer.BlockCopy(pass, 0, buff, offset, pass.Length);
				offset += pass.Length;
				if (salt.Length > 0)
					Buffer.BlockCopy(salt, 0, buff, offset, salt.Length);
				hashes[i] = md5.ComputeHash(buff);
			}

			byte[] key = new byte[mKeyBits / 8];
			byte[] IV = new byte[mBlockSize / 8];

			//Buffer.BlockCopy(hashes[1], 0, mKey, 0, hashes[1].Length);
			//Buffer.BlockCopy(hashes[2], 0, mKey, 16, hashes[2].Length);
			//Buffer.BlockCopy(hashes[3], 0, mIV, 0, hashes[3].Length);
			//Buffer.BlockCopy(hashes[4], 0, mIV, 16, hashes[4].Length);

			int nh = 1;
			// compose key from first n hashes that would fill the mKeyBits
			for (int i = 1, off = 0; i <= mKeyBits/MD5_HASH_SIZE_BITS; i++, nh++, off++)
				Buffer.BlockCopy(hashes[i], 0, key, off * (MD5_HASH_SIZE_BITS/8), hashes[i].Length);
			// the IV is composed from the rest of the hashes
			for (int i = nh, off = 0; i < hashes.Count; i++, off++)
				Buffer.BlockCopy(hashes[i], 0, IV, off * (MD5_HASH_SIZE_BITS/8), hashes[i].Length);

			mAES.Key = key;
			mAES.IV = IV;
			ClearBuffer(key);
			ClearBuffer(IV);
		}

		public byte[] Encrypt(byte[] data, string password, bool salted = true)
		{
			byte[] salt = new byte[0];
			if (salted)
			{
				salt = new byte[8];
				using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
					rng.GetNonZeroBytes(salt);
			}
			DeriveKeyAndIV(password, salt);
			ICryptoTransform enc = mAES.CreateEncryptor();
			byte[] combine = null;
			
			using (MemoryStream ms = new MemoryStream())
			using (CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
			{
				cs.Write(data, 0, data.Length);
				cs.Flush();
				cs.Close();
				byte[] encoded = ms.ToArray();

				int offset = 0;
				if (salted)
				{
					combine = new byte[SALT_HEADER.Length + salt.Length + encoded.Length];
					Buffer.BlockCopy(SALT_HEADER, 0, combine, 0, SALT_HEADER.Length);
					Buffer.BlockCopy(salt, 0, combine, SALT_HEADER.Length, salt.Length);
					offset = SALT_HEADER.Length + salt.Length;
				}
				else
					combine = new byte[encoded.Length];
				
				Buffer.BlockCopy(encoded.ToArray(), 0, combine, offset, encoded.Length);
			}
			ClearSensitiveData();
			return combine;
		}

		public string Decrypt(byte[] data, string password)
		{
			byte[] aesdata = data;
			byte[] salt = new byte[0];

			if (IsDataEqualRange(aesdata, 0, SALT_HEADER, 0, 8))
			{
				// salted
				salt = new byte[8];
				Buffer.BlockCopy(aesdata, 8, salt, 0, 8);
				// offset the data
				int aeslen = data.Length - 16;
				aesdata = new byte[aeslen];
				Buffer.BlockCopy(data, 16, aesdata, 0, aeslen);
			}
			DeriveKeyAndIV(password, salt);
			ICryptoTransform dec = mAES.CreateDecryptor();
			//byte[] clear = dec.TransformFinalBlock(aesdata, 0, aesdata.Length);
			string decrypted = null;
			
			using (MemoryStream ms = new MemoryStream(aesdata))
			using (CryptoStream cs = new CryptoStream(ms, dec, CryptoStreamMode.Read))
			using (StreamReader rdr = new StreamReader(cs))
			{
				decrypted = rdr.ReadToEnd();
				rdr.Close();
			}
			ClearSensitiveData();
			return decrypted;
		}

		#endregion Encryption

		#region Utility
		/// <summary>
		/// Compares two byte subsets to determine bit-wise equality.
		/// </summary>
		private bool IsDataEqualRange(byte[] b1, int b1Offset, byte[] b2, int b2Offset, int length)
		{
			if (b1 == null) return false;
			if (b2 == null) return false;

			if (b1Offset + length > b1.Length) return false;
			if (b2Offset + length > b2.Length) return false;

			bool match = true;

			for (int i = 0; i < length && match; i++)
			{
				match = (b1[b1Offset + i] == b2[b2Offset + i]);
				if (!match) break;
			}
			return match;
		}
		#endregion Utility
	}
}
