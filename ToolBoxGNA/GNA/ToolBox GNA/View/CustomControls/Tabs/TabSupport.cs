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
using DatabaseOperations.Operations.ChatBuissness;
using DatabaseOperations.Model;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabSupport : ControlDesign
	{
		public TabSupport()
		{
			InitializeComponent();
			TimerRefreshChat.Start();
		}

		private void TabSupport_Load(object sender, EventArgs e)
		{
			LbUsers.Items.AddRange(ChatServices.GetUsers().ToArray());
			LbUsers.DisplayMember = "username";
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			ChatServices.SendMessage(TbMessage.Text, ((Users)LbUsers.SelectedItem).id);
			richTextBox1.AppendText(DateTime.Now.ToString() + "  ");
			richTextBox1.AppendText($"to {((Users)LbUsers.SelectedItem).username}" + "\r\n");
			richTextBox1.AppendText($"{TbMessage.Text}" + "\r\n");
		}

		private void TimerRefreshChat_Tick(object sender, EventArgs e)
		{
			int messageId = ChatServices.ReturnUnreadMessageId();
			if (messageId > 0)
			{
				ChatMessages message = ChatServices.ReturnMessage(messageId);
				richTextBox1.AppendText(DateTime.Now.ToString() + "  ");
				richTextBox1.AppendText($"from {ChatServices.GetUsers(message.sender_id)}" + "\r\n");
				richTextBox1.AppendText($"{message.Message}" + "\r\n");
				ChatServices.SetFlagRead(messageId);
			}

		}
	}
}
