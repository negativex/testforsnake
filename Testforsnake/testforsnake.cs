using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Snake;

namespace Testforsnake
{
    public partial class testforsnake : Form
    {
        private TcpClient tcpClient;
        private StreamWriter sWriter;
        private Thread clientthread;
        private int svport = 8888;
        private bool stopclient = true;
        public int en = 1;
        string user_name_ = "Pseudo";
        //public ListViewItem list = new ListViewItem("item1", 0);
        public testforsnake()
        {
            InitializeComponent();
        }

        

        private void testforsnake_Load(object sender, EventArgs e)
        {
            //listView1.Items.Add("Pressed A\n");
            
            
        }
        private void send(object sender, EventArgs e)
        {


            if (Input.KeyPressed(Keys.A) && en ==1) { listView1.Items.Add("Pressed A\n"); en = 0; }
            if (Input.KeyPressed(Keys.D) && en == 0) { listView1.Items.Add("Pressed D \n"); en = 1; }
            
        }
        

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        

        private void ClientRecv()
        {
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            try
            {
                while (!stopclient)
                {
                    Application.DoEvents();
                    string data = sr.ReadLine();
                    //UpdateChatHistoryThreadSafe($"{data}\n");
                }
            }
            catch (SocketException)
            {
                tcpClient.Close();
                sr.Close();

            }
        }

        private delegate void SafeCallDelegate(string text);

        
        private void sendinnw(object sender, EventArgs e)
        {
            try

            {
                if (Input.KeyPressed(Keys.A) && en != 1) { sWriter.WriteLine('A'); en = 1; }
                else if (Input.KeyPressed(Keys.D) && en != 2) { sWriter.WriteLine('D'); en = 2; }
                else if (Input.KeyPressed(Keys.S) && en != 3) { sWriter.WriteLine('S'); en = 3; }
                else if (Input.KeyPressed(Keys.W) && en != 4) { sWriter.WriteLine('W'); en = 4; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stopclient = false;

                this.tcpClient = new TcpClient();
                this.tcpClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), svport));
                this.sWriter = new StreamWriter(tcpClient.GetStream());
                this.sWriter.AutoFlush = true;
                sWriter.WriteLine(this.user_name_);
                clientthread = new Thread(this.ClientRecv);
                clientthread.Start();
                timer1.Interval = 10;
                timer1.Tick += sendinnw;
                timer1.Start();
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
