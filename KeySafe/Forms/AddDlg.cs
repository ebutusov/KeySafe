using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeySafe
{
	public partial class AddDlg : Form
	{
		bool mEditMode = false;
		EncryptedStorage mStorage;
		KeyEntry mKeyEntry;

		public AddDlg(EncryptedStorage es, bool edit = false, KeyEntry entry = null)
		{
			InitializeComponent();
			mStorage = es;
			mEditMode = edit;
			mKeyEntry = entry;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Init();
		}

		private void Init()
		{
			tbDomain.Enabled = tbUser.Enabled = !mEditMode;
			if (mEditMode)
			{
				tbDomain.Text = mKeyEntry.Domain;
				tbUser.Text = mKeyEntry.User;
				tbComment.Text = mKeyEntry.Comment;
			}
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			if (tbPassword.Text != tbRepeat.Text)
			{
				MessageBox.Show("Passwords don't match!",
					"Check passwords", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (mEditMode && tbPassword.Text == mKeyEntry.Password &&
				tbComment.Text == mKeyEntry.Comment)
			{
				DialogResult = System.Windows.Forms.DialogResult.Cancel;
				return; // nothing to save
			}

			KeyEntry newEntry;
			if (mEditMode)
			{
				newEntry = (KeyEntry)mKeyEntry.Clone();
				if (tbPassword.Text.Length > 0)
					newEntry.Password = tbPassword.Text;
				newEntry.Comment = tbComment.Text;
			}
			else
			{
				if (tbDomain.Text.Length == 0 || tbUser.Text.Length == 0 || tbPassword.Text.Length == 0)
				{
					MessageBox.Show("Please fill at least Domain, User and Password fields!",
						"Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				newEntry = new KeyEntry(tbDomain.Text, tbUser.Text, tbPassword.Text, tbComment.Text);
			}

			try
			{
				PasswordDlg pdlg = new PasswordDlg(true);
				if (pdlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;
				bool ok = true;
				if (mEditMode)
					ok = mStorage.ReplaceEntry(mKeyEntry, newEntry, pdlg.Password);
				else
					ok = mStorage.AddEntry(newEntry, pdlg.Password);

				if (!ok)
					MessageBox.Show("Operation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				string msg = ex.Message;
				if (ex.InnerException != null)
					msg += "\r\n" + ex.InnerException.Message;
				MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			DialogResult = DialogResult.OK;
		}
	}
}
