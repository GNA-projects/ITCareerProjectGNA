using GDN_Toolbox.GlobalVariables.MousePosition;
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
	public partial class MainDesignForm : Form
	{
		public MainDesignForm()
		{
			InitializeComponent();
			
		}

		private void PanelBorder_MouseMove(object sender, MouseEventArgs e)
		{
			if (MouseButtons.Left == e.Button)
			{
				int lastMousePosX = LastMousePosition.MousePosX;
				int lastMousePosY = LastMousePosition.MousePosY;
				int mousePositionX = MousePosition.X;
				int mousePositionY = MousePosition.Y;
				int Xminus = mousePositionX - LastMousePosition.MousePosX;
				int Yminus = mousePositionY - LastMousePosition.MousePosY;

				if (lastMousePosX != 0 && lastMousePosY != 0)
				{
					this.Left += Xminus;
					this.Top += Yminus;
				}
				LastMousePosition.MousePosX = mousePositionX;
				LastMousePosition.MousePosY = mousePositionY;

			}
			else
			{
				LastMousePosition.MousePosX = 0;
				LastMousePosition.MousePosY = 0;
			}
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void ButtonMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
