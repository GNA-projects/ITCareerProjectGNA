using GDN_Toolbox.CustomControls.Tabs;
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

		private void ButtonHome_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabHome tabHome = new TabHome();
			tabHome.Parent = PanelCurrentTab;
			tabHome.Show();
		}

		private void ButtonFileSearcher_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabFileSearcher tabFileSearcher = new TabFileSearcher();
			tabFileSearcher.Parent = PanelCurrentTab;
			tabFileSearcher.Show();
		}
	}
}
