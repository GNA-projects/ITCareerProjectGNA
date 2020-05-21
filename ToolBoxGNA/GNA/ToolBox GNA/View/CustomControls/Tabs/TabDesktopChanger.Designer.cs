namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabDesktopChanger
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
			this.PbImagePreview = new System.Windows.Forms.PictureBox();
			this.RbStretched = new System.Windows.Forms.RadioButton();
			this.RbTiled = new System.Windows.Forms.RadioButton();
			this.RbCentered = new System.Windows.Forms.RadioButton();
			this.BtnOpen = new System.Windows.Forms.Button();
			this.BtnApply = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PbImagePreview)).BeginInit();
			this.SuspendLayout();
			// 
			// PbImagePreview
			// 
			this.PbImagePreview.Location = new System.Drawing.Point(29, 36);
			this.PbImagePreview.Name = "PbImagePreview";
			this.PbImagePreview.Size = new System.Drawing.Size(480, 270);
			this.PbImagePreview.TabIndex = 1;
			this.PbImagePreview.TabStop = false;
			// 
			// RbStretched
			// 
			this.RbStretched.AutoSize = true;
			this.RbStretched.Checked = true;
			this.RbStretched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.RbStretched.ForeColor = System.Drawing.Color.White;
			this.RbStretched.Location = new System.Drawing.Point(437, 334);
			this.RbStretched.Name = "RbStretched";
			this.RbStretched.Size = new System.Drawing.Size(87, 21);
			this.RbStretched.TabIndex = 2;
			this.RbStretched.TabStop = true;
			this.RbStretched.Text = "Stretched";
			this.RbStretched.UseVisualStyleBackColor = true;
			// 
			// RbTiled
			// 
			this.RbTiled.AutoSize = true;
			this.RbTiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.RbTiled.ForeColor = System.Drawing.Color.White;
			this.RbTiled.Location = new System.Drawing.Point(437, 361);
			this.RbTiled.Name = "RbTiled";
			this.RbTiled.Size = new System.Drawing.Size(57, 21);
			this.RbTiled.TabIndex = 3;
			this.RbTiled.Text = "Tiled";
			this.RbTiled.UseVisualStyleBackColor = true;
			// 
			// RbCentered
			// 
			this.RbCentered.AutoSize = true;
			this.RbCentered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.RbCentered.ForeColor = System.Drawing.Color.White;
			this.RbCentered.Location = new System.Drawing.Point(437, 388);
			this.RbCentered.Name = "RbCentered";
			this.RbCentered.Size = new System.Drawing.Size(84, 21);
			this.RbCentered.TabIndex = 4;
			this.RbCentered.Text = "Centered";
			this.RbCentered.UseVisualStyleBackColor = true;
			// 
			// BtnOpen
			// 
			this.BtnOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BtnOpen.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnOpen.Location = new System.Drawing.Point(29, 345);
			this.BtnOpen.Name = "BtnOpen";
			this.BtnOpen.Size = new System.Drawing.Size(179, 50);
			this.BtnOpen.TabIndex = 6;
			this.BtnOpen.Text = "Open Image";
			this.BtnOpen.UseVisualStyleBackColor = true;
			this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// BtnApply
			// 
			this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BtnApply.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnApply.Location = new System.Drawing.Point(214, 345);
			this.BtnApply.Name = "BtnApply";
			this.BtnApply.Size = new System.Drawing.Size(179, 50);
			this.BtnApply.TabIndex = 7;
			this.BtnApply.Text = "Apply Image";
			this.BtnApply.UseVisualStyleBackColor = true;
			this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
			// 
			// TabDesktopChanger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.BtnApply);
			this.Controls.Add(this.BtnOpen);
			this.Controls.Add(this.RbCentered);
			this.Controls.Add(this.RbTiled);
			this.Controls.Add(this.RbStretched);
			this.Controls.Add(this.PbImagePreview);
			this.Name = "TabDesktopChanger";
			((System.ComponentModel.ISupportInitialize)(this.PbImagePreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox PbImagePreview;
		private System.Windows.Forms.RadioButton RbStretched;
		private System.Windows.Forms.RadioButton RbTiled;
		private System.Windows.Forms.RadioButton RbCentered;
		private System.Windows.Forms.Button BtnOpen;
		private System.Windows.Forms.Button BtnApply;
	}
}
