namespace GDN_Toolbox
{
	partial class FormLogin
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
			this.ButtonLogin = new System.Windows.Forms.Button();
			this.ButtonRegister = new System.Windows.Forms.Button();
			this.PanelDown = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.ButtonRevealPassword = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.LabelName = new System.Windows.Forms.Label();
			this.PanelDown.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonLogin
			// 
			this.ButtonLogin.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonLogin.FlatAppearance.BorderSize = 0;
			this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonLogin.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonLogin.Location = new System.Drawing.Point(0, 0);
			this.ButtonLogin.Name = "ButtonLogin";
			this.ButtonLogin.Size = new System.Drawing.Size(529, 116);
			this.ButtonLogin.TabIndex = 3;
			this.ButtonLogin.Text = "Login";
			this.ButtonLogin.UseVisualStyleBackColor = false;
			// 
			// ButtonRegister
			// 
			this.ButtonRegister.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ButtonRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonRegister.FlatAppearance.BorderSize = 0;
			this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonRegister.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonRegister.Location = new System.Drawing.Point(0, 116);
			this.ButtonRegister.Name = "ButtonRegister";
			this.ButtonRegister.Size = new System.Drawing.Size(529, 33);
			this.ButtonRegister.TabIndex = 4;
			this.ButtonRegister.Text = "Register";
			this.ButtonRegister.UseVisualStyleBackColor = false;
			// 
			// PanelDown
			// 
			this.PanelDown.Controls.Add(this.ButtonLogin);
			this.PanelDown.Controls.Add(this.ButtonRegister);
			this.PanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PanelDown.Location = new System.Drawing.Point(0, 361);
			this.PanelDown.Name = "PanelDown";
			this.PanelDown.Size = new System.Drawing.Size(529, 149);
			this.PanelDown.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 178);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(529, 183);
			this.panel1.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.textBoxPassword);
			this.panel5.Controls.Add(this.ButtonRevealPassword);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 55);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(529, 54);
			this.panel5.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPassword.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
			this.textBoxPassword.Location = new System.Drawing.Point(0, 0);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(454, 49);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Text = "Password";
			this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxPassword.Click += new System.EventHandler(this.TextBoxPassword_Click);
			// 
			// ButtonRevealPassword
			// 
			this.ButtonRevealPassword.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonRevealPassword.FlatAppearance.BorderSize = 0;
			this.ButtonRevealPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonRevealPassword.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonRevealPassword.Location = new System.Drawing.Point(454, 0);
			this.ButtonRevealPassword.Name = "ButtonRevealPassword";
			this.ButtonRevealPassword.Size = new System.Drawing.Size(75, 54);
			this.ButtonRevealPassword.TabIndex = 2;
			this.ButtonRevealPassword.Text = "Reveal / Hide";
			this.ButtonRevealPassword.UseVisualStyleBackColor = true;
			this.ButtonRevealPassword.Click += new System.EventHandler(this.ButtonRevealPassword_Click);
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 109);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(529, 74);
			this.panel4.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textBoxUsername);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(529, 55);
			this.panel3.TabIndex = 0;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxUsername.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
			this.textBoxUsername.Location = new System.Drawing.Point(0, 0);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(529, 49);
			this.textBoxUsername.TabIndex = 0;
			this.textBoxUsername.Text = "Username";
			this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxUsername.Click += new System.EventHandler(this.TextBoxUsername_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.LabelName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(529, 144);
			this.panel2.TabIndex = 3;
			// 
			// LabelName
			// 
			this.LabelName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelName.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelName.Location = new System.Drawing.Point(0, 0);
			this.LabelName.Name = "LabelName";
			this.LabelName.Size = new System.Drawing.Size(529, 144);
			this.LabelName.TabIndex = 2;
			this.LabelName.Text = "GDN";
			this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(529, 510);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.PanelDown);
			this.Name = "FormLogin";
			this.Text = "Login";
			this.Controls.SetChildIndex(this.PanelDown, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.PanelDown.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button ButtonLogin;
		private System.Windows.Forms.Button ButtonRegister;
		private System.Windows.Forms.Panel PanelDown;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label LabelName;
		private System.Windows.Forms.Button ButtonRevealPassword;
	}
}

