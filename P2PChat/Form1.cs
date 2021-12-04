using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace P2PChat
{
    public partial class Form1 : Form
    {
        Task client;
        Task server;
        bool stop = false;
        public Form1()
        {
            InitializeComponent();
            /*инициализируем сервер*/
        }

        private void createServerTSM_Click(object sender, EventArgs e)
        {
            server = new Task(createServer);
            server.Start();
           
        }
        private void connectToTSM_Click(object sender, EventArgs e)
        {
            client = new Task(connectToServer);
            client.Start();
        }
        private void disconnectTSM_Click(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {

        }
        private void createServer() 
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1598); // адрес сервера
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Bind(ipPoint);
                socket.Listen(10);

                this.Invoke(new MethodInvoker(() =>
                {
                    checkConnectionLbl.Text = "Локальный сервер запущен.";
                    checkConnectionLbl.ForeColor = Color.Red;
                }));
                this.Invoke(new MethodInvoker(() =>
                {
                    connectToTSM.Enabled = false;
                }));
                while (true)
                {
                    Socket handler = socket.Accept();
                    StringBuilder builder = new StringBuilder();
                    string message = "Welcome";
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    handler.Send(buffer);
                    byte[] data = new byte[256]; // буфер для ответа
                    int bytes = 0; // количество полученных байт
                    do
                    {
                        bytes = handler.Receive(data, data.Length, 0);
                        builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        chatTb.Text += "ответ сервера: " + builder.ToString();
                    }));
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                this.Invoke(new MethodInvoker(() =>
                {
                    checkConnectionLbl.Text = "Локальный сервер остановлен.";
                    checkConnectionLbl.ForeColor = Color.Red;
                }));
            }
            catch (Exception exc)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    checkConnectionLbl.Text = "исключение " + exc.ToString();
                    checkConnectionLbl.ForeColor = Color.Red;
                }));
            }
        }

        private void connectToServer() 
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1598); // адрес сервера
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socket.Connect(ipPoint);
                byte[] data = new byte[256]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт
                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                this.Invoke(new MethodInvoker(() =>
                {
                    chatTb.Text += "ответ сервера: " + builder.ToString();
                }));
                //recieveMessage(socket);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка " + exc.ToString());
            }
        }


    }
}
