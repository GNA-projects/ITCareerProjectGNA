namespace ToolBox_GNA.View.Forms.LoginRegisterForms
{
	partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.PanelAvatar = new System.Windows.Forms.Panel();
            this.PictureAvatar = new System.Windows.Forms.PictureBox();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new ToolBox_GNA.View.CustomControls.TextBoxes.HintPassword();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new ToolBox_GNA.View.CustomControls.TextBoxes.HintUsername();
            this.PanelRegister = new System.Windows.Forms.Panel();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.PanelMessage = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PanelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).BeginInit();
            this.PanelPassword.SuspendLayout();
            this.PanelUsername.SuspendLayout();
            this.PanelRegister.SuspendLayout();
            this.PanelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAvatar
            // 
            this.PanelAvatar.Controls.Add(this.PictureAvatar);
            this.PanelAvatar.Location = new System.Drawing.Point(0, 33);
            this.PanelAvatar.Name = "PanelAvatar";
            this.PanelAvatar.Size = new System.Drawing.Size(330, 100);
            this.PanelAvatar.TabIndex = 7;
            // 
            // PictureAvatar
            // 
            this.PictureAvatar.BackgroundImage = global::ToolBox_GNA.Properties.Resources.Avatar;
            this.PictureAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureAvatar.Location = new System.Drawing.Point(0, 0);
            this.PictureAvatar.Name = "PictureAvatar";
            this.PictureAvatar.Size = new System.Drawing.Size(330, 100);
            this.PictureAvatar.TabIndex = 5;
            this.PictureAvatar.TabStop = false;
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(0, 313);
            this.PanelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(330, 53);
            this.PanelPassword.TabIndex = 9;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxPassword.Hint = "Password";
            this.TextBoxPassword.Location = new System.Drawing.Point(0, 7);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(330, 46);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.Text = "Password";
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelUsername
            // 
            this.PanelUsername.Controls.Add(this.TextBoxUsername);
            this.PanelUsername.Location = new System.Drawing.Point(0, 256);
            this.PanelUsername.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(330, 53);
            this.PanelUsername.TabIndex = 8;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TextBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUsername.Hint = "Username";
            this.TextBoxUsername.Location = new System.Drawing.Point(0, 7);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(330, 46);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.Text = "Username";
            this.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelRegister
            // 
            this.PanelRegister.Controls.Add(this.ButtonRegister);
            this.PanelRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelRegister.Location = new System.Drawing.Point(0, 429);
            this.PanelRegister.Name = "PanelRegister";
            this.PanelRegister.Size = new System.Drawing.Size(330, 84);
            this.PanelRegister.TabIndex = 10;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.ButtonRegister.ForeColor = System.Drawing.Color.Gray;
            this.ButtonRegister.Location = new System.Drawing.Point(0, 0);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(330, 84);
            this.ButtonRegister.TabIndex = 8;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // PanelMessage
            // 
            this.PanelMessage.Controls.Add(this.LabelMessage);
            this.PanelMessage.Location = new System.Drawing.Point(0, 139);
            this.PanelMessage.Name = "PanelMessage";
            this.PanelMessage.Size = new System.Drawing.Size(330, 74);
            this.PanelMessage.TabIndex = 11;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LabelMessage.ForeColor = System.Drawing.Color.White;
            this.LabelMessage.Location = new System.Drawing.Point(0, 0);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(330, 74);
            this.LabelMessage.TabIndex = 0;
            this.LabelMessage.Text = "Register yourself...";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 513);
            this.Controls.Add(this.PanelMessage);
            this.Controls.Add(this.PanelRegister);
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.PanelUsername);
            this.Controls.Add(this.PanelAvatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.PanelAvatar, 0);
            this.Controls.SetChildIndex(this.PanelUsername, 0);
            this.Controls.SetChildIndex(this.PanelPassword, 0);
            this.Controls.SetChildIndex(this.PanelRegister, 0);
            this.Controls.SetChildIndex(this.PanelMessage, 0);
            this.PanelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureAvatar)).EndInit();
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.PanelUsername.ResumeLayout(false);
            this.PanelUsername.PerformLayout();
            this.PanelRegister.ResumeLayout(false);
            this.PanelMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAvatar;
        private System.Windows.Forms.PictureBox PictureAvatar;
        private System.Windows.Forms.Panel PanelPassword;
        private CustomControls.TextBoxes.HintPassword TextBoxPassword;
        private System.Windows.Forms.Panel PanelUsername;
        private CustomControls.TextBoxes.HintUsername TextBoxUsername;
        private System.Windows.Forms.Panel PanelRegister;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Panel PanelMessage;
        private System.Windows.Forms.Label LabelMessage;
	}
}