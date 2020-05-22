using DesktopChangerDemo.DesktopChanger.Controllers;
using DesktopChangerDemo.Services.OpenImageService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo
{
    public partial class SelectMenu : Form
    {

        public SelectMenu()
        {
            InitializeComponent();
        }
        public bool IsLocal = false;
        public static bool IsFromWeb = false;
        public string path;
        public static int count = 0;
        OpenImageService service = new OpenImageService();
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog OBrwsDialog = new OpenFileDialog();
            DesktopChangerSelectMenuController.OpenLocalImage(OBrwsDialog, service);
            path = DesktopChangerSelectMenuController.ReturnPath();
            IsLocal = true;
            this.Close();
        }



        public string GetImageLocalPath()
        {
            return path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFromWebMenu form3 = new OpenFromWebMenu();
            DesktopChangerSelectMenuController.OpenWebImage(form3, service);
            IsLocal = false;
            this.Close();
            
        }


        public string GetPathFromWeb()
        {
            IsFromWeb = true;
            return OpenFromWebMenu.GetImageFromWebPath();
        }

        private void SelectMenu_Load(object sender, EventArgs e)
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
