namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabWifiChecker
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
            this.RtbWifiInfo = new System.Windows.Forms.RichTextBox();
            this.BtnGetWifiInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RtbWifiInfo
            // 
            this.RtbWifiInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RtbWifiInfo.Location = new System.Drawing.Point(48, 54);
            this.RtbWifiInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RtbWifiInfo.Name = "RtbWifiInfo";
            this.RtbWifiInfo.Size = new System.Drawing.Size(644, 315);
            this.RtbWifiInfo.TabIndex = 0;
            this.RtbWifiInfo.Text = "";
            // 
            // BtnGetWifiInfo
            // 
            this.BtnGetWifiInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGetWifiInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetWifiInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnGetWifiInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGetWifiInfo.Location = new System.Drawing.Point(48, 420);
            this.BtnGetWifiInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGetWifiInfo.Name = "BtnGetWifiInfo";
            this.BtnGetWifiInfo.Size = new System.Drawing.Size(645, 79);
            this.BtnGetWifiInfo.TabIndex = 6;
            this.BtnGetWifiInfo.Text = "Get Wifi Info";
            this.BtnGetWifiInfo.UseVisualStyleBackColor = true;
            this.BtnGetWifiInfo.Click += new System.EventHandler(this.BtnGetWifiInfo_Click);
            // 
            // TabWifiChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnGetWifiInfo);
            this.Controls.Add(this.RtbWifiInfo);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TabWifiChecker";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox RtbWifiInfo;
		private System.Windows.Forms.Button BtnGetWifiInfo;
	}
}
