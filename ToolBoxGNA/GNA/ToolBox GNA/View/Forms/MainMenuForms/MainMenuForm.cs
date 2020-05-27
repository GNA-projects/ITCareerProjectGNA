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

		private void ButtonTempDeleter_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabTempDeleter tabTempDeleter = new TabTempDeleter
			{
				Parent = PanelCurrentTab
			};
			tabTempDeleter.Show();
		}

		private void ButtonSafeZone_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabSafeZone tabSafeZone = new TabSafeZone
			{
				Parent = PanelCurrentTab
			};
			tabSafeZone.Show();
		}

		private void ButtonConvertor_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabConvertor tabConvertor = new TabConvertor
			{
				Parent = PanelCurrentTab
			};
			tabConvertor.Show();
		}

		private void ButtonPasswordManager_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabPasswordManager tabPasswordManager = new TabPasswordManager
			{
				Parent = PanelCurrentTab
			};
			tabPasswordManager.Show();
		}

		private void ButtonWifiCheck_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabWifiChecker tabWifiChecker = new TabWifiChecker
			{
				Parent = PanelCurrentTab
			};
			tabWifiChecker.Show();
		}

		private void ButtonSupport_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabSupport tabSupport = new TabSupport
			{
				Parent = PanelCurrentTab
			};
			tabSupport.Show();
		}

		private void BtnDesktopChanger_Click(object sender, EventArgs e)
		{
			if (this.PanelCurrentTab.HasChildren)
			{
				this.PanelCurrentTab.GetChildAtPoint(new Point(0, 0)).Dispose();
			}
			TabDesktopChanger tabDesktopChanger = new TabDesktopChanger
			{
				Parent = PanelCurrentTab
			};
			tabDesktopChanger.Show();
		}

		private void MainMenuForm_Load(object sender, EventArgs e)
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
	}
}
