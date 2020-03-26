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
	public partial class HintUsernameBox : TextBox
	{
		public HintUsernameBox()
		{
			InitializeComponent();
			this.Text = "Username";
			this.ForeColor = Color.Gray;
		}
		public string Hint { get; set; } = "Username";

		protected override void OnClick(EventArgs e)
		{
				this.Text = "";
				this.ForeColor = Color.Black;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			if (this.Text == "")
			{				
				this.Text = Hint;
				this.ForeColor = Color.Gray;
			}
		}
	}
}
