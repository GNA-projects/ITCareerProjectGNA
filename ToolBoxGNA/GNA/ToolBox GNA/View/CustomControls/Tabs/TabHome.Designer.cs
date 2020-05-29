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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RtbUserInfo
            // 
            this.RtbUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.RtbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbUserInfo.ForeColor = System.Drawing.Color.White;
            this.RtbUserInfo.Location = new System.Drawing.Point(41, 137);
            this.RtbUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RtbUserInfo.Name = "RtbUserInfo";
            this.RtbUserInfo.Size = new System.Drawing.Size(644, 243);
            this.RtbUserInfo.TabIndex = 6;
            this.RtbUserInfo.Text = "";
            // 
            // LblWelcome
            // 
            this.LblWelcome.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWelcome.ForeColor = System.Drawing.Color.White;
            this.LblWelcome.Location = new System.Drawing.Point(37, 31);
            this.LblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(649, 102);
            this.LblWelcome.TabIndex = 7;
            this.LblWelcome.Text = "Welcome";
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChangePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnChangePassword.Location = new System.Drawing.Point(43, 430);
            this.BtnChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(265, 58);
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
            this.TbPassword.Location = new System.Drawing.Point(381, 437);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbPassword.MaxLength = 21;
            this.TbPassword.Multiline = true;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(329, 50);
            this.TbPassword.TabIndex = 31;
            this.TbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(400, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "New password:";
            // 
            // TabHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.RtbUserInfo);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
		private System.Windows.Forms.Label label1;
	}
}
