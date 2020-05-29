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
using DatabaseOperations;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabSupport : ControlDesign
	{
		public TabSupport()
		{
			InitializeComponent();
		}

		private void TabSupport_Load(object sender, EventArgs e)
		{
			List<Users> allUsers = ChatServices.GetUsers();
			List<Users> admins = allUsers.Where(x => x.IsAdmin == true && x.id != CurrentUser.user.id).ToList();
			List<Users> nonAdmins = allUsers.Where(x => x.IsAdmin == false && x.id != CurrentUser.user.id).ToList();
			Users currentUser = allUsers.FirstOrDefault(x => x.id == CurrentUser.user.id);

			LbUsers.Items.Add(currentUser);
			LbUsers.Items.AddRange(admins.ToArray());
			LbUsers.Items.AddRange(nonAdmins.ToArray());
			LbUsers.DisplayMember = "username";

			LbUsers.SelectedIndex = 0;
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			ChatServices.SendMessage(TbMessage.Text, ((Users)LbUsers.SelectedItem).id);
			RtbChat.AppendText(DateTime.Now.ToString() + "  ");
			RtbChat.AppendText($"to {((Users)LbUsers.SelectedItem).username}" + "\r\n");
			RtbChat.AppendText($"{TbMessage.Text}" + "\r\n");
			TbMessage.Text = "";
			TbMessage.Focus();
		}

		private void TimerRefreshChat_Tick(object sender, EventArgs e)
		{
			int messageId = ChatServices.ReturnUnreadMessageId();
			if (messageId > 0)
			{
				ChatMessages message = ChatServices.ReturnMessage(messageId);
				RtbChat.AppendText(DateTime.Now.ToString() + "  ");
				RtbChat.AppendText($"from {ChatServices.GetUsers(message.sender_id)}" + "\r\n");
				RtbChat.AppendText($"{message.Message}" + "\r\n");
				ChatServices.SetFlagRead(messageId);
			}

		}

		private void TbMessage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnSend_Click(null,null);
			}
		}

		private void LbUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			RtbChat.Text = "";
			TimerRefreshChat.Stop();
			List<ChatMessages> chatMessages = ChatServices.ReturnReadMessages(((Users)LbUsers.SelectedItem).id);
			foreach (var message in chatMessages)
			{
				RtbChat.AppendText(DateTime.Now.ToString() + "  ");
				RtbChat.AppendText($"from {ChatServices.GetUsers(message.sender_id)}" + "\r\n");
				RtbChat.AppendText($"{message.Message}" + "\r\n");
			}
			TimerRefreshChat.Start();
		}
	}
}
