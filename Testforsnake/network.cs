using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Testforsnake
{
    internal class network
    {
        public void Client()
        {
            //CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //Send();
            //AddMessage(txtB_message.Text);
        }

        IPEndPoint IP;
        Socket client;


        //ket noi toi server
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9991);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Can't connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        //dong ket noi
        void Close()
        {
            client.Close();
        }

        //gui tin
        void Send()
        {
            //if (txtB_message.Text != string.Empty)
            //    client.Send(Serialize(txtB_message.Text));
        }

        //nhan tin
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }

        }


        void AddMessage(string s)
        {
            //lstV_message.Items.Add(new ListViewItem() { Text = s });
            //txtB_message.Clear();
        }

        // phan manh
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        //gom manh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
