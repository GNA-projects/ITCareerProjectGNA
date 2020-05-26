using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.View.CustomControls.Tabs.Design;
using DatabaseOperations;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabHome : ControlDesign
	{
		public TabHome()
		{
			InitializeComponent();
			usernameLabel.Text = CurrentUser.user.username;
		}
	}
}
