using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.View.CustomControls.Tabs;
using ToolBox_GNA.View.Forms.DesignForms;

namespace ToolBox_GNA.View.Forms.MainMenuForms
{
	public partial class MainMenuForm : DesignForm
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
			TabHome tabHome = new TabHome
			{
				Parent = PanelCurrentTab
			};
			tabHome.Show();
		}

		private void ButtonFileSearcher_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabFileSearcher tabFileSearcher = new TabFileSearcher
			{
				Parent = PanelCurrentTab
			};
			tabFileSearcher.Show();
		}
	}
}
