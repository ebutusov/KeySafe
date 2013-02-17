namespace KeySafe
{
	partial class PasswordDlg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbRepeat = new System.Windows.Forms.Label();
			this.tbRepeat = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(85, 12);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(251, 22);
			this.tbPassword.TabIndex = 0;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(203, 77);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(62, 24);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(271, 77);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(62, 24);
			this.btCancel.TabIndex = 4;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Password";
			// 
			// lbRepeat
			// 
			this.lbRepeat.AutoSize = true;
			this.lbRepeat.Location = new System.Drawing.Point(12, 41);
			this.lbRepeat.Name = "lbRepeat";
			this.lbRepeat.Size = new System.Drawing.Size(54, 17);
			this.lbRepeat.TabIndex = 5;
			this.lbRepeat.Text = "Repeat";
			// 
			// tbRepeat
			// 
			this.tbRepeat.Location = new System.Drawing.Point(85, 41);
			this.tbRepeat.Name = "tbRepeat";
			this.tbRepeat.Size = new System.Drawing.Size(251, 22);
			this.tbRepeat.TabIndex = 2;
			this.tbRepeat.UseSystemPasswordChar = true;
			// 
			// PasswordDlg
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(348, 110);
			this.Controls.Add(this.lbRepeat);
			this.Controls.Add(this.tbRepeat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.tbPassword);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PasswordDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Enter password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbRepeat;
		private System.Windows.Forms.TextBox tbRepeat;
	}
}