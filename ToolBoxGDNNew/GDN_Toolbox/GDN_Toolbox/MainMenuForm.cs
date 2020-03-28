using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDN_Toolbox
{
	public partial class MainMenuForm : ProgramDesignForm
	{
		public MainMenuForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (panel1.HasChildren)
			{
				panel1.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			UserControl1 userControl1 = new UserControl1();
			userControl1.Parent = panel1;
			userControl1.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (panel1.HasChildren)
			{
				panel1.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			UserControl2 userControl2 = new UserControl2();
			userControl2.Parent = panel1;
			userControl2.Show();
		}
	}
}
