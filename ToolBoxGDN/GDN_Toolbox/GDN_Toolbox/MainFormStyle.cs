using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace GDN_Toolbox
{
	public partial class MainFormStyle : Form
	{
		public MainFormStyle()
		{
			InitializeComponent();
		}


		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		private void ButtonMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void PanelUpBorder_MouseMove(object sender, MouseEventArgs e)
		{
			int mousePosX = MousePosition.X - PanelUpBorder.Width/2;
			int mousePosY = MousePosition.Y - PanelUpBorder.Height/5;

			if (e.Button == MouseButtons.Left)
			{
				this.SetDesktopLocation(mousePosX, mousePosY);
			}
		}
	}
}
