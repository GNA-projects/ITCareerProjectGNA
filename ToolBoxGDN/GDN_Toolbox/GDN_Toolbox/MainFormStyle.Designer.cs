namespace GDN_Toolbox
{
	partial class MainFormStyle
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
            this.PanelUpBorder = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PanelUpBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUpBorder
            // 
            this.PanelUpBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelUpBorder.Controls.Add(this.ButtonMinimize);
            this.PanelUpBorder.Controls.Add(this.ButtonExit);
            this.PanelUpBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpBorder.Location = new System.Drawing.Point(0, 0);
            this.PanelUpBorder.Margin = new System.Windows.Forms.Padding(2);
            this.PanelUpBorder.Name = "PanelUpBorder";
            this.PanelUpBorder.Size = new System.Drawing.Size(549, 28);
            this.PanelUpBorder.TabIndex = 0;
            this.PanelUpBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelUpBorder_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonMinimize.BackgroundImage = global::GDN_Toolbox.Properties.Resources.User_Interface_Minus_icon;
            this.ButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimize.Location = new System.Drawing.Point(492, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(28, 28);
            this.ButtonMinimize.TabIndex = 1;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonExit.BackgroundImage = global::GDN_Toolbox.Properties.Resources.x_512;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(520, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(29, 28);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainFormStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(549, 386);
            this.Controls.Add(this.PanelUpBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFormStyle";
            this.Text = "FormRegister";
            this.PanelUpBorder.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelUpBorder;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonMinimize;
	}
}