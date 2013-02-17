using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KeySafe
{
	public class KeyEntry : ICloneable
	{
		public string Domain { get; set; }
		public string User { get; set; }
		public string Password { get; set; }
		public string Comment { get; set; }

		public KeyEntry(string domain, string user, string password, string comment = null)
		{
			Domain = domain;
			User = user;
			Password = password;
			Comment = comment;
		}

		public KeyEntry(string line)
		{
			string[] items = line.Split(':');
			if (items != null)
			{
				if (items.Length >= 3)
				{
					Domain = items[0];
					User = items[1];
					Password = items[2];
				}
				else
					throw new Exception("Malformed input line!");
				if (items.Length >= 4)
					Comment = items[3];
			}
		}

		public string ToLine()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(string.Join(":", Domain, User, Password));
			if (!string.IsNullOrEmpty(Comment))
			{
				sb.Append(":");
				sb.Append(Comment);
			}
			return sb.ToString();
		}

		#region ICloneable Members

		public object Clone()
		{
			return new KeyEntry(Domain, User, Password, Comment);
		}

		#endregion
	}
}
