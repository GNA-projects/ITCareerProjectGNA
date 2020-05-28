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
			this.RtbUserInfo = new System.Windows.Forms.RichTextBox();
			this.LblWelcome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// RtbUserInfo
			// 
			this.RtbUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.RtbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.RtbUserInfo.ForeColor = System.Drawing.Color.White;
			this.RtbUserInfo.Location = new System.Drawing.Point(31, 111);
			this.RtbUserInfo.Name = "RtbUserInfo";
			this.RtbUserInfo.Size = new System.Drawing.Size(484, 295);
			this.RtbUserInfo.TabIndex = 6;
			this.RtbUserInfo.Text = "";
			// 
			// LblWelcome
			// 
			this.LblWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblWelcome.ForeColor = System.Drawing.Color.White;
			this.LblWelcome.Location = new System.Drawing.Point(28, 59);
			this.LblWelcome.Name = "LblWelcome";
			this.LblWelcome.Size = new System.Drawing.Size(487, 49);
			this.LblWelcome.TabIndex = 7;
			this.LblWelcome.Text = "Welcome";
			// 
			// TabHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.LblWelcome);
			this.Controls.Add(this.RtbUserInfo);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TabHome";
			this.Load += new System.EventHandler(this.TabHome_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox RtbUserInfo;
		private System.Windows.Forms.Label LblWelcome;
	}
}
