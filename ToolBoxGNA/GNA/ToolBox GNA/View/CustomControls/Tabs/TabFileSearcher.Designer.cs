namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabFileSearcher
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RtbInfo2 = new System.Windows.Forms.RichTextBox();
			this.RtbInfo1 = new System.Windows.Forms.RichTextBox();
			this.BtnMoveFiles = new System.Windows.Forms.Button();
			this.BtnDeleteFiles = new System.Windows.Forms.Button();
			this.BtnCreateFiles = new System.Windows.Forms.Button();
			this.BtnRenameFiles = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.LblDestination = new System.Windows.Forms.Label();
			this.LblSource = new System.Windows.Forms.Label();
			this.TbFileDestination = new System.Windows.Forms.TextBox();
			this.TbFileSource = new System.Windows.Forms.TextBox();
			this.BtnSearchFiles = new System.Windows.Forms.Button();
			this.BtnCopyFiles = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RtbInfo2
			// 
			this.RtbInfo2.Location = new System.Drawing.Point(361, 16);
			this.RtbInfo2.Name = "RtbInfo2";
			this.RtbInfo2.ReadOnly = true;
			this.RtbInfo2.Size = new System.Drawing.Size(181, 88);
			this.RtbInfo2.TabIndex = 7;
			this.RtbInfo2.Text = "";
			// 
			// RtbInfo1
			// 
			this.RtbInfo1.Enabled = false;
			this.RtbInfo1.Location = new System.Drawing.Point(181, 16);
			this.RtbInfo1.Name = "RtbInfo1";
			this.RtbInfo1.ReadOnly = true;
			this.RtbInfo1.Size = new System.Drawing.Size(175, 88);
			this.RtbInfo1.TabIndex = 6;
			this.RtbInfo1.Text = "";
			// 
			// BtnMoveFiles
			// 
			this.BtnMoveFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnMoveFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMoveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnMoveFiles.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnMoveFiles.Location = new System.Drawing.Point(16, 63);
			this.BtnMoveFiles.Name = "BtnMoveFiles";
			this.BtnMoveFiles.Size = new System.Drawing.Size(122, 41);
			this.BtnMoveFiles.TabIndex = 8;
			this.BtnMoveFiles.Text = "Move Files";
			this.BtnMoveFiles.UseVisualStyleBackColor = true;
			this.BtnMoveFiles.Click += new System.EventHandler(this.BtnMoveFiles_Click);
			// 
			// BtnDeleteFiles
			// 
			this.BtnDeleteFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnDeleteFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDeleteFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnDeleteFiles.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnDeleteFiles.Location = new System.Drawing.Point(16, 110);
			this.BtnDeleteFiles.Name = "BtnDeleteFiles";
			this.BtnDeleteFiles.Size = new System.Drawing.Size(122, 41);
			this.BtnDeleteFiles.TabIndex = 9;
			this.BtnDeleteFiles.Text = "Delete Files";
			this.BtnDeleteFiles.UseVisualStyleBackColor = true;
			this.BtnDeleteFiles.Click += new System.EventHandler(this.BtnDeleteFiles_Click);
			// 
			// BtnCreateFiles
			// 
			this.BtnCreateFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnCreateFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCreateFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnCreateFiles.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnCreateFiles.Location = new System.Drawing.Point(16, 157);
			this.BtnCreateFiles.Name = "BtnCreateFiles";
			this.BtnCreateFiles.Size = new System.Drawing.Size(122, 41);
			this.BtnCreateFiles.TabIndex = 10;
			this.BtnCreateFiles.Text = "Create Files";
			this.BtnCreateFiles.UseVisualStyleBackColor = true;
			this.BtnCreateFiles.Click += new System.EventHandler(this.BtnCreateFiles_Click);
			// 
			// BtnRenameFiles
			// 
			this.BtnRenameFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnRenameFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRenameFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnRenameFiles.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnRenameFiles.Location = new System.Drawing.Point(16, 204);
			this.BtnRenameFiles.Name = "BtnRenameFiles";
			this.BtnRenameFiles.Size = new System.Drawing.Size(122, 41);
			this.BtnRenameFiles.TabIndex = 11;
			this.BtnRenameFiles.Text = "Rename File";
			this.BtnRenameFiles.UseVisualStyleBackColor = true;
			this.BtnRenameFiles.Click += new System.EventHandler(this.BtnRenameFiles_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnClear.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnClear.Location = new System.Drawing.Point(16, 362);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(122, 41);
			this.BtnClear.TabIndex = 12;
			this.BtnClear.Text = "Clear";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// LblDestination
			// 
			this.LblDestination.AutoSize = true;
			this.LblDestination.ForeColor = System.Drawing.Color.White;
			this.LblDestination.Location = new System.Drawing.Point(181, 190);
			this.LblDestination.Name = "LblDestination";
			this.LblDestination.Size = new System.Drawing.Size(104, 13);
			this.LblDestination.TabIndex = 28;
			this.LblDestination.Text = "File Destiantion Path";
			// 
			// LblSource
			// 
			this.LblSource.AutoSize = true;
			this.LblSource.ForeColor = System.Drawing.Color.White;
			this.LblSource.Location = new System.Drawing.Point(181, 138);
			this.LblSource.Name = "LblSource";
			this.LblSource.Size = new System.Drawing.Size(85, 13);
			this.LblSource.TabIndex = 27;
			this.LblSource.Text = "File Source Path";
			// 
			// TbFileDestination
			// 
			this.TbFileDestination.Enabled = false;
			this.TbFileDestination.Location = new System.Drawing.Point(181, 206);
			this.TbFileDestination.Name = "TbFileDestination";
			this.TbFileDestination.Size = new System.Drawing.Size(271, 20);
			this.TbFileDestination.TabIndex = 26;
			// 
			// TbFileSource
			// 
			this.TbFileSource.Enabled = false;
			this.TbFileSource.Location = new System.Drawing.Point(181, 157);
			this.TbFileSource.Name = "TbFileSource";
			this.TbFileSource.Size = new System.Drawing.Size(271, 20);
			this.TbFileSource.TabIndex = 25;
			// 
			// BtnSearchFiles
			// 
			this.BtnSearchFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnSearchFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSearchFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnSearchFiles.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnSearchFiles.Location = new System.Drawing.Point(290, 362);
			this.BtnSearchFiles.Name = "BtnSearchFiles";
			this.BtnSearchFiles.Size = new System.Drawing.Size(199, 41);
			this.BtnSearchFiles.TabIndex = 29;
			this.BtnSearchFiles.Text = "Search Files";
			this.BtnSearchFiles.UseVisualStyleBackColor = true;
			this.BtnSearchFiles.Click += new System.EventHandler(this.BtnSearchFiles_Click);
			// 
			// BtnCopyFiles
			// 
			this.BtnCopyFiles.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnCopyFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCopyFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BtnCopyFiles.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnCopyFiles.Location = new System.Drawing.Point(16, 16);
			this.BtnCopyFiles.Name = "BtnCopyFiles";
			this.BtnCopyFiles.Size = new System.Drawing.Size(122, 41);
			this.BtnCopyFiles.TabIndex = 30;
			this.BtnCopyFiles.Text = "CopyFiles";
			this.BtnCopyFiles.UseVisualStyleBackColor = true;
			this.BtnCopyFiles.Click += new System.EventHandler(this.BtnCopyFiles_Click);
			// 
			// TabFileSearcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.BtnCopyFiles);
			this.Controls.Add(this.BtnSearchFiles);
			this.Controls.Add(this.LblDestination);
			this.Controls.Add(this.LblSource);
			this.Controls.Add(this.TbFileDestination);
			this.Controls.Add(this.TbFileSource);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnRenameFiles);
			this.Controls.Add(this.BtnCreateFiles);
			this.Controls.Add(this.BtnDeleteFiles);
			this.Controls.Add(this.BtnMoveFiles);
			this.Controls.Add(this.RtbInfo2);
			this.Controls.Add(this.RtbInfo1);
			this.DoubleBuffered = true;
			this.Name = "TabFileSearcher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox RtbInfo2;
		private System.Windows.Forms.RichTextBox RtbInfo1;
		private System.Windows.Forms.Button BtnMoveFiles;
		private System.Windows.Forms.Button BtnDeleteFiles;
		private System.Windows.Forms.Button BtnCreateFiles;
		private System.Windows.Forms.Button BtnRenameFiles;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Label LblDestination;
		private System.Windows.Forms.Label LblSource;
		private System.Windows.Forms.TextBox TbFileDestination;
		private System.Windows.Forms.TextBox TbFileSource;
		private System.Windows.Forms.Button BtnSearchFiles;
		private System.Windows.Forms.Button BtnCopyFiles;
	}
}
