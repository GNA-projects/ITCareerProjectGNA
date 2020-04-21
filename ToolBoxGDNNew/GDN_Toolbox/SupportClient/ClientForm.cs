using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDN_Toolbox;

namespace SupportClient
{
	public partial class ClientForm : ProgramDesignForm
	{
		Socket _client;
		public ClientForm()
		{
			InitializeComponent();
			//Process.Start("C:\\Users\\GOGO\\Desktop\\ItKarieraProgram\\ITCareerProjectGDN\\ToolBoxGDNNew\\GDN_Toolbox\\SupportServer\\bin\\Debug\\SupportServer.exe");

		}

		private void ButtonConnect_Click(object sender, EventArgs e)
		{
			IPAddress iPAddress = IPAddress.Parse(textBox3.Text);
			_client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			_client.BeginConnect(new IPEndPoint(iPAddress,9999),ConnectHandler,_client);
		}

		private void ConnectHandler(IAsyncResult ar)
		{
			Socket client = (Socket)ar.AsyncState;
			client.EndConnect(ar);
		}

		private void SendHandler(IAsyncResult ar)
		{
			Socket client = (Socket)ar.AsyncState;
			client.EndSend(ar);
		}

		private void ButtonSend_Click(object sender, EventArgs e)
		{
			byte[] buffer = Encoding.ASCII.GetBytes($"{textBox2.Text} => {textBox1.Text}");
			textBox1.Text = "";
			_client.BeginSend(buffer,0,buffer.Length,SocketFlags.None,SendHandler,_client);
		}

	}
}
