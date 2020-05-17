namespace DesktopChangerDemo
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IsStreched = new System.Windows.Forms.RadioButton();
            this.IsTilted = new System.Windows.Forms.RadioButton();
            this.IsCentered = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(873, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Apply Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 533);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // IsStreched
            // 
            this.IsStreched.AutoSize = true;
            this.IsStreched.Checked = true;
            this.IsStreched.Location = new System.Drawing.Point(873, 135);
            this.IsStreched.Name = "IsStreched";
            this.IsStreched.Size = new System.Drawing.Size(90, 21);
            this.IsStreched.TabIndex = 3;
            this.IsStreched.TabStop = true;
            this.IsStreched.Text = "Stretched";
            this.IsStreched.UseVisualStyleBackColor = true;
            // 
            // IsTilted
            // 
            this.IsTilted.AutoSize = true;
            this.IsTilted.Location = new System.Drawing.Point(873, 220);
            this.IsTilted.Name = "IsTilted";
            this.IsTilted.Size = new System.Drawing.Size(60, 21);
            this.IsTilted.TabIndex = 4;
            this.IsTilted.Text = "Tiled";
            this.IsTilted.UseVisualStyleBackColor = true;
            // 
            // IsCentered
            // 
            this.IsCentered.AutoSize = true;
            this.IsCentered.Location = new System.Drawing.Point(873, 325);
            this.IsCentered.Name = "IsCentered";
            this.IsCentered.Size = new System.Drawing.Size(87, 21);
            this.IsCentered.TabIndex = 5;
            this.IsCentered.Text = "Centered";
            this.IsCentered.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 673);
            this.Controls.Add(this.IsCentered);
            this.Controls.Add(this.IsTilted);
            this.Controls.Add(this.IsStreched);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton IsStreched;
        private System.Windows.Forms.RadioButton IsTilted;
        private System.Windows.Forms.RadioButton IsCentered;
    }
}

