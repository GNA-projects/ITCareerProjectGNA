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
            if (TempDeleter.HasTempFiles())
            {
                button2.Visible = true;
            }
        }
        private async void Button2_Click(object sender, EventArgs e)
        {
            //ЗАДЪЛЖИТЕЛНО БУТОНА ЗА ТРИЕНЕ СЕ ИМПЛЕМЕНТИРА С ДИЛЕЯ И СЕ ЧАКАТ 2 СЕКУНДИ!!!
            TempDeleter.DeleteTempFilesAsync(Path.GetTempPath());
            
            await Task.Delay(1500);
            
            if (TempDeleter.HasErrors())
            {
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("Everything is deleted");
            }
            TempDeleter.ResetValues();
            
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            TempDeleter.GetErrorFilesNamesAsync();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

