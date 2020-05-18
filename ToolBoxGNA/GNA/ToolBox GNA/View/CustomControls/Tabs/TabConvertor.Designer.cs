namespace ToolBox_GNA.View.CustomControls.Tabs
{
	partial class TabConvertor
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
            this.TbInput = new System.Windows.Forms.TextBox();
            this.TbOutput = new System.Windows.Forms.TextBox();
            this.BtnBrowseIn = new System.Windows.Forms.Button();
            this.BtnBrowseOut = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.RbToPng = new System.Windows.Forms.RadioButton();
            this.RbWordToPdf = new System.Windows.Forms.RadioButton();
            this.LblSource = new System.Windows.Forms.Label();
            this.LblTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbInput
            // 
            this.TbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbInput.Location = new System.Drawing.Point(34, 52);
            this.TbInput.Name = "TbInput";
            this.TbInput.Size = new System.Drawing.Size(380, 31);
            this.TbInput.TabIndex = 0;
            // 
            // TbOutput
            // 
            this.TbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.TbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbOutput.Location = new System.Drawing.Point(34, 119);
            this.TbOutput.Name = "TbOutput";
            this.TbOutput.Size = new System.Drawing.Size(380, 31);
            this.TbOutput.TabIndex = 1;
            // 
            // BtnBrowseIn
            // 
            this.BtnBrowseIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBrowseIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseIn.Location = new System.Drawing.Point(430, 52);
            this.BtnBrowseIn.Name = "BtnBrowseIn";
            this.BtnBrowseIn.Size = new System.Drawing.Size(80, 30);
            this.BtnBrowseIn.TabIndex = 2;
            this.BtnBrowseIn.Text = "Browse";
            this.BtnBrowseIn.UseVisualStyleBackColor = true;
            this.BtnBrowseIn.Click += new System.EventHandler(this.BtnBrowseIn_Click);
            // 
            // BtnBrowseOut
            // 
            this.BtnBrowseOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBrowseOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseOut.Location = new System.Drawing.Point(430, 120);
            this.BtnBrowseOut.Name = "BtnBrowseOut";
            this.BtnBrowseOut.Size = new System.Drawing.Size(80, 30);
            this.BtnBrowseOut.TabIndex = 3;
            this.BtnBrowseOut.Text = "Browse";
            this.BtnBrowseOut.UseVisualStyleBackColor = true;
            this.BtnBrowseOut.Click += new System.EventHandler(this.BtnBrowseOut_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnConvert.Location = new System.Drawing.Point(319, 324);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(191, 64);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // RbToPng
            // 
            this.RbToPng.AutoSize = true;
            this.RbToPng.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbToPng.Location = new System.Drawing.Point(34, 359);
            this.RbToPng.Name = "RbToPng";
            this.RbToPng.Size = new System.Drawing.Size(190, 29);
            this.RbToPng.TabIndex = 6;
            this.RbToPng.TabStop = true;
            this.RbToPng.Text = ".jpg/.bmp to .png";
            this.RbToPng.UseVisualStyleBackColor = true;
            // 
            // RbWordToPdf
            // 
            this.RbWordToPdf.AutoSize = true;
            this.RbWordToPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbWordToPdf.Location = new System.Drawing.Point(34, 324);
            this.RbWordToPdf.Name = "RbWordToPdf";
            this.RbWordToPdf.Size = new System.Drawing.Size(147, 29);
            this.RbWordToPdf.TabIndex = 8;
            this.RbWordToPdf.TabStop = true;
            this.RbWordToPdf.Text = "Word to .pdf";
            this.RbWordToPdf.UseVisualStyleBackColor = true;
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(31, 36);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(66, 13);
            this.LblSource.TabIndex = 9;
            this.LblSource.Text = "Source Path";
            // 
            // LblTarget
            // 
            this.LblTarget.AutoSize = true;
            this.LblTarget.Location = new System.Drawing.Point(31, 103);
            this.LblTarget.Name = "LblTarget";
            this.LblTarget.Size = new System.Drawing.Size(63, 13);
            this.LblTarget.TabIndex = 10;
            this.LblTarget.Text = "Target Path";
            // 
            // TabConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblTarget);
            this.Controls.Add(this.LblSource);
            this.Controls.Add(this.RbWordToPdf);
            this.Controls.Add(this.RbToPng);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.BtnBrowseOut);
            this.Controls.Add(this.BtnBrowseIn);
            this.Controls.Add(this.TbOutput);
            this.Controls.Add(this.TbInput);
            this.Name = "TabConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TbInput;
		private System.Windows.Forms.TextBox TbOutput;
		private System.Windows.Forms.Button BtnBrowseIn;
		private System.Windows.Forms.Button BtnBrowseOut;
		private System.Windows.Forms.Button BtnConvert;
		private System.Windows.Forms.RadioButton RbToPng;
		private System.Windows.Forms.RadioButton RbWordToPdf;
		private System.Windows.Forms.Label LblSource;
		private System.Windows.Forms.Label LblTarget;
	}
}
