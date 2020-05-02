using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TempDeleter.TempDeleter;

namespace TempDeleter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TempDeleterController.HasTempFiles())
            {
                button2.Visible = true;
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            TempDeleterController.ResetValues();
            TempDeleterController.DeleteTempFilesAsync(Path.GetTempPath());
            button3.Visible = true;

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            TempDeleterController.GetNames();
        }
    }
}

