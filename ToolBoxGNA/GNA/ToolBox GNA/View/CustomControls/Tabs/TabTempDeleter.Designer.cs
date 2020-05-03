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
			this.SuspendLayout();
			// 
			// BtnCheckDel
			// 
			this.BtnCheckDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCheckDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BtnCheckDel.Location = new System.Drawing.Point(45, 329);
			this.BtnCheckDel.Name = "BtnCheckDel";
			this.BtnCheckDel.Size = new System.Drawing.Size(228, 69);
			this.BtnCheckDel.TabIndex = 0;
			this.BtnCheckDel.Text = "Check";
			this.BtnCheckDel.UseVisualStyleBackColor = true;
			// 
			// RtbInfo
			// 
			this.RtbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
			this.RtbInfo.Location = new System.Drawing.Point(326, 15);
			this.RtbInfo.Name = "RtbInfo";
			this.RtbInfo.Size = new System.Drawing.Size(218, 405);
			this.RtbInfo.TabIndex = 2;
			this.RtbInfo.Text = "";
			// 
			// LblExplain1
			// 
			this.LblExplain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LblExplain1.Location = new System.Drawing.Point(45, 15);
			this.LblExplain1.Name = "LblExplain1";
			this.LblExplain1.Size = new System.Drawing.Size(228, 169);
			this.LblExplain1.TabIndex = 3;
			this.LblExplain1.Text = resources.GetString("LblExplain1.Text");
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(45, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 132);
			this.label1.TabIndex = 4;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// TabTempDeleter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LblExplain1);
			this.Controls.Add(this.RtbInfo);
			this.Controls.Add(this.BtnCheckDel);
			this.Name = "TabTempDeleter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnCheckDel;
		private System.Windows.Forms.RichTextBox RtbInfo;
		private System.Windows.Forms.Label LblExplain1;
		private System.Windows.Forms.Label label1;
	}
}
