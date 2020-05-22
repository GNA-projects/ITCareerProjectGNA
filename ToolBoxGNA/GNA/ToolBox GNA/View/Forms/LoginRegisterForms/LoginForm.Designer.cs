namespace ToolBox_GNA.View.Forms.LoginRegisterForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TextBoxPassword = new ToolBox_GNA.View.CustomControls.TextBoxes.HintPassword();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new ToolBox_GNA.View.CustomControls.TextBoxes.HintUsername();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.PictureAvatar = new System.Windows.Forms.PictureBox();
            this.PanelAvatar = new System.Windows.Forms.Panel();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.PanelRegister = new System.Windows.Forms.Panel();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.PanelUsername.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).BeginInit();
            this.PanelAvatar.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.PanelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxPassword.Hint = "Password";
            this.TextBoxPassword.Location = new System.Drawing.Point(0, 8);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(440, 57);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.Text = "Password";
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelUsername
            // 
            this.PanelUsername.Controls.Add(this.TextBoxUsername);
            this.PanelUsername.Location = new System.Drawing.Point(0, 191);
            this.PanelUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(440, 65);
            this.PanelUsername.TabIndex = 3;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUsername.Hint = "Username";
            this.TextBoxUsername.Location = new System.Drawing.Point(0, 8);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(440, 57);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.Text = "Username";
            this.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(0, 261);
            this.PanelPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(440, 65);
            this.PanelPassword.TabIndex = 4;
            // 
            // PictureAvatar
            // 
            this.PictureAvatar.BackgroundImage = global::ToolBox_GNA.Properties.Resources.Avatar;
            this.PictureAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureAvatar.Location = new System.Drawing.Point(0, 0);
            this.PictureAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureAvatar.Name = "PictureAvatar";
            this.PictureAvatar.Size = new System.Drawing.Size(440, 123);
            this.PictureAvatar.TabIndex = 5;
            this.PictureAvatar.TabStop = false;
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.Controls.Add(this.PictureAvatar);
            this.PanelAvatar.Location = new System.Drawing.Point(0, 41);
            this.PanelAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(440, 123);
            this.PanelAvatar.TabIndex = 6;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.Gray;
            this.ButtonLogin.Location = new System.Drawing.Point(0, 3);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(440, 94);
            this.ButtonLogin.TabIndex = 8;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelLogin.Location = new System.Drawing.Point(0, 398);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(440, 97);
            this.PanelLogin.TabIndex = 9;
            // 
            // PanelRegister
            // 
            this.PanelRegister.Controls.Add(this.ButtonRegister);
            this.PanelRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelRegister.Location = new System.Drawing.Point(0, 495);
            this.PanelRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelRegister.Name = "PanelRegister";
            this.PanelRegister.Size = new System.Drawing.Size(440, 47);
            this.PanelRegister.TabIndex = 10;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ButtonRegister.ForeColor = System.Drawing.Color.Gray;
            this.ButtonRegister.Location = new System.Drawing.Point(0, 0);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(440, 47);
            this.ButtonRegister.TabIndex = 0;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(440, 542);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PanelAvatar);
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.PanelUsername);
            this.Controls.Add(this.PanelRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.PanelRegister, 0);
            this.Controls.SetChildIndex(this.PanelUsername, 0);
            this.Controls.SetChildIndex(this.PanelPassword, 0);
            this.Controls.SetChildIndex(this.PanelAvatar, 0);
            this.Controls.SetChildIndex(this.PanelLogin, 0);
            this.PanelUsername.ResumeLayout(false);
            this.PanelUsername.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).EndInit();
            this.PanelAvatar.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelRegister.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion
		private CustomControls.TextBoxes.HintPassword TextBoxPassword;
		private System.Windows.Forms.Panel PanelUsername;
		private System.Windows.Forms.Panel PanelPassword;
		private System.Windows.Forms.PictureBox PictureAvatar;
        private System.Windows.Forms.Panel PanelAvatar;
        private CustomControls.TextBoxes.HintUsername TextBoxUsername;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Panel PanelRegister;
        private System.Windows.Forms.Button ButtonRegister;
    }
}

