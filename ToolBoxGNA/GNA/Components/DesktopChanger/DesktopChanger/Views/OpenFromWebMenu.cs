using DesktopChangerDemo.DesktopChanger.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo
{
    public partial class OpenFromWebMenu : Form
    {
        public OpenFromWebMenu()
        {
            InitializeComponent();
        }
        public static bool IsReady = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            DesktopChangerOpenFromWebMenuController.GetImageFromWeb(textBox1.Text);
            IsReady = true;
            this.Close();
        }
        
        
        public static string GetImageFromWebPath()
        {
            return DesktopChangerOpenFromWebMenuController.path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
