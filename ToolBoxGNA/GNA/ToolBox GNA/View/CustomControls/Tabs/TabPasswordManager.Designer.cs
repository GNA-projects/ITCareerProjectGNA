namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabPasswordManager
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
			this.BtnGetPasswords = new System.Windows.Forms.Button();
			this.TbUsername = new System.Windows.Forms.TextBox();
			this.TbPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LbUrls = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// BtnGetPasswords
			// 
			this.BtnGetPasswords.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnGetPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGetPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BtnGetPasswords.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnGetPasswords.Location = new System.Drawing.Point(334, 338);
			this.BtnGetPasswords.Name = "BtnGetPasswords";
			this.BtnGetPasswords.Size = new System.Drawing.Size(191, 64);
			this.BtnGetPasswords.TabIndex = 5;
			this.BtnGetPasswords.Text = "Get Passwords";
			this.BtnGetPasswords.UseVisualStyleBackColor = true;
			this.BtnGetPasswords.Click += new System.EventHandler(this.BtnGetPasswords_Click);
			// 
			// TbUsername
			// 
			this.TbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.TbUsername.ForeColor = System.Drawing.Color.White;
			this.TbUsername.Location = new System.Drawing.Point(309, 60);
			this.TbUsername.Name = "TbUsername";
			this.TbUsername.ReadOnly = true;
			this.TbUsername.Size = new System.Drawing.Size(216, 30);
			this.TbUsername.TabIndex = 6;
			// 
			// TbPassword
			// 
			this.TbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.TbPassword.ForeColor = System.Drawing.Color.White;
			this.TbPassword.Location = new System.Drawing.Point(309, 135);
			this.TbPassword.Name = "TbPassword";
			this.TbPassword.ReadOnly = true;
			this.TbPassword.Size = new System.Drawing.Size(216, 30);
			this.TbPassword.TabIndex = 7;
			// 
			// usernameLabel
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(306, 44);
			this.label1.Name = "usernameLabel";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(306, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Password";
			// 
			// LbUrls
			// 
			this.LbUrls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.LbUrls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LbUrls.ForeColor = System.Drawing.Color.White;
			this.LbUrls.FormattingEnabled = true;
			this.LbUrls.ItemHeight = 16;
			this.LbUrls.Location = new System.Drawing.Point(14, 14);
			this.LbUrls.Name = "LbUrls";
			this.LbUrls.Size = new System.Drawing.Size(266, 388);
			this.LbUrls.TabIndex = 10;
			this.LbUrls.SelectedIndexChanged += new System.EventHandler(this.LbUrls_SelectedIndexChanged);
			// 
			// TabPasswordManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.LbUrls);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TbPassword);
			this.Controls.Add(this.TbUsername);
			this.Controls.Add(this.BtnGetPasswords);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "TabPasswordManager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnGetPasswords;
		private System.Windows.Forms.TextBox TbUsername;
		private System.Windows.Forms.TextBox TbPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox LbUrls;
	}
}
