namespace SupportClient
{
	partial class ClientForm
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
			this.ButtonSend = new System.Windows.Forms.Button();
			this.ButtonConnect = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ButtonSend
			// 
			this.ButtonSend.Location = new System.Drawing.Point(31, 176);
			this.ButtonSend.Name = "ButtonSend";
			this.ButtonSend.Size = new System.Drawing.Size(75, 23);
			this.ButtonSend.TabIndex = 5;
			this.ButtonSend.Text = "Send";
			this.ButtonSend.UseVisualStyleBackColor = true;
			this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
			// 
			// ButtonConnect
			// 
			this.ButtonConnect.Location = new System.Drawing.Point(169, 176);
			this.ButtonConnect.Name = "ButtonConnect";
			this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
			this.ButtonConnect.TabIndex = 4;
			this.ButtonConnect.Text = "Connect";
			this.ButtonConnect.UseVisualStyleBackColor = true;
			this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 44);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(259, 126);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(31, 220);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "Name";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(171, 220);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "IP";
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 261);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ButtonSend);
			this.Controls.Add(this.ButtonConnect);
			this.Name = "ClientForm";
			this.Text = "Form1";
			this.Controls.SetChildIndex(this.ButtonConnect, 0);
			this.Controls.SetChildIndex(this.ButtonSend, 0);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.Controls.SetChildIndex(this.textBox2, 0);
			this.Controls.SetChildIndex(this.textBox3, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonSend;
		private System.Windows.Forms.Button ButtonConnect;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}

