using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.View.Forms.DesignForms;
using System.Diagnostics;

namespace ToolBox_GNA.View.CustomControls.Tabs.Design
{
	public partial class ControlDesign : UserControl
	{
		public ControlDesign()
		{
			InitializeComponent();
			using (DesignForm form = new DesignForm())
			{
				this.BackColor = form.BackColor;
			} 
		}
	}
}
