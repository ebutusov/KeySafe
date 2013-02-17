using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace KeySafe
{
	public partial class KeySafe : Form
	{
		const string SETTINGS_FILENAME = "Settings.st";
		const string APP_NAME = "KeySafe";

		string mPassword = null;
		Timer timerPasswordErase = new Timer();
		Timer timerResultsErase = new Timer();

		Settings mSettings = null;

		bool mShowAllPasswords = false;

		public KeySafe()
		{
			InitializeComponent();
			SetShowPasswords(false);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			LoadOrStoreSettings(false);
		}

		private void SetShowPasswords(bool show)
		{
			gridResults.Columns[2].CellTemplate = (show ? 
				(DataGridViewCell)new DataGridViewTextBoxCell() :
				new DataGridViewPasswordCell());

			//DataGridViewColumn col = (show ? 
			//	(DataGridViewColumn)new DataGridViewTextBoxColumn() : (DataGridViewColumn)new DataGridViewPasswordColumn());
			//gridResults.Columns.RemoveAt(2);
			//col.HeaderText = "Password";
			//col.DataPropertyName = "password";
			//gridResults.Columns.Insert(2, col);
			mShowAllPasswords = show;
		}

		private void ResetStatus()
		{
			lbStatusResults.Text = "None";
		}

		private void SetResultsTimer()
		{
			timerResultsErase.Stop();
			timerResultsErase.Interval = 60000; //  60 secs
			timerResultsErase.Tick += timerResultsErase_Tick;
			timerResultsErase.Start();
		}

		List<KeyEntry> mEmptyList = new List<KeyEntry>();
		void ResetResults()
		{
			timerResultsErase.Stop();
			gridResults.DataSource = mEmptyList;
			ResetStatus();
			tbFilter.Text = "";
			tbFilter.Focus();
		}

		void timerResultsErase_Tick(object sender, EventArgs e)
		{
			ResetResults();
		}

		private void SetPasswordTimer()
		{
			timerPasswordErase.Stop();
			timerPasswordErase.Interval = 15000; // 15 secs
			timerPasswordErase.Tick += timerPasswordErase_Tick;
			timerPasswordErase.Start();
		}

		void ResetPassword()
		{
			timerPasswordErase.Stop();
			mPassword = null;
			ResetStatus();
		}

		void timerPasswordErase_Tick(object sender, EventArgs e)
		{
			ResetPassword();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbFilter.Text))
				return;

			if (string.IsNullOrEmpty(mSettings.Filename))
			{
				MessageBox.Show("Please register key storage first!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (mPassword == null)
			{
				PasswordDlg pdlg = new PasswordDlg();
				if (pdlg.ShowDialog(this) != DialogResult.OK || string.IsNullOrEmpty(pdlg.Password))
					return;
				mPassword = pdlg.Password;
				pdlg.Dispose();
			}
			SetShowPasswords(showPasswordsToolStripMenuItem.Checked);
			SetPasswordTimer();
			EncryptedStorage es = new EncryptedStorage(mSettings.Filename);
			string t = tbFilter.Text.Trim();
			if (tbFilter.Text == "*")
				t = "";
			try
			{
				List<KeyEntry> entries = es.GetEntries(mPassword, t);
				if (entries == null || entries.Count() == 0)
				{
					ResetStatus();
					if (entries != null)
						entries.Clear();
				}
				else
				{
					lbStatusResults.Text = string.Format("Results: {0}", entries.Count());
					//if (dt.Rows.Count > 1)
					//	gridResults.Focus();
					SetResultsTimer();
				}
				if (entries == null)
					gridResults.DataSource = mEmptyList;
				else
					gridResults.DataSource = entries;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ResetPassword();
			}
		}

		void LoadOrStoreSettings(bool store)
		{
			try
			{
				string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
					Assembly.GetExecutingAssembly().GetName().Name);
				if (!Directory.Exists(folder))
					Directory.CreateDirectory(folder);
				
				string filename = Path.Combine(folder, SETTINGS_FILENAME);
				using (FileStream fs = new FileStream(filename, (store ? FileMode.Create : FileMode.Open)))
				{
					if (store)
						Settings.WriteSettings(mSettings, fs);
					else
						mSettings = Settings.ReadSettings(fs);
					fs.Close();
				}
			}
			catch (Exception)
			{
				if (store)
					MessageBox.Show("Failed to store settings file!", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);					
				else
					mSettings = new Settings();
			}
		}

		private void KeySafe_FormClosed(object sender, FormClosedEventArgs e)
		{
			LoadOrStoreSettings(true);
			ResetPassword();
			ResetResults();
		}

		private void registerStorageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog fd = new OpenFileDialog())
			{
				fd.Filter = "All files (*.*)|*.*";
				fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				fd.RestoreDirectory = true;

				if (fd.ShowDialog() == DialogResult.OK)
				{
					mSettings.Filename = fd.FileName;
					LoadOrStoreSettings(true);
					ResetPassword();
					ResetResults();
				} 
			}
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetPassword();
			ResetResults();
		}

		private void unregisterStorageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetPassword();
			ResetResults();
			mSettings.Filename = null;
			LoadOrStoreSettings(true);
		}

		private void gridResults_SelectionChanged(object sender, EventArgs e)
		{
			//if (gridResults.SelectedCells != null && gridResults.SelectedCells.Count == 1)
			//	gridResults.Rows[gridResults.SelectedCells[0].RowIndex].Selected = true;
		}

		private void aboutKeeSafeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var dlg = new AboutDlg())
				dlg.ShowDialog();
		}

		private KeyEntry GetCurrentKeyEntry()
		{
			if (gridResults.CurrentRow == null)
				return null;
			KeyEntry entry = gridResults.CurrentRow.DataBoundItem as KeyEntry;
			return entry;
		}

		private void ctxEdit_Click(object sender, EventArgs e)
		{
			KeyEntry entry = GetCurrentKeyEntry();
			if (entry == null)
				return;
			gridResults.CurrentRow.Cells[0].Selected = true;

			using (AddDlg dlg = new AddDlg(new EncryptedStorage(mSettings.Filename), true, entry))
			{
				if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					ResetResults();
				
			}
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			if (gridResults.CurrentRow == null)
				e.Cancel = true;
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AddDlg dlg = new AddDlg(new EncryptedStorage(mSettings.Filename), false, null))
			{
				if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					ResetResults(); 
			}
		}

		private void ctxDelete_Click(object sender, EventArgs e)
		{
			KeyEntry entry = GetCurrentKeyEntry();
			if (entry == null) return;

			if (MessageBox.Show("Are you sure you want to delete entry for " + entry.Domain + "?", "Confirm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				using (PasswordDlg pdlg = new PasswordDlg(true))
				{
					if (pdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						EncryptedStorage enc = new EncryptedStorage(mSettings.Filename);
						try
						{
							if (enc.RemoveEntry(entry, pdlg.Password))
							{
								MessageBox.Show("Entry has been removed!", "Removed",
									MessageBoxButtons.OK, MessageBoxIcon.Information);
								ResetResults();
							}
							else
								MessageBox.Show("Entry cannot be removed!", "Error",
									MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Operation failed!\r\n" + ex.Message, "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					} 
				}
			}
		}
	}
}
