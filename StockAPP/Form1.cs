using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace StockAPP
{
    public partial class Form1 : Form
    {
        private Socket socketServer;
        private Socket socketClient;
        Dictionary<string, Thread> T_server = new Dictionary<string, Thread>();
        Dictionary<string, Thread> T_client = new Dictionary<string, Thread>();
        Operator op = new Operator();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = op.GetIP();
        }
                              
        #region 服务端
        private void btnListen_Click(object sender, EventArgs e)
        {
            if (txtPort.Text == "")
            {
                MessageBox.Show("端口号不能为空！");
                return;
            }
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;                //创建对象端口
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                socketWatch.Bind(point);//绑定端口号
                socketWatch.Listen(10);//设置监听
                                       //创建监听线程
                Thread thread = new Thread(Listen);
                thread.IsBackground = true;
                thread.Start(socketWatch);
                btnListen.Text = "监听中";
                btnListen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Listen(object o)
        {
            try
            {
                Socket socketWatch = o as Socket;
                while (true)
                {
                    socketServer = socketWatch.Accept();//等待接收客户端连接
                    op.Show(this, socketServer.RemoteEndPoint.ToString() + "连接成功!");
                    btnStop.Enabled = true;
                    btnSend1.Enabled = true;
                    //开启一个新线程，执行接收消息方法
                    Thread r_thread = new Thread(Received);
                    r_thread.IsBackground = true;
                    r_thread.Start(socketServer);
                    T_server.Add(socketServer.RemoteEndPoint.ToString(), r_thread);
                }
            }
            catch { }
        }

        private void Received(object o)
        {
            try
            {
                Socket socketServer = o as Socket;
                IPList.Items.Add(socketServer.RemoteEndPoint);
                btnStop.Enabled = true;
                while (true)
                {
                    
                    //客户端连接服务器成功后，服务器接收客户端发送的消息
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    //实际接收到的有效字节数
                    int len = socketServer.Receive(buffer);
                    if (len == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, len);
                    AppendTorichTextBox(txtReceive1,socketServer.RemoteEndPoint,str);
                }
            }
            catch 
            {
                T_server[socketServer.RemoteEndPoint.ToString()].Abort();
            }
        }

        private void AppendTorichTextBox(RichTextBox rtb,EndPoint point,string content)
        {

            rtb.AppendText("\r");
            rtb.AppendText(point+":");
            rtb.AppendText("\r");
            rtb.AppendText(content);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            op.SendMsg(socketServer, txtWord1.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            socketServer.Close();
            btnSend1.Enabled = false;
            btnStop.Enabled = false;
            IPList.Items.Clear();
        }
        #endregion

        #region 客户端
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //创建客户端Socket，获得远程ip和端口号
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(IP.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Port.Text));

                socketClient.Connect(point);
                op.Show(this, "连接成功!");
                button1.Enabled = false;
                button2.Enabled = true;
                btnSend2.Enabled = true;

                //开启新的线程，不停的接收服务器发来的消息
                Thread c_thread = new Thread(Received1);
                c_thread.IsBackground = true;
                c_thread.Start();
                T_client.Add(socketClient.RemoteEndPoint.ToString(), c_thread);
            }
            catch (Exception)
            {
                MessageBox.Show("IP或者端口号错误...");
                return;
            }
        }

        private void Received1()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    //实际接收到的有效字节数
                    int len = socketClient.Receive(buffer);
                    if (len == 0)
                    {
                        continue;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, len);
                    AppendTorichTextBox(txtReceive2, socketClient.RemoteEndPoint, str);
                }
                catch(Exception ex)
                {
                    T_client[socketClient.RemoteEndPoint.ToString()].Abort();
                    return;
                }
            }

        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            op.SendMsg(socketClient, txtWord2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            socketClient.Close();
            op.Show(this,"断开连接!");
            button2.Enabled = false;
            button1.Enabled = true;
            btnSend2.Enabled = false;
        }
        #endregion
    }
}
