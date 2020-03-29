namespace GDN_Toolbox.CustomControls.Tabs
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
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// PictureBoxLogo
			// 
			this.PictureBoxLogo.BackgroundImage = global::GDN_Toolbox.Properties.Resources.GNA;
			this.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBoxLogo.Location = new System.Drawing.Point(0, 0);
			this.PictureBoxLogo.Name = "PictureBoxLogo";
			this.PictureBoxLogo.Size = new System.Drawing.Size(561, 435);
			this.PictureBoxLogo.TabIndex = 0;
			this.PictureBoxLogo.TabStop = false;
			// 
			// TabHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PictureBoxLogo);
			this.Name = "TabHome";
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PictureBoxLogo;
	}
}
