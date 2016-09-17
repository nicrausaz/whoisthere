using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoisthere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pingBtn_Click(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            string ipAddress = ipRequestBox.Text;
            Console.WriteLine(ipAddress);
            IPAddress address = IPAddress.Parse(ipAddress);
            Console.WriteLine(address);
            PingReply reply = pingSender.Send(address);
            if(reply.Status == IPStatus.Success){
                Console.WriteLine("Success");
                MessageBox.Show("Host ping has succeded", "Success");
            }else{
                Console.WriteLine(reply.Status);
                MessageBox.Show("Host Unreachable", "Failed");
            }
        }
    }
}

