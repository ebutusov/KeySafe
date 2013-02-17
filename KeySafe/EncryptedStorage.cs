using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace KeySafe
{
	public class EncryptedStorage
	{
		private string mFile;
		private Coder mCoder = new Coder();
		const string BACKUP_FILE = "_tmpsafe11.ks";

		public EncryptedStorage(string file)
		{
			mFile = file;
		}

		private byte[] ReadFile()
		{
			byte[] buf = null;
			using (FileStream fs = new FileStream(mFile, FileMode.Open, FileAccess.Read))
			{
				long len = fs.Length;
				if (len > 0)
				{
					buf = new byte[len];
					int total = 0, count = 0;
					while ((count = fs.Read(buf, total, (int)len - total)) > 0)
						total += count;
					fs.Close();
				}
			}
			return buf;
		}

		private bool Matches(string[] items, string filter)
		{
			string[] flt = filter.Split(' ');
			int m = 0;
			for (int i = 0; i < items.Length; ++i)
			{
				if (i == 2) continue; // don't match against passwords!
				foreach (string f in flt)
					if (items[i].Contains(f))
						++m;
			}
			if (m >= flt.Length)
				return true;
			return false;
		}

		public List<KeyEntry> GetEntries(string password, string filter = null)
		{
			string[] keys = GetKeys(password);
			if (keys == null || keys.Length == 0)
				return null;
			List<KeyEntry> entries = new List<KeyEntry>();

			foreach (string k in keys)
			{
				if (!string.IsNullOrEmpty(filter))
				{
					string[] items = k.Split(':');
					if (Matches(items, filter))
						entries.Add(new KeyEntry(k));
				}
				else
					entries.Add(new KeyEntry(k));
			}
			return entries;
		}

		private string GetDir(string file)
		{
			int bs = file.LastIndexOf('\\');
			if (bs != -1)
				return file.Substring(0, bs);
			return "";
		}

		private void SaveKeys(string[] lines, string password)
		{
			string dir = GetDir(mFile);
			string outfile = Path.Combine(dir, BACKUP_FILE);

			// nothing to write, just erase file contents
			if (lines == null || lines.Length == 0)
			{
				File.WriteAllText(mFile, string.Empty);
				return;
			}

			try
			{
				StringBuilder all = new StringBuilder();
				for (int i = 0; i < lines.Length; ++i)
				{
					lines[i] = lines[i] + "\r\n";
					all.Append(lines[i]);
				}
				byte[] data = Encoding.UTF8.GetBytes(all.ToString());
				byte[] encrypted = mCoder.Encrypt(data, password);
				using (FileStream fs = new FileStream(outfile, FileMode.Create, FileAccess.Write))
				{
					fs.Write(encrypted, 0, encrypted.Length);
					fs.Flush();
					fs.Close();
				}
				File.Copy(outfile, mFile, true);
			}
			finally
			{
				if (File.Exists(outfile))
					File.Delete(outfile);
			}
		}

		public bool RemoveEntry(KeyEntry entry, string password)
		{
			string line = entry.ToLine();
			string[] lines = GetKeys(password);
			if (lines == null) return false;

			var q = from l in lines
							where l != line
							select l;

			if (q.Count() != lines.Length - 1) 
				return false;
			
			SaveKeys(q.ToArray(), password);
			return true;
		}

		public bool AddEntry(KeyEntry entry, string password)
		{
			string line = entry.ToLine();
			string[] lines = GetKeys(password);
			if (lines == null)
				lines = new string[0];

			string[] linesNew = new string[lines.Length + 1];
			Array.Copy(lines, linesNew, lines.Length);
			linesNew[linesNew.Length - 1] = line;
			SaveKeys(linesNew, password);
			return true;
		}

		public bool ReplaceEntry(KeyEntry oldEntry, KeyEntry newEntry, string password)
		{
			if (newEntry.Domain != oldEntry.Domain ||
				newEntry.User != oldEntry.User)
				throw new Exception("Entry has been modified in a way it shouldn't!");

			string oldLine = oldEntry.ToLine();
			string newLine = newEntry.ToLine();

			string[] lines = GetKeys(password);
			if (lines == null)
				return false;

			bool replaced = false;
			for (int i = 0; i < lines.Length; ++i)
				if (lines[i] == oldLine)
				{
					lines[i] = newLine;
					replaced = true;
				}

			if (replaced)
				SaveKeys(lines, password);
			return replaced;
		}

		public string[] GetKeys(string password)
		{
			byte[] data = ReadFile();
			if (data == null) return new string[0]; // empty file?
			try 
			{	        
				string decrypted = mCoder.Decrypt(data, password);
				if (!string.IsNullOrEmpty(decrypted))
				{
					string[] lines = decrypted.Split("\r\n".ToArray(),StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < lines.Length; i++)
						lines[i] = lines[i].TrimEnd(" \r\t".ToCharArray());
					
					var q = from l in lines
								where l.Length > 0
								 select l;
					return q.ToArray();
				}
			}
			catch (Exception e)
			{
				mCoder.Clear();
				throw new Exception("Failed to decode the storage!", e);
			}
			return null;
		}
	}
}
