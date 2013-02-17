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
	public partial class PasswordDlg : Form
	{
		private bool mWithRepeat = false;
		public PasswordDlg(bool withRepeat = false)
		{
			InitializeComponent();
			mWithRepeat = withRepeat;
			tbRepeat.Visible = lbRepeat.Visible = mWithRepeat;
		}

		public string Password
		{
			get
			{
				return tbPassword.Text;
			}
			private set { }
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbPassword.Text))
				return;

			if (tbRepeat.Visible && tbRepeat.Text.Length == 0)
			{
				tbRepeat.Focus();
				return;
			}

			if (mWithRepeat && tbPassword.Text != tbRepeat.Text)
			{
				MessageBox.Show("Entered passwords don't match!", "Check password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbRepeat.Text = tbPassword.Text = "";
				tbPassword.Focus();
				return;
			}

			DialogResult = System.Windows.Forms.DialogResult.OK;
		}
	}
}
