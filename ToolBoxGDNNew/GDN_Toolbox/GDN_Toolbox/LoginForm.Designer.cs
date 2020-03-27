namespace GDN_Toolbox
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
			this.ButtonUsername = new GDN_Toolbox.CustomControls.HintUsername();
			this.ButtonPassword = new GDN_Toolbox.CustomControls.HintPassword();
			this.PanelUsername = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.PanelPassword = new System.Windows.Forms.Panel();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PanelUsername.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.PanelPassword.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonUsername
			// 
			this.ButtonUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.ButtonUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ButtonUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonUsername.ForeColor = System.Drawing.Color.Gray;
			this.ButtonUsername.Hint = "Username";
			this.ButtonUsername.Location = new System.Drawing.Point(0, 6);
			this.ButtonUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonUsername.Name = "ButtonUsername";
			this.ButtonUsername.Size = new System.Drawing.Size(262, 47);
			this.ButtonUsername.TabIndex = 1;
			this.ButtonUsername.Text = "Username";
			this.ButtonUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ButtonPassword
			// 
			this.ButtonPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.ButtonPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ButtonPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonPassword.ForeColor = System.Drawing.Color.Gray;
			this.ButtonPassword.Hint = "Password";
			this.ButtonPassword.Location = new System.Drawing.Point(0, 6);
			this.ButtonPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonPassword.Name = "ButtonPassword";
			this.ButtonPassword.Size = new System.Drawing.Size(262, 47);
			this.ButtonPassword.TabIndex = 2;
			this.ButtonPassword.Text = "Password";
			this.ButtonPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PanelUsername
			// 
			this.PanelUsername.Controls.Add(this.splitContainer1);
			this.PanelUsername.Location = new System.Drawing.Point(0, 238);
			this.PanelUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PanelUsername.Name = "PanelUsername";
			this.PanelUsername.Size = new System.Drawing.Size(338, 53);
			this.PanelUsername.TabIndex = 3;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ButtonUsername);
			this.splitContainer1.Size = new System.Drawing.Size(338, 53);
			this.splitContainer1.SplitterDistance = 262;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 0;
			// 
			// PanelPassword
			// 
			this.PanelPassword.Controls.Add(this.splitContainer2);
			this.PanelPassword.Location = new System.Drawing.Point(0, 321);
			this.PanelPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PanelPassword.Name = "PanelPassword";
			this.PanelPassword.Size = new System.Drawing.Size(338, 53);
			this.PanelPassword.TabIndex = 4;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.ButtonPassword);
			this.splitContainer2.Size = new System.Drawing.Size(338, 53);
			this.splitContainer2.SplitterDistance = 262;
			this.splitContainer2.SplitterWidth = 3;
			this.splitContainer2.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(50, 118);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 13);
			this.textBox1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(204, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "label1";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(338, 609);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PanelPassword);
			this.Controls.Add(this.PanelUsername);
			this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.Name = "LoginForm";
			this.Text = "Form1";
			this.Controls.SetChildIndex(this.PanelUsername, 0);
			this.Controls.SetChildIndex(this.PanelPassword, 0);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.PanelUsername.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.PanelPassword.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private CustomControls.HintUsername ButtonUsername;
		private CustomControls.HintPassword ButtonPassword;
		private System.Windows.Forms.Panel PanelUsername;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel PanelPassword;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

