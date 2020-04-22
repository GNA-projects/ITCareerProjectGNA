using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Drawing.Imaging;
using ConverterDemo.Services.WordToPDFConvertorService;
using ConverterDemo.Services;
using ConverterDemo.Services.GetFilePathService;
using ConverterDemo.Services.SetDestPathService;
using ConverterDemo.ControllerG.Convertor;

namespace ConverterDemo
{
    public partial class Form1 : Form
    {
        //Crating usefull variables


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Method gets File directory and type.
            
            if (radioButton1.Checked)
            {
                textBox1.Text = Convertor.GetFileInfo(true);
            }
            else
            {
                textBox1.Text = Convertor.GetFileInfo(false);
            }



        }
        private void Button2_Click(object sender, EventArgs e)
        {

            
            textBox2.Text = Convertor.SetDestFilePath();

            //Sends the directory to the Models

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //Converts Word doc to PDF
                Convertor.DocumentToPDFConvertAsync(textBox1.Text, textBox2.Text);

            }
            else if (radioButton2.Checked)
            {
                Convertor.ImageToPNGConvertAsync(textBox1.Text, textBox2.Text);

            }
            
        }

        
    }
}