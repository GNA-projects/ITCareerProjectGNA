namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabHome
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
			this.RtbUserInfo = new System.Windows.Forms.RichTextBox();
			this.LblWelcome = new System.Windows.Forms.Label();
			this.BtnChangePassword = new System.Windows.Forms.Button();
			this.TbPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// RtbUserInfo
			// 
			this.RtbUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.RtbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RtbUserInfo.ForeColor = System.Drawing.Color.White;
			this.RtbUserInfo.Location = new System.Drawing.Point(31, 111);
			this.RtbUserInfo.Name = "RtbUserInfo";
			this.RtbUserInfo.Size = new System.Drawing.Size(484, 198);
			this.RtbUserInfo.TabIndex = 6;
			this.RtbUserInfo.Text = "";
			// 
			// LblWelcome
			// 
			this.LblWelcome.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LblWelcome.ForeColor = System.Drawing.Color.White;
			this.LblWelcome.Location = new System.Drawing.Point(28, 25);
			this.LblWelcome.Name = "LblWelcome";
			this.LblWelcome.Size = new System.Drawing.Size(487, 83);
			this.LblWelcome.TabIndex = 7;
			this.LblWelcome.Text = "Welcome";
			// 
			// BtnChangePassword
			// 
			this.BtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BtnChangePassword.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnChangePassword.Location = new System.Drawing.Point(32, 349);
			this.BtnChangePassword.Name = "BtnChangePassword";
			this.BtnChangePassword.Size = new System.Drawing.Size(199, 47);
			this.BtnChangePassword.TabIndex = 30;
			this.BtnChangePassword.Text = "Change Password";
			this.BtnChangePassword.UseVisualStyleBackColor = true;
			this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
			// 
			// TbPassword
			// 
			this.TbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.TbPassword.ForeColor = System.Drawing.Color.White;
			this.TbPassword.Location = new System.Drawing.Point(286, 355);
			this.TbPassword.MaxLength = 21;
			this.TbPassword.Multiline = true;
			this.TbPassword.Name = "TbPassword";
			this.TbPassword.Size = new System.Drawing.Size(248, 41);
			this.TbPassword.TabIndex = 31;
			this.TbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TabHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TbPassword);
			this.Controls.Add(this.BtnChangePassword);
			this.Controls.Add(this.LblWelcome);
			this.Controls.Add(this.RtbUserInfo);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TabHome";
			this.Load += new System.EventHandler(this.TabHome_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox RtbUserInfo;
		private System.Windows.Forms.Label LblWelcome;
		private System.Windows.Forms.Button BtnChangePassword;
		private System.Windows.Forms.TextBox TbPassword;
	}
}
