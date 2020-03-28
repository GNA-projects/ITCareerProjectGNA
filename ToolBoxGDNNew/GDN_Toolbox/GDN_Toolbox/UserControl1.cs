using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDN_Toolbox
{
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			InitializeComponent();
			checkBox1.Checked = true;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
		}

		public CheckBox CheckBox1 { get => this.checkBox1; set => checkBox1 = value ; }
		public CheckBox CheckBox2 { get => this.checkBox2; set => checkBox2 = value ; }
		public CheckBox CheckBox3 { get => this.checkBox3; set => checkBox3 = value ; }
		public Button Button1 { get => this.button1; set => button1 = value ; }

	}
}
