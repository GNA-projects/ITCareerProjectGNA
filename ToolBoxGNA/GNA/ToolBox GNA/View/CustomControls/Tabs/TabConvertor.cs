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
using ConverterDemo.ControllerG.Convertor;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabConvertor : ControlDesign
	{
		public TabConvertor()
		{
			InitializeComponent();
		}

		private void BtnBrowseIn_Click(object sender, EventArgs e)
		{
			if (RbWordToPdf.Checked)
			{
				TbInput.Text = Convertor.GetFileInfo(true);
			}
			else
			{
				TbInput.Text = Convertor.GetFileInfo(false);
			}
		}

		private void BtnBrowseOut_Click(object sender, EventArgs e)
		{
			TbOutput.Text = Convertor.SetDestFilePath();
		}

		private void BtnConvert_Click(object sender, EventArgs e)
		{
			if (RbWordToPdf.Checked)
			{
				Convertor.DocumentToPDFConvertAsync(TbInput.Text, TbOutput.Text);
			}
			else if (RbToPng.Checked)
			{
				Convertor.ImageToPNGConvertAsync(TbInput.Text, TbOutput.Text);
			}
		}

	}
}
