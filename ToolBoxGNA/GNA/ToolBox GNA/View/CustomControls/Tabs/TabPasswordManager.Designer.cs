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
            this.BtnGetPasswords.Location = new System.Drawing.Point(428, 433);
            this.BtnGetPasswords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGetPasswords.Name = "BtnGetPasswords";
            this.BtnGetPasswords.Size = new System.Drawing.Size(255, 79);
            this.BtnGetPasswords.TabIndex = 5;
            this.BtnGetPasswords.Text = "Get Passwords";
            this.BtnGetPasswords.UseVisualStyleBackColor = true;
            this.BtnGetPasswords.Click += new System.EventHandler(this.BtnGetPasswords_Click);
            // 
            // TbUsername
            // 
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbUsername.Location = new System.Drawing.Point(412, 74);
            this.TbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(287, 36);
            this.TbUsername.TabIndex = 6;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TbPassword.Location = new System.Drawing.Point(412, 166);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(287, 36);
            this.TbPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(408, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(408, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // LbUrls
            // 
            this.LbUrls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LbUrls.FormattingEnabled = true;
            this.LbUrls.ItemHeight = 20;
            this.LbUrls.Location = new System.Drawing.Point(19, 17);
            this.LbUrls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbUrls.Name = "LbUrls";
            this.LbUrls.Size = new System.Drawing.Size(353, 484);
            this.LbUrls.TabIndex = 10;
            this.LbUrls.SelectedIndexChanged += new System.EventHandler(this.LbUrls_SelectedIndexChanged);
            // 
            // TabPasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbUrls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.BtnGetPasswords);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
