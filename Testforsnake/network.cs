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
    internal class network
    {
        //private TcpClient tcpClient;
        //private StreamWriter sWriter;
        //private Thread clientthread;
        //private int svport = 8888;
        //private bool stopclient = true;
        
        //private void ClientRecv()
        //{
        //    StreamReader sr = new StreamReader(tcpClient.GetStream());
        //    try
        //    {
        //        while (!stopclient)
        //        {
        //            Application.DoEvents();
        //            string data = sr.ReadLine();
        //            //UpdateChatHistoryThreadSafe($"{data}\n");
        //        }
        //    }
        //    catch (SocketException)
        //    {
        //        tcpClient.Close();
        //        sr.Close();

        //    }
        //}
        
        //private delegate void SafeCallDelegate(string text);

        ////private void UpdateChatHistoryThreadSafe(string text)
        ////{
        ////    if (richTextBox1.InvokeRequired)
        ////    {
        ////        var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
        ////        richTextBox1.Invoke(d, new object[] { text });
        ////    }
        ////    else
        ////    {
        ////        richTextBox1.Text += text;
        ////    }
        ////}

        //private void sendinnw(object sender, EventArgs e)
        //{
        //    try

        //    {
        //        sWriter.WriteLine(Input.KeyPressed(Keys.A));
        //        //mess_txt.Text = "";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void connect_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        stopclient = false;

        //        this.tcpClient = new TcpClient();
        //        this.tcpClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), svport));
        //        this.sWriter = new StreamWriter(tcpClient.GetStream());
        //        this.sWriter.AutoFlush = true;
        //        sWriter.WriteLine(this.user_name_txt.Text);
        //        clientthread = new Thread(this.ClientRecv);
        //        clientthread.Start();
        //        richTextBox1.Text += "Connected\n";
        //    }
        //    catch (SocketException sockEx)
        //    {
        //        MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void clickk()
        //{
        //    try
        //    {
        //        stopclient = false;

        //        this.tcpClient = new TcpClient();
        //        this.tcpClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), svport));
        //        this.sWriter = new StreamWriter(tcpClient.GetStream())
        //        {
        //            AutoFlush = true
        //        };
        //        sWriter.WriteLine(this.user_name_txt.Text);
        //        clientthread = new Thread(this.clientrecivefile);
        //        clientthread.Start();
        //        MessageBox.Show("Connected");
        //    }
        //    catch (SocketException sockEx)
        //    {
        //        MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void press()
        //{
        //    try
        //    {
        //        stopclient = false;

        //        this.tcpClient = new TcpClient();
        //        this.tcpClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), svport));
        //        this.sWriter = new StreamWriter(tcpClient.GetStream());
        //        this.sWriter.AutoFlush = true;
        //        sWriter.WriteLine(this.user_name_txt.Text);
        //        clientthread = new Thread(this.ClientRecv);
        //        clientthread.Start();
        //        richTextBox1.Text += "Connected\n";
        //    }
        //    catch (SocketException sockEx)
        //    {
        //        MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
