using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace ElderlyCareSystemV3_Server_
{
    public partial class ElderlyCareSystemServer : Form
    {
   
        public ElderlyCareSystemServer()
        {
            InitializeComponent();
        }

        int i;
        TcpListener server = new TcpListener(IPAddress.Any, 1980);
        NetworkStream stream;
        TcpClient client;
        byte[] datalength = new byte[4];
        string serverRcv = "";
      
    

        private void Button_Connect_Server_Click(object sender, EventArgs e)
        {
            Button_Connect_Server.Enabled = false;
            Button_Disconnect_Server.Enabled = true;
            server.Start();
            MessageBox.Show("Waiting For Connection");
            new Thread(() =>
            {
                client = server.AcceptTcpClient();
                MessageBox.Show("Connected To Client");
                if (client.Connected)
                {
                    ServerReceive();
                }
            }).Start();
        }

        public void ServerSend(string msg)
        {
            stream = client.GetStream();
            byte[] data;
            data = Encoding.Default.GetBytes(msg);
            int length = data.Length;
            byte[] datalength = new byte[4];
            datalength = BitConverter.GetBytes(length);
            stream.Write(datalength, 0, 4);
            stream.Write(data, 0, data.Length);
        }

        public void ServerReceive()
        {
            stream = client.GetStream();
            new Thread(() =>
            {
                while ((i = stream.Read(datalength, 0, 4)) != 0)
                {
                    byte[] data = new byte[BitConverter.ToInt32(datalength, 0)];
                    stream.Read(data, 0, data.Length);
                    this.Invoke((MethodInvoker)delegate
                    {
                        serverRcv = Encoding.Default.GetString(data);
                        Main(serverRcv, "Client-1");
                    });
                }
            }).Start();
        }

        public void Main(string msg, string clientId)
        {
            listBox3.Items.Add(msg);
            listBox2.Items.Add(DateTime.Now.ToString("HH:mm:ss tt"));
            listBox1.Items.Add(clientId);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
