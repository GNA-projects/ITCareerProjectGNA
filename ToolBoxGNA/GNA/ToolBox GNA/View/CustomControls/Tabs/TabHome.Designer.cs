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
			this.BtnGetInfo = new System.Windows.Forms.Button();
			this.RtbUserInfo = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// BtnGetInfo
			// 
			this.BtnGetInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BtnGetInfo.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnGetInfo.Location = new System.Drawing.Point(32, 346);
			this.BtnGetInfo.Name = "BtnGetInfo";
			this.BtnGetInfo.Size = new System.Drawing.Size(484, 64);
			this.BtnGetInfo.TabIndex = 5;
			this.BtnGetInfo.Text = "Get info about me";
			this.BtnGetInfo.UseVisualStyleBackColor = true;
			// 
			// RtbUserInfo
			// 
			this.RtbUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.RtbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.RtbUserInfo.ForeColor = System.Drawing.Color.White;
			this.RtbUserInfo.Location = new System.Drawing.Point(32, 29);
			this.RtbUserInfo.Name = "RtbUserInfo";
			this.RtbUserInfo.Size = new System.Drawing.Size(484, 295);
			this.RtbUserInfo.TabIndex = 6;
			this.RtbUserInfo.Text = "";
			// 
			// TabHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RtbUserInfo);
			this.Controls.Add(this.BtnGetInfo);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TabHome";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnGetInfo;
		private System.Windows.Forms.RichTextBox RtbUserInfo;
	}
}
