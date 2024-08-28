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
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace C_Chat
{
    public partial class Form1 : Form
    {
        private TcpClient Client;
        public StreamReader STR;
        public StreamWriter STW;
        public String Recieve;
        public String TextToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localİP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localİP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    Serverİptxt.Text = address.ToString();
                }
            }
        }

        private void ServerStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any,int.Parse(ServerPorttxt.Text));
            listener.Start();
            Client = listener.AcceptTcpClient();
            STR=new StreamReader(Client.GetStream());
            STW = new StreamWriter(Client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void ClientConnect_Click(object sender, EventArgs e)
        {
            Client = new TcpClient();
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse(Clientİptxt.Text),int.Parse(ClientPortTxt.Text));
            Client.Connect(ipend);

            try
            {
                ChatScreen.AppendText("Connect To Server " + "\r\n");
                STW =new StreamWriter(Client.GetStream());
                STR=new StreamReader(Client.GetStream());
                STW.AutoFlush=true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(Client.Connected) 
            {
                try
                {
                    Recieve=STR.ReadLine();
                    this.ChatScreen.Invoke(new MethodInvoker(delegate () { ChatScreen.AppendText("You:"+Recieve+"\r\n"); }));
                    Recieve = "";
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreen.Invoke(new MethodInvoker(delegate () { ChatScreen.AppendText("Me:" + TextToSend + "\n"); }));
            }
            else { MessageBox.Show("Sending Failed"); }
            backgroundWorker2.CancelAsync();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            if (MessageTXT.Text != "") 
            { 
                TextToSend = MessageTXT.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessageTXT.Text  = "";
        }
    }
}
