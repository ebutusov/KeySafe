namespace KeySafe
{
	partial class AboutDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDlg));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btOK = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(145, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "KeySafe v0.1 ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(121, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "E.Butusov <ebutusov@gmail.com>";
			// 
			// btOK
			// 
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(149, 147);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(79, 27);
			this.btOK.TabIndex = 2;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(5, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 109);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// AboutDlg
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btOK;
			this.ClientSize = new System.Drawing.Size(362, 186);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}