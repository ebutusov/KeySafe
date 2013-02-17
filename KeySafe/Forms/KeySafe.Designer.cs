namespace KeySafe
{
	partial class KeySafe
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySafe));
			this.btFind = new System.Windows.Forms.Button();
			this.gridResults = new System.Windows.Forms.DataGridView();
			this.domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tbFilter = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lbStatusResults = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registerStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unregisterStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutKeeSafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btFind
			// 
			this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btFind.Location = new System.Drawing.Point(533, 16);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(56, 32);
			this.btFind.TabIndex = 1;
			this.btFind.Text = "Find";
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridResults
			// 
			this.gridResults.AllowUserToAddRows = false;
			this.gridResults.AllowUserToDeleteRows = false;
			this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domain,
            this.user,
            this.password,
            this.comment});
			this.gridResults.ContextMenuStrip = this.contextMenuStrip;
			this.gridResults.Location = new System.Drawing.Point(0, 90);
			this.gridResults.MultiSelect = false;
			this.gridResults.Name = "gridResults";
			this.gridResults.ReadOnly = true;
			this.gridResults.RowTemplate.Height = 24;
			this.gridResults.Size = new System.Drawing.Size(619, 236);
			this.gridResults.TabIndex = 2;
			this.gridResults.SelectionChanged += new System.EventHandler(this.gridResults_SelectionChanged);
			// 
			// domain
			// 
			this.domain.DataPropertyName = "domain";
			this.domain.HeaderText = "Domain";
			this.domain.Name = "domain";
			this.domain.ReadOnly = true;
			// 
			// user
			// 
			this.user.DataPropertyName = "user";
			this.user.HeaderText = "User";
			this.user.Name = "user";
			this.user.ReadOnly = true;
			// 
			// password
			// 
			this.password.DataPropertyName = "password";
			this.password.HeaderText = "Password";
			this.password.Name = "password";
			this.password.ReadOnly = true;
			// 
			// comment
			// 
			this.comment.DataPropertyName = "comment";
			this.comment.HeaderText = "Comment";
			this.comment.Name = "comment";
			this.comment.ReadOnly = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEdit,
            this.ctxDelete});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(123, 52);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// ctxEdit
			// 
			this.ctxEdit.Name = "ctxEdit";
			this.ctxEdit.Size = new System.Drawing.Size(122, 24);
			this.ctxEdit.Text = "Edit";
			this.ctxEdit.Click += new System.EventHandler(this.ctxEdit_Click);
			// 
			// ctxDelete
			// 
			this.ctxDelete.Name = "ctxDelete";
			this.ctxDelete.Size = new System.Drawing.Size(122, 24);
			this.ctxDelete.Text = "Delete";
			this.ctxDelete.Click += new System.EventHandler(this.ctxDelete_Click);
			// 
			// tbFilter
			// 
			this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFilter.Location = new System.Drawing.Point(6, 21);
			this.tbFilter.Name = "tbFilter";
			this.tbFilter.Size = new System.Drawing.Size(521, 22);
			this.tbFilter.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatusResults});
			this.statusStrip.Location = new System.Drawing.Point(0, 329);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(619, 22);
			this.statusStrip.TabIndex = 3;
			this.statusStrip.Text = "statusStrip1";
			// 
			// lbStatusResults
			// 
			this.lbStatusResults.Name = "lbStatusResults";
			this.lbStatusResults.Size = new System.Drawing.Size(0, 17);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(619, 28);
			this.menuStrip.TabIndex = 5;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStorageToolStripMenuItem,
            this.unregisterStorageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// registerStorageToolStripMenuItem
			// 
			this.registerStorageToolStripMenuItem.Name = "registerStorageToolStripMenuItem";
			this.registerStorageToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
			this.registerStorageToolStripMenuItem.Text = "Register storage";
			this.registerStorageToolStripMenuItem.Click += new System.EventHandler(this.registerStorageToolStripMenuItem_Click);
			// 
			// unregisterStorageToolStripMenuItem
			// 
			this.unregisterStorageToolStripMenuItem.Name = "unregisterStorageToolStripMenuItem";
			this.unregisterStorageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.unregisterStorageToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
			this.unregisterStorageToolStripMenuItem.Text = "Unregister storage";
			this.unregisterStorageToolStripMenuItem.Click += new System.EventHandler(this.unregisterStorageToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.showPasswordsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.addToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
			this.addToolStripMenuItem.Text = "New";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
			this.clearToolStripMenuItem.Text = "Wipe";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// showPasswordsToolStripMenuItem
			// 
			this.showPasswordsToolStripMenuItem.CheckOnClick = true;
			this.showPasswordsToolStripMenuItem.Name = "showPasswordsToolStripMenuItem";
			this.showPasswordsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
			this.showPasswordsToolStripMenuItem.Text = "Show passwords";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutKeeSafeToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.aboutToolStripMenuItem.Text = "Help";
			// 
			// aboutKeeSafeToolStripMenuItem
			// 
			this.aboutKeeSafeToolStripMenuItem.Name = "aboutKeeSafeToolStripMenuItem";
			this.aboutKeeSafeToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
			this.aboutKeeSafeToolStripMenuItem.Text = "About KeySafe";
			this.aboutKeeSafeToolStripMenuItem.Click += new System.EventHandler(this.aboutKeeSafeToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tbFilter);
			this.groupBox1.Controls.Add(this.btFind);
			this.groupBox1.Location = new System.Drawing.Point(12, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(595, 53);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "domain";
			this.dataGridViewTextBoxColumn1.HeaderText = "Domain";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 143;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "user";
			this.dataGridViewTextBoxColumn2.HeaderText = "User";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 144;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
			this.dataGridViewTextBoxColumn3.HeaderText = "Password";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 143;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn4.HeaderText = "Comment";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 143;
			// 
			// KeySafe
			// 
			this.AcceptButton = this.btFind;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 351);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.gridResults);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "KeySafe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KeySafe";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeySafe_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.DataGridView gridResults;
		private System.Windows.Forms.DataGridViewTextBoxColumn domain;
		private System.Windows.Forms.DataGridViewTextBoxColumn user;
		private System.Windows.Forms.DataGridViewTextBoxColumn password;
		private System.Windows.Forms.DataGridViewTextBoxColumn comment;
		private System.Windows.Forms.TextBox tbFilter;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lbStatusResults;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registerStorageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.ToolStripMenuItem unregisterStorageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutKeeSafeToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ctxEdit;
		private System.Windows.Forms.ToolStripMenuItem showPasswordsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ctxDelete;
	}
}

