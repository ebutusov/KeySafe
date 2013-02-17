namespace KeySafe
{
	partial class AddDlg
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDomain = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbComment = new System.Windows.Forms.TextBox();
			this.btCancel = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.tbRepeat = new System.Windows.Forms.TextBox();
			this.lbRepeat = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Domain:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "User:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Comment:";
			// 
			// tbDomain
			// 
			this.tbDomain.Location = new System.Drawing.Point(139, 26);
			this.tbDomain.Name = "tbDomain";
			this.tbDomain.Size = new System.Drawing.Size(224, 22);
			this.tbDomain.TabIndex = 0;
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(139, 55);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(224, 22);
			this.tbUser.TabIndex = 1;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(139, 83);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(224, 22);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbComment
			// 
			this.tbComment.Location = new System.Drawing.Point(139, 145);
			this.tbComment.Name = "tbComment";
			this.tbComment.Size = new System.Drawing.Size(224, 22);
			this.tbComment.TabIndex = 4;
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(328, 195);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 23);
			this.btCancel.TabIndex = 7;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(247, 195);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 23);
			this.btOK.TabIndex = 6;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// tbRepeat
			// 
			this.tbRepeat.Location = new System.Drawing.Point(139, 115);
			this.tbRepeat.Name = "tbRepeat";
			this.tbRepeat.Size = new System.Drawing.Size(224, 22);
			this.tbRepeat.TabIndex = 3;
			this.tbRepeat.UseSystemPasswordChar = true;
			// 
			// lbRepeat
			// 
			this.lbRepeat.AutoSize = true;
			this.lbRepeat.Location = new System.Drawing.Point(19, 114);
			this.lbRepeat.Name = "lbRepeat";
			this.lbRepeat.Size = new System.Drawing.Size(122, 17);
			this.lbRepeat.TabIndex = 3;
			this.lbRepeat.Text = "Repeat password:";
			// 
			// AddDlg
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(414, 230);
			this.Controls.Add(this.tbRepeat);
			this.Controls.Add(this.lbRepeat);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.tbComment);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.tbDomain);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add entry";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbDomain;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbComment;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.TextBox tbRepeat;
		private System.Windows.Forms.Label lbRepeat;
	}
}