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

namespace SupportServer
{
	public partial class ServerForm : ProgramDesignForm
	{
		
		Socket _server;
		byte[] _buffer = new byte[1024];

		public ServerForm()
		{
			InitializeComponent();
			Server_Start();
			//Process.Start("C:\\Users\\GOGO\\Desktop\\ItKarieraProgram\\ITCareerProjectGDN\\ToolBoxGDNNew\\GDN_Toolbox\\SupportClient\\bin\\Debug\\SupportClient.exe");
		}



		public void Server_Start()
		{
			IPAddress iPAddress = Dns.GetHostAddresses(Dns.GetHostName()).ToList().Where(x => x.AddressFamily == AddressFamily.InterNetwork).ToList().First();
			string ip = iPAddress.ToString();
			label1.Text = ip;
			_server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
			_server.Bind(new IPEndPoint(iPAddress, 9999));
			_server.Listen(500);
			AcceptConnection();
		}

		private void AcceptConnection()
		{
			_server.BeginAccept(AcceptHandler, _server);
		}

		private void AcceptHandler(IAsyncResult ar)
		{
			AcceptConnection();
			Socket server = (Socket)ar.AsyncState;
			Socket client = server.EndAccept(ar);
			_buffer = new byte[client.ReceiveBufferSize];
			client.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceiveHandler, client);
		}

		private void ReceiveHandler(IAsyncResult ar)
		{
			Socket client = (Socket)ar.AsyncState;
			int size = client.EndReceive(ar);
			Array.Resize(ref _buffer, size);
			AppendText(Encoding.ASCII.GetString(_buffer) + "\r\n");
			Array.Resize(ref _buffer, 1024);
			client.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceiveHandler, client);
		}

		private void AppendText(string text)
		{
			MethodInvoker invoker = new MethodInvoker(delegate{TextBoxChat.Text += text ;});
			this.Invoke(invoker);
		}
	}
}
