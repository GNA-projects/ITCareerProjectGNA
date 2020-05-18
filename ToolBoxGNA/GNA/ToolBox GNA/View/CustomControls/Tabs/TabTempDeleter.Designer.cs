namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabTempDeleter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabTempDeleter));
            this.BtnCheckDel = new System.Windows.Forms.Button();
            this.RtbInfo = new System.Windows.Forms.RichTextBox();
            this.LblExplain1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCheckDel
            // 
            this.BtnCheckDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCheckDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnCheckDel.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCheckDel.Location = new System.Drawing.Point(20, 416);
            this.BtnCheckDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCheckDel.Name = "BtnCheckDel";
            this.BtnCheckDel.Size = new System.Drawing.Size(236, 85);
            this.BtnCheckDel.TabIndex = 0;
            this.BtnCheckDel.Text = "Check";
            this.BtnCheckDel.UseVisualStyleBackColor = true;
            this.BtnCheckDel.Click += new System.EventHandler(this.BtnCheckDel_Click);
            // 
            // RtbInfo
            // 
            this.RtbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.RtbInfo.Location = new System.Drawing.Point(435, 18);
            this.RtbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RtbInfo.Name = "RtbInfo";
            this.RtbInfo.Size = new System.Drawing.Size(289, 498);
            this.RtbInfo.TabIndex = 2;
            this.RtbInfo.Text = "";
            // 
            // LblExplain1
            // 
            this.LblExplain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblExplain1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblExplain1.Location = new System.Drawing.Point(60, 18);
            this.LblExplain1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExplain1.Name = "LblExplain1";
            this.LblExplain1.Size = new System.Drawing.Size(304, 208);
            this.LblExplain1.TabIndex = 3;
            this.LblExplain1.Text = resources.GetString("LblExplain1.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 162);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // BtnInfo
            // 
            this.BtnInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInfo.Location = new System.Drawing.Point(287, 416);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(123, 85);
            this.BtnInfo.TabIndex = 5;
            this.BtnInfo.Text = "Info";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // TabTempDeleter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblExplain1);
            this.Controls.Add(this.RtbInfo);
            this.Controls.Add(this.BtnCheckDel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TabTempDeleter";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnCheckDel;
		private System.Windows.Forms.RichTextBox RtbInfo;
		private System.Windows.Forms.Label LblExplain1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInfo;
    }
}
