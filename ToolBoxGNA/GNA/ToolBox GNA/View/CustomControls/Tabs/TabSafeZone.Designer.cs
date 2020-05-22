namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabSafeZone
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
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.TbDecryptedFile = new System.Windows.Forms.TextBox();
            this.TbEncryptedFile = new System.Windows.Forms.TextBox();
            this.LblPathEn = new System.Windows.Forms.Label();
            this.LblPathDe = new System.Windows.Forms.Label();
            this.RtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnEncrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEncrypt.Location = new System.Drawing.Point(45, 432);
            this.BtnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(263, 66);
            this.BtnEncrypt.TabIndex = 1;
            this.BtnEncrypt.Text = "Encrypt";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnDecrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDecrypt.Location = new System.Drawing.Point(420, 432);
            this.BtnDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(263, 66);
            this.BtnDecrypt.TabIndex = 2;
            this.BtnDecrypt.Text = "Decrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // TbDecryptedFile
            // 
            this.TbDecryptedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TbDecryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbDecryptedFile.ForeColor = System.Drawing.Color.White;
            this.TbDecryptedFile.Location = new System.Drawing.Point(395, 167);
            this.TbDecryptedFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbDecryptedFile.Name = "TbDecryptedFile";
            this.TbDecryptedFile.ReadOnly = true;
            this.TbDecryptedFile.Size = new System.Drawing.Size(287, 36);
            this.TbDecryptedFile.TabIndex = 9;
            // 
            // TbEncryptedFile
            // 
            this.TbEncryptedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TbEncryptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbEncryptedFile.ForeColor = System.Drawing.Color.White;
            this.TbEncryptedFile.Location = new System.Drawing.Point(395, 75);
            this.TbEncryptedFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbEncryptedFile.Name = "TbEncryptedFile";
            this.TbEncryptedFile.ReadOnly = true;
            this.TbEncryptedFile.Size = new System.Drawing.Size(287, 36);
            this.TbEncryptedFile.TabIndex = 8;
            // 
            // LblPathEn
            // 
            this.LblPathEn.AutoSize = true;
            this.LblPathEn.ForeColor = System.Drawing.Color.White;
            this.LblPathEn.Location = new System.Drawing.Point(391, 55);
            this.LblPathEn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPathEn.Name = "LblPathEn";
            this.LblPathEn.Size = new System.Drawing.Size(212, 17);
            this.LblPathEn.TabIndex = 14;
            this.LblPathEn.Text = "File Source Path For Encryption:";
            // 
            // LblPathDe
            // 
            this.LblPathDe.AutoSize = true;
            this.LblPathDe.ForeColor = System.Drawing.Color.White;
            this.LblPathDe.Location = new System.Drawing.Point(391, 148);
            this.LblPathDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPathDe.Name = "LblPathDe";
            this.LblPathDe.Size = new System.Drawing.Size(213, 17);
            this.LblPathDe.TabIndex = 15;
            this.LblPathDe.Text = "File Source Path For Decryption:";
            // 
            // RtbInfo
            // 
            this.RtbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.RtbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.RtbInfo.Location = new System.Drawing.Point(45, 55);
            this.RtbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RtbInfo.Name = "RtbInfo";
            this.RtbInfo.Size = new System.Drawing.Size(261, 286);
            this.RtbInfo.TabIndex = 16;
            this.RtbInfo.Text = "";
            // 
            // TabSafeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RtbInfo);
            this.Controls.Add(this.LblPathDe);
            this.Controls.Add(this.LblPathEn);
            this.Controls.Add(this.TbDecryptedFile);
            this.Controls.Add(this.TbEncryptedFile);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.BtnEncrypt);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TabSafeZone";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnEncrypt;
		private System.Windows.Forms.Button BtnDecrypt;
		private System.Windows.Forms.TextBox TbDecryptedFile;
		private System.Windows.Forms.TextBox TbEncryptedFile;
		private System.Windows.Forms.Label LblPathEn;
		private System.Windows.Forms.Label LblPathDe;
		private System.Windows.Forms.RichTextBox RtbInfo;
	}
}
