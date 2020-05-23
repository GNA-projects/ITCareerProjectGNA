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
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.HelloLabel1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(748, 535);
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // HelloLabel1
            // 
            this.HelloLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.HelloLabel1.Location = new System.Drawing.Point(68, 36);
            this.HelloLabel1.Name = "HelloLabel1";
            this.HelloLabel1.Size = new System.Drawing.Size(158, 33);
            this.HelloLabel1.TabIndex = 1;
            this.HelloLabel1.Text = "Welcome,";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameLabel.Location = new System.Drawing.Point(213, 36);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 32);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "000";
            // 
            // TabHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.HelloLabel1);
            this.Controls.Add(this.PictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TabHome";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PictureBoxLogo;
		private System.Windows.Forms.Label HelloLabel1;
        private System.Windows.Forms.Label usernameLabel;
    }
}
